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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonUtf2Zebra = New System.Windows.Forms.Button()
        Me.TextBoxUTFInput = New System.Windows.Forms.TextBox()
        Me.TextBoxZebraOutput = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxPrevSamples = New System.Windows.Forms.ComboBox()
        Me.TextBoxPrevSample = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownW = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownH = New System.Windows.Forms.NumericUpDown()
        Me.PictureBoxLabel = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.NumericUpDownW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(899, 650)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(891, 624)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "UTF to ZebraCode"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxUTFInput, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxZebraOutput, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(885, 618)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonUtf2Zebra, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 559)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(879, 56)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ButtonUtf2Zebra
        '
        Me.ButtonUtf2Zebra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUtf2Zebra.Location = New System.Drawing.Point(703, 3)
        Me.ButtonUtf2Zebra.Name = "ButtonUtf2Zebra"
        Me.ButtonUtf2Zebra.Size = New System.Drawing.Size(173, 50)
        Me.ButtonUtf2Zebra.TabIndex = 0
        Me.ButtonUtf2Zebra.Text = "Generate"
        Me.ButtonUtf2Zebra.UseVisualStyleBackColor = True
        '
        'TextBoxUTFInput
        '
        Me.TextBoxUTFInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUTFInput.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxUTFInput.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxUTFInput.Multiline = True
        Me.TextBoxUTFInput.Name = "TextBoxUTFInput"
        Me.TextBoxUTFInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxUTFInput.Size = New System.Drawing.Size(879, 272)
        Me.TextBoxUTFInput.TabIndex = 1
        '
        'TextBoxZebraOutput
        '
        Me.TextBoxZebraOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxZebraOutput.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxZebraOutput.Location = New System.Drawing.Point(3, 281)
        Me.TextBoxZebraOutput.Multiline = True
        Me.TextBoxZebraOutput.Name = "TextBoxZebraOutput"
        Me.TextBoxZebraOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxZebraOutput.Size = New System.Drawing.Size(879, 272)
        Me.TextBoxZebraOutput.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(891, 624)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Calculator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(891, 624)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Previewer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.70595!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.29405!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxPrevSamples, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxPrevSample, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(891, 624)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ComboBoxPrevSamples
        '
        Me.ComboBoxPrevSamples.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPrevSamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPrevSamples.FormattingEnabled = True
        Me.ComboBoxPrevSamples.Location = New System.Drawing.Point(730, 3)
        Me.ComboBoxPrevSamples.Name = "ComboBoxPrevSamples"
        Me.ComboBoxPrevSamples.Size = New System.Drawing.Size(158, 21)
        Me.ComboBoxPrevSamples.TabIndex = 0
        '
        'TextBoxPrevSample
        '
        Me.TextBoxPrevSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPrevSample.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxPrevSample.Multiline = True
        Me.TextBoxPrevSample.Name = "TextBoxPrevSample"
        Me.TextBoxPrevSample.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxPrevSample.Size = New System.Drawing.Size(721, 306)
        Me.TextBoxPrevSample.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonPreview, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonPrint, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBoxPrinter, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(730, 315)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(158, 306)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'ButtonPreview
        '
        Me.ButtonPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPreview.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(152, 70)
        Me.ButtonPreview.TabIndex = 0
        Me.ButtonPreview.Text = "Preview"
        Me.ButtonPreview.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrint.Location = New System.Drawing.Point(3, 155)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(152, 70)
        Me.ButtonPrint.TabIndex = 1
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ComboBoxPrinter
        '
        Me.ComboBoxPrinter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ComboBoxPrinter.FormattingEnabled = True
        Me.ComboBoxPrinter.Location = New System.Drawing.Point(3, 128)
        Me.ComboBoxPrinter.Name = "ComboBoxPrinter"
        Me.ComboBoxPrinter.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxPrinter.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.35645!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64355!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBoxLabel, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 315)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(721, 306)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.NumericUpDownW, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.NumericUpDownH, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(604, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(114, 300)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(16, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 60)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Height:"
        '
        'NumericUpDownW
        '
        Me.NumericUpDownW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownW.Location = New System.Drawing.Point(60, 3)
        Me.NumericUpDownW.Name = "NumericUpDownW"
        Me.NumericUpDownW.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDownW.TabIndex = 4
        Me.NumericUpDownW.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'NumericUpDownH
        '
        Me.NumericUpDownH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownH.Location = New System.Drawing.Point(60, 63)
        Me.NumericUpDownH.Name = "NumericUpDownH"
        Me.NumericUpDownH.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDownH.TabIndex = 5
        Me.NumericUpDownH.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'PictureBoxLabel
        '
        Me.PictureBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxLabel.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxLabel.Name = "PictureBoxLabel"
        Me.PictureBoxLabel.Size = New System.Drawing.Size(595, 300)
        Me.PictureBoxLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLabel.TabIndex = 1
        Me.PictureBoxLabel.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 650)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "ZPL Mate"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.NumericUpDownW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonUtf2Zebra As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxUTFInput As TextBox
    Friend WithEvents TextBoxZebraOutput As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ComboBoxPrevSamples As ComboBox
    Friend WithEvents TextBoxPrevSample As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ButtonPreview As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ComboBoxPrinter As ComboBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownW As NumericUpDown
    Friend WithEvents NumericUpDownH As NumericUpDown
    Friend WithEvents PictureBoxLabel As PictureBox
End Class
