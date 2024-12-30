Public Class connexion



    Private Sub connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'GMAODataSet.Personnel'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.PersonnelTableAdapter.Fill(Me.GMAODataSet.Personnel)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Mot_de_PasseTextBox.Text = TextBox1.Text Then
            Form1.Show()
            Form1.ToolStripStatusMat.Text = MatriculeTextBox.Text
            Form1.ToolStripStatusNom.Text = NomTextBox.Text + " " + PrenomTextBox.Text
            Form1.ToolStripStatusspec.Text = SpecialiteTextBox.Text
            '  Form1.ToolStripStatusspec.Text = Form1.SpecialiteTextBox.Text
            ' Form1.ToolStripStatusNom.Text = Form1.NomPrenomTextBox.Text
            Form1.Enabled = True
            Me.Close()
            Form1.Label1.Visible = True
            Form1.PictureBox2.Visible = True
        Else
            MsgBox(" mot de passe invalide", vbCritical)
        End If

    End Sub

    Private Sub MatriculeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriculeTextBox.TextChanged
        On Error Resume Next
        Me.PersonnelTableAdapter.Fill_mat(Me.GMAODataSet.Personnel, MatriculeTextBox.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Close()
        Me.Close()
    End Sub

   


End Class