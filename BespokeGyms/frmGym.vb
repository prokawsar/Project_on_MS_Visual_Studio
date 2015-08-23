Public Class frmGym
    Dim title As String = "Error !"
    Dim warnig As String = "Warning"
    'Components Stock
    Dim barbell() As Integer = {3, 3, 3, 3}
    Dim bumper() As Integer = {30, 30, 30, 30, 30}
    Dim steel() As Integer = {30, 30, 30, 30, 30, 30}
    Dim ExMac() As Integer = {3, 3, 3, 3}

    Dim exMat() As Integer = {10, 10}
    Dim Pull() As Integer = {10, 10, 10}
    Dim Ropes() As Integer = {10, 10, 10}

    'Components price
    Dim barbellPrice() As Single = {2.0, 3.0, 4.0, 4.5}
    Dim weightPrice() As Single = {5.5, 5.0, 4.0, 3.5, 3.0, 2.0}
    Dim exerPrice() As Single = {2.0, 3.0, 4.0, 4.5}
    Dim matPrice() As Single = {2.0, 3.0}
    Dim rigPrice() As Single = {2.0, 3.0, 4.0}
    Dim ropesPrice() As Single = {2.0, 3.0, 4.0}

    Private Sub frmGym_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        'Me.BackColor = ColorTranslator.FromHtml("#FF0023")

        'Loading Instrument to ComboBox
        cmbBarbell.Items.Add("20kg Olympic Bar")
        cmbBarbell.Items.Add("16kg Olympic Women's Bar")
        cmbBarbell.Items.Add("12kg Bar")
        cmbBarbell.Items.Add("2kg hollow Bar")
        cmbBarbell.SelectedIndex = 0

        cmbDelivery.Items.Add("Overnight express")
        cmbDelivery.Items.Add("Priority")
        cmbDelivery.Items.Add("Standard")
        cmbDelivery.SelectedIndex = 0

        cmbWeightPlate.Items.Add("Bumper Plates (rubber)")
        cmbWeightPlate.Items.Add("Steel Plates")
        cmbWeightPlate.SelectedIndex = 0

        txtWeightQuan.Text = 1

        lstExMachine.Items.Add("Rowing Machine")
        lstExMachine.Items.Add("Aerodyne Machine")
        lstExMachine.Items.Add("Exercise Bike")
        lstExMachine.Items.Add("Treadmill")
        lstExMachine.SelectedIndex = 0

        cmbMat.Items.Add("Thick foam")
        cmbMat.Items.Add("Yoga mat")
        cmbMat.SelectedIndex = 0
        txtboxMat.Text = 1

        cmbRig.Items.Add("Free standing")
        cmbRig.Items.Add("Wall mounted")
        cmbRig.Items.Add("Door mounted")
        cmbRig.SelectedIndex = 0
        txtboxRig.Text = 1

        cmbRopes.Items.Add("Regular Ropes")
        cmbRopes.Items.Add("Speed ropes")
        cmbRopes.Items.Add("Leather ropes")
        cmbRopes.SelectedIndex = 0
        txtboxRopes.Text = 1

    End Sub

    Private Sub cmbDelivery_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDelivery.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbBarbell_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBarbell.KeyPress
        e.Handled = True
    End Sub

    Private Sub lstExMachine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstExMachine.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbMat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMat.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbRig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRig.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbRopes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRopes.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbWeightPlate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbWeightPlate.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        'Checking any of them missing or not
        If (cmbBarbell.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Barbell type Missing !", title)
            Exit Sub
        ElseIf (cmbDelivery.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Delivery type Missing !", title)
            Exit Sub

        ElseIf (cmbWeightPlate.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Weight Plate type Missing !", title)
            Exit Sub
        ElseIf (lstboxPlateSize.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Weight Plate size Missing !", title)
            Exit Sub
        ElseIf (lstExMachine.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Exersice Machine Missing !", title)
            Exit Sub
        ElseIf (Num(txtWeightQuan.Text) = 0) Then
            MessageBox.Show("Wrong Quantity in Weight Plate !", title)
            Exit Sub
        End If
        If (cmbMat.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Exersice Mat Missing !", title)
            Exit Sub

            'Checking Quantity Box
        ElseIf (Num(txtboxMat.Text) = 0) Then
            Beep()
            MessageBox.Show("Wrong Quantity in Exersice Mat !", title)
            Exit Sub
        ElseIf (cmbRig.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Pull-up Rig Missing !", title)
            Exit Sub
        ElseIf (Num(txtboxRig.Text) = 0) Then
            Beep()
            MessageBox.Show("Wrong Quantity in Pull-up Rig !", title)
            Exit Sub
        ElseIf (cmbRopes.SelectedIndex < 0) Then
            Beep()
            MessageBox.Show("Skipping Ropes Missing !", title)
            Exit Sub
        ElseIf (Num(txtboxRopes.Text) = 0) Then
            Beep()
            MessageBox.Show("Wrong Quantity in Skipping Ropes !", title)
            Exit Sub
        End If
        'Initialize all Indexes
        Dim bar As Integer = cmbBarbell.SelectedIndex
        Dim size As Integer = lstboxPlateSize.SelectedIndex
        Dim mac As Integer = lstExMachine.SelectedIndex
        Dim mat As Integer = cmbMat.SelectedIndex
        Dim rig As Integer = cmbRig.SelectedIndex
        Dim rop As Integer = cmbRopes.SelectedIndex

        Dim compPrice As Single
        compPrice = barbellPrice(bar) + weightPrice(size) * txtWeightQuan.Text + exerPrice(mac) + (matPrice(mat) * txtboxMat.Text) +
        (rigPrice(rig) * txtboxRig.Text) + (ropesPrice(rop) * txtboxRopes.Text)


        'Checking Components stock
        If (barbell(bar) < 1) Then
            Beep()
            MessageBox.Show(cmbBarbell.SelectedItem & " out of stock !", warnig)
            Exit Sub
        End If

        If (cmbWeightPlate.SelectedIndex = 0) Then
            If (bumper(size) < txtWeightQuan.Text) Then
                Beep()
                MessageBox.Show(cmbWeightPlate.SelectedItem & " " & lstboxPlateSize.SelectedItem & " out of stock !", title)
                Exit Sub
            End If
        End If

        If (cmbWeightPlate.SelectedIndex = 1) Then
            If (steel(size) < txtWeightQuan.Text) Then
                Beep()
                MessageBox.Show(cmbWeightPlate.SelectedItem & " " & lstboxPlateSize.SelectedItem & " out of stock !", title)
                Exit Sub
            End If
        End If
        If (ExMac(mac) < 1) Then
            Beep()
            MessageBox.Show(lstExMachine.SelectedItem & " out of stock !", warnig)
            Exit Sub
        End If
        If (exMat(mat) < txtboxMat.Text) Then
            Beep()
            MessageBox.Show(cmbMat.SelectedItem & " out of stock !", warnig)
            Exit Sub
        End If
        If (Pull(rig) < txtboxRig.Text) Then
            Beep()
            MessageBox.Show(cmbRig.SelectedItem & " Pull-up Rig out of stock !", warnig)
            Exit Sub
        End If
        If (Ropes(rop) < txtboxRopes.Text) Then
            Beep()
            MessageBox.Show(cmbRopes.SelectedItem & " out of stock !", warnig)
            Exit Sub
        End If

        Dim output_msg As String
        output_msg = "Your Choices Are : " & vbCrLf & "--------------------" & vbCrLf & "Barbell :                             " & cmbBarbell.SelectedItem & " : 1" &
            vbCrLf & vbCrLf & "Delivery type :                   " & cmbDelivery.SelectedItem & vbCrLf & vbCrLf & "Weight Plate type :           " & cmbWeightPlate.SelectedItem &
            vbCrLf & vbCrLf & "Weight Plate size :             " & lstboxPlateSize.SelectedItem & " " & txtWeightQuan.Text & vbCrLf & vbCrLf & "Exercise Machine :           " & lstExMachine.SelectedItem & " : 1" &
            vbCrLf & vbCrLf & "Exercise Mat :                   " & cmbMat.SelectedItem & " : " & txtboxMat.Text & vbCrLf & vbCrLf & "Pull-up Rig :                     " & cmbRig.SelectedItem & " : " & txtboxRig.Text &
    vbCrLf & vbCrLf & cmbRopes.SelectedItem & " :               " & txtboxRopes.Text & vbCrLf & vbCrLf & "Toal Price :                      £ " & compPrice


        If (txtWeightQuan.Text >= 10) Then
            'Calculating Discount
            Dim temp As Single = compPrice * 15 / 100
            Dim discount As Single = compPrice - temp

            Dim output_msg2 As String
            output_msg2 = "Your Choices Are : " & vbCrLf & "--------------------" & vbCrLf & "Barbell :                             " & cmbBarbell.SelectedItem & " : 1" &
                vbCrLf & vbCrLf & "Delivery type :                   " & cmbDelivery.SelectedItem & vbCrLf & vbCrLf & "Weight Plate type :           " & cmbWeightPlate.SelectedItem &
                vbCrLf & vbCrLf & "Weight Plate size :             " & lstboxPlateSize.SelectedItem & " " & txtWeightQuan.Text & vbCrLf & vbCrLf & "Exercise Machine :           " & lstExMachine.SelectedItem & " : 1" &
                vbCrLf & vbCrLf & "Exercise Mat :                   " & cmbMat.SelectedItem & " : " & txtboxMat.Text & vbCrLf & vbCrLf & "Pull-up Rig :                      " & cmbRig.SelectedItem & " : " & txtboxRig.Text &
        vbCrLf & vbCrLf & cmbRopes.SelectedItem & " :               " & txtboxRopes.Text & vbCrLf & vbCrLf & "Toal Price :                      £ " & compPrice & vbCrLf & vbCrLf & "Discount Price :              £ " & discount



            Dim x As DialogResult = MessageBox.Show(output_msg2 & vbCrLf & "------------------------------" & vbCrLf & "Would You Like to Proceed ?", " CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then
                barbell(bar) = barbell(bar) - 1
                If (cmbWeightPlate.SelectedIndex = 0) Then
                    bumper(size) = bumper(size) - txtWeightQuan.Text

                ElseIf (cmbWeightPlate.SelectedIndex = 1) Then
                    steel(size) = steel(size) - txtWeightQuan.Text
                End If
                ExMac(mac) = ExMac(mac) - 1
                exMat(mat) = exMat(mat) - txtboxMat.Text
                Pull(rig) = Pull(rig) - txtboxRig.Text
                Ropes(rop) = Ropes(rop) - txtboxRopes.Text
                MessageBox.Show("---------------------------" & vbCrLf & "Thanks For Your Customs." & vbCrLf &
                                "---------------------------", "Message")
                frmAddress.Show()

            Else
                MessageBox.Show("Your Purchase is Cancelled", "Message")

            End If
            Exit Sub
        End If

        Dim x1 As DialogResult = MessageBox.Show(output_msg & vbCrLf & "------------------------------" & vbCrLf & "Would You Like to Proceed ?", " CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)



        If x1 = Windows.Forms.DialogResult.Yes Then
            barbell(bar) = barbell(bar) - 1
            If (cmbWeightPlate.SelectedIndex = 0) Then
                bumper(size) = bumper(size) - 1

            ElseIf (cmbWeightPlate.SelectedIndex = 1) Then
                steel(size) = steel(size) - 1
            End If
            ExMac(mac) = ExMac(mac) - 1
            exMat(mat) = exMat(mat) - txtboxMat.Text
            Pull(rig) = Pull(rig) - txtboxRig.Text
            Ropes(rop) = Ropes(rop) - txtboxRopes.Text
            MessageBox.Show("---------------------------" & vbCrLf & "Thanks For Your Customs." & vbCrLf &
                            "---------------------------", "Message")
            frmAddress.Show()

        Else
            MessageBox.Show("Your Purchase is Cancelled", "Message")

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub


    Private Sub cmbWeightPlate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWeightPlate.SelectedIndexChanged

        If cmbWeightPlate.SelectedIndex = 1 Then
            lstboxPlateSize.Items.Clear()
            lstboxPlateSize.Items.Add("Pair of 25kg")
            lstboxPlateSize.Items.Add("Pair of 20kg")
            lstboxPlateSize.Items.Add("Pair of 15kg")
            lstboxPlateSize.Items.Add("Pair of 10kg")
            lstboxPlateSize.Items.Add("Pair of 5kg")
            lstboxPlateSize.Items.Add("Pair of 2.5kg")
            lstboxPlateSize.SelectedIndex = 0
        End If
        If cmbWeightPlate.SelectedIndex = 0 Then
            lstboxPlateSize.Items.Clear()
            lstboxPlateSize.Items.Add("Pair of 25kg")
            lstboxPlateSize.Items.Add("Pair of 20kg")
            lstboxPlateSize.Items.Add("Pair of 15kg")
            lstboxPlateSize.Items.Add("Pair of 10kg")
            lstboxPlateSize.Items.Add("Pair of 5kg")
            lstboxPlateSize.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmGym_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Graphics As Graphics = e.Graphics

        Graphics.FillRectangle(Brushes.DeepSkyBlue, 100, 18, 600, 110)
        Graphics.FillRectangle(Brushes.DarkViolet, 120, 196, 600, 115)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        cmbBarbell.SelectedIndex = 0
        cmbDelivery.SelectedIndex = 0
        cmbWeightPlate.SelectedIndex = 0
        txtWeightQuan.Text = 1

        cmbMat.SelectedIndex = 0
        cmbRig.SelectedIndex = 0
        cmbRopes.SelectedIndex = 0
        txtboxMat.Text = 1
        txtboxRig.Text = 1
        txtboxRopes.Text = 1
    End Sub

End Class
