<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kinds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kinds))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KindBack = New System.Windows.Forms.Button()
        Me.Rabbits = New System.Windows.Forms.Button()
        Me.Fishs = New System.Windows.Forms.Button()
        Me.Dogs1 = New System.Windows.Forms.Button()
        Me.Cats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.KindBack)
        Me.Panel1.Controls.Add(Me.Rabbits)
        Me.Panel1.Controls.Add(Me.Fishs)
        Me.Panel1.Controls.Add(Me.Dogs1)
        Me.Panel1.Controls.Add(Me.Cats)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 1026)
        Me.Panel1.TabIndex = 0
        '
        'KindBack
        '
        Me.KindBack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.KindBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.KindBack.Location = New System.Drawing.Point(0, 24)
        Me.KindBack.Name = "KindBack"
        Me.KindBack.Size = New System.Drawing.Size(33, 31)
        Me.KindBack.TabIndex = 7
        Me.KindBack.Text = "<"
        Me.KindBack.UseVisualStyleBackColor = False
        '
        'Rabbits
        '
        Me.Rabbits.BackgroundImage = CType(resources.GetObject("Rabbits.BackgroundImage"), System.Drawing.Image)
        Me.Rabbits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rabbits.FlatAppearance.BorderSize = 0
        Me.Rabbits.Location = New System.Drawing.Point(111, 783)
        Me.Rabbits.Name = "Rabbits"
        Me.Rabbits.Size = New System.Drawing.Size(318, 193)
        Me.Rabbits.TabIndex = 6
        Me.Rabbits.UseVisualStyleBackColor = True
        '
        'Fishs
        '
        Me.Fishs.BackgroundImage = CType(resources.GetObject("Fishs.BackgroundImage"), System.Drawing.Image)
        Me.Fishs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Fishs.FlatAppearance.BorderSize = 0
        Me.Fishs.Location = New System.Drawing.Point(111, 554)
        Me.Fishs.Name = "Fishs"
        Me.Fishs.Size = New System.Drawing.Size(318, 193)
        Me.Fishs.TabIndex = 5
        Me.Fishs.UseVisualStyleBackColor = True
        '
        'Dogs1
        '
        Me.Dogs1.BackgroundImage = CType(resources.GetObject("Dogs1.BackgroundImage"), System.Drawing.Image)
        Me.Dogs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dogs1.FlatAppearance.BorderSize = 0
        Me.Dogs1.Location = New System.Drawing.Point(111, 332)
        Me.Dogs1.Name = "Dogs1"
        Me.Dogs1.Size = New System.Drawing.Size(318, 193)
        Me.Dogs1.TabIndex = 3
        Me.Dogs1.UseVisualStyleBackColor = True
        '
        'Cats
        '
        Me.Cats.BackgroundImage = CType(resources.GetObject("Cats.BackgroundImage"), System.Drawing.Image)
        Me.Cats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cats.FlatAppearance.BorderSize = 0
        Me.Cats.Location = New System.Drawing.Point(111, 99)
        Me.Cats.Name = "Cats"
        Me.Cats.Size = New System.Drawing.Size(318, 193)
        Me.Cats.TabIndex = 2
        Me.Cats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pick your Pet:"
        '
        'Kinds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(578, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Kinds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kinds"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dog As Button
    Friend WithEvents Rabbits As Button
    Friend WithEvents Fishs As Button
    Friend WithEvents Dogs1 As Button
    Friend WithEvents Cats As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents KindBack As Button
End Class
