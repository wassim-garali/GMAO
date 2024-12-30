Public Class Fiche_Intervention_Corrective
    Public MOD_AJOUT As Boolean

    Private Sub Fiche_Intervention_Corrective_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Article_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '  Me.Article_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Article_Intervention)
        Me.Liste_PanneTableAdapter.Fill(Me.DataSet_Intervention.Liste_Panne)
        Me.MachineTableAdapter.Fill(Me.DataSet_Machine.Machine)
        Me.Personnel1TableAdapter.Fill_Spec(Me.GMAODataSet.Personnel1, "Technicien")

        'If MOD_AJOUT = True Then Me.NUMBER_LOAD()
    End Sub
    Public Sub NUMBER_LOAD()
        If Me.InterventionTableAdapter.MAX("corrective") Is Nothing Then
            Me.N_IntervTextBox1.Text = 1
        Else
            Me.N_IntervTextBox1.Text = Val(Me.InterventionTableAdapter.MAX("corrective")) + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        If Form1.ToolStripStatusspec.Text = "Technicien" And Me.Validation_ResponsableCheckBox1.Checked = True Then
            MsgBox("Validation Responsable effectué, impossible de modifier cette fiche", vbCritical)
            Exit Sub
        End If

        Dim NOM_MACHINE As String = Code_MachineComboBox1.Text
        Dim EMAIL As String = TextBox_Email.Text

        Me.InterventionBindingSource.EndEdit()
        Me.InterventionTableAdapter.Update(Me.DataSet_Intervention.Intervention)

        Me.LigneIntervPrevBindingSource.EndEdit()
        Me.Ligne_Interv_PrevTableAdapter.Update(Me.DataSet_Intervention.Ligne_Interv_Prev)

        Me.ArticleInterventionBindingSource.EndEdit()
        Me.Article_InterventionTableAdapter.Update(Me.DataSet_Intervention.Article_Intervention)

        If Form1.ToolStripStatusspec.Text = "Responsable" And Me.Validation_ResponsableCheckBox1.Enabled = True Then
            Me.ArticlesTableAdapter.UpdateStock(N_IntervTextBox1.Text, "corrective")
        End If

        If Form1.ToolStripStatusspec.Text = "Responsable" And EMAIL <> "" And Me.Validation_ResponsableCheckBox1.Enabled = False Then
            If Form1.SEND_EMAIL("delice.compagnieFromagere@gmail.com", "delicedelice12345", EMAIL, "INTERVENTION CORRECTIVE", "Bonjour" & vbCrLf & vbCrLf & " Veuillez nous contacter pour réparation  de la machine " + NOM_MACHINE + vbCrLf & "prévoir de finir la mission le  " + Date_IntervDateTimePicker1.Text + " .", "smtp.topnet.tn", 25) = True Then
                MsgBox("Email envoyer avec succé", vbInformation)
            End If
        End If

        MsgBox("OK")

        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Interv_Corrective.InterventionTableAdapter.Fill_type(Liste_Interv_Corrective.DataSet_Intervention.Intervention, "corrective")
        Else
            Liste_Interv_Corrective.InterventionTableAdapter.Fill_type_nom(Liste_Interv_Corrective.DataSet_Intervention.Intervention, "corrective", Form1.ToolStripStatusNom.Text)
        End If
        Liste_Interv_Corrective.IntervCorrDataGridView.Update()

        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        Me.Liste_PanneTableAdapter.Fill(Me.DataSet_Intervention.Liste_Panne)
        Me.MachineTableAdapter.Fill(Me.DataSet_Machine.Machine)
        Me.Personnel1TableAdapter.Fill_Spec(Me.GMAODataSet.Personnel1, "Technicien")

        Me.InterventionBindingSource.CancelEdit()
        Me.LigneIntervPrevBindingSource.CancelEdit()

        Me.InterventionTableAdapter.Fill_Original_N_Interv(Me.DataSet_Intervention.Intervention, N_IntervTextBox1.Text, "corrective")
        Me.Ligne_Interv_PrevTableAdapter.Fill_Original_N_Interv(Me.DataSet_Intervention.Ligne_Interv_Prev, N_IntervTextBox1.Text, "corrective")
        Me.Article_InterventionTableAdapter.Fill_Original_N_Interv(Me.DataSet_Intervention.Article_Intervention, N_IntervTextBox1.Text, "corrective")
    End Sub

    Private Sub PersonnelDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles PersonnelDataGridView.RowsAdded
        On Error Resume Next

        Me.DureeTextBox1.Text = "00:00"

        For I = 0 To PersonnelDataGridView.RowCount - 1
            ' MsgBox(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString)
            ' MsgBox(DateAndTime.Hour(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString))
            Me.DureeTextBox1.Text = FormatDateTime(DateAdd("n", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString), Me.DureeTextBox1.Text), DateFormat.ShortTime)
        Next

        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn2").Value = Code_MachineComboBox1.SelectedValue
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn1").Value = N_IntervTextBox1.Text
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Type").Value = "corrective"
    End Sub

    Private Sub PersonnelDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PersonnelDataGridView.RowValidated
        On Error Resume Next

        Me.DureeTextBox1.Text = "00:00"

        For I = 0 To PersonnelDataGridView.RowCount - 1
            'MsgBox(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString)
            'MsgBox(DateAndTime.Hour(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString))
            Me.DureeTextBox1.Text = FormatDateTime(DateAdd("n", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString), Me.DureeTextBox1.Text), DateFormat.ShortTime)
        Next
    End Sub

    Private Sub PersonnelDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles PersonnelDataGridView.RowValidating
        On Error Resume Next

        Me.DureeTextBox1.Text = "00:00"

        For I = 0 To PersonnelDataGridView.RowCount - 1
            ' MsgBox(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString)
            ' MsgBox(DateAndTime.Hour(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString))
            Me.DureeTextBox1.Text = FormatDateTime(DateAdd("n", Val(PersonnelDataGridView.Rows(I).Cells("DataGridViewTextBoxColumn4").Value.ToString), Me.DureeTextBox1.Text), DateFormat.ShortTime)
        Next

        If e.RowIndex = 0 Then Exit Sub

        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn2").Value = Code_MachineComboBox1.SelectedValue
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn1").Value = N_IntervTextBox1.Text
        PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("Type").Value = "corrective"
    End Sub

    Private Sub NomPrenomComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomPrenomComboBox.SelectedIndexChanged
        Me.PersonnelTableAdapter.Fill_EMAIL(Me.GMAODataSet.Personnel, NomPrenomComboBox.Text)
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        If e.RowIndex = 0 Then Exit Sub
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn9").Value = Code_MachineComboBox1.SelectedValue
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn8").Value = N_IntervTextBox1.Text
        DataGridView1.Rows(e.RowIndex - 1).Cells("TypeDataGridViewTextBoxColumn").Value = "corrective"
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
        If e.RowIndex = 0 Then Exit Sub
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn9").Value = Code_MachineComboBox1.SelectedValue
        DataGridView1.Rows(e.RowIndex - 1).Cells("DataGridViewTextBoxColumn8").Value = N_IntervTextBox1.Text
        DataGridView1.Rows(e.RowIndex - 1).Cells("TypeDataGridViewTextBoxColumn").Value = "corrective"
    End Sub

    Private Sub Date_IntervDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_IntervDateTimePicker1.ValueChanged
        If DateDiff("n", Me.Date_IntervDateTimePicker1.Value.ToString, Me.Date_ArretDateTimePicker1.Value.ToString) < 0 Then
            'MsgBox("Date Incorrecte", vbCritical)
            Me.Date_ArretDateTimePicker1.Value = Me.Date_IntervDateTimePicker1.Value
            Me.Date_ArretDateTimePicker1.Text = Me.Date_IntervDateTimePicker1.Text

            DureeTextBox1_TextChanged(sender, e)
        End If
    End Sub
    Private Sub Date_ArretDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_ArretDateTimePicker1.ValueChanged
        If Me.MOD_AJOUT = False Then Exit Sub
        If DateDiff("n", Me.Date_IntervDateTimePicker1.Value.ToString, Me.Date_ArretDateTimePicker1.Value.ToString) < 0 Then
            MsgBox("Date Incorrecte", vbCritical)
            Me.Date_ArretDateTimePicker1.Value = Me.Date_IntervDateTimePicker1.Value
            Me.Date_ArretDateTimePicker1.Text = Me.Date_IntervDateTimePicker1.Text
        End If

        DureeTextBox1_TextChanged(sender, e)
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DureeTextBox1_TextChanged(sender, e)
    End Sub
    Private Sub Date_RealisationDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_RealisationDateTimePicker1.ValueChanged
        If Me.MOD_AJOUT = False Then Exit Sub
        If DateDiff("n", Me.Date_ArretDateTimePicker1.Value.ToString, Me.Date_RealisationDateTimePicker1.Value.ToString) <= Val(Me.TTR_MTextBox.Text) Then
            MsgBox("Date Incorrecte", vbCritical)
            Me.Date_RealisationDateTimePicker1.Value = DateAdd("n", Val(Me.TTR_MTextBox.Text), Me.Date_ArretDateTimePicker1.Value)
            Me.Date_RealisationDateTimePicker1.Text = DateAdd("n", Val(Me.TTR_MTextBox.Text), Me.Date_ArretDateTimePicker1.Text)
        End If

        DureeTextBox1_TextChanged(sender, e)
    End Sub
    Private Sub DureeTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DureeTextBox1.TextChanged
        On Error Resume Next
        If Me.MOD_AJOUT = False Then Exit Sub

        Me.TTR_MTextBox.Text = (Microsoft.VisualBasic.Left(Val(Me.DureeTextBox1.Text), 2) * 60) + Mid(Me.DureeTextBox1.Text, 4, 2)
        If DateDiff("n", Me.Date_ArretDateTimePicker1.Value.ToString, Me.Date_RealisationDateTimePicker1.Value.ToString) <= Val(Me.TTR_MTextBox.Text) Then
            'MsgBox("Date Incorrecte", vbCritical)
            Me.MOD_AJOUT = False
            Me.Date_RealisationDateTimePicker1.Value = DateAdd("n", Val(Me.TTR_MTextBox.Text), Me.Date_ArretDateTimePicker1.Value)
            Me.Date_RealisationDateTimePicker1.Text = DateAdd("n", Val(Me.TTR_MTextBox.Text), Me.Date_ArretDateTimePicker1.Text)
            Me.MOD_AJOUT = True
        End If

        Me.DT_DTextBox.Text = "0J 0H 0M"
        Me.UT_DTextBox.Text = "0J 0H 0M"
        Me.TTR_DTextBox.Text = "0J 0H 0M"
        Me.TBF_DTextBox.Text = "0J 0H 0M"

        Me.DT_MTextBox.Text = 0
        Me.UT_MTextBox.Text = 0
        Me.TTR_MTextBox.Text = 0
        Me.TBF_MTextBox.Text = 0

        Me.DT_MTextBox.Text = DateDiff("n", Me.Date_ArretDateTimePicker1.Value.ToString, Me.Date_RealisationDateTimePicker1.Value.ToString)
        Me.TBF_MTextBox.Text = DateDiff("n", Me.DateTimePicker1.Value.ToString, Me.Date_ArretDateTimePicker1.Value.ToString)
        Me.UT_MTextBox.Text = Val(Me.TBF_MTextBox.Text) - Val(Me.DT_MTextBox.Text)
        Me.TTR_MTextBox.Text = (Microsoft.VisualBasic.Left(Val(Me.DureeTextBox1.Text), 2) * 60) + Mid(Me.DureeTextBox1.Text, 4, 2)

        Me.DT_DTextBox.Text = CONVERT_TIME(Val(Me.DT_MTextBox.Text))
        Me.UT_DTextBox.Text = CONVERT_TIME(Val(Me.UT_MTextBox.Text))
        Me.TTR_DTextBox.Text = CONVERT_TIME(Val(Me.TTR_MTextBox.Text))
        Me.TBF_DTextBox.Text = CONVERT_TIME(Val(Me.TBF_MTextBox.Text))
    End Sub
    Public Sub DATE_DERNIER()
        Me.DateTimePicker1.Value = Today

        Dim DATE_MISE As Date
        Dim DATE_DER As Date

        If Not (Me.InterventionTableAdapter.MAX_DATE("corrective", Me.Code_MachineComboBox1.Text, N_IntervTextBox1.Text) Is Nothing) Then
            DATE_DER = Me.InterventionTableAdapter.MAX_DATE("corrective", Me.Code_MachineComboBox1.Text, N_IntervTextBox1.Text)
            Me.DateTimePicker1.Value = DATE_DER
            Exit Sub
        End If
        If Not (Me.MachineTableAdapter.DATE_MISEENMARCHE(Me.Code_MachineComboBox1.SelectedValue) Is Nothing) Then
            DATE_MISE = Me.MachineTableAdapter.DATE_MISEENMARCHE(Me.Code_MachineComboBox1.SelectedValue)
            Me.DateTimePicker1.Value = DATE_MISE
            Exit Sub
        End If
    End Sub
    Public Function CONVERT_TIME(TIME_D As Integer) As String
        CONVERT_TIME = "0J 0H 0M"

        Dim X_MIN As Integer = 60
        Dim Y_HR As Integer = X_MIN * 24

        Dim T_DAY As Integer = Int(TIME_D / Y_HR)
        Dim W_HR As Integer = Int((TIME_D Mod Y_HR) / X_MIN)
        Dim S_MIN As Integer = Int((TIME_D Mod Y_HR) Mod X_MIN)

        CONVERT_TIME = T_DAY & "J " & W_HR & "H " & S_MIN & "M"
    End Function


End Class