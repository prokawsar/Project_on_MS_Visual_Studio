Public Class frmAddress

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Dim r, r2 As Boolean
        Dim title As String = "Error !"
        r = cheek_(txtboxHouse.Text)
        r2 = cheek_(txtboxPost.Text)


        If (r = False) Then
            Beep()
            MessageBox.Show("Enter Your House Number in Correct Format !", title)
            Exit Sub
        End If

        If (txtboxStreet.Text = "") Then
            Beep()
            MessageBox.Show("Enter Your Street Name Correctly !", title)
            Exit Sub
        End If
        If (txtboxCity.Text = "") Then
            Beep()
            MessageBox.Show("Enter Your City Name Correctly!", title)
            Exit Sub
        End If
        If (r2 = False) Then
            Beep()
            MessageBox.Show("Please Enter Number to Postcode", title)
            Exit Sub
        End If

        'Credit Card Checking
        Dim str As String = txtboxCard.Text
        If (str = "") Then
            Beep()
            MessageBox.Show("Credit Card Number can not Be Empty !", title)
            Exit Sub
        End If

        For x = 0 To str.Length - 1
            Dim oneCha As String
            oneCha = str.Substring(x, 1)
            If (oneCha = " ") Then
                MessageBox.Show("In Credit Card Number can not be a Space !", title)
                Exit Sub
                Exit For
            End If
        Next

        Dim trim As String = txtboxCard.Text.Trim
        For x = 0 To trim.Length - 1
            Dim oneCha As String
            oneCha = trim.Substring(x, 1)
            If Not IsNumeric(oneCha) Then
                MessageBox.Show("In Credit Card can not contain Character !", title)
                Exit Sub

            End If
        Next

        If (str.Length < 16) Then
            Beep()
            MessageBox.Show("Credit Card Number Must be 16 Digit !", title)
            Exit Sub
        End If
        MessageBox.Show("Congratualtion ! Your purchase has been done.")

        Me.Close()
    End Sub


    Private Sub frmAddress_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Graphics As Graphics = e.Graphics

        Graphics.FillRectangle(Brushes.Blue, 0, 50, 532, 28)
        Graphics.FillRectangle(Brushes.BlueViolet, 0, 79, 532, 28)
        Graphics.FillRectangle(Brushes.Chocolate, 0, 108, 532, 28)
        Graphics.FillRectangle(Brushes.BurlyWood, 0, 137, 532, 28)
        Graphics.FillRectangle(Brushes.Salmon, 0, 200, 532, 28)
    End Sub


End Class