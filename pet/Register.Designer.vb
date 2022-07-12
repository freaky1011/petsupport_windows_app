<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Rregister1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rregister2 = New System.Windows.Forms.Button()
        Me.PassTbox = New System.Windows.Forms.TextBox()
        Me.UserTbox = New System.Windows.Forms.TextBox()
        Me.none = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(142, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 50)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "           Create your account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " It's free and only it takes a minute!"
        '
        'Rregister1
        '
        Me.Rregister1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rregister1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Rregister1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Rregister1.Location = New System.Drawing.Point(339, 396)
        Me.Rregister1.Name = "Rregister1"
        Me.Rregister1.Size = New System.Drawing.Size(85, 29)
        Me.Rregister1.TabIndex = 7
        Me.Rregister1.Text = "Sign-in"
        Me.Rregister1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(190, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Already have an account?"
        '
        'Rregister2
        '
        Me.Rregister2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rregister2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Rregister2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Rregister2.Location = New System.Drawing.Point(241, 296)
        Me.Rregister2.Name = "Rregister2"
        Me.Rregister2.Size = New System.Drawing.Size(92, 35)
        Me.Rregister2.TabIndex = 5
        Me.Rregister2.Text = "Register"
        Me.Rregister2.UseVisualStyleBackColor = False
        '
        'PassTbox
        '
        Me.PassTbox.Location = New System.Drawing.Point(190, 267)
        Me.PassTbox.MaxLength = 21
        Me.PassTbox.Name = "PassTbox"
        Me.PassTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTbox.Size = New System.Drawing.Size(188, 23)
        Me.PassTbox.TabIndex = 4
        '
        'UserTbox
        '
        Me.UserTbox.Location = New System.Drawing.Point(190, 189)
        Me.UserTbox.MaxLength = 21
        Me.UserTbox.Name = "UserTbox"
        Me.UserTbox.Size = New System.Drawing.Size(188, 23)
        Me.UserTbox.TabIndex = 3
        '
        'none
        '
        Me.none.AutoSize = True
        Me.none.Location = New System.Drawing.Point(190, 238)
        Me.none.Name = "none"
        Me.none.Size = New System.Drawing.Size(57, 15)
        Me.none.TabIndex = 2
        Me.none.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 475)
        Me.Controls.Add(Me.PassTbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.none)
        Me.Controls.Add(Me.UserTbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Rregister1)
        Me.Controls.Add(Me.Rregister2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Rregister1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Rregister2 As Button
    Friend WithEvents PassTbox As TextBox
    Friend WithEvents UserTbox As TextBox
    Friend WithEvents none As Label
    Friend WithEvents Label2 As Label
End Class
