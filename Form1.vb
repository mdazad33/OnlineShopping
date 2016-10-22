Public Class Form1

    Dim color As String
    Dim quantity As Integer
    Dim totalCost As Double
    Dim subtotal As Double
    Dim item As String
    Dim tax As Double
    Dim shippingCost As Double


    Private Sub rdbtnHand_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnHand.CheckedChanged

        'viewing only hsnf crocheted section
        grpBxHand.Visible = True
        lstBxColor.Visible = True
        numQuantity.Visible = True
        txtBxColor.Visible = True
        txtBxQuantity.Visible = True

        grpBxCharm.Visible = False


    End Sub

    Private Sub rdbtnCharm_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnCharm.CheckedChanged
        'viewing only charm section
        grpBxHand.Visible = False
        lstBxColor.Visible = False
        numQuantity.Visible = False
        txtBxColor.Visible = False
        txtBxQuantity.Visible = False

        grpBxCharm.Visible = True
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If rdbtnHand.Checked Then
            If numQuantity.Value < 1 Then
                MessageBox.Show("Please, select the amount of items you want to purchase!")
                Return
            End If
            If lstBxColor.Text = "" Then
                MessageBox.Show("Please, select a color of your item!")
                Return
            End If
            If rdbtnHat.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_hat = 10 * quantity
                color = lstBxColor.Text
                totalCost += price_hat
                item = color & " hat " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            ElseIf rdbtnGloves.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_gloves = 12 * quantity
                color = lstBxColor.Text
                totalCost += price_gloves
                item = color & " Gloves " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            ElseIf rdbtnScarf.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_scarf = 12 * quantity
                color = lstBxColor.Text
                totalCost += price_scarf
                item = color & " Scarf " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            ElseIf rdbtnWrap.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_wrap = 25 * quantity
                color = lstBxColor.Text
                totalCost += price_wrap
                item = color & " Wrap " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            End If
        ElseIf rdbtnCharm.Checked Then
            totalCost += 10
            item = "Charm Bracelet "
            If chkBxCat.Checked Then
                item += " Cat "
                totalCost += 2
            End If
            If chkBxDog.Checked Then
                item += " Dog "
                totalCost += 2
            End If
            If chkBxFlower.Checked Then
                item += " Flower "
                totalCost += 2
            End If
            If chkBxRabbit.Checked Then
                item += " Rabbit "
                totalCost += 2
            End If
            If chkBxSnowflake.Checked Then
                item += " Snowflake "
                totalCost += 2
            End If
            If chkBxStar.Checked Then
                item += " Star "
                totalCost += 2
            End If

            item += " Quantity: 1"
            LstItems.Items.Add(item)

        Else
            MessageBox.Show("Please choose an item to purchase!")
        End If

        rdbtnHand.Checked = False
        rdbtnCharm.Checked = False
        rdbtnHat.Checked = False
        rdbtnGloves.Checked = False
        rdbtnScarf.Checked = False
        rdbtnWrap.Checked = False
        chkBxCat.Checked = False
        chkBxDog.Checked = False
        chkBxFlower.Checked = False
        chkBxSnowflake.Checked = False
        chkBxRabbit.Checked = False
        chkBxStar.Checked = False
        numQuantity.Value = 1
        lstBxColor.ClearSelected()

        grpBxHand.Visible = False
        grpBxCharm.Visible = False
        lstBxColor.Visible = False
        txtBxColor.Visible = False
        numQuantity.Visible = False
        txtBxQuantity.Visible = False
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        If rdbtnHand.Checked Then
            If numQuantity.Value < 1 Then
                MessageBox.Show("Please, select the amount of items you want to purchase!")
                Return
            End If
            If lstBxColor.Text = "" Then
                MessageBox.Show("Please, select a color of your item!")
                Return
            End If
            If rdbtnHat.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_hat = 10 * quantity
                color = lstBxColor.Text
                totalCost += price_hat
                item = color & " hat " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            ElseIf rdbtnGloves.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_gloves = 12 * quantity
                color = lstBxColor.Text
                totalCost += price_gloves
                item = color & " Gloves " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            ElseIf rdbtnScarf.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_scarf = 12 * quantity
                color = lstBxColor.Text
                totalCost += price_scarf
                item = color & " Scarf " & " Quantity: " & quantity
                LstItems.Items.Add(item)

            ElseIf rdbtnWrap.Checked Then
                quantity = CInt(numQuantity.Text)
                Dim price_wrap = 25 * quantity
                color = lstBxColor.Text
                totalCost += price_wrap
                item = color & " Wrap " & " Quantity: " & quantity
                LstItems.Items.Add(item)
            End If
        ElseIf rdbtnCharm.Checked Then
            totalCost += 10
            item = "Charm Bracelet "
            If chkBxCat.Checked Then
                item += " Cat "
                totalCost += 2
            End If
            If chkBxDog.Checked Then
                item += " Dog "
                totalCost += 2
            End If
            If chkBxFlower.Checked Then
                item += " Flower "
                totalCost += 2
            End If
            If chkBxRabbit.Checked Then
                item += " Rabbit "
                totalCost += 2
            End If
            If chkBxSnowflake.Checked Then
                item += " Snowflake "
                totalCost += 2
            End If
            If chkBxStar.Checked Then
                item += " Star "
                totalCost += 2
            End If

            item += " Quantity: 1"
            LstItems.Items.Add(item)

        End If


        grpBxHand.Visible = False
        grpBxCharm.Visible = False
        rdbtnHand.Visible = False
        rdbtnCharm.Visible = False
        txtBxColor.Visible = False
        txtBxQuantity.Visible = False
        numQuantity.Visible = False
        lstBxColor.Visible = False
        BtnAdd.Visible = False
        LstItems.Visible = False
        btnCheckout.Visible = False

        txtBxShipping.Visible = True
        btnFinalCheckout.Visible = True
        grpBxShipping.Visible = True
        lstBxReceipt.Visible = True
        btnConfirm.Visible = True
        btnBack.Visible = True


    End Sub

    Private Sub btnFinalCheckout_Click(sender As Object, e As EventArgs) Handles btnFinalCheckout.Click

        tax = totalCost * 0.0875

        If rdbtnStandard.Checked Then
            shippingCost += 2.95
        ElseIf rdbtnPriority.Checked Then
            shippingCost += 9.95
        ElseIf rdbtnNext.Checked Then
            shippingCost += 14.95
        Else
            MessageBox.Show("Please, Choose a shipping option!")
            Return
        End If
        Dim subtotal As Double = totalCost + shippingCost + tax
        totalCost.ToString("C")
        tax.ToString("C")
        shippingCost.ToString("C")
        subtotal.ToString("C")



        lstBxReceipt.Items.Add("Total cost of items: $" & totalCost)
        lstBxReceipt.Items.Add("Total tax: $" & tax)
        lstBxReceipt.Items.Add("Shipping cost: $" & shippingCost)
        lstBxReceipt.Items.Add("______________________________")
        lstBxReceipt.Items.Add("Subtotal: $" & subtotal)

        txtBxShipping.Visible = False
        grpBxShipping.Visible = False
        btnBack.Visible = False
        btnFinalCheckout.Visible = False
        btnBackShipping.Visible = True
        lstBxReceipt.Visible = True
        btnConfirm.Visible = True



    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        MessageBox.Show("Your order has been placed! Thank You for Shopping with us. ")
        rdbtnPriority.Checked = False
        rdbtnStandard.Checked = False
        rdbtnNext.Checked = False
        lstBxReceipt.Items.Clear()
        LstItems.Items.Clear()
        totalCost = 0
        subtotal = 0

        lstBxReceipt.Visible = False
        grpBxShipping.Visible = False
        txtBxShipping.Visible = False
        btnFinalCheckout.Visible = False
        btnConfirm.Visible = False
        btnBackShipping.Visible = False

        rdbtnHand.Visible = True
        rdbtnCharm.Visible = True
        btnCheckout.Visible = True
        BtnAdd.Visible = True
        LstItems.Visible = True
        rdbtnHand.Checked = True





    End Sub

    Private Sub btnBackShipping_Click(sender As Object, e As EventArgs) Handles btnBackShipping.Click
        shippingCost = 0
        lstBxReceipt.Items.Clear()
        btnBack.Visible = True
        txtBxShipping.Visible = True
        grpBxShipping.Visible = True
        btnFinalCheckout.Visible = True

        lstBxReceipt.Visible = False
        btnConfirm.Visible = False
        btnBackShipping.Visible = False



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MessageBox.Show("Your Order has been CANCELED!!!")
        Close()

    End Sub
End Class
