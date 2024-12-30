Public Class fiche_des_pannes

    Private Sub Liste_PanneBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        ' Me.Liste_PanneBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet_Intervention)

    End Sub

    Private Sub fiche_des_pannes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Panne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.Liste_PanneTableAdapter.Fill(Me.DataSet_Intervention.Liste_Panne)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.Liste_PanneBindingSource.EndEdit()
        Me.Liste_PanneTableAdapter.Update(Me.DataSet_Intervention.Liste_Panne)
        MsgBox("OK")
        settings.Liste_PanneTableAdapter.Fill(settings.DataSet_Intervention.Liste_Panne)
        settings.DataGridView5.Update()
        Me.Close()
        settings.ajouter6.Visible = False
        settings.supprimer6.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        settings.ajouter6.Visible = False
        settings.supprimer6.Visible = False
    End Sub
End Class