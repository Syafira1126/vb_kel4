Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub DataBukuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem1.Click
        Data_Buku.Show()
        Data_Buku.MdiParent = Me

    End Sub

    Private Sub PinjamBukuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinjamBukuToolStripMenuItem1.Click

    End Sub
End Class
