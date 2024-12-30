<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_Fournisseur
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
        Dim Code_FournisseurLabel As System.Windows.Forms.Label
        Dim Nom_FournisseurLabel As System.Windows.Forms.Label
        Dim Activite_FournisseurLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_Fournisseur))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Code_FournisseurTextBox = New System.Windows.Forms.TextBox()
        Me.FournisseurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Fournisseur = New GMAO_Wassim_Skander.DataSet_Fournisseur()
        Me.Nom_FournisseurTextBox = New System.Windows.Forms.TextBox()
        Me.Activite_FournisseurTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FournisseurTableAdapter = New GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.FournisseurTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Code_FournisseurLabel = New System.Windows.Forms.Label()
        Nom_FournisseurLabel = New System.Windows.Forms.Label()
        Activite_FournisseurLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.FournisseurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Fournisseur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Code_FournisseurLabel
        '
        Code_FournisseurLabel.AutoSize = True
        Code_FournisseurLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_FournisseurLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Code_FournisseurLabel.Location = New System.Drawing.Point(74, 191)
        Code_FournisseurLabel.Name = "Code_FournisseurLabel"
        Code_FournisseurLabel.Size = New System.Drawing.Size(225, 33)
        Code_FournisseurLabel.TabIndex = 27
        Code_FournisseurLabel.Text = "Code Fournisseur:"
        '
        'Nom_FournisseurLabel
        '
        Nom_FournisseurLabel.AutoSize = True
        Nom_FournisseurLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_FournisseurLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nom_FournisseurLabel.Location = New System.Drawing.Point(74, 262)
        Nom_FournisseurLabel.Name = "Nom_FournisseurLabel"
        Nom_FournisseurLabel.Size = New System.Drawing.Size(223, 33)
        Nom_FournisseurLabel.TabIndex = 29
        Nom_FournisseurLabel.Text = "Nom Fournisseur:"
        '
        'Activite_FournisseurLabel
        '
        Activite_FournisseurLabel.AutoSize = True
        Activite_FournisseurLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Activite_FournisseurLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Activite_FournisseurLabel.Location = New System.Drawing.Point(72, 335)
        Activite_FournisseurLabel.Name = "Activite_FournisseurLabel"
        Activite_FournisseurLabel.Size = New System.Drawing.Size(257, 33)
        Activite_FournisseurLabel.TabIndex = 31
        Activite_FournisseurLabel.Text = "Activite Fournisseur:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TelephoneLabel.Location = New System.Drawing.Point(592, 215)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(147, 33)
        TelephoneLabel.TabIndex = 33
        TelephoneLabel.Text = "Telephone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        EmailLabel.Location = New System.Drawing.Point(592, 287)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(85, 33)
        EmailLabel.TabIndex = 35
        EmailLabel.Text = "Email:"
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
        Me.Button1.Location = New System.Drawing.Point(775, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 43)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(330, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 44)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Ajouter Fournisseur"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1027, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 477)
        Me.Panel2.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 472)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1022, 5)
        Me.Panel4.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1022, 5)
        Me.Panel3.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 477)
        Me.Panel5.TabIndex = 24
        '
        'Code_FournisseurTextBox
        '
        Me.Code_FournisseurTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Code_FournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Code_FournisseurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FournisseurBindingSource, "Code_Fournisseur", True))
        Me.Code_FournisseurTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_FournisseurTextBox.Location = New System.Drawing.Point(374, 202)
        Me.Code_FournisseurTextBox.Multiline = True
        Me.Code_FournisseurTextBox.Name = "Code_FournisseurTextBox"
        Me.Code_FournisseurTextBox.Size = New System.Drawing.Size(184, 22)
        Me.Code_FournisseurTextBox.TabIndex = 28
        '
        'FournisseurBindingSource
        '
        Me.FournisseurBindingSource.DataMember = "Fournisseur"
        Me.FournisseurBindingSource.DataSource = Me.DataSet_Fournisseur
        '
        'DataSet_Fournisseur
        '
        Me.DataSet_Fournisseur.DataSetName = "DataSet_Fournisseur"
        Me.DataSet_Fournisseur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nom_FournisseurTextBox
        '
        Me.Nom_FournisseurTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Nom_FournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom_FournisseurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FournisseurBindingSource, "Nom_Fournisseur", True))
        Me.Nom_FournisseurTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_FournisseurTextBox.Location = New System.Drawing.Point(374, 273)
        Me.Nom_FournisseurTextBox.Multiline = True
        Me.Nom_FournisseurTextBox.Name = "Nom_FournisseurTextBox"
        Me.Nom_FournisseurTextBox.Size = New System.Drawing.Size(181, 22)
        Me.Nom_FournisseurTextBox.TabIndex = 30
        '
        'Activite_FournisseurTextBox
        '
        Me.Activite_FournisseurTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Activite_FournisseurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Activite_FournisseurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FournisseurBindingSource, "Activite_Fournisseur", True))
        Me.Activite_FournisseurTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Activite_FournisseurTextBox.Location = New System.Drawing.Point(374, 349)
        Me.Activite_FournisseurTextBox.Multiline = True
        Me.Activite_FournisseurTextBox.Name = "Activite_FournisseurTextBox"
        Me.Activite_FournisseurTextBox.Size = New System.Drawing.Size(181, 22)
        Me.Activite_FournisseurTextBox.TabIndex = 32
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TelephoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FournisseurBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(784, 226)
        Me.TelephoneTextBox.Multiline = True
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(184, 22)
        Me.TelephoneTextBox.TabIndex = 34
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FournisseurBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(784, 298)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(184, 22)
        Me.EmailTextBox.TabIndex = 36
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel9.Location = New System.Drawing.Point(374, 294)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(184, 3)
        Me.Panel9.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(374, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 3)
        Me.Panel1.TabIndex = 18
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(184, 3)
        Me.Panel6.TabIndex = 18
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel7.Location = New System.Drawing.Point(374, 367)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(184, 3)
        Me.Panel7.TabIndex = 18
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel8.Location = New System.Drawing.Point(784, 245)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(184, 3)
        Me.Panel8.TabIndex = 18
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel10.Location = New System.Drawing.Point(784, 319)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(184, 3)
        Me.Panel10.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(943, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 42
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FournisseurTableAdapter
        '
        Me.FournisseurTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bon_Commande_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_CommandeTableAdapter = Nothing
        Me.TableAdapterManager.Bon_Reseption_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_ReseptionTableAdapter = Nothing
        Me.TableAdapterManager.Demande_Achat_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Demande_AchatTableAdapter = Nothing
        Me.TableAdapterManager.FournisseurTableAdapter = Me.FournisseurTableAdapter
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Fiche_Fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 477)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Code_FournisseurLabel)
        Me.Controls.Add(Me.Code_FournisseurTextBox)
        Me.Controls.Add(Nom_FournisseurLabel)
        Me.Controls.Add(Me.Nom_FournisseurTextBox)
        Me.Controls.Add(Activite_FournisseurLabel)
        Me.Controls.Add(Me.Activite_FournisseurTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fiche_Fournisseur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche_Fournisseur"
        Me.TopMost = True
        CType(Me.FournisseurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Fournisseur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataSet_Fournisseur As Global.GMAO_Wassim_Skander.DataSet_Fournisseur
    Friend WithEvents FournisseurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FournisseurTableAdapter As Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.FournisseurTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.DataSet_FournisseurTableAdapters.TableAdapterManager
    Friend WithEvents Code_FournisseurTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_FournisseurTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Activite_FournisseurTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
