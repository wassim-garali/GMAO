Public Class Liste_Fournisseur_Bon_Cde

    Private Property Fiche_Fournisseur_Bon_Cde As Fiche_Fournisseur_Bon_Cd

    Private Sub Bon_CommandeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Bon_CommandeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet_Fournisseur)

    End Sub

    Private Sub Liste_Fournisseur_Bon_Cde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Bon_Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_CommandeTableAdapter.Fill(Me.DataSet_Fournisseur.Bon_Commande)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fiche_Fournisseur_Bon_Cde() = New Fiche_Fournisseur_Bon_Cd
        Fiche_Fournisseur_Bon_Cde.Show()

    End Sub
End Class