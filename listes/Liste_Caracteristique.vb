Public Class Liste_Caracteristique

   
    Private Sub Liste_Caracteristique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Caracteristiques'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Caracteristiques)

    End Sub
End Class