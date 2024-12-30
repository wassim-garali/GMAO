Public Class Fiche_Machine

    Private Sub MachineBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.MachineBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DataSet_Machine)
    End Sub

    Private Sub Fiche_Machine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Liste_Intervention)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Type_Frequence'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Type_FrequenceTableAdapter.Fill(Me.DataSet_Machine.Type_Frequence)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.MachineBindingSource.EndEdit()
        Me.MachineTableAdapter.Update(Me.DataSet_Machine.Machine)

        Me.MachineIntervPrevBindingSource.EndEdit()
        Me.Machine_Interv_PrevTableAdapter.Update(Me.DataSet_Machine.Machine_Interv_Prev)

        Me.Machine_Interv_PrevTableAdapter.DeleteQueryNULL()

        MsgBox("OK")
        Liste_Machine.MachineTableAdapter.Fill(Liste_Machine.DataSet_Machine.Machine)
        Liste_Machine.PersonnelDataGridView.Update()

        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'FORM_LOAD
        Me.Liste_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Liste_Intervention)
        Me.Type_FrequenceTableAdapter.Fill(Me.DataSet_Machine.Type_Frequence)

        'LISTE_BOUTON2(MODIFIER)
        Me.MachineBindingSource.CancelEdit()
        Me.MachineIntervPrevBindingSource.CancelEdit()
        Me.Machine_Interv_PrevTableAdapter.Fill_CODE(Me.DataSet_Machine.Machine_Interv_Prev, Code_MachineTextBox.Text)
        Me.MachineTableAdapter.Fill_CODE(Me.DataSet_Machine.Machine, Code_MachineTextBox.Text)
    End Sub

    Private Sub PersonnelDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles PersonnelDataGridView.RowsAdded
        On Error Resume Next
        If e.RowIndex = 0 Then Exit Sub

        For I = 0 To PersonnelDataGridView.RowCount - 1
            If PersonnelDataGridView.Rows(I).Cells("TypeFrequenceDataGridViewTextBoxColumn").Value <> "" And PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value <> Nothing And PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString <> "" Then
                Select Case PersonnelDataGridView.Rows(I).Cells("TypeFrequenceDataGridViewTextBoxColumn").Value
                    Case "Quotidienne"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("d", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Hebdomadaire"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("ww", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Mensuel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("m", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Trimestriel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("q", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Annuel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("yyyy", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case Else

                End Select
            End If

        Next
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Code_Machine").Value = Code_MachineTextBox.Text
    End Sub

    Private Sub PersonnelDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonnelDataGridView.RowValidated
        On Error Resume Next
        If e.RowIndex = 0 Then Exit Sub

        For I = 0 To PersonnelDataGridView.RowCount - 1
            If PersonnelDataGridView.Rows(I).Cells("TypeFrequenceDataGridViewTextBoxColumn").Value <> "" And PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value <> Nothing And PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString <> "" Then
                Select Case PersonnelDataGridView.Rows(I).Cells("TypeFrequenceDataGridViewTextBoxColumn").Value
                    Case "Quotidienne"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("d", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Hebdomadaire"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("ww", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Mensuel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("m", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Trimestriel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("q", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Annuel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("yyyy", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                End Select
            End If

        Next
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Code_Machine").Value = Code_MachineTextBox.Text
    End Sub

    Private Sub PersonnelDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles PersonnelDataGridView.RowValidating
        On Error Resume Next
        If e.RowIndex = 0 Then Exit Sub

        For I = 0 To PersonnelDataGridView.RowCount - 1
            If PersonnelDataGridView.Rows(I).Cells("TypeFrequenceDataGridViewTextBoxColumn").Value <> "" And PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value <> Nothing And PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString <> "" Then
                Select Case PersonnelDataGridView.Rows(I).Cells("TypeFrequenceDataGridViewTextBoxColumn").Value
                    Case "Quotidienne"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("d", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Hebdomadaire"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("ww", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Mensuel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("m", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Trimestriel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("q", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                    Case "Annuel"
                        PersonnelDataGridView.Rows(I).Cells("Date_PInterv").Value = DateAdd("yyyy", Val(PersonnelDataGridView.Rows(I).Cells("FreqDataGridViewTextBoxColumn").Value), PersonnelDataGridView.Rows(I).Cells("DateDIntervDataGridViewTextBoxColumn").Value.ToString)
                End Select
            End If

        Next
        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Code_Machine").Value = Code_MachineTextBox.Text
    End Sub
End Class