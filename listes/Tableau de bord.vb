Public Class Tableau_de_bord
    Public MODE_LOAD As Boolean

    Private Sub Tableau_de_bord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MODE_LOAD = True

        Me.DateTimePicker1.Value = "01/01/" & Today.Year
        Me.DateTimePicker2.Value = Today

        Me.STAT_LOAD()

        Me.MODE_LOAD = False
    End Sub

    Public Sub STAT_LOAD()
        'TODO: cette ligne de code charge les données dans la table 'GMAODataSet_VUE.VUE_TTR_MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Button1.ForeColor = Color.Black
        Me.Button2.ForeColor = Color.Black
        Me.Button3.ForeColor = Color.Black
        Me.Button4.ForeColor = Color.Black
        Me.Button5.ForeColor = Color.Black
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Me.Button1.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & " en retard : " & Me.Machine_Interv_PrevTableAdapter.COUNT_DEPASSE(Today) & vbCrLf & " Nombre des machines = " & Me.Machine_Interv_PrevTableAdapter.COUNT_DEPASSE_M(Today)
            Me.Button5.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & " à faire : " & Me.Machine_Interv_PrevTableAdapter.COUNT_PREV(Today, Me.NumericUpDown2.Value) & vbCrLf & " Nombre des machines = " & Me.Machine_Interv_PrevTableAdapter.COUNT_PREV_M(Today, Me.NumericUpDown2.Value)
            Me.Button2.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & vbCrLf & "Non encore valider par : " & vbCrLf & vbCrLf & "  Responsable : " & Me.InterventionTableAdapter.COUNT_R("préventive") & vbCrLf & "  Technicien : " & Me.InterventionTableAdapter.COUNT_T("préventive")
            Me.Button3.Text = vbCrLf & "        Intervention Corrective " & vbCrLf & vbCrLf & "Non encore valider par : " & vbCrLf & vbCrLf & "  Responsable : " & Me.InterventionTableAdapter.COUNT_R("corrective") & vbCrLf & "  Technicien : " & Me.InterventionTableAdapter.COUNT_T("corrective")
            Me.Button4.Text = Me.ArticlesTableAdapter.STOCKMIN() & " Article " & vbCrLf & vbCrLf & "en niveau de stock critque" & vbCrLf
        ElseIf Form1.ToolStripStatusspec.Text = "Technicien" Then
            Me.Button1.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & " en retard : " & "***" & vbCrLf & " Nombre des machines = " & "***"
            Me.Button5.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & " à faire : " & "***" & vbCrLf & " Nombre des machines = " & "***"
            Me.Button2.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & vbCrLf & "Non encore valider par : " & vbCrLf & vbCrLf & "  Responsable : " & "***" & vbCrLf & "  Technicien : " & Me.InterventionTableAdapter.COUNT_TECH("préventive", Form1.ToolStripStatusNom.Text)
            Me.Button3.Text = vbCrLf & "        Intervention Corrective " & vbCrLf & vbCrLf & "Non encore valider par : " & vbCrLf & vbCrLf & "  Responsable : " & "***" & vbCrLf & "  Technicien : " & Me.InterventionTableAdapter.COUNT_TECH("corrective", Form1.ToolStripStatusNom.Text)
            Me.Button4.Text = "***" & " Article " & vbCrLf & vbCrLf & "en niveau de stock critque" & vbCrLf
        End If

        Me.VUE_TOP10TableAdapter.Fill(Me.GMAODataSet_VUE.VUE_TOP10, DateTimePicker1.Value, DateTimePicker2.Value)
        Me.ReportViewer1.RefreshReport()
        Me.VUE_TTR_MACHINETableAdapter.Fill(Me.GMAODataSet_VUE.VUE_TTR_MACHINE, DateTimePicker1.Value, DateTimePicker2.Value)
        Me.ReportViewer2.RefreshReport()
        Me.VUE_TTR_ALLTableAdapter.Fill(Me.GMAODataSet_VUE.VUE_TTR_ALL, DateTimePicker1.Value, DateTimePicker2.Value)
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer4.RefreshReport()
        Me.ReportViewer5.RefreshReport()
        Me.ReportViewer6.RefreshReport()
    End Sub
    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        Me.Button5.Text = vbCrLf & "        Intervention Préventive " & vbCrLf & " à faire : " & Me.Machine_Interv_PrevTableAdapter.COUNT_PREV(Today, Me.NumericUpDown2.Value) & vbCrLf & " Nombre des machines = " & Me.Machine_Interv_PrevTableAdapter.COUNT_PREV_M(Today, Me.NumericUpDown2.Value)
    End Sub

    Private Sub DateTimePicker1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Validated
        If Me.MODE_LOAD = True Then Exit Sub

        Me.STAT_LOAD()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        '
    End Sub
    Private Sub DateTimePicker2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Validated
        If Me.MODE_LOAD = True Then Exit Sub

        Me.STAT_LOAD()
    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        '
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Liste_Article.TAB_BORD = True
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Article.Show()
            Liste_Article.ArticlesTableAdapter.Fill_ART_MIN(Liste_Article.DataSet_Stock.Articles)
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Liste_Interv_Corrective.TAB_BORD = True
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Interv_Corrective.Show()
            Liste_Interv_Corrective.InterventionTableAdapter.Fill_INTERV(Liste_Interv_Corrective.DataSet_Intervention.Intervention, "corrective")
        Else
            Liste_Interv_Corrective.Show()
            Liste_Interv_Corrective.InterventionTableAdapter.Fill_INTERV_TECH(Liste_Interv_Corrective.DataSet_Intervention.Intervention, "corrective", Form1.ToolStripStatusNom.Text)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Liste_Interv_Preventive.TAB_BORD = True
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Interv_Preventive.Show()
            Liste_Interv_Preventive.InterventionTableAdapter.Fill_INTERV(Liste_Interv_Preventive.DataSet_Intervention.Intervention, "préventive")
        Else
            Liste_Interv_Preventive.Show()
            Liste_Interv_Preventive.InterventionTableAdapter.Fill_INTERV_TECH(Liste_Interv_Preventive.DataSet_Intervention.Intervention, "préventive", Form1.ToolStripStatusNom.Text)
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Form1.PictureBox2.Visible = True
        Form1.Label1.Visible = True
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Liste_Machine.TAB_BORD = True
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Machine.Show()
            Liste_Machine.MachineTableAdapter.Fill_PREV(Liste_Machine.DataSet_Machine.Machine, Today, Me.NumericUpDown2.Value)
            Liste_Machine.button_add_prev.Visible = True
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Liste_Machine.TAB_BORD = True
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Liste_Machine.Show()
            Liste_Machine.MachineTableAdapter.Fill_DEPASSE(Liste_Machine.DataSet_Machine.Machine, Today)
            Liste_Machine.button_add_prev.Visible = True
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                Me.VUE_TOP10TableAdapter.Fill(Me.GMAODataSet_VUE.VUE_TOP10, DateTimePicker1.Value, DateTimePicker2.Value)
                Me.ReportViewer1.RefreshReport()
            Case 1
                Me.VUE_TTR_MACHINETableAdapter.Fill(Me.GMAODataSet_VUE.VUE_TTR_MACHINE, DateTimePicker1.Value, DateTimePicker2.Value)
                Me.ReportViewer2.RefreshReport()
            Case 2
                Me.VUE_TTR_ALLTableAdapter.Fill_TTR(Me.GMAODataSet_VUE.VUE_TTR_ALL, DateTimePicker1.Value, DateTimePicker2.Value)
                Me.ReportViewer3.RefreshReport()
            Case 3
                Me.VUE_TTR_ALLTableAdapter.Fill_DT(Me.GMAODataSet_VUE.VUE_TTR_ALL, DateTimePicker1.Value, DateTimePicker2.Value)
                Me.ReportViewer4.RefreshReport()
            Case 4
                Me.VUE_TTR_ALLTableAdapter.Fill_UT(Me.GMAODataSet_VUE.VUE_TTR_ALL, DateTimePicker1.Value, DateTimePicker2.Value)
                Me.ReportViewer5.RefreshReport()
            Case 5
                Me.VUE_TTR_ALLTableAdapter.Fill_TBF(Me.GMAODataSet_VUE.VUE_TTR_ALL, DateTimePicker1.Value, DateTimePicker2.Value)
                Me.ReportViewer6.RefreshReport()
        End Select
    End Sub

    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        
    End Sub
End Class