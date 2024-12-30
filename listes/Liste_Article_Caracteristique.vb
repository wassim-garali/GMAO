Public Class Liste_Article_Caracteristique


  

    Private Sub Liste_Article_Caracteristique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Caracteristiques'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Articles_CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Articles_Caracteristiques)

    End Sub
End Class