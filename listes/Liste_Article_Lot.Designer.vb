﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Article_Lot
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Article_Lot))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet_Stock = New Global.GMAO_Wassim_Skander.DataSet_Stock()
        Me.ArticlesLotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Articles_LotTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_LotTableAdapter()
        Me.CodeLotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeArticlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NserieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAchatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMserviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateGarantieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesLotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(21, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 3)
        Me.Panel2.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(21, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 3)
        Me.Panel1.TabIndex = 40
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
        Me.PersonnelDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.PersonnelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeLotDataGridViewTextBoxColumn, Me.CodeArticlesDataGridViewTextBoxColumn, Me.NserieDataGridViewTextBoxColumn, Me.DateAchatDataGridViewTextBoxColumn, Me.DateMserviceDataGridViewTextBoxColumn, Me.DateGarantieDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.ArticlesLotBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PersonnelDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(21, 191)
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1168, 468)
        Me.PersonnelDataGridView.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(518, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(344, 3)
        Me.Panel3.TabIndex = 39
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Matricule", "Nom", "Prenom", "Specialite", "Qualification"})
        Me.ComboBox1.Location = New System.Drawing.Point(153, 111)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 41)
        Me.ComboBox1.TabIndex = 37
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(518, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 44)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "Recherche"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(772, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(334, 48)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Suprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(397, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(334, 48)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(21, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(334, 48)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataSet_Stock
        '
        Me.DataSet_Stock.DataSetName = "DataSet_Stock"
        Me.DataSet_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticlesLotBindingSource
        '
        Me.ArticlesLotBindingSource.DataMember = "Articles_Lot"
        Me.ArticlesLotBindingSource.DataSource = Me.DataSet_Stock
        '
        'Articles_LotTableAdapter
        '
        Me.Articles_LotTableAdapter.ClearBeforeFill = True
        '
        'CodeLotDataGridViewTextBoxColumn
        '
        Me.CodeLotDataGridViewTextBoxColumn.DataPropertyName = "Code_Lot"
        Me.CodeLotDataGridViewTextBoxColumn.HeaderText = "Code_Lot"
        Me.CodeLotDataGridViewTextBoxColumn.Name = "CodeLotDataGridViewTextBoxColumn"
        '
        'CodeArticlesDataGridViewTextBoxColumn
        '
        Me.CodeArticlesDataGridViewTextBoxColumn.DataPropertyName = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.HeaderText = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Name = "CodeArticlesDataGridViewTextBoxColumn"
        '
        'NserieDataGridViewTextBoxColumn
        '
        Me.NserieDataGridViewTextBoxColumn.DataPropertyName = "N_serie"
        Me.NserieDataGridViewTextBoxColumn.HeaderText = "N_serie"
        Me.NserieDataGridViewTextBoxColumn.Name = "NserieDataGridViewTextBoxColumn"
        '
        'DateAchatDataGridViewTextBoxColumn
        '
        Me.DateAchatDataGridViewTextBoxColumn.DataPropertyName = "Date_Achat"
        Me.DateAchatDataGridViewTextBoxColumn.HeaderText = "Date_Achat"
        Me.DateAchatDataGridViewTextBoxColumn.Name = "DateAchatDataGridViewTextBoxColumn"
        '
        'DateMserviceDataGridViewTextBoxColumn
        '
        Me.DateMserviceDataGridViewTextBoxColumn.DataPropertyName = "Date_Mservice"
        Me.DateMserviceDataGridViewTextBoxColumn.HeaderText = "Date_Mservice"
        Me.DateMserviceDataGridViewTextBoxColumn.Name = "DateMserviceDataGridViewTextBoxColumn"
        '
        'DateGarantieDataGridViewTextBoxColumn
        '
        Me.DateGarantieDataGridViewTextBoxColumn.DataPropertyName = "Date_Garantie"
        Me.DateGarantieDataGridViewTextBoxColumn.HeaderText = "Date_Garantie"
        Me.DateGarantieDataGridViewTextBoxColumn.Name = "DateGarantieDataGridViewTextBoxColumn"
        '
        'PrixDataGridViewTextBoxColumn
        '
        Me.PrixDataGridViewTextBoxColumn.DataPropertyName = "Prix"
        Me.PrixDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn.Name = "PrixDataGridViewTextBoxColumn"
        '
        'Liste_Lot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 674)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PersonnelDataGridView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Liste_Lot"
        Me.Text = "Liste_Lot"
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesLotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents ArticlesLotBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Articles_LotTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_LotTableAdapter
    Friend WithEvents CodeLotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeArticlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NserieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateAchatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateMserviceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateGarantieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class