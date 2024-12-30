Public Class Liste_Article
    Public TAB_BORD As Boolean
    Private Sub Liste_Article_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'If Me.ArticlesTableAdapter.Fill_ART_MIN(Me.DataSet_Stock.Articles) Then
        '  Form1.PictureBox2.Visible = False
        If TAB_BORD = False Then
            Form1.PictureBox2.Visible = True
            Form1.Label1.Visible = True
        End If
    End Sub

    Private Sub Liste_Article_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
    End Sub

    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click
        If Form1.ToolStripStatusspec.Text = "Responsable" Then
            Fiche_Article.Show()
            Fiche_Article.ArticlesBindingSource.AddNew()
            Fiche_Article.Button1.Enabled = False

            'Fiche_Article.Articles_CaracteristiquesBindingSource.AddNew()
            'Fiche_Article.Articles_LotBindingSource.AddNew()
            Fiche_Article.Code_ArticlesTextBox.Enabled = True
            Fiche_Article.FamilleComboBox.Enabled = True
            Fiche_Article.DesignationTextBox.Enabled = True
            Fiche_Article.QuantiteTextBox.Enabled = True
            Fiche_Article.MaxTextBox.Enabled = True
            Fiche_Article.MinTextBox.Enabled = True
            Fiche_Article.PersonnelDataGridView.Enabled = True
            Fiche_Article.Articles_CaracteristiquesDataGridView.Enabled = True
            Fiche_Article.PictureBox1.Enabled = True
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifier.Click
        Fiche_Article.Show()
        Fiche_Article.Button1.Enabled = True
        ' Vérifie que l'utilisateur a sélectionné une ligne
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)

            Fiche_Article.ArticlesBindingSource.CancelEdit()
            Fiche_Article.Articles_CaracteristiquesBindingSource.CancelEdit()
            Fiche_Article.ArticlesLotBindingSource.CancelEdit()
            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            Fiche_Article.ArticlesTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            Fiche_Article.Articles_CaracteristiquesTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles_Caracteristiques, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Article.Articles_LotTableAdapter.Fill_code(Fiche_Article.DataSet_Stock.Articles_Lot, selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Article.IMAGE_LOAD(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())

            Fiche_Article.Code_ArticlesTextBox.Enabled = False
            Fiche_Article.FamilleComboBox.Enabled = True
            Fiche_Article.DesignationTextBox.Enabled = True
            Fiche_Article.QuantiteTextBox.Enabled = True
            Fiche_Article.MaxTextBox.Enabled = True
            Fiche_Article.MinTextBox.Enabled = True
            Fiche_Article.PersonnelDataGridView.Enabled = True
            Fiche_Article.Articles_CaracteristiquesDataGridView.Enabled = True
            Fiche_Article.PictureBox1.Enabled = True

        End If
    End Sub

    Private Sub suprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suprimer.Click
        If MsgBox("Voulez vous supprimer?", vbYesNo) = vbNo Then Exit Sub
        If PersonnelDataGridView.SelectedRows.Count > 0 Then
            ' Récupère la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = PersonnelDataGridView.SelectedRows(0)
            Fiche_Article.ArticlesTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Article.Articles_CaracteristiquesTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
            Fiche_Article.Articles_LotTableAdapter.DeleteQuery(selectedRow.Cells("CodeArticlesDataGridViewTextBoxColumn").Value.ToString())
        End If

        MsgBox("OK")
        Me.ArticlesTableAdapter.Fill(Me.DataSet_Stock.Articles)
        Me.PersonnelDataGridView.Update()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class