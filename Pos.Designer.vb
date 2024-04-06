<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos
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
        Me.balance_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.customerList = New System.Windows.Forms.ComboBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbox_total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_box_discount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbox_subtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.balance_lbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Guna2TextBox2)
        Me.Panel1.Controls.Add(Me.customerList)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.txtbox_total)
        Me.Panel1.Controls.Add(Me.txt_box_discount)
        Me.Panel1.Controls.Add(Me.txtbox_subtotal)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(972, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 658)
        Me.Panel1.TabIndex = 0
        '
        'balance_lbl
        '
        Me.balance_lbl.AutoSize = True
        Me.balance_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance_lbl.Location = New System.Drawing.Point(220, 576)
        Me.balance_lbl.Name = "balance_lbl"
        Me.balance_lbl.Size = New System.Drawing.Size(58, 29)
        Me.balance_lbl.TabIndex = 15
        Me.balance_lbl.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 576)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Balance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Sub total:"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(225, 518)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Customer Paid"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(210, 44)
        Me.Guna2TextBox2.TabIndex = 11
        '
        'customerList
        '
        Me.customerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerList.FormattingEnabled = True
        Me.customerList.Location = New System.Drawing.Point(223, 339)
        Me.customerList.Name = "customerList"
        Me.customerList.Size = New System.Drawing.Size(211, 33)
        Me.customerList.TabIndex = 10
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(10, 608)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(139, 40)
        Me.Guna2Button2.TabIndex = 9
        Me.Guna2Button2.Text = "Clear"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(276, 608)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(148, 40)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "Proceed"
        '
        'txtbox_total
        '
        Me.txtbox_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_total.DefaultText = ""
        Me.txtbox_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_total.DisabledState.Parent = Me.txtbox_total
        Me.txtbox_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_total.FocusedState.Parent = Me.txtbox_total
        Me.txtbox_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_total.HoverState.Parent = Me.txtbox_total
        Me.txtbox_total.Location = New System.Drawing.Point(225, 469)
        Me.txtbox_total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_total.Name = "txtbox_total"
        Me.txtbox_total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_total.PlaceholderText = "Total"
        Me.txtbox_total.SelectedText = ""
        Me.txtbox_total.ShadowDecoration.Parent = Me.txtbox_total
        Me.txtbox_total.Size = New System.Drawing.Size(208, 44)
        Me.txtbox_total.TabIndex = 7
        '
        'txt_box_discount
        '
        Me.txt_box_discount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_box_discount.DefaultText = ""
        Me.txt_box_discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_box_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_box_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_box_discount.DisabledState.Parent = Me.txt_box_discount
        Me.txt_box_discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_box_discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_box_discount.FocusedState.Parent = Me.txt_box_discount
        Me.txt_box_discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_box_discount.HoverState.Parent = Me.txt_box_discount
        Me.txt_box_discount.Location = New System.Drawing.Point(225, 424)
        Me.txt_box_discount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_box_discount.Name = "txt_box_discount"
        Me.txt_box_discount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_box_discount.PlaceholderText = "Discount %"
        Me.txt_box_discount.SelectedText = ""
        Me.txt_box_discount.ShadowDecoration.Parent = Me.txt_box_discount
        Me.txt_box_discount.Size = New System.Drawing.Size(208, 44)
        Me.txt_box_discount.TabIndex = 6
        '
        'txtbox_subtotal
        '
        Me.txtbox_subtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_subtotal.DefaultText = ""
        Me.txtbox_subtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_subtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_subtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_subtotal.DisabledState.Parent = Me.txtbox_subtotal
        Me.txtbox_subtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_subtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_subtotal.FocusedState.Parent = Me.txtbox_subtotal
        Me.txtbox_subtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_subtotal.HoverState.Parent = Me.txtbox_subtotal
        Me.txtbox_subtotal.Location = New System.Drawing.Point(225, 379)
        Me.txtbox_subtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_subtotal.Name = "txtbox_subtotal"
        Me.txtbox_subtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_subtotal.PlaceholderText = "Sub total"
        Me.txtbox_subtotal.SelectedText = ""
        Me.txtbox_subtotal.ShadowDecoration.Parent = Me.txtbox_subtotal
        Me.txtbox_subtotal.Size = New System.Drawing.Size(209, 44)
        Me.txtbox_subtotal.TabIndex = 5
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(10, 37)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(425, 296)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Checkout"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(962, 658)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Products"
        '
        'ProductsPanel
        '
        Me.ProductsPanel.AutoScroll = True
        Me.ProductsPanel.Location = New System.Drawing.Point(3, 34)
        Me.ProductsPanel.Name = "ProductsPanel"
        Me.ProductsPanel.Size = New System.Drawing.Size(964, 626)
        Me.ProductsPanel.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 527)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Customer paid"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Discount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Customer"
        '
        'Pos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.ProductsPanel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Pos"
        Me.Size = New System.Drawing.Size(1428, 663)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbox_total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_box_discount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbox_subtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ProductsPanel As FlowLayoutPanel
    Friend WithEvents customerList As ComboBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents balance_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
