Public Class Fiche_Article

    Private Sub Fiche_Article_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Lot'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        '   Me.Articles_LotTableAdapter.Fill(Me.DataSet_Stock.Articles_Lot)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Articles_Famille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Articles_FamilleTableAdapter.Fill(Me.DataSet_Stock.Articles_Famille)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Caracteristiques'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Caracteristiques)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enregistrer.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.ArticlesBindingSource.EndEdit()
        Me.ArticlesTableAdapter.Update(Me.DataSet_Stock.Articles)

        Me.Articles_CaracteristiquesBindingSource.EndEdit()
        Me.Articles_CaracteristiquesTableAdapter.Update(Me.DataSet_Stock.Articles_Caracteristiques)

        Me.ArticlesLotBindingSource.EndEdit()
        Me.Articles_LotTableAdapter.Update(Me.DataSet_Stock.Articles_Lot)

        '  Me.PictureBox1.Update()
        Me.IMAGE_SAVE()

        MsgBox("OK")
        Liste_Article.ArticlesTableAdapter.Fill(Liste_Article.DataSet_Stock.Articles)
        Liste_Article.PersonnelDataGridView.Update()

        Me.Close()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Articles_FamilleTableAdapter.Fill(Me.DataSet_Stock.Articles_Famille)
        Me.CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Caracteristiques)
        Me.ArticlesBindingSource.CancelEdit()
        Me.Articles_CaracteristiquesBindingSource.CancelEdit()
        Me.ArticlesLotBindingSource.CancelEdit()
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine_Interv_Prev'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticlesTableAdapter.Fill_code(Me.DataSet_Stock.Articles, Code_ArticlesTextBox.Text)
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Machine.Machine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Articles_CaracteristiquesTableAdapter.Fill_code(Me.DataSet_Stock.Articles_Caracteristiques, Code_ArticlesTextBox.Text)
        Me.Articles_LotTableAdapter.Fill_code(Me.DataSet_Stock.Articles_Lot, Code_ArticlesTextBox.Text)
        Me.IMAGE_LOAD(Code_ArticlesTextBox.Text)
    End Sub

    Public Sub IMAGE_SAVE()
        Dim FoldersName As String = Application.StartupPath + "\ArticleImage"

        'If CreateFolders(FoldersName) = False Then FoldersName = "" : Exit Sub

        Try
            Me.PictureBox1.Image.Save(FoldersName & "\" & Me.Code_ArticlesTextBox.Text & ".jpg")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub IMAGE_LOAD(ByVal IMAG As String)
        Dim FoldersName As String = Application.StartupPath + "\ArticleImage"

        Me.PictureBox1.Image = Nothing

        If My.Computer.FileSystem.DirectoryExists(FoldersName) = True Then
            If My.Computer.FileSystem.FileExists(FoldersName & "\" & IMAG & ".jpg") = True Then
                Me.PictureBox1.Image = Image.FromFile(FoldersName & "\" & IMAG & ".jpg")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            ' Charge l'image sélectionnée dans le contrôle PictureBox
            Me.PictureBox1.ImageLocation = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Articles_CaracteristiquesDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Articles_CaracteristiquesDataGridView.RowsAdded
        If e.RowIndex = 0 Then Exit Sub

        Articles_CaracteristiquesDataGridView.Rows(e.RowIndex - 1).Cells("code_article").Value = Code_ArticlesTextBox.Text

    End Sub

    Private Sub Articles_CaracteristiquesDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Articles_CaracteristiquesDataGridView.RowValidating
        If e.RowIndex = 0 Then Exit Sub

        Articles_CaracteristiquesDataGridView.Rows(e.RowIndex - 1).Cells("code_article").Value = Code_ArticlesTextBox.Text
    End Sub

    Private Sub PersonnelDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles PersonnelDataGridView.RowsAdded
        If e.RowIndex = 0 Then Exit Sub

        Me.PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("CodeArticlesDataGridViewTextBoxColumn").Value = Code_ArticlesTextBox.Text
    End Sub

    Private Sub PersonnelDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles PersonnelDataGridView.RowValidating
        If e.RowIndex = 0 Then Exit Sub

        Me.PersonnelDataGridView.Rows(e.RowIndex - 1).Cells("CodeArticlesDataGridViewTextBoxColumn").Value = Code_ArticlesTextBox.Text
    End Sub

  
End Class