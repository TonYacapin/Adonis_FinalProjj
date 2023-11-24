<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteuserFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteuserFORM))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_USERROLE = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_PASSWORD = New System.Windows.Forms.TextBox()
        Me.TB_USERNAME = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_CASHIERID = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(173, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 24)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "UserRole:"
        '
        'CB_USERROLE
        '
        Me.CB_USERROLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.CB_USERROLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_USERROLE.Enabled = False
        Me.CB_USERROLE.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_USERROLE.FormattingEnabled = True
        Me.CB_USERROLE.Items.AddRange(New Object() {"Manager", "Cashier", "Admin"})
        Me.CB_USERROLE.Location = New System.Drawing.Point(300, 334)
        Me.CB_USERROLE.Name = "CB_USERROLE"
        Me.CB_USERROLE.Size = New System.Drawing.Size(100, 31)
        Me.CB_USERROLE.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 24)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(232, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 54)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Username:"
        '
        'TB_PASSWORD
        '
        Me.TB_PASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_PASSWORD.Enabled = False
        Me.TB_PASSWORD.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PASSWORD.Location = New System.Drawing.Point(421, 278)
        Me.TB_PASSWORD.Name = "TB_PASSWORD"
        Me.TB_PASSWORD.Size = New System.Drawing.Size(100, 32)
        Me.TB_PASSWORD.TabIndex = 42
        '
        'TB_USERNAME
        '
        Me.TB_USERNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_USERNAME.Enabled = False
        Me.TB_USERNAME.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USERNAME.Location = New System.Drawing.Point(154, 276)
        Me.TB_USERNAME.Name = "TB_USERNAME"
        Me.TB_USERNAME.Size = New System.Drawing.Size(100, 32)
        Me.TB_USERNAME.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(655, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(677, 375)
        Me.DataGridView1.TabIndex = 39
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(1262, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 61)
        Me.Button6.TabIndex = 58
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(346, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1358, 100)
        Me.Panel4.TabIndex = 51
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Fax", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1358, 83)
        Me.TextBox1.TabIndex = 59
        Me.TextBox1.Text = "BURGERAN NI TONTON"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 941)
        Me.Panel3.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 941)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1704, 100)
        Me.Panel2.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1704, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1041)
        Me.Panel1.TabIndex = 48
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-13, -107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 35)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, -41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 24)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "ADD USER"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(470, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(361, 24)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "CashierID(AUTO INCREMENTED)"
        Me.Label6.Visible = False
        '
        'TB_CASHIERID
        '
        Me.TB_CASHIERID.Enabled = False
        Me.TB_CASHIERID.Location = New System.Drawing.Point(647, 538)
        Me.TB_CASHIERID.Name = "TB_CASHIERID"
        Me.TB_CASHIERID.Size = New System.Drawing.Size(100, 20)
        Me.TB_CASHIERID.TabIndex = 44
        Me.TB_CASHIERID.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.CB_USERROLE)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.TB_PASSWORD)
        Me.Panel5.Controls.Add(Me.TB_USERNAME)
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(346, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1358, 841)
        Me.Panel5.TabIndex = 52
        '
        'deleteuserFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_CASHIERID)
        Me.Name = "deleteuserFORM"
        Me.Text = "deleteuserFORM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents CB_USERROLE As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_PASSWORD As TextBox
    Friend WithEvents TB_USERNAME As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_CASHIERID As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
