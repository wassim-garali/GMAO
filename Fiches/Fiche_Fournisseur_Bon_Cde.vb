Public Class Fiche_Fournisseur_Bon_Cd





    Private Sub Fiche_Fournisseur_Bon_Cde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Bon_Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_CommandeTableAdapter.Fill(Me.DataSet_Fournisseur.Bon_Commande)

        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Bon_Commande_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_Commande_LigneTableAdapter.Fill(Me.DataSet_Fournisseur.Bon_Commande_Ligne)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub
End Class