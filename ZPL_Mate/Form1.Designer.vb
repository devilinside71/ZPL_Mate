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
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxResolution = New System.Windows.Forms.ComboBox()
        Me.TextBoxResolutionDpmm = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxUnit = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxW = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxH = New System.Windows.Forms.TextBox()
        Me.ButtonCalcLabel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxW1 = New System.Windows.Forms.TextBox()
        Me.TextBoxW2 = New System.Windows.Forms.TextBox()
        Me.LabelCalcW1 = New System.Windows.Forms.Label()
        Me.LabelCalcW2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxH1 = New System.Windows.Forms.TextBox()
        Me.TextBoxH2 = New System.Windows.Forms.TextBox()
        Me.LabelCalcH1 = New System.Windows.Forms.Label()
        Me.LabelCalcH2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxPrevSamples = New System.Windows.Forms.ComboBox()
        Me.TextBoxPrevSample = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.ButtonZPLGuide = New System.Windows.Forms.Button()
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
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
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
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(891, 624)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Calculator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 4
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(885, 618)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Label"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel11, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(873, 129)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel10, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(430, 123)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(152, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 123)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resolution:"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.ComboBoxResolution, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TextBoxResolutionDpmm, 0, 1)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(218, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(209, 117)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'ComboBoxResolution
        '
        Me.ComboBoxResolution.FormattingEnabled = True
        Me.ComboBoxResolution.Items.AddRange(New Object() {"203dpi", "300dpi"})
        Me.ComboBoxResolution.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxResolution.Name = "ComboBoxResolution"
        Me.ComboBoxResolution.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxResolution.TabIndex = 0
        '
        'TextBoxResolutionDpmm
        '
        Me.TextBoxResolutionDpmm.Location = New System.Drawing.Point(3, 61)
        Me.TextBoxResolutionDpmm.Name = "TextBoxResolutionDpmm"
        Me.TextBoxResolutionDpmm.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxResolutionDpmm.TabIndex = 1
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.ComboBoxUnit, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel12, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel13, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.ButtonCalcLabel, 2, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel14, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel15, 1, 1)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(439, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.55704!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.44296!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(431, 123)
        Me.TableLayoutPanel11.TabIndex = 1
        '
        'ComboBoxUnit
        '
        Me.ComboBoxUnit.FormattingEnabled = True
        Me.ComboBoxUnit.Items.AddRange(New Object() {"mm", "inch", "dot"})
        Me.ComboBoxUnit.Location = New System.Drawing.Point(347, 3)
        Me.ComboBoxUnit.Name = "ComboBoxUnit"
        Me.ComboBoxUnit.Size = New System.Drawing.Size(81, 21)
        Me.ComboBoxUnit.TabIndex = 0
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.TextBoxW, 1, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(166, 35)
        Me.TableLayoutPanel12.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Width:"
        '
        'TextBoxW
        '
        Me.TextBoxW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxW.Location = New System.Drawing.Point(86, 3)
        Me.TextBoxW.Name = "TextBoxW"
        Me.TextBoxW.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxW.TabIndex = 1
        Me.TextBoxW.Text = "90"
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.TextBoxH, 1, 0)
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(175, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(166, 35)
        Me.TableLayoutPanel13.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Height:"
        '
        'TextBoxH
        '
        Me.TextBoxH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxH.Location = New System.Drawing.Point(86, 3)
        Me.TextBoxH.Name = "TextBoxH"
        Me.TextBoxH.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxH.TabIndex = 1
        Me.TextBoxH.Text = "50"
        '
        'ButtonCalcLabel
        '
        Me.ButtonCalcLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCalcLabel.Location = New System.Drawing.Point(347, 44)
        Me.ButtonCalcLabel.Name = "ButtonCalcLabel"
        Me.ButtonCalcLabel.Size = New System.Drawing.Size(81, 76)
        Me.ButtonCalcLabel.TabIndex = 3
        Me.ButtonCalcLabel.Text = "Calc"
        Me.ButtonCalcLabel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.TextBoxW1, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.TextBoxW2, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.LabelCalcW1, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.LabelCalcW2, 1, 1)
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 44)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(166, 76)
        Me.TableLayoutPanel14.TabIndex = 4
        '
        'TextBoxW1
        '
        Me.TextBoxW1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxW1.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxW1.Name = "TextBoxW1"
        Me.TextBoxW1.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxW1.TabIndex = 0
        '
        'TextBoxW2
        '
        Me.TextBoxW2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxW2.Location = New System.Drawing.Point(3, 41)
        Me.TextBoxW2.Name = "TextBoxW2"
        Me.TextBoxW2.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxW2.TabIndex = 1
        '
        'LabelCalcW1
        '
        Me.LabelCalcW1.AutoSize = True
        Me.LabelCalcW1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelCalcW1.Location = New System.Drawing.Point(86, 0)
        Me.LabelCalcW1.Name = "LabelCalcW1"
        Me.LabelCalcW1.Size = New System.Drawing.Size(39, 38)
        Me.LabelCalcW1.TabIndex = 2
        Me.LabelCalcW1.Text = "Label6"
        '
        'LabelCalcW2
        '
        Me.LabelCalcW2.AutoSize = True
        Me.LabelCalcW2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelCalcW2.Location = New System.Drawing.Point(86, 38)
        Me.LabelCalcW2.Name = "LabelCalcW2"
        Me.LabelCalcW2.Size = New System.Drawing.Size(39, 38)
        Me.LabelCalcW2.TabIndex = 3
        Me.LabelCalcW2.Text = "Label8"
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.TextBoxH1, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.TextBoxH2, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.LabelCalcH1, 1, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.LabelCalcH2, 1, 1)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(175, 44)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(166, 76)
        Me.TableLayoutPanel15.TabIndex = 5
        '
        'TextBoxH1
        '
        Me.TextBoxH1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxH1.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxH1.Name = "TextBoxH1"
        Me.TextBoxH1.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxH1.TabIndex = 0
        '
        'TextBoxH2
        '
        Me.TextBoxH2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxH2.Location = New System.Drawing.Point(3, 41)
        Me.TextBoxH2.Name = "TextBoxH2"
        Me.TextBoxH2.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxH2.TabIndex = 1
        '
        'LabelCalcH1
        '
        Me.LabelCalcH1.AutoSize = True
        Me.LabelCalcH1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelCalcH1.Location = New System.Drawing.Point(86, 0)
        Me.LabelCalcH1.Name = "LabelCalcH1"
        Me.LabelCalcH1.Size = New System.Drawing.Size(39, 38)
        Me.LabelCalcH1.TabIndex = 2
        Me.LabelCalcH1.Text = "Label7"
        '
        'LabelCalcH2
        '
        Me.LabelCalcH2.AutoSize = True
        Me.LabelCalcH2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelCalcH2.Location = New System.Drawing.Point(86, 38)
        Me.LabelCalcH2.Name = "LabelCalcH2"
        Me.LabelCalcH2.Size = New System.Drawing.Size(39, 38)
        Me.LabelCalcH2.TabIndex = 3
        Me.LabelCalcH2.Text = "Label9"
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
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonZPLGuide, 0, 3)
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
        'ButtonZPLGuide
        '
        Me.ButtonZPLGuide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonZPLGuide.Location = New System.Drawing.Point(3, 231)
        Me.ButtonZPLGuide.Name = "ButtonZPLGuide"
        Me.ButtonZPLGuide.Size = New System.Drawing.Size(152, 72)
        Me.ButtonZPLGuide.TabIndex = 3
        Me.ButtonZPLGuide.Text = "ZPL Programming Guide"
        Me.ButtonZPLGuide.UseVisualStyleBackColor = True
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
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
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
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents ComboBoxResolution As ComboBox
    Friend WithEvents TextBoxResolutionDpmm As TextBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents ComboBoxUnit As ComboBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxW As TextBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxH As TextBox
    Friend WithEvents ButtonCalcLabel As Button
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents TextBoxW1 As TextBox
    Friend WithEvents TextBoxW2 As TextBox
    Friend WithEvents LabelCalcW1 As Label
    Friend WithEvents LabelCalcW2 As Label
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents TextBoxH1 As TextBox
    Friend WithEvents TextBoxH2 As TextBox
    Friend WithEvents LabelCalcH1 As Label
    Friend WithEvents LabelCalcH2 As Label
    Friend WithEvents ButtonZPLGuide As Button
End Class
