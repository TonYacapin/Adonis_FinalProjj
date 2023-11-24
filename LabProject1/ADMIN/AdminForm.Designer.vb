<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.btn_ADMINLOGOUT = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel_Items = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel_User = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel_TransactionRecord = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserActivity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel_Items.SuspendLayout()
        Me.Panel_User.SuspendLayout()
        Me.Panel_TransactionRecord.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ADMINLOGOUT
        '
        Me.btn_ADMINLOGOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ADMINLOGOUT.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ADMINLOGOUT.ForeColor = System.Drawing.Color.Black
        Me.btn_ADMINLOGOUT.Location = New System.Drawing.Point(1067, 73)
        Me.btn_ADMINLOGOUT.Name = "btn_ADMINLOGOUT"
        Me.btn_ADMINLOGOUT.Size = New System.Drawing.Size(123, 38)
        Me.btn_ADMINLOGOUT.TabIndex = 0
        Me.btn_ADMINLOGOUT.Text = "LOGOUT"
        Me.btn_ADMINLOGOUT.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(61, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(61, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 71)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel_Items
        '
        Me.Panel_Items.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Items.Controls.Add(Me.Label1)
        Me.Panel_Items.Controls.Add(Me.Button6)
        Me.Panel_Items.Controls.Add(Me.Button5)
        Me.Panel_Items.Location = New System.Drawing.Point(416, 211)
        Me.Panel_Items.Name = "Panel_Items"
        Me.Panel_Items.Size = New System.Drawing.Size(827, 353)
        Me.Panel_Items.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Items"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(322, 186)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(210, 38)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Edit Item Stock"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(322, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(210, 38)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Edit Item Price"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel_User
        '
        Me.Panel_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_User.Controls.Add(Me.Button9)
        Me.Panel_User.Controls.Add(Me.Button8)
        Me.Panel_User.Controls.Add(Me.Button12)
        Me.Panel_User.Controls.Add(Me.Label2)
        Me.Panel_User.Controls.Add(Me.Button7)
        Me.Panel_User.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel_User.Location = New System.Drawing.Point(417, 209)
        Me.Panel_User.Name = "Panel_User"
        Me.Panel_User.Size = New System.Drawing.Size(827, 353)
        Me.Panel_User.TabIndex = 6
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(339, 149)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(187, 38)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Delete User"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(339, 61)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(190, 38)
        Me.Button12.TabIndex = 8
        Me.Button12.Text = "Request"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(339, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(187, 38)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Add User"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel_TransactionRecord
        '
        Me.Panel_TransactionRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_TransactionRecord.Controls.Add(Me.Button2)
        Me.Panel_TransactionRecord.Controls.Add(Me.Label3)
        Me.Panel_TransactionRecord.Controls.Add(Me.Button10)
        Me.Panel_TransactionRecord.Location = New System.Drawing.Point(418, 209)
        Me.Panel_TransactionRecord.Name = "Panel_TransactionRecord"
        Me.Panel_TransactionRecord.Size = New System.Drawing.Size(826, 353)
        Me.Panel_TransactionRecord.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(322, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 38)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Login Records"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Transaction Record"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(322, 145)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(207, 38)
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "Order Records"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(61, 371)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(109, 71)
        Me.Button11.TabIndex = 10
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hello,"
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1058)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1920, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'UserActivity
        '
        Me.UserActivity.Interval = 60000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1058)
        Me.Panel1.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(61, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 71)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_ADMINLOGOUT)
        Me.Panel2.Controls.Add(Me.lbl_username)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1720, 114)
        Me.Panel2.TabIndex = 16
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Black
        Me.lbl_username.Location = New System.Drawing.Point(175, 81)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(126, 23)
        Me.lbl_username.TabIndex = 12
        Me.lbl_username.Text = "SampleText"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(200, 958)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1720, 100)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1720, 114)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 844)
        Me.Panel4.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel_User)
        Me.Panel5.Controls.Add(Me.Panel_TransactionRecord)
        Me.Panel5.Controls.Add(Me.Panel_Items)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(200, 114)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1520, 844)
        Me.Panel5.TabIndex = 19
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(339, 193)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(187, 38)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Edit User"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel_Items.ResumeLayout(False)
        Me.Panel_Items.PerformLayout()
        Me.Panel_User.ResumeLayout(False)
        Me.Panel_User.PerformLayout()
        Me.Panel_TransactionRecord.ResumeLayout(False)
        Me.Panel_TransactionRecord.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ADMINLOGOUT As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel_Items As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel_User As Panel
    Friend WithEvents Panel_TransactionRecord As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents UserActivity As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_username As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
