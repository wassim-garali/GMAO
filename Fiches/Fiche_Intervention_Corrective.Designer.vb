<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Intervention_Corrective
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DT_MLabel As System.Windows.Forms.Label
        Dim DT_DLabel As System.Windows.Forms.Label
        Dim UT_MLabel As System.Windows.Forms.Label
        Dim UT_DLabel As System.Windows.Forms.Label
        Dim TTR_MLabel As System.Windows.Forms.Label
        Dim TTR_DLabel As System.Windows.Forms.Label
        Dim TBF_MLabel As System.Windows.Forms.Label
        Dim TBF_DLabel As System.Windows.Forms.Label
        Dim Temps_reparationLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_Intervention_Corrective))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMAODataSet = New GMAO_Wassim_Skander.GMAODataSet()
        Me.NomPrenomComboBox = New System.Windows.Forms.ComboBox()
        Me.InterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Intervention = New GMAO_Wassim_Skander.DataSet_Intervention()
        Me.Personnel1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Validation_ResponsableCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Date_ArretDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Code_MachineComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Machine = New GMAO_Wassim_Skander.DataSet_Machine()
        Me.ResponsableTextBox1 = New System.Windows.Forms.TextBox()
        Me.Date_IntervDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.N_IntervTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Date_RealisationDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DureeTextBox1 = New System.Windows.Forms.TextBox()
        Me.Validation_TechnisienCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ListePanneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LigneIntervPrevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Personnel1TableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.Personnel1TableAdapter()
        Me.TableAdapterManager1 = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager()
        Me.MachineTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter()
        Me.Ligne_Interv_PrevTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Ligne_Interv_PrevTableAdapter()
        Me.Liste_PanneTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Liste_PanneTableAdapter()
        Me.PersonnelTableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeArticlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.QuantiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticleInterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Article_InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Article_InterventionTableAdapter()
        Me.ArticlesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ObservationTextBox = New System.Windows.Forms.TextBox()
        Me.DT_MTextBox = New System.Windows.Forms.TextBox()
        Me.DT_DTextBox = New System.Windows.Forms.TextBox()
        Me.UT_MTextBox = New System.Windows.Forms.TextBox()
        Me.UT_DTextBox = New System.Windows.Forms.TextBox()
        Me.TTR_MTextBox = New System.Windows.Forms.TextBox()
        Me.TTR_DTextBox = New System.Windows.Forms.TextBox()
        Me.TBF_MTextBox = New System.Windows.Forms.TextBox()
        Me.TBF_DTextBox = New System.Windows.Forms.TextBox()
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
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        DT_MLabel = New System.Windows.Forms.Label()
        DT_DLabel = New System.Windows.Forms.Label()
        UT_MLabel = New System.Windows.Forms.Label()
        UT_DLabel = New System.Windows.Forms.Label()
        TTR_MLabel = New System.Windows.Forms.Label()
        TTR_DLabel = New System.Windows.Forms.Label()
        TBF_MLabel = New System.Windows.Forms.Label()
        TBF_DLabel = New System.Windows.Forms.Label()
        Temps_reparationLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Personnel1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListePanneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LigneIntervPrevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
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
        Code_MachineLabel.Location = New System.Drawing.Point(635, 124)
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
        ResponsableLabel.Location = New System.Drawing.Point(635, 39)
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
        TechnisienLabel.Location = New System.Drawing.Point(635, 80)
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
        Validation_ResponsableLabel.Location = New System.Drawing.Point(1251, 126)
        Validation_ResponsableLabel.Name = "Validation_ResponsableLabel"
        Validation_ResponsableLabel.Size = New System.Drawing.Size(196, 22)
        Validation_ResponsableLabel.TabIndex = 0
        Validation_ResponsableLabel.Text = "Validation Responsable"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        TypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        TypeLabel.Location = New System.Drawing.Point(1251, 50)
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
        Date_IntervLabel.Location = New System.Drawing.Point(29, 82)
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
        N_IntervLabel.Location = New System.Drawing.Point(29, 46)
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
        Validation_TechnisienLabel.Location = New System.Drawing.Point(1248, 62)
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
        Date_ArretLabel.Location = New System.Drawing.Point(30, 123)
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
        Date_RealisationLabel.Location = New System.Drawing.Point(31, 85)
        Date_RealisationLabel.Name = "Date_RealisationLabel"
        Date_RealisationLabel.Size = New System.Drawing.Size(128, 22)
        Date_RealisationLabel.TabIndex = 6
        Date_RealisationLabel.Text = "Date R.marche"
        '
        'Label2
        '
        Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold)
        Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label2.Location = New System.Drawing.Point(31, 45)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(113, 22)
        Label2.TabIndex = 32
        Label2.Text = "Date D.Arrêt"
        '
        'Label3
        '
        Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label3.Location = New System.Drawing.Point(72, 649)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(138, 26)
        Label3.TabIndex = 86
        Label3.Text = "Observation :"
        '
        'DT_MLabel
        '
        DT_MLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DT_MLabel.AutoSize = True
        DT_MLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DT_MLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DT_MLabel.Location = New System.Drawing.Point(807, 731)
        DT_MLabel.Name = "DT_MLabel"
        DT_MLabel.Size = New System.Drawing.Size(49, 18)
        DT_MLabel.TabIndex = 86
        DT_MLabel.Text = "DT M:"
        '
        'DT_DLabel
        '
        DT_DLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DT_DLabel.AutoSize = True
        DT_DLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DT_DLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DT_DLabel.Location = New System.Drawing.Point(1031, 731)
        DT_DLabel.Name = "DT_DLabel"
        DT_DLabel.Size = New System.Drawing.Size(47, 18)
        DT_DLabel.TabIndex = 87
        DT_DLabel.Text = "DT D:"
        '
        'UT_MLabel
        '
        UT_MLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UT_MLabel.AutoSize = True
        UT_MLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UT_MLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        UT_MLabel.Location = New System.Drawing.Point(807, 773)
        UT_MLabel.Name = "UT_MLabel"
        UT_MLabel.Size = New System.Drawing.Size(49, 18)
        UT_MLabel.TabIndex = 88
        UT_MLabel.Text = "UT M:"
        '
        'UT_DLabel
        '
        UT_DLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UT_DLabel.AutoSize = True
        UT_DLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UT_DLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        UT_DLabel.Location = New System.Drawing.Point(1031, 770)
        UT_DLabel.Name = "UT_DLabel"
        UT_DLabel.Size = New System.Drawing.Size(47, 18)
        UT_DLabel.TabIndex = 89
        UT_DLabel.Text = "UT D:"
        '
        'TTR_MLabel
        '
        TTR_MLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TTR_MLabel.AutoSize = True
        TTR_MLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TTR_MLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TTR_MLabel.Location = New System.Drawing.Point(808, 807)
        TTR_MLabel.Name = "TTR_MLabel"
        TTR_MLabel.Size = New System.Drawing.Size(58, 18)
        TTR_MLabel.TabIndex = 90
        TTR_MLabel.Text = "TTR M:"
        '
        'TTR_DLabel
        '
        TTR_DLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TTR_DLabel.AutoSize = True
        TTR_DLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TTR_DLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TTR_DLabel.Location = New System.Drawing.Point(1031, 807)
        TTR_DLabel.Name = "TTR_DLabel"
        TTR_DLabel.Size = New System.Drawing.Size(56, 18)
        TTR_DLabel.TabIndex = 91
        TTR_DLabel.Text = "TTR D:"
        '
        'TBF_MLabel
        '
        TBF_MLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TBF_MLabel.AutoSize = True
        TBF_MLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBF_MLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TBF_MLabel.Location = New System.Drawing.Point(808, 848)
        TBF_MLabel.Name = "TBF_MLabel"
        TBF_MLabel.Size = New System.Drawing.Size(57, 18)
        TBF_MLabel.TabIndex = 92
        TBF_MLabel.Text = "TBF M:"
        '
        'TBF_DLabel
        '
        TBF_DLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TBF_DLabel.AutoSize = True
        TBF_DLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBF_DLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TBF_DLabel.Location = New System.Drawing.Point(1031, 850)
        TBF_DLabel.Name = "TBF_DLabel"
        TBF_DLabel.Size = New System.Drawing.Size(55, 18)
        TBF_DLabel.TabIndex = 93
        TBF_DLabel.Text = "TBF D:"
        '
        'Temps_reparationLabel
        '
        Temps_reparationLabel.AutoSize = True
        Temps_reparationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Temps_reparationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Temps_reparationLabel.Location = New System.Drawing.Point(681, 63)
        Temps_reparationLabel.Name = "Temps_reparationLabel"
        Temps_reparationLabel.Size = New System.Drawing.Size(156, 22)
        Temps_reparationLabel.TabIndex = 87
        Temps_reparationLabel.Text = "Temps Réparation"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.TextBox_Email)
        Me.GroupBox3.Controls.Add(Me.NomPrenomComboBox)
        Me.GroupBox3.Controls.Add(Me.TypeComboBox)
        Me.GroupBox3.Controls.Add(Me.Validation_ResponsableCheckBox1)
        Me.GroupBox3.Controls.Add(Me.Date_ArretDateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Code_MachineComboBox1)
        Me.GroupBox3.Controls.Add(Me.ResponsableTextBox1)
        Me.GroupBox3.Controls.Add(Me.Date_IntervDateTimePicker1)
        Me.GroupBox3.Controls.Add(Date_ArretLabel)
        Me.GroupBox3.Controls.Add(Me.N_IntervTextBox1)
        Me.GroupBox3.Controls.Add(Code_MachineLabel)
        Me.GroupBox3.Controls.Add(ResponsableLabel)
        Me.GroupBox3.Controls.Add(TechnisienLabel)
        Me.GroupBox3.Controls.Add(Validation_ResponsableLabel)
        Me.GroupBox3.Controls.Add(TypeLabel)
        Me.GroupBox3.Controls.Add(Date_IntervLabel)
        Me.GroupBox3.Controls.Add(N_IntervLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(49, 81)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1533, 187)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Responsable"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Qualification", True))
        Me.TextBox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.Location = New System.Drawing.Point(989, 78)
        Me.TextBox_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(211, 27)
        Me.TextBox_Email.TabIndex = 30
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
        'NomPrenomComboBox
        '
        Me.NomPrenomComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Technisien", True))
        Me.NomPrenomComboBox.DataSource = Me.Personnel1BindingSource
        Me.NomPrenomComboBox.DisplayMember = "NomPrenom"
        Me.NomPrenomComboBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomPrenomComboBox.FormattingEnabled = True
        Me.NomPrenomComboBox.Location = New System.Drawing.Point(792, 74)
        Me.NomPrenomComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NomPrenomComboBox.Name = "NomPrenomComboBox"
        Me.NomPrenomComboBox.Size = New System.Drawing.Size(192, 30)
        Me.NomPrenomComboBox.TabIndex = 29
        Me.NomPrenomComboBox.ValueMember = "NomPrenom"
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
        'Personnel1BindingSource
        '
        Me.Personnel1BindingSource.DataMember = "Personnel1"
        Me.Personnel1BindingSource.DataSource = Me.GMAODataSet
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Type", True))
        Me.TypeComboBox.Enabled = False
        Me.TypeComboBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"corrective", "préventive"})
        Me.TypeComboBox.Location = New System.Drawing.Point(1339, 47)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(169, 30)
        Me.TypeComboBox.TabIndex = 28
        '
        'Validation_ResponsableCheckBox1
        '
        Me.Validation_ResponsableCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Validation_Responsable", True))
        Me.Validation_ResponsableCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.InterventionBindingSource, "Validation_Responsable", True))
        Me.Validation_ResponsableCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.InterventionBindingSource, "Validation_Responsable", True))
        Me.Validation_ResponsableCheckBox1.Location = New System.Drawing.Point(1475, 126)
        Me.Validation_ResponsableCheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Validation_ResponsableCheckBox1.Name = "Validation_ResponsableCheckBox1"
        Me.Validation_ResponsableCheckBox1.Size = New System.Drawing.Size(32, 25)
        Me.Validation_ResponsableCheckBox1.TabIndex = 27
        Me.Validation_ResponsableCheckBox1.UseVisualStyleBackColor = True
        '
        'Date_ArretDateTimePicker1
        '
        Me.Date_ArretDateTimePicker1.CustomFormat = "dddd dd MMMM yyyy     HH:mm"
        Me.Date_ArretDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventionBindingSource, "Date_Arret", True))
        Me.Date_ArretDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_ArretDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_ArretDateTimePicker1.Location = New System.Drawing.Point(208, 121)
        Me.Date_ArretDateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_ArretDateTimePicker1.Name = "Date_ArretDateTimePicker1"
        Me.Date_ArretDateTimePicker1.Size = New System.Drawing.Size(392, 27)
        Me.Date_ArretDateTimePicker1.TabIndex = 14
        '
        'Code_MachineComboBox1
        '
        Me.Code_MachineComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Code_Machine", True))
        Me.Code_MachineComboBox1.DataSource = Me.MachineBindingSource
        Me.Code_MachineComboBox1.DisplayMember = "Designation"
        Me.Code_MachineComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_MachineComboBox1.FormattingEnabled = True
        Me.Code_MachineComboBox1.Location = New System.Drawing.Point(792, 121)
        Me.Code_MachineComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Code_MachineComboBox1.Name = "Code_MachineComboBox1"
        Me.Code_MachineComboBox1.Size = New System.Drawing.Size(311, 28)
        Me.Code_MachineComboBox1.TabIndex = 25
        Me.Code_MachineComboBox1.ValueMember = "Code_Machine"
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
        'ResponsableTextBox1
        '
        Me.ResponsableTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Responsable", True))
        Me.ResponsableTextBox1.Enabled = False
        Me.ResponsableTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResponsableTextBox1.Location = New System.Drawing.Point(792, 33)
        Me.ResponsableTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResponsableTextBox1.Name = "ResponsableTextBox1"
        Me.ResponsableTextBox1.Size = New System.Drawing.Size(192, 27)
        Me.ResponsableTextBox1.TabIndex = 23
        '
        'Date_IntervDateTimePicker1
        '
        Me.Date_IntervDateTimePicker1.CustomFormat = "dddd dd MMMM yyyy     "
        Me.Date_IntervDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventionBindingSource, "Date_Interv", True))
        Me.Date_IntervDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_IntervDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_IntervDateTimePicker1.Location = New System.Drawing.Point(208, 80)
        Me.Date_IntervDateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_IntervDateTimePicker1.Name = "Date_IntervDateTimePicker1"
        Me.Date_IntervDateTimePicker1.Size = New System.Drawing.Size(392, 27)
        Me.Date_IntervDateTimePicker1.TabIndex = 22
        '
        'N_IntervTextBox1
        '
        Me.N_IntervTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "N_Interv", True))
        Me.N_IntervTextBox1.Enabled = False
        Me.N_IntervTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_IntervTextBox1.Location = New System.Drawing.Point(208, 42)
        Me.N_IntervTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.N_IntervTextBox1.Name = "N_IntervTextBox1"
        Me.N_IntervTextBox1.Size = New System.Drawing.Size(100, 27)
        Me.N_IntervTextBox1.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd dd MMMM yyyy     HH:mm"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 42)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(392, 27)
        Me.DateTimePicker1.TabIndex = 31
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
        Me.Button1.Location = New System.Drawing.Point(1347, 722)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 50)
        Me.Button1.TabIndex = 79
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
        Me.Label1.Location = New System.Drawing.Point(569, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 44)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Fiche Intervention Corrective"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Temps_reparationLabel)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Date_RealisationDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DureeTextBox1)
        Me.GroupBox1.Controls.Add(Me.Validation_TechnisienCheckBox1)
        Me.GroupBox1.Controls.Add(Validation_TechnisienLabel)
        Me.GroupBox1.Controls.Add(Date_RealisationLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(47, 272)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1535, 146)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technicien"
        '
        'Date_RealisationDateTimePicker1
        '
        Me.Date_RealisationDateTimePicker1.CustomFormat = "dddd dd MMMM yyyy     HH:mm"
        Me.Date_RealisationDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventionBindingSource, "Date_Realisation", True))
        Me.Date_RealisationDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_RealisationDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_RealisationDateTimePicker1.Location = New System.Drawing.Point(210, 85)
        Me.Date_RealisationDateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_RealisationDateTimePicker1.Name = "Date_RealisationDateTimePicker1"
        Me.Date_RealisationDateTimePicker1.Size = New System.Drawing.Size(392, 27)
        Me.Date_RealisationDateTimePicker1.TabIndex = 15
        '
        'DureeTextBox1
        '
        Me.DureeTextBox1.AcceptsTab = True
        Me.DureeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Duree", True))
        Me.DureeTextBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DureeTextBox1.Location = New System.Drawing.Point(900, 59)
        Me.DureeTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DureeTextBox1.Name = "DureeTextBox1"
        Me.DureeTextBox1.Size = New System.Drawing.Size(131, 29)
        Me.DureeTextBox1.TabIndex = 13
        '
        'Validation_TechnisienCheckBox1
        '
        Me.Validation_TechnisienCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.InterventionBindingSource, "Validation_Technisien", True))
        Me.Validation_TechnisienCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Validation_Technisien", True))
        Me.Validation_TechnisienCheckBox1.Location = New System.Drawing.Point(1453, 66)
        Me.Validation_TechnisienCheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Validation_TechnisienCheckBox1.Name = "Validation_TechnisienCheckBox1"
        Me.Validation_TechnisienCheckBox1.Size = New System.Drawing.Size(29, 25)
        Me.Validation_TechnisienCheckBox1.TabIndex = 12
        Me.Validation_TechnisienCheckBox1.UseVisualStyleBackColor = True
        '
        'InterventionTableAdapter
        '
        Me.InterventionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Article_InterventionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InterventionTableAdapter = Me.InterventionTableAdapter
        Me.TableAdapterManager.Ligne_Interv_PrevTableAdapter = Nothing
        Me.TableAdapterManager.Liste_InterventionTableAdapter = Nothing
        Me.TableAdapterManager.Liste_PanneTableAdapter = Nothing
        Me.TableAdapterManager.ObservationsTableAdapter = Nothing
        Me.TableAdapterManager.RapportTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vue_preventiveTableAdapter = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PersonnelDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(19, 423)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1587, 222)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fiche corrective "
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
        Me.PersonnelDataGridView.ColumnHeadersHeight = 30
        Me.PersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.Type})
        Me.PersonnelDataGridView.DataSource = Me.LigneIntervPrevBindingSource
        Me.PersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.GridColor = System.Drawing.Color.White
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(3, 32)
        Me.PersonnelDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PersonnelDataGridView.MultiSelect = False
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        Me.PersonnelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1581, 188)
        Me.PersonnelDataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_intervention"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_intervention"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 182
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code_Machine"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code_Machine"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 181
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code_Intervention"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ListePanneBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Designation"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type de panne"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Designation"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'ListePanneBindingSource
        '
        Me.ListePanneBindingSource.DataMember = "Liste_Panne"
        Me.ListePanneBindingSource.DataSource = Me.DataSet_Intervention
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Déscription panne"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 420
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Intervention"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Travaux efféctuer"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 480
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Duree"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Durée"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 108
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Observation"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observation"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Visible = False
        '
        'LigneIntervPrevBindingSource
        '
        Me.LigneIntervPrevBindingSource.DataMember = "Ligne_Interv_Prev"
        Me.LigneIntervPrevBindingSource.DataSource = Me.DataSet_Intervention
        '
        'Personnel1TableAdapter
        '
        Me.Personnel1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Personnel1TableAdapter = Me.Personnel1TableAdapter
        Me.TableAdapterManager1.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachineTableAdapter
        '
        Me.MachineTableAdapter.ClearBeforeFill = True
        '
        'Ligne_Interv_PrevTableAdapter
        '
        Me.Ligne_Interv_PrevTableAdapter.ClearBeforeFill = True
        '
        'Liste_PanneTableAdapter
        '
        Me.Liste_PanneTableAdapter.ClearBeforeFill = True
        '
        'PersonnelTableAdapter
        '
        Me.PersonnelTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(21, 720)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(663, 140)
        Me.GroupBox4.TabIndex = 83
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Articles"
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.TypeDataGridViewTextBoxColumn, Me.CodeArticlesDataGridViewTextBoxColumn, Me.QuantiteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArticleInterventionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(657, 110)
        Me.DataGridView1.TabIndex = 43
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "N_intervention"
        Me.DataGridViewTextBoxColumn8.HeaderText = "N_intervention"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Code_Machine"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Code_Machine"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Visible = False
        '
        'CodeArticlesDataGridViewTextBoxColumn
        '
        Me.CodeArticlesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodeArticlesDataGridViewTextBoxColumn.DataPropertyName = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.DataSource = Me.ArticlesBindingSource
        Me.CodeArticlesDataGridViewTextBoxColumn.DisplayMember = "Designation"
        Me.CodeArticlesDataGridViewTextBoxColumn.HeaderText = "Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Name = "CodeArticlesDataGridViewTextBoxColumn"
        Me.CodeArticlesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CodeArticlesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CodeArticlesDataGridViewTextBoxColumn.ValueMember = "Code_Articles"
        Me.CodeArticlesDataGridViewTextBoxColumn.Width = 431
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
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.QuantiteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.QuantiteDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QuantiteDataGridViewTextBoxColumn.Name = "QuantiteDataGridViewTextBoxColumn"
        Me.QuantiteDataGridViewTextBoxColumn.Width = 150
        '
        'ArticleInterventionBindingSource
        '
        Me.ArticleInterventionBindingSource.DataMember = "Article_Intervention"
        Me.ArticleInterventionBindingSource.DataSource = Me.DataSet_Intervention
        '
        'Article_InterventionTableAdapter
        '
        Me.Article_InterventionTableAdapter.ClearBeforeFill = True
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
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
        Me.Button2.Location = New System.Drawing.Point(1347, 798)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(245, 50)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Actualiser"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'ObservationTextBox
        '
        Me.ObservationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ObservationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "Observation", True))
        Me.ObservationTextBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservationTextBox.Location = New System.Drawing.Point(252, 649)
        Me.ObservationTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ObservationTextBox.Multiline = True
        Me.ObservationTextBox.Name = "ObservationTextBox"
        Me.ObservationTextBox.Size = New System.Drawing.Size(900, 63)
        Me.ObservationTextBox.TabIndex = 31
        '
        'DT_MTextBox
        '
        Me.DT_MTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "DT_M", True))
        Me.DT_MTextBox.Enabled = False
        Me.DT_MTextBox.Location = New System.Drawing.Point(891, 727)
        Me.DT_MTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DT_MTextBox.Name = "DT_MTextBox"
        Me.DT_MTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DT_MTextBox.TabIndex = 87
        '
        'DT_DTextBox
        '
        Me.DT_DTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "DT_D", True))
        Me.DT_DTextBox.Enabled = False
        Me.DT_DTextBox.Location = New System.Drawing.Point(1097, 728)
        Me.DT_DTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DT_DTextBox.Name = "DT_DTextBox"
        Me.DT_DTextBox.Size = New System.Drawing.Size(143, 22)
        Me.DT_DTextBox.TabIndex = 88
        '
        'UT_MTextBox
        '
        Me.UT_MTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UT_MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "UT_M", True))
        Me.UT_MTextBox.Enabled = False
        Me.UT_MTextBox.Location = New System.Drawing.Point(891, 770)
        Me.UT_MTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UT_MTextBox.Name = "UT_MTextBox"
        Me.UT_MTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UT_MTextBox.TabIndex = 89
        '
        'UT_DTextBox
        '
        Me.UT_DTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UT_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "UT_D", True))
        Me.UT_DTextBox.Enabled = False
        Me.UT_DTextBox.Location = New System.Drawing.Point(1097, 765)
        Me.UT_DTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UT_DTextBox.Name = "UT_DTextBox"
        Me.UT_DTextBox.Size = New System.Drawing.Size(143, 22)
        Me.UT_DTextBox.TabIndex = 90
        '
        'TTR_MTextBox
        '
        Me.TTR_MTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTR_MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "TTR_M", True))
        Me.TTR_MTextBox.Enabled = False
        Me.TTR_MTextBox.Location = New System.Drawing.Point(891, 807)
        Me.TTR_MTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TTR_MTextBox.Name = "TTR_MTextBox"
        Me.TTR_MTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TTR_MTextBox.TabIndex = 91
        '
        'TTR_DTextBox
        '
        Me.TTR_DTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTR_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "TTR_D", True))
        Me.TTR_DTextBox.Enabled = False
        Me.TTR_DTextBox.Location = New System.Drawing.Point(1097, 803)
        Me.TTR_DTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TTR_DTextBox.Name = "TTR_DTextBox"
        Me.TTR_DTextBox.Size = New System.Drawing.Size(143, 22)
        Me.TTR_DTextBox.TabIndex = 92
        '
        'TBF_MTextBox
        '
        Me.TBF_MTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBF_MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "TBF_M", True))
        Me.TBF_MTextBox.Enabled = False
        Me.TBF_MTextBox.Location = New System.Drawing.Point(891, 848)
        Me.TBF_MTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBF_MTextBox.Name = "TBF_MTextBox"
        Me.TBF_MTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TBF_MTextBox.TabIndex = 93
        '
        'TBF_DTextBox
        '
        Me.TBF_DTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBF_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventionBindingSource, "TBF_D", True))
        Me.TBF_DTextBox.Enabled = False
        Me.TBF_DTextBox.Location = New System.Drawing.Point(1097, 845)
        Me.TBF_DTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBF_DTextBox.Name = "TBF_DTextBox"
        Me.TBF_DTextBox.Size = New System.Drawing.Size(143, 22)
        Me.TBF_DTextBox.TabIndex = 94
        '
        'Fiche_Intervention_Corrective
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1604, 874)
        Me.Controls.Add(TBF_DLabel)
        Me.Controls.Add(Me.TBF_DTextBox)
        Me.Controls.Add(TBF_MLabel)
        Me.Controls.Add(Me.TBF_MTextBox)
        Me.Controls.Add(TTR_DLabel)
        Me.Controls.Add(Me.TTR_DTextBox)
        Me.Controls.Add(TTR_MLabel)
        Me.Controls.Add(Me.TTR_MTextBox)
        Me.Controls.Add(UT_DLabel)
        Me.Controls.Add(Me.UT_DTextBox)
        Me.Controls.Add(UT_MLabel)
        Me.Controls.Add(Me.UT_MTextBox)
        Me.Controls.Add(DT_DLabel)
        Me.Controls.Add(Me.DT_DTextBox)
        Me.Controls.Add(DT_MLabel)
        Me.Controls.Add(Me.DT_MTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ObservationTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Fiche_Intervention_Corrective"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fiche_Intervention_Corrective"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Personnel1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Machine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListePanneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LigneIntervPrevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
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
    Friend WithEvents DataSet_Intervention As Global.GMAO_Wassim_Skander.DataSet_Intervention
    Friend WithEvents InterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterventionTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.TableAdapterManager
    Friend WithEvents N_IntervTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Validation_ResponsableCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Code_MachineComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ResponsableTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Date_IntervDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_RealisationDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_ArretDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Validation_TechnisienCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NinterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeMachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeInterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GMAODataSet As Global.GMAO_Wassim_Skander.GMAODataSet
    Friend WithEvents Personnel1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Personnel1TableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.Personnel1TableAdapter
    Friend WithEvents NomPrenomComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager1 As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataSet_Machine As Global.GMAO_Wassim_Skander.DataSet_Machine
    Friend WithEvents MachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineTableAdapter As Global.GMAO_Wassim_Skander.DataSet_MachineTableAdapters.MachineTableAdapter
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LigneIntervPrevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ligne_Interv_PrevTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Ligne_Interv_PrevTableAdapter
    Friend WithEvents ListePanneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Liste_PanneTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Liste_PanneTableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Friend WithEvents PersonnelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonnelTableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ArticleInterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Article_InterventionTableAdapter As GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Article_InterventionTableAdapter
    Friend WithEvents DataSet_Stock As GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeArticlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_MTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DT_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UT_MTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UT_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTR_MTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTR_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TBF_MTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TBF_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DureeTextBox1 As System.Windows.Forms.TextBox
End Class
