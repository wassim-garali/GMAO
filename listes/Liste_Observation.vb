Public Class Liste_Observation


    Private Sub Liste_Observation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Observations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ObservationsTableAdapter.Fill(Me.DataSet_Intervention.Observations)

    End Sub
End Class