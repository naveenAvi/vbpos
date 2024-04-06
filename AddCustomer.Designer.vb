<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_lastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_FirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.txt_lastName)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_contact)
        Me.Panel1.Controls.Add(Me.txt_FirstName)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Location = New System.Drawing.Point(254, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 349)
        Me.Panel1.TabIndex = 7
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(72, 268)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(315, 39)
        Me.Guna2Button2.TabIndex = 13
        Me.Guna2Button2.Text = "Cancel"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(422, 268)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(315, 39)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Save"
        '
        'txt_lastName
        '
        Me.txt_lastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lastName.DefaultText = ""
        Me.txt_lastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastName.DisabledState.Parent = Me.txt_lastName
        Me.txt_lastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastName.FocusedState.Parent = Me.txt_lastName
        Me.txt_lastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastName.HoverState.Parent = Me.txt_lastName
        Me.txt_lastName.Location = New System.Drawing.Point(422, 64)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastName.PlaceholderText = "Last Name"
        Me.txt_lastName.SelectedText = ""
        Me.txt_lastName.ShadowDecoration.Parent = Me.txt_lastName
        Me.txt_lastName.Size = New System.Drawing.Size(315, 44)
        Me.txt_lastName.TabIndex = 11
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.Parent = Me.txt_email
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.FocusedState.Parent = Me.txt_email
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.HoverState.Parent = Me.txt_email
        Me.txt_email.Location = New System.Drawing.Point(72, 200)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderText = "Email address"
        Me.txt_email.SelectedText = ""
        Me.txt_email.ShadowDecoration.Parent = Me.txt_email
        Me.txt_email.Size = New System.Drawing.Size(665, 44)
        Me.txt_email.TabIndex = 10
        '
        'txt_contact
        '
        Me.txt_contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contact.DefaultText = ""
        Me.txt_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_contact.DisabledState.Parent = Me.txt_contact
        Me.txt_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contact.FocusedState.Parent = Me.txt_contact
        Me.txt_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contact.HoverState.Parent = Me.txt_contact
        Me.txt_contact.Location = New System.Drawing.Point(72, 136)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.PlaceholderText = "Contact Number"
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.ShadowDecoration.Parent = Me.txt_contact
        Me.txt_contact.Size = New System.Drawing.Size(665, 44)
        Me.txt_contact.TabIndex = 9
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_FirstName.DefaultText = ""
        Me.txt_FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_FirstName.DisabledState.Parent = Me.txt_FirstName
        Me.txt_FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_FirstName.FocusedState.Parent = Me.txt_FirstName
        Me.txt_FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_FirstName.HoverState.Parent = Me.txt_FirstName
        Me.txt_FirstName.Location = New System.Drawing.Point(72, 64)
        Me.txt_FirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_FirstName.PlaceholderText = "First Name"
        Me.txt_FirstName.SelectedText = ""
        Me.txt_FirstName.ShadowDecoration.Parent = Me.txt_FirstName
        Me.txt_FirstName.Size = New System.Drawing.Size(332, 44)
        Me.txt_FirstName.TabIndex = 8
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(67, 19)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(154, 25)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "Add a Customer"
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddCustomer"
        Me.Size = New System.Drawing.Size(1256, 592)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_lastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_FirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_title As Label
End Class
