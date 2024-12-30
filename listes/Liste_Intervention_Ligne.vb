Public Class Liste_Intervention_Ligne

 

    Private Sub Liste_Intervention_Ligne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Ligne_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Ligne_Interv_PrevTableAdapter.Fill(Me.DataSet_Intervention.Ligne_Interv_Prev)

    End Sub
End Class