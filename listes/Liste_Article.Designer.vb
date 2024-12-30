<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Article
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Article))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeArticlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmplacementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabriquantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suprimer = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.ajouter = New System.Windows.Forms.Button()
        Me.ArticlesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(55, 189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 3)
        Me.Panel2.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(55, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 3)
        Me.Panel1.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(552, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(344, 3)
        Me.Panel3.TabIndex = 57
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DataSource = Me.ArticlesBindingSource
        Me.ComboBox1.DisplayMember = "Code_Articles"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(187, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 41)
        Me.ComboBox1.TabIndex = 56
        Me.ComboBox1.ValueMember = "Code_Articles"
        '
        'ArticlesBindingSource
        '
        Me.ArticlesBindingSource.DataMember = "Articles"
        Me.ArticlesBindingSource.DataSource = Me.DataSet_Stock
        '
        'DataSet_Stock
        '
        Me.DataSet_Stock.DataSetName = "DataSet_Stock"
        Me.DataSet_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(552, 115)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 44)
        Me.TextBox1.TabIndex = 55
        Me.TextBox1.Text = "Recherche"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1186, 491)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des Articles"
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToAddRows = False
        Me.PersonnelDataGridView.AllowUserToDeleteRows = False
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
        Me.PersonnelDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.PersonnelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeArticlesDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.QuantiteDataGridViewTextBoxColumn, Me.MaxDataGridViewTextBoxColumn, Me.MinDataGridViewTextBoxColumn, Me.EmplacementDataGridViewTextBoxColumn, Me.FamilleDataGridViewTextBoxColumn, Me.FabriquantDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.ArticlesBindingSource
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 29)
        Me.PersonnelDataGridView.MultiSelect = False
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.ReadOnly = True
        Me.PersonnelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1180, 459)
        Me.PersonnelDataGridView.TabIndex = 30
        '
        'CodeArticlesDataGridViewTextBoxColumn
        '
        Me.CodeArticlesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CodeArticlesDataGridViewTextBoxColumn.DataPropertyName = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.HeaderText = "Code Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Name = "CodeArticlesDataGridViewTextBoxColumn"
        Me.CodeArticlesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeArticlesDataGridViewTextBoxColumn.Width = 161
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesignationDataGridViewTextBoxColumn.Width = 300
        '
        'QuantiteDataGridViewTextBoxColumn
        '
        Me.QuantiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.QuantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.QuantiteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.QuantiteDataGridViewTextBoxColumn.HeaderText = "Quantite"
        Me.QuantiteDataGridViewTextBoxColumn.Name = "QuantiteDataGridViewTextBoxColumn"
        Me.QuantiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantiteDataGridViewTextBoxColumn.Width = 119
        '
        'MaxDataGridViewTextBoxColumn
        '
        Me.MaxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MaxDataGridViewTextBoxColumn.DataPropertyName = "Max"
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.MaxDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MaxDataGridViewTextBoxColumn.HeaderText = "Max"
        Me.MaxDataGridViewTextBoxColumn.Name = "MaxDataGridViewTextBoxColumn"
        Me.MaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaxDataGridViewTextBoxColumn.Width = 77
        '
        'MinDataGridViewTextBoxColumn
        '
        Me.MinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MinDataGridViewTextBoxColumn.DataPropertyName = "Min"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.MinDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MinDataGridViewTextBoxColumn.HeaderText = "Min"
        Me.MinDataGridViewTextBoxColumn.Name = "MinDataGridViewTextBoxColumn"
        Me.MinDataGridViewTextBoxColumn.ReadOnly = True
        Me.MinDataGridViewTextBoxColumn.Width = 73
        '
        'EmplacementDataGridViewTextBoxColumn
        '
        Me.EmplacementDataGridViewTextBoxColumn.DataPropertyName = "Emplacement"
        Me.EmplacementDataGridViewTextBoxColumn.HeaderText = "Emplacement"
        Me.EmplacementDataGridViewTextBoxColumn.Name = "EmplacementDataGridViewTextBoxColumn"
        Me.EmplacementDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmplacementDataGridViewTextBoxColumn.Width = 200
        '
        'FamilleDataGridViewTextBoxColumn
        '
        Me.FamilleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FamilleDataGridViewTextBoxColumn.DataPropertyName = "Famille"
        Me.FamilleDataGridViewTextBoxColumn.HeaderText = "Famille"
        Me.FamilleDataGridViewTextBoxColumn.Name = "FamilleDataGridViewTextBoxColumn"
        Me.FamilleDataGridViewTextBoxColumn.ReadOnly = True
        Me.FamilleDataGridViewTextBoxColumn.Visible = False
        '
        'FabriquantDataGridViewTextBoxColumn
        '
        Me.FabriquantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FabriquantDataGridViewTextBoxColumn.DataPropertyName = "Fabriquant"
        Me.FabriquantDataGridViewTextBoxColumn.HeaderText = "Fabriquant"
        Me.FabriquantDataGridViewTextBoxColumn.Name = "FabriquantDataGridViewTextBoxColumn"
        Me.FabriquantDataGridViewTextBoxColumn.ReadOnly = True
        Me.FabriquantDataGridViewTextBoxColumn.Visible = False
        '
        'suprimer
        '
        Me.suprimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.suprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.suprimer.FlatAppearance.BorderSize = 0
        Me.suprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.suprimer.Image = CType(resources.GetObject("suprimer.Image"), System.Drawing.Image)
        Me.suprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.suprimer.Location = New System.Drawing.Point(806, 23)
        Me.suprimer.Name = "suprimer"
        Me.suprimer.Size = New System.Drawing.Size(334, 55)
        Me.suprimer.TabIndex = 54
        Me.suprimer.Text = "Suprimer"
        Me.suprimer.UseVisualStyleBackColor = False
        '
        'modifier
        '
        Me.modifier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.modifier.FlatAppearance.BorderSize = 0
        Me.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.modifier.Image = CType(resources.GetObject("modifier.Image"), System.Drawing.Image)
        Me.modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modifier.Location = New System.Drawing.Point(431, 23)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(334, 55)
        Me.modifier.TabIndex = 53
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = False
        '
        'ajouter
        '
        Me.ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ajouter.FlatAppearance.BorderSize = 0
        Me.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ajouter.Image = CType(resources.GetObject("ajouter.Image"), System.Drawing.Image)
        Me.ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ajouter.Location = New System.Drawing.Point(55, 23)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(334, 55)
        Me.ajouter.TabIndex = 52
        Me.ajouter.Text = "Ajouter"
        Me.ajouter.UseVisualStyleBackColor = False
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Liste_Article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 728)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.suprimer)
        Me.Controls.Add(Me.modifier)
        Me.Controls.Add(Me.ajouter)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Liste_Article"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste_Article"
        Me.TopMost = True
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents suprimer As System.Windows.Forms.Button
    Friend WithEvents modifier As System.Windows.Forms.Button
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents CodeArticlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmplacementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabriquantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
