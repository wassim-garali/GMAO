Public Class Fiche_Article_Bon_Sortie





    Private Sub Fiche_Article_Bon_Sortie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Sortie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_SortieTableAdapter.Fill(Me.DataSet_Stock.Bon_Sortie)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Sortie_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_Sortie_LigneTableAdapter.Fill(Me.DataSet_Stock.Bon_Sortie_Ligne)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.Bon_SortieBindingSource.EndEdit()
        Me.Bon_SortieTableAdapter.Update(Me.DataSet_Stock.Bon_Sortie)

        Me.BonSortieLigneBindingSource.EndEdit()
        Me.Bon_Sortie_LigneTableAdapter.Update(Me.DataSet_Stock.Bon_Sortie_Ligne)
        

        '  Me.PictureBox1.Update()

        MsgBox("OK")
        Liste_Article_Bon_Sortie.Bon_SortieTableAdapter.Fill(Liste_Article_Bon_Sortie.DataSet_Stock.Bon_Sortie)
        Liste_Article_Bon_Sortie.PersonnelDataGridView.Update()

        Me.Close()
    End Sub

    Private Sub PersonnelDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles PersonnelDataGridView.RowsAdded
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("code_article").Value = N_Bon_sortieTextBox.Text
    End Sub

    Private Sub PersonnelDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles PersonnelDataGridView.RowValidating
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("code_article").Value = N_Bon_sortieTextBox.Text
    End Sub
End Class