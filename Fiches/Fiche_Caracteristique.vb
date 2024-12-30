Public Class Fiche_Caracteristique

    Private Sub CaracteristiquesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.CaracteristiquesBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DataSet_Stock)

    End Sub

    Private Sub Fiche_Caracteristique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet_Stock.Caracteristiques'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.CaracteristiquesTableAdapter.Fill(Me.DataSet_Stock.Caracteristiques)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Enregistrer les modifications?", vbYesNo) = vbNo Then Exit Sub

        Me.CaracteristiquesBindingSource.EndEdit()
        Me.CaracteristiquesTableAdapter.Update(Me.DataSet_Stock.Caracteristiques)
        MsgBox("OK")
        settings.CaracteristiquesTableAdapter.Fill(settings.DataSet_Stock.Caracteristiques)
        settings.DataGridView1.Update()
        Me.Close()
        settings.ajouter2.Visible = False
        settings.supprimer2.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        settings.ajouter2.Visible = False
        settings.supprimer2.Visible = False
    End Sub
End Class