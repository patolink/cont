Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System
' The authors disclaims copyright of this project. Use at your own risk.
' For bugs report, feature request, discussions, supports, please visit:
' http://mysqlbackupnet.codeplex.com/


Namespace MySql.Data.MySqlClient
    Public Class Methods
        Public Function GetCreateTableSql(table As String, cmd As MySqlCommand) As String
            cmd.CommandText = "SHOW CREATE TABLE `" + table + "`;"
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            da = Nothing

            Dim createSql As String = ""
            Dim ob As Object = dt.Rows(0)(1)

            If TypeOf ob Is System.String Then
                createSql = ob + ""
                ' It has been reported that, in some unknown cases, the query will return
                ' byte array.
                ' Report: http://www.codeproject.com/Messages/4450086/Small-changes-in-Code.aspx
            ElseIf TypeOf ob Is System.Byte() Then
                Dim enc As New System.Text.UTF8Encoding()
                createSql = enc.GetString(CType(ob, Byte()))
            End If

            Return createSql.Replace("CREATE TABLE", "CREATE TABLE IF NOT EXISTS").Replace(vbLf, vbCrLf) + ";"

        End Function

        Public Function GetCreateDatabaseSql(cmd As MySqlCommand) As String
            cmd.CommandText = "SELECT DATABASE();"
            Dim databaseName As String = cmd.ExecuteScalar().ToString()
            cmd.CommandText = "SHOW CREATE DATABASE `" + databaseName + "`;"
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            da = Nothing
            Return dt.Rows(0)(1).ToString().Replace("CREATE DATABASE", "CREATE DATABASE IF NOT EXISTS") + ";"
        End Function

        Public Function GetTotalRowsInTables(tableNames As String(), ByRef cmd As MySqlCommand) As Dictionary(Of String, Long)
            Dim dic As New Dictionary(Of String, Long)()
            For Each s As String In tableNames
                dic.Add(s, GetTotalRowsInTable(s, cmd))
            Next
            Return dic
        End Function

        Public Function GetTotalRowsInTable(tableName As String, cmd As MySqlCommand) As Long
            cmd.CommandText = "SELECT COUNT(*) FROM `" + tableName + "`;"
            Return CType(cmd.ExecuteScalar(), Long)
        End Function

        Public Function GetColumnNames(table As String, cmd As MySqlCommand) As String()
            cmd.CommandText = "SHOW COLUMNS FROM `" + table + "`;"
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            da = Nothing
            Dim sa As String() = New String(dt.Rows.Count) {}
            Dim count As Integer = -1
            For Each dr As DataRow In dt.Rows
                count += 1

                sa(count) = dr(0).ToString()
            Next
            Return sa
        End Function

        Public Function GetTableNames(ByRef cmd As MySqlCommand) As String()
            cmd.CommandText = "SHOW FULL TABLES WHERE Table_type LIKE 'BASE TABLE';"
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            da = Nothing
            Dim sa As String() = New String(dt.Rows.Count) {}
            Dim count As Integer = -1

            For Each dr As DataRow In dt.Rows
                count += 1
                sa(count) = dr(0) + ""
            Next

            Return sa
        End Function

        Public Function GetServerVersion(ByRef cmd As MySqlCommand, ByRef version As String) As String
            cmd.CommandText = "SHOW variables WHERE Variable_name = 'version';"
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            version = dt.Rows(0)(1).ToString()
            cmd.CommandText = "SHOW variables WHERE Variable_name = 'version_comment';"
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            Return version + " " + dt.Rows(0)(1).ToString()
        End Function

        Public Function GetServerMaxAllowedPacket(ByRef cmd As MySqlCommand) As Long
            cmd.CommandText = "SHOW variables WHERE Variable_name = 'max_allowed_packet';"
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return Convert.ToInt64(dt.Rows(0)(1))
        End Function

        Public Function GetDatabaseName(ConnectionString As String) As String
            Dim sa As String() = ConnectionString.Split(";"c)
            For Each s As String In sa
                If s.ToLower().StartsWith("database") Then
                    Dim sb As String() = s.Split("="c)
                    Return sb(1)
                End If
                If s.ToLower().StartsWith("initial catalog") Then
                    Dim sb As String() = s.Split("="c)
                    Return sb(1)
                End If
            Next
            Throw New Exception("Database Name is not detected in Connection String.")
        End Function

        Public Function GetBLOBSqlDataStringFromBytes(ba As Byte()) As String
            ' Method 1 (slower)
            'return "0x"+ BitConverter.ToString(bytes).Replace("-", string.Empty);

            ' Method 2 (faster)
            Dim c As Char() = New Char(ba.Length * 2 + 2) {}
            Dim b As Byte
            c(0) = "0"c
            c(1) = "x"c
            Dim y As Integer = 0, x As Integer = 2
            While y < ba.Length
                b = (CType((ba(y) >> 4), Byte))
                c(x) = CType(ChrW((If(b > 9, b + &H37, b + &H30))), Char)
                b = (CType((ba(y) And &HF), Byte))
                c(System.Threading.Interlocked.Increment(x)) = CType(ChrW((If(b > 9, b + &H37, b + &H30))), Char)
                System.Threading.Interlocked.Increment(y)
                System.Threading.Interlocked.Increment(x)
            End While
            Return New String(c)
        End Function

        Public Function EncryptWithSalt(input As String, key As String, saltSize As Integer) As String
            Dim salt As String = RandomString(saltSize)
            Return salt + AES_Encrypt(input, key + salt)
        End Function

        Public Function DecryptWithSalt(input As String, key As String, saltSize As Integer) As String
            Try
                Dim salt As String = input.Substring(0, saltSize)
                Dim data As String = input.Substring(saltSize)
                Return AES_Decrypt(data, key + salt)
            Catch
                Dim a As String = input
                Throw New Exception("Invalid Key.")
            End Try
        End Function

        Public random As New Random(CType(DateTime.Now.Ticks, Integer))

        Public Function RandomString(size As Integer) As String
            Dim sb As New StringBuilder()
            Dim ch As Char
            Dim i As Integer = 0
            While i < size
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)))
                sb.Append(ch)
                i += 1
            End While

            Return AES_Encrypt(sb.ToString(), random.[Next](1, 1000000).ToString()).Substring(0, size)
        End Function

        Public Function GetSaltSize(key As String) As Integer
            Dim a As Integer = key.GetHashCode()
            Dim b As String = Convert.ToString(a)
            Dim ca As Char() = b.ToCharArray()
            Dim c As Integer = 0
            For Each cc As Char In ca
                If Char.IsNumber(cc) Then
                    c += Convert.ToInt32(cc.ToString())
                End If
            Next
            Return c
        End Function

        Public Function Sha1Hash(input As String) As String
            Dim sha As New SHA1CryptoServiceProvider()
            Dim ba As Byte() = Encoding.UTF8.GetBytes(input)
            Dim ba2 As Byte() = sha.ComputeHash(ba)
            Return BitConverter.ToString(ba2).Replace("-", String.Empty).ToLower()
        End Function

        Public Function Sha2Hash(input As String) As String
            Dim ba As Byte() = Encoding.UTF8.GetBytes(input)
            Return Sha2Hash(ba)
        End Function

        Public Function Sha2Hash(ba As Byte()) As String
            Dim sha2 As New SHA256Managed()
            Dim ba2 As Byte() = sha2.ComputeHash(ba)
            Return BitConverter.ToString(ba2).Replace("-", String.Empty).ToLower()
        End Function

        Public Function AES_Encrypt(input As String, password As String) As String
            Dim clearBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(input)
            Dim pdb As New PasswordDeriveBytes(password, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
                &H65, &H64, &H76, &H65, &H64, &H65, _
                &H76})
            Dim encryptedData As Byte() = AES_Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16))
            Return Convert.ToBase64String(encryptedData)
        End Function

        Public Function AES_Decrypt(input As String, password As String) As String
            Dim cipherBytes As Byte() = Convert.FromBase64String(input)
            Dim pdb As New PasswordDeriveBytes(password, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
                &H65, &H64, &H76, &H65, &H64, &H65, _
                &H76})
            Dim decryptedData As Byte() = AES_Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16))
            Return System.Text.Encoding.UTF8.GetString(decryptedData)
        End Function

        Private Shared Function AES_Encrypt(clearData As Byte(), Key As Byte(), IV As Byte()) As Byte()
            Dim ms As New MemoryStream()
            Dim alg As Rijndael = Rijndael.Create()
            alg.Key = Key
            alg.IV = IV
            Dim cs As New CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write)
            cs.Write(clearData, 0, clearData.Length)
            cs.Close()
            Dim encryptedData As Byte() = ms.ToArray()
            Return encryptedData
        End Function

        Private Shared Function AES_Decrypt(cipherData As Byte(), Key As Byte(), IV As Byte()) As Byte()
            Dim ms As New MemoryStream()
            Dim alg As Rijndael = Rijndael.Create()
            alg.Key = Key
            alg.IV = IV
            Dim cs As New CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write)
            cs.Write(cipherData, 0, cipherData.Length)
            cs.Close()
            Dim decryptedData As Byte() = ms.ToArray()
            Return decryptedData
        End Function
    End Class
End Namespace