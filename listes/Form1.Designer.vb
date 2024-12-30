<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel_dessous = New System.Windows.Forms.Panel()
        Me.restaure_button = New System.Windows.Forms.Button()
        Me.minimize_button = New System.Windows.Forms.Button()
        Me.maximize_button = New System.Windows.Forms.Button()
        Me.close_button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cacher_menu = New System.Windows.Forms.Timer(Me.components)
        Me.montrer_menu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_gauche = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.menu_button = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button_Tableaudebord = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button_Equipement = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Paneltravaux1 = New System.Windows.Forms.Panel()
        Me.Button_Travaux = New System.Windows.Forms.Button()
        Me.Button_Settings = New System.Windows.Forms.Button()
        Me.PanelTraveaux = New System.Windows.Forms.Panel()
        Me.Button_interv_corrective = New System.Windows.Forms.Button()
        Me.Button_interv_prev = New System.Windows.Forms.Button()
        Me.PanelPersonnel = New System.Windows.Forms.Panel()
        Me.button_Personnel = New System.Windows.Forms.Button()
        Me.Panelstock1 = New System.Windows.Forms.Panel()
        Me.Button_Stock = New System.Windows.Forms.Button()
        Me.Panelstock = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusMat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusNom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusspec = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel_contenir = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMAODataSet = New GMAO_Wassim_Skander.GMAODataSet()
        Me.Personnel1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonnelTableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager()
        Me.Personnel1TableAdapter = New GMAO_Wassim_Skander.GMAODataSetTableAdapters.Personnel1TableAdapter()
        Me.Panel_dessous.SuspendLayout()
        Me.Panel_gauche.SuspendLayout()
        CType(Me.menu_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneltravaux1.SuspendLayout()
        Me.PanelTraveaux.SuspendLayout()
        Me.PanelPersonnel.SuspendLayout()
        Me.Panelstock1.SuspendLayout()
        Me.Panelstock.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel_contenir.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Personnel1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_dessous
        '
        Me.Panel_dessous.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel_dessous.Controls.Add(Me.restaure_button)
        Me.Panel_dessous.Controls.Add(Me.minimize_button)
        Me.Panel_dessous.Controls.Add(Me.maximize_button)
        Me.Panel_dessous.Controls.Add(Me.close_button)
        Me.Panel_dessous.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_dessous.Location = New System.Drawing.Point(0, 0)
        Me.Panel_dessous.Name = "Panel_dessous"
        Me.Panel_dessous.Size = New System.Drawing.Size(1777, 40)
        Me.Panel_dessous.TabIndex = 0
        '
        'restaure_button
        '
        Me.restaure_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.restaure_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.restaure_button.FlatAppearance.BorderSize = 0
        Me.restaure_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.restaure_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.restaure_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.restaure_button.Image = CType(resources.GetObject("restaure_button.Image"), System.Drawing.Image)
        Me.restaure_button.Location = New System.Drawing.Point(1687, 0)
        Me.restaure_button.Name = "restaure_button"
        Me.restaure_button.Size = New System.Drawing.Size(45, 45)
        Me.restaure_button.TabIndex = 3
        Me.restaure_button.UseVisualStyleBackColor = True
        '
        'minimize_button
        '
        Me.minimize_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize_button.FlatAppearance.BorderSize = 0
        Me.minimize_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.minimize_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize_button.Image = CType(resources.GetObject("minimize_button.Image"), System.Drawing.Image)
        Me.minimize_button.Location = New System.Drawing.Point(1642, 0)
        Me.minimize_button.Name = "minimize_button"
        Me.minimize_button.Size = New System.Drawing.Size(40, 40)
        Me.minimize_button.TabIndex = 2
        Me.minimize_button.UseVisualStyleBackColor = True
        '
        'maximize_button
        '
        Me.maximize_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximize_button.FlatAppearance.BorderSize = 0
        Me.maximize_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.maximize_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maximize_button.Image = CType(resources.GetObject("maximize_button.Image"), System.Drawing.Image)
        Me.maximize_button.Location = New System.Drawing.Point(1687, 0)
        Me.maximize_button.Name = "maximize_button"
        Me.maximize_button.Size = New System.Drawing.Size(45, 40)
        Me.maximize_button.TabIndex = 1
        Me.maximize_button.UseVisualStyleBackColor = True
        '
        'close_button
        '
        Me.close_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.close_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_button.FlatAppearance.BorderSize = 0
        Me.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_button.Image = CType(resources.GetObject("close_button.Image"), System.Drawing.Image)
        Me.close_button.Location = New System.Drawing.Point(1732, 0)
        Me.close_button.Name = "close_button"
        Me.close_button.Size = New System.Drawing.Size(45, 40)
        Me.close_button.TabIndex = 0
        Me.close_button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 3
        '
        'cacher_menu
        '
        '
        'montrer_menu
        '
        '
        'Panel_gauche
        '
        Me.Panel_gauche.AutoScroll = True
        Me.Panel_gauche.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel_gauche.Controls.Add(Me.Panel11)
        Me.Panel_gauche.Controls.Add(Me.Panel10)
        Me.Panel_gauche.Controls.Add(Me.Panel8)
        Me.Panel_gauche.Controls.Add(Me.menu_button)
        Me.Panel_gauche.Controls.Add(Me.Button1)
        Me.Panel_gauche.Controls.Add(Me.Panel3)
        Me.Panel_gauche.Controls.Add(Me.Panel2)
        Me.Panel_gauche.Controls.Add(Me.Paneltravaux1)
        Me.Panel_gauche.Controls.Add(Me.Button_Settings)
        Me.Panel_gauche.Controls.Add(Me.PanelTraveaux)
        Me.Panel_gauche.Controls.Add(Me.PanelPersonnel)
        Me.Panel_gauche.Controls.Add(Me.Panelstock1)
        Me.Panel_gauche.Controls.Add(Me.Panelstock)
        Me.Panel_gauche.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_gauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_gauche.ForeColor = System.Drawing.Color.White
        Me.Panel_gauche.Location = New System.Drawing.Point(0, 40)
        Me.Panel_gauche.Name = "Panel_gauche"
        Me.Panel_gauche.Size = New System.Drawing.Size(368, 1062)
        Me.Panel_gauche.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(3, 804)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 50)
        Me.Panel11.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(3, 643)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 50)
        Me.Panel10.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(3, 477)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 50)
        Me.Panel8.TabIndex = 4
        '
        'menu_button
        '
        Me.menu_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu_button.Image = CType(resources.GetObject("menu_button.Image"), System.Drawing.Image)
        Me.menu_button.Location = New System.Drawing.Point(12, 6)
        Me.menu_button.Name = "menu_button"
        Me.menu_button.Size = New System.Drawing.Size(47, 48)
        Me.menu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.menu_button.TabIndex = 0
        Me.menu_button.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(7, 1006)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Button_Tableaudebord)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Button_Equipement)
        Me.Panel3.Location = New System.Drawing.Point(0, 163)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 223)
        Me.Panel3.TabIndex = 14
        '
        'Button_Tableaudebord
        '
        Me.Button_Tableaudebord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Tableaudebord.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Tableaudebord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button_Tableaudebord.FlatAppearance.BorderSize = 0
        Me.Button_Tableaudebord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button_Tableaudebord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button_Tableaudebord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Tableaudebord.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Tableaudebord.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Tableaudebord.Image = CType(resources.GetObject("Button_Tableaudebord.Image"), System.Drawing.Image)
        Me.Button_Tableaudebord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Tableaudebord.Location = New System.Drawing.Point(0, 0)
        Me.Button_Tableaudebord.Name = "Button_Tableaudebord"
        Me.Button_Tableaudebord.Size = New System.Drawing.Size(365, 64)
        Me.Button_Tableaudebord.TabIndex = 1
        Me.Button_Tableaudebord.Text = "Tableau de bord"
        Me.Button_Tableaudebord.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(3, 159)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 50)
        Me.Panel9.TabIndex = 4
        '
        'Button_Equipement
        '
        Me.Button_Equipement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Equipement.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button_Equipement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button_Equipement.FlatAppearance.BorderSize = 0
        Me.Button_Equipement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button_Equipement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button_Equipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Equipement.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Equipement.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Equipement.Image = CType(resources.GetObject("Button_Equipement.Image"), System.Drawing.Image)
        Me.Button_Equipement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Equipement.Location = New System.Drawing.Point(0, 159)
        Me.Button_Equipement.Name = "Button_Equipement"
        Me.Button_Equipement.Size = New System.Drawing.Size(365, 64)
        Me.Button_Equipement.TabIndex = 4
        Me.Button_Equipement.Text = "Equipement"
        Me.Button_Equipement.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(4, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 86)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(361, 86)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Paneltravaux1
        '
        Me.Paneltravaux1.Controls.Add(Me.Button_Travaux)
        Me.Paneltravaux1.Location = New System.Drawing.Point(4, 474)
        Me.Paneltravaux1.Name = "Paneltravaux1"
        Me.Paneltravaux1.Size = New System.Drawing.Size(361, 64)
        Me.Paneltravaux1.TabIndex = 13
        '
        'Button_Travaux
        '
        Me.Button_Travaux.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Travaux.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Travaux.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button_Travaux.FlatAppearance.BorderSize = 0
        Me.Button_Travaux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button_Travaux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button_Travaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Travaux.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Travaux.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Travaux.Image = CType(resources.GetObject("Button_Travaux.Image"), System.Drawing.Image)
        Me.Button_Travaux.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Travaux.Location = New System.Drawing.Point(0, 0)
        Me.Button_Travaux.Name = "Button_Travaux"
        Me.Button_Travaux.Size = New System.Drawing.Size(361, 64)
        Me.Button_Travaux.TabIndex = 12
        Me.Button_Travaux.Text = "Travaux"
        Me.Button_Travaux.UseVisualStyleBackColor = True
        '
        'Button_Settings
        '
        Me.Button_Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Settings.FlatAppearance.BorderSize = 0
        Me.Button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Settings.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Settings.Image = CType(resources.GetObject("Button_Settings.Image"), System.Drawing.Image)
        Me.Button_Settings.Location = New System.Drawing.Point(57, 1006)
        Me.Button_Settings.Name = "Button_Settings"
        Me.Button_Settings.Size = New System.Drawing.Size(44, 44)
        Me.Button_Settings.TabIndex = 3
        Me.Button_Settings.UseVisualStyleBackColor = True
        '
        'PanelTraveaux
        '
        Me.PanelTraveaux.Controls.Add(Me.Button_interv_corrective)
        Me.PanelTraveaux.Controls.Add(Me.Button_interv_prev)
        Me.PanelTraveaux.Location = New System.Drawing.Point(4, 544)
        Me.PanelTraveaux.Name = "PanelTraveaux"
        Me.PanelTraveaux.Size = New System.Drawing.Size(340, 90)
        Me.PanelTraveaux.TabIndex = 15
        '
        'Button_interv_corrective
        '
        Me.Button_interv_corrective.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_interv_corrective.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_interv_corrective.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button_interv_corrective.FlatAppearance.BorderSize = 0
        Me.Button_interv_corrective.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button_interv_corrective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.Button_interv_corrective.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_interv_corrective.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_interv_corrective.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_interv_corrective.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_interv_corrective.Location = New System.Drawing.Point(0, 45)
        Me.Button_interv_corrective.Name = "Button_interv_corrective"
        Me.Button_interv_corrective.Size = New System.Drawing.Size(340, 45)
        Me.Button_interv_corrective.TabIndex = 14
        Me.Button_interv_corrective.Text = " Intervention Corrective"
        Me.Button_interv_corrective.UseVisualStyleBackColor = True
        '
        'Button_interv_prev
        '
        Me.Button_interv_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_interv_prev.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_interv_prev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button_interv_prev.FlatAppearance.BorderSize = 0
        Me.Button_interv_prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button_interv_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.Button_interv_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_interv_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_interv_prev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_interv_prev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_interv_prev.Location = New System.Drawing.Point(0, 0)
        Me.Button_interv_prev.Name = "Button_interv_prev"
        Me.Button_interv_prev.Size = New System.Drawing.Size(340, 45)
        Me.Button_interv_prev.TabIndex = 13
        Me.Button_interv_prev.Text = " Intervention Préventive "
        Me.Button_interv_prev.UseVisualStyleBackColor = True
        '
        'PanelPersonnel
        '
        Me.PanelPersonnel.Controls.Add(Me.button_Personnel)
        Me.PanelPersonnel.Location = New System.Drawing.Point(3, 640)
        Me.PanelPersonnel.Name = "PanelPersonnel"
        Me.PanelPersonnel.Size = New System.Drawing.Size(365, 64)
        Me.PanelPersonnel.TabIndex = 10
        '
        'button_Personnel
        '
        Me.button_Personnel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Personnel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Personnel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.button_Personnel.FlatAppearance.BorderSize = 0
        Me.button_Personnel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.button_Personnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.button_Personnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Personnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Personnel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button_Personnel.Image = CType(resources.GetObject("button_Personnel.Image"), System.Drawing.Image)
        Me.button_Personnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Personnel.Location = New System.Drawing.Point(0, 0)
        Me.button_Personnel.Name = "button_Personnel"
        Me.button_Personnel.Size = New System.Drawing.Size(365, 64)
        Me.button_Personnel.TabIndex = 10
        Me.button_Personnel.Text = "Utilisateur"
        Me.button_Personnel.UseVisualStyleBackColor = True
        '
        'Panelstock1
        '
        Me.Panelstock1.Controls.Add(Me.Button_Stock)
        Me.Panelstock1.Location = New System.Drawing.Point(4, 801)
        Me.Panelstock1.Name = "Panelstock1"
        Me.Panelstock1.Size = New System.Drawing.Size(361, 64)
        Me.Panelstock1.TabIndex = 14
        '
        'Button_Stock
        '
        Me.Button_Stock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Stock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button_Stock.FlatAppearance.BorderSize = 0
        Me.Button_Stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button_Stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Stock.Image = CType(resources.GetObject("Button_Stock.Image"), System.Drawing.Image)
        Me.Button_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Stock.Location = New System.Drawing.Point(0, 0)
        Me.Button_Stock.Name = "Button_Stock"
        Me.Button_Stock.Size = New System.Drawing.Size(361, 64)
        Me.Button_Stock.TabIndex = 10
        Me.Button_Stock.Text = "  Stock"
        Me.Button_Stock.UseVisualStyleBackColor = True
        '
        'Panelstock
        '
        Me.Panelstock.Controls.Add(Me.Button2)
        Me.Panelstock.Location = New System.Drawing.Point(7, 871)
        Me.Panelstock.Name = "Panelstock"
        Me.Panelstock.Size = New System.Drawing.Size(355, 76)
        Me.Panelstock.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(355, 45)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Articles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusMat, Me.ToolStripStatusNom, Me.ToolStripStatusspec})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 990)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1409, 72)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusMat
        '
        Me.ToolStripStatusMat.Font = New System.Drawing.Font("Siemens Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ToolStripStatusMat.Name = "ToolStripStatusMat"
        Me.ToolStripStatusMat.Size = New System.Drawing.Size(161, 67)
        Me.ToolStripStatusMat.Text = "      -------             "
        '
        'ToolStripStatusNom
        '
        Me.ToolStripStatusNom.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.ToolStripStatusNom.Font = New System.Drawing.Font("Siemens Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusNom.Name = "ToolStripStatusNom"
        Me.ToolStripStatusNom.Size = New System.Drawing.Size(174, 67)
        Me.ToolStripStatusNom.Text = "     --------               "
        '
        'ToolStripStatusspec
        '
        Me.ToolStripStatusspec.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.ToolStripStatusspec.Font = New System.Drawing.Font("Siemens Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusspec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusspec.Name = "ToolStripStatusspec"
        Me.ToolStripStatusspec.Size = New System.Drawing.Size(415, 67)
        Me.ToolStripStatusspec.Text = "    -----                                                                     "
        '
        'Panel_contenir
        '
        Me.Panel_contenir.BackColor = System.Drawing.Color.SlateGray
        Me.Panel_contenir.Controls.Add(Me.Label2)
        Me.Panel_contenir.Controls.Add(Me.PictureBox5)
        Me.Panel_contenir.Controls.Add(Me.PictureBox4)
        Me.Panel_contenir.Controls.Add(Me.PictureBox2)
        Me.Panel_contenir.Controls.Add(Me.Label1)
        Me.Panel_contenir.Controls.Add(Me.StatusStrip1)
        Me.Panel_contenir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_contenir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_contenir.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel_contenir.Location = New System.Drawing.Point(368, 40)
        Me.Panel_contenir.Name = "Panel_contenir"
        Me.Panel_contenir.Size = New System.Drawing.Size(1409, 1062)
        Me.Panel_contenir.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1303, 1006)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "date"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1157, 992)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(130, 68)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1018, 992)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(133, 68)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(212, 152)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(980, 530)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 46.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(343, 738)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 83)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date Time"
        Me.Label1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
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
        'Personnel1BindingSource
        '
        Me.Personnel1BindingSource.DataMember = "Personnel1"
        Me.Personnel1BindingSource.DataSource = Me.GMAODataSet
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
        'Personnel1TableAdapter
        '
        Me.Personnel1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1777, 1102)
        Me.Controls.Add(Me.Panel_contenir)
        Me.Controls.Add(Me.Panel_gauche)
        Me.Controls.Add(Me.Panel_dessous)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pannel_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_dessous.ResumeLayout(False)
        Me.Panel_gauche.ResumeLayout(False)
        CType(Me.menu_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneltravaux1.ResumeLayout(False)
        Me.PanelTraveaux.ResumeLayout(False)
        Me.PanelPersonnel.ResumeLayout(False)
        Me.Panelstock1.ResumeLayout(False)
        Me.Panelstock.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel_contenir.ResumeLayout(False)
        Me.Panel_contenir.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMAODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Personnel1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_dessous As System.Windows.Forms.Panel
    Friend WithEvents close_button As System.Windows.Forms.Button
    Friend WithEvents minimize_button As System.Windows.Forms.Button
    Friend WithEvents maximize_button As System.Windows.Forms.Button
    Friend WithEvents restaure_button As System.Windows.Forms.Button
    Friend WithEvents cacher_menu As System.Windows.Forms.Timer
    Friend WithEvents montrer_menu As System.Windows.Forms.Timer
    Friend WithEvents Button_Stock As System.Windows.Forms.Button
    Friend WithEvents menu_button As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button_Tableaudebord As System.Windows.Forms.Button
    Friend WithEvents Button_Travaux As System.Windows.Forms.Button
    Friend WithEvents Button_Equipement As System.Windows.Forms.Button
    Friend WithEvents Panel_gauche As System.Windows.Forms.Panel
    Friend WithEvents Button_interv_prev As System.Windows.Forms.Button
    Friend WithEvents Button_interv_corrective As System.Windows.Forms.Button
    Friend WithEvents Panelstock As System.Windows.Forms.Panel
    Friend WithEvents PanelTraveaux As System.Windows.Forms.Panel
    Friend WithEvents Paneltravaux1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panelstock1 As System.Windows.Forms.Panel
    Friend WithEvents button_Personnel As System.Windows.Forms.Button
    Friend WithEvents PanelPersonnel As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GMAODataSet As Global.GMAO_Wassim_Skander.GMAODataSet
    Friend WithEvents Button_Settings As System.Windows.Forms.Button
    Friend WithEvents PersonnelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonnelTableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.PersonnelTableAdapter
    Friend WithEvents TableAdapterManager As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.TableAdapterManager
    Friend WithEvents Personnel1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Personnel1TableAdapter As Global.GMAO_Wassim_Skander.GMAODataSetTableAdapters.Personnel1TableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusMat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusNom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusspec As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel_contenir As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
