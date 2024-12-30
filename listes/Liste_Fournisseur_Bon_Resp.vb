Public Class Liste_Fournisseur_Bon_Resp

    Private Property Fiche_Fournisseur_Bon_Resp As Fiche_Fournisseur_Bon_Resp

    Private Sub Liste_Fournisseur_Bon_Resp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Bon_Reseption'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_ReseptionTableAdapter.Fill(Me.DataSet_Fournisseur.Bon_Reseption)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fiche_Fournisseur_Bon_Resp() = New Fiche_Fournisseur_Bon_Resp
        Fiche_Fournisseur_Bon_Resp.Show()
    End Sub
End Class