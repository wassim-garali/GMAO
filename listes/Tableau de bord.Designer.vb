<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tableau_de_bord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tableau_de_bord))
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VUE_TOP10BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMAODataSet_VUE = New GMAO_Wassim_Skander.GMAODataSet_VUE()
        Me.VUE_TTR_MACHINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VUE_TTR_ALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.ArticlesTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter()
        Me.InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter()
        Me.Machine_Interv_PrevTableAdapter = New GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Machine_Interv_PrevTableAdapter()
        Me.VUE_TOP10TableAdapter = New GMAO_Wassim_Skander.GMAODataSet_VUETableAdapters.VUE_TOP10TableAdapter()
        Me.VUE_TTR_MACHINETableAdapter = New GMAO_Wassim_Skander.GMAODataSet_VUETableAdapters.VUE_TTR_MACHINETableAdapter()
        Me.VUE_TTR_ALLTableAdapter = New GMAO_Wassim_Skander.GMAODataSet_VUETableAdapters.VUE_TTR_ALLTableAdapter()
        CType(Me.VUE_TOP10BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMAODataSet_VUE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VUE_TTR_MACHINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VUE_TTR_ALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VUE_TOP10BindingSource
        '
        Me.VUE_TOP10BindingSource.DataMember = "VUE_TOP10"
        Me.VUE_TOP10BindingSource.DataSource = Me.GMAODataSet_VUE
        '
        'GMAODataSet_VUE
        '
        Me.GMAODataSet_VUE.DataSetName = "GMAODataSet_VUE"
        Me.GMAODataSet_VUE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VUE_TTR_MACHINEBindingSource
        '
        Me.VUE_TTR_MACHINEBindingSource.DataMember = "VUE_TTR_MACHINE"
        Me.VUE_TTR_MACHINEBindingSource.DataSource = Me.GMAODataSet_VUE
        '
        'VUE_TTR_ALLBindingSource
        '
        Me.VUE_TTR_ALLBindingSource.DataMember = "VUE_TTR_ALL"
        Me.VUE_TTR_ALLBindingSource.DataSource = Me.GMAODataSet_VUE
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(992, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(237, 123)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "fin de stock"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(744, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(242, 123)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Corrective non travaillé"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(484, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 123)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Preventive non travailler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(245, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 123)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = " Préventive en retard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.SteelBlue
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1391, 1015)
        Me.SplitContainer1.SplitterDistance = 180
        Me.SplitContainer1.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(1277, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 85)
        Me.Button6.TabIndex = 1
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue
        Me.FlowLayoutPanel1.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1253, 180)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(236, 123)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = " Préventive à faire"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(300, 21)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1391, 831)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DateTimePicker2)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.ReportViewer1)
        Me.TabPage3.Controls.Add(Me.NumericUpDown2)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1383, 802)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Géneral"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dddd dd MMMM yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(548, 7)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(273, 27)
        Me.DateTimePicker2.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd dd MMMM yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(181, 7)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(278, 27)
        Me.DateTimePicker1.TabIndex = 23
        '
        'ReportViewer1
        '
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.VUE_TOP10BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GMAO_Wassim_Skander.Report_TOP10.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1384, 598)
        Me.ReportViewer1.TabIndex = 7
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(8, 6)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(85, 27)
        Me.NumericUpDown2.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer2)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1383, 802)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TTR"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource8.Name = "DataSet1"
        ReportDataSource8.Value = Me.VUE_TTR_MACHINEBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "GMAO_Wassim_Skander.Report_TTR_Machine.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1377, 796)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1383, 802)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "MTTR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.VUE_TTR_ALLBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "GMAO_Wassim_Skander.Report_TTR_ALL.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(1377, 796)
        Me.ReportViewer3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1383, 802)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "MDT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource10.Name = "DataSet1"
        ReportDataSource10.Value = Me.VUE_TTR_ALLBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "GMAO_Wassim_Skander.Report_DT_ALL.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(1377, 796)
        Me.ReportViewer4.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ReportViewer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1383, 802)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "MUT"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ReportViewer5
        '
        Me.ReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource11.Name = "DataSet1"
        ReportDataSource11.Value = Me.VUE_TTR_ALLBindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "GMAO_Wassim_Skander.Report_UT_ALL.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(1377, 796)
        Me.ReportViewer5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReportViewer6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1383, 802)
        Me.TabPage6.TabIndex = 7
        Me.TabPage6.Text = "MTBF"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ReportViewer6
        '
        Me.ReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource12.Name = "DataSet1"
        ReportDataSource12.Value = Me.VUE_TTR_ALLBindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "GMAO_Wassim_Skander.Report_TBF_ALL.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(1383, 802)
        Me.ReportViewer6.TabIndex = 0
        '
        'DataSet_Stock
        '
        Me.DataSet_Stock.DataSetName = "DataSet_Stock"
        Me.DataSet_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'InterventionTableAdapter
        '
        Me.InterventionTableAdapter.ClearBeforeFill = True
        '
        'Machine_Interv_PrevTableAdapter
        '
        Me.Machine_Interv_PrevTableAdapter.ClearBeforeFill = True
        '
        'VUE_TOP10TableAdapter
        '
        Me.VUE_TOP10TableAdapter.ClearBeforeFill = True
        '
        'VUE_TTR_MACHINETableAdapter
        '
        Me.VUE_TTR_MACHINETableAdapter.ClearBeforeFill = True
        '
        'VUE_TTR_ALLTableAdapter
        '
        Me.VUE_TTR_ALLTableAdapter.ClearBeforeFill = True
        '
        'Tableau_de_bord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1391, 1015)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Tableau_de_bord"
        CType(Me.VUE_TOP10BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMAODataSet_VUE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VUE_TTR_MACHINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VUE_TTR_ALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ArticlesTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.ArticlesTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents InterventionTableAdapter As GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter
    Friend WithEvents DataSet_Stock As GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Machine_Interv_PrevTableAdapter As GMAO_Wassim_Skander.DataSet_MachineTableAdapters.Machine_Interv_PrevTableAdapter
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VUE_TOP10BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMAODataSet_VUE As GMAO_Wassim_Skander.GMAODataSet_VUE
    Friend WithEvents VUE_TOP10TableAdapter As GMAO_Wassim_Skander.GMAODataSet_VUETableAdapters.VUE_TOP10TableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents VUE_TTR_MACHINETableAdapter As GMAO_Wassim_Skander.GMAODataSet_VUETableAdapters.VUE_TTR_MACHINETableAdapter
    Friend WithEvents VUE_TTR_MACHINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VUE_TTR_ALLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VUE_TTR_ALLTableAdapter As GMAO_Wassim_Skander.GMAODataSet_VUETableAdapters.VUE_TTR_ALLTableAdapter
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
