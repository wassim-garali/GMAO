<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Intervention_Ligne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Intervention_Ligne))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PersonnelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet_Intervention = New Global.GMAO_Wassim_Skander.DataSet_Intervention()
        Me.LigneIntervPrevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ligne_Interv_PrevTableAdapter = New Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Ligne_Interv_PrevTableAdapter()
        Me.NinterventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeMachineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeInterventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DureeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidationDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LigneIntervPrevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(21, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1433, 3)
        Me.Panel2.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(21, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1433, 3)
        Me.Panel1.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(692, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(344, 3)
        Me.Panel3.TabIndex = 39
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Matricule", "Nom", "Prenom", "Specialite", "Qualification"})
        Me.ComboBox1.Location = New System.Drawing.Point(327, 111)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 41)
        Me.ComboBox1.TabIndex = 37
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(692, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 44)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "Recherche"
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
        Me.Button3.Location = New System.Drawing.Point(1120, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(334, 48)
        Me.Button3.TabIndex = 35
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
        Me.Button2.Location = New System.Drawing.Point(571, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(334, 48)
        Me.Button2.TabIndex = 34
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
        Me.Button1.Location = New System.Drawing.Point(21, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(334, 48)
        Me.Button1.TabIndex = 33
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1516, 496)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste lignes interventions"
        '
        'PersonnelDataGridView
        '
        Me.PersonnelDataGridView.AllowDrop = True
        Me.PersonnelDataGridView.AllowUserToOrderColumns = True
        Me.PersonnelDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonnelDataGridView.AutoGenerateColumns = False
        Me.PersonnelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PersonnelDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.PersonnelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonnelDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.PersonnelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PersonnelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.PersonnelDataGridView.ColumnHeadersHeight = 30
        Me.PersonnelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NinterventionDataGridViewTextBoxColumn, Me.CodeMachineDataGridViewTextBoxColumn, Me.CodeInterventionDataGridViewTextBoxColumn, Me.DureeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.InterventionDataGridViewTextBoxColumn, Me.ObservationDataGridViewTextBoxColumn, Me.ValidationDataGridViewCheckBoxColumn})
        Me.PersonnelDataGridView.DataSource = Me.LigneIntervPrevBindingSource
        Me.PersonnelDataGridView.EnableHeadersVisualStyles = False
        Me.PersonnelDataGridView.Location = New System.Drawing.Point(18, 48)
        Me.PersonnelDataGridView.Name = "PersonnelDataGridView"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.PersonnelDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.PersonnelDataGridView.RowTemplate.Height = 24
        Me.PersonnelDataGridView.Size = New System.Drawing.Size(1471, 314)
        Me.PersonnelDataGridView.TabIndex = 42
        '
        'DataSet_Intervention
        '
        Me.DataSet_Intervention.DataSetName = "DataSet_Intervention"
        Me.DataSet_Intervention.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LigneIntervPrevBindingSource
        '
        Me.LigneIntervPrevBindingSource.DataMember = "Ligne_Interv_Prev"
        Me.LigneIntervPrevBindingSource.DataSource = Me.DataSet_Intervention
        '
        'Ligne_Interv_PrevTableAdapter
        '
        Me.Ligne_Interv_PrevTableAdapter.ClearBeforeFill = True
        '
        'NinterventionDataGridViewTextBoxColumn
        '
        Me.NinterventionDataGridViewTextBoxColumn.DataPropertyName = "N_intervention"
        Me.NinterventionDataGridViewTextBoxColumn.HeaderText = "N°intervention"
        Me.NinterventionDataGridViewTextBoxColumn.Name = "NinterventionDataGridViewTextBoxColumn"
        '
        'CodeMachineDataGridViewTextBoxColumn
        '
        Me.CodeMachineDataGridViewTextBoxColumn.DataPropertyName = "Code_Machine"
        Me.CodeMachineDataGridViewTextBoxColumn.HeaderText = "Code Machine"
        Me.CodeMachineDataGridViewTextBoxColumn.Name = "CodeMachineDataGridViewTextBoxColumn"
        '
        'CodeInterventionDataGridViewTextBoxColumn
        '
        Me.CodeInterventionDataGridViewTextBoxColumn.DataPropertyName = "Code_Intervention"
        Me.CodeInterventionDataGridViewTextBoxColumn.HeaderText = "Code Interv"
        Me.CodeInterventionDataGridViewTextBoxColumn.Name = "CodeInterventionDataGridViewTextBoxColumn"
        '
        'DureeDataGridViewTextBoxColumn
        '
        Me.DureeDataGridViewTextBoxColumn.DataPropertyName = "Duree"
        Me.DureeDataGridViewTextBoxColumn.HeaderText = "Durée"
        Me.DureeDataGridViewTextBoxColumn.Name = "DureeDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'InterventionDataGridViewTextBoxColumn
        '
        Me.InterventionDataGridViewTextBoxColumn.DataPropertyName = "Intervention"
        Me.InterventionDataGridViewTextBoxColumn.HeaderText = "Intervention"
        Me.InterventionDataGridViewTextBoxColumn.Name = "InterventionDataGridViewTextBoxColumn"
        '
        'ObservationDataGridViewTextBoxColumn
        '
        Me.ObservationDataGridViewTextBoxColumn.DataPropertyName = "Observation"
        Me.ObservationDataGridViewTextBoxColumn.HeaderText = "Observation"
        Me.ObservationDataGridViewTextBoxColumn.Name = "ObservationDataGridViewTextBoxColumn"
        '
        'ValidationDataGridViewCheckBoxColumn
        '
        Me.ValidationDataGridViewCheckBoxColumn.DataPropertyName = "Validation"
        Me.ValidationDataGridViewCheckBoxColumn.HeaderText = "Validation"
        Me.ValidationDataGridViewCheckBoxColumn.Name = "ValidationDataGridViewCheckBoxColumn"
        '
        'Liste_Intervention_Ligne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1558, 709)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Liste_Intervention_Ligne"
        Me.Text = "Liste_Intervention_Ligne"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PersonnelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LigneIntervPrevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PersonnelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Intervention As Global.GMAO_Wassim_Skander.DataSet_Intervention
    Friend WithEvents LigneIntervPrevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ligne_Interv_PrevTableAdapter As Global.GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Ligne_Interv_PrevTableAdapter
    Friend WithEvents NinterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeMachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeInterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterventionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
