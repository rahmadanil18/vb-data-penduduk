Imports MySql.Data.MySqlClient

Module Module_Data_Warga
    Public Str As String = "server=localhost;user=root;database=db_warga"
    Public con As New MySqlConnection(Str)
    Public cmd As MySqlCommand
    Public adp As MySqlDataAdapter
    Public Read As MySqlDataReader

    Public Function koneksi() As MySqlConnection
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Error", MsgBoxStyle.Critical, "Connection")
        End Try
        Return con
    End Function

    'fungsi untuk data warga'

    Public Function Data() As DataTable

        Dim tbl As New DataTable
        Dim cek As String = "select * from tb_warga"
        Try
            adp = New MySqlDataAdapter(cek, koneksi)
            adp.Fill(tbl)
        Catch ex As Exception
            MsgBox("Tampilkan Data Error!", MsgBoxStyle.Critical, "Error!")
        End Try
        Return tbl
    End Function

    'fungsi untuk tambah data warga'

    Sub insertdata(ByVal nik As String, ByVal nama As String, ByVal tgl As String, ByVal jk As String, ByVal rt As String)
        Dim query As String = "insert into tb_warga values(@NIK,@NAMA,@TANGGAL_LAHIR,@JK,@RT)"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@NIK", MySqlDbType.VarChar).Value = nik
            cmd.Parameters.Add("@NAMA", MySqlDbType.VarChar).Value = nama
            cmd.Parameters.Add("@TANGGAL_LAHIR", MySqlDbType.VarChar).Value = tgl
            cmd.Parameters.Add("@JK", MySqlDbType.VarChar).Value = jk
            cmd.Parameters.Add("@RT", MySqlDbType.VarChar).Value = rt
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "DATA WARGA")
        Catch ex As Exception
            MsgBox("insert Error", MsgBoxStyle.Critical, "Insert Error!")
        End Try

    End Sub

    'fungsi untuk hapus data warga'
    Public Function deletedata(ByVal nik As String) As Boolean
        Dim cek = False
        Dim query As String = "delete from tb_warga where NIK  = @NIK"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@NIK", MySqlDbType.VarChar).Value = nik
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", MsgBoxStyle.Information, "DATA WARGA")
            cek = True
        Catch ex As Exception
            MsgBox("Delete Data Error!", MsgBoxStyle.Critical, "Delete Error")
        End Try

        Return cek
    End Function

    'fungsi untuk edit data warga'
    Public Function Updatedata(ByVal nik As String, ByVal nama As String, ByVal tgl As String, ByVal jk As String, ByVal rt As String) As Boolean
        Dim cek = False
        Dim query As String = "update tb_warga set NIK=@NIK, NAMA=@NAMA,TANGGAL_LAHIR=@TANGGAL_LAHIR,JK=@JK,RT=@RT where NIK='" & nik & "'"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@NIK", MySqlDbType.VarChar).Value = nik
            cmd.Parameters.Add("@NAMA", MySqlDbType.VarChar).Value = nama
            cmd.Parameters.Add("@TANGGAL_LAHIR", MySqlDbType.VarChar).Value = tgl
            cmd.Parameters.Add("@JK", MySqlDbType.VarChar).Value = jk
            cmd.Parameters.Add("@RT", MySqlDbType.VarChar).Value = rt
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Diupdate", MsgBoxStyle.Information, "DATA WARGA")
            cek = True
        Catch ex As Exception
            MsgBox("Update Data Error", MsgBoxStyle.Critical, "Update Error!")
        End Try
        Return cek
    End Function
End Module
