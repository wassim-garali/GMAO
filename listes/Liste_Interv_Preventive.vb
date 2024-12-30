Public Class Liste_Interv_Preventive
    Public TAB_BORD As Boolean
    Private Sub Liste_Interv_Preventive_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' If Me.InterventionTableAdapter.Fill_INTERV(Me.DataSet_Intervention.Intervention, "préventive") Then
        'Form1.PictureBox2.Visible = False
        ' Form1.Label1.Visible = False
        ' Else
        If TAB_BORD = False Then
            Form1.PictureBox2.Visible = True
            Form1.Label1.Visible = True
        End If
    End Sub

    Private Sub Liste_Interv_Preventive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.VUE_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.VUE_InterventionTableAdapter.Fill(Me.DataSet_Intervention.VUE_Intervention)
        'Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "préventive")
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "préventive")
        Else
            Me.InterventionTableAdapter.Fill_type_nom(Me.DataSet_Intervention.Intervention, "préventive", Form1.ToolStripStatusNom.Text)
        End If

        Me.ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Intervention_Preventive.MOD_AJOUT = True
            Fiche_Intervention_Preventive.Button2.Enabled = False
            Fiche_Intervention_Preventive.Show()
            Fiche_Intervention_Preventive.InterventionBindingSource.CancelEdit()
            Fiche_Intervention_Preventive.InterventionBindingSource.AddNew()
            Fiche_Intervention_Preventive.Validation_ResponsableCheckBox.Enabled = False
            Fiche_Intervention_Preventive.Validation_TechnisienCheckBox.Enabled = False
            Fiche_Intervention_Preventive.PersonnelDataGridView.ReadOnly = True
            Fiche_Intervention_Preventive.DureeTextBox.Enabled = False
            Fiche_Intervention_Preventive.Date_ArretDateTimePicker.Enabled = False
            Fiche_Intervention_Preventive.DataGridView2.ReadOnly = True
            Fiche_Intervention_Preventive.DataGridView1.ReadOnly = True
            Fiche_Intervention_Preventive.Date_RealisationDateTimePicker.Enabled = False
            Fiche_Intervention_Preventive.Code_MachineComboBox.Enabled = True

            Fiche_Intervention_Preventive.ResponsableTextBox.Text = Form1.ToolStripStatusNom.Text
            Fiche_Intervention_Preventive.TypeComboBox.Text = "préventive"
            Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Value = FormatDateTime(Today, DateFormat.ShortDate)
            Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Text = FormatDateTime(Today, DateFormat.ShortDate)
            'Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Value = Now

            Fiche_Intervention_Preventive.NUMBER_LOAD()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fiche_Intervention_Preventive.MOD_AJOUT = False
        Fiche_Intervention_Preventive.Show()
        Fiche_Intervention_Preventive.Button2.Enabled = True
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)

            Fiche_Intervention_Preventive.InterventionBindingSource.CancelEdit()
            Fiche_Intervention_Preventive.VuepreventiveBindingSource.CancelEdit()

            Fiche_Intervention_Preventive.InterventionTableAdapter.Fill_Original_N_Interv(Fiche_Intervention_Preventive.DataSet_Intervention.Intervention, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "préventive")
            Fiche_Intervention_Preventive.Vue_preventiveTableAdapter.Fill_NUM(Fiche_Intervention_Preventive.DataSet_Intervention.vue_preventive, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "préventive")
            Fiche_Intervention_Preventive.RapportTableAdapter.Fill_Original_N_Interv(Fiche_Intervention_Preventive.DataSet_Intervention.Rapport, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Intervention_Preventive.Article_InterventionTableAdapter.Fill_Original_N_Interv(Fiche_Intervention_Preventive.DataSet_Intervention.Article_Intervention, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "préventive")

            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                If selectedRow.Cells("ValidationResponsableDataGridViewCheckBoxColumn").Value = True Then
                    Fiche_Intervention_Preventive.Button1.Enabled = False
                    'MsgBox("Impossible de modifier")
                End If
                Fiche_Intervention_Preventive.Code_MachineComboBox.Enabled = False
                Fiche_Intervention_Preventive.N_IntervTextBox.Enabled = False
                'Fiche_Intervention_Preventive.NomPrenomComboBox.Enabled = True
                Fiche_Intervention_Preventive.Validation_ResponsableCheckBox.Enabled = True
                Fiche_Intervention_Preventive.Validation_TechnisienCheckBox.Enabled = False
                Fiche_Intervention_Preventive.PersonnelDataGridView.ReadOnly = True
                Fiche_Intervention_Preventive.DureeTextBox.Enabled = False
                Fiche_Intervention_Preventive.DataGridView1.ReadOnly = True
                Fiche_Intervention_Preventive.DataGridView2.ReadOnly = True
                Fiche_Intervention_Preventive.Date_ArretDateTimePicker.Enabled = False
                Fiche_Intervention_Preventive.Date_RealisationDateTimePicker.Enabled = False
                If Fiche_Intervention_Preventive.Validation_TechnisienCheckBox.Checked = True Then
                    Fiche_Intervention_Preventive.TechnisienComboBox.Enabled = False
                    Fiche_Intervention_Preventive.Validation_ResponsableCheckBox.Enabled = True
                Else
                    Fiche_Intervention_Preventive.TechnisienComboBox.Enabled = True
                    Fiche_Intervention_Preventive.Validation_ResponsableCheckBox.Enabled = False
                End If
            ElseIf Form1.ToolStripStatusspec.Text = "Technicien" Then
                If selectedRow.Cells("ValidationResponsableDataGridViewCheckBoxColumn").Value = True Then
                    Fiche_Intervention_Preventive.Button1.Enabled = False
                    '  MsgBox("Impossible de modifier")
                End If
                Fiche_Intervention_Preventive.Code_MachineComboBox.Enabled = False
                Fiche_Intervention_Preventive.N_IntervTextBox.Enabled = False
                ' Fiche_Intervention_Preventive.NomPrenomComboBox.Enabled = False
                Fiche_Intervention_Preventive.Validation_ResponsableCheckBox.Enabled = False
                Fiche_Intervention_Preventive.Date_IntervDateTimePicker.Enabled = False
                Fiche_Intervention_Preventive.Validation_TechnisienCheckBox.Enabled = True
                Fiche_Intervention_Preventive.PersonnelDataGridView.ReadOnly = False
                Fiche_Intervention_Preventive.DureeTextBox.Enabled = False
                Fiche_Intervention_Preventive.Date_ArretDateTimePicker.Enabled = True
                Fiche_Intervention_Preventive.Date_RealisationDateTimePicker.Enabled = True
                Fiche_Intervention_Preventive.DataGridView2.ReadOnly = False
                Fiche_Intervention_Preventive.DataGridView1.ReadOnly = False
                Fiche_Intervention_Preventive.TechnisienComboBox.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            If selectedRow.Cells("ValidationResponsableDataGridViewCheckBoxColumn").Value = True Then
                MsgBox("Impossible de supprimer")
                Exit Sub
            End If
        End If

        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            If PersonnelDataGridView.SelectedRows.Count > 0 Then
                ' Récupère la ligne sélectionnée
                Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
                Fiche_Intervention_Preventive.InterventionTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "préventive")
                Fiche_Intervention_Preventive.Vue_preventiveTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "préventive")
                Fiche_Intervention_Preventive.RapportTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString())
                Fiche_Intervention_Preventive.Article_InterventionTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "préventive")

            End If

            MsgBox("OK")
            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "préventive")
            Else
                Me.InterventionTableAdapter.Fill_type_nom(Me.DataSet_Intervention.Intervention, "préventive", Form1.ToolStripStatusNom.Text)
            End If
            Me.PersonnelDataGridView.Update()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text <> "" Then
            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                Me.InterventionTableAdapter.Fill_MACH(Me.DataSet_Intervention.Intervention, "préventive", ComboBox1.Text)
            Else
                Me.InterventionTableAdapter.Fill_MACHT(Me.DataSet_Intervention.Intervention, "préventive", Form1.ToolStripStatusNom.Text, ComboBox1.Text)
            End If
        Else
            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "préventive")
            Else
                Me.InterventionTableAdapter.Fill_type_nom(Me.DataSet_Intervention.Intervention, "préventive", Form1.ToolStripStatusNom.Text)
            End If
        End If
    End Sub
End Class