<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion
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
        Dim NomLabel As System.Windows.Forms.Label
        Dim PrenomLabel As System.Windows.Forms.Label
        Dim SpecialiteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(connexion))
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMAODataSet = New GMAO_Wassim_Skander.GMAODataSet()
        Me.PrenomTextBox = New System.Windows.Forms.TextBox()
        Me.Mot_de_PasseTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SpecialiteTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PersonnelTableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager()
        NomLabel = New System.Windows.Forms.Label()
        PrenomLabel = New System.Windows.Forms.Label()
        SpecialiteLabel = New System.Windows.Forms.Label()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomLabel.Location = New System.Drawing.Point(605, 235)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(62, 25)
        NomLabel.TabIndex = 3
        NomLabel.Text = "Nom"
        '
        'PrenomLabel
        '
        PrenomLabel.AutoSize = True
        PrenomLabel.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrenomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PrenomLabel.Location = New System.Drawing.Point(682, 235)
        PrenomLabel.Name = "PrenomLabel"
        PrenomLabel.Size = New System.Drawing.Size(92, 25)
        PrenomLabel.TabIndex = 5
        PrenomLabel.Text = "Prénom"
        '
        'SpecialiteLabel
        '
        SpecialiteLabel.AutoSize = True
        SpecialiteLabel.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpecialiteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SpecialiteLabel.Location = New System.Drawing.Point(605, 303)
        SpecialiteLabel.Name = "SpecialiteLabel"
        SpecialiteLabel.Size = New System.Drawing.Size(116, 25)
        SpecialiteLabel.TabIndex = 70
        SpecialiteLabel.Text = "Specialité"
        '
        'NomTextBox
        '
        Me.NomTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Nom", True))
        Me.NomTextBox.Enabled = False
        Me.NomTextBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomTextBox.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.NomTextBox.Location = New System.Drawing.Point(829, 230)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(160, 30)
        Me.NomTextBox.TabIndex = 4
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
        'PrenomTextBox
        '
        Me.PrenomTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PrenomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrenomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Prenom", True))
        Me.PrenomTextBox.Enabled = False
        Me.PrenomTextBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrenomTextBox.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.PrenomTextBox.Location = New System.Drawing.Point(1005, 230)
        Me.PrenomTextBox.Name = "PrenomTextBox"
        Me.PrenomTextBox.Size = New System.Drawing.Size(160, 30)
        Me.PrenomTextBox.TabIndex = 6
        '
        'Mot_de_PasseTextBox
        '
        Me.Mot_de_PasseTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Mot_de_PasseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Mot_de_PasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Mot_de_Passe", True))
        Me.Mot_de_PasseTextBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mot_de_PasseTextBox.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Mot_de_PasseTextBox.Location = New System.Drawing.Point(827, 380)
        Me.Mot_de_PasseTextBox.Name = "Mot_de_PasseTextBox"
        Me.Mot_de_PasseTextBox.Size = New System.Drawing.Size(160, 24)
        Me.Mot_de_PasseTextBox.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.Location = New System.Drawing.Point(827, 380)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(160, 24)
        Me.TextBox1.TabIndex = 9
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
        Me.Button1.Location = New System.Drawing.Point(900, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 52)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Se Connecter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SpecialiteTextBox
        '
        Me.SpecialiteTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SpecialiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpecialiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonnelBindingSource, "Specialite", True))
        Me.SpecialiteTextBox.Enabled = False
        Me.SpecialiteTextBox.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialiteTextBox.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.SpecialiteTextBox.Location = New System.Drawing.Point(829, 303)
        Me.SpecialiteTextBox.Name = "SpecialiteTextBox"
        Me.SpecialiteTextBox.Size = New System.Drawing.Size(160, 30)
        Me.SpecialiteTextBox.TabIndex = 71
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(1111, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 72
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(605, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Matricule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(605, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 25)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Mot de passe"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(827, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 1)
        Me.Panel2.TabIndex = 76
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(1005, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(162, 1)
        Me.Panel3.TabIndex = 77
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(827, 346)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(162, 1)
        Me.Panel4.TabIndex = 78
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(825, 403)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(162, 1)
        Me.Panel5.TabIndex = 79
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(332, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MatriculeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MatriculeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculeTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MatriculeTextBox.Location = New System.Drawing.Point(829, 168)
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(160, 27)
        Me.MatriculeTextBox.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(829, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 1)
        Me.Panel1.TabIndex = 75
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(326, 531)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 36)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Connexion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(342, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(346, 24)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "S'il vous plait vos donnés correctement !"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 47)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Bienvenue"
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
        'connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1173, 531)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MatriculeTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(SpecialiteLabel)
        Me.Controls.Add(Me.SpecialiteTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mot_de_PasseTextBox)
        Me.Controls.Add(PrenomLabel)
        Me.Controls.Add(Me.PrenomTextBox)
        Me.Controls.Add(NomLabel)
        Me.Controls.Add(Me.NomTextBox)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matricule"
        Me.TopMost = True
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GMAODataSet As Global.GMAO_Wassim_Skander.GMAODataSet
    Friend WithEvents PersonnelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonnelTableAdapter As GMAODataSetTableAdapters.PersonnelTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mot_de_PasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SpecialiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
