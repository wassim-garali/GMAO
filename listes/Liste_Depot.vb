Public Class Liste_Depot


  
    Private Sub Liste_Depot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.DEPOT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DEPOTTableAdapter.Fill(Me.DataSet_Stock.DEPOT)

    End Sub

    Private Sub PersonnelDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonnelDataGridView.CellContentClick

    End Sub
End Class