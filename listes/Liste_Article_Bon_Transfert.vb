Public Class Liste_Article_Bon_Transfert





    
    Private Sub Liste_Article_Bon_Transfert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Bon_Transfert'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Bon_TransfertTableAdapter.Fill(Me.DataSet_Stock.Bon_Transfert)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Article_Bon_Transfert.Show()
            Fiche_Article_Bon_Transfert.Bon_TransfertBindingSource.AddNew()
            Fiche_Article_Bon_Transfert.N_Bon_TransfertTextBox.Enabled = True
            Fiche_Article_Bon_Transfert.Date_Bon_TransfertDateTimePicker.Enabled = True
            Fiche_Article_Bon_Transfert.Depot_EComboBox.Enabled = True
            Fiche_Article_Bon_Transfert.Depot_SComboBox.Enabled = True
            Fiche_Article_Bon_Transfert.Total_HTTextBox.Enabled = True
            Fiche_Article_Bon_Transfert.Total_TVATextBox.Enabled = True
            Fiche_Article_Bon_Transfert.Total_TTCTextBox.Enabled = True
            Fiche_Article_Bon_Transfert.PersonnelDataGridView.Enabled = True

        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fiche_Article_Bon_Transfert.Show()

        ' Vérifie que l'utilisateur a sélectionné une ligne
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)

            Fiche_Article_Bon_entree.Bon_EntreeBindingSource.CancelEdit()
            Fiche_Article_Bon_entree.BonEntreeLigneBindingSource.CancelEdit()

            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            '(Fiche_Article.DataSet_Stock.Articles, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            ' Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles_Caracteristiques, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())

            Fiche_Article_Bon_Transfert.N_Bon_TransfertTextBox.Enabled = False
            Fiche_Article_Bon_Transfert.Date_Bon_TransfertDateTimePicker.Enabled = True
            Fiche_Article_Bon_Transfert.Depot_EComboBox.Enabled = True
            Fiche_Article_Bon_Transfert.Depot_SComboBox.Enabled = True
            Fiche_Article_Bon_Transfert.Total_HTTextBox.Enabled = True
            Fiche_Article_Bon_Transfert.Total_TVATextBox.Enabled = True
            Fiche_Article_Bon_Transfert.Total_TTCTextBox.Enabled = True
            Fiche_Article_Bon_Transfert.PersonnelDataGridView.Enabled = True


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            'Fiche_Article_Bon_entree.Bon_EntreeTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            '  Fiche_Article_Bon_entree.Bon_Entree_LigneTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())

        End If

        MsgBox("OK")
        Me.Bon_TransfertTableAdapter.Fill(Me.DataSet_Stock.Bon_Transfert)
        Me.PersonnelDataGridView.Update()
    End Sub
End Class