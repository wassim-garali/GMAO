<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Article_Inventaire
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
        Dim N_InvantaireLabel As System.Windows.Forms.Label
        Dim Date_InvantaireLabel As System.Windows.Forms.Label
        Dim ResponsableLabel As System.Windows.Forms.Label
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
        Me.InventaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New Global.GMAO_Wassim_Skander.DataSet_Stock()
        Me.ResponsableTextBox = New System.Windows.Forms.TextBox()
        Me.Date_InvantaireDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_InvantaireTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeArticleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventaireLigneBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventaireLigneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaire_LigneTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Inventaire_LigneTableAdapter()
        Me.ArticlesTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        Me.InventaireTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.InventaireTableAdapter()
        Me.TableAdapterManager = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager()
        N_InvantaireLabel = New System.Windows.Forms.Label()
        Date_InvantaireLabel = New System.Windows.Forms.Label()
        ResponsableLabel = New System.Windows.Forms.Label()
        DepotLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InventaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventaireLigneBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventaireLigneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_InvantaireLabel
        '
        N_InvantaireLabel.AutoSize = True
        N_InvantaireLabel.Location = New System.Drawing.Point(16, 69)
        N_InvantaireLabel.Name = "N_InvantaireLabel"
        N_InvantaireLabel.Size = New System.Drawing.Size(129, 25)
        N_InvantaireLabel.TabIndex = 0
        N_InvantaireLabel.Text = "N° Invantaire"
        '
        'Date_InvantaireLabel
        '
        Date_InvantaireLabel.AutoSize = True
        Date_InvantaireLabel.Location = New System.Drawing.Point(364, 72)
        Date_InvantaireLabel.Name = "Date_InvantaireLabel"
        Date_InvantaireLabel.Size = New System.Drawing.Size(58, 25)
        Date_InvantaireLabel.TabIndex = 2
        Date_InvantaireLabel.Text = "Date "
        '
        'ResponsableLabel
        '
        ResponsableLabel.AutoSize = True
        ResponsableLabel.Location = New System.Drawing.Point(817, 74)
        ResponsableLabel.Name = "ResponsableLabel"
        ResponsableLabel.Size = New System.Drawing.Size(123, 25)
        ResponsableLabel.TabIndex = 6
        ResponsableLabel.Text = "Responsable"
        '
        'DepotLabel
        '
        DepotLabel.AutoSize = True
        DepotLabel.Location = New System.Drawing.Point(1190, 72)
        DepotLabel.Name = "DepotLabel"
        DepotLabel.Size = New System.Drawing.Size(67, 25)
        DepotLabel.TabIndex = 7
        DepotLabel.Text = "Dépôt"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1504, 0)
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
        Me.Panel1.Size = New System.Drawing.Size(10, 792)
        Me.Panel1.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 787)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1504, 5)
        Me.Panel4.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1504, 5)
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
        Me.Button1.Location = New System.Drawing.Point(1199, 716)
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
        Me.Label1.Location = New System.Drawing.Point(640, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 44)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Inventaire"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(DepotLabel)
        Me.GroupBox1.Controls.Add(Me.DepotComboBox)
        Me.GroupBox1.Controls.Add(ResponsableLabel)
        Me.GroupBox1.Controls.Add(Me.ResponsableTextBox)
        Me.GroupBox1.Controls.Add(Date_InvantaireLabel)
        Me.GroupBox1.Controls.Add(Me.Date_InvantaireDateTimePicker)
        Me.GroupBox1.Controls.Add(N_InvantaireLabel)
        Me.GroupBox1.Controls.Add(Me.N_InvantaireTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(42, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1451, 176)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entête"
        '
        'DepotComboBox
        '
        Me.DepotComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventaireBindingSource, "Depot", True))
        Me.DepotComboBox.FormattingEnabled = True
        Me.DepotComboBox.Location = New System.Drawing.Point(1295, 69)
        Me.DepotComboBox.Name = "DepotComboBox"
        Me.DepotComboBox.Size = New System.Drawing.Size(131, 31)
        Me.DepotComboBox.TabIndex = 8
        '
        'InventaireBindingSource
        '
        Me.InventaireBindingSource.DataMember = "Inventaire"
        Me.InventaireBindingSource.DataSource = Me.DataSet_Stock
        '
        'DataSet_Stock
        '
        Me.DataSet_Stock.DataSetName = "DataSet_Stock"
        Me.DataSet_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResponsableTextBox
        '
        Me.ResponsableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventaireBindingSource, "Responsable", True))
        Me.ResponsableTextBox.Location = New System.Drawing.Point(963, 66)
        Me.ResponsableTextBox.Name = "ResponsableTextBox"
        Me.ResponsableTextBox.Size = New System.Drawing.Size(150, 31)
        Me.ResponsableTextBox.TabIndex = 7
        '
        'Date_InvantaireDateTimePicker
        '
        Me.Date_InvantaireDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InventaireBindingSource, "Date_Invantaire", True))
        Me.Date_InvantaireDateTimePicker.Location = New System.Drawing.Point(462, 69)
        Me.Date_InvantaireDateTimePicker.Name = "Date_InvantaireDateTimePicker"
        Me.Date_InvantaireDateTimePicker.Size = New System.Drawing.Size(283, 31)
        Me.Date_InvantaireDateTimePicker.TabIndex = 3
        '
        'N_InvantaireTextBox
        '
        Me.N_InvantaireTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventaireBindingSource, "N_Invantaire", True))
        Me.N_InvantaireTextBox.Location = New System.Drawing.Point(149, 66)
        Me.N_InvantaireTextBox.Name = "N_InvantaireTextBox"
        Me.N_InvantaireTextBox.Size = New System.Drawing.Size(142, 31)
        Me.N_InvantaireTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(42, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1451, 392)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ligne d'inventaire"
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
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeArticleDataGridViewTextBoxColumn, Me.QuantiteDataGridViewTextBoxColumn, Me.PrixUnitDataGridViewTextBoxColumn, Me.TVADataGridViewTextBoxColumn, Me.HTDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.InventaireLigneBindingSource1
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
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1445, 281)
        Me.PersonnelDataGridView.TabIndex = 42
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
        'InventaireLigneBindingSource1
        '
        Me.InventaireLigneBindingSource1.DataMember = "Inventaire_Ligne"
        Me.InventaireLigneBindingSource1.DataSource = Me.DataSet_Stock
        '
        'InventaireLigneBindingSource
        '
        Me.InventaireLigneBindingSource.DataMember = "Inventaire_Ligne"
        Me.InventaireLigneBindingSource.DataSource = Me.DataSet_Stock
        '
        'Inventaire_LigneTableAdapter
        '
        Me.Inventaire_LigneTableAdapter.ClearBeforeFill = True
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'InventaireTableAdapter
        '
        Me.InventaireTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Articles_CaracteristiquesTableAdapter = Nothing
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
        Me.TableAdapterManager.Inventaire_LigneTableAdapter = Me.Inventaire_LigneTableAdapter
        Me.TableAdapterManager.InventaireTableAdapter = Me.InventaireTableAdapter
        Me.TableAdapterManager.UpdateOrder = Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Fiche_Article_Inventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1509, 792)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Fiche_Article_Inventaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche_Fournisseur_Bon_Cde"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InventaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventaireLigneBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventaireLigneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents InventaireLigneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inventaire_LigneTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Inventaire_LigneTableAdapter
    Friend WithEvents InventaireLigneBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents CodeArticleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventaireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventaireTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.InventaireTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager
    Friend WithEvents ResponsableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_InvantaireDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N_InvantaireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepotComboBox As System.Windows.Forms.ComboBox
End Class
