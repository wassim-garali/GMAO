<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Article_Bon_entree
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
        Dim N_Bon_entreeLabel As System.Windows.Forms.Label
        Dim Date_Bon_entreeLabel As System.Windows.Forms.Label
        Dim Total_HTLabel As System.Windows.Forms.Label
        Dim Total_TVALabel As System.Windows.Forms.Label
        Dim Total_TTCLabel As System.Windows.Forms.Label
        Dim DepotLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DepotComboBox = New System.Windows.Forms.ComboBox()
        Me.Date_Bon_entreeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_Bon_entreeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total_TTCTextBox = New System.Windows.Forms.TextBox()
        Me.Total_TVATextBox = New System.Windows.Forms.TextBox()
        Me.Total_HTTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.NBonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.QuantiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonEntreeLigneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bon_EntreeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bon_EntreeTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.Bon_EntreeTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager()
        Me.Bon_Entree_LigneTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.Bon_Entree_LigneTableAdapter()
        Me.ArticlesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        N_Bon_entreeLabel = New System.Windows.Forms.Label()
        Date_Bon_entreeLabel = New System.Windows.Forms.Label()
        Total_HTLabel = New System.Windows.Forms.Label()
        Total_TVALabel = New System.Windows.Forms.Label()
        Total_TTCLabel = New System.Windows.Forms.Label()
        DepotLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonEntreeLigneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bon_EntreeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_Bon_entreeLabel
        '
        N_Bon_entreeLabel.AutoSize = True
        N_Bon_entreeLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_Bon_entreeLabel.Location = New System.Drawing.Point(121, 80)
        N_Bon_entreeLabel.Name = "N_Bon_entreeLabel"
        N_Bon_entreeLabel.Size = New System.Drawing.Size(197, 32)
        N_Bon_entreeLabel.TabIndex = 0
        N_Bon_entreeLabel.Text = "N° Bon d'entrée"
        '
        'Date_Bon_entreeLabel
        '
        Date_Bon_entreeLabel.AutoSize = True
        Date_Bon_entreeLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Bon_entreeLabel.Location = New System.Drawing.Point(608, 80)
        Date_Bon_entreeLabel.Name = "Date_Bon_entreeLabel"
        Date_Bon_entreeLabel.Size = New System.Drawing.Size(75, 32)
        Date_Bon_entreeLabel.TabIndex = 2
        Date_Bon_entreeLabel.Text = "Date "
        '
        'Total_HTLabel
        '
        Total_HTLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Total_HTLabel.AutoSize = True
        Total_HTLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_HTLabel.Location = New System.Drawing.Point(136, 327)
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
        Total_TVALabel.Location = New System.Drawing.Point(590, 327)
        Total_TVALabel.Name = "Total_TVALabel"
        Total_TVALabel.Size = New System.Drawing.Size(127, 32)
        Total_TVALabel.TabIndex = 43
        Total_TVALabel.Text = "Total TVA"
        '
        'Total_TTCLabel
        '
        Total_TTCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Total_TTCLabel.AutoSize = True
        Total_TTCLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_TTCLabel.Location = New System.Drawing.Point(1060, 330)
        Total_TTCLabel.Name = "Total_TTCLabel"
        Total_TTCLabel.Size = New System.Drawing.Size(123, 32)
        Total_TTCLabel.TabIndex = 44
        Total_TTCLabel.Text = "Total TTC"
        '
        'DepotLabel
        '
        DepotLabel.AutoSize = True
        DepotLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepotLabel.Location = New System.Drawing.Point(1080, 83)
        DepotLabel.Name = "DepotLabel"
        DepotLabel.Size = New System.Drawing.Size(85, 32)
        DepotLabel.TabIndex = 4
        DepotLabel.Text = "Dépôt"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1554, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 792)
        Me.Panel2.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 792)
        Me.Panel1.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 787)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1554, 5)
        Me.Panel4.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1554, 5)
        Me.Panel3.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 782)
        Me.Panel5.TabIndex = 29
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
        Me.Button1.Location = New System.Drawing.Point(1174, 718)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 46)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(643, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 44)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Bon d'Entrée"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(DepotLabel)
        Me.GroupBox1.Controls.Add(Me.DepotComboBox)
        Me.GroupBox1.Controls.Add(Date_Bon_entreeLabel)
        Me.GroupBox1.Controls.Add(Me.Date_Bon_entreeDateTimePicker)
        Me.GroupBox1.Controls.Add(N_Bon_entreeLabel)
        Me.GroupBox1.Controls.Add(Me.N_Bon_entreeTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(57, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1432, 176)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entête"
        '
        'DepotComboBox
        '
        Me.DepotComboBox.FormattingEnabled = True
        Me.DepotComboBox.Location = New System.Drawing.Point(1213, 83)
        Me.DepotComboBox.Name = "DepotComboBox"
        Me.DepotComboBox.Size = New System.Drawing.Size(150, 31)
        Me.DepotComboBox.TabIndex = 5
        '
        'Date_Bon_entreeDateTimePicker
        '
        Me.Date_Bon_entreeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bon_EntreeBindingSource, "Date_Bon_entree", True))
        Me.Date_Bon_entreeDateTimePicker.Location = New System.Drawing.Point(721, 80)
        Me.Date_Bon_entreeDateTimePicker.Name = "Date_Bon_entreeDateTimePicker"
        Me.Date_Bon_entreeDateTimePicker.Size = New System.Drawing.Size(297, 31)
        Me.Date_Bon_entreeDateTimePicker.TabIndex = 3
        '
        'N_Bon_entreeTextBox
        '
        Me.N_Bon_entreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bon_EntreeBindingSource, "N_Bon_entree", True))
        Me.N_Bon_entreeTextBox.Location = New System.Drawing.Point(347, 80)
        Me.N_Bon_entreeTextBox.Name = "N_Bon_entreeTextBox"
        Me.N_Bon_entreeTextBox.Size = New System.Drawing.Size(100, 31)
        Me.N_Bon_entreeTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox2.Controls.Add(Total_TTCLabel)
        Me.GroupBox2.Controls.Add(Me.Total_TTCTextBox)
        Me.GroupBox2.Controls.Add(Total_TVALabel)
        Me.GroupBox2.Controls.Add(Me.Total_TVATextBox)
        Me.GroupBox2.Controls.Add(Total_HTLabel)
        Me.GroupBox2.Controls.Add(Me.Total_HTTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(57, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1432, 414)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ligne Bon d'Entrée"
        '
        'Total_TTCTextBox
        '
        Me.Total_TTCTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_TTCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bon_EntreeBindingSource, "Total_TTC", True))
        Me.Total_TTCTextBox.Location = New System.Drawing.Point(1234, 330)
        Me.Total_TTCTextBox.Name = "Total_TTCTextBox"
        Me.Total_TTCTextBox.Size = New System.Drawing.Size(100, 31)
        Me.Total_TTCTextBox.TabIndex = 45
        '
        'Total_TVATextBox
        '
        Me.Total_TVATextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Total_TVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bon_EntreeBindingSource, "Total_TVA", True))
        Me.Total_TVATextBox.Location = New System.Drawing.Point(759, 330)
        Me.Total_TVATextBox.Name = "Total_TVATextBox"
        Me.Total_TVATextBox.Size = New System.Drawing.Size(100, 31)
        Me.Total_TVATextBox.TabIndex = 44
        '
        'Total_HTTextBox
        '
        Me.Total_HTTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Total_HTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bon_EntreeBindingSource, "Total_HT", True))
        Me.Total_HTTextBox.Location = New System.Drawing.Point(287, 330)
        Me.Total_HTTextBox.Name = "Total_HTTextBox"
        Me.Total_HTTextBox.Size = New System.Drawing.Size(100, 31)
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
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NBonDataGridViewTextBoxColumn, Me.CodeArticleDataGridViewTextBoxColumn, Me.QuantiteDataGridViewTextBoxColumn, Me.PrixUnitDataGridViewTextBoxColumn, Me.TVADataGridViewTextBoxColumn, Me.HTDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.BonEntreeLigneBindingSource
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
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1426, 273)
        Me.PersonnelDataGridView.TabIndex = 46
        '
        'NBonDataGridViewTextBoxColumn
        '
        Me.NBonDataGridViewTextBoxColumn.DataPropertyName = "N_Bon"
        Me.NBonDataGridViewTextBoxColumn.HeaderText = "N_Bon"
        Me.NBonDataGridViewTextBoxColumn.Name = "NBonDataGridViewTextBoxColumn"
        Me.NBonDataGridViewTextBoxColumn.Visible = False
        '
        'CodeArticleDataGridViewTextBoxColumn
        '
        Me.CodeArticleDataGridViewTextBoxColumn.DataPropertyName = "Code_Article"
        Me.CodeArticleDataGridViewTextBoxColumn.DataSource = Me.ArticlesBindingSource
        Me.CodeArticleDataGridViewTextBoxColumn.DisplayMember = "Designation"
        Me.CodeArticleDataGridViewTextBoxColumn.HeaderText = "Article"
        Me.CodeArticleDataGridViewTextBoxColumn.Name = "CodeArticleDataGridViewTextBoxColumn"
        Me.CodeArticleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CodeArticleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CodeArticleDataGridViewTextBoxColumn.ValueMember = "Designation"
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
        Me.QuantiteDataGridViewTextBoxColumn.HeaderText = "Quantite"
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
        'BonEntreeLigneBindingSource
        '
        Me.BonEntreeLigneBindingSource.DataMember = "Bon_Entree_Ligne"
        Me.BonEntreeLigneBindingSource.DataSource = Me.DataSet_Stock
        '
        'Bon_EntreeBindingSource
        '
        Me.Bon_EntreeBindingSource.DataMember = "Bon_Entree"
        Me.Bon_EntreeBindingSource.DataSource = Me.DataSet_Stock
        '
        'Bon_EntreeTableAdapter
        '
        Me.Bon_EntreeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Articles_CaracteristiquesTableAdapter = Nothing
        Me.TableAdapterManager.Articles_FamilleTableAdapter = Nothing
        Me.TableAdapterManager.Articles_LotTableAdapter = Nothing
        Me.TableAdapterManager.ArticlesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bon_Entree_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_EntreeTableAdapter = Me.Bon_EntreeTableAdapter
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
        'Bon_Entree_LigneTableAdapter
        '
        Me.Bon_Entree_LigneTableAdapter.ClearBeforeFill = True
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Fiche_Article_Bon_entree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1559, 792)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Fiche_Article_Bon_entree"
        Me.Text = "Fiche_Fournisseur_Bon_Cde"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonEntreeLigneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bon_EntreeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents Bon_EntreeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bon_EntreeTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Bon_EntreeTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager
    Friend WithEvents Date_Bon_entreeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N_Bon_entreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_TTCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_HTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepotComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BonEntreeLigneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bon_Entree_LigneTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.Bon_Entree_LigneTableAdapter
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents NBonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
