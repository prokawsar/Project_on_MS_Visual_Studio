<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddress))
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPost = New System.Windows.Forms.Label()
        Me.txtboxCard = New System.Windows.Forms.TextBox()
        Me.txtboxHouse = New System.Windows.Forms.TextBox()
        Me.txtboxStreet = New System.Windows.Forms.TextBox()
        Me.txtboxCity = New System.Windows.Forms.TextBox()
        Me.txtboxPost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCard.Location = New System.Drawing.Point(3, 203)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(149, 20)
        Me.lblCreditCard.TabIndex = 0
        Me.lblCreditCard.Text = "Credit Card Number :"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSubmit.Location = New System.Drawing.Point(299, 236)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(93, 30)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Confirm"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.AutoSize = True
        Me.lblHouseNumber.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseNumber.Location = New System.Drawing.Point(20, 54)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(117, 20)
        Me.lblHouseNumber.TabIndex = 2
        Me.lblHouseNumber.Text = "House Number :"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(40, 83)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(100, 20)
        Me.lblStreet.TabIndex = 3
        Me.lblStreet.Text = "Street Name :"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(54, 112)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(83, 20)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City/Town :"
        '
        'lblPost
        '
        Me.lblPost.AutoSize = True
        Me.lblPost.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPost.Location = New System.Drawing.Point(54, 141)
        Me.lblPost.Name = "lblPost"
        Me.lblPost.Size = New System.Drawing.Size(79, 20)
        Me.lblPost.TabIndex = 5
        Me.lblPost.Text = "Postcode :"
        '
        'txtboxCard
        '
        Me.txtboxCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxCard.Location = New System.Drawing.Point(174, 203)
        Me.txtboxCard.MaxLength = 16
        Me.txtboxCard.Name = "txtboxCard"
        Me.txtboxCard.Size = New System.Drawing.Size(218, 21)
        Me.txtboxCard.TabIndex = 6
        '
        'txtboxHouse
        '
        Me.txtboxHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxHouse.Location = New System.Drawing.Point(174, 54)
        Me.txtboxHouse.MaxLength = 16
        Me.txtboxHouse.Name = "txtboxHouse"
        Me.txtboxHouse.Size = New System.Drawing.Size(218, 21)
        Me.txtboxHouse.TabIndex = 7
        '
        'txtboxStreet
        '
        Me.txtboxStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxStreet.Location = New System.Drawing.Point(174, 83)
        Me.txtboxStreet.MaxLength = 16
        Me.txtboxStreet.Name = "txtboxStreet"
        Me.txtboxStreet.Size = New System.Drawing.Size(218, 21)
        Me.txtboxStreet.TabIndex = 8
        '
        'txtboxCity
        '
        Me.txtboxCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxCity.Location = New System.Drawing.Point(174, 112)
        Me.txtboxCity.MaxLength = 16
        Me.txtboxCity.Name = "txtboxCity"
        Me.txtboxCity.Size = New System.Drawing.Size(218, 21)
        Me.txtboxCity.TabIndex = 9
        '
        'txtboxPost
        '
        Me.txtboxPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPost.Location = New System.Drawing.Point(174, 141)
        Me.txtboxPost.MaxLength = 10
        Me.txtboxPost.Name = "txtboxPost"
        Me.txtboxPost.Size = New System.Drawing.Size(218, 21)
        Me.txtboxPost.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 44)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Please Provide Your Details Here :"
        '
        'frmAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 305)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxPost)
        Me.Controls.Add(Me.txtboxCity)
        Me.Controls.Add(Me.txtboxStreet)
        Me.Controls.Add(Me.txtboxHouse)
        Me.Controls.Add(Me.txtboxCard)
        Me.Controls.Add(Me.lblPost)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblHouseNumber)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblCreditCard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddress"
        Me.Text = "Input Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCreditCard As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblHouseNumber As System.Windows.Forms.Label
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblPost As System.Windows.Forms.Label
    Friend WithEvents txtboxCard As System.Windows.Forms.TextBox
    Friend WithEvents txtboxHouse As System.Windows.Forms.TextBox
    Friend WithEvents txtboxStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtboxCity As System.Windows.Forms.TextBox
    Friend WithEvents txtboxPost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
