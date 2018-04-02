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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonOyna = New System.Windows.Forms.Button()
        Me.ımageListSans = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ımageListSans
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.MaximumSize = New System.Drawing.Size(75, 75)
        Me.Button1.MinimumSize = New System.Drawing.Size(75, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageIndex = 1
        Me.Button2.ImageList = Me.ımageListSans
        Me.Button2.Location = New System.Drawing.Point(130, 12)
        Me.Button2.MaximumSize = New System.Drawing.Size(75, 75)
        Me.Button2.MinimumSize = New System.Drawing.Size(75, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 75)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ImageIndex = 2
        Me.Button3.ImageList = Me.ımageListSans
        Me.Button3.Location = New System.Drawing.Point(245, 12)
        Me.Button3.MaximumSize = New System.Drawing.Size(75, 75)
        Me.Button3.MinimumSize = New System.Drawing.Size(75, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 75)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonOyna
        '
        Me.ButtonOyna.Location = New System.Drawing.Point(12, 93)
        Me.ButtonOyna.Name = "ButtonOyna"
        Me.ButtonOyna.Size = New System.Drawing.Size(308, 42)
        Me.ButtonOyna.TabIndex = 3
        Me.ButtonOyna.Text = "Oyna"
        Me.ButtonOyna.UseVisualStyleBackColor = True
        '
        'ımageListSans
        '
        Me.ımageListSans.ImageStream = CType(resources.GetObject("ımageListSans.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageListSans.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageListSans.Images.SetKeyName(0, "kiraz.png")
        Me.ımageListSans.Images.SetKeyName(1, "limon.png")
        Me.ımageListSans.Images.SetKeyName(2, "muz.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 253)
        Me.Controls.Add(Me.ButtonOyna)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonOyna As System.Windows.Forms.Button
    Friend WithEvents ımageListSans As System.Windows.Forms.ImageList

End Class
