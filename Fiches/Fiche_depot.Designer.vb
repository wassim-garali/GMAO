﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche_depot
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
        Dim Code_DepotLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche_depot))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataSet_Stock = New GMAO_Wassim_Skander.DataSet_Stock()
        Me.DEPOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPOTTableAdapter = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.DEPOTTableAdapter()
        Me.TableAdapterManager = New GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager()
        Me.Code_DepotTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Code_DepotLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Code_DepotLabel
        '
        Code_DepotLabel.AutoSize = True
        Code_DepotLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_DepotLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Code_DepotLabel.Location = New System.Drawing.Point(49, 88)
        Code_DepotLabel.Name = "Code_DepotLabel"
        Code_DepotLabel.Size = New System.Drawing.Size(128, 26)
        Code_DepotLabel.TabIndex = 45
        Code_DepotLabel.Text = "Code Depot:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DesignationLabel.Location = New System.Drawing.Point(49, 155)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(131, 26)
        DesignationLabel.TabIndex = 46
        DesignationLabel.Text = "Designation:"
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
        Me.Button1.Location = New System.Drawing.Point(188, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 43)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(538, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 334)
        Me.Panel2.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(468, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 41
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 334)
        Me.Panel1.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(533, 5)
        Me.Panel3.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 329)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(533, 5)
        Me.Panel4.TabIndex = 44
        '
        'DataSet_Stock
        '
        Me.DataSet_Stock.DataSetName = "DataSet_Stock"
        Me.DataSet_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEPOTBindingSource
        '
        Me.DEPOTBindingSource.DataMember = "DEPOT"
        Me.DEPOTBindingSource.DataSource = Me.DataSet_Stock
        '
        'DEPOTTableAdapter
        '
        Me.DEPOTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Articles_CaracteristiquesTableAdapter = Nothing
        Me.TableAdapterManager.Articles_FamilleTableAdapter = Nothing
        Me.TableAdapterManager.Articles_LotTableAdapter = Nothing
        Me.TableAdapterManager.ArticlesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bon_Entree_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_EntreeTableAdapter = Nothing
        Me.TableAdapterManager.Bon_Sortie_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_SortieTableAdapter = Nothing
        Me.TableAdapterManager.Bon_Transfert_LigneTableAdapter = Nothing
        Me.TableAdapterManager.Bon_TransfertTableAdapter = Nothing
        Me.TableAdapterManager.CaracteristiquesTableAdapter = Nothing
        Me.TableAdapterManager.DEPOTTableAdapter = Me.DEPOTTableAdapter
        Me.TableAdapterManager.Inventaire_LigneTableAdapter = Nothing
        Me.TableAdapterManager.InventaireTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Code_DepotTextBox
        '
        Me.Code_DepotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEPOTBindingSource, "Code_Depot", True))
        Me.Code_DepotTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_DepotTextBox.Location = New System.Drawing.Point(237, 88)
        Me.Code_DepotTextBox.Name = "Code_DepotTextBox"
        Me.Code_DepotTextBox.Size = New System.Drawing.Size(185, 27)
        Me.Code_DepotTextBox.TabIndex = 46
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEPOTBindingSource, "Designation", True))
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextBox.Location = New System.Drawing.Point(237, 155)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(185, 27)
        Me.DesignationTextBox.TabIndex = 47
        '
        'Fiche_depot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 334)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Code_DepotLabel)
        Me.Controls.Add(Me.Code_DepotTextBox)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Fiche_depot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche_depot"
        Me.TopMost = True
        CType(Me.DataSet_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DataSet_Stock As GMAO_Wassim_Skander.DataSet_Stock
    Friend WithEvents DEPOTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEPOTTableAdapter As GMAO_Wassim_Skander.DataSet_StockTableAdapters.DEPOTTableAdapter
    Friend WithEvents TableAdapterManager As GMAO_Wassim_Skander.DataSet_StockTableAdapters.TableAdapterManager
    Friend WithEvents Code_DepotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
End Class