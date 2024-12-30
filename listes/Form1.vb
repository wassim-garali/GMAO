Imports System.Runtime.InteropServices
Public Class Form1

    '  Private Property GMAODataSet As GMAO_Wassim_Skander.GMAODataSet

    Private Sub form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'GMAODataSet.Personnel1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Personnel1TableAdapter.Fill(Me.GMAODataSet.Personnel1)

        'TODO: cette ligne de code charge les données dans la table 'GMAODataSet.Personnel'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PersonnelTableAdapter.Fill(Me.GMAODataSet.Personnel)
        Me.Enabled = False
        connexion.ShowDialog()
        Liste_Machine.button_add_prev.Visible = False
        PanelTraveaux.Visible = False
        Panelstock.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        '  PictureBox2.Visible = True
        '  Label1.Visible = True
        ' Panelfournisseur.Visible = False
    End Sub
    'create sub hide menu when we click on the button
    Sub HideMenu()
        If PanelTraveaux.Visible = True Then
            PanelTraveaux.Visible = False
        ElseIf Panelstock.Visible = True Then
            Panelstock.Visible = False
            ' ElseIf Panelfournisseur.Visible = True Then
            '  Panelfournisseur.Visible = False
        End If
    End Sub

    Private Sub close_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_button.Click
        Me.Close()
    End Sub

    Private Sub maximize_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximize_button.Click
        maximize_button.Visible = False
        restaure_button.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub minimize_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub restaure_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restaure_button.Click
        restaure_button.Visible = False
        maximize_button.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub cacher_menu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cacher_menu.Tick
        If Panel_gauche.Width <= 100 Then
            Me.cacher_menu.Enabled = False
        Else
            Me.Panel_gauche.Width = Panel_gauche.Width - 30

        End If
    End Sub

    Private Sub montrer_menu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles montrer_menu.Tick
        If Panel_gauche.Width >= 267 Then
            Me.montrer_menu.Enabled = False
        Else
            Me.Panel_gauche.Width = Panel_gauche.Width + 30


        End If
    End Sub

    Private Sub menu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_button.Click
        If Panel_gauche.Width >= 100 Then
            cacher_menu.Enabled = True
        End If

        If Panel_gauche.Width < 100 Then
            montrer_menu.Enabled = True
        End If
        Tableau_de_bord.Button6.Visible = True
    End Sub

    Private Sub ouvrir_panel(ByVal form_fils As Object)
        If Me.Panel_contenir.Controls.Count > 0 Then
            Me.Panel_contenir.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(form_fils, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(fh)
        Me.Panel_contenir.Tag = fh
        fh.Show()
      
    End Sub

    Private Sub Button_Tableaudebord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Tableaudebord.Click
        'ouvrir_panel(New Tableau_de_bord)
        Tableau_de_bord.TopLevel = False
        Tableau_de_bord.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Tableau_de_bord.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Tableau_de_bord)
        Me.Panel_contenir.Tag = Tableau_de_bord
        Tableau_de_bord.Show()
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub button_Personnel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Personnel.Click
        If Me.ToolStripStatusspec.Text = "Administrateur" Then
            'ouvrir_panel(New Liste_Personnel)
            Liste_Personnel.TopLevel = False
            Liste_Personnel.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Liste_Personnel.Dock = DockStyle.Fill
            Me.Panel_contenir.Controls.Add(Liste_Personnel)
            Me.Panel_contenir.Tag = Liste_Personnel
            Liste_Personnel.Show()
            PictureBox2.Visible = False
            Label1.Visible = False
        Else
            MsgBox(" Accés non disponible", vbCritical)
        End If
    End Sub

    Private Sub Button_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Stock.Click
        If Panelstock.Visible = False Then
            Panelstock.Visible = True
        Else : Panelstock.Visible = False
        End If
    End Sub

    Private Sub Button_Traveaux_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Travaux.Click
        If PanelTraveaux.Visible = False Then
            PanelTraveaux.Visible = True
        Else : PanelTraveaux.Visible = False
        End If
    End Sub

    Private Sub Button_Equipement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Equipement.Click
        'ouvrir_panel(New Liste_Machine)
        Liste_Machine.TopLevel = False
        Liste_Machine.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Liste_Machine.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Machine)
        Me.Panel_contenir.Tag = Liste_Machine
        Liste_Machine.TAB_BORD = False
        Liste_Machine.Show()
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_interv_prev.Click
        ' HideMenu()
        'ouvrir_panel(New Liste_Interv_Preventive)
        Liste_Interv_Preventive.TopLevel = False
        Liste_Interv_Preventive.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Liste_Interv_Preventive.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Interv_Preventive)
        Me.Panel_contenir.Tag = Liste_Interv_Preventive
        Liste_Interv_Preventive.TAB_BORD = False
        Liste_Interv_Preventive.Show()
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_interv_corrective.Click
        'HideMenu()
        'ouvrir_panel(New Liste_Interv_corrective)
        Liste_Interv_corrective.TopLevel = False
        Liste_Interv_corrective.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Liste_Interv_Corrective.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Interv_Corrective)
        Me.Panel_contenir.Tag = Liste_Interv_Corrective
        Liste_Interv_Corrective.TAB_BORD = False
        Liste_Interv_Corrective.Show()
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' HideMenu()
        'ouvrir_panel(New Liste_Article)
        Liste_Article.TopLevel = False
        Liste_Article.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Liste_Article.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Article)
        Me.Panel_contenir.Tag = Liste_Article
        Liste_Article.TAB_BORD = False
        Liste_Article.Show()
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' HideMenu()
        'ouvrir_panel(New Liste_Article_Bon_Entree)
        Liste_Article_Bon_Entree.TopLevel = False
        Liste_Article_Bon_Entree.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Article_Bon_Entree.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Article_Bon_Entree)
        Me.Panel_contenir.Tag = Liste_Article_Bon_Entree
        Liste_Article_Bon_Entree.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HideMenu()
        'ouvrir_panel(New Liste_Article_Bon_Sortie)
        Liste_Article_Bon_Sortie.TopLevel = False
        Liste_Article_Bon_Sortie.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Article_Bon_Sortie.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Article_Bon_Sortie)
        Me.Panel_contenir.Tag = Liste_Interv_Corrective
        Liste_Article_Bon_Sortie.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' HideMenu()
        'ouvrir_panel(New Liste_Article_Bon_Transfert)
        Liste_Article_Bon_Transfert.TopLevel = False
        Liste_Article_Bon_Transfert.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Article_Bon_Transfert.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Article_Bon_Transfert)
        Me.Panel_contenir.Tag = Liste_Article_Bon_Transfert
        Liste_Article_Bon_Transfert.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HideMenu()
        'ouvrir_panel(New Liste_Article_Inventaire)
        Liste_Article_Inventaire.TopLevel = False
        Liste_Article_Inventaire.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Article_Inventaire.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Article_Inventaire)
        Me.Panel_contenir.Tag = Liste_Article_Inventaire
        Liste_Article_Inventaire.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HideMenu()
        'ouvrir_panel(New Liste_fournisseur)
        Liste_fournisseur.TopLevel = False
        Liste_fournisseur.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_fournisseur.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_fournisseur)
        Me.Panel_contenir.Tag = Liste_fournisseur
        Liste_fournisseur.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HideMenu()
        'ouvrir_panel(New Liste_Fournisseur_DDe_Achat)
        Liste_Fournisseur_DDe_Achat.TopLevel = False
        Liste_Fournisseur_DDe_Achat.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Fournisseur_DDe_Achat.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Fournisseur_DDe_Achat)
        Me.Panel_contenir.Tag = Liste_Fournisseur_DDe_Achat
        Liste_Fournisseur_DDe_Achat.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HideMenu()
        'ouvrir_panel(New Liste_Fournisseur_Bon_Cde)
        Liste_Fournisseur_Bon_Cde.TopLevel = False
        Liste_Fournisseur_Bon_Cde.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Fournisseur_Bon_Cde.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Fournisseur_Bon_Cde)
        Me.Panel_contenir.Tag = Liste_Fournisseur_Bon_Cde
        Liste_Fournisseur_Bon_Cde.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HideMenu()
        'ouvrir_panel(New Liste_Fournisseur_Bon_Resp)
        Liste_Fournisseur_Bon_Resp.TopLevel = False
        Liste_Fournisseur_Bon_Resp.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Liste_Fournisseur_Bon_Resp.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(Liste_Fournisseur_Bon_Resp)
        Me.Panel_contenir.Tag = Liste_Fournisseur_Bon_Resp
        Liste_Fournisseur_Bon_Resp.Show()
    End Sub

    Private Sub Panel_gauche_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel_gauche.SizeChanged
        If Panel_gauche.Width < 200 Then
            Button_Equipement.Text = ""
            Button_Tableaudebord.Text = ""
            Button_Travaux.Text = ""
            button_Personnel.Text = ""
            Button_Stock.Text = ""
            '  Button_fourn.Text = ""
        Else
            Button_Equipement.Text = "Equipement"
            Button_Tableaudebord.Text = "Tableau de bord"
            Button_Travaux.Text = "Travaux"
            button_Personnel.Text = "Utilisateur"
            Button_Stock.Text = "Stock"
            '   Button_fourn.Text = "Fournisseur"
        End If
    End Sub

    Public Function SEND_EMAIL(ByVal MAIL_EXP As String, ByVal MAIL_PASS As String, ByVal MAIL_REC As String, ByVal MAIL_SUBJECT As String, ByVal MAIL_BODY As String, ByVal MAIL_SMTP As String, ByVal MAIL_PORT As Integer) As Boolean
        Try
            Dim EmailMessage As New Net.Mail.MailMessage
            Dim Smtp As New Net.Mail.SmtpClient(MAIL_SMTP)

            EmailMessage.From = New Net.Mail.MailAddress(MAIL_EXP)
            EmailMessage.To.Add(MAIL_REC)
            EmailMessage.Subject = MAIL_SUBJECT
            EmailMessage.Body = MAIL_BODY

            EmailMessage.IsBodyHtml = False
            EmailMessage.DeliveryNotificationOptions = Net.Mail.DeliveryNotificationOptions.OnSuccess
            EmailMessage.Priority = Net.Mail.MailPriority.Normal

            Smtp.Port = MAIL_PORT
            Smtp.EnableSsl = False
            'Smtp.ClientCertificates = New System.Net.
            Smtp.Credentials = New System.Net.NetworkCredential(MAIL_EXP, MAIL_PASS)
            Smtp.Send(EmailMessage)

            SEND_EMAIL = True
        Catch ex As Exception
            'SEND_EMAIL = False
            MsgBox("Exception")
        End Try
    End Function

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Settings.Click
        settings.TopLevel = False
        settings.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        settings.Dock = DockStyle.Fill
        Me.Panel_contenir.Controls.Add(settings)
        Me.Panel_contenir.Tag = settings
        settings.Show()
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyyy  HH:mm:ss")
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Voulez vous quitter l'application?", vbYesNo) = vbNo Then Exit Sub
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Text = Date.Now.ToString("   HH:mm " & vbCrLf & "dd/MM/yyyy")
    End Sub

    
 
End Class
