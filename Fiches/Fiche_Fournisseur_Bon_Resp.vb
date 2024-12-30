Public Class Fiche_Fournisseur_Bon_Resp

    
    Private Sub Fiche_Fournisseur_Bon_Resp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Bon_Reseption'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_ReseptionTableAdapter.Fill(Me.DataSet_Fournisseur.Bon_Reseption)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Bon_Reseption_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_Reseption_LigneTableAdapter.Fill(Me.DataSet_Fournisseur.Bon_Reseption_Ligne)

    End Sub

    Private Sub PersonnelDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonnelDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class