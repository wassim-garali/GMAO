<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Machine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Machine))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeMachineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDImmoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmplacementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabriquantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiseenmarcheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CracteristiqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Machine = New GMAO_Wassim_Skander.DataSet_Machine()
        Me.MachineTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.button_add_prev = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(61, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1146, 3)
        Me.Panel2.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(61, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 3)
        Me.Panel1.TabIndex = 49
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(426, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(344, 3)
        Me.Panel3.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(426, 116)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 44)
        Me.TextBox1.TabIndex = 46
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
        Me.Button3.Location = New System.Drawing.Point(873, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(334, 48)
        Me.Button3.TabIndex = 45
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
        Me.Button2.Location = New System.Drawing.Point(467, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(334, 48)
        Me.Button2.TabIndex = 44
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
        Me.Button1.Location = New System.Drawing.Point(61, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(334, 48)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1247, 461)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des machines"
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToAddRows = False
        Me.PersonnelDataGridView.AllowUserToDeleteRows = False
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
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
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeMachineDataGridViewTextBoxColumn, Me.IDImmoDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.EmplacementDataGridViewTextBoxColumn, Me.FabriquantDataGridViewTextBoxColumn, Me.MiseenmarcheDataGridViewTextBoxColumn, Me.CracteristiqueDataGridViewTextBoxColumn, Me.GarantieDataGridViewTextBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.MachineBindingSource
        Me.PersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 29)
        Me.PersonnelDataGridView.MultiSelect = False
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.ReadOnly = True
        Me.PersonnelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1241, 429)
        Me.PersonnelDataGridView.TabIndex = 30
        Me.PersonnelDataGridView.TabStop = False
        '
        'CodeMachineDataGridViewTextBoxColumn
        '
        Me.CodeMachineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodeMachineDataGridViewTextBoxColumn.DataPropertyName = "Code_Machine"
        Me.CodeMachineDataGridViewTextBoxColumn.HeaderText = "Code Machine"
        Me.CodeMachineDataGridViewTextBoxColumn.Name = "CodeMachineDataGridViewTextBoxColumn"
        Me.CodeMachineDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeMachineDataGridViewTextBoxColumn.Width = 190
        '
        'IDImmoDataGridViewTextBoxColumn
        '
        Me.IDImmoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDImmoDataGridViewTextBoxColumn.DataPropertyName = "ID_Immo"
        Me.IDImmoDataGridViewTextBoxColumn.HeaderText = "ID Immo"
        Me.IDImmoDataGridViewTextBoxColumn.Name = "IDImmoDataGridViewTextBoxColumn"
        Me.IDImmoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDImmoDataGridViewTextBoxColumn.Width = 150
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation Machine"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesignationDataGridViewTextBoxColumn.Width = 400
        '
        'EmplacementDataGridViewTextBoxColumn
        '
        Me.EmplacementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EmplacementDataGridViewTextBoxColumn.DataPropertyName = "Emplacement"
        Me.EmplacementDataGridViewTextBoxColumn.HeaderText = "Emplacement"
        Me.EmplacementDataGridViewTextBoxColumn.Name = "EmplacementDataGridViewTextBoxColumn"
        Me.EmplacementDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmplacementDataGridViewTextBoxColumn.Width = 200
        '
        'FabriquantDataGridViewTextBoxColumn
        '
        Me.FabriquantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FabriquantDataGridViewTextBoxColumn.DataPropertyName = "Fabriquant"
        Me.FabriquantDataGridViewTextBoxColumn.HeaderText = "Fabriquant"
        Me.FabriquantDataGridViewTextBoxColumn.Name = "FabriquantDataGridViewTextBoxColumn"
        Me.FabriquantDataGridViewTextBoxColumn.ReadOnly = True
        Me.FabriquantDataGridViewTextBoxColumn.Visible = False
        Me.FabriquantDataGridViewTextBoxColumn.Width = 150
        '
        'MiseenmarcheDataGridViewTextBoxColumn
        '
        Me.MiseenmarcheDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MiseenmarcheDataGridViewTextBoxColumn.DataPropertyName = "Mise_en_marche"
        Me.MiseenmarcheDataGridViewTextBoxColumn.HeaderText = "Mise en marche"
        Me.MiseenmarcheDataGridViewTextBoxColumn.Name = "MiseenmarcheDataGridViewTextBoxColumn"
        Me.MiseenmarcheDataGridViewTextBoxColumn.ReadOnly = True
        Me.MiseenmarcheDataGridViewTextBoxColumn.Width = 230
        '
        'CracteristiqueDataGridViewTextBoxColumn
        '
        Me.CracteristiqueDataGridViewTextBoxColumn.DataPropertyName = "Cracteristique"
        Me.CracteristiqueDataGridViewTextBoxColumn.HeaderText = "Cracteristique"
        Me.CracteristiqueDataGridViewTextBoxColumn.Name = "CracteristiqueDataGridViewTextBoxColumn"
        Me.CracteristiqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.CracteristiqueDataGridViewTextBoxColumn.Visible = False
        Me.CracteristiqueDataGridViewTextBoxColumn.Width = 141
        '
        'GarantieDataGridViewTextBoxColumn
        '
        Me.GarantieDataGridViewTextBoxColumn.DataPropertyName = "Garantie"
        Me.GarantieDataGridViewTextBoxColumn.HeaderText = "Garantie"
        Me.GarantieDataGridViewTextBoxColumn.Name = "GarantieDataGridViewTextBoxColumn"
        Me.GarantieDataGridViewTextBoxColumn.ReadOnly = True
        Me.GarantieDataGridViewTextBoxColumn.Visible = False
        Me.GarantieDataGridViewTextBoxColumn.Width = 141
        '
        'MachineBindingSource
        '
        Me.MachineBindingSource.DataMember = "Machine"
        Me.MachineBindingSource.DataSource = Me.DataSet_Machine
        '
        'DataSet_Machine
        '
        Me.DataSet_Machine.DataSetName = "DataSet_Machine"
        Me.DataSet_Machine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachineTableAdapter
        '
        Me.MachineTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MachineBindingSource
        Me.ComboBox1.DisplayMember = "ID_Immo"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(61, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(334, 37)
        Me.ComboBox1.TabIndex = 52
        Me.ComboBox1.ValueMember = "Code_Machine"
        '
        'button_add_prev
        '
        Me.button_add_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_add_prev.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.button_add_prev.FlatAppearance.BorderSize = 0
        Me.button_add_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_add_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_add_prev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button_add_prev.Image = CType(resources.GetObject("button_add_prev.Image"), System.Drawing.Image)
        Me.button_add_prev.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.button_add_prev.Location = New System.Drawing.Point(873, 123)
        Me.button_add_prev.Name = "button_add_prev"
        Me.button_add_prev.Size = New System.Drawing.Size(334, 48)
        Me.button_add_prev.TabIndex = 53
        Me.button_add_prev.Text = "Ajouter Préventive"
        Me.button_add_prev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_add_prev.UseVisualStyleBackColor = False
        Me.button_add_prev.Visible = False
        '
        'Liste_Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 740)
        Me.Controls.Add(Me.button_add_prev)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Liste_Machine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste_Machine"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Machine As Global.GMAO_Wassim_Skander.DataSet_Machine
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineTableAdapter As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents button_add_prev As System.Windows.Forms.Button
    Friend WithEvents CodeMachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDImmoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmplacementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabriquantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiseenmarcheDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CracteristiqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GarantieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
