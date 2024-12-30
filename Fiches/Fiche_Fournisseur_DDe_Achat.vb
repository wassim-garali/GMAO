Public Class Fiche_Fournisseur_DDe_Achat



    Private Sub Demande_AchatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Demande_AchatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet_Fournisseur)

    End Sub

    Private Sub Fiche_Fournisseur_DDe_Achat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)

        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Demande_Achat_Ligne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Demande_Achat_LigneTableAdapter.Fill(Me.DataSet_Fournisseur.Demande_Achat_Ligne)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Fournisseur.Demande_Achat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Demande_AchatTableAdapter.Fill(Me.DataSet_Fournisseur.Demande_Achat)

    End Sub

    Private Sub DepotListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepotListBox.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class