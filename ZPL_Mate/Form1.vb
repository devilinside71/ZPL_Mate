
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.ZebraTL
        Call ZebraPrint.LoadPrinters()
        Call ZebraPrint.LoadLabels()
        ComboBoxPrinter.Items.Clear()
        For Each printername In ZebraPrint.PrinterNames
            ComboBoxPrinter.Items.Add(printername)
        Next
        ComboBoxPrinter.SelectedIndex = 0
        ComboBoxPrevSamples.Items.Clear()
        For Each lb As String In ZebraPrint.LabelNames
            ComboBoxPrevSamples.Items.Add(lb)
        Next
        ComboBoxPrevSamples.SelectedIndex = 0
        Call ZebraPrint.LoadLabels()
        ComboBoxResolution.SelectedIndex = 0
        ComboBoxUnit.SelectedIndex = 0
        Call WriteTextLines()
    End Sub
    ''' <summary>
    ''' Prints label.
    ''' Replaces variables with parameters
    ''' </summary>
    ''' <param name="replacement_text">replacement of variables</param>
    ''' <param name="labelsample_number">which labelsample</param>
    Sub ZPLPrint(replacement_text As String, labelsample_number As Integer)
        Dim strPrinter As String
        Dim strPrintText As String
        Dim res As String



        strPrinter = ZebraPrint.PrinterWinNames(ComboBoxPrinter.SelectedIndex)

        strPrintText = ZebraPrint.LabelCodes(labelsample_number)
        strPrintText = strPrintText.Replace("UTF8STR", replacement_text)
        strPrintText = strPrintText.Replace("UTF8CODE", ZebraPrint.GetZPLutf8Code(replacement_text))

        res = ZebraPrint.SendStringToPrinter(strPrinter, strPrintText)


    End Sub
    ''' <summary>
    ''' Prints label.
    ''' Replaces variables with parameters
    ''' </summary>
    ''' <param name="replacement_text">replacement of variables</param>
    ''' <param name="printer_number">which printer</param>
    ''' <param name="labelsample_number">which labelsample</param>
    Sub ZPLPrint(replacement_text As String, printer_number As Integer, labelsample_number As Integer)
        Dim strPrinter As String
        Dim strPrintText As String
        Dim res As String



        strPrinter = ZebraPrint.PrinterWinNames(printer_number)

        strPrintText = ZebraPrint.LabelCodes(labelsample_number)
        strPrintText = strPrintText.Replace("UTF8STR", replacement_text)
        strPrintText = strPrintText.Replace("UTF8CODE", ZebraPrint.GetZPLutf8Code(replacement_text))

        res = ZebraPrint.SendStringToPrinter(strPrinter, strPrintText)


    End Sub
    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs)
        Call ZPLPrint("Almásrétes", 0, 0)
    End Sub

    Private Sub ButtonUtf2Zebra_Click(sender As Object, e As EventArgs) Handles ButtonUtf2Zebra.Click
        Dim strText As String
        Dim strArray() As String
        Dim i As Integer

        strText = ZebraPrint.GetZPLutf8Code(TextBoxUTFInput.Text) & vbCrLf & vbCrLf
        strText = strText & "http://labelary.com/viewer.html" & vbCrLf & vbCrLf
        strText = strText & "^CWT,E:TT0003M_.FNT" & vbCrLf
        strText = strText & "^CFT,40,30" & vbCrLf
        strText = strText & "^CI28" & vbCrLf

        strArray = Split(TextBoxUTFInput.Text, vbCrLf)
        For i = LBound(strArray) To UBound(strArray)
            strText = strText & "^FT10,90^FH^FD" & ZebraPrint.GetZPLutf8Code(strArray(i)) & "^FS" & vbCrLf
        Next
        TextBoxZebraOutput.Text = strText
    End Sub

    Private Sub ComboBoxPrevSamples_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPrevSamples.SelectedIndexChanged
        TextBoxPrevSample.Text = ZebraPrint.LabelCodes(ComboBoxPrevSamples.SelectedIndex)
    End Sub

    Private Sub ButtonPrint_Click_1(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Dim strPrinter As String
        Dim res As String
        strPrinter = ComboBoxPrinter.Text
        Try
            strPrinter = ZebraPrint.PrinterWinNames(ComboBoxPrinter.SelectedIndex)
        Catch ex As Exception

        End Try
        Debug.Print("Printer:" & strPrinter)
        res = ZebraPrint.SendStringToPrinter(strPrinter, TextBoxPrevSample.Text)
    End Sub

    Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click
        Dim res As String
        Try
            PictureBoxLabel.Image.Dispose()
        Catch ex As Exception
            Console.WriteLine("Error: {0}", ex.Message)
        End Try
        res = ZebraPrint.DownloadLabelaryImage(TextBoxPrevSample.Text, NumericUpDownW.Value, NumericUpDownH.Value, ZebraPrint.ZebraPrintLabelFormat.PNG)
        PictureBoxLabel.Image = Image.FromFile(res)

    End Sub

    Private Sub ComboBoxResolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxResolution.SelectedIndexChanged
        If ComboBoxResolution.SelectedIndex = 0 Then
            TextBoxResolutionDpmm.Text = "8dpmm"
        End If
        If ComboBoxResolution.SelectedIndex = 1 Then
            TextBoxResolutionDpmm.Text = "12dpmm"
        End If
    End Sub

    Private Sub ComboBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUnit.SelectedIndexChanged
        If ComboBoxUnit.SelectedIndex = 1 Then
            LabelCalcH1.Text = "mm"
            LabelCalcW1.Text = "mm"
            LabelCalcH2.Text = "dot"
            LabelCalcW2.Text = "dot"
        End If
        If ComboBoxUnit.SelectedIndex = 0 Then
            LabelCalcH1.Text = "inch"
            LabelCalcW1.Text = "inch"
            LabelCalcH2.Text = "dot"
            LabelCalcW2.Text = "dot"
        End If
        If ComboBoxUnit.SelectedIndex = 2 Then
            LabelCalcH1.Text = "mm"
            LabelCalcW1.Text = "mm"
            LabelCalcH2.Text = "inch"
            LabelCalcW2.Text = "inch"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalcLabel.Click
        If ComboBoxUnit.SelectedIndex = 0 Then
            TextBoxW1.Text = CStr(CDbl(TextBoxW.Text) / 25.4)
            TextBoxH1.Text = CStr(CDbl(TextBoxH.Text) / 25.4)
            If ComboBoxResolution.SelectedIndex = 0 Then
                TextBoxW2.Text = CStr(CDbl(TextBoxW.Text) * 8)
                TextBoxH2.Text = CStr(CDbl(TextBoxH.Text) * 8)
            End If
            If ComboBoxResolution.SelectedIndex = 1 Then
                TextBoxW2.Text = CStr(CDbl(TextBoxW.Text) * 12)
                TextBoxH2.Text = CStr(CDbl(TextBoxH.Text) * 12)
            End If
        End If
        If ComboBoxUnit.SelectedIndex = 1 Then
            TextBoxW1.Text = CStr(CDbl(TextBoxW.Text) * 25.4)
            TextBoxH1.Text = CStr(CDbl(TextBoxH.Text) * 25.4)
            If ComboBoxResolution.SelectedIndex = 0 Then
                TextBoxW2.Text = CStr(CDbl(TextBoxW.Text) * 203)
                TextBoxH2.Text = CStr(CDbl(TextBoxH.Text) * 203)
            End If
            If ComboBoxResolution.SelectedIndex = 1 Then
                TextBoxW2.Text = CStr(CDbl(TextBoxW.Text) * 300)
                TextBoxH2.Text = CStr(CDbl(TextBoxH.Text) * 300)
            End If
        End If
        If ComboBoxUnit.SelectedIndex = 2 Then

            If ComboBoxResolution.SelectedIndex = 0 Then
                TextBoxW1.Text = CStr(CDbl(TextBoxW.Text) / 8)
                TextBoxH1.Text = CStr(CDbl(TextBoxH.Text) / 8)
                TextBoxW2.Text = CStr(CDbl(TextBoxW.Text) / 203)
                TextBoxH2.Text = CStr(CDbl(TextBoxH.Text) / 203)
            End If
            If ComboBoxResolution.SelectedIndex = 1 Then
                TextBoxW1.Text = CStr(CDbl(TextBoxW.Text) / 12)
                TextBoxH1.Text = CStr(CDbl(TextBoxH.Text) / 12)
                TextBoxW2.Text = CStr(CDbl(TextBoxW.Text) / 300)
                TextBoxH2.Text = CStr(CDbl(TextBoxH.Text) / 300)
            End If
        End If
    End Sub

    Private Sub ButtonZPLGuide_Click(sender As Object, e As EventArgs) Handles ButtonZPLGuide.Click
        Process.Start("ZPL Programming Guide.pdf")
    End Sub


    Private Sub TextBoxUTFInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUTFInput.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxZebraOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxZebraOutput.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxPrevSample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrevSample.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub


    Private Sub TextBoxTextLines_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTextLines.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub NumericUpDownTLFontHeight_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownTLFontHeight.ValueChanged
        Call WriteTextLines()
    End Sub


    Private Sub WriteTextLines()
        Dim i As Integer
        Dim intY As Integer
        TextBoxTextLines.Text = "^CFT," & NumericUpDownTLFontHeight.Value & ",15" & vbCrLf
        For i = 0 To 9
            intY = NumericUpDownTLStartY.Value + i * NumericUpDownTLFontHeight.Value + i * NumericUpDownTLRowGap.Value

            TextBoxTextLines.Text = TextBoxTextLines.Text & "^FT50," & intY & "^FH^FDTEXTLINE" & i & "^FS" & vbCrLf
        Next

    End Sub

    Private Sub NumericUpDownTLStartY_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownTLStartY.ValueChanged
        Call WriteTextLines()
    End Sub

    Private Sub NumericUpDownTLRowGap_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownTLRowGap.ValueChanged
        Call WriteTextLines()
    End Sub
End Class
