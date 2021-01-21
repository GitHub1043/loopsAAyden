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
        Me.btnOver = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOver
        '
        Me.btnOver.Location = New System.Drawing.Point(105, 44)
        Me.btnOver.Name = "btnOver"
        Me.btnOver.Size = New System.Drawing.Size(75, 23)
        Me.btnOver.TabIndex = 0
        Me.btnOver.Text = "Over 3"
        Me.btnOver.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(105, 119)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll 12"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(105, 194)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(75, 23)
        Me.btnSimulate.TabIndex = 2
        Me.btnSimulate.Text = "Simulate 12"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSimulate)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnOver)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOver As System.Windows.Forms.Button
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents btnSimulate As System.Windows.Forms.Button

End Class
