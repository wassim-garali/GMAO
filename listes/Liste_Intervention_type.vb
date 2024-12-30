Public Class Liste_Intervention_type





    Private Sub Liste_Intervention_type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Liste_Intervention)

    End Sub
End Class