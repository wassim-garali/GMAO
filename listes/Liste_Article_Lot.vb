Public Class Liste_Article_Lot


    Private Sub Liste_Lot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Lot'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Articles_LotTableAdapter.Fill(Me.DataSet_Stock.Articles_Lot)

    End Sub
End Class