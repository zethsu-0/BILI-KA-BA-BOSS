Public Class Form1

    Dim total As Decimal
    Dim payment As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sardinasLigo, sardinas555, tunacan, argentina, straCorned, hekkaido, sanMarino, sabaSalmon, spam, delimodo As Decimal

        Dim chickenNeck, chickencut, porkCubes, porkChop, salami, ham, bacon, beefRibEye1, beefRibEye2, beefSirloin As Decimal

        Dim uloNgAno, hito, mayaMaya, tukingan, espada, matangBaka, dalagangBukid, tuna, bangus, tilapia As Decimal

        If CheckBox1.Checked Then sardinasLigo = 25.0 * NumericUpDown1.Value
        If CheckBox2.Checked Then sardinas555 = 23.0 * NumericUpDown2.Value
        If CheckBox3.Checked Then tunacan = 35.0 * NumericUpDown3.Value
        If CheckBox4.Checked Then argentina = 35.0 * NumericUpDown4.Value
        If CheckBox5.Checked Then straCorned = 30.0 * NumericUpDown5.Value
        If CheckBox6.Checked Then hekkaido = 25.0 * NumericUpDown6.Value
        If CheckBox7.Checked Then sanMarino = 45.0 * NumericUpDown7.Value
        If CheckBox8.Checked Then sabaSalmon = 35.0 * NumericUpDown8.Value
        If CheckBox9.Checked Then spam = 120.0 * NumericUpDown9.Value
        If CheckBox10.Checked Then delimodo = 180.0 * NumericUpDown10.Value

        If CheckBox11.Checked Then chickenNeck = 100 * NumericUpDown11.Value
        If CheckBox12.Checked Then chickencut = 180 * NumericUpDown12.Value
        If CheckBox13.Checked Then porkCubes = 310 * NumericUpDown13.Value
        If CheckBox14.Checked Then porkChop = 310 * NumericUpDown14.Value
        If CheckBox15.Checked Then salami = 290 * NumericUpDown15.Value
        If CheckBox16.Checked Then ham = 290 * NumericUpDown16.Value
        If CheckBox17.Checked Then bacon = 290 * NumericUpDown17.Value
        If CheckBox18.Checked Then beefRibEye1 = 320 * NumericUpDown18.Value
        If CheckBox19.Checked Then beefRibEye2 = 320 * NumericUpDown19.Value
        If CheckBox20.Checked Then beefSirloin = 350 * NumericUpDown20.Value

        If CheckBox21.Checked Then uloNgAno = 180 * NumericUpDown21.Value
        If CheckBox22.Checked Then hito = 180 * NumericUpDown22.Value
        If CheckBox23.Checked Then mayaMaya = 250 * NumericUpDown23.Value
        If CheckBox24.Checked Then tukingan = 180 * NumericUpDown24.Value
        If CheckBox25.Checked Then espada = 200 * NumericUpDown25.Value
        If CheckBox26.Checked Then matangBaka = 200 * NumericUpDown26.Value
        If CheckBox27.Checked Then dalagangBukid = 220 * NumericUpDown27.Value
        If CheckBox28.Checked Then tuna = 520 * NumericUpDown28.Value
        If CheckBox29.Checked Then bangus = 180 * NumericUpDown29.Value
        If CheckBox30.Checked Then tilapia = 160 * NumericUpDown30.Value


        total = sardinas555 + sardinasLigo + tunacan + argentina + straCorned + hekkaido + sanMarino + sabaSalmon + spam + delimodo +
                uloNgAno + chickencut + mayaMaya + tukingan + espada + matangBaka + dalagangBukid + tuna + bangus + tilapia +
                chickenNeck + hito + porkCubes + porkChop + salami + ham + bacon + beefRibEye1 + beefRibEye2 + beefSirloin

        Label9.Text = total.ToString("0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim less As Decimal

        If Not Decimal.TryParse(TextBox2.Text, Nothing) Then
            Label5.Text = "Please Enter an Amount"
        Else
            If TextBox2.Text >= total Then
                payment = TextBox2.Text - total
                Label12.Text = payment.ToString("0.00")
                Label5.Text = " "
                Label5.Text = ": )"
            ElseIf TextBox2.Text = 0 Then
                Label5.Text = "Please Enter an Amount"
            Else
                less = total - TextBox2.Text
                Label5.Text = "Kulang Boss ng ₱" & less.ToString("0.00")
                Label12.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso TextBox2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

End Class