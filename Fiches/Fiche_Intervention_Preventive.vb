Public Class Fiche_Intervention_Preventive
    Public MOD_AJOUT As Boolean

    Private Sub Fiche_Intervention_Preventive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        Me.MachineTableAdapter.Fill(Me.DataSet_Machine.Machine)
        Me.Personnel1TableAdapter.Fill_Spec(Me.GMAODataSet.Personnel1, "Technicien")
        Me.ObservationsTableAdapter.Fill(Me.DataSet_Intervention.Observations)

        'If MOD_AJOUT = True Then Me.NUMBER_LOAD()
    End Sub
    Public Sub NUMBER_LOAD()
        If Me.InterventionTableAdapter.MAX("préventive") Is Nothing Then
            Me.N_IntervTextBox.Text = 1
        Else
            Me.N_IntervTextBox.Text = Val(Me.InterventionTableAdapter.MAX("préventive")) + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        If Form1.ToolStripStatusspec.Text = "Technicien" And Me.Validation_ResponsableCheckBox.Checked = True Then
            MsgBox("Validation Responsable effectué, impossible de modifier cette fiche", vbCritical)
            Exit Sub
        End If

        Dim CODE_MACHINE As String = Code_MachineComboBox.SelectedValue
        Dim NOM_MACHINE As String = Code_MachineComboBox.Text
        Dim EMAIL As String = TextBox_Email.Text

        Me.InterventionBindingSource.EndEdit()
        Me.InterventionTableAdapter.Update(Me.DataSet_Intervention.Intervention)

        Me.VuepreventiveBindingSource.EndEdit()
        Me.Vue_preventiveTableAdapter.Update(Me.DataSet_Intervention.vue_preventive)

        Me.ArticleInterventionBindingSource.EndEdit()
        Me.Article_InterventionTableAdapter.Update(Me.DataSet_Intervention.Article_Intervention)

        Me.RapportBindingSource.EndEdit()
        Me.RapportTableAdapter.Update(Me.DataSet_Intervention.Rapport)

        If Form1.ToolStripStatusspec.Text = "Responsable" And Me.Validation_ResponsableCheckBox.Enabled = True Then
            Me.ArticlesTableAdapter.UpdateStock(N_IntervTextBox.Text, "préventive")
            Me.Machine_Interv_PrevTableAdapter.UpdateDateD(CODE_MACHINE, N_IntervTextBox.Text, NOM_MACHINE, "préventive")

            For I = 0 To PersonnelDataGridView.RowCount - 1
                If PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value <> "" And PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn10").Value <> Nothing Then
                    Select Case PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value
                        Case "Quotidienne"
                            Me.Machine_Interv_PrevTableAdapter.UpdateDateP(DateAdd("d", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn10").Value), Date_RealisationDateTimePicker.Value), CODE_MACHINE, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn7").Value, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value)
                        Case "Hebdomadaire"
                            Me.Machine_Interv_PrevTableAdapter.UpdateDateP(DateAdd("ww", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn10").Value), Date_RealisationDateTimePicker.Value), CODE_MACHINE, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn7").Value, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value)
                        Case "Mensuel"
                            Me.Machine_Interv_PrevTableAdapter.UpdateDateP(DateAdd("m", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn10").Value), Date_RealisationDateTimePicker.Value), CODE_MACHINE, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn7").Value, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value)
                        Case "Trimestriel"
                            Me.Machine_Interv_PrevTableAdapter.UpdateDateP(DateAdd("q", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn10").Value), Date_RealisationDateTimePicker.Value), CODE_MACHINE, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn7").Value, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value)
                        Case "Annuel"
                            Me.Machine_Interv_PrevTableAdapter.UpdateDateP(DateAdd("yyyy", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn10").Value), Date_RealisationDateTimePicker.Value), CODE_MACHINE, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn7").Value, PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn9").Value)
                        Case Else

                    End Select
                End If
            Next
        End If

        If Form1.ToolStripStatusspec.Text = "Responsable" And EMAIL <> "" And Me.Validation_ResponsableCheckBox.Enabled = False Then
            If Form1.SEND_EMAIL("garaliwassim709@gmail.com", "gmaowassim", EMAIL, "INTERVENTION PREVENTIVE", "Bonjour ;" & vbCrLf & vbCrLf & " La date de l'action préventive de la machine  " + NOM_MACHINE + vbCrLf & "sera  le  " + Date_IntervDateTimePicker.Text + " .", "smtp.topnet.tn", 25) = True Then
                MsgBox("Email envoyer avec succé", vbInformation)
            End If
        End If

        MsgBox("OK")

        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Interv_Preventive.InterventionTableAdapter.Fill_type(Liste_Interv_Preventive.DataSet_Intervention.Intervention, "préventive")
        Else
            Liste_Interv_Preventive.InterventionTableAdapter.Fill_type_nom(Liste_Interv_Preventive.DataSet_Intervention.Intervention, "préventive", Form1.ToolStripStatusNom.Text)
        End If
        Liste_Interv_Preventive.PersonnelDataGridView.Update()

        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        Me.MachineTableAdapter.Fill(Me.DataSet_Machine.Machine)
        Me.Personnel1TableAdapter.Fill_Spec(Me.GMAODataSet.Personnel1, "Technicien")
        Me.ObservationsTableAdapter.Fill(Me.DataSet_Intervention.Observations)
        Me.InterventionBindingSource.CancelEdit()
        Me.VuepreventiveBindingSource.CancelEdit()

        Me.InterventionTableAdapter.Fill_Original_N_Interv(Me.DataSet_Intervention.Intervention, N_IntervTextBox.Text, "préventive")
        Me.Vue_preventiveTableAdapter.Fill_NUM(Me.DataSet_Intervention.vue_preventive, N_IntervTextBox.Text, "préventive")
        Me.RapportTableAdapter.Fill_Original_N_Interv(Me.DataSet_Intervention.Rapport, N_IntervTextBox.Text)
        Me.Article_InterventionTableAdapter.Fill_Original_N_Interv(Me.DataSet_Intervention.Article_Intervention, N_IntervTextBox.Text, "préventive")
    End Sub

    Private Sub PersonnelDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles PersonnelDataGridView.RowsAdded
        On Error Resume Next
        Me.DureeTextBox.Text = "00:00:00"

        For I = 0 To PersonnelDataGridView.RowCount - 1
            'MsgBox(PersonnelDataGridView.Rows(I).Cells("DureeDataGridViewTextBoxColumn").Value.ToString)
            'MsgBox(DateAndTime.Hour(PersonnelDataGridView.Rows(I).Cells("DureeDataGridViewTextBoxColumn").Value.ToString))
            Me.DureeTextBox.Text = DateAdd("s", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn2").Value.ToString) * 60, Me.DureeTextBox.Text)
        Next

        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn6").Value = Code_MachineComboBox.SelectedValue
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn1").Value = N_IntervTextBox.Text
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Type").Value = "préventive"
    End Sub

    Private Sub PersonnelDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonnelDataGridView.RowValidated
        On Error Resume Next

        Me.DureeTextBox.Text = "00:00:00"

        For I = 0 To PersonnelDataGridView.RowCount - 1
            'MsgBox(PersonnelDataGridView.Rows(I).Cells("DureeDataGridViewTextBoxColumn").Value.ToString)
            'MsgBox(DateAndTime.Hour(PersonnelDataGridView.Rows(I).Cells("DureeDataGridViewTextBoxColumn").Value.ToString))
            Me.DureeTextBox.Text = DateAdd("s", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn2").Value.ToString) * 60, Me.DureeTextBox.Text)
        Next
    End Sub

    Private Sub PersonnelDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles PersonnelDataGridView.RowValidating
        On Error Resume Next

        Me.DureeTextBox.Text = "00:00:00"

        For I = 0 To PersonnelDataGridView.RowCount - 1
            'MsgBox(PersonnelDataGridView.Rows(I).Cells("DureeDataGridViewTextBoxColumn").Value.ToString)
            'MsgBox(DateAndTime.Hour(PersonnelDataGridView.Rows(I).Cells("DureeDataGridViewTextBoxColumn").Value.ToString))
            Me.DureeTextBox.Text = DateAdd("s", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn2 ").Value.ToString) * 60, Me.DureeTextBox.Text)
        Next

        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn6").Value = Code_MachineComboBox.SelectedValue
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn1").Value = N_IntervTextBox.Text
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Type").Value = "préventive"
    End Sub

    Private Sub TechnisienComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TechnisienComboBox.SelectedIndexChanged
        Me.PersonnelTableAdapter.Fill_EMAIL(Me.GMAODataSet.Personnel, TechnisienComboBox.Text)
    End Sub

    Private Sub Code_MachineComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Code_MachineComboBox.SelectedIndexChanged
        'If Code_MachineComboBox.SelectedValue = Nothing Then Exit Sub
        If Code_MachineComboBox.SelectedValue <> "" And Me.MOD_AJOUT = True Then
            Me.Ligne_Interv_PrevTableAdapter.DeleteQuery(N_IntervTextBox.Text, "préventive")
            Me.Ligne_Interv_PrevTableAdapter.InsertQuery(N_IntervTextBox.Text, Code_MachineComboBox.SelectedValue)
            Me.Vue_preventiveTableAdapter.Fill_NUM(Me.DataSet_Intervention.vue_preventive, N_IntervTextBox.Text, "préventive")
        End If
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        If e.RowIndex = 0 Then Exit Sub
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn15").Value = Code_MachineComboBox.SelectedValue
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn14").Value = N_IntervTextBox.Text
        DataGridView1.Rows(e.RowIndex - 1).Cells("TypeDataGridViewTextBoxColumn").Value = "préventive"
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
        If e.RowIndex = 0 Then Exit Sub
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn15").Value = Code_MachineComboBox.SelectedValue
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn14").Value = N_IntervTextBox.Text
        DataGridView1.Rows(e.RowIndex - 1).Cells("TypeDataGridViewTextBoxColumn").Value = "préventive"
    End Sub

    Private Sub DataGridView2_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView2.RowsAdded
        If e.RowIndex = 0 Then Exit Sub
        'DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn15").Value = Code_MachineComboBox.Text
        DataGridView2.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn11").Value = N_IntervTextBox.Text
        'DataGridView1.Rows(e.RowIndex - 1).Cells("TypeDataGridViewTextBoxColumn").Value = "préventive"
    End Sub

    Private Sub DataGridView2_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView2.RowValidating
        If e.RowIndex = 0 Then Exit Sub
        'DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn15").Value = Code_MachineComboBox.Text
        DataGridView2.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn11").Value = N_IntervTextBox.Text
        'DataGridView1.Rows(e.RowIndex - 1).Cells("TypeDataGridViewTextBoxColumn").Value = "préventive"
    End Sub

    Private Sub Validation_TechnisienCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Validation_TechnisienCheckBox.CheckedChanged

    End Sub

    
End Class