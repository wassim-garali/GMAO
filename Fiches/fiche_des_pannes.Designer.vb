<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fiche_des_pannes
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
        Dim Code_PanneLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fiche_des_pannes))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet_Intervention = New GMAO_Wassim_Skander.DataSet_Intervention()
        Me.Liste_PanneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Liste_PanneTableAdapter = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Liste_PanneTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.TableAdapterManager()
        Me.Code_PanneTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Code_PanneLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Liste_PanneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Code_PanneLabel
        '
        Code_PanneLabel.AutoSize = True
        Code_PanneLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_PanneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Code_PanneLabel.Location = New System.Drawing.Point(41, 103)
        Code_PanneLabel.Name = "Code_PanneLabel"
        Code_PanneLabel.Size = New System.Drawing.Size(123, 26)
        Code_PanneLabel.TabIndex = 39
        Code_PanneLabel.Text = "Code Panne"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DesignationLabel.Location = New System.Drawing.Point(41, 170)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(126, 26)
        DesignationLabel.TabIndex = 40
        DesignationLabel.Text = "Designation"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 5)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 5)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(480, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 344)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 344)
        Me.Panel4.TabIndex = 6
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
        Me.Button1.Location = New System.Drawing.Point(108, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 43)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataSet_Intervention
        '
        Me.DataSet_Intervention.DataSetName = "DataSet_Intervention"
        Me.DataSet_Intervention.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Liste_PanneBindingSource
        '
        Me.Liste_PanneBindingSource.DataMember = "Liste_Panne"
        Me.Liste_PanneBindingSource.DataSource = Me.DataSet_Intervention
        '
        'Liste_PanneTableAdapter
        '
        Me.Liste_PanneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Article_InterventionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InterventionTableAdapter = Nothing
        Me.TableAdapterManager.Ligne_Interv_PrevTableAdapter = Nothing
        Me.TableAdapterManager.Liste_InterventionTableAdapter = Nothing
        Me.TableAdapterManager.Liste_PanneTableAdapter = Me.Liste_PanneTableAdapter
        Me.TableAdapterManager.ObservationsTableAdapter = Nothing
        Me.TableAdapterManager.RapportTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Code_PanneTextBox
        '
        Me.Code_PanneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Liste_PanneBindingSource, "Code_Panne", True))
        Me.Code_PanneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_PanneTextBox.Location = New System.Drawing.Point(210, 103)
        Me.Code_PanneTextBox.Name = "Code_PanneTextBox"
        Me.Code_PanneTextBox.Size = New System.Drawing.Size(187, 27)
        Me.Code_PanneTextBox.TabIndex = 40
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Liste_PanneBindingSource, "Designation", True))
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextBox.Location = New System.Drawing.Point(210, 170)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(187, 27)
        Me.DesignationTextBox.TabIndex = 41
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(410, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 38
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fiche_des_pannes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(485, 354)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Code_PanneLabel)
        Me.Controls.Add(Me.Code_PanneTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "fiche_des_pannes"
        Me.Text = "fiche_des_pannes"
        CType(Me.DataSet_Intervention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Liste_PanneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet_Intervention As GMAO_Wassim_Skander.DataSet_Intervention
    Friend WithEvents Liste_PanneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Liste_PanneTableAdapter As GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.Liste_PanneTableAdapter
    Friend WithEvents TableAdapterManager As GMAO_Wassim_Skander.DataSet_InterventionTableAdapters.TableAdapterManager
    Friend WithEvents Code_PanneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
End Class
