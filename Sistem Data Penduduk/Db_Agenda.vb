Imports MySql.Data.MySqlClient

Module Db_Agenda

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

    'fungsi untuk data agenda'

    Public Function valueAgenda() As DataTable

        Dim tbl As New DataTable
        Dim cek As String = "select * from tb_agenda"
        Try
            adp = New MySqlDataAdapter(cek, koneksi)
            adp.Fill(tbl)
        Catch ex As Exception
            MsgBox("Tampilkan Data Error!", MsgBoxStyle.Critical, "Error!")
        End Try
        Return tbl
    End Function

    'tambah data'
    Sub insertdataAgenda(ByVal id As String, ByVal agenda As String, ByVal tgl As String, ByVal tmpt As String)
        Dim query As String = "insert into tb_agenda values(@id_AGENDA,@AGENDA,@TANGGAL,@TEMPAT)"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@id_AGENDA", MySqlDbType.VarChar).Value = id
            cmd.Parameters.Add("@AGENDA", MySqlDbType.VarChar).Value = agenda
            cmd.Parameters.Add("@TANGGAL", MySqlDbType.VarChar).Value = tgl
            cmd.Parameters.Add("@TEMPAT", MySqlDbType.VarChar).Value = tmpt
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "DATA AGENDA")
        Catch ex As Exception
            MsgBox("insert Error", MsgBoxStyle.Critical, "Insert Error!")
        End Try
    End Sub

    'HAPUS DATA AGENDA'
    Public Function deleteAgenda(ByVal id As String) As Boolean
        Dim cek = False
        Dim query As String = "delete from tb_agenda where id_AGENDA = @id_AGENDA"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@id_AGENDA", MySqlDbType.VarChar).Value = id
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Dihapus", MsgBoxStyle.Information, "DATA AGENDA")
            cek = True
        Catch ex As Exception
            MsgBox("Delete Data Error!", MsgBoxStyle.Critical, "Delete Error")
        End Try
        Return cek
    End Function

    'Edit Data Agenda'

    Public Function UpdateAgenda(ByVal id As String, ByVal agenda As String, ByVal tgl As String, ByVal tmpt As String) As Boolean
        Dim cek = False
        Dim query As String = "update tb_agenda set id_AGENDA=@id_AGENDA, AGENDA=@AGENDA,TANGGAL=@TANGGAL,TEMPAT=@TEMPAT where id_AGENDA='" & id & "'"
        Try
            cmd = New MySqlCommand(query, koneksi)
            cmd.Parameters.Add("@id_AGENDA", MySqlDbType.VarChar).Value = id
            cmd.Parameters.Add("@AGENDA", MySqlDbType.VarChar).Value = agenda
            cmd.Parameters.Add("@TANGGAL", MySqlDbType.VarChar).Value = tgl
            cmd.Parameters.Add("@TEMPAT", MySqlDbType.VarChar).Value = tmpt
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Diupdate", MsgBoxStyle.Information, "DATA AGENDA")
            cek = True
        Catch ex As Exception
            MsgBox("Update Data Error", MsgBoxStyle.Critical, "Update Error!")
        End Try
        Return cek
    End Function

End Module
