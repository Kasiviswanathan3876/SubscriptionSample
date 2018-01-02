<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSubscribe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubscribe
        '
        Me.btnSubscribe.Location = New System.Drawing.Point(60, 62)
        Me.btnSubscribe.Name = "btnSubscribe"
        Me.btnSubscribe.Size = New System.Drawing.Size(75, 23)
        Me.btnSubscribe.TabIndex = 0
        Me.btnSubscribe.Text = "Subscribe"
        Me.btnSubscribe.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSubscribe)
        Me.Name = "frmMain"
        Me.Text = "Main App"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubscribe As Button
End Class
