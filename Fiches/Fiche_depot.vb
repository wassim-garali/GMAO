Public Class Fiche_depot

    Private Sub DEPOTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        '  Me.DEPOTBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet_Stock)

    End Sub

    Private Sub Fiche_depot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.DEPOT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '  Me.DEPOTTableAdapter.Fill(Me.DataSet_Stock.DEPOT)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.DEPOTBindingSource.EndEdit()
        Me.DEPOTTableAdapter.Update(Me.DataSet_Stock.DEPOT)
        MsgBox("OK")
        settings.DEPOTTableAdapter.Fill(settings.DataSet_Stock.DEPOT)
        settings.DataGridView4.Update()
        Me.Close()
        settings.ajouter7.Visible = False
        settings.supprimer7.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        settings.ajouter7.Visible = False
        settings.supprimer7.Visible = False
    End Sub
End Class