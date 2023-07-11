<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinjamBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinjamBukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataBukuToolStripMenuItem, Me.DataAnggotaToolStripMenuItem, Me.PinjamBukuToolStripMenuItem, Me.DataBukuToolStripMenuItem1, Me.PinjamBukuToolStripMenuItem1, Me.RiwayatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Image = CType(resources.GetObject("LOGINToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Image = CType(resources.GetObject("LOGOUTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Image = CType(resources.GetObject("EXITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DataBukuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DataBukuToolStripMenuItem.Image = CType(resources.GetObject("DataBukuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(108, 23)
        Me.DataBukuToolStripMenuItem.Text = "Data Users"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DataAnggotaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DataAnggotaToolStripMenuItem.Image = CType(resources.GetObject("DataAnggotaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(130, 23)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Anggota"
        '
        'PinjamBukuToolStripMenuItem
        '
        Me.PinjamBukuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PinjamBukuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PinjamBukuToolStripMenuItem.Image = CType(resources.GetObject("PinjamBukuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PinjamBukuToolStripMenuItem.Name = "PinjamBukuToolStripMenuItem"
        Me.PinjamBukuToolStripMenuItem.Size = New System.Drawing.Size(151, 23)
        Me.PinjamBukuToolStripMenuItem.Text = "Data Pengunjung"
        '
        'DataBukuToolStripMenuItem1
        '
        Me.DataBukuToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DataBukuToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DataBukuToolStripMenuItem1.Image = CType(resources.GetObject("DataBukuToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DataBukuToolStripMenuItem1.Name = "DataBukuToolStripMenuItem1"
        Me.DataBukuToolStripMenuItem1.Size = New System.Drawing.Size(105, 23)
        Me.DataBukuToolStripMenuItem1.Text = "Data Buku"
        '
        'PinjamBukuToolStripMenuItem1
        '
        Me.PinjamBukuToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PinjamBukuToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PinjamBukuToolStripMenuItem1.Image = CType(resources.GetObject("PinjamBukuToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PinjamBukuToolStripMenuItem1.Name = "PinjamBukuToolStripMenuItem1"
        Me.PinjamBukuToolStripMenuItem1.Size = New System.Drawing.Size(120, 23)
        Me.PinjamBukuToolStripMenuItem1.Text = "Pinjam Buku"
        '
        'RiwayatToolStripMenuItem
        '
        Me.RiwayatToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RiwayatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RiwayatToolStripMenuItem.Image = CType(resources.GetObject("RiwayatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RiwayatToolStripMenuItem.Name = "RiwayatToolStripMenuItem"
        Me.RiwayatToolStripMenuItem.Size = New System.Drawing.Size(90, 23)
        Me.RiwayatToolStripMenuItem.Text = "Riwayat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(833, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanggal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(905, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Waktu :"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 447)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinjamBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PinjamBukuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RiwayatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
