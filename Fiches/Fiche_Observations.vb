Public Class Fiche_Observations

    Private Sub ObservationsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        '  Me.ObservationsBindingSource.EndEdit()
        '  Me.TableAdapterManager.UpdateAll(Me.DataSet_Intervention)

    End Sub

    Private Sub Fiche_Observations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Observations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '   Me.ObservationsTableAdapter.Fill(Me.DataSet_Intervention.Observations)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.ObservationsBindingSource.EndEdit()
        Me.ObservationsTableAdapter.Update(Me.DataSet_Intervention.Observations)
        MsgBox("OK")
        settings.ObservationsTableAdapter.Fill(settings.DataSet_Intervention.Observations)
        settings.DataGridView2.Update()
        Me.Close()
        settings.ajouter3.Visible = False
        settings.supprimer3.Visible = False
    End Sub
End Class