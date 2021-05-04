Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Formun başlığını ayarlayın.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format(ApplicationTitle, "Berkay ERAYDIN 1700002887")
        ' Hakkında Kutusu üzerinde görüntülenen metnin tümünü baştan atayın.
        ' TODO: Projenin "Uygulama" bölmesinde uygulamanın derleme bilgisini özelleştirin 
        '    özellikleri iletişim kutusunda yapılır ("Proje" menüsü altında).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("İstanbul Kültür Üniversitesi")
        Me.LabelCopyright.Text = String.Format("Matematik ve Bilgisayar")
        Me.LabelCompanyName.Text = String.Format("Berkay ERAYDIN 1700002887")
        Me.TextBoxDescription.Text = String.Format("MB0013 - Görsel Programlama - Visual Basic ile Yazılım Geliştirme.")
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
