Public Class Fiche_famille

    Private Sub Articles_FamilleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        '  Me.Articles_FamilleBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet_Stock)

    End Sub

    Private Sub Fiche_famille_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '  Me.Articles_FamilleTableAdapter.Fill(Me.DataSet_Stock.Articles_Famille)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.Articles_FamilleBindingSource.EndEdit()
        Me.Articles_FamilleTableAdapter.Update(Me.DataSet_Stock.Articles_Famille)
        MsgBox("OK")
        settings.Articles_FamilleTableAdapter.Fill(settings.DataSet_Stock.Articles_Famille)
        settings.DataGridView3.Update()
        Me.Close()
        settings.ajouter4.Visible = False
        settings.supprimer4.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        settings.ajouter4.Visible = False
        settings.supprimer4.Visible = False
    End Sub
End Class