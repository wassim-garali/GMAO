Public Class Liste_Fournisseur_DDe_Achat

    Private Property Fiche_Fournisseur_DDe_Achat As Fiche_Fournisseur_DDe_Achat

  
   
   
  
    Private Sub Liste_Fournisseur_DDe_Achat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Demande_Achat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Demande_AchatTableAdapter.Fill(Me.DataSet_Fournisseur.Demande_Achat)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fiche_Fournisseur_DDe_Achat() = New Fiche_Fournisseur_DDe_Achat
        Fiche_Fournisseur_DDe_Achat.Show()
    End Sub
End Class