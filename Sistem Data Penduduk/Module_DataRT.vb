Imports MySql.Data.MySqlClient

Module Module_DataRT
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

    'fungsi untuk data RT'

    Public Function valueRT() As DataTable

        Dim tbl As New DataTable
        Dim cek As String = "select * from tb_rt"
        Try
            adp = New MySqlDataAdapter(cek, koneksi)
            adp.Fill(tbl)
        Catch ex As Exception
            MsgBox("Tampilkan Data Error!", MsgBoxStyle.Critical, "Error!")
        End Try
        Return tbl
    End Function


    'fungsi untuk tambah data rt'

    Sub insertdataRT(ByVal noRT As String, ByVal nama As String, ByVal nik As String, ByVal tgl As String, ByVal jk As String)
        Dim query As String = "insert into tb_rt values(@RT,@NAMA,@NIK,@TANGGAL_LAHIR,@JK)"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@RT", MySqlDbType.VarChar).Value = noRT
            cmd.Parameters.Add("@NAMA", MySqlDbType.VarChar).Value = nama
            cmd.Parameters.Add("@NIK", MySqlDbType.VarChar).Value = nik
            cmd.Parameters.Add("@TANGGAL_LAHIR", MySqlDbType.VarChar).Value = tgl
            cmd.Parameters.Add("@JK", MySqlDbType.VarChar).Value = jk
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "DATA RT")
        Catch ex As Exception
            MsgBox("insert Error", MsgBoxStyle.Critical, "Insert Error!")
        End Try
    End Sub

    'HAPUS DATA RT'
    Public Function deletedataRT(ByVal noRT As String) As Boolean
        Dim cek = False
        Dim query As String = "delete from tb_rt where RT  = @RT"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@RT", MySqlDbType.VarChar).Value = noRT
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", MsgBoxStyle.Information, "DATA RT")
            cek = True
        Catch ex As Exception
            MsgBox("Delete Data Error!", MsgBoxStyle.Critical, "Delete Error")
        End Try
        Return cek
    End Function

    'edit data'

    Public Function UpdatedataRT(ByVal noRT As String, ByVal nama As String, ByVal nik As String, ByVal tgl As String, ByVal JK As String) As Boolean
        Dim cek = False
        Dim query As String = "update tb_rt set RT=@RT, NAMA=@NAMA,NIK=@NIK,TANGGAL_LAHIR=@TANGGAL_LAHIR,JK=@JK where RT='" & noRT & "'"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@RT", MySqlDbType.VarChar).Value = noRT
            cmd.Parameters.Add("@NAMA", MySqlDbType.VarChar).Value = nama
            cmd.Parameters.Add("@NIK", MySqlDbType.VarChar).Value = nik
            cmd.Parameters.Add("@TANGGAL_LAHIR", MySqlDbType.VarChar).Value = tgl
            cmd.Parameters.Add("@JK", MySqlDbType.VarChar).Value = jk
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Diupdate", MsgBoxStyle.Information, "DATA RT")
            cek = True
        Catch ex As Exception
            MsgBox("Update Data Error", MsgBoxStyle.Critical, "Update Error!")
        End Try
        Return cek
    End Function

End Module
