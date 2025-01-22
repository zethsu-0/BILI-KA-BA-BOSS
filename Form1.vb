Public Class Form1

    Dim total As Integer
    Dim payment As Integer

    Dim sardinasLigo As Integer = 0
    Dim sardinas555 As Integer = 0
    Dim tunacan As Integer = 0
    Dim argentina As Integer = 0
    Dim straCorned As Integer = 0
    Dim hekkaido As Integer = 0
    Dim sanMarino As Integer = 0
    Dim sabaSalmon As Integer = 0
    Dim spam As Integer = 0
    Dim delimodo As Integer = 0
    Dim uloNgAno As Integer = 0
    Dim chickenCut As Integer = 0
    Dim mayaMaya As Integer = 0
    Dim tukingan As Integer = 0
    Dim espada As Integer = 0
    Dim matangBaka As Integer = 0
    Dim dalagangBukid As Integer = 0
    Dim tuna As Integer = 0
    Dim bangus As Integer = 0
    Dim tilapia As Integer = 0
    Dim chickenNeck As Integer = 0
    Dim hito As Integer = 0
    Dim porkCubes As Integer = 0
    Dim porkChop As Integer = 0
    Dim salami As Integer = 0
    Dim ham As Integer = 0
    Dim bacon As Integer = 0
    Dim beefRibEye1 As Integer = 0
    Dim beefRibEye2 As Integer = 0
    Dim beefSirloin As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            sardinasLigo = 25
        End If
        If CheckBox2.Checked Then
            sardinas555 = 23
        End If
        If CheckBox3.Checked Then
            tunacan = 35
        End If
        If CheckBox4.Checked Then
            argentina = 35
        End If
        If CheckBox5.Checked Then
            straCorned = 30
        End If
        If CheckBox6.Checked Then
            hekkaido = 25
        End If
        If CheckBox7.Checked Then
            sanMarino = 45
        End If
        If CheckBox8.Checked Then
            sabaSalmon = 35
        End If
        If CheckBox9.Checked Then
            spam = 120
        End If
        If CheckBox10.Checked Then
            delimodo = 180
        End If

        If CheckBox21.Checked Then
            uloNgAno = 180
        End If

        If CheckBox22.Checked Then
            chickenCut = 180
        End If

        If CheckBox23.Checked Then
            mayaMaya = 250
        End If

        If CheckBox24.Checked Then
            tukingan = 180
        End If

        If CheckBox25.Checked Then
            espada = 200
        End If

        If CheckBox26.Checked Then
            matangBaka = 200
        End If

        If CheckBox27.Checked Then
            dalagangBukid = 220
        End If

        If CheckBox28.Checked Then
            tuna = 520
        End If

        If CheckBox29.Checked Then
            bangus = 180
        End If

        If CheckBox30.Checked Then
            tilapia = 160
        End If

        If CheckBox11.Checked Then
            chickenNeck = 100
        End If

        If CheckBox12.Checked Then
            hito = 180
        End If

        If CheckBox13.Checked Then
            porkCubes = 310
        End If

        If CheckBox14.Checked Then
            porkChop = 310
        End If

        If CheckBox15.Checked Then
            salami = 290
        End If

        If CheckBox16.Checked Then
            ham = 290
        End If

        If CheckBox17.Checked Then
            bacon = 290
        End If

        If CheckBox18.Checked Then
            beefRibEye1 = 320
        End If

        If CheckBox19.Checked Then
            beefRibEye2 = 320
        End If

        If CheckBox20.Checked Then
            beefSirloin = 350
        End If


        total = sardinas555 + sardinasLigo + tunacan + argentina + straCorned + hekkaido + sanMarino + sabaSalmon + spam + delimodo + uloNgAno + chickenCut + mayaMaya + tukingan + espada + matangBaka + dalagangBukid + tuna + bangus + tilapia + chickenNeck + hito + porkCubes + porkChop + salami + ham + bacon + beefRibEye1 + beefRibEye2 + beefSirloin

        TextBox1.Text = total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text >= total Then
            payment = TextBox2.Text - total
            TextBox3.Text = payment
            Label5.Text = " "
        Else
            Label5.Text = "Kulang Boss"
        End If


    End Sub

    Private Sub TextBox2_Keypresser(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class

