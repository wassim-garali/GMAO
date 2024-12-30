<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Intervention_Preventive
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
        Dim Code_MachineLabel As System.Windows.Forms.Label
        Dim ResponsableLabel As System.Windows.Forms.Label
        Dim TechnisienLabel As System.Windows.Forms.Label
        Dim Validation_ResponsableLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim Date_IntervLabel As System.Windows.Forms.Label
        Dim N_IntervLabel As System.Windows.Forms.Label
        Dim Validation_TechnisienLabel As System.Windows.Forms.Label
        Dim Date_ArretLabel As System.Windows.Forms.Label
        Dim Date_RealisationLabel As System.Windows.Forms.Label
        Dim DureeLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_Intervention_Preventive))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMAODataSet = New GMAO_Wassim_Skander.GMAODataSet()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.InterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Intervention = New GMAO_Wassim_Skander.DataSet_Intervention()
        Me.Validation_ResponsableCheckBox = New System.Windows.Forms.CheckBox()
        Me.Code_MachineComboBox = New System.Windows.Forms.ComboBox()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Machine = New GMAO_Wassim_Skander.DataSet_Machine()
        Me.TechnisienComboBox = New System.Windows.Forms.ComboBox()
        Me.Personnel1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResponsableTextBox = New System.Windows.Forms.TextBox()
        Me.Date_IntervDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_IntervTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Date_RealisationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_ArretDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DureeTextBox = New System.Windows.Forms.TextBox()
        Me.Validation_TechnisienCheckBox = New System.Windows.Forms.CheckBox()
        Me.InterventionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_PInterv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VuepreventiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ObservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RapportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter()
        Me.MachineTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter()
        Me.Personnel1TableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.Personnel1TableAdapter()
        Me.ObservationsTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.ObservationsTableAdapter()
        Me.Vue_preventiveTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.vue_preventiveTableAdapter()
        Me.RapportTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.RapportTableAdapter()
        Me.PersonnelTableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter()
        Me.Ligne_Interv_PrevTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Ligne_Interv_PrevTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodeArticlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.QuantiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticleInterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Article_InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Article_InterventionTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ArticlesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        Me.Machine_Interv_PrevTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Machine_Interv_PrevTableAdapter()
        Code_MachineLabel = New System.Windows.Forms.Label()
        ResponsableLabel = New System.Windows.Forms.Label()
        TechnisienLabel = New System.Windows.Forms.Label()
        Validation_ResponsableLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        Date_IntervLabel = New System.Windows.Forms.Label()
        N_IntervLabel = New System.Windows.Forms.Label()
        Validation_TechnisienLabel = New System.Windows.Forms.Label()
        Date_ArretLabel = New System.Windows.Forms.Label()
        Date_RealisationLabel = New System.Windows.Forms.Label()
        DureeLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Personnel1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InterventionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VuepreventiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RapportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleInterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Code_MachineLabel
        '
        Code_MachineLabel.AutoSize = True
        Code_MachineLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Code_MachineLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Code_MachineLabel.Location = New System.Drawing.Point(589, 114)
        Code_MachineLabel.Name = "Code_MachineLabel"
        Code_MachineLabel.Size = New System.Drawing.Size(82, 22)
        Code_MachineLabel.TabIndex = 19
        Code_MachineLabel.Text = " Machine"
        '
        'ResponsableLabel
        '
        ResponsableLabel.AutoSize = True
        ResponsableLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        ResponsableLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        ResponsableLabel.Location = New System.Drawing.Point(589, 30)
        ResponsableLabel.Name = "ResponsableLabel"
        ResponsableLabel.Size = New System.Drawing.Size(109, 22)
        ResponsableLabel.TabIndex = 17
        ResponsableLabel.Text = "Responsable"
        '
        'TechnisienLabel
        '
        TechnisienLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TechnisienLabel.AutoSize = True
        TechnisienLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        TechnisienLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        TechnisienLabel.Location = New System.Drawing.Point(589, 70)
        TechnisienLabel.Name = "TechnisienLabel"
        TechnisienLabel.Size = New System.Drawing.Size(94, 22)
        TechnisienLabel.TabIndex = 16
        TechnisienLabel.Text = "Technicien"
        '
        'Validation_ResponsableLabel
        '
        Validation_ResponsableLabel.AutoSize = True
        Validation_ResponsableLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Validation_ResponsableLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Validation_ResponsableLabel.Location = New System.Drawing.Point(1205, 101)
        Validation_ResponsableLabel.Name = "Validation_ResponsableLabel"
        Validation_ResponsableLabel.Size = New System.Drawing.Size(196, 22)
        Validation_ResponsableLabel.TabIndex = 0
        Validation_ResponsableLabel.Text = "Validation Responsable"
        '
        'TypeLabel
        '
        TypeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TypeLabel.AutoSize = True
        TypeLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        TypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        TypeLabel.Location = New System.Drawing.Point(1205, 42)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(49, 22)
        TypeLabel.TabIndex = 12
        TypeLabel.Text = "Type"
        '
        'Date_IntervLabel
        '
        Date_IntervLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Date_IntervLabel.AutoSize = True
        Date_IntervLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Date_IntervLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Date_IntervLabel.Location = New System.Drawing.Point(23, 103)
        Date_IntervLabel.Name = "Date_IntervLabel"
        Date_IntervLabel.Size = New System.Drawing.Size(100, 22)
        Date_IntervLabel.TabIndex = 4
        Date_IntervLabel.Text = "Date Interv"
        '
        'N_IntervLabel
        '
        N_IntervLabel.AutoSize = True
        N_IntervLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        N_IntervLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        N_IntervLabel.Location = New System.Drawing.Point(23, 52)
        N_IntervLabel.Name = "N_IntervLabel"
        N_IntervLabel.Size = New System.Drawing.Size(81, 22)
        N_IntervLabel.TabIndex = 0
        N_IntervLabel.Text = "N° Interv"
        '
        'Validation_TechnisienLabel
        '
        Validation_TechnisienLabel.AutoSize = True
        Validation_TechnisienLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Validation_TechnisienLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Validation_TechnisienLabel.Location = New System.Drawing.Point(1147, 73)
        Validation_TechnisienLabel.Name = "Validation_TechnisienLabel"
        Validation_TechnisienLabel.Size = New System.Drawing.Size(181, 22)
        Validation_TechnisienLabel.TabIndex = 2
        Validation_TechnisienLabel.Text = "Validation Technicien"
        '
        'Date_ArretLabel
        '
        Date_ArretLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Date_ArretLabel.AutoSize = True
        Date_ArretLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Date_ArretLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Date_ArretLabel.Location = New System.Drawing.Point(21, 49)
        Date_ArretLabel.Name = "Date_ArretLabel"
        Date_ArretLabel.Size = New System.Drawing.Size(95, 22)
        Date_ArretLabel.TabIndex = 8
        Date_ArretLabel.Text = "Date Arrêt"
        '
        'Date_RealisationLabel
        '
        Date_RealisationLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Date_RealisationLabel.AutoSize = True
        Date_RealisationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Date_RealisationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Date_RealisationLabel.Location = New System.Drawing.Point(21, 94)
        Date_RealisationLabel.Name = "Date_RealisationLabel"
        Date_RealisationLabel.Size = New System.Drawing.Size(140, 22)
        Date_RealisationLabel.TabIndex = 6
        Date_RealisationLabel.Text = "Date Réalisation"
        '
        'DureeLabel
        '
        DureeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DureeLabel.AutoSize = True
        DureeLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        DureeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        DureeLabel.Location = New System.Drawing.Point(589, 98)
        DureeLabel.Name = "DureeLabel"
        DureeLabel.Size = New System.Drawing.Size(154, 22)
        DureeLabel.TabIndex = 10
        DureeLabel.Text = "Temp  Réparation"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.TextBox_Email)
        Me.GroupBox3.Controls.Add(Me.TypeComboBox)
        Me.GroupBox3.Controls.Add(Me.Validation_ResponsableCheckBox)
        Me.GroupBox3.Controls.Add(Me.Code_MachineComboBox)
        Me.GroupBox3.Controls.Add(Me.TechnisienComboBox)
        Me.GroupBox3.Controls.Add(Me.ResponsableTextBox)
        Me.GroupBox3.Controls.Add(Me.Date_IntervDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.N_IntervTextBox)
        Me.GroupBox3.Controls.Add(Code_MachineLabel)
        Me.GroupBox3.Controls.Add(ResponsableLabel)
        Me.GroupBox3.Controls.Add(TechnisienLabel)
        Me.GroupBox3.Controls.Add(Validation_ResponsableLabel)
        Me.GroupBox3.Controls.Add(TypeLabel)
        Me.GroupBox3.Controls.Add(Date_IntervLabel)
        Me.GroupBox3.Controls.Add(N_IntervLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1501, 162)
        Me.GroupBox3.TabIndex = 86
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Responsable"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Qualification", True))
        Me.TextBox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.Location = New System.Drawing.Point(945, 70)
        Me.TextBox_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(211, 27)
        Me.TextBox_Email.TabIndex = 36
        '
        'PersonnelBindingSource
        '
        Me.PersonnelBindingSource.DataMember = "Personnel"
        Me.PersonnelBindingSource.DataSource = Me.GMAODataSet
        '
        'GMAODataSet
        '
        Me.GMAODataSet.DataSetName = "GMAODataSet"
        Me.GMAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Type", True))
        Me.TypeComboBox.Enabled = False
        Me.TypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"corrective", "préventive"})
        Me.TypeComboBox.Location = New System.Drawing.Point(1280, 36)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(139, 28)
        Me.TypeComboBox.TabIndex = 35
        '
        'InterventionBindingSource
        '
        Me.InterventionBindingSource.DataMember = "Intervention"
        Me.InterventionBindingSource.DataSource = Me.DataSet_Intervention
        '
        'DataSet_Intervention
        '
        Me.DataSet_Intervention.DataSetName = "DataSet_Intervention"
        Me.DataSet_Intervention.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Validation_ResponsableCheckBox
        '
        Me.Validation_ResponsableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Validation_Responsable", True))
        Me.Validation_ResponsableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.InterventionBindingSource, "Validation_Responsable", True))
        Me.Validation_ResponsableCheckBox.Location = New System.Drawing.Point(1420, 100)
        Me.Validation_ResponsableCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Validation_ResponsableCheckBox.Name = "Validation_ResponsableCheckBox"
        Me.Validation_ResponsableCheckBox.Size = New System.Drawing.Size(61, 25)
        Me.Validation_ResponsableCheckBox.TabIndex = 34
        Me.Validation_ResponsableCheckBox.UseVisualStyleBackColor = True
        '
        'Code_MachineComboBox
        '
        Me.Code_MachineComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Code_Machine", True))
        Me.Code_MachineComboBox.DataSource = Me.MachineBindingSource
        Me.Code_MachineComboBox.DisplayMember = "Designation"
        Me.Code_MachineComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_MachineComboBox.FormattingEnabled = True
        Me.Code_MachineComboBox.Location = New System.Drawing.Point(725, 122)
        Me.Code_MachineComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Code_MachineComboBox.Name = "Code_MachineComboBox"
        Me.Code_MachineComboBox.Size = New System.Drawing.Size(308, 28)
        Me.Code_MachineComboBox.TabIndex = 32
        Me.Code_MachineComboBox.ValueMember = "Code_Machine"
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
        'TechnisienComboBox
        '
        Me.TechnisienComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Technisien", True))
        Me.TechnisienComboBox.DataSource = Me.Personnel1BindingSource
        Me.TechnisienComboBox.DisplayMember = "NomPrenom"
        Me.TechnisienComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechnisienComboBox.FormattingEnabled = True
        Me.TechnisienComboBox.Location = New System.Drawing.Point(725, 70)
        Me.TechnisienComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TechnisienComboBox.Name = "TechnisienComboBox"
        Me.TechnisienComboBox.Size = New System.Drawing.Size(213, 28)
        Me.TechnisienComboBox.TabIndex = 31
        Me.TechnisienComboBox.ValueMember = "NomPrenom"
        '
        'Personnel1BindingSource
        '
        Me.Personnel1BindingSource.DataMember = "Personnel1"
        Me.Personnel1BindingSource.DataSource = Me.GMAODataSet
        '
        'ResponsableTextBox
        '
        Me.ResponsableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Responsable", True))
        Me.ResponsableTextBox.Enabled = False
        Me.ResponsableTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResponsableTextBox.Location = New System.Drawing.Point(725, 23)
        Me.ResponsableTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResponsableTextBox.Name = "ResponsableTextBox"
        Me.ResponsableTextBox.Size = New System.Drawing.Size(213, 27)
        Me.ResponsableTextBox.TabIndex = 30
        '
        'Date_IntervDateTimePicker
        '
        Me.Date_IntervDateTimePicker.CustomFormat = "dddd dd MMMM yyyy     HH:mm:ss"
        Me.Date_IntervDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventionBindingSource, "Date_Interv", True))
        Me.Date_IntervDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_IntervDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_IntervDateTimePicker.Location = New System.Drawing.Point(180, 101)
        Me.Date_IntervDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_IntervDateTimePicker.Name = "Date_IntervDateTimePicker"
        Me.Date_IntervDateTimePicker.Size = New System.Drawing.Size(377, 27)
        Me.Date_IntervDateTimePicker.TabIndex = 29
        Me.Date_IntervDateTimePicker.Value = New Date(2023, 5, 20, 0, 0, 0, 0)
        '
        'N_IntervTextBox
        '
        Me.N_IntervTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "N_Interv", True))
        Me.N_IntervTextBox.Enabled = False
        Me.N_IntervTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_IntervTextBox.Location = New System.Drawing.Point(180, 53)
        Me.N_IntervTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.N_IntervTextBox.Name = "N_IntervTextBox"
        Me.N_IntervTextBox.Size = New System.Drawing.Size(100, 27)
        Me.N_IntervTextBox.TabIndex = 28
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
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(1249, 650)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 50)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(525, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 44)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Fiche Intervention Preventive"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Date_RealisationDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Date_ArretDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.DureeTextBox)
        Me.GroupBox1.Controls.Add(Me.Validation_TechnisienCheckBox)
        Me.GroupBox1.Controls.Add(Validation_TechnisienLabel)
        Me.GroupBox1.Controls.Add(Date_ArretLabel)
        Me.GroupBox1.Controls.Add(Date_RealisationLabel)
        Me.GroupBox1.Controls.Add(DureeLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(13, 249)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1501, 159)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technicien"
        '
        'Date_RealisationDateTimePicker
        '
        Me.Date_RealisationDateTimePicker.CustomFormat = "dddd dd MMMM yyyy     HH:mm:ss"
        Me.Date_RealisationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventionBindingSource, "Date_Realisation", True))
        Me.Date_RealisationDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_RealisationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_RealisationDateTimePicker.Location = New System.Drawing.Point(180, 94)
        Me.Date_RealisationDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_RealisationDateTimePicker.Name = "Date_RealisationDateTimePicker"
        Me.Date_RealisationDateTimePicker.Size = New System.Drawing.Size(377, 27)
        Me.Date_RealisationDateTimePicker.TabIndex = 14
        '
        'Date_ArretDateTimePicker
        '
        Me.Date_ArretDateTimePicker.CustomFormat = "dddd dd MMMM yyyy     HH:mm:ss"
        Me.Date_ArretDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventionBindingSource, "Date_Arret", True))
        Me.Date_ArretDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_ArretDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_ArretDateTimePicker.Location = New System.Drawing.Point(180, 46)
        Me.Date_ArretDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_ArretDateTimePicker.Name = "Date_ArretDateTimePicker"
        Me.Date_ArretDateTimePicker.Size = New System.Drawing.Size(377, 27)
        Me.Date_ArretDateTimePicker.TabIndex = 13
        '
        'DureeTextBox
        '
        Me.DureeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Duree", True))
        Me.DureeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DureeTextBox.Location = New System.Drawing.Point(808, 96)
        Me.DureeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DureeTextBox.Name = "DureeTextBox"
        Me.DureeTextBox.Size = New System.Drawing.Size(131, 27)
        Me.DureeTextBox.TabIndex = 12
        '
        'Validation_TechnisienCheckBox
        '
        Me.Validation_TechnisienCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Validation_Technisien", True))
        Me.Validation_TechnisienCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.InterventionBindingSource1, "Validation_Technisien", True))
        Me.Validation_TechnisienCheckBox.Location = New System.Drawing.Point(1355, 73)
        Me.Validation_TechnisienCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Validation_TechnisienCheckBox.Name = "Validation_TechnisienCheckBox"
        Me.Validation_TechnisienCheckBox.Size = New System.Drawing.Size(48, 25)
        Me.Validation_TechnisienCheckBox.TabIndex = 11
        Me.Validation_TechnisienCheckBox.UseVisualStyleBackColor = True
        '
        'InterventionBindingSource1
        '
        Me.InterventionBindingSource1.DataMember = "Intervention"
        Me.InterventionBindingSource1.DataSource = Me.DataSet_Intervention
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 411)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1508, 186)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fiche preventive "
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PersonnelDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PersonnelDataGridView.ColumnHeadersHeight = 35
        Me.PersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Type, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn8, Me.Date_PInterv, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6})
        Me.PersonnelDataGridView.DataSource = Me.VuepreventiveBindingSource
        Me.PersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.GridColor = System.Drawing.Color.White
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 32)
        Me.PersonnelDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PersonnelDataGridView.MultiSelect = False
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.ReadOnly = True
        Me.PersonnelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1502, 152)
        Me.PersonnelDataGridView.TabIndex = 55
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_intervention"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_intervention"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 210
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Code_Interv"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Interventions"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 500
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Intervention"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Intervention"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 182
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 172
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Type_Frequence"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Type Frequence"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 219
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Freq"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Freq"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 89
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date_DInterv"
        Me.DataGridViewTextBoxColumn8.HeaderText = "D.Dérniere Interv"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 238
        '
        'Date_PInterv
        '
        Me.Date_PInterv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Date_PInterv.DataPropertyName = "Date_PInterv"
        Me.Date_PInterv.HeaderText = "D.Prochaine Interv"
        Me.Date_PInterv.Name = "Date_PInterv"
        Me.Date_PInterv.ReadOnly = True
        Me.Date_PInterv.Width = 253
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Duree"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Durée"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 108
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Observation"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observation"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Validation"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Valide"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 91
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Code_Machine"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Code_Machine"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 205
        '
        'VuepreventiveBindingSource
        '
        Me.VuepreventiveBindingSource.DataMember = "vue_preventive"
        Me.VuepreventiveBindingSource.DataSource = Me.DataSet_Intervention
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(555, 609)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(659, 161)
        Me.GroupBox4.TabIndex = 83
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observation"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowDrop = True
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeight = 35
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.DataGridView2.DataSource = Me.RapportBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(3, 32)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(653, 127)
        Me.DataGridView2.TabIndex = 44
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "N_Intervention"
        Me.DataGridViewTextBoxColumn11.HeaderText = "N_Intervention"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 211
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Type_Observation"
        Me.DataGridViewTextBoxColumn12.DataSource = Me.ObservationsBindingSource
        Me.DataGridViewTextBoxColumn12.DisplayMember = "Designation"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Type Observation"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn12.ValueMember = "Designation"
        Me.DataGridViewTextBoxColumn12.Width = 240
        '
        'ObservationsBindingSource
        '
        Me.ObservationsBindingSource.DataMember = "Observations"
        Me.ObservationsBindingSource.DataSource = Me.DataSet_Intervention
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Observation"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Observation"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 300
        '
        'RapportBindingSource
        '
        Me.RapportBindingSource.DataMember = "Rapport"
        Me.RapportBindingSource.DataSource = Me.DataSet_Intervention
        '
        'InterventionTableAdapter
        '
        Me.InterventionTableAdapter.ClearBeforeFill = True
        '
        'MachineTableAdapter
        '
        Me.MachineTableAdapter.ClearBeforeFill = True
        '
        'Personnel1TableAdapter
        '
        Me.Personnel1TableAdapter.ClearBeforeFill = True
        '
        'ObservationsTableAdapter
        '
        Me.ObservationsTableAdapter.ClearBeforeFill = True
        '
        'Vue_preventiveTableAdapter
        '
        Me.Vue_preventiveTableAdapter.ClearBeforeFill = True
        '
        'RapportTableAdapter
        '
        Me.RapportTableAdapter.ClearBeforeFill = True
        '
        'PersonnelTableAdapter
        '
        Me.PersonnelTableAdapter.ClearBeforeFill = True
        '
        'Ligne_Interv_PrevTableAdapter
        '
        Me.Ligne_Interv_PrevTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(12, 610)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(506, 159)
        Me.GroupBox5.TabIndex = 88
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Articles"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeArticlesDataGridViewTextBoxColumn, Me.QuantiteDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.TypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArticleInterventionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(500, 129)
        Me.DataGridView1.TabIndex = 44
        '
        'CodeArticlesDataGridViewTextBoxColumn
        '
        Me.CodeArticlesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodeArticlesDataGridViewTextBoxColumn.DataPropertyName = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.DataSource = Me.ArticlesBindingSource
        Me.CodeArticlesDataGridViewTextBoxColumn.DisplayMember = "Designation"
        Me.CodeArticlesDataGridViewTextBoxColumn.HeaderText = "Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Name = "CodeArticlesDataGridViewTextBoxColumn"
        Me.CodeArticlesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeArticlesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CodeArticlesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CodeArticlesDataGridViewTextBoxColumn.ValueMember = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Width = 280
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
        Me.QuantiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.QuantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite"
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        Me.QuantiteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.QuantiteDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.QuantiteDataGridViewTextBoxColumn.HeaderText = "QT"
        Me.QuantiteDataGridViewTextBoxColumn.Name = "QuantiteDataGridViewTextBoxColumn"
        Me.QuantiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantiteDataGridViewTextBoxColumn.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "N_intervention"
        Me.DataGridViewTextBoxColumn14.HeaderText = "N_intervention"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Code_Machine"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Code_Machine"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Visible = False
        '
        'ArticleInterventionBindingSource
        '
        Me.ArticleInterventionBindingSource.DataMember = "Article_Intervention"
        Me.ArticleInterventionBindingSource.DataSource = Me.DataSet_Intervention
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
        Me.Button2.Location = New System.Drawing.Point(1249, 726)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(245, 50)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Actualiser"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Article_InterventionTableAdapter
        '
        Me.Article_InterventionTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Machine_Interv_PrevTableAdapter
        '
        Me.Machine_Interv_PrevTableAdapter.ClearBeforeFill = True
        '
        'Fiche_Intervention_Preventive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1532, 802)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Fiche_Intervention_Preventive"
        Me.Text = "Fiche_Intervention_Preventive"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Personnel1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InterventionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VuepreventiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RapportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleInterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Code_MachineComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TechnisienComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ResponsableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_IntervDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N_IntervTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Validation_ResponsableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Date_RealisationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_ArretDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DureeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Validation_TechnisienCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NinterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeMachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeIntervDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDIntervDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeFrequenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NInterventionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeObservationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ObservationDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_Intervention As Global.GMAO_Wassim_Skander.DataSet_Intervention
    Friend WithEvents InterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterventionTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter
    Friend WithEvents DataSet_Machine As Global.GMAO_Wassim_Skander.DataSet_Machine
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineTableAdapter As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter
    Friend WithEvents GMAODataSet As Global.GMAO_Wassim_Skander.GMAODataSet
    Friend WithEvents Personnel1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Personnel1TableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.Personnel1TableAdapter
    Friend WithEvents ObservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObservationsTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.ObservationsTableAdapter
    Friend WithEvents VuepreventiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vue_preventiveTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.vue_preventiveTableAdapter
    Friend WithEvents RapportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RapportTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.RapportTableAdapter
    Friend WithEvents PersonnelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonnelTableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter
    Friend WithEvents Ligne_Interv_PrevTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Ligne_Interv_PrevTableAdapter
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ArticleInterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Article_InterventionTableAdapter As GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Article_InterventionTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataSet_Stock As GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents InterventionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_PInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeArticlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Machine_Interv_PrevTableAdapter As GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Machine_Interv_PrevTableAdapter
End Class
