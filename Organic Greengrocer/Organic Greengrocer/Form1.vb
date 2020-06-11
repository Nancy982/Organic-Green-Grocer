'Nancy Medina
'CS105
'Spring-2020

'I pledge that I have neither given nor received help from anyone other than the instructor and TA
'for all program components included here.

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare contants for shipping and surcharge cutoff values and fruit price values
        Const decSHIP_CUTOFF As Decimal = 50D
        Const decSURCHARGE_CUTOFF As Decimal = 25D
        Const decZERO As Decimal = 0D
        Const decAPPLE_PRICE As Decimal = 3.25D
        Const decGRAPE_PRICE As Decimal = 2.75D
        Const decORANGE_PRICE As Decimal = 3.5D
        Const decPEACH_PRICE As Decimal = 3.75D
        Const decPEAR_PRICE As Decimal = 4.3D
        Const decTax_RATE As Decimal = 0.079D
        Const decSHIP_RATE As Decimal = 7.5D
        Const decSURCHARGE_RATE As Decimal = 5D

        'Declare Decimal variables for the the total of each fruit, subtotal, tax, total, shipping and surcharge 
        Dim decTotalApple As Decimal
        Dim decTotalGrape As Decimal
        Dim decTotalOrange As Decimal
        Dim decTotalPeach As Decimal
        Dim decTotalPear As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Dim decShip As Decimal
        Dim decSurcharge As Decimal

        'Declare Decimal variables for the corresponding fruit (user input will be stored here)
        Dim decUserApple As Decimal
        Dim decUserGrape As Decimal
        Dim decUserOrange As Decimal
        Dim decUserPeach As Decimal
        Dim decUserPear As Decimal

        'Collect user input from the Text property's of each fruit, and assign them to the Decimal variables
        decUserApple = CDec(txtApples.Text)
        decUserGrape = CDec(txtGrapes.Text)
        decUserOrange = CDec(txtOranges.Text)
        decUserPeach = CDec(txtPeaches.Text)
        decUserPear = CDec(txtPears.Text)

        'calculate the total for each fruit
        decTotalApple = decUserApple * decAPPLE_PRICE
        decTotalGrape = decUserGrape * decGRAPE_PRICE
        decTotalOrange = decUserOrange * decORANGE_PRICE
        decTotalPeach = decUserPeach * decPEACH_PRICE
        decTotalPear = decUserPear * decPEAR_PRICE

        'calculate the subtotal and tax
        decSubtotal = decTotalApple + decTotalGrape + decTotalOrange + decTotalPeach + decTotalPear
        decTax = (decSubtotal * decTax_RATE)

        'display the subtotal and tax in the Text property's of lblSubtotalOutput and lblTaxOutput
        lblSubtotalOutput.Text = decSubtotal.ToString("C")
        lblTaxOutput.Text = decTax.ToString("C")

        'Compare the subtotal variable to the shipping and surcharge cutoff values to determine the correct shipping and surcharge
        If (decSubtotal = decZERO) Then
            decShip = 0
            decSurcharge = 0
        ElseIf (decSubtotal >= decSURCHARGE_CUTOFF) Then
            If (decSubtotal >= decSHIP_CUTOFF) Then
                decSurcharge = 0
                decShip = 0
            Else
                decSurcharge = 0
                decShip = decSHIP_RATE
            End If
        Else
            decShip = decSHIP_RATE
            decSurcharge = decSURCHARGE_RATE
        End If
        'display the shipping and surcharge in the Text property's of lblShippingOutput and lblSurchargeOutput.Text 
        lblShippingOutput.Text = decShip.ToString("C")
        lblSurchargeOutput.Text = decSurcharge.ToString("C")

        'calulate the total
        decTotal = decSubtotal + decShip + decSurcharge + decTax

        'display the total in the Text property of lblTotalOutput
        lblTotalOutput.Text = decTotal.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the TextBox controls
        txtApples.Text = String.Empty
        txtGrapes.Text = String.Empty
        txtOranges.Text = String.Empty
        txtPeaches.Text = String.Empty
        txtPears.Text = String.Empty

        'Clear all the Lable controls
        lblSubtotalOutput.Text = String.Empty
        lblShippingOutput.Text = String.Empty
        lblSurchargeOutput.Text = String.Empty
        lblTaxOutput.Text = String.Empty
        lblTotalOutput.Text = String.Empty

        'Set the focus to the txtApples TextBox; this designates the position of the blinking cursor
        txtApples.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
