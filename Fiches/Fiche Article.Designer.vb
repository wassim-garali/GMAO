<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Article
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
        Dim QuantiteLabel As System.Windows.Forms.Label
        Dim MinLabel As System.Windows.Forms.Label
        Dim MaxLabel As System.Windows.Forms.Label
        Dim FamilleLabel As System.Windows.Forms.Label
        Dim FabriquantLabel As System.Windows.Forms.Label
        Dim Code_ArticlesLabel1 As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuantiteTextBox = New System.Windows.Forms.TextBox()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.MinTextBox = New System.Windows.Forms.TextBox()
        Me.MaxTextBox = New System.Windows.Forms.TextBox()
        Me.Articles_CaracteristiquesDataGridView = New System.Windows.Forms.DataGridView()
        Me.code_article = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CaracteristiquesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articles_CaracteristiquesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmplacementTextBox = New System.Windows.Forms.TextBox()
        Me.FamilleComboBox = New System.Windows.Forms.ComboBox()
        Me.ArticlesFamilleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.Code_ArticlesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeLotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NserieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAchatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMserviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateGarantieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeArticlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticlesLotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ArticlesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager()
        Me.Articles_CaracteristiquesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_CaracteristiquesTableAdapter()
        Me.CaracteristiquesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.CaracteristiquesTableAdapter()
        Me.Articles_FamilleTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_FamilleTableAdapter()
        Me.Articles_LotTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_LotTableAdapter()
        QuantiteLabel = New System.Windows.Forms.Label()
        MinLabel = New System.Windows.Forms.Label()
        MaxLabel = New System.Windows.Forms.Label()
        FamilleLabel = New System.Windows.Forms.Label()
        FabriquantLabel = New System.Windows.Forms.Label()
        Code_ArticlesLabel1 = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Articles_CaracteristiquesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaracteristiquesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Articles_CaracteristiquesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArticlesFamilleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesLotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuantiteLabel
        '
        QuantiteLabel.AutoSize = True
        QuantiteLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantiteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        QuantiteLabel.Location = New System.Drawing.Point(873, 107)
        QuantiteLabel.Name = "QuantiteLabel"
        QuantiteLabel.Size = New System.Drawing.Size(114, 32)
        QuantiteLabel.TabIndex = 44
        QuantiteLabel.Text = "Quantite"
        '
        'MinLabel
        '
        MinLabel.AutoSize = True
        MinLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MinLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        MinLabel.Location = New System.Drawing.Point(1180, 145)
        MinLabel.Name = "MinLabel"
        MinLabel.Size = New System.Drawing.Size(60, 32)
        MinLabel.TabIndex = 46
        MinLabel.Text = "Min"
        '
        'MaxLabel
        '
        MaxLabel.AutoSize = True
        MaxLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        MaxLabel.Location = New System.Drawing.Point(1190, 59)
        MaxLabel.Name = "MaxLabel"
        MaxLabel.Size = New System.Drawing.Size(64, 32)
        MaxLabel.TabIndex = 48
        MaxLabel.Text = "Max"
        '
        'FamilleLabel
        '
        FamilleLabel.AutoSize = True
        FamilleLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FamilleLabel.Location = New System.Drawing.Point(44, 141)
        FamilleLabel.Name = "FamilleLabel"
        FamilleLabel.Size = New System.Drawing.Size(96, 32)
        FamilleLabel.TabIndex = 50
        FamilleLabel.Text = "Famille"
        '
        'FabriquantLabel
        '
        FabriquantLabel.AutoSize = True
        FabriquantLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FabriquantLabel.Location = New System.Drawing.Point(449, 137)
        FabriquantLabel.Name = "FabriquantLabel"
        FabriquantLabel.Size = New System.Drawing.Size(169, 32)
        FabriquantLabel.TabIndex = 51
        FabriquantLabel.Text = "Emplacement"
        '
        'Code_ArticlesLabel1
        '
        Code_ArticlesLabel1.AutoSize = True
        Code_ArticlesLabel1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_ArticlesLabel1.Location = New System.Drawing.Point(43, 71)
        Code_ArticlesLabel1.Name = "Code_ArticlesLabel1"
        Code_ArticlesLabel1.Size = New System.Drawing.Size(166, 32)
        Code_ArticlesLabel1.TabIndex = 52
        Code_ArticlesLabel1.Text = "Code Articles"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.Location = New System.Drawing.Point(449, 65)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(153, 32)
        DesignationLabel.TabIndex = 53
        DesignationLabel.Text = "Designation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1557, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 855)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1557, 5)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 850)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 850)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1552, 5)
        Me.Panel4.TabIndex = 5
        '
        'Enregistrer
        '
        Me.Enregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Enregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Enregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enregistrer.FlatAppearance.BorderSize = 0
        Me.Enregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enregistrer.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Enregistrer.Location = New System.Drawing.Point(1296, 791)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(218, 43)
        Me.Enregistrer.TabIndex = 38
        Me.Enregistrer.Text = "Enregistrer"
        Me.Enregistrer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(666, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 44)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Ajouter Article"
        '
        'QuantiteTextBox
        '
        Me.QuantiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Quantite", True))
        Me.QuantiteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteTextBox.Location = New System.Drawing.Point(1020, 107)
        Me.QuantiteTextBox.Name = "QuantiteTextBox"
        Me.QuantiteTextBox.Size = New System.Drawing.Size(147, 30)
        Me.QuantiteTextBox.TabIndex = 45
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
        'MinTextBox
        '
        Me.MinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Min", True))
        Me.MinTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinTextBox.Location = New System.Drawing.Point(1313, 145)
        Me.MinTextBox.Name = "MinTextBox"
        Me.MinTextBox.Size = New System.Drawing.Size(150, 30)
        Me.MinTextBox.TabIndex = 47
        '
        'MaxTextBox
        '
        Me.MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Max", True))
        Me.MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxTextBox.Location = New System.Drawing.Point(1313, 62)
        Me.MaxTextBox.Name = "MaxTextBox"
        Me.MaxTextBox.Size = New System.Drawing.Size(150, 30)
        Me.MaxTextBox.TabIndex = 49
        '
        'Articles_CaracteristiquesDataGridView
        '
        Me.Articles_CaracteristiquesDataGridView.AutoGenerateColumns = False
        Me.Articles_CaracteristiquesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Articles_CaracteristiquesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Articles_CaracteristiquesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.Articles_CaracteristiquesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Articles_CaracteristiquesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Articles_CaracteristiquesDataGridView.ColumnHeadersHeight = 30
        Me.Articles_CaracteristiquesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Articles_CaracteristiquesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_article, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Articles_CaracteristiquesDataGridView.DataSource = Me.Articles_CaracteristiquesBindingSource
        Me.Articles_CaracteristiquesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Articles_CaracteristiquesDataGridView.EnableHeadersVisualStyles = False
        Me.Articles_CaracteristiquesDataGridView.GridColor = System.Drawing.Color.White
        Me.Articles_CaracteristiquesDataGridView.Location = New System.Drawing.Point(3, 29)
        Me.Articles_CaracteristiquesDataGridView.Name = "Articles_CaracteristiquesDataGridView"
        Me.Articles_CaracteristiquesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Articles_CaracteristiquesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.Articles_CaracteristiquesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Articles_CaracteristiquesDataGridView.RowTemplate.Height = 24
        Me.Articles_CaracteristiquesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Articles_CaracteristiquesDataGridView.Size = New System.Drawing.Size(431, 415)
        Me.Articles_CaracteristiquesDataGridView.TabIndex = 53
        '
        'code_article
        '
        Me.code_article.DataPropertyName = "Code_Articles"
        Me.code_article.HeaderText = "code article"
        Me.code_article.Name = "code_article"
        Me.code_article.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Caracteristiques"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.CaracteristiquesBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Designation"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Caracteristiques"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Designation"
        '
        'CaracteristiquesBindingSource
        '
        Me.CaracteristiquesBindingSource.DataMember = "Caracteristiques"
        Me.CaracteristiquesBindingSource.DataSource = Me.DataSet_Stock
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Articles_CaracteristiquesBindingSource
        '
        Me.Articles_CaracteristiquesBindingSource.DataMember = "Articles_Caracteristiques"
        Me.Articles_CaracteristiquesBindingSource.DataSource = Me.DataSet_Stock
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.EmplacementTextBox)
        Me.GroupBox1.Controls.Add(Me.FamilleComboBox)
        Me.GroupBox1.Controls.Add(DesignationLabel)
        Me.GroupBox1.Controls.Add(Me.DesignationTextBox)
        Me.GroupBox1.Controls.Add(Code_ArticlesLabel1)
        Me.GroupBox1.Controls.Add(FabriquantLabel)
        Me.GroupBox1.Controls.Add(Me.Code_ArticlesTextBox)
        Me.GroupBox1.Controls.Add(FamilleLabel)
        Me.GroupBox1.Controls.Add(MaxLabel)
        Me.GroupBox1.Controls.Add(Me.MaxTextBox)
        Me.GroupBox1.Controls.Add(MinLabel)
        Me.GroupBox1.Controls.Add(Me.QuantiteTextBox)
        Me.GroupBox1.Controls.Add(QuantiteLabel)
        Me.GroupBox1.Controls.Add(Me.MinTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(18, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1516, 211)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiche Article"
        '
        'EmplacementTextBox
        '
        Me.EmplacementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Emplacement", True))
        Me.EmplacementTextBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmplacementTextBox.Location = New System.Drawing.Point(624, 136)
        Me.EmplacementTextBox.Name = "EmplacementTextBox"
        Me.EmplacementTextBox.Size = New System.Drawing.Size(217, 33)
        Me.EmplacementTextBox.TabIndex = 57
        '
        'FamilleComboBox
        '
        Me.FamilleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Famille", True))
        Me.FamilleComboBox.DataSource = Me.ArticlesFamilleBindingSource
        Me.FamilleComboBox.DisplayMember = "Designation"
        Me.FamilleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamilleComboBox.FormattingEnabled = True
        Me.FamilleComboBox.Location = New System.Drawing.Point(215, 134)
        Me.FamilleComboBox.Name = "FamilleComboBox"
        Me.FamilleComboBox.Size = New System.Drawing.Size(187, 33)
        Me.FamilleComboBox.TabIndex = 56
        Me.FamilleComboBox.ValueMember = "Designation"
        '
        'ArticlesFamilleBindingSource
        '
        Me.ArticlesFamilleBindingSource.DataMember = "Articles_Famille"
        Me.ArticlesFamilleBindingSource.DataSource = Me.DataSet_Stock
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Designation", True))
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextBox.Location = New System.Drawing.Point(624, 65)
        Me.DesignationTextBox.Multiline = True
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(217, 32)
        Me.DesignationTextBox.TabIndex = 54
        '
        'Code_ArticlesTextBox
        '
        Me.Code_ArticlesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticlesBindingSource, "Code_Articles", True))
        Me.Code_ArticlesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_ArticlesTextBox.Location = New System.Drawing.Point(215, 71)
        Me.Code_ArticlesTextBox.Multiline = True
        Me.Code_ArticlesTextBox.Name = "Code_ArticlesTextBox"
        Me.Code_ArticlesTextBox.Size = New System.Drawing.Size(187, 32)
        Me.Code_ArticlesTextBox.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Articles_CaracteristiquesDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 447)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Caracteristiques"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(473, 327)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 447)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lot"
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PersonnelDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PersonnelDataGridView.ColumnHeadersHeight = 30
        Me.PersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeLotDataGridViewTextBoxColumn, Me.NserieDataGridViewTextBoxColumn, Me.DateAchatDataGridViewTextBoxColumn, Me.DateMserviceDataGridViewTextBoxColumn, Me.DateGarantieDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn, Me.CodeArticlesDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.ArticlesLotBindingSource
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.GridColor = System.Drawing.Color.White
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 38)
        Me.PersonnelDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PersonnelDataGridView.MultiSelect = False
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(706, 406)
        Me.PersonnelDataGridView.TabIndex = 55
        '
        'CodeLotDataGridViewTextBoxColumn
        '
        Me.CodeLotDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CodeLotDataGridViewTextBoxColumn.DataPropertyName = "Code_Lot"
        Me.CodeLotDataGridViewTextBoxColumn.HeaderText = "Code Lot"
        Me.CodeLotDataGridViewTextBoxColumn.Name = "CodeLotDataGridViewTextBoxColumn"
        Me.CodeLotDataGridViewTextBoxColumn.Width = 119
        '
        'NserieDataGridViewTextBoxColumn
        '
        Me.NserieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NserieDataGridViewTextBoxColumn.DataPropertyName = "N_serie"
        Me.NserieDataGridViewTextBoxColumn.HeaderText = "N° serie"
        Me.NserieDataGridViewTextBoxColumn.Name = "NserieDataGridViewTextBoxColumn"
        Me.NserieDataGridViewTextBoxColumn.Width = 111
        '
        'DateAchatDataGridViewTextBoxColumn
        '
        Me.DateAchatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateAchatDataGridViewTextBoxColumn.DataPropertyName = "Date_Achat"
        Me.DateAchatDataGridViewTextBoxColumn.HeaderText = "Date d'Achat"
        Me.DateAchatDataGridViewTextBoxColumn.Name = "DateAchatDataGridViewTextBoxColumn"
        Me.DateAchatDataGridViewTextBoxColumn.Width = 160
        '
        'DateMserviceDataGridViewTextBoxColumn
        '
        Me.DateMserviceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateMserviceDataGridViewTextBoxColumn.DataPropertyName = "Date_Mservice"
        Me.DateMserviceDataGridViewTextBoxColumn.HeaderText = "Date Mservice"
        Me.DateMserviceDataGridViewTextBoxColumn.Name = "DateMserviceDataGridViewTextBoxColumn"
        Me.DateMserviceDataGridViewTextBoxColumn.Width = 172
        '
        'DateGarantieDataGridViewTextBoxColumn
        '
        Me.DateGarantieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateGarantieDataGridViewTextBoxColumn.DataPropertyName = "Date_Garantie"
        Me.DateGarantieDataGridViewTextBoxColumn.HeaderText = "Date Garantie"
        Me.DateGarantieDataGridViewTextBoxColumn.Name = "DateGarantieDataGridViewTextBoxColumn"
        Me.DateGarantieDataGridViewTextBoxColumn.Width = 168
        '
        'PrixDataGridViewTextBoxColumn
        '
        Me.PrixDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PrixDataGridViewTextBoxColumn.DataPropertyName = "Prix"
        Me.PrixDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn.Name = "PrixDataGridViewTextBoxColumn"
        Me.PrixDataGridViewTextBoxColumn.Width = 90
        '
        'CodeArticlesDataGridViewTextBoxColumn
        '
        Me.CodeArticlesDataGridViewTextBoxColumn.DataPropertyName = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.HeaderText = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Name = "CodeArticlesDataGridViewTextBoxColumn"
        Me.CodeArticlesDataGridViewTextBoxColumn.Visible = False
        '
        'ArticlesLotBindingSource
        '
        Me.ArticlesLotBindingSource.DataMember = "Articles_Lot"
        Me.ArticlesLotBindingSource.DataSource = Me.DataSet_Stock
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1296, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Image :"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(1244, 616)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(227, 44)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Parcourire.."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1244, 407)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1054, 791)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 43)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Actualiser"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Articles_CaracteristiquesTableAdapter = Me.Articles_CaracteristiquesTableAdapter
        Me.TableAdapterManager.Articles_FamilleTableAdapter = Nothing
        Me.TableAdapterManager.Articles_LotTableAdapter = Nothing
        Me.TableAdapterManager.ArticlesTableAdapter = Me.ArticlesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bon_Entree_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_EntreeTableAdapter = Nothing
        Me.TableAdapterManager.Bon_Sortie_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_SortieTableAdapter = Nothing
        Me.TableAdapterManager.Bon_Transfert_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_TransfertTableAdapter = Nothing
        Me.TableAdapterManager.CaracteristiquesTableAdapter = Nothing
        Me.TableAdapterManager.DEPOTTableAdapter = Nothing
        Me.TableAdapterManager.Inventaire_LigneTableAdapter = Nothing
        Me.TableAdapterManager.InventaireTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Articles_CaracteristiquesTableAdapter
        '
        Me.Articles_CaracteristiquesTableAdapter.ClearBeforeFill = True
        '
        'CaracteristiquesTableAdapter
        '
        Me.CaracteristiquesTableAdapter.ClearBeforeFill = True
        '
        'Articles_FamilleTableAdapter
        '
        Me.Articles_FamilleTableAdapter.ClearBeforeFill = True
        '
        'Articles_LotTableAdapter
        '
        Me.Articles_LotTableAdapter.ClearBeforeFill = True
        '
        'Fiche_Article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1562, 855)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Fiche_Article"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche_Article"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Articles_CaracteristiquesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaracteristiquesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Articles_CaracteristiquesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArticlesFamilleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesLotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Enregistrer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager
    Friend WithEvents QuantiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Articles_CaracteristiquesTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_CaracteristiquesTableAdapter
    Friend WithEvents Articles_CaracteristiquesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Articles_CaracteristiquesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CaracteristiquesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaracteristiquesTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.CaracteristiquesTableAdapter
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code_ArticlesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FamilleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents code_article As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticlesFamilleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Articles_FamilleTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_FamilleTableAdapter
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ArticlesLotBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Articles_LotTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.Articles_LotTableAdapter
    Friend WithEvents CodeLotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NserieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateAchatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateMserviceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateGarantieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeArticlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmplacementTextBox As System.Windows.Forms.TextBox
End Class
