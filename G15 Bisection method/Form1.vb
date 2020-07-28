Public Class Form1
    Dim p10, p9, p8, p7, p6, p5, p4, p3, p2, p1, x, fx, constant, a, b, pos, neg As Double
    Dim n, count As Integer

    Private Sub cp10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CP1.KeyPress, CP10.KeyPress, CP2.KeyPress, CP3.KeyPress, CP4.KeyPress, CP5.KeyPress, CP6.KeyPress, CP7.KeyPress, CP8.KeyPress, CP9.KeyPress, CPconst.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "+" Or e.KeyChar = "-" Or e.KeyChar = "." Or Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("يمكنك فقط ادخال الأرقام و علامات - + . ", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        test004.close.Show()
    End Sub
    Public Sub Swap(Of T)(ByRef d1 As T, ByRef d2 As T)
        Dim d = d2
        d2 = d1
        d1 = d
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CP10.Text = "" Then ''''''''''''''''''''''''''''''''''''''''''''''''''''''تفادي الأخطاء
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP10.Focus()
            Exit Sub
        ElseIf CP9.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP9.Focus()
            Exit Sub
        ElseIf CP8.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP8.Focus()
            Exit Sub
        ElseIf CP7.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP7.Focus()
        ElseIf CP6.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP6.Focus()
        ElseIf CP5.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP5.Focus()
        ElseIf CP4.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP4.Focus()
        ElseIf CP3.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP3.Focus()
        ElseIf CP2.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP2.Focus()
        ElseIf CP1.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CP1.Focus()
        ElseIf CPconst.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            CPconst.Focus()
        ElseIf TextBox14.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            TextBox14.Focus()
        ElseIf TextBox13.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            TextBox13.Focus()
        ElseIf TextBox12.Text = "" Then
            MsgBox("برجاء أدخل البيانات الناقصة", MsgBoxStyle.Information)
            TextBox12.Focus()
            Exit Sub
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''تحديد المدخلات
        p10 = CP10.Text
        p9 = CP9.Text
        p8 = CP8.Text
        p7 = CP7.Text
        p6 = CP6.Text
        p5 = CP5.Text
        p4 = CP4.Text
        p3 = CP3.Text
        p2 = CP2.Text
        p1 = CP1.Text
        constant = CPconst.Text
        count = 2
        a = TextBox12.Text
        b = TextBox13.Text
        n = TextBox14.Text

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' عشان نتأكد إن الفترات صح
        x = a
        fx = (p10 * (x ^ 10)) + (p9 * (x ^ 9)) + (p8 * (x ^ 8)) + (p7 * (x ^ 7)) + (p6 * (x ^ 6)) + (p5 * (x ^ 5)) + (p4 * (x ^ 4)) + (p3 * (x ^ 3)) + (p2 * (x ^ 2)) + (p1 * (x)) + constant
        If fx < 0 Then
            a = a
        Else : Swap(Of Integer)(a, b)
        End If

        '''''''''''''''''''''''''''''''''''''''''''المحاولة الأولى
        x = (a + b) / 2
        TextBox15.Text = ("     iteration" & "  " & "1") & ("    ") & ("a= ") & a & ("    ") & ("b= ") & b & ("    ") & ("The root is  ") & x

        '''''''''''''''''''''''''''''''''''''''''''باقي المحاولات
        Do Until count = n + 1

Equ:        fx = (p10 * (x ^ 10)) + (p9 * (x ^ 9)) + (p8 * (x ^ 8)) + (p7 * (x ^ 7)) + (p6 * (x ^ 6)) + (p5 * (x ^ 5)) + (p4 * (x ^ 4)) + (p3 * (x ^ 3)) + (p2 * (x ^ 2)) + (p1 * (x)) + constant
            If fx < 0 Then
                a = x
                b = b
            ElseIf fx > 0 Then
                b = x
                a = a
           

            End If


            x = (a + b) / 2

            TextBox15.Text += vbNewLine & ("     iteration" & "  " & count) & ("    ") & ("a= ") & a & ("    ") & ("b= ") & b & ("    ") & ("The root is  ") & x
            count += 1
            If count = n + 1 Then

                MsgBox("Final Resualt is   " & x)
                Label15.Text = ("Final Resualt is   " & vbNewLine & vbNewLine & x)
            End If
        Loop


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        test004.Form2.Show()
    End Sub
End Class
