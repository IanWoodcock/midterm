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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picHouse = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpBtns = New System.Windows.Forms.GroupBox()
        Me.rbtnMToIn = New System.Windows.Forms.RadioButton()
        Me.rbtnInToM = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.picHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'picHouse
        '
        Me.picHouse.Image = CType(resources.GetObject("picHouse.Image"), System.Drawing.Image)
        Me.picHouse.Location = New System.Drawing.Point(-1, 12)
        Me.picHouse.Name = "picHouse"
        Me.picHouse.Size = New System.Drawing.Size(269, 167)
        Me.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHouse.TabIndex = 0
        Me.picHouse.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(330, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(263, 47)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Converter App"
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruct.Location = New System.Drawing.Point(330, 115)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(214, 96)
        Me.lblInstruct.TabIndex = 2
        Me.lblInstruct.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Indigo
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInput.ForeColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(581, 118)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(108, 33)
        Me.txtInput.TabIndex = 3
        '
        'grpBtns
        '
        Me.grpBtns.BackColor = System.Drawing.Color.Indigo
        Me.grpBtns.Controls.Add(Me.rbtnMToIn)
        Me.grpBtns.Controls.Add(Me.rbtnInToM)
        Me.grpBtns.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpBtns.ForeColor = System.Drawing.Color.White
        Me.grpBtns.Location = New System.Drawing.Point(393, 199)
        Me.grpBtns.Name = "grpBtns"
        Me.grpBtns.Size = New System.Drawing.Size(254, 99)
        Me.grpBtns.TabIndex = 4
        Me.grpBtns.TabStop = False
        Me.grpBtns.Text = "Convert Measurement"
        '
        'rbtnMToIn
        '
        Me.rbtnMToIn.AutoSize = True
        Me.rbtnMToIn.Location = New System.Drawing.Point(7, 59)
        Me.rbtnMToIn.Name = "rbtnMToIn"
        Me.rbtnMToIn.Size = New System.Drawing.Size(169, 29)
        Me.rbtnMToIn.TabIndex = 1
        Me.rbtnMToIn.Text = "Meters to Inches"
        Me.rbtnMToIn.UseVisualStyleBackColor = True
        '
        'rbtnInToM
        '
        Me.rbtnInToM.AutoSize = True
        Me.rbtnInToM.Checked = True
        Me.rbtnInToM.Location = New System.Drawing.Point(7, 33)
        Me.rbtnInToM.Name = "rbtnInToM"
        Me.rbtnInToM.Size = New System.Drawing.Size(169, 29)
        Me.rbtnInToM.TabIndex = 0
        Me.rbtnInToM.TabStop = True
        Me.rbtnInToM.Text = "Inches to Meters"
        Me.rbtnInToM.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnConvert.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConvert.Location = New System.Drawing.Point(36, 379)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(178, 44)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(309, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(178, 44)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(582, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 44)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.Location = New System.Drawing.Point(400, 325)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 25)
        Me.lblOutput.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpBtns)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picHouse)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.picHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBtns.ResumeLayout(False)
        Me.grpBtns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picHouse As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruct As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents grpBtns As GroupBox
    Friend WithEvents rbtnMToIn As RadioButton
    Friend WithEvents rbtnInToM As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label
End Class
