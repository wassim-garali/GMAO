Public Class Liste_Machine_Interv_Prev

   



    Private Sub Liste_Machine_Interv_Prev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Machine_Interv_PrevTableAdapter.Fill(Me.DataSet_Machine.Machine_Interv_Prev)

    End Sub
End Class