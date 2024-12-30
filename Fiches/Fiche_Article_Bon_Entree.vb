Public Class Fiche_Article_Bon_entree

    Private Sub Fiche_Article_Bon_entree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Entree_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.Bon_Entree_LigneTableAdapter.Fill(Me.DataSet_Stock.Bon_Entree_Ligne)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '  Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Entree'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '  Me.Bon_EntreeTableAdapter.Fill(Me.DataSet_Stock.Bon_Entree)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Entree_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '  Me.Bon_Entree_LigneTableAdapter.Fill(Me.DataSet_Stock.Bon_Entree_Ligne)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.Bon_EntreeBindingSource.EndEdit()
        Me.Bon_EntreeTableAdapter.Update(Me.DataSet_Stock.Bon_Entree)

        Me.BonEntreeLigneBindingSource.EndEdit()
        Me.Bon_Entree_LigneTableAdapter.Update(Me.DataSet_Stock.Bon_Entree_Ligne)

        '  Me.PictureBox1.Update()

        MsgBox("OK")
        Liste_Article_Bon_Entree.Bon_EntreeTableAdapter.Fill(Liste_Article_Bon_Entree.DataSet_Stock.Bon_Entree)
        Liste_Article_Bon_Entree.PersonnelDataGridView.Update()

        Me.Close()
    End Sub

    Private Sub PersonnelDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs)
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("NBonDataGridViewTextBoxColumn").Value = N_Bon_entreeTextBox.Text
    End Sub

    Private Sub PersonnelDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("NBonDataGridViewTextBoxColumn").Value = N_Bon_entreeTextBox.Text
    End Sub
End Class