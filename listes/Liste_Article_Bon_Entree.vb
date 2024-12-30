Public Class Liste_Article_Bon_Entree
    Private Sub Liste_Article_Bon_Entree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Entree'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_EntreeTableAdapter.Fill(Me.DataSet_Stock.Bon_Entree)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Article_Bon_entree.Show()
            Fiche_Article_Bon_entree.Bon_EntreeBindingSource.AddNew()
            Fiche_Article_Bon_entree.N_Bon_entreeTextBox.Enabled = True
            Fiche_Article_Bon_entree.Date_Bon_entreeDateTimePicker.Enabled = True
            Fiche_Article_Bon_entree.DepotComboBox.Enabled = True
            Fiche_Article_Bon_entree.Total_HTTextBox.Enabled = True
            Fiche_Article_Bon_entree.Total_TVATextBox.Enabled = True
            Fiche_Article_Bon_entree.Total_TTCTextBox.Enabled = True
            Fiche_Article_Bon_entree.PersonnelDataGridView.Enabled = True

        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fiche_Article_Bon_entree.Show()

        ' Vérifie que l'utilisateur a sélectionné une ligne
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)

            Fiche_Article_Bon_entree.Bon_EntreeBindingSource.CancelEdit()
            Fiche_Article_Bon_entree.BonEntreeLigneBindingSource.CancelEdit()

            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            Fiche_Article_Bon_entree.Bon_EntreeTableAdapter.Fill_BONE(Fiche_Article_Bon_entree.DataSet_Stock.Bon_Entree, selectedRow.Cells("NBonentreeDataGridViewTextBoxColumn").Value.ToString())
            ' Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles_Caracteristiques, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.Fill_BONE(Fiche_Article_Bon_entree.DataSet_Stock.Bon_Entree_Ligne, selectedRow.Cells("NBonentreeDataGridViewTextBoxColumn").Value.ToString())

            Fiche_Article_Bon_entree.N_Bon_entreeTextBox.Enabled = False
            Fiche_Article_Bon_entree.Date_Bon_entreeDateTimePicker.Enabled = True
            Fiche_Article_Bon_entree.DepotComboBox.Enabled = True
            Fiche_Article_Bon_entree.Total_HTTextBox.Enabled = True
            Fiche_Article_Bon_entree.Total_TVATextBox.Enabled = True
            Fiche_Article_Bon_entree.Total_TTCTextBox.Enabled = True
            Fiche_Article_Bon_entree.PersonnelDataGridView.Enabled = True


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            Fiche_Article_Bon_entree.Bon_EntreeTableAdapter.DeleteQuery(selectedRow.Cells("NBonentreeDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.DeleteQuery(selectedRow.Cells("NBonentreeDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.Bon_EntreeTableAdapter.Fill(Me.DataSet_Stock.Bon_Entree)
        Me.PersonnelDataGridView.Update()
    End Sub

End Class