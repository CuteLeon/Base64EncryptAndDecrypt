Public Class Base64DEncrypt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EncryptByte() As Byte = System.Text.Encoding.Default.GetBytes(PlainText.Text)
        CipherText.Text = Convert.ToBase64String(EncryptByte)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim DecryptByte() As Byte = Convert.FromBase64String(CipherText.Text)
            PlainText.Text = System.Text.Encoding.Default.GetString(DecryptByte)
        Catch ex As Exception
            PlainText.Text = "不是Base64加密的密文！"
        End Try
    End Sub
End Class
