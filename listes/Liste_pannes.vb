Public Class Liste_pannes

    Private Sub Liste_pannes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Panne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_PanneTableAdapter.Fill(Me.DataSet_Intervention.Liste_Panne)

    End Sub
End Class