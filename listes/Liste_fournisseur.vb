Public Class Liste_fournisseur

    Private Property Fiche_Fournisseur As Fiche_Fournisseur

    Private Sub Liste_fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Fournisseur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.FournisseurTableAdapter.Fill(Me.DataSet_Fournisseur.Fournisseur)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fiche_Fournisseur() = New Fiche_Fournisseur
        Fiche_Fournisseur.Show()
    End Sub
End Class