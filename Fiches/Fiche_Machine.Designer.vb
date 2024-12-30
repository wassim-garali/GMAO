<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Machine
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
        Dim FabriquantLabel As System.Windows.Forms.Label
        Dim GarantieLabel As System.Windows.Forms.Label
        Dim Mise_en_marcheLabel As System.Windows.Forms.Label
        Dim EmplacementLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim ID_ImmoLabel As System.Windows.Forms.Label
        Dim Code_MachineLabel As System.Windows.Forms.Label
        Dim TTF_MLabel As System.Windows.Forms.Label
        Dim TTF_DLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_Machine))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TTF_DTextBox = New System.Windows.Forms.TextBox()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Machine = New GMAO_Wassim_Skander.DataSet_Machine()
        Me.TTF_MTextBox = New System.Windows.Forms.TextBox()
        Me.Code_MachineTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ImmoTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.EmplacementTextBox = New System.Windows.Forms.TextBox()
        Me.Mise_en_marcheDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GarantieDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FabriquantTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.Code_Machine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeIntervDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ListeInterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Intervention = New GMAO_Wassim_Skander.DataSet_Intervention()
        Me.DateDIntervDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeFrequenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TypeFrequenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FreqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_PInterv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineIntervPrevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MachineTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.TableAdapterManager()
        Me.Machine_Interv_PrevTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Machine_Interv_PrevTableAdapter()
        Me.Type_FrequenceTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Type_FrequenceTableAdapter()
        Me.Liste_InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Liste_InterventionTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        FabriquantLabel = New System.Windows.Forms.Label()
        GarantieLabel = New System.Windows.Forms.Label()
        Mise_en_marcheLabel = New System.Windows.Forms.Label()
        EmplacementLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        ID_ImmoLabel = New System.Windows.Forms.Label()
        Code_MachineLabel = New System.Windows.Forms.Label()
        TTF_MLabel = New System.Windows.Forms.Label()
        TTF_DLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeInterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeFrequenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineIntervPrevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FabriquantLabel
        '
        FabriquantLabel.AutoSize = True
        FabriquantLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FabriquantLabel.Location = New System.Drawing.Point(445, 106)
        FabriquantLabel.Name = "FabriquantLabel"
        FabriquantLabel.Size = New System.Drawing.Size(139, 32)
        FabriquantLabel.TabIndex = 14
        FabriquantLabel.Text = "Fabriquant"
        '
        'GarantieLabel
        '
        GarantieLabel.AutoSize = True
        GarantieLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GarantieLabel.Location = New System.Drawing.Point(866, 110)
        GarantieLabel.Name = "GarantieLabel"
        GarantieLabel.Size = New System.Drawing.Size(112, 32)
        GarantieLabel.TabIndex = 12
        GarantieLabel.Text = "Garantie"
        '
        'Mise_en_marcheLabel
        '
        Mise_en_marcheLabel.AutoSize = True
        Mise_en_marcheLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mise_en_marcheLabel.Location = New System.Drawing.Point(866, 47)
        Mise_en_marcheLabel.Name = "Mise_en_marcheLabel"
        Mise_en_marcheLabel.Size = New System.Drawing.Size(195, 32)
        Mise_en_marcheLabel.TabIndex = 8
        Mise_en_marcheLabel.Text = "Mise en marche"
        '
        'EmplacementLabel
        '
        EmplacementLabel.AutoSize = True
        EmplacementLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmplacementLabel.Location = New System.Drawing.Point(445, 161)
        EmplacementLabel.Name = "EmplacementLabel"
        EmplacementLabel.Size = New System.Drawing.Size(169, 32)
        EmplacementLabel.TabIndex = 6
        EmplacementLabel.Text = "Emplacement"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.Location = New System.Drawing.Point(445, 49)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(153, 32)
        DesignationLabel.TabIndex = 4
        DesignationLabel.Text = "Designation"
        '
        'ID_ImmoLabel
        '
        ID_ImmoLabel.AutoSize = True
        ID_ImmoLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ImmoLabel.Location = New System.Drawing.Point(11, 129)
        ID_ImmoLabel.Name = "ID_ImmoLabel"
        ID_ImmoLabel.Size = New System.Drawing.Size(115, 32)
        ID_ImmoLabel.TabIndex = 2
        ID_ImmoLabel.Text = "ID Immo"
        '
        'Code_MachineLabel
        '
        Code_MachineLabel.AutoSize = True
        Code_MachineLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_MachineLabel.Location = New System.Drawing.Point(11, 72)
        Code_MachineLabel.Name = "Code_MachineLabel"
        Code_MachineLabel.Size = New System.Drawing.Size(177, 32)
        Code_MachineLabel.TabIndex = 0
        Code_MachineLabel.Text = "Code Machine"
        '
        'TTF_MLabel
        '
        TTF_MLabel.AutoSize = True
        TTF_MLabel.Location = New System.Drawing.Point(1235, 167)
        TTF_MLabel.Name = "TTF_MLabel"
        TTF_MLabel.Size = New System.Drawing.Size(85, 32)
        TTF_MLabel.TabIndex = 15
        TTF_MLabel.Text = "TTF M"
        '
        'TTF_DLabel
        '
        TTF_DLabel.AutoSize = True
        TTF_DLabel.Location = New System.Drawing.Point(866, 167)
        TTF_DLabel.Name = "TTF_DLabel"
        TTF_DLabel.Size = New System.Drawing.Size(62, 32)
        TTF_DLabel.TabIndex = 16
        TTF_DLabel.Text = "TTF "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1555, 5)
        Me.Panel3.TabIndex = 26
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 741)
        Me.Panel5.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 741)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1550, 5)
        Me.Panel4.TabIndex = 28
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
        Me.Button1.Location = New System.Drawing.Point(1303, 671)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 50)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(605, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 44)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Ajouter Machine"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(TTF_DLabel)
        Me.GroupBox1.Controls.Add(Me.TTF_DTextBox)
        Me.GroupBox1.Controls.Add(TTF_MLabel)
        Me.GroupBox1.Controls.Add(Me.TTF_MTextBox)
        Me.GroupBox1.Controls.Add(Code_MachineLabel)
        Me.GroupBox1.Controls.Add(Me.Code_MachineTextBox)
        Me.GroupBox1.Controls.Add(ID_ImmoLabel)
        Me.GroupBox1.Controls.Add(Me.ID_ImmoTextBox)
        Me.GroupBox1.Controls.Add(DesignationLabel)
        Me.GroupBox1.Controls.Add(Me.DesignationTextBox)
        Me.GroupBox1.Controls.Add(EmplacementLabel)
        Me.GroupBox1.Controls.Add(Me.EmplacementTextBox)
        Me.GroupBox1.Controls.Add(Mise_en_marcheLabel)
        Me.GroupBox1.Controls.Add(Me.Mise_en_marcheDateTimePicker)
        Me.GroupBox1.Controls.Add(GarantieLabel)
        Me.GroupBox1.Controls.Add(Me.GarantieDateTimePicker)
        Me.GroupBox1.Controls.Add(FabriquantLabel)
        Me.GroupBox1.Controls.Add(Me.FabriquantTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(13, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1531, 237)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiche Machine"
        '
        'TTF_DTextBox
        '
        Me.TTF_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "TTF_D", True))
        Me.TTF_DTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTF_DTextBox.Location = New System.Drawing.Point(1075, 172)
        Me.TTF_DTextBox.Name = "TTF_DTextBox"
        Me.TTF_DTextBox.Size = New System.Drawing.Size(131, 28)
        Me.TTF_DTextBox.TabIndex = 17
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
        'TTF_MTextBox
        '
        Me.TTF_MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "TTF_M", True))
        Me.TTF_MTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTF_MTextBox.Location = New System.Drawing.Point(1360, 171)
        Me.TTF_MTextBox.Name = "TTF_MTextBox"
        Me.TTF_MTextBox.Size = New System.Drawing.Size(136, 28)
        Me.TTF_MTextBox.TabIndex = 16
        '
        'Code_MachineTextBox
        '
        Me.Code_MachineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "Code_Machine", True))
        Me.Code_MachineTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_MachineTextBox.Location = New System.Drawing.Point(194, 74)
        Me.Code_MachineTextBox.Name = "Code_MachineTextBox"
        Me.Code_MachineTextBox.Size = New System.Drawing.Size(200, 28)
        Me.Code_MachineTextBox.TabIndex = 1
        '
        'ID_ImmoTextBox
        '
        Me.ID_ImmoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "ID_Immo", True))
        Me.ID_ImmoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_ImmoTextBox.Location = New System.Drawing.Point(194, 135)
        Me.ID_ImmoTextBox.Name = "ID_ImmoTextBox"
        Me.ID_ImmoTextBox.Size = New System.Drawing.Size(200, 28)
        Me.ID_ImmoTextBox.TabIndex = 3
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "Designation", True))
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextBox.Location = New System.Drawing.Point(634, 49)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(200, 28)
        Me.DesignationTextBox.TabIndex = 5
        '
        'EmplacementTextBox
        '
        Me.EmplacementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "Emplacement", True))
        Me.EmplacementTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmplacementTextBox.Location = New System.Drawing.Point(634, 167)
        Me.EmplacementTextBox.Name = "EmplacementTextBox"
        Me.EmplacementTextBox.Size = New System.Drawing.Size(200, 28)
        Me.EmplacementTextBox.TabIndex = 7
        '
        'Mise_en_marcheDateTimePicker
        '
        Me.Mise_en_marcheDateTimePicker.CustomFormat = "dddd dd MMMM yyyy     HH:mm"
        Me.Mise_en_marcheDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MachineBindingSource, "Mise_en_marche", True))
        Me.Mise_en_marcheDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mise_en_marcheDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mise_en_marcheDateTimePicker.Location = New System.Drawing.Point(1075, 50)
        Me.Mise_en_marcheDateTimePicker.Name = "Mise_en_marcheDateTimePicker"
        Me.Mise_en_marcheDateTimePicker.Size = New System.Drawing.Size(408, 28)
        Me.Mise_en_marcheDateTimePicker.TabIndex = 9
        '
        'GarantieDateTimePicker
        '
        Me.GarantieDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MachineBindingSource, "Garantie", True))
        Me.GarantieDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GarantieDateTimePicker.Location = New System.Drawing.Point(1075, 108)
        Me.GarantieDateTimePicker.Name = "GarantieDateTimePicker"
        Me.GarantieDateTimePicker.Size = New System.Drawing.Size(408, 28)
        Me.GarantieDateTimePicker.TabIndex = 13
        '
        'FabriquantTextBox
        '
        Me.FabriquantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MachineBindingSource, "Fabriquant", True))
        Me.FabriquantTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FabriquantTextBox.Location = New System.Drawing.Point(634, 106)
        Me.FabriquantTextBox.Name = "FabriquantTextBox"
        Me.FabriquantTextBox.Size = New System.Drawing.Size(200, 28)
        Me.FabriquantTextBox.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 356)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1532, 309)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fiche preventive "
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PersonnelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonnelDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonnelDataGridView.ColumnHeadersHeight = 35
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_Machine, Me.CodeIntervDataGridViewTextBoxColumn, Me.DateDIntervDataGridViewTextBoxColumn, Me.TypeFrequenceDataGridViewTextBoxColumn, Me.FreqDataGridViewTextBoxColumn, Me.Date_PInterv})
        Me.PersonnelDataGridView.DataSource = Me.MachineIntervPrevBindingSource
        Me.PersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.PersonnelDataGridView.MultiSelect = False
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1526, 273)
        Me.PersonnelDataGridView.TabIndex = 44
        '
        'Code_Machine
        '
        Me.Code_Machine.DataPropertyName = "Code_Machine"
        Me.Code_Machine.HeaderText = "Code_Machine"
        Me.Code_Machine.Name = "Code_Machine"
        Me.Code_Machine.Visible = False
        '
        'CodeIntervDataGridViewTextBoxColumn
        '
        Me.CodeIntervDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodeIntervDataGridViewTextBoxColumn.DataPropertyName = "Code_Interv"
        Me.CodeIntervDataGridViewTextBoxColumn.DataSource = Me.ListeInterventionBindingSource
        Me.CodeIntervDataGridViewTextBoxColumn.DisplayMember = "Designation"
        Me.CodeIntervDataGridViewTextBoxColumn.HeaderText = "Designation Intervention"
        Me.CodeIntervDataGridViewTextBoxColumn.Name = "CodeIntervDataGridViewTextBoxColumn"
        Me.CodeIntervDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CodeIntervDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CodeIntervDataGridViewTextBoxColumn.ValueMember = "Designation"
        Me.CodeIntervDataGridViewTextBoxColumn.Width = 650
        '
        'ListeInterventionBindingSource
        '
        Me.ListeInterventionBindingSource.DataMember = "Liste_Intervention"
        Me.ListeInterventionBindingSource.DataSource = Me.DataSet_Intervention
        '
        'DataSet_Intervention
        '
        Me.DataSet_Intervention.DataSetName = "DataSet_Intervention"
        Me.DataSet_Intervention.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateDIntervDataGridViewTextBoxColumn
        '
        Me.DateDIntervDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateDIntervDataGridViewTextBoxColumn.DataPropertyName = "Date_DInterv"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DateDIntervDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DateDIntervDataGridViewTextBoxColumn.HeaderText = "D.Dérniére interv"
        Me.DateDIntervDataGridViewTextBoxColumn.Name = "DateDIntervDataGridViewTextBoxColumn"
        Me.DateDIntervDataGridViewTextBoxColumn.Width = 237
        '
        'TypeFrequenceDataGridViewTextBoxColumn
        '
        Me.TypeFrequenceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TypeFrequenceDataGridViewTextBoxColumn.DataPropertyName = "Type_Frequence"
        Me.TypeFrequenceDataGridViewTextBoxColumn.DataSource = Me.TypeFrequenceBindingSource
        Me.TypeFrequenceDataGridViewTextBoxColumn.DisplayMember = "Designation"
        Me.TypeFrequenceDataGridViewTextBoxColumn.HeaderText = "Type Frequence"
        Me.TypeFrequenceDataGridViewTextBoxColumn.Name = "TypeFrequenceDataGridViewTextBoxColumn"
        Me.TypeFrequenceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypeFrequenceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TypeFrequenceDataGridViewTextBoxColumn.ValueMember = "Designation"
        Me.TypeFrequenceDataGridViewTextBoxColumn.Width = 219
        '
        'TypeFrequenceBindingSource
        '
        Me.TypeFrequenceBindingSource.DataMember = "Type_Frequence"
        Me.TypeFrequenceBindingSource.DataSource = Me.DataSet_Machine
        '
        'FreqDataGridViewTextBoxColumn
        '
        Me.FreqDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FreqDataGridViewTextBoxColumn.DataPropertyName = "Freq"
        Me.FreqDataGridViewTextBoxColumn.HeaderText = "Frequence"
        Me.FreqDataGridViewTextBoxColumn.Name = "FreqDataGridViewTextBoxColumn"
        Me.FreqDataGridViewTextBoxColumn.Width = 157
        '
        'Date_PInterv
        '
        Me.Date_PInterv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Date_PInterv.DataPropertyName = "Date_PInterv"
        Me.Date_PInterv.HeaderText = "D.Prochaine interv"
        Me.Date_PInterv.Name = "Date_PInterv"
        Me.Date_PInterv.Width = 252
        '
        'MachineIntervPrevBindingSource
        '
        Me.MachineIntervPrevBindingSource.DataMember = "Machine_Interv_Prev"
        Me.MachineIntervPrevBindingSource.DataSource = Me.DataSet_Machine
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1550, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 736)
        Me.Panel1.TabIndex = 42
        '
        'MachineTableAdapter
        '
        Me.MachineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Machine_Interv_PrevTableAdapter = Me.Machine_Interv_PrevTableAdapter
        Me.TableAdapterManager.MachineTableAdapter = Me.MachineTableAdapter
        Me.TableAdapterManager.Type_FrequenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.DataSet_MachineTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Machine_Interv_PrevTableAdapter
        '
        Me.Machine_Interv_PrevTableAdapter.ClearBeforeFill = True
        '
        'Type_FrequenceTableAdapter
        '
        Me.Type_FrequenceTableAdapter.ClearBeforeFill = True
        '
        'Liste_InterventionTableAdapter
        '
        Me.Liste_InterventionTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1034, 671)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(245, 50)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Actualiser"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Fiche_Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1555, 746)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Fiche_Machine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListeInterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeFrequenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineIntervPrevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataSet_Machine As Global.GMAO_Wassim_Skander.DataSet_Machine
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineTableAdapter As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.TableAdapterManager
    Friend WithEvents Code_MachineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ImmoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmplacementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mise_en_marcheDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GarantieDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FabriquantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Machine_Interv_PrevTableAdapter As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Machine_Interv_PrevTableAdapter
    Friend WithEvents MachineIntervPrevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeFrequenceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_FrequenceTableAdapter As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Type_FrequenceTableAdapter
    Friend WithEvents DataSet_Intervention As Global.GMAO_Wassim_Skander.DataSet_Intervention
    Friend WithEvents ListeInterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Liste_InterventionTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Liste_InterventionTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Code_Machine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeIntervDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DateDIntervDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeFrequenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FreqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_PInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTF_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTF_MTextBox As System.Windows.Forms.TextBox
End Class
