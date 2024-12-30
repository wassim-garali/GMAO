<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Personnel
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
        Dim MatriculeLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim PrenomLabel As System.Windows.Forms.Label
        Dim Mot_de_PasseLabel As System.Windows.Forms.Label
        Dim SpecialiteLabel As System.Windows.Forms.Label
        Dim QualificationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_Personnel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMAODataSet = New GMAO_Wassim_Skander.GMAODataSet()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PrenomTextBox = New System.Windows.Forms.TextBox()
        Me.Mot_de_PasseTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialiteComboBox = New System.Windows.Forms.ComboBox()
        Me.PersonnelTableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QualificationTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        MatriculeLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        PrenomLabel = New System.Windows.Forms.Label()
        Mot_de_PasseLabel = New System.Windows.Forms.Label()
        SpecialiteLabel = New System.Windows.Forms.Label()
        QualificationLabel = New System.Windows.Forms.Label()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculeLabel
        '
        MatriculeLabel.AutoSize = True
        MatriculeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        MatriculeLabel.Location = New System.Drawing.Point(543, 167)
        MatriculeLabel.Name = "MatriculeLabel"
        MatriculeLabel.Size = New System.Drawing.Size(120, 29)
        MatriculeLabel.TabIndex = 37
        MatriculeLabel.Text = "Matricule"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomLabel.Location = New System.Drawing.Point(80, 252)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(68, 29)
        NomLabel.TabIndex = 39
        NomLabel.Text = "Nom"
        '
        'PrenomLabel
        '
        PrenomLabel.AutoSize = True
        PrenomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrenomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PrenomLabel.Location = New System.Drawing.Point(543, 252)
        PrenomLabel.Name = "PrenomLabel"
        PrenomLabel.Size = New System.Drawing.Size(104, 29)
        PrenomLabel.TabIndex = 41
        PrenomLabel.Text = "Prénom"
        '
        'Mot_de_PasseLabel
        '
        Mot_de_PasseLabel.AutoSize = True
        Mot_de_PasseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mot_de_PasseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Mot_de_PasseLabel.Location = New System.Drawing.Point(543, 338)
        Mot_de_PasseLabel.Name = "Mot_de_PasseLabel"
        Mot_de_PasseLabel.Size = New System.Drawing.Size(172, 29)
        Mot_de_PasseLabel.TabIndex = 47
        Mot_de_PasseLabel.Text = "Mot de Passe"
        '
        'SpecialiteLabel
        '
        SpecialiteLabel.AutoSize = True
        SpecialiteLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpecialiteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SpecialiteLabel.Location = New System.Drawing.Point(79, 165)
        SpecialiteLabel.Name = "SpecialiteLabel"
        SpecialiteLabel.Size = New System.Drawing.Size(124, 32)
        SpecialiteLabel.TabIndex = 50
        SpecialiteLabel.Text = "Specialité"
        '
        'QualificationLabel
        '
        QualificationLabel.AutoSize = True
        QualificationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QualificationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        QualificationLabel.Location = New System.Drawing.Point(79, 335)
        QualificationLabel.Name = "QualificationLabel"
        QualificationLabel.Size = New System.Drawing.Size(77, 32)
        QualificationLabel.TabIndex = 52
        QualificationLabel.Text = "Email"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1078, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 538)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 538)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1073, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 533)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1073, 5)
        Me.Panel4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(338, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 44)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ajouter Personnel"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(803, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 50)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1007, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 36
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Matricule", True))
        Me.MatriculeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculeTextBox.Location = New System.Drawing.Point(836, 172)
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(174, 27)
        Me.MatriculeTextBox.TabIndex = 38
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
        'NomTextBox
        '
        Me.NomTextBox.BackColor = System.Drawing.Color.White
        Me.NomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Nom", True))
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NomTextBox.Location = New System.Drawing.Point(267, 252)
        Me.NomTextBox.Multiline = True
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(205, 29)
        Me.NomTextBox.TabIndex = 40
        '
        'PrenomTextBox
        '
        Me.PrenomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Prenom", True))
        Me.PrenomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrenomTextBox.Location = New System.Drawing.Point(836, 252)
        Me.PrenomTextBox.Name = "PrenomTextBox"
        Me.PrenomTextBox.Size = New System.Drawing.Size(174, 27)
        Me.PrenomTextBox.TabIndex = 42
        '
        'Mot_de_PasseTextBox
        '
        Me.Mot_de_PasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Mot_de_Passe", True))
        Me.Mot_de_PasseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mot_de_PasseTextBox.Location = New System.Drawing.Point(836, 338)
        Me.Mot_de_PasseTextBox.Name = "Mot_de_PasseTextBox"
        Me.Mot_de_PasseTextBox.Size = New System.Drawing.Size(205, 27)
        Me.Mot_de_PasseTextBox.TabIndex = 48
        '
        'SpecialiteComboBox
        '
        Me.SpecialiteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Specialite", True))
        Me.SpecialiteComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialiteComboBox.FormattingEnabled = True
        Me.SpecialiteComboBox.Items.AddRange(New Object() {"Responsable", "Technicien"})
        Me.SpecialiteComboBox.Location = New System.Drawing.Point(267, 171)
        Me.SpecialiteComboBox.Name = "SpecialiteComboBox"
        Me.SpecialiteComboBox.Size = New System.Drawing.Size(205, 28)
        Me.SpecialiteComboBox.TabIndex = 51
        '
        'PersonnelTableAdapter
        '
        Me.PersonnelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Personnel1TableAdapter = Nothing
        Me.TableAdapterManager.PersonnelTableAdapter = Me.PersonnelTableAdapter
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'QualificationTextBox
        '
        Me.QualificationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Qualification", True))
        Me.QualificationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QualificationTextBox.Location = New System.Drawing.Point(267, 338)
        Me.QualificationTextBox.Name = "QualificationTextBox"
        Me.QualificationTextBox.Size = New System.Drawing.Size(205, 27)
        Me.QualificationTextBox.TabIndex = 53
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(539, 436)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(245, 50)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "Actualiser"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Fiche_Personnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1083, 538)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(QualificationLabel)
        Me.Controls.Add(Me.QualificationTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(SpecialiteLabel)
        Me.Controls.Add(Me.SpecialiteComboBox)
        Me.Controls.Add(MatriculeLabel)
        Me.Controls.Add(Me.MatriculeTextBox)
        Me.Controls.Add(NomLabel)
        Me.Controls.Add(Me.NomTextBox)
        Me.Controls.Add(PrenomLabel)
        Me.Controls.Add(Me.PrenomTextBox)
        Me.Controls.Add(Mot_de_PasseLabel)
        Me.Controls.Add(Me.Mot_de_PasseTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Fiche_Personnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche_Personnel"
        Me.TopMost = True
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GMAODataSet As Global.GMAO_Wassim_Skander.GMAODataSet
    Friend WithEvents PersonnelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonnelTableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mot_de_PasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpecialiteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents QualificationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
