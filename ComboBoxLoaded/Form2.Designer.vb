<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        gbox = New GroupBox()
        btnE = New Button()
        btnC = New Button()
        btnR = New Button()
        lblItems = New Label()
        lblCount = New Label()
        btnA = New Button()
        lstN = New ListBox()
        txtN = New TextBox()
        lblName = New Label()
        gbox.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbox
        ' 
        gbox.Controls.Add(btnE)
        gbox.Controls.Add(btnC)
        gbox.Controls.Add(btnR)
        gbox.Controls.Add(lblItems)
        gbox.Controls.Add(lblCount)
        gbox.Controls.Add(btnA)
        gbox.Controls.Add(lstN)
        gbox.Controls.Add(txtN)
        gbox.Controls.Add(lblName)
        gbox.FlatStyle = FlatStyle.Popup
        gbox.Location = New Point(12, 10)
        gbox.Name = "gbox"
        gbox.Size = New Size(513, 308)
        gbox.TabIndex = 0
        gbox.TabStop = False
        ' 
        ' btnE
        ' 
        btnE.Location = New Point(372, 229)
        btnE.Name = "btnE"
        btnE.Size = New Size(88, 33)
        btnE.TabIndex = 8
        btnE.Text = "&Exit"
        btnE.UseVisualStyleBackColor = True
        ' 
        ' btnC
        ' 
        btnC.Location = New Point(372, 169)
        btnC.Name = "btnC"
        btnC.Size = New Size(88, 33)
        btnC.TabIndex = 7
        btnC.Text = "&Clear"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' btnR
        ' 
        btnR.Location = New Point(372, 109)
        btnR.Name = "btnR"
        btnR.Size = New Size(88, 33)
        btnR.TabIndex = 6
        btnR.Text = "&Remove"
        btnR.UseVisualStyleBackColor = True
        ' 
        ' lblItems
        ' 
        lblItems.BackColor = SystemColors.ControlDark
        lblItems.BorderStyle = BorderStyle.Fixed3D
        lblItems.Location = New Point(176, 255)
        lblItems.Name = "lblItems"
        lblItems.Size = New Size(100, 22)
        lblItems.TabIndex = 5
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCount.Location = New Point(23, 256)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(113, 17)
        lblCount.TabIndex = 4
        lblCount.Text = "< Items Count: >"
        ' 
        ' btnA
        ' 
        btnA.Location = New Point(372, 51)
        btnA.Name = "btnA"
        btnA.Size = New Size(88, 33)
        btnA.TabIndex = 3
        btnA.Text = "&ADD"
        btnA.UseVisualStyleBackColor = True
        ' 
        ' lstN
        ' 
        lstN.FormattingEnabled = True
        lstN.ItemHeight = 15
        lstN.Location = New Point(23, 99)
        lstN.Name = "lstN"
        lstN.Size = New Size(252, 139)
        lstN.TabIndex = 2
        ' 
        ' txtN
        ' 
        txtN.Location = New Point(24, 56)
        txtN.Name = "txtN"
        txtN.Size = New Size(251, 23)
        txtN.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblName.Location = New Point(20, 31)
        lblName.Name = "lblName"
        lblName.Size = New Size(117, 21)
        lblName.TabIndex = 0
        lblName.Text = "Enter a Name:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(537, 330)
        Controls.Add(gbox)
        Name = "Form2"
        Text = "Working with list boxes"
        gbox.ResumeLayout(False)
        gbox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbox As GroupBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents btnA As Button
    Friend WithEvents lstN As ListBox
    Friend WithEvents btnE As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnR As Button
End Class
