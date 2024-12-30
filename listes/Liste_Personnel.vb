Public Class Liste_Personnel

    Private Sub Liste_Personnel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.PictureBox2.Visible = True
        Form1.Label1.Visible = True
    End Sub

    Private Sub Liste_Personnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'GMAODataSet.Personnel'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PersonnelTableAdapter.Fill(Me.GMAODataSet.Personnel)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Personnel.Show()
            Fiche_Personnel.PersonnelBindingSource.AddNew()
            Fiche_Personnel.Button2.Enabled = False
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            Fiche_Personnel.PersonnelTableAdapter.DeleteQuery(selectedRow.Cells("MatriculeDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.PersonnelTableAdapter.Fill(Me.GMAODataSet.Personnel)
        Me.PersonnelDataGridView.Update()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fiche_Personnel.Show()
        Fiche_Personnel.Button2.Enabled = True
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            'Fiche_Machine.Code_MachineTextBox.Text = selectedRow.Cells("CodeMachineDataGridViewTextBoxColumn").Value.ToString()
            'Fiche_Machine.ID_ImmoTextBox.Text = selectedRow.Cells("IDImmoDataGridViewTextBoxColumn").Value.ToString()
            'Fiche_Machine.DesignationTextBox.Text = selectedRow.Cells("DesignationDataGridViewTextBoxColumn").Value.ToString()
            'Fiche_Machine.EmplacementTextBox.Text = selectedRow.Cells("EmplacementDataGridViewTextBoxColumn").Value.ToString()

            ' Active les zones de texte pour permettre à l'utilisateur de les modifier

            Fiche_Personnel.PersonnelBindingSource.CancelEdit()
            Fiche_Personnel.PersonnelTableAdapter.Fill_mat(Fiche_Personnel.GMAODataSet.Personnel, selectedRow.Cells("MatriculeDataGridViewTextBoxColumn").Value.ToString())
        End If
    End Sub
End Class