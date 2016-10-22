<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.rdbtnHand = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grpBxHand = New System.Windows.Forms.GroupBox()
        Me.rdbtnWrap = New System.Windows.Forms.RadioButton()
        Me.rdbtnScarf = New System.Windows.Forms.RadioButton()
        Me.rdbtnGloves = New System.Windows.Forms.RadioButton()
        Me.rdbtnHat = New System.Windows.Forms.RadioButton()
        Me.grpBxCharm = New System.Windows.Forms.GroupBox()
        Me.chkBxStar = New System.Windows.Forms.CheckBox()
        Me.chkBxSnowflake = New System.Windows.Forms.CheckBox()
        Me.chkBxRabbit = New System.Windows.Forms.CheckBox()
        Me.chkBxFlower = New System.Windows.Forms.CheckBox()
        Me.chkBxDog = New System.Windows.Forms.CheckBox()
        Me.chkBxCat = New System.Windows.Forms.CheckBox()
        Me.rdbtnCharm = New System.Windows.Forms.RadioButton()
        Me.lstBxColor = New System.Windows.Forms.ListBox()
        Me.txtBxColor = New System.Windows.Forms.TextBox()
        Me.txtBxQuantity = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.LstItems = New System.Windows.Forms.ListBox()
        Me.grpBxShipping = New System.Windows.Forms.GroupBox()
        Me.rdbtnNext = New System.Windows.Forms.RadioButton()
        Me.rdbtnPriority = New System.Windows.Forms.RadioButton()
        Me.rdbtnStandard = New System.Windows.Forms.RadioButton()
        Me.txtBxShipping = New System.Windows.Forms.TextBox()
        Me.btnFinalCheckout = New System.Windows.Forms.Button()
        Me.lstBxReceipt = New System.Windows.Forms.ListBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBackShipping = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpBxHand.SuspendLayout()
        Me.grpBxCharm.SuspendLayout()
        Me.grpBxShipping.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbtnHand
        '
        Me.rdbtnHand.AutoSize = True
        Me.rdbtnHand.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnHand.ForeColor = System.Drawing.Color.Blue
        Me.rdbtnHand.Location = New System.Drawing.Point(13, 13)
        Me.rdbtnHand.Name = "rdbtnHand"
        Me.rdbtnHand.Size = New System.Drawing.Size(236, 30)
        Me.rdbtnHand.TabIndex = 0
        Me.rdbtnHand.TabStop = True
        Me.rdbtnHand.Text = "HAND CROCHETED ITEMS"
        Me.rdbtnHand.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'grpBxHand
        '
        Me.grpBxHand.Controls.Add(Me.rdbtnWrap)
        Me.grpBxHand.Controls.Add(Me.rdbtnScarf)
        Me.grpBxHand.Controls.Add(Me.rdbtnGloves)
        Me.grpBxHand.Controls.Add(Me.rdbtnHat)
        Me.grpBxHand.Location = New System.Drawing.Point(12, 46)
        Me.grpBxHand.Name = "grpBxHand"
        Me.grpBxHand.Size = New System.Drawing.Size(151, 137)
        Me.grpBxHand.TabIndex = 2
        Me.grpBxHand.TabStop = False
        Me.grpBxHand.Text = "Please select one:"
        Me.grpBxHand.Visible = False
        '
        'rdbtnWrap
        '
        Me.rdbtnWrap.AutoSize = True
        Me.rdbtnWrap.Location = New System.Drawing.Point(7, 92)
        Me.rdbtnWrap.Name = "rdbtnWrap"
        Me.rdbtnWrap.Size = New System.Drawing.Size(87, 17)
        Me.rdbtnWrap.TabIndex = 3
        Me.rdbtnWrap.TabStop = True
        Me.rdbtnWrap.Text = "Wrap $25.00"
        Me.rdbtnWrap.UseVisualStyleBackColor = True
        '
        'rdbtnScarf
        '
        Me.rdbtnScarf.AutoSize = True
        Me.rdbtnScarf.Location = New System.Drawing.Point(7, 68)
        Me.rdbtnScarf.Name = "rdbtnScarf"
        Me.rdbtnScarf.Size = New System.Drawing.Size(86, 17)
        Me.rdbtnScarf.TabIndex = 2
        Me.rdbtnScarf.TabStop = True
        Me.rdbtnScarf.Text = "Scarf $12.00"
        Me.rdbtnScarf.UseVisualStyleBackColor = True
        '
        'rdbtnGloves
        '
        Me.rdbtnGloves.AutoSize = True
        Me.rdbtnGloves.Location = New System.Drawing.Point(7, 44)
        Me.rdbtnGloves.Name = "rdbtnGloves"
        Me.rdbtnGloves.Size = New System.Drawing.Size(94, 17)
        Me.rdbtnGloves.TabIndex = 1
        Me.rdbtnGloves.TabStop = True
        Me.rdbtnGloves.Text = "Gloves $12.00"
        Me.rdbtnGloves.UseVisualStyleBackColor = True
        '
        'rdbtnHat
        '
        Me.rdbtnHat.AutoSize = True
        Me.rdbtnHat.Location = New System.Drawing.Point(7, 20)
        Me.rdbtnHat.Name = "rdbtnHat"
        Me.rdbtnHat.Size = New System.Drawing.Size(78, 17)
        Me.rdbtnHat.TabIndex = 0
        Me.rdbtnHat.TabStop = True
        Me.rdbtnHat.Text = "Hat $10.00"
        Me.rdbtnHat.UseVisualStyleBackColor = True
        '
        'grpBxCharm
        '
        Me.grpBxCharm.Controls.Add(Me.chkBxStar)
        Me.grpBxCharm.Controls.Add(Me.chkBxSnowflake)
        Me.grpBxCharm.Controls.Add(Me.chkBxRabbit)
        Me.grpBxCharm.Controls.Add(Me.chkBxFlower)
        Me.grpBxCharm.Controls.Add(Me.chkBxDog)
        Me.grpBxCharm.Controls.Add(Me.chkBxCat)
        Me.grpBxCharm.Location = New System.Drawing.Point(13, 246)
        Me.grpBxCharm.Name = "grpBxCharm"
        Me.grpBxCharm.Size = New System.Drawing.Size(272, 100)
        Me.grpBxCharm.TabIndex = 3
        Me.grpBxCharm.TabStop = False
        Me.grpBxCharm.Text = "CHARMS $2.00 each"
        Me.grpBxCharm.Visible = False
        '
        'chkBxStar
        '
        Me.chkBxStar.AutoSize = True
        Me.chkBxStar.Location = New System.Drawing.Point(161, 67)
        Me.chkBxStar.Name = "chkBxStar"
        Me.chkBxStar.Size = New System.Drawing.Size(45, 17)
        Me.chkBxStar.TabIndex = 5
        Me.chkBxStar.Text = "Star"
        Me.chkBxStar.UseVisualStyleBackColor = True
        '
        'chkBxSnowflake
        '
        Me.chkBxSnowflake.AutoSize = True
        Me.chkBxSnowflake.Location = New System.Drawing.Point(161, 44)
        Me.chkBxSnowflake.Name = "chkBxSnowflake"
        Me.chkBxSnowflake.Size = New System.Drawing.Size(76, 17)
        Me.chkBxSnowflake.TabIndex = 4
        Me.chkBxSnowflake.Text = "Snowflake"
        Me.chkBxSnowflake.UseVisualStyleBackColor = True
        '
        'chkBxRabbit
        '
        Me.chkBxRabbit.AutoSize = True
        Me.chkBxRabbit.Location = New System.Drawing.Point(161, 19)
        Me.chkBxRabbit.Name = "chkBxRabbit"
        Me.chkBxRabbit.Size = New System.Drawing.Size(57, 17)
        Me.chkBxRabbit.TabIndex = 3
        Me.chkBxRabbit.Text = "Rabbit"
        Me.chkBxRabbit.UseVisualStyleBackColor = True
        '
        'chkBxFlower
        '
        Me.chkBxFlower.AutoSize = True
        Me.chkBxFlower.Location = New System.Drawing.Point(7, 67)
        Me.chkBxFlower.Name = "chkBxFlower"
        Me.chkBxFlower.Size = New System.Drawing.Size(57, 17)
        Me.chkBxFlower.TabIndex = 2
        Me.chkBxFlower.Text = "Flower"
        Me.chkBxFlower.UseVisualStyleBackColor = True
        '
        'chkBxDog
        '
        Me.chkBxDog.AutoSize = True
        Me.chkBxDog.Location = New System.Drawing.Point(7, 44)
        Me.chkBxDog.Name = "chkBxDog"
        Me.chkBxDog.Size = New System.Drawing.Size(46, 17)
        Me.chkBxDog.TabIndex = 1
        Me.chkBxDog.Text = "Dog"
        Me.chkBxDog.UseVisualStyleBackColor = True
        '
        'chkBxCat
        '
        Me.chkBxCat.AutoSize = True
        Me.chkBxCat.Location = New System.Drawing.Point(6, 20)
        Me.chkBxCat.Name = "chkBxCat"
        Me.chkBxCat.Size = New System.Drawing.Size(42, 17)
        Me.chkBxCat.TabIndex = 0
        Me.chkBxCat.Text = "Cat"
        Me.chkBxCat.UseVisualStyleBackColor = True
        '
        'rdbtnCharm
        '
        Me.rdbtnCharm.AutoSize = True
        Me.rdbtnCharm.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnCharm.ForeColor = System.Drawing.Color.Blue
        Me.rdbtnCharm.Location = New System.Drawing.Point(12, 210)
        Me.rdbtnCharm.Name = "rdbtnCharm"
        Me.rdbtnCharm.Size = New System.Drawing.Size(224, 30)
        Me.rdbtnCharm.TabIndex = 4
        Me.rdbtnCharm.TabStop = True
        Me.rdbtnCharm.Text = "CHARM BRACELETS $10"
        Me.rdbtnCharm.UseVisualStyleBackColor = True
        '
        'lstBxColor
        '
        Me.lstBxColor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstBxColor.FormattingEnabled = True
        Me.lstBxColor.Items.AddRange(New Object() {"Black", "Gray", "Blue", "Red", "Yellow", "Rainbow", "Green"})
        Me.lstBxColor.Location = New System.Drawing.Point(185, 73)
        Me.lstBxColor.Name = "lstBxColor"
        Me.lstBxColor.Size = New System.Drawing.Size(75, 82)
        Me.lstBxColor.TabIndex = 5
        Me.lstBxColor.Visible = False
        '
        'txtBxColor
        '
        Me.txtBxColor.Location = New System.Drawing.Point(185, 46)
        Me.txtBxColor.Name = "txtBxColor"
        Me.txtBxColor.ReadOnly = True
        Me.txtBxColor.Size = New System.Drawing.Size(86, 20)
        Me.txtBxColor.TabIndex = 6
        Me.txtBxColor.Text = "Colors Available"
        Me.txtBxColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBxColor.Visible = False
        '
        'txtBxQuantity
        '
        Me.txtBxQuantity.Location = New System.Drawing.Point(185, 162)
        Me.txtBxQuantity.Name = "txtBxQuantity"
        Me.txtBxQuantity.ReadOnly = True
        Me.txtBxQuantity.Size = New System.Drawing.Size(46, 20)
        Me.txtBxQuantity.TabIndex = 7
        Me.txtBxQuantity.Text = "Quantity"
        Me.txtBxQuantity.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.Location = New System.Drawing.Point(300, 24)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(209, 36)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add to Cart and Continue"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheckout.Location = New System.Drawing.Point(308, 265)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(195, 65)
        Me.btnCheckout.TabIndex = 10
        Me.btnCheckout.Text = "Add to Cart and Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'LstItems
        '
        Me.LstItems.FormattingEnabled = True
        Me.LstItems.Location = New System.Drawing.Point(308, 66)
        Me.LstItems.Name = "LstItems"
        Me.LstItems.Size = New System.Drawing.Size(198, 173)
        Me.LstItems.TabIndex = 11
        '
        'grpBxShipping
        '
        Me.grpBxShipping.Controls.Add(Me.rdbtnNext)
        Me.grpBxShipping.Controls.Add(Me.rdbtnPriority)
        Me.grpBxShipping.Controls.Add(Me.rdbtnStandard)
        Me.grpBxShipping.Location = New System.Drawing.Point(509, 81)
        Me.grpBxShipping.Name = "grpBxShipping"
        Me.grpBxShipping.Size = New System.Drawing.Size(198, 100)
        Me.grpBxShipping.TabIndex = 12
        Me.grpBxShipping.TabStop = False
        Me.grpBxShipping.Text = "Choose a shipping option"
        Me.grpBxShipping.Visible = False
        '
        'rdbtnNext
        '
        Me.rdbtnNext.AutoSize = True
        Me.rdbtnNext.Location = New System.Drawing.Point(0, 77)
        Me.rdbtnNext.Name = "rdbtnNext"
        Me.rdbtnNext.Size = New System.Drawing.Size(201, 17)
        Me.rdbtnNext.TabIndex = 2
        Me.rdbtnNext.TabStop = True
        Me.rdbtnNext.Text = "Next Day:                                $14.95"
        Me.rdbtnNext.UseVisualStyleBackColor = True
        '
        'rdbtnPriority
        '
        Me.rdbtnPriority.AutoSize = True
        Me.rdbtnPriority.Location = New System.Drawing.Point(0, 48)
        Me.rdbtnPriority.Name = "rdbtnPriority"
        Me.rdbtnPriority.Size = New System.Drawing.Size(194, 17)
        Me.rdbtnPriority.TabIndex = 1
        Me.rdbtnPriority.TabStop = True
        Me.rdbtnPriority.Text = "Priority Shipping: 2-3 days       $9.95"
        Me.rdbtnPriority.UseVisualStyleBackColor = True
        '
        'rdbtnStandard
        '
        Me.rdbtnStandard.AutoSize = True
        Me.rdbtnStandard.Location = New System.Drawing.Point(0, 19)
        Me.rdbtnStandard.Name = "rdbtnStandard"
        Me.rdbtnStandard.Size = New System.Drawing.Size(194, 17)
        Me.rdbtnStandard.TabIndex = 0
        Me.rdbtnStandard.TabStop = True
        Me.rdbtnStandard.Text = "Standard Shipping: 5-7 days   $2.95"
        Me.rdbtnStandard.UseVisualStyleBackColor = True
        '
        'txtBxShipping
        '
        Me.txtBxShipping.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxShipping.Location = New System.Drawing.Point(549, 55)
        Me.txtBxShipping.Name = "txtBxShipping"
        Me.txtBxShipping.ReadOnly = True
        Me.txtBxShipping.Size = New System.Drawing.Size(100, 25)
        Me.txtBxShipping.TabIndex = 13
        Me.txtBxShipping.Text = "Shipping"
        Me.txtBxShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBxShipping.Visible = False
        '
        'btnFinalCheckout
        '
        Me.btnFinalCheckout.BackColor = System.Drawing.Color.GreenYellow
        Me.btnFinalCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalCheckout.Location = New System.Drawing.Point(512, 192)
        Me.btnFinalCheckout.Name = "btnFinalCheckout"
        Me.btnFinalCheckout.Size = New System.Drawing.Size(162, 37)
        Me.btnFinalCheckout.TabIndex = 14
        Me.btnFinalCheckout.Text = "CHECKOUT"
        Me.btnFinalCheckout.UseVisualStyleBackColor = False
        Me.btnFinalCheckout.Visible = False
        '
        'lstBxReceipt
        '
        Me.lstBxReceipt.FormattingEnabled = True
        Me.lstBxReceipt.Location = New System.Drawing.Point(509, 235)
        Me.lstBxReceipt.Name = "lstBxReceipt"
        Me.lstBxReceipt.Size = New System.Drawing.Size(201, 95)
        Me.lstBxReceipt.TabIndex = 15
        Me.lstBxReceipt.Visible = False
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(237, 161)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(34, 20)
        Me.numQuantity.TabIndex = 16
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantity.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Green
        Me.btnConfirm.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Location = New System.Drawing.Point(549, 425)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(125, 47)
        Me.btnConfirm.TabIndex = 17
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'btnBackShipping
        '
        Me.btnBackShipping.BackColor = System.Drawing.Color.Yellow
        Me.btnBackShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackShipping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackShipping.Location = New System.Drawing.Point(509, 352)
        Me.btnBackShipping.Name = "btnBackShipping"
        Me.btnBackShipping.Size = New System.Drawing.Size(98, 47)
        Me.btnBackShipping.TabIndex = 18
        Me.btnBackShipping.Text = "Back To Shipping ^"
        Me.btnBackShipping.UseVisualStyleBackColor = False
        Me.btnBackShipping.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(613, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 47)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel Order/ Exit"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(554, 24)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "<= Back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 484)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBackShipping)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.lstBxReceipt)
        Me.Controls.Add(Me.btnFinalCheckout)
        Me.Controls.Add(Me.txtBxShipping)
        Me.Controls.Add(Me.grpBxShipping)
        Me.Controls.Add(Me.LstItems)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.txtBxQuantity)
        Me.Controls.Add(Me.txtBxColor)
        Me.Controls.Add(Me.lstBxColor)
        Me.Controls.Add(Me.rdbtnCharm)
        Me.Controls.Add(Me.grpBxCharm)
        Me.Controls.Add(Me.grpBxHand)
        Me.Controls.Add(Me.rdbtnHand)
        Me.Name = "Form1"
        Me.Text = "The Handmade Boutique"
        Me.grpBxHand.ResumeLayout(False)
        Me.grpBxHand.PerformLayout()
        Me.grpBxCharm.ResumeLayout(False)
        Me.grpBxCharm.PerformLayout()
        Me.grpBxShipping.ResumeLayout(False)
        Me.grpBxShipping.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbtnHand As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents grpBxHand As GroupBox
    Friend WithEvents grpBxCharm As GroupBox
    Friend WithEvents rdbtnCharm As RadioButton
    Friend WithEvents rdbtnWrap As RadioButton
    Friend WithEvents rdbtnScarf As RadioButton
    Friend WithEvents rdbtnGloves As RadioButton
    Friend WithEvents rdbtnHat As RadioButton
    Friend WithEvents chkBxStar As CheckBox
    Friend WithEvents chkBxSnowflake As CheckBox
    Friend WithEvents chkBxRabbit As CheckBox
    Friend WithEvents chkBxFlower As CheckBox
    Friend WithEvents chkBxDog As CheckBox
    Friend WithEvents chkBxCat As CheckBox
    Friend WithEvents lstBxColor As ListBox
    Friend WithEvents txtBxColor As TextBox
    Friend WithEvents txtBxQuantity As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents LstItems As ListBox
    Friend WithEvents grpBxShipping As GroupBox
    Friend WithEvents rdbtnPriority As RadioButton
    Friend WithEvents rdbtnStandard As RadioButton
    Friend WithEvents txtBxShipping As TextBox
    Friend WithEvents btnFinalCheckout As Button
    Friend WithEvents lstBxReceipt As ListBox
    Friend WithEvents rdbtnNext As RadioButton
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnBackShipping As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBack As Button
End Class
