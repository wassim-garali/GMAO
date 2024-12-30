Public Class fiche_type_frequence

    Private Sub Type_FrequenceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        '  Me.Type_FrequenceBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet_Machine)

    End Sub

    Private Sub fiche_type_frequence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Type_Frequence'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.Type_FrequenceTableAdapter.Fill(Me.DataSet_Machine.Type_Frequence)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        settings.ajouter1.Visible = False
        settings.supprimer1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.Type_FrequenceBindingSource.EndEdit()
        Me.Type_FrequenceTableAdapter.Update(Me.DataSet_Machine.Type_Frequence)
        MsgBox("OK")
        settings.Type_FrequenceTableAdapter.Fill(settings.DataSet_Machine.Type_Frequence)
        settings.PersonnelDataGridView.Update()
        Me.Close()
        settings.ajouter1.Visible = False
        settings.supprimer1.Visible = False
    End Sub
End Class