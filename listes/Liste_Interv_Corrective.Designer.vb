<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Interv_Corrective
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Interv_Corrective))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VUEInterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Intervention = New GMAO_Wassim_Skander.DataSet_Intervention()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IntervCorrDataGridView = New System.Windows.Forms.DataGridView()
        Me.InterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter()
        Me.VUE_InterventionTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.VUE_InterventionTableAdapter()
        Me.NIntervDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateIntervDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeMachineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Technisien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DureeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateArretDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRealisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidationTechnisienDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ValidationResponsableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VUEInterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IntervCorrDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(62, 178)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1145, 3)
        Me.Panel2.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(62, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1145, 3)
        Me.Panel1.TabIndex = 49
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(589, 154)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(344, 3)
        Me.Panel3.TabIndex = 48
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DataSource = Me.VUEInterventionBindingSource
        Me.ComboBox1.DisplayMember = "Code_Machine"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(224, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 41)
        Me.ComboBox1.TabIndex = 47
        Me.ComboBox1.ValueMember = "Code_Machine"
        '
        'VUEInterventionBindingSource
        '
        Me.VUEInterventionBindingSource.DataMember = "VUE_Intervention"
        Me.VUEInterventionBindingSource.DataSource = Me.DataSet_Intervention
        '
        'DataSet_Intervention
        '
        Me.DataSet_Intervention.DataSetName = "DataSet_Intervention"
        Me.DataSet_Intervention.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(589, 104)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 44)
        Me.TextBox1.TabIndex = 46
        Me.TextBox1.Text = "Recherche"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.IntervCorrDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1254, 536)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des interventions"
        '
        'IntervCorrDataGridView
        '
        Me.IntervCorrDataGridView.AllowDrop = True
        Me.IntervCorrDataGridView.AllowUserToAddRows = False
        Me.IntervCorrDataGridView.AllowUserToDeleteRows = False
        Me.IntervCorrDataGridView.AllowUserToOrderColumns = True
        Me.IntervCorrDataGridView.AutoGenerateColumns = False
        Me.IntervCorrDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.IntervCorrDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IntervCorrDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IntervCorrDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.IntervCorrDataGridView.ColumnHeadersHeight = 30
        Me.IntervCorrDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIntervDataGridViewTextBoxColumn, Me.DateIntervDataGridViewTextBoxColumn, Me.CodeMachineDataGridViewTextBoxColumn, Me.Responsable, Me.Technisien, Me.DureeDataGridViewTextBoxColumn, Me.DateArretDataGridViewTextBoxColumn, Me.DateRealisationDataGridViewTextBoxColumn, Me.ValidationTechnisienDataGridViewCheckBoxColumn, Me.ValidationResponsableDataGridViewCheckBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.IntervCorrDataGridView.DataSource = Me.InterventionBindingSource
        Me.IntervCorrDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntervCorrDataGridView.EnableHeadersVisualStyles = False
        Me.IntervCorrDataGridView.Location = New System.Drawing.Point(3, 29)
        Me.IntervCorrDataGridView.MultiSelect = False
        Me.IntervCorrDataGridView.Name = "IntervCorrDataGridView"
        Me.IntervCorrDataGridView.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.IntervCorrDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.IntervCorrDataGridView.RowTemplate.Height = 24
        Me.IntervCorrDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IntervCorrDataGridView.Size = New System.Drawing.Size(1248, 504)
        Me.IntervCorrDataGridView.TabIndex = 43
        '
        'InterventionBindingSource
        '
        Me.InterventionBindingSource.DataMember = "Intervention"
        Me.InterventionBindingSource.DataSource = Me.DataSet_Intervention
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(873, 12)
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
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(468, 12)
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
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(62, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(334, 48)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'InterventionTableAdapter
        '
        Me.InterventionTableAdapter.ClearBeforeFill = True
        '
        'VUE_InterventionTableAdapter
        '
        Me.VUE_InterventionTableAdapter.ClearBeforeFill = True
        '
        'NIntervDataGridViewTextBoxColumn
        '
        Me.NIntervDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NIntervDataGridViewTextBoxColumn.DataPropertyName = "N_Interv"
        Me.NIntervDataGridViewTextBoxColumn.HeaderText = "N° Interv"
        Me.NIntervDataGridViewTextBoxColumn.Name = "NIntervDataGridViewTextBoxColumn"
        Me.NIntervDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateIntervDataGridViewTextBoxColumn
        '
        Me.DateIntervDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateIntervDataGridViewTextBoxColumn.DataPropertyName = "Date_Interv"
        Me.DateIntervDataGridViewTextBoxColumn.HeaderText = "D. Interv"
        Me.DateIntervDataGridViewTextBoxColumn.Name = "DateIntervDataGridViewTextBoxColumn"
        Me.DateIntervDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateIntervDataGridViewTextBoxColumn.Width = 118
        '
        'CodeMachineDataGridViewTextBoxColumn
        '
        Me.CodeMachineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodeMachineDataGridViewTextBoxColumn.DataPropertyName = "Code_Machine"
        Me.CodeMachineDataGridViewTextBoxColumn.HeaderText = " Machine"
        Me.CodeMachineDataGridViewTextBoxColumn.Name = "CodeMachineDataGridViewTextBoxColumn"
        Me.CodeMachineDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeMachineDataGridViewTextBoxColumn.Width = 180
        '
        'Responsable
        '
        Me.Responsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Responsable.DataPropertyName = "Responsable"
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.Name = "Responsable"
        Me.Responsable.ReadOnly = True
        Me.Responsable.Width = 150
        '
        'Technisien
        '
        Me.Technisien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Technisien.DataPropertyName = "Technisien"
        Me.Technisien.HeaderText = "Technicien"
        Me.Technisien.Name = "Technisien"
        Me.Technisien.ReadOnly = True
        Me.Technisien.Width = 132
        '
        'DureeDataGridViewTextBoxColumn
        '
        Me.DureeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DureeDataGridViewTextBoxColumn.DataPropertyName = "Duree"
        Me.DureeDataGridViewTextBoxColumn.HeaderText = "Durée"
        Me.DureeDataGridViewTextBoxColumn.Name = "DureeDataGridViewTextBoxColumn"
        Me.DureeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DureeDataGridViewTextBoxColumn.Width = 93
        '
        'DateArretDataGridViewTextBoxColumn
        '
        Me.DateArretDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateArretDataGridViewTextBoxColumn.DataPropertyName = "Date_Arret"
        Me.DateArretDataGridViewTextBoxColumn.HeaderText = "D. Arrêt"
        Me.DateArretDataGridViewTextBoxColumn.Name = "DateArretDataGridViewTextBoxColumn"
        Me.DateArretDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateArretDataGridViewTextBoxColumn.Width = 111
        '
        'DateRealisationDataGridViewTextBoxColumn
        '
        Me.DateRealisationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateRealisationDataGridViewTextBoxColumn.DataPropertyName = "Date_Realisation"
        Me.DateRealisationDataGridViewTextBoxColumn.HeaderText = "D. R.marche"
        Me.DateRealisationDataGridViewTextBoxColumn.Name = "DateRealisationDataGridViewTextBoxColumn"
        Me.DateRealisationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateRealisationDataGridViewTextBoxColumn.Width = 150
        '
        'ValidationTechnisienDataGridViewCheckBoxColumn
        '
        Me.ValidationTechnisienDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ValidationTechnisienDataGridViewCheckBoxColumn.DataPropertyName = "Validation_Technisien"
        Me.ValidationTechnisienDataGridViewCheckBoxColumn.HeaderText = "V. Tech"
        Me.ValidationTechnisienDataGridViewCheckBoxColumn.Name = "ValidationTechnisienDataGridViewCheckBoxColumn"
        Me.ValidationTechnisienDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ValidationTechnisienDataGridViewCheckBoxColumn.Width = 86
        '
        'ValidationResponsableDataGridViewCheckBoxColumn
        '
        Me.ValidationResponsableDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ValidationResponsableDataGridViewCheckBoxColumn.DataPropertyName = "Validation_Responsable"
        Me.ValidationResponsableDataGridViewCheckBoxColumn.HeaderText = "V. Resp"
        Me.ValidationResponsableDataGridViewCheckBoxColumn.Name = "ValidationResponsableDataGridViewCheckBoxColumn"
        Me.ValidationResponsableDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ValidationResponsableDataGridViewCheckBoxColumn.Width = 86
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Width = 125
        '
        'Liste_Interv_Corrective
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 754)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Liste_Interv_Corrective"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste_Interv"
        Me.TopMost = True
        CType(Me.VUEInterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.IntervCorrDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IntervCorrDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Intervention As Global.GMAO_Wassim_Skander.DataSet_Intervention
    Friend WithEvents InterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterventionTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.InterventionTableAdapter
    Friend WithEvents VUEInterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VUE_InterventionTableAdapter As GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.VUE_InterventionTableAdapter
    Friend WithEvents NIntervDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIntervDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeMachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Responsable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Technisien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateArretDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRealisationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationTechnisienDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ValidationResponsableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
