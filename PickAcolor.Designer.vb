<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickAcolor
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
        Me.YourFavColr = New System.Windows.Forms.Label()
        Me.Red = New System.Windows.Forms.Button()
        Me.Green = New System.Windows.Forms.Button()
        Me.Blue = New System.Windows.Forms.Button()
        Me.DisplayMsg = New System.Windows.Forms.Label()
        Me.Picked = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'YourFavColr
        '
        Me.YourFavColr.AutoSize = True
        Me.YourFavColr.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YourFavColr.Location = New System.Drawing.Point(155, 25)
        Me.YourFavColr.Name = "YourFavColr"
        Me.YourFavColr.Size = New System.Drawing.Size(493, 46)
        Me.YourFavColr.TabIndex = 0
        Me.YourFavColr.Text = "Your Favorite Color Is ..."
        Me.YourFavColr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Red
        '
        Me.Red.Location = New System.Drawing.Point(163, 274)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(98, 41)
        Me.Red.TabIndex = 1
        Me.Red.Text = "Red"
        Me.Red.UseVisualStyleBackColor = True
        '
        'Green
        '
        Me.Green.Location = New System.Drawing.Point(362, 274)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(98, 41)
        Me.Green.TabIndex = 2
        Me.Green.Text = "Green"
        Me.Green.UseVisualStyleBackColor = True
        '
        'Blue
        '
        Me.Blue.Location = New System.Drawing.Point(564, 274)
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(98, 41)
        Me.Blue.TabIndex = 3
        Me.Blue.Text = "Blue"
        Me.Blue.UseVisualStyleBackColor = True
        '
        'DisplayMsg
        '
        Me.DisplayMsg.AutoSize = True
        Me.DisplayMsg.Location = New System.Drawing.Point(160, 392)
        Me.DisplayMsg.Name = "DisplayMsg"
        Me.DisplayMsg.Size = New System.Drawing.Size(160, 17)
        Me.DisplayMsg.TabIndex = 4
        Me.DisplayMsg.Text = "Pick Your Favorite Color"
        '
        'Picked
        '
        Me.Picked.AutoSize = True
        Me.Picked.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picked.Location = New System.Drawing.Point(344, 202)
        Me.Picked.Name = "Picked"
        Me.Picked.Size = New System.Drawing.Size(0, 46)
        Me.Picked.TabIndex = 5
        Me.Picked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PickAcolor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Picked)
        Me.Controls.Add(Me.DisplayMsg)
        Me.Controls.Add(Me.Blue)
        Me.Controls.Add(Me.Green)
        Me.Controls.Add(Me.Red)
        Me.Controls.Add(Me.YourFavColr)
        Me.Name = "PickAcolor"
        Me.Text = "Favorite Color"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YourFavColr As Label
    Friend WithEvents Red As Button
    Friend WithEvents Green As Button
    Friend WithEvents Blue As Button
    Friend WithEvents DisplayMsg As Label
    Friend WithEvents Picked As Label
End Class
