<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cboNames = New ComboBox()
        lblCity = New Label()
        SuspendLayout()
        ' 
        ' cboNames
        ' 
        cboNames.FormattingEnabled = True
        cboNames.Location = New Point(117, 85)
        cboNames.Name = "cboNames"
        cboNames.Size = New Size(145, 23)
        cboNames.TabIndex = 0
        cboNames.Text = "Select a city"
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Location = New Point(74, 88)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(28, 15)
        lblCity.TabIndex = 1
        lblCity.Text = "City"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(354, 210)
        Controls.Add(lblCity)
        Controls.Add(cboNames)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboNames As ComboBox
    Friend WithEvents lblCity As Label
End Class
