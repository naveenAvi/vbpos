<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartItemUserController
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ItemsCount = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btn_ItemsCount
        '
        Me.btn_ItemsCount.Enabled = False
        Me.btn_ItemsCount.Location = New System.Drawing.Point(332, 6)
        Me.btn_ItemsCount.Name = "btn_ItemsCount"
        Me.btn_ItemsCount.Size = New System.Drawing.Size(50, 50)
        Me.btn_ItemsCount.TabIndex = 1
        Me.btn_ItemsCount.Text = "btn_itemCount"
        Me.btn_ItemsCount.UseVisualStyleBackColor = True
        '
        'btn_plus
        '
        Me.btn_plus.Location = New System.Drawing.Point(388, 5)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(32, 51)
        Me.btn_plus.TabIndex = 3
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'btn_minus
        '
        Me.btn_minus.Location = New System.Drawing.Point(295, 5)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(31, 50)
        Me.btn_minus.TabIndex = 4
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'CartItemUserController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.btn_ItemsCount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CartItemUserController"
        Me.Size = New System.Drawing.Size(423, 59)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ItemsCount As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_minus As Button
End Class
