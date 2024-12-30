Public Class Fiche_Personnel

    Private Sub PersonnelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        ' Me.PersonnelBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.GMAODataSet)

    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.PersonnelBindingSource.EndEdit()
        Me.PersonnelTableAdapter.Update(Me.GMAODataSet.Personnel)
        MsgBox("OK")
        Liste_Personnel.PersonnelTableAdapter.Fill(Liste_Personnel.GMAODataSet.Personnel)
        Liste_Personnel.PersonnelDataGridView.Update()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PersonnelBindingSource.CancelEdit()
        Me.PersonnelTableAdapter.Fill_mat(Me.GMAODataSet.Personnel, MatriculeTextBox.Text)
    End Sub
End Class