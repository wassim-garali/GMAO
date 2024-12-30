Public Class Fiche_interv

    Private Sub Liste_InterventionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        ' Me.Liste_InterventionBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet_Intervention)

    End Sub

    Private Sub Fiche_interv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.Liste_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Liste_Intervention)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.Liste_InterventionBindingSource.EndEdit()
        Me.Liste_InterventionTableAdapter.Update(Me.DataSet_Intervention.Liste_Intervention)
        MsgBox("OK")
        settings.Liste_InterventionTableAdapter.Fill(settings.DataSet_Intervention.Liste_Intervention)
        settings.DataGridView6.Update()
        Me.Close()
        settings.ajouter5.Visible = False
        settings.supprimer5.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        settings.ajouter5.Visible = False
        settings.supprimer5.Visible = False
    End Sub
End Class