Public Class Liste__Article_Famille




    Private Sub Liste_Famille_Article_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Articles_FamilleTableAdapter.Fill(Me.DataSet_Stock.Articles_Famille)

    End Sub

    Private Sub PersonnelDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonnelDataGridView.CellContentClick

    End Sub
End Class