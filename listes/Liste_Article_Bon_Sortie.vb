Public Class Liste_Article_Bon_Sortie



  
    Private Sub Liste_Article_Bon_Sortie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Sortie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_SortieTableAdapter.Fill(Me.DataSet_Stock.Bon_Sortie)

    End Sub

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Article_Bon_entree.Show()
            Fiche_Article_Bon_Sortie.Bon_SortieBindingSource.AddNew()
            Fiche_Article_Bon_Sortie.N_Bon_sortieTextBox.Enabled = True
            Fiche_Article_Bon_Sortie.Date_Bon_sortieDateTimePicker.Enabled = True
            Fiche_Article_Bon_Sortie.DepotComboBox.Enabled = True
            Fiche_Article_Bon_Sortie.Total_HTTextBox.Enabled = True
            Fiche_Article_Bon_Sortie.Total_TVATextBox.Enabled = True
            Fiche_Article_Bon_Sortie.Total_TTCTextBox.Enabled = True
            Fiche_Article_Bon_Sortie.PersonnelDataGridView.Enabled = True

        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifier.Click
        Fiche_Article_Bon_Sortie.Show()

        ' Vérifie que l'utilisateur a sélectionné une ligne
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)

            Fiche_Article_Bon_Sortie.Bon_SortieBindingSource.CancelEdit()
            Fiche_Article_Bon_Sortie.BonSortieLigneBindingSource.CancelEdit()

            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            ' Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles_Caracteristiques, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())            
            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            ' Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles_Caracteristiques, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())

            Fiche_Article_Bon_Sortie.N_Bon_sortieTextBox.Enabled = False
            Fiche_Article_Bon_Sortie.Date_Bon_sortieDateTimePicker.Enabled = True
            Fiche_Article_Bon_Sortie.DepotComboBox.Enabled = True
            Fiche_Article_Bon_Sortie.Total_HTTextBox.Enabled = True
            Fiche_Article_Bon_Sortie.Total_TVATextBox.Enabled = True
            Fiche_Article_Bon_Sortie.Total_TTCTextBox.Enabled = True
            Fiche_Article_Bon_Sortie.PersonnelDataGridView.Enabled = True
        End If
    End Sub

    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            'Fiche_Article_Bon_entree.Bon_EntreeTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            '  Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.Bon_SortieTableAdapter.Fill(Me.DataSet_Stock.Bon_Sortie)
        Me.PersonnelDataGridView.Update()
    End Sub
End Class