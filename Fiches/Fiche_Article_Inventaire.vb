Public Class Fiche_Article_Inventaire





    Private Sub Fiche_Article_Inventaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Inventaire'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.InventaireTableAdapter.Fill(Me.DataSet_Stock.Inventaire)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Inventaire_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Inventaire_LigneTableAdapter.Fill(Me.DataSet_Stock.Inventaire_Ligne)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class