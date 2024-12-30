Public Class Liste_Article_Inventaire

    Private Property Fiche_Article_Inventaire As Fiche_Article_Inventaire


    Private Sub Liste_Article_Inventaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Inventaire'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.InventaireTableAdapter.Fill(Me.DataSet_Stock.Inventaire)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fiche_Article_Inventaire() = New Fiche_Article_Inventaire
        Fiche_Article_Inventaire.Show()
    End Sub
End Class