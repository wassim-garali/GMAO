Public Class Liste_Machine
    Public TAB_BORD As Boolean
    Private Sub Liste_Machine_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' If Me.MachineTableAdapter.Fill_PREV(Me.DataSet_Machine.Machine, Today, Tableau_de_bord.NumericUpDown2.Value) Then
        'Form1.PictureBox2.Visible = False
        '  Form1.Label1.Visible = False
        ' Else
        'Form1.PictureBox2.Visible = True
        'Form1.Label1.Visible = True
        '  End If
        ' If Me.MachineTableAdapter.Fill_DEPASSE(Me.DataSet_Machine.Machine, Today) Then
        'Form1.PictureBox2.Visible = False
        '  Form1.Label1.Visible = False
        If TAB_BORD = False Then
            Form1.PictureBox2.Visible = True
            Form1.Label1.Visible = True
        End If
    End Sub

    Private Sub Liste_Machine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.MachineTableAdapter.Fill(Me.DataSet_Machine.Machine)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Machine.Show()
            Fiche_Machine.MachineBindingSource.AddNew()
            Fiche_Machine.Code_MachineTextBox.Enabled = True
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If

        Fiche_Machine.Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fiche_Machine.Show()
        Fiche_Machine.Button2.Enabled = True

        ' Vérifie que l'utilisateur a sélectionné une ligne
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)

            Fiche_Machine.MachineBindingSource.CancelEdit()
            Fiche_Machine.MachineIntervPrevBindingSource.CancelEdit()
            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            Fiche_Machine.Machine_Interv_PrevTableAdapter.Fill_CODE(Fiche_Machine.DataSet_Machine.Machine_Interv_Prev, selectedRow.Cells("CodeMachineDataGridViewTextBoxColumn").Value.ToString())
            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            Fiche_Machine.MachineTableAdapter.Fill_CODE(Fiche_Machine.DataSet_Machine.Machine, selectedRow.Cells("CodeMachineDataGridViewTextBoxColumn").Value.ToString())

            Fiche_Machine.Code_MachineTextBox.Enabled = False
            Fiche_Machine.ID_ImmoTextBox.Enabled = False
            Fiche_Machine.FabriquantTextBox.Enabled = True
            Fiche_Machine.DesignationTextBox.Enabled = False
            Fiche_Machine.Mise_en_marcheDateTimePicker.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            Fiche_Machine.MachineTableAdapter.DeleteQuery(selectedRow.Cells("CodeMachineDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Machine.Machine_Interv_PrevTableAdapter.DeleteQuery(selectedRow.Cells("CodeMachineDataGridViewTextBoxColumn").Value.ToString())
        End If

        MsgBox("OK")
        Me.MachineTableAdapter.Fill(Me.DataSet_Machine.Machine)
        Me.PersonnelDataGridView.Update()
    End Sub

    Private Sub button_add_prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_add_prev.Click
        Fiche_Intervention_Preventive.MOD_AJOUT = True
        Fiche_Intervention_Preventive.Show()

        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            If Form1.ToolStripStatusspec.Text = "Responsable" Then

                Fiche_Intervention_Preventive.InterventionBindingSource.CancelEdit()
                Fiche_Intervention_Preventive.InterventionBindingSource.AddNew()
                Fiche_Intervention_Preventive.Validation_ResponsableCheckBox.Enabled = False
                Fiche_Intervention_Preventive.Validation_TechnisienCheckBox.Enabled = False
                Fiche_Intervention_Preventive.PersonnelDataGridView.Enabled = False
                Fiche_Intervention_Preventive.DureeTextBox.Enabled = False
                Fiche_Intervention_Preventive.Date_ArretDateTimePicker.Enabled = False
                Fiche_Intervention_Preventive.DataGridView2.Enabled = False
                Fiche_Intervention_Preventive.Date_RealisationDateTimePicker.Enabled = False
                Fiche_Intervention_Preventive.Code_MachineComboBox.Enabled = False
                Fiche_Intervention_Preventive.ResponsableTextBox.Text = Form1.ToolStripStatusNom.Text
                Fiche_Intervention_Preventive.TypeComboBox.Text = "préventive"
                Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Value = FormatDateTime(Today, DateFormat.ShortDate)
                Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Text = FormatDateTime(Today, DateFormat.ShortDate)
                'Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Value = Now

                Fiche_Intervention_Preventive.NUMBER_LOAD()
                Fiche_Intervention_Preventive.Code_MachineComboBox.SelectedValue = selectedRow.Cells("CodeMachineDataGridViewTextBoxColumn").Value
            Else
                MsgBox(" Accés non disponible", vbCritical)
            End If

            Me.Close()
        End If

    End Sub
End Class