<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.Data = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataWargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataRtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KegiatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaKegiatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Data.SuspendLayout()
        Me.SuspendLayout()
        '
        'Data
        '
        Me.Data.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.KegiatanToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.Data.Location = New System.Drawing.Point(0, 0)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(827, 29)
        Me.Data.TabIndex = 0
        Me.Data.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataWargaToolStripMenuItem, Me.DataRtToolStripMenuItem})
        Me.DataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataWargaToolStripMenuItem
        '
        Me.DataWargaToolStripMenuItem.Name = "DataWargaToolStripMenuItem"
        Me.DataWargaToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.DataWargaToolStripMenuItem.Text = "Data Warga"
        '
        'DataRtToolStripMenuItem
        '
        Me.DataRtToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataRtToolStripMenuItem.Name = "DataRtToolStripMenuItem"
        Me.DataRtToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.DataRtToolStripMenuItem.Text = "Data RT"
        '
        'KegiatanToolStripMenuItem
        '
        Me.KegiatanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendaKegiatanToolStripMenuItem})
        Me.KegiatanToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KegiatanToolStripMenuItem.Name = "KegiatanToolStripMenuItem"
        Me.KegiatanToolStripMenuItem.Size = New System.Drawing.Size(82, 25)
        Me.KegiatanToolStripMenuItem.Text = "Kegiatan"
        '
        'AgendaKegiatanToolStripMenuItem
        '
        Me.AgendaKegiatanToolStripMenuItem.Name = "AgendaKegiatanToolStripMenuItem"
        Me.AgendaKegiatanToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.AgendaKegiatanToolStripMenuItem.Text = "Agenda Kegiatan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.TentangToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(66, 25)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(827, 487)
        Me.Controls.Add(Me.Data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.Data
        Me.Name = "MenuUtama"
        Me.Text = "Menu Utama"
        Me.Data.ResumeLayout(False)
        Me.Data.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataWargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataRtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KegiatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgendaKegiatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
