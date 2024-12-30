<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Fournisseur_DDe_Achat
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
        Dim N_Dem_AchatLabel As System.Windows.Forms.Label
        Dim Date_Dem_AchatLabel As System.Windows.Forms.Label
        Dim DepotLabel As System.Windows.Forms.Label
        Dim DelaiLabel As System.Windows.Forms.Label
        Dim Total_HTLabel As System.Windows.Forms.Label
        Dim Total_TVALabel As System.Windows.Forms.Label
        Dim Total_TTCLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total_TTCTextBox = New System.Windows.Forms.TextBox()
        Me.Demande_AchatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Fournisseur = New Global.GMAO_Wassim_Skander.DataSet_Fournisseur()
        Me.Total_TVATextBox = New System.Windows.Forms.TextBox()
        Me.Total_HTTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.NDemAchatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New Global.GMAO_Wassim_Skander.DataSet_Stock()
        Me.QuantiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DemandeAchatLigneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DelaiDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DepotListBox = New System.Windows.Forms.ListBox()
        Me.Date_Dem_AchatDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_Dem_AchatTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Demande_AchatTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.Demande_AchatTableAdapter()
        Me.TableAdapterManager = New Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.TableAdapterManager()
        Me.Demande_Achat_LigneTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.Demande_Achat_LigneTableAdapter()
        Me.ArticlesTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        N_Dem_AchatLabel = New System.Windows.Forms.Label()
        Date_Dem_AchatLabel = New System.Windows.Forms.Label()
        DepotLabel = New System.Windows.Forms.Label()
        DelaiLabel = New System.Windows.Forms.Label()
        Total_HTLabel = New System.Windows.Forms.Label()
        Total_TVALabel = New System.Windows.Forms.Label()
        Total_TTCLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Demande_AchatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Fournisseur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DemandeAchatLigneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'N_Dem_AchatLabel
        '
        N_Dem_AchatLabel.AutoSize = True
        N_Dem_AchatLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_Dem_AchatLabel.Location = New System.Drawing.Point(72, 119)
        N_Dem_AchatLabel.Name = "N_Dem_AchatLabel"
        N_Dem_AchatLabel.Size = New System.Drawing.Size(231, 32)
        N_Dem_AchatLabel.TabIndex = 0
        N_Dem_AchatLabel.Text = "N° Demande Achat"
        '
        'Date_Dem_AchatLabel
        '
        Date_Dem_AchatLabel.AutoSize = True
        Date_Dem_AchatLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Dem_AchatLabel.Location = New System.Drawing.Point(53, 49)
        Date_Dem_AchatLabel.Name = "Date_Dem_AchatLabel"
        Date_Dem_AchatLabel.Size = New System.Drawing.Size(256, 32)
        Date_Dem_AchatLabel.TabIndex = 2
        Date_Dem_AchatLabel.Text = "Date Demande Achat"
        '
        'DepotLabel
        '
        DepotLabel.AutoSize = True
        DepotLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepotLabel.Location = New System.Drawing.Point(933, 123)
        DepotLabel.Name = "DepotLabel"
        DepotLabel.Size = New System.Drawing.Size(85, 32)
        DepotLabel.TabIndex = 4
        DepotLabel.Text = "Depot"
        '
        'DelaiLabel
        '
        DelaiLabel.AutoSize = True
        DelaiLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DelaiLabel.Location = New System.Drawing.Point(933, 47)
        DelaiLabel.Name = "DelaiLabel"
        DelaiLabel.Size = New System.Drawing.Size(73, 32)
        DelaiLabel.TabIndex = 6
        DelaiLabel.Text = "Délai"
        '
        'Total_HTLabel
        '
        Total_HTLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Total_HTLabel.AutoSize = True
        Total_HTLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_HTLabel.Location = New System.Drawing.Point(187, 285)
        Total_HTLabel.Name = "Total_HTLabel"
        Total_HTLabel.Size = New System.Drawing.Size(112, 32)
        Total_HTLabel.TabIndex = 42
        Total_HTLabel.Text = "Total HT"
        '
        'Total_TVALabel
        '
        Total_TVALabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Total_TVALabel.AutoSize = True
        Total_TVALabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_TVALabel.Location = New System.Drawing.Point(504, 291)
        Total_TVALabel.Name = "Total_TVALabel"
        Total_TVALabel.Size = New System.Drawing.Size(127, 32)
        Total_TVALabel.TabIndex = 43
        Total_TVALabel.Text = "Total TVA"
        '
        'Total_TTCLabel
        '
        Total_TTCLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Total_TTCLabel.AutoSize = True
        Total_TTCLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_TTCLabel.Location = New System.Drawing.Point(846, 291)
        Total_TTCLabel.Name = "Total_TTCLabel"
        Total_TTCLabel.Size = New System.Drawing.Size(123, 32)
        Total_TTCLabel.TabIndex = 44
        Total_TTCLabel.Text = "Total TTC"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1555, 5)
        Me.Panel3.TabIndex = 29
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 787)
        Me.Panel5.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 787)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1550, 5)
        Me.Panel4.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1550, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 782)
        Me.Panel1.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Total_TTCLabel)
        Me.GroupBox2.Controls.Add(Me.Total_TTCTextBox)
        Me.GroupBox2.Controls.Add(Total_TVALabel)
        Me.GroupBox2.Controls.Add(Me.Total_TVATextBox)
        Me.GroupBox2.Controls.Add(Total_HTLabel)
        Me.GroupBox2.Controls.Add(Me.Total_HTTextBox)
        Me.GroupBox2.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(44, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1486, 372)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "demande d'achat"
        '
        'Total_TTCTextBox
        '
        Me.Total_TTCTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Total_TTCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Demande_AchatBindingSource, "Total_TTC", True))
        Me.Total_TTCTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_TTCTextBox.Location = New System.Drawing.Point(1005, 288)
        Me.Total_TTCTextBox.Name = "Total_TTCTextBox"
        Me.Total_TTCTextBox.Size = New System.Drawing.Size(127, 30)
        Me.Total_TTCTextBox.TabIndex = 45
        '
        'Demande_AchatBindingSource
        '
        Me.Demande_AchatBindingSource.DataMember = "Demande_Achat"
        Me.Demande_AchatBindingSource.DataSource = Me.DataSet_Fournisseur
        '
        'DataSet_Fournisseur
        '
        Me.DataSet_Fournisseur.DataSetName = "DataSet_Fournisseur"
        Me.DataSet_Fournisseur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Total_TVATextBox
        '
        Me.Total_TVATextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Total_TVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Demande_AchatBindingSource, "Total_TVA", True))
        Me.Total_TVATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_TVATextBox.Location = New System.Drawing.Point(674, 288)
        Me.Total_TVATextBox.Name = "Total_TVATextBox"
        Me.Total_TVATextBox.Size = New System.Drawing.Size(112, 30)
        Me.Total_TVATextBox.TabIndex = 44
        '
        'Total_HTTextBox
        '
        Me.Total_HTTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Total_HTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Demande_AchatBindingSource, "Total_HT", True))
        Me.Total_HTTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_HTTextBox.Location = New System.Drawing.Point(317, 291)
        Me.Total_HTTextBox.Name = "Total_HTTextBox"
        Me.Total_HTTextBox.Size = New System.Drawing.Size(129, 30)
        Me.Total_HTTextBox.TabIndex = 43
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PersonnelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDemAchatDataGridViewTextBoxColumn, Me.CodeArticleDataGridViewTextBoxColumn, Me.QuantiteDataGridViewTextBoxColumn, Me.PrixUnitDataGridViewTextBoxColumn, Me.TVADataGridViewTextBoxColumn, Me.HTDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.DemandeAchatLigneBindingSource
        Me.PersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1480, 221)
        Me.PersonnelDataGridView.TabIndex = 42
        '
        'NDemAchatDataGridViewTextBoxColumn
        '
        Me.NDemAchatDataGridViewTextBoxColumn.DataPropertyName = "N_Dem_Achat"
        Me.NDemAchatDataGridViewTextBoxColumn.HeaderText = "N°Demande Achat"
        Me.NDemAchatDataGridViewTextBoxColumn.Name = "NDemAchatDataGridViewTextBoxColumn"
        '
        'CodeArticleDataGridViewTextBoxColumn
        '
        Me.CodeArticleDataGridViewTextBoxColumn.DataPropertyName = "Code_Article"
        Me.CodeArticleDataGridViewTextBoxColumn.DataSource = Me.ArticlesBindingSource
        Me.CodeArticleDataGridViewTextBoxColumn.DisplayMember = "Designation"
        Me.CodeArticleDataGridViewTextBoxColumn.HeaderText = "Désignation Article"
        Me.CodeArticleDataGridViewTextBoxColumn.Name = "CodeArticleDataGridViewTextBoxColumn"
        Me.CodeArticleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CodeArticleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CodeArticleDataGridViewTextBoxColumn.ValueMember = "Code_Articles"
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
        'QuantiteDataGridViewTextBoxColumn
        '
        Me.QuantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite"
        Me.QuantiteDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QuantiteDataGridViewTextBoxColumn.Name = "QuantiteDataGridViewTextBoxColumn"
        '
        'PrixUnitDataGridViewTextBoxColumn
        '
        Me.PrixUnitDataGridViewTextBoxColumn.DataPropertyName = "Prix_Unit"
        Me.PrixUnitDataGridViewTextBoxColumn.HeaderText = "Prix Unit"
        Me.PrixUnitDataGridViewTextBoxColumn.Name = "PrixUnitDataGridViewTextBoxColumn"
        '
        'TVADataGridViewTextBoxColumn
        '
        Me.TVADataGridViewTextBoxColumn.DataPropertyName = "TVA"
        Me.TVADataGridViewTextBoxColumn.HeaderText = "TVA"
        Me.TVADataGridViewTextBoxColumn.Name = "TVADataGridViewTextBoxColumn"
        '
        'HTDataGridViewTextBoxColumn
        '
        Me.HTDataGridViewTextBoxColumn.DataPropertyName = "HT"
        Me.HTDataGridViewTextBoxColumn.HeaderText = "HT"
        Me.HTDataGridViewTextBoxColumn.Name = "HTDataGridViewTextBoxColumn"
        '
        'DemandeAchatLigneBindingSource
        '
        Me.DemandeAchatLigneBindingSource.DataMember = "Demande_Achat_Ligne"
        Me.DemandeAchatLigneBindingSource.DataSource = Me.DataSet_Fournisseur
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(DelaiLabel)
        Me.GroupBox1.Controls.Add(Me.DelaiDateTimePicker)
        Me.GroupBox1.Controls.Add(DepotLabel)
        Me.GroupBox1.Controls.Add(Me.DepotListBox)
        Me.GroupBox1.Controls.Add(Date_Dem_AchatLabel)
        Me.GroupBox1.Controls.Add(Me.Date_Dem_AchatDateTimePicker)
        Me.GroupBox1.Controls.Add(N_Dem_AchatLabel)
        Me.GroupBox1.Controls.Add(Me.N_Dem_AchatTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(50, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1473, 194)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entête"
        '
        'DelaiDateTimePicker
        '
        Me.DelaiDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Demande_AchatBindingSource, "delai", True))
        Me.DelaiDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelaiDateTimePicker.Location = New System.Drawing.Point(1035, 47)
        Me.DelaiDateTimePicker.Name = "DelaiDateTimePicker"
        Me.DelaiDateTimePicker.Size = New System.Drawing.Size(284, 30)
        Me.DelaiDateTimePicker.TabIndex = 7
        '
        'DepotListBox
        '
        Me.DepotListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Demande_AchatBindingSource, "Depot", True))
        Me.DepotListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepotListBox.FormattingEnabled = True
        Me.DepotListBox.ItemHeight = 25
        Me.DepotListBox.Location = New System.Drawing.Point(1035, 124)
        Me.DepotListBox.Name = "DepotListBox"
        Me.DepotListBox.Size = New System.Drawing.Size(218, 25)
        Me.DepotListBox.TabIndex = 5
        '
        'Date_Dem_AchatDateTimePicker
        '
        Me.Date_Dem_AchatDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Demande_AchatBindingSource, "Date_Dem_Achat", True))
        Me.Date_Dem_AchatDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Dem_AchatDateTimePicker.Location = New System.Drawing.Point(325, 49)
        Me.Date_Dem_AchatDateTimePicker.Name = "Date_Dem_AchatDateTimePicker"
        Me.Date_Dem_AchatDateTimePicker.Size = New System.Drawing.Size(279, 30)
        Me.Date_Dem_AchatDateTimePicker.TabIndex = 3
        '
        'N_Dem_AchatTextBox
        '
        Me.N_Dem_AchatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Demande_AchatBindingSource, "N_Dem_Achat", True))
        Me.N_Dem_AchatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_Dem_AchatTextBox.Location = New System.Drawing.Point(325, 122)
        Me.N_Dem_AchatTextBox.Name = "N_Dem_AchatTextBox"
        Me.N_Dem_AchatTextBox.Size = New System.Drawing.Size(193, 30)
        Me.N_Dem_AchatTextBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1197, 717)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 43)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(569, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 44)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = " Demande d'achat"
        '
        'Demande_AchatTableAdapter
        '
        Me.Demande_AchatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bon_Commande_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_CommandeTableAdapter = Nothing
        Me.TableAdapterManager.Bon_Reseption_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_ReseptionTableAdapter = Nothing
        Me.TableAdapterManager.Demande_Achat_LigneTableAdapter = Me.Demande_Achat_LigneTableAdapter
        Me.TableAdapterManager.Demande_AchatTableAdapter = Me.Demande_AchatTableAdapter
        Me.TableAdapterManager.FournisseurTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Demande_Achat_LigneTableAdapter
        '
        Me.Demande_Achat_LigneTableAdapter.ClearBeforeFill = True
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Fiche_Fournisseur_DDe_Achat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1555, 792)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Fiche_Fournisseur_DDe_Achat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche_Fournisseur_DDe_Achat"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Demande_AchatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Fournisseur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DemandeAchatLigneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Fournisseur As Global.GMAO_Wassim_Skander.DataSet_Fournisseur
    Friend WithEvents Demande_AchatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Demande_AchatTableAdapter As Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.Demande_AchatTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.TableAdapterManager
    Friend WithEvents Date_Dem_AchatDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N_Dem_AchatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DelaiDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DepotListBox As System.Windows.Forms.ListBox
    Friend WithEvents Demande_Achat_LigneTableAdapter As Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.Demande_Achat_LigneTableAdapter
    Friend WithEvents DemandeAchatLigneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Total_TTCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_HTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents NDemAchatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
