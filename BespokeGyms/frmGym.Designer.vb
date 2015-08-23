<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGym
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGym))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstExMachine = New System.Windows.Forms.ListBox()
        Me.txtWeightQuan = New System.Windows.Forms.TextBox()
        Me.lblWPQuantity = New System.Windows.Forms.Label()
        Me.lblMachine = New System.Windows.Forms.Label()
        Me.lstboxPlateSize = New System.Windows.Forms.ListBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.cmbWeightPlate = New System.Windows.Forms.ComboBox()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblBarbell = New System.Windows.Forms.Label()
        Me.cmbDelivery = New System.Windows.Forms.ComboBox()
        Me.cmbBarbell = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbRopes = New System.Windows.Forms.ComboBox()
        Me.cmbRig = New System.Windows.Forms.ComboBox()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.lblRopeQuantity = New System.Windows.Forms.Label()
        Me.lblPullQuantity = New System.Windows.Forms.Label()
        Me.lblMatQuantity = New System.Windows.Forms.Label()
        Me.txtboxMat = New System.Windows.Forms.TextBox()
        Me.lblMat = New System.Windows.Forms.Label()
        Me.txtboxRopes = New System.Windows.Forms.TextBox()
        Me.lblRopes = New System.Windows.Forms.Label()
        Me.txtboxRig = New System.Windows.Forms.TextBox()
        Me.lblPull = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(719, 330)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(87, 35)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(559, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 35)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.lstExMachine)
        Me.Panel1.Controls.Add(Me.txtWeightQuan)
        Me.Panel1.Controls.Add(Me.lblWPQuantity)
        Me.Panel1.Controls.Add(Me.lblMachine)
        Me.Panel1.Controls.Add(Me.lstboxPlateSize)
        Me.Panel1.Controls.Add(Me.lblSize)
        Me.Panel1.Controls.Add(Me.lblPlate)
        Me.Panel1.Controls.Add(Me.cmbWeightPlate)
        Me.Panel1.Controls.Add(Me.lblDelivery)
        Me.Panel1.Controls.Add(Me.lblBarbell)
        Me.Panel1.Controls.Add(Me.cmbDelivery)
        Me.Panel1.Controls.Add(Me.cmbBarbell)
        Me.Panel1.Location = New System.Drawing.Point(15, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 293)
        Me.Panel1.TabIndex = 25
        '
        'lstExMachine
        '
        Me.lstExMachine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstExMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstExMachine.FormattingEnabled = True
        Me.lstExMachine.ItemHeight = 16
        Me.lstExMachine.Location = New System.Drawing.Point(17, 170)
        Me.lstExMachine.Name = "lstExMachine"
        Me.lstExMachine.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstExMachine.Size = New System.Drawing.Size(159, 116)
        Me.lstExMachine.TabIndex = 36
        '
        'txtWeightQuan
        '
        Me.txtWeightQuan.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeightQuan.Location = New System.Drawing.Point(191, 260)
        Me.txtWeightQuan.MaxLength = 7
        Me.txtWeightQuan.Name = "txtWeightQuan"
        Me.txtWeightQuan.Size = New System.Drawing.Size(149, 25)
        Me.txtWeightQuan.TabIndex = 35
        '
        'lblWPQuantity
        '
        Me.lblWPQuantity.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWPQuantity.Location = New System.Drawing.Point(188, 238)
        Me.lblWPQuantity.Name = "lblWPQuantity"
        Me.lblWPQuantity.Size = New System.Drawing.Size(152, 19)
        Me.lblWPQuantity.TabIndex = 34
        Me.lblWPQuantity.Text = "Weight Plate Quantity :"
        '
        'lblMachine
        '
        Me.lblMachine.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachine.Location = New System.Drawing.Point(14, 144)
        Me.lblMachine.Name = "lblMachine"
        Me.lblMachine.Size = New System.Drawing.Size(134, 19)
        Me.lblMachine.TabIndex = 32
        Me.lblMachine.Text = "Exercise Machine"
        '
        'lstboxPlateSize
        '
        Me.lstboxPlateSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstboxPlateSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxPlateSize.FormattingEnabled = True
        Me.lstboxPlateSize.ItemHeight = 16
        Me.lstboxPlateSize.Location = New System.Drawing.Point(191, 108)
        Me.lstboxPlateSize.Name = "lstboxPlateSize"
        Me.lstboxPlateSize.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstboxPlateSize.Size = New System.Drawing.Size(149, 116)
        Me.lstboxPlateSize.TabIndex = 27
        '
        'lblSize
        '
        Me.lblSize.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(187, 83)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(124, 19)
        Me.lblSize.TabIndex = 30
        Me.lblSize.Text = "Weight Plate Size"
        '
        'lblPlate
        '
        Me.lblPlate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.Location = New System.Drawing.Point(14, 83)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(124, 19)
        Me.lblPlate.TabIndex = 29
        Me.lblPlate.Text = "Weight Plate Type"
        '
        'cmbWeightPlate
        '
        Me.cmbWeightPlate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWeightPlate.FormattingEnabled = True
        Me.cmbWeightPlate.Location = New System.Drawing.Point(17, 109)
        Me.cmbWeightPlate.Name = "cmbWeightPlate"
        Me.cmbWeightPlate.Size = New System.Drawing.Size(159, 26)
        Me.cmbWeightPlate.TabIndex = 28
        '
        'lblDelivery
        '
        Me.lblDelivery.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.Location = New System.Drawing.Point(187, 17)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(110, 25)
        Me.lblDelivery.TabIndex = 27
        Me.lblDelivery.Text = "Delivery Type"
        '
        'lblBarbell
        '
        Me.lblBarbell.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarbell.Location = New System.Drawing.Point(14, 17)
        Me.lblBarbell.Name = "lblBarbell"
        Me.lblBarbell.Size = New System.Drawing.Size(112, 25)
        Me.lblBarbell.TabIndex = 26
        Me.lblBarbell.Text = "Barbell Type"
        '
        'cmbDelivery
        '
        Me.cmbDelivery.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDelivery.FormattingEnabled = True
        Me.cmbDelivery.Location = New System.Drawing.Point(190, 42)
        Me.cmbDelivery.Name = "cmbDelivery"
        Me.cmbDelivery.Size = New System.Drawing.Size(150, 26)
        Me.cmbDelivery.TabIndex = 25
        '
        'cmbBarbell
        '
        Me.cmbBarbell.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarbell.FormattingEnabled = True
        Me.cmbBarbell.Location = New System.Drawing.Point(17, 42)
        Me.cmbBarbell.Name = "cmbBarbell"
        Me.cmbBarbell.Size = New System.Drawing.Size(159, 26)
        Me.cmbBarbell.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel2.Controls.Add(Me.cmbRopes)
        Me.Panel2.Controls.Add(Me.cmbRig)
        Me.Panel2.Controls.Add(Me.cmbMat)
        Me.Panel2.Controls.Add(Me.lblRopeQuantity)
        Me.Panel2.Controls.Add(Me.lblPullQuantity)
        Me.Panel2.Controls.Add(Me.lblMatQuantity)
        Me.Panel2.Controls.Add(Me.txtboxMat)
        Me.Panel2.Controls.Add(Me.lblMat)
        Me.Panel2.Controls.Add(Me.txtboxRopes)
        Me.Panel2.Controls.Add(Me.lblRopes)
        Me.Panel2.Controls.Add(Me.txtboxRig)
        Me.Panel2.Controls.Add(Me.lblPull)
        Me.Panel2.Location = New System.Drawing.Point(558, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 293)
        Me.Panel2.TabIndex = 26
        '
        'cmbRopes
        '
        Me.cmbRopes.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRopes.FormattingEnabled = True
        Me.cmbRopes.Location = New System.Drawing.Point(114, 193)
        Me.cmbRopes.Name = "cmbRopes"
        Me.cmbRopes.Size = New System.Drawing.Size(112, 26)
        Me.cmbRopes.TabIndex = 34
        '
        'cmbRig
        '
        Me.cmbRig.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRig.FormattingEnabled = True
        Me.cmbRig.Location = New System.Drawing.Point(114, 109)
        Me.cmbRig.Name = "cmbRig"
        Me.cmbRig.Size = New System.Drawing.Size(112, 26)
        Me.cmbRig.TabIndex = 33
        '
        'cmbMat
        '
        Me.cmbMat.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMat.FormattingEnabled = True
        Me.cmbMat.Location = New System.Drawing.Point(114, 22)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(112, 26)
        Me.cmbMat.TabIndex = 32
        '
        'lblRopeQuantity
        '
        Me.lblRopeQuantity.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRopeQuantity.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRopeQuantity.Location = New System.Drawing.Point(17, 221)
        Me.lblRopeQuantity.Name = "lblRopeQuantity"
        Me.lblRopeQuantity.Size = New System.Drawing.Size(77, 21)
        Me.lblRopeQuantity.TabIndex = 31
        Me.lblRopeQuantity.Text = "Quantity :"
        '
        'lblPullQuantity
        '
        Me.lblPullQuantity.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPullQuantity.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPullQuantity.Location = New System.Drawing.Point(13, 137)
        Me.lblPullQuantity.Name = "lblPullQuantity"
        Me.lblPullQuantity.Size = New System.Drawing.Size(91, 19)
        Me.lblPullQuantity.TabIndex = 30
        Me.lblPullQuantity.Text = "Quantity :"
        '
        'lblMatQuantity
        '
        Me.lblMatQuantity.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatQuantity.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMatQuantity.Location = New System.Drawing.Point(13, 51)
        Me.lblMatQuantity.Name = "lblMatQuantity"
        Me.lblMatQuantity.Size = New System.Drawing.Size(91, 26)
        Me.lblMatQuantity.TabIndex = 29
        Me.lblMatQuantity.Text = "Quantity :"
        '
        'txtboxMat
        '
        Me.txtboxMat.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxMat.Location = New System.Drawing.Point(114, 52)
        Me.txtboxMat.MaxLength = 7
        Me.txtboxMat.Name = "txtboxMat"
        Me.txtboxMat.Size = New System.Drawing.Size(112, 25)
        Me.txtboxMat.TabIndex = 28
        '
        'lblMat
        '
        Me.lblMat.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMat.Location = New System.Drawing.Point(3, 22)
        Me.lblMat.Name = "lblMat"
        Me.lblMat.Size = New System.Drawing.Size(105, 23)
        Me.lblMat.TabIndex = 27
        Me.lblMat.Text = "Exercise mat"
        '
        'txtboxRopes
        '
        Me.txtboxRopes.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxRopes.Location = New System.Drawing.Point(114, 224)
        Me.txtboxRopes.MaxLength = 7
        Me.txtboxRopes.Name = "txtboxRopes"
        Me.txtboxRopes.Size = New System.Drawing.Size(112, 25)
        Me.txtboxRopes.TabIndex = 26
        '
        'lblRopes
        '
        Me.lblRopes.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRopes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRopes.Location = New System.Drawing.Point(3, 193)
        Me.lblRopes.Name = "lblRopes"
        Me.lblRopes.Size = New System.Drawing.Size(109, 26)
        Me.lblRopes.TabIndex = 25
        Me.lblRopes.Text = "Skipping ropes"
        '
        'txtboxRig
        '
        Me.txtboxRig.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxRig.Location = New System.Drawing.Point(114, 139)
        Me.txtboxRig.MaxLength = 7
        Me.txtboxRig.Name = "txtboxRig"
        Me.txtboxRig.Size = New System.Drawing.Size(112, 25)
        Me.txtboxRig.TabIndex = 24
        '
        'lblPull
        '
        Me.lblPull.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPull.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPull.Location = New System.Drawing.Point(13, 111)
        Me.lblPull.Name = "lblPull"
        Me.lblPull.Size = New System.Drawing.Size(91, 19)
        Me.lblPull.TabIndex = 23
        Me.lblPull.Text = "Pull-up rig"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(407, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 110)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Location = New System.Drawing.Point(404, 361)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(117, 13)
        Me.lblSign.TabIndex = 31
        Me.lblSign.Text = "Powered by ProKawsar"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Snow
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Red
        Me.btnReset.Location = New System.Drawing.Point(15, 330)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 35)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmGym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 377)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGym"
        Me.Text = "Basepoke Gyms"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMachine As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblPlate As System.Windows.Forms.Label
    Friend WithEvents cmbWeightPlate As System.Windows.Forms.ComboBox
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents lblBarbell As System.Windows.Forms.Label
    Friend WithEvents cmbDelivery As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBarbell As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbRopes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRig As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents lblRopeQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPullQuantity As System.Windows.Forms.Label
    Friend WithEvents lblMatQuantity As System.Windows.Forms.Label
    Friend WithEvents txtboxMat As System.Windows.Forms.TextBox
    Friend WithEvents lblMat As System.Windows.Forms.Label
    Friend WithEvents txtboxRopes As System.Windows.Forms.TextBox
    Friend WithEvents lblRopes As System.Windows.Forms.Label
    Friend WithEvents txtboxRig As System.Windows.Forms.TextBox
    Friend WithEvents lblPull As System.Windows.Forms.Label
    Friend WithEvents lstboxPlateSize As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSign As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblWPQuantity As System.Windows.Forms.Label
    Friend WithEvents txtWeightQuan As System.Windows.Forms.TextBox
    Friend WithEvents lstExMachine As System.Windows.Forms.ListBox

End Class
