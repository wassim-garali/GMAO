Public Class Liste_Rapport

    Private Sub Liste_Rapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Rapport'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.RapportTableAdapter.Fill(Me.DataSet_Intervention.Rapport)

    End Sub
End Class