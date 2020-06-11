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
        Me.lblIntructions = New System.Windows.Forms.Label()
        Me.lblApples = New System.Windows.Forms.Label()
        Me.lblGrapes = New System.Windows.Forms.Label()
        Me.lblOranges = New System.Windows.Forms.Label()
        Me.lblPeaches = New System.Windows.Forms.Label()
        Me.lblPears = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblSurcharge = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtApples = New System.Windows.Forms.TextBox()
        Me.txtGrapes = New System.Windows.Forms.TextBox()
        Me.txtOranges = New System.Windows.Forms.TextBox()
        Me.txtPeaches = New System.Windows.Forms.TextBox()
        Me.txtPears = New System.Windows.Forms.TextBox()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.lblSubtotalOutput = New System.Windows.Forms.Label()
        Me.lblShippingOutput = New System.Windows.Forms.Label()
        Me.lblSurchargeOutput = New System.Windows.Forms.Label()
        Me.lblTaxOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIntructions
        '
        Me.lblIntructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntructions.Location = New System.Drawing.Point(25, 9)
        Me.lblIntructions.Name = "lblIntructions"
        Me.lblIntructions.Size = New System.Drawing.Size(500, 29)
        Me.lblIntructions.TabIndex = 0
        Me.lblIntructions.Text = "Greengrocer Order Form: Enter # Pounds Of Each Item To Purchase"
        Me.lblIntructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblApples
        '
        Me.lblApples.AutoSize = True
        Me.lblApples.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApples.Location = New System.Drawing.Point(37, 95)
        Me.lblApples.Name = "lblApples"
        Me.lblApples.Size = New System.Drawing.Size(101, 13)
        Me.lblApples.TabIndex = 1
        Me.lblApples.Text = "Apples: $3.25/lb"
        '
        'lblGrapes
        '
        Me.lblGrapes.AutoSize = True
        Me.lblGrapes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrapes.Location = New System.Drawing.Point(37, 130)
        Me.lblGrapes.Name = "lblGrapes"
        Me.lblGrapes.Size = New System.Drawing.Size(103, 13)
        Me.lblGrapes.TabIndex = 2
        Me.lblGrapes.Text = "Grapes: $2.75/lb"
        '
        'lblOranges
        '
        Me.lblOranges.AutoSize = True
        Me.lblOranges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOranges.Location = New System.Drawing.Point(37, 172)
        Me.lblOranges.Name = "lblOranges"
        Me.lblOranges.Size = New System.Drawing.Size(110, 13)
        Me.lblOranges.TabIndex = 3
        Me.lblOranges.Text = "Oranges: $3.50/lb"
        '
        'lblPeaches
        '
        Me.lblPeaches.AutoSize = True
        Me.lblPeaches.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeaches.Location = New System.Drawing.Point(37, 215)
        Me.lblPeaches.Name = "lblPeaches"
        Me.lblPeaches.Size = New System.Drawing.Size(112, 13)
        Me.lblPeaches.TabIndex = 4
        Me.lblPeaches.Text = "Peaches: $3.75/lb"
        '
        'lblPears
        '
        Me.lblPears.AutoSize = True
        Me.lblPears.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPears.Location = New System.Drawing.Point(37, 253)
        Me.lblPears.Name = "lblPears"
        Me.lblPears.Size = New System.Drawing.Size(95, 13)
        Me.lblPears.TabIndex = 5
        Me.lblPears.Text = "Pears: $4.30/lb"
        '
        'lblSummary
        '
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(340, 54)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(124, 31)
        Me.lblSummary.TabIndex = 6
        Me.lblSummary.Text = "Order Summary"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(327, 91)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(58, 13)
        Me.lblSubtotal.TabIndex = 7
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipping.Location = New System.Drawing.Point(327, 130)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(60, 13)
        Me.lblShipping.TabIndex = 8
        Me.lblShipping.Text = "Shipping:"
        '
        'lblSurcharge
        '
        Me.lblSurcharge.AutoSize = True
        Me.lblSurcharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurcharge.Location = New System.Drawing.Point(318, 168)
        Me.lblSurcharge.Name = "lblSurcharge"
        Me.lblSurcharge.Size = New System.Drawing.Size(69, 13)
        Me.lblSurcharge.TabIndex = 9
        Me.lblSurcharge.Text = "Surcharge:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(353, 211)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(32, 13)
        Me.lblTax.TabIndex = 10
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(340, 253)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 13)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "TOTAL:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(40, 306)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 44)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(243, 306)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 44)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(380, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 44)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtApples
        '
        Me.txtApples.Location = New System.Drawing.Point(153, 92)
        Me.txtApples.Name = "txtApples"
        Me.txtApples.Size = New System.Drawing.Size(63, 20)
        Me.txtApples.TabIndex = 16
        Me.txtApples.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGrapes
        '
        Me.txtGrapes.Location = New System.Drawing.Point(153, 130)
        Me.txtGrapes.Name = "txtGrapes"
        Me.txtGrapes.Size = New System.Drawing.Size(63, 20)
        Me.txtGrapes.TabIndex = 17
        Me.txtGrapes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOranges
        '
        Me.txtOranges.Location = New System.Drawing.Point(153, 169)
        Me.txtOranges.Name = "txtOranges"
        Me.txtOranges.Size = New System.Drawing.Size(63, 20)
        Me.txtOranges.TabIndex = 18
        Me.txtOranges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeaches
        '
        Me.txtPeaches.Location = New System.Drawing.Point(153, 208)
        Me.txtPeaches.Name = "txtPeaches"
        Me.txtPeaches.Size = New System.Drawing.Size(63, 20)
        Me.txtPeaches.TabIndex = 19
        Me.txtPeaches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPears
        '
        Me.txtPears.Location = New System.Drawing.Point(153, 246)
        Me.txtPears.Name = "txtPears"
        Me.txtPears.Size = New System.Drawing.Size(63, 20)
        Me.txtPears.TabIndex = 20
        Me.txtPears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.BackColor = System.Drawing.Color.White
        Me.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalOutput.Location = New System.Drawing.Point(397, 248)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(73, 18)
        Me.lblTotalOutput.TabIndex = 24
        Me.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblSubtotalOutput
        '
        Me.lblSubtotalOutput.BackColor = System.Drawing.Color.White
        Me.lblSubtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotalOutput.Location = New System.Drawing.Point(397, 89)
        Me.lblSubtotalOutput.Name = "lblSubtotalOutput"
        Me.lblSubtotalOutput.Size = New System.Drawing.Size(73, 19)
        Me.lblSubtotalOutput.TabIndex = 25
        Me.lblSubtotalOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblShippingOutput
        '
        Me.lblShippingOutput.BackColor = System.Drawing.Color.White
        Me.lblShippingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingOutput.Location = New System.Drawing.Point(397, 132)
        Me.lblShippingOutput.Name = "lblShippingOutput"
        Me.lblShippingOutput.Size = New System.Drawing.Size(73, 21)
        Me.lblShippingOutput.TabIndex = 26
        Me.lblShippingOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblSurchargeOutput
        '
        Me.lblSurchargeOutput.BackColor = System.Drawing.Color.White
        Me.lblSurchargeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSurchargeOutput.Location = New System.Drawing.Point(397, 168)
        Me.lblSurchargeOutput.Name = "lblSurchargeOutput"
        Me.lblSurchargeOutput.Size = New System.Drawing.Size(73, 21)
        Me.lblSurchargeOutput.TabIndex = 27
        Me.lblSurchargeOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTaxOutput
        '
        Me.lblTaxOutput.BackColor = System.Drawing.Color.White
        Me.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxOutput.Location = New System.Drawing.Point(397, 210)
        Me.lblTaxOutput.Name = "lblTaxOutput"
        Me.lblTaxOutput.Size = New System.Drawing.Size(73, 18)
        Me.lblTaxOutput.TabIndex = 28
        Me.lblTaxOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 390)
        Me.Controls.Add(Me.lblTaxOutput)
        Me.Controls.Add(Me.lblSurchargeOutput)
        Me.Controls.Add(Me.lblShippingOutput)
        Me.Controls.Add(Me.lblSubtotalOutput)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.txtPears)
        Me.Controls.Add(Me.txtPeaches)
        Me.Controls.Add(Me.txtOranges)
        Me.Controls.Add(Me.txtGrapes)
        Me.Controls.Add(Me.txtApples)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSurcharge)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblPears)
        Me.Controls.Add(Me.lblPeaches)
        Me.Controls.Add(Me.lblOranges)
        Me.Controls.Add(Me.lblGrapes)
        Me.Controls.Add(Me.lblApples)
        Me.Controls.Add(Me.lblIntructions)
        Me.Name = "Form1"
        Me.Text = "Organic Greengrocer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntructions As System.Windows.Forms.Label
    Friend WithEvents lblApples As System.Windows.Forms.Label
    Friend WithEvents lblGrapes As System.Windows.Forms.Label
    Friend WithEvents lblOranges As System.Windows.Forms.Label
    Friend WithEvents lblPeaches As System.Windows.Forms.Label
    Friend WithEvents lblPears As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblSurcharge As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtApples As System.Windows.Forms.TextBox
    Friend WithEvents txtGrapes As System.Windows.Forms.TextBox
    Friend WithEvents txtOranges As System.Windows.Forms.TextBox
    Friend WithEvents txtPeaches As System.Windows.Forms.TextBox
    Friend WithEvents txtPears As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblShippingOutput As System.Windows.Forms.Label
    Friend WithEvents lblSurchargeOutput As System.Windows.Forms.Label
    Friend WithEvents lblTaxOutput As System.Windows.Forms.Label

End Class
