<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Article_Bon_Sortie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Article_Bon_Sortie))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.NBonsortieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBonsortieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonSortieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New Global.GMAO_Wassim_Skander.DataSet_Stock()
        Me.Bon_SortieTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Bon_SortieTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ajouter = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonSortieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(45, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 3)
        Me.Panel2.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(45, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 3)
        Me.Panel1.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(542, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(344, 3)
        Me.Panel3.TabIndex = 37
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Matricule", "Nom", "Prenom", "Specialite", "Qualification"})
        Me.ComboBox1.Location = New System.Drawing.Point(177, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 41)
        Me.ComboBox1.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(542, 123)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 44)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "Recherche"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'supprimer
        '
        Me.supprimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.supprimer.FlatAppearance.BorderSize = 0
        Me.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.supprimer.Image = CType(resources.GetObject("supprimer.Image"), System.Drawing.Image)
        Me.supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.supprimer.Location = New System.Drawing.Point(796, 31)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(334, 55)
        Me.supprimer.TabIndex = 34
        Me.supprimer.Text = "Suprimer"
        Me.supprimer.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(421, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(334, 48)
        Me.Button2.TabIndex = 33
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
        Me.Button1.Location = New System.Drawing.Point(45, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(334, 48)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NBonsortieDataGridViewTextBoxColumn, Me.DateBonsortieDataGridViewTextBoxColumn, Me.DepotDataGridViewTextBoxColumn, Me.TotalHTDataGridViewTextBoxColumn, Me.TotalTVADataGridViewTextBoxColumn, Me.TotalTTCDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.BonSortieBindingSource
        Me.PersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 29)
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1180, 424)
        Me.PersonnelDataGridView.TabIndex = 41
        '
        'NBonsortieDataGridViewTextBoxColumn
        '
        Me.NBonsortieDataGridViewTextBoxColumn.DataPropertyName = "N_Bon_sortie"
        Me.NBonsortieDataGridViewTextBoxColumn.HeaderText = "N°Bon sortie"
        Me.NBonsortieDataGridViewTextBoxColumn.Name = "NBonsortieDataGridViewTextBoxColumn"
        '
        'DateBonsortieDataGridViewTextBoxColumn
        '
        Me.DateBonsortieDataGridViewTextBoxColumn.DataPropertyName = "Date_Bon_sortie"
        Me.DateBonsortieDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateBonsortieDataGridViewTextBoxColumn.Name = "DateBonsortieDataGridViewTextBoxColumn"
        '
        'DepotDataGridViewTextBoxColumn
        '
        Me.DepotDataGridViewTextBoxColumn.DataPropertyName = "Depot"
        Me.DepotDataGridViewTextBoxColumn.HeaderText = "Dépôt"
        Me.DepotDataGridViewTextBoxColumn.Name = "DepotDataGridViewTextBoxColumn"
        '
        'TotalHTDataGridViewTextBoxColumn
        '
        Me.TotalHTDataGridViewTextBoxColumn.DataPropertyName = "Total_HT"
        Me.TotalHTDataGridViewTextBoxColumn.HeaderText = "Total HT"
        Me.TotalHTDataGridViewTextBoxColumn.Name = "TotalHTDataGridViewTextBoxColumn"
        '
        'TotalTVADataGridViewTextBoxColumn
        '
        Me.TotalTVADataGridViewTextBoxColumn.DataPropertyName = "Total_TVA"
        Me.TotalTVADataGridViewTextBoxColumn.HeaderText = "Total TVA"
        Me.TotalTVADataGridViewTextBoxColumn.Name = "TotalTVADataGridViewTextBoxColumn"
        '
        'TotalTTCDataGridViewTextBoxColumn
        '
        Me.TotalTTCDataGridViewTextBoxColumn.DataPropertyName = "Total_TTC"
        Me.TotalTTCDataGridViewTextBoxColumn.HeaderText = "Total TTC"
        Me.TotalTTCDataGridViewTextBoxColumn.Name = "TotalTTCDataGridViewTextBoxColumn"
        '
        'BonSortieBindingSource
        '
        Me.BonSortieBindingSource.DataMember = "Bon_Sortie"
        Me.BonSortieBindingSource.DataSource = Me.DataSet_Stock
        '
        'DataSet_Stock
        '
        Me.DataSet_Stock.DataSetName = "DataSet_Stock"
        Me.DataSet_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bon_SortieTableAdapter
        '
        Me.Bon_SortieTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1186, 456)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des bon de sortie"
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
        Me.ajouter.Location = New System.Drawing.Point(45, 31)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(334, 55)
        Me.ajouter.TabIndex = 32
        Me.ajouter.Text = "Ajouter"
        Me.ajouter.UseVisualStyleBackColor = False
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
        Me.modifier.Location = New System.Drawing.Point(421, 31)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(334, 55)
        Me.modifier.TabIndex = 33
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = False
        '
        'Liste_Article_Bon_Sortie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 674)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.supprimer)
        Me.Controls.Add(Me.modifier)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ajouter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Liste_Article_Bon_Sortie"
        Me.Text = "Liste_Article_Bon_Sortie"
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonSortieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents supprimer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Stock As Global.GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents BonSortieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bon_SortieTableAdapter As Global.GMAO_Wassim_Skander.DataSet_StockTableAdapters.Bon_SortieTableAdapter
    Friend WithEvents NBonsortieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateBonsortieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalTVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalTTCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents modifier As System.Windows.Forms.Button
End Class
