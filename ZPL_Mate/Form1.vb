
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

        strPrinter = ZebraPrint.PrinterWinNames(ComboBoxPrinter.SelectedIndex)
        res = ZebraPrint.SendStringToPrinter(strPrinter, TextBoxPrevSample.Text)
    End Sub

    Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click
        Dim res As String
        res = ZebraPrint.DownloadLabelaryImage(TextBoxPrevSample.Text, NumericUpDownW.Value, NumericUpDownH.Value, ZebraPrint.ZebraPrintLabelFormat.PNG)
        PictureBoxLabel.Image = Image.FromFile(res)
    End Sub

End Class
