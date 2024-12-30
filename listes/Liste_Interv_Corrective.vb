Public Class Liste_Interv_Corrective
    Public TAB_BORD As Boolean

    Private Sub Liste_Interv_Corrective_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If Me.InterventionTableAdapter.Fill_INTERV(Me.DataSet_Intervention.Intervention, "corrective") Then
        'Form1.PictureBox2.Visible = False
        ' Form1.Label1.Visible = False
        If TAB_BORD = False Then
            Form1.PictureBox2.Visible = True
            Form1.Label1.Visible = True
        End If
        ' End If
    End Sub

    Private Sub Liste_Interv_corrective_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.VUE_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.VUE_InterventionTableAdapter.Fill(Me.DataSet_Intervention.VUE_Intervention)
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "corrective")
        Else
            Me.InterventionTableAdapter.Fill_type_nom(Me.DataSet_Intervention.Intervention, "corrective", Form1.ToolStripStatusNom.Text)
        End If
        Me.ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Intervention_Corrective.MOD_AJOUT = True
            Fiche_Intervention_Corrective.Button2.Enabled = False
            Fiche_Intervention_Corrective.Show()
            Fiche_Intervention_Corrective.InterventionBindingSource.CancelEdit()
            Fiche_Intervention_Corrective.InterventionBindingSource.AddNew()
            Fiche_Intervention_Corrective.Validation_ResponsableCheckBox1.Enabled = False
            Fiche_Intervention_Corrective.Validation_TechnisienCheckBox1.Enabled = False
            Fiche_Intervention_Corrective.PersonnelDataGridView.ReadOnly = True
            Fiche_Intervention_Corrective.DureeTextBox1.Enabled = False
            Fiche_Intervention_Corrective.Date_ArretDateTimePicker1.Enabled = True
            Fiche_Intervention_Corrective.Date_RealisationDateTimePicker1.Enabled = False
            Fiche_Intervention_Corrective.Code_MachineComboBox1.Enabled = True
            Fiche_Intervention_Corrective.DataGridView1.ReadOnly = True

            Fiche_Intervention_Corrective.DureeTextBox1.Text = "00:00"
            'Fiche_Intervention_Corrective.Temps_arretTextBox.Text = "00:00:00"
            'Fiche_Intervention_Corrective.Temps_bon_fonctionTextBox.Text = "00:00:00"
            Fiche_Intervention_Corrective.ResponsableTextBox1.Text = Form1.ToolStripStatusNom.Text
            Fiche_Intervention_Corrective.TypeComboBox.Text = "corrective"
            Fiche_Intervention_Corrective.Date_IntervDateTimePicker1.Value = FormatDateTime(Today, DateFormat.GeneralDate)
            Fiche_Intervention_Corrective.Date_IntervDateTimePicker1.Text = FormatDateTime(Today, DateFormat.GeneralDate)
            Fiche_Intervention_Corrective.Date_ArretDateTimePicker1.Value = FormatDateTime(Today, DateFormat.GeneralDate)
            Fiche_Intervention_Corrective.Date_ArretDateTimePicker1.Text = FormatDateTime(Today, DateFormat.GeneralDate)

            Fiche_Intervention_Corrective.NUMBER_LOAD()
            Fiche_Intervention_Corrective.MOD_AJOUT = False
            Fiche_Intervention_Corrective.DATE_DERNIER()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fiche_Intervention_Corrective.MOD_AJOUT = False
        Fiche_Intervention_Corrective.Show()
        Fiche_Intervention_Corrective.Button2.Enabled = True
        If IntervCorrDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = IntervCorrDataGridView.SelectedRows(0)

            Fiche_Intervention_Corrective.InterventionBindingSource.CancelEdit()
            Fiche_Intervention_Corrective.LigneIntervPrevBindingSource.CancelEdit()

            Fiche_Intervention_Corrective.InterventionTableAdapter.Fill_Original_N_Interv(Fiche_Intervention_Corrective.DataSet_Intervention.Intervention, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "corrective")
            Fiche_Intervention_Corrective.Ligne_Interv_PrevTableAdapter.Fill_Original_N_Interv(Fiche_Intervention_Corrective.DataSet_Intervention.Ligne_Interv_Prev, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "corrective")
            Fiche_Intervention_Corrective.Article_InterventionTableAdapter.Fill_Original_N_Interv(Fiche_Intervention_Corrective.DataSet_Intervention.Article_Intervention, selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "corrective")

            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                If selectedRow.Cells("ValidationResponsableDataGridViewCheckBoxColumn").Value = True Then
                    Fiche_Intervention_Corrective.Button1.Enabled = False
                    '  MsgBox("Impossible de modifier")
                End If
                Fiche_Intervention_Corrective.Code_MachineComboBox1.Enabled = False
                Fiche_Intervention_Corrective.N_IntervTextBox1.Enabled = False
                Fiche_Intervention_Corrective.NomPrenomComboBox.Enabled = True
                Fiche_Intervention_Corrective.Validation_ResponsableCheckBox1.Enabled = True
                Fiche_Intervention_Corrective.Validation_TechnisienCheckBox1.Enabled = False
                Fiche_Intervention_Corrective.PersonnelDataGridView.ReadOnly = True
                Fiche_Intervention_Corrective.DureeTextBox1.Enabled = False
                Fiche_Intervention_Corrective.Date_ArretDateTimePicker1.Enabled = True
                Fiche_Intervention_Corrective.Date_RealisationDateTimePicker1.Enabled = False
                Fiche_Intervention_Corrective.DataGridView1.ReadOnly = True

                'selectedRow.Cells("ValidationTechnisienDataGridViewCheckBoxColumn").Value
                If Fiche_Intervention_Corrective.Validation_TechnisienCheckBox1.Checked = True Then
                    Fiche_Intervention_Corrective.NomPrenomComboBox.Enabled = False
                    Fiche_Intervention_Corrective.Date_IntervDateTimePicker1.Enabled = False
                    Fiche_Intervention_Corrective.Validation_ResponsableCheckBox1.Enabled = True
                Else
                    Fiche_Intervention_Corrective.NomPrenomComboBox.Enabled = True
                    Fiche_Intervention_Corrective.Date_IntervDateTimePicker1.Enabled = True
                    Fiche_Intervention_Corrective.Validation_ResponsableCheckBox1.Enabled = False
                End If
            ElseIf Form1.ToolStripStatusspec.Text = "Technicien" Then
                If selectedRow.Cells("ValidationResponsableDataGridViewCheckBoxColumn").Value = True Then
                    Fiche_Intervention_Corrective.Button1.Enabled = False
                    '  MsgBox("Impossible de modifier")
                End If
                Fiche_Intervention_Corrective.Code_MachineComboBox1.Enabled = False
                Fiche_Intervention_Corrective.N_IntervTextBox1.Enabled = False
                Fiche_Intervention_Corrective.NomPrenomComboBox.Enabled = False
                Fiche_Intervention_Corrective.Validation_ResponsableCheckBox1.Enabled = False
                Fiche_Intervention_Corrective.Date_IntervDateTimePicker1.Enabled = False
                Fiche_Intervention_Corrective.Validation_TechnisienCheckBox1.Enabled = True
                Fiche_Intervention_Corrective.PersonnelDataGridView.ReadOnly = False
                Fiche_Intervention_Corrective.DureeTextBox1.Enabled = False
                Fiche_Intervention_Corrective.Date_ArretDateTimePicker1.Enabled = False
                Fiche_Intervention_Corrective.Date_RealisationDateTimePicker1.Enabled = True
                Fiche_Intervention_Corrective.DataGridView1.ReadOnly = False
            End If
        End If

        Fiche_Intervention_Corrective.MOD_AJOUT = True
        Fiche_Intervention_Corrective.DATE_DERNIER()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If IntervCorrDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = IntervCorrDataGridView.SelectedRows(0)
            If selectedRow.Cells("ValidationResponsableDataGridViewCheckBoxColumn").Value = True Then
                MsgBox("Impossible de supprimer")
                Exit Sub
            End If
        End If
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            If IntervCorrDataGridView.SelectedRows.Count > 0 Then
                ' Récupère la ligne sélectionnée
                Dim selectedRow As DataGridViewRow = IntervCorrDataGridView.SelectedRows(0)
                Fiche_Intervention_Corrective.InterventionTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "corrective")
                Fiche_Intervention_Corrective.Ligne_Interv_PrevTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "corrective")
                Fiche_Intervention_Corrective.Article_InterventionTableAdapter.DeleteQuery(selectedRow.Cells("NIntervDataGridViewTextBoxColumn").Value.ToString(), "corrective")
            End If

            MsgBox("OK")
            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "corrective")
            Else
                Me.InterventionTableAdapter.Fill_type_nom(Me.DataSet_Intervention.Intervention, "corrective", Form1.ToolStripStatusNom.Text)
            End If
            Me.IntervCorrDataGridView.Update()
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text <> "" Then
            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                Me.InterventionTableAdapter.Fill_MACH(Me.DataSet_Intervention.Intervention, "corrective", ComboBox1.Text)
            Else
                Me.InterventionTableAdapter.Fill_MACHT(Me.DataSet_Intervention.Intervention, "corrective", Form1.ToolStripStatusNom.Text, ComboBox1.Text)
            End If
        Else
            If Form1.ToolStripStatusspec.Text = "Responsable" Then
                Me.InterventionTableAdapter.Fill_type(Me.DataSet_Intervention.Intervention, "corrective")
            Else
                Me.InterventionTableAdapter.Fill_type_nom(Me.DataSet_Intervention.Intervention, "corrective", Form1.ToolStripStatusNom.Text)
            End If
        End If
    End Sub
End Class