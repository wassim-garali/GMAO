Public Class Fiche_Fournisseur



    Private Sub FournisseurBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FournisseurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet_Fournisseur)

    End Sub

    Private Sub Fiche_Fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Fournisseur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.FournisseurTableAdapter.Fill(Me.DataSet_Fournisseur.Fournisseur)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class