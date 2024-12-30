Public Class settings

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.DEPOT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DEPOTTableAdapter.Fill(Me.DataSet_Stock.DEPOT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Panne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_PanneTableAdapter.Fill(Me.DataSet_Intervention.Liste_Panne)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Liste_Intervention'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Liste_Intervention)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Articles_FamilleTableAdapter.Fill(Me.DataSet_Stock.Articles_Famille)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Intervention.Observations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ObservationsTableAdapter.Fill(Me.DataSet_Intervention.Observations)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Caracteristiques'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Caracteristiques)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Type_Frequence'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Type_FrequenceTableAdapter.Fill(Me.DataSet_Machine.Type_Frequence)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            fiche_type_frequence.Show()
            fiche_type_frequence.Type_FrequenceBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer1.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            fiche_type_frequence.Type_FrequenceTableAdapter.DeleteQuery(selectedRow.Cells("CodeDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.Type_FrequenceTableAdapter.Fill(Me.DataSet_Machine.Type_Frequence)
        Me.PersonnelDataGridView.Update()
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
    End Sub

    Private Sub PersonnelDataGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonnelDataGridView.Click

        Me.ajouter1.Visible = True
        Me.supprimer1.Visible = True
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub



    
    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Me.ajouter2.Visible = True
        Me.supprimer2.Visible = True
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        Me.ajouter3.Visible = True
        Me.supprimer3.Visible = True
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub

    Private Sub DataGridView3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView3.Click
        Me.ajouter4.Visible = True
        Me.supprimer4.Visible = True
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub

    Private Sub DataGridView6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView6.Click
        Me.ajouter5.Visible = True
        Me.supprimer5.Visible = True
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub

    Private Sub DataGridView5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView5.Click
        Me.ajouter6.Visible = True
        Me.supprimer6.Visible = True
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub

    Private Sub DataGridView4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView4.Click
        Me.ajouter7.Visible = True
        Me.supprimer7.Visible = True
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
        Me.ajouter1.Visible = False
        Me.supprimer1.Visible = False
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.PictureBox2.Visible = True
        Form1.Label1.Visible = True
    End Sub

    Private Sub ajouter6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter6.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            fiche_des_pannes.Show()
            fiche_des_pannes.Liste_PanneBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub supprimer6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer6.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If DataGridView5.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView5.SelectedRows(0)
            fiche_des_pannes.Liste_PanneTableAdapter.DeleteQuery(selectedRow.Cells("CodePanneDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.Liste_PanneTableAdapter.Fill(Me.DataSet_Intervention.Liste_Panne)
        Me.DataGridView5.Update()
        Me.ajouter6.Visible = False
        Me.supprimer6.Visible = False
    End Sub

    Private Sub ajouter2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter2.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Caracteristique.Show()
            Fiche_Caracteristique.CaracteristiquesBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub supprimer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer2.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Fiche_Caracteristique.CaracteristiquesTableAdapter.DeleteQuery(selectedRow.Cells("CodeDataGridViewTextBoxColumn1").Value.ToString())

        End If

        MsgBox("OK")
        Me.CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Caracteristiques)
        Me.DataGridView1.Update()
        Me.ajouter2.Visible = False
        Me.supprimer2.Visible = False
    End Sub

    Private Sub ajouter5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter5.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_interv.Show()
            Fiche_interv.Liste_InterventionBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub supprimer5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer5.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If DataGridView6.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView6.SelectedRows(0)
            Fiche_interv.Liste_InterventionTableAdapter.DeleteQuery(selectedRow.Cells("CodeIntervDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.Liste_InterventionTableAdapter.Fill(Me.DataSet_Intervention.Liste_Intervention)
        Me.DataGridView6.Update()
        Me.ajouter5.Visible = False
        Me.supprimer5.Visible = False
    End Sub

    Private Sub ajouter3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter3.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Observations.Show()
            Fiche_Observations.ObservationsBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub supprimer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer3.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If DataGridView2.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
            Fiche_Observations.ObservationsTableAdapter.DeleteQuery(selectedRow.Cells("CodeDataGridViewTextBoxColumn2").Value.ToString())

        End If

        MsgBox("OK")
        Me.ObservationsTableAdapter.Fill(Me.DataSet_Intervention.Observations)
        Me.DataGridView2.Update()
        Me.ajouter3.Visible = False
        Me.supprimer3.Visible = False
    End Sub

    Private Sub ajouter4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter4.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_famille.Show()
            Fiche_famille.Articles_FamilleBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub ajouter7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter7.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_depot.Show()
            Fiche_depot.DEPOTBindingSource.AddNew()
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub supprimer4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer4.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If DataGridView3.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)
            Fiche_famille.Articles_FamilleTableAdapter.DeleteQuery(selectedRow.Cells("CodeDataGridViewTextBoxColumn3").Value.ToString())

        End If

        MsgBox("OK")
        Me.Articles_FamilleTableAdapter.Fill(Me.DataSet_Stock.Articles_Famille)
        Me.DataGridView3.Update()
        Me.ajouter4.Visible = False
        Me.supprimer4.Visible = False
    End Sub

    Private Sub supprimer7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer7.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If DataGridView4.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView4.SelectedRows(0)
            Fiche_depot.DEPOTTableAdapter.DeleteQuery(selectedRow.Cells("CodeDepotDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.DEPOTTableAdapter.Fill(Me.DataSet_Stock.DEPOT)
        Me.DataGridView4.Update()
        Me.ajouter7.Visible = False
        Me.supprimer7.Visible = False
    End Sub
End Class