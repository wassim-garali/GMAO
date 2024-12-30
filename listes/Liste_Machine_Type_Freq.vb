Public Class Liste_Machine_Type_Freq

   
 
    Private Sub Liste_Machine_Type_Freq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Type_Frequence'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Type_FrequenceTableAdapter.Fill(Me.DataSet_Machine.Type_Frequence)

    End Sub
End Class