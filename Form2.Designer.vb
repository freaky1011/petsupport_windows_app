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
        Me.Next1 = New System.Windows.Forms.Button()
        Me.Previous1 = New System.Windows.Forms.Button()
        Me.Skip1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Finish1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Next1
        '
        Me.Next1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Next1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Next1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Next1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Next1.Location = New System.Drawing.Point(442, 190)
        Me.Next1.Name = "Next1"
        Me.Next1.Size = New System.Drawing.Size(75, 60)
        Me.Next1.TabIndex = 2
        Me.Next1.Text = ">"
        Me.Next1.UseVisualStyleBackColor = False
        '
        'Previous1
        '
        Me.Previous1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Previous1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Previous1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Previous1.Location = New System.Drawing.Point(31, 190)
        Me.Previous1.Name = "Previous1"
        Me.Previous1.Size = New System.Drawing.Size(79, 60)
        Me.Previous1.TabIndex = 3
        Me.Previous1.Text = "<"
        Me.Previous1.UseVisualStyleBackColor = False
        '
        'Skip1
        '
        Me.Skip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Skip1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Skip1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Skip1.Location = New System.Drawing.Point(31, 410)
        Me.Skip1.Name = "Skip1"
        Me.Skip1.Size = New System.Drawing.Size(79, 35)
        Me.Skip1.TabIndex = 4
        Me.Skip1.Text = "Skip"
        Me.Skip1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(580, 475)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Finish1
        '
        Me.Finish1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Finish1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Finish1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Finish1.Location = New System.Drawing.Point(442, 410)
        Me.Finish1.Name = "Finish1"
        Me.Finish1.Size = New System.Drawing.Size(79, 35)
        Me.Finish1.TabIndex = 6
        Me.Finish1.Text = "Finish"
        Me.Finish1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(578, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.Finish1)
        Me.Controls.Add(Me.Next1)
        Me.Controls.Add(Me.Previous1)
        Me.Controls.Add(Me.Skip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HousePetSupport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Next1 As Button
    Friend WithEvents Previous1 As Button
    Friend WithEvents Skip1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Finish1 As Button
End Class
