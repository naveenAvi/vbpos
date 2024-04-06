<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtbpx_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbpx_username
        '
        Me.txtbpx_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbpx_username.DefaultText = ""
        Me.txtbpx_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbpx_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbpx_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbpx_username.DisabledState.Parent = Me.txtbpx_username
        Me.txtbpx_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbpx_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbpx_username.FocusedState.Parent = Me.txtbpx_username
        Me.txtbpx_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbpx_username.HoverState.Parent = Me.txtbpx_username
        Me.txtbpx_username.Location = New System.Drawing.Point(252, 200)
        Me.txtbpx_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbpx_username.Name = "txtbpx_username"
        Me.txtbpx_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbpx_username.PlaceholderText = "Username"
        Me.txtbpx_username.SelectedText = ""
        Me.txtbpx_username.ShadowDecoration.Parent = Me.txtbpx_username
        Me.txtbpx_username.Size = New System.Drawing.Size(342, 50)
        Me.txtbpx_username.TabIndex = 0
        '
        'txtbox_password
        '
        Me.txtbox_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_password.DefaultText = ""
        Me.txtbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_password.DisabledState.Parent = Me.txtbox_password
        Me.txtbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_password.FocusedState.Parent = Me.txtbox_password
        Me.txtbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_password.HoverState.Parent = Me.txtbox_password
        Me.txtbox_password.Location = New System.Drawing.Point(252, 283)
        Me.txtbox_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_password.PlaceholderText = "password"
        Me.txtbox_password.SelectedText = ""
        Me.txtbox_password.ShadowDecoration.Parent = Me.txtbox_password
        Me.txtbox_password.Size = New System.Drawing.Size(342, 51)
        Me.txtbox_password.TabIndex = 1
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtbpx_username)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtbox_password)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(915, 538)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User login"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Black
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(252, 367)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(342, 45)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(916, 539)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtbpx_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
