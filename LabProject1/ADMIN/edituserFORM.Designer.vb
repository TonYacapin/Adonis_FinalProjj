<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edituserFORM
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edituserFORM))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.logininfopanel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_USERROLE = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_PASSWORD = New System.Windows.Forms.TextBox()
        Me.TB_USERNAME = New System.Windows.Forms.TextBox()
        Me.personalinfopanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_LASTNAME = New System.Windows.Forms.TextBox()
        Me.TB_PHONE = New System.Windows.Forms.TextBox()
        Me.TB_EMAIL = New System.Windows.Forms.TextBox()
        Me.TB_FIRSTNAME = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_CASHIERID = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logininfopanel.SuspendLayout()
        Me.personalinfopanel.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Controls.Add(Me.logininfopanel)
        Me.Panel5.Controls.Add(Me.personalinfopanel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(346, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1358, 841)
        Me.Panel5.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "EDIT:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(368, 33)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 54)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Login Info"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(198, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 54)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Personal Info"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(716, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(677, 375)
        Me.DataGridView1.TabIndex = 39
        '
        'logininfopanel
        '
        Me.logininfopanel.Controls.Add(Me.Label9)
        Me.logininfopanel.Controls.Add(Me.CB_USERROLE)
        Me.logininfopanel.Controls.Add(Me.Label8)
        Me.logininfopanel.Controls.Add(Me.Button1)
        Me.logininfopanel.Controls.Add(Me.Label1)
        Me.logininfopanel.Controls.Add(Me.TB_PASSWORD)
        Me.logininfopanel.Controls.Add(Me.TB_USERNAME)
        Me.logininfopanel.Location = New System.Drawing.Point(6, 120)
        Me.logininfopanel.Name = "logininfopanel"
        Me.logininfopanel.Size = New System.Drawing.Size(704, 266)
        Me.logininfopanel.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(255, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 24)
        Me.Label9.TabIndex = 64
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
        Me.CB_USERROLE.Location = New System.Drawing.Point(382, 108)
        Me.CB_USERROLE.Name = "CB_USERROLE"
        Me.CB_USERROLE.Size = New System.Drawing.Size(100, 31)
        Me.CB_USERROLE.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(379, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 24)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(304, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 54)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Username:"
        '
        'TB_PASSWORD
        '
        Me.TB_PASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_PASSWORD.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PASSWORD.Location = New System.Drawing.Point(503, 52)
        Me.TB_PASSWORD.Name = "TB_PASSWORD"
        Me.TB_PASSWORD.Size = New System.Drawing.Size(100, 32)
        Me.TB_PASSWORD.TabIndex = 59
        '
        'TB_USERNAME
        '
        Me.TB_USERNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_USERNAME.Enabled = False
        Me.TB_USERNAME.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USERNAME.Location = New System.Drawing.Point(236, 50)
        Me.TB_USERNAME.Name = "TB_USERNAME"
        Me.TB_USERNAME.Size = New System.Drawing.Size(100, 32)
        Me.TB_USERNAME.TabIndex = 58
        '
        'personalinfopanel
        '
        Me.personalinfopanel.Controls.Add(Me.Label13)
        Me.personalinfopanel.Controls.Add(Me.ComboBox2)
        Me.personalinfopanel.Controls.Add(Me.Button4)
        Me.personalinfopanel.Controls.Add(Me.Label5)
        Me.personalinfopanel.Controls.Add(Me.Label4)
        Me.personalinfopanel.Controls.Add(Me.Label10)
        Me.personalinfopanel.Controls.Add(Me.Label11)
        Me.personalinfopanel.Controls.Add(Me.Label12)
        Me.personalinfopanel.Controls.Add(Me.TB_LASTNAME)
        Me.personalinfopanel.Controls.Add(Me.TB_PHONE)
        Me.personalinfopanel.Controls.Add(Me.TB_EMAIL)
        Me.personalinfopanel.Controls.Add(Me.TB_FIRSTNAME)
        Me.personalinfopanel.Controls.Add(Me.TextBox3)
        Me.personalinfopanel.Location = New System.Drawing.Point(6, 160)
        Me.personalinfopanel.Name = "personalinfopanel"
        Me.personalinfopanel.Size = New System.Drawing.Size(704, 224)
        Me.personalinfopanel.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(119, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 24)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "View:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Manager", "Cashier", "Admin"})
        Me.ComboBox2.Location = New System.Drawing.Point(194, 106)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 31)
        Me.ComboBox2.TabIndex = 85
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(298, 151)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 54)
        Me.Button4.TabIndex = 84
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(364, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 24)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Email:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(364, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 24)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "LastName:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(59, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 24)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Firstname:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(59, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 24)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Username:"
        '
        'TB_LASTNAME
        '
        Me.TB_LASTNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_LASTNAME.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LASTNAME.Location = New System.Drawing.Point(546, 20)
        Me.TB_LASTNAME.Name = "TB_LASTNAME"
        Me.TB_LASTNAME.Size = New System.Drawing.Size(100, 32)
        Me.TB_LASTNAME.TabIndex = 78
        '
        'TB_PHONE
        '
        Me.TB_PHONE.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_PHONE.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PHONE.Location = New System.Drawing.Point(546, 98)
        Me.TB_PHONE.Name = "TB_PHONE"
        Me.TB_PHONE.Size = New System.Drawing.Size(100, 32)
        Me.TB_PHONE.TabIndex = 77
        '
        'TB_EMAIL
        '
        Me.TB_EMAIL.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_EMAIL.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EMAIL.Location = New System.Drawing.Point(546, 58)
        Me.TB_EMAIL.Name = "TB_EMAIL"
        Me.TB_EMAIL.Size = New System.Drawing.Size(100, 32)
        Me.TB_EMAIL.TabIndex = 76
        '
        'TB_FIRSTNAME
        '
        Me.TB_FIRSTNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TB_FIRSTNAME.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FIRSTNAME.Location = New System.Drawing.Point(194, 20)
        Me.TB_FIRSTNAME.Name = "TB_FIRSTNAME"
        Me.TB_FIRSTNAME.Size = New System.Drawing.Size(100, 32)
        Me.TB_FIRSTNAME.TabIndex = 75
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(194, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 32)
        Me.TextBox3.TabIndex = 74
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(346, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1358, 100)
        Me.Panel4.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(477, 598)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(361, 24)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "CashierID(AUTO INCREMENTED)"
        Me.Label6.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 941)
        Me.Panel3.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 941)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1704, 100)
        Me.Panel2.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1704, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1041)
        Me.Panel1.TabIndex = 57
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-6, -54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 35)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 24)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "ADD USER"
        Me.Label7.Visible = False
        '
        'TB_CASHIERID
        '
        Me.TB_CASHIERID.Enabled = False
        Me.TB_CASHIERID.Location = New System.Drawing.Point(654, 591)
        Me.TB_CASHIERID.Name = "TB_CASHIERID"
        Me.TB_CASHIERID.Size = New System.Drawing.Size(100, 20)
        Me.TB_CASHIERID.TabIndex = 53
        Me.TB_CASHIERID.Visible = False
        '
        'edituserFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_CASHIERID)
        Me.Name = "edituserFORM"
        Me.Text = "edituserFORM"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logininfopanel.ResumeLayout(False)
        Me.logininfopanel.PerformLayout()
        Me.personalinfopanel.ResumeLayout(False)
        Me.personalinfopanel.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_CASHIERID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents logininfopanel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents CB_USERROLE As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_PASSWORD As TextBox
    Friend WithEvents TB_USERNAME As TextBox
    Friend WithEvents personalinfopanel As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TB_LASTNAME As TextBox
    Friend WithEvents TB_PHONE As TextBox
    Friend WithEvents TB_EMAIL As TextBox
    Friend WithEvents TB_FIRSTNAME As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
