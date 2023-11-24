<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Admin_Panel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_capslockindi_admin = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_admin_username = New System.Windows.Forms.TextBox()
        Me.btn_login_admin = New System.Windows.Forms.Button()
        Me.tb_admin_password = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Manager_panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_capslockindi_manager = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_manager_username = New System.Windows.Forms.TextBox()
        Me.btn_login_manager = New System.Windows.Forms.Button()
        Me.tb_manager_password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Cashier_panel = New System.Windows.Forms.Panel()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.btn_login_Cashier = New System.Windows.Forms.Button()
        Me.Tb_Username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_CaplockIndi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Admin_Panel.SuspendLayout()
        Me.Manager_panel.SuspendLayout()
        Me.Cashier_panel.SuspendLayout()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(358, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 45)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ADMIN"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Admin_Panel
        '
        Me.Admin_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Admin_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Admin_Panel.Controls.Add(Me.Label5)
        Me.Admin_Panel.Controls.Add(Me.lbl_capslockindi_admin)
        Me.Admin_Panel.Controls.Add(Me.CheckBox2)
        Me.Admin_Panel.Controls.Add(Me.Label4)
        Me.Admin_Panel.Controls.Add(Me.Label10)
        Me.Admin_Panel.Controls.Add(Me.Label6)
        Me.Admin_Panel.Controls.Add(Me.tb_admin_username)
        Me.Admin_Panel.Controls.Add(Me.btn_login_admin)
        Me.Admin_Panel.Controls.Add(Me.tb_admin_password)
        Me.Admin_Panel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Admin_Panel.Location = New System.Drawing.Point(0, 120)
        Me.Admin_Panel.Name = "Admin_Panel"
        Me.Admin_Panel.Size = New System.Drawing.Size(565, 734)
        Me.Admin_Panel.TabIndex = 11
        Me.Admin_Panel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 28)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "LOGIN"
        '
        'lbl_capslockindi_admin
        '
        Me.lbl_capslockindi_admin.AutoSize = True
        Me.lbl_capslockindi_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_capslockindi_admin.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capslockindi_admin.Location = New System.Drawing.Point(69, 388)
        Me.lbl_capslockindi_admin.Name = "lbl_capslockindi_admin"
        Me.lbl_capslockindi_admin.Size = New System.Drawing.Size(78, 25)
        Me.lbl_capslockindi_admin.TabIndex = 6
        Me.lbl_capslockindi_admin.Text = "Label3"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(69, 348)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(184, 27)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Username:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(397, 109)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ADMIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password:"
        '
        'tb_admin_username
        '
        Me.tb_admin_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tb_admin_username.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_admin_username.Location = New System.Drawing.Point(69, 245)
        Me.tb_admin_username.Name = "tb_admin_username"
        Me.tb_admin_username.Size = New System.Drawing.Size(167, 32)
        Me.tb_admin_username.TabIndex = 2
        '
        'btn_login_admin
        '
        Me.btn_login_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_login_admin.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_admin.Location = New System.Drawing.Point(201, 451)
        Me.btn_login_admin.Name = "btn_login_admin"
        Me.btn_login_admin.Size = New System.Drawing.Size(134, 69)
        Me.btn_login_admin.TabIndex = 4
        Me.btn_login_admin.Text = "LOGIN"
        Me.btn_login_admin.UseVisualStyleBackColor = False
        '
        'tb_admin_password
        '
        Me.tb_admin_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tb_admin_password.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_admin_password.Location = New System.Drawing.Point(69, 310)
        Me.tb_admin_password.Name = "tb_admin_password"
        Me.tb_admin_password.Size = New System.Drawing.Size(167, 32)
        Me.tb_admin_password.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(48, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 45)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CASHIER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Manager_panel
        '
        Me.Manager_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Manager_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Manager_panel.Controls.Add(Me.Label3)
        Me.Manager_panel.Controls.Add(Me.Label7)
        Me.Manager_panel.Controls.Add(Me.CheckBox3)
        Me.Manager_panel.Controls.Add(Me.Label8)
        Me.Manager_panel.Controls.Add(Me.lbl_capslockindi_manager)
        Me.Manager_panel.Controls.Add(Me.Label13)
        Me.Manager_panel.Controls.Add(Me.tb_manager_username)
        Me.Manager_panel.Controls.Add(Me.btn_login_manager)
        Me.Manager_panel.Controls.Add(Me.tb_manager_password)
        Me.Manager_panel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Manager_panel.Location = New System.Drawing.Point(0, 120)
        Me.Manager_panel.Name = "Manager_panel"
        Me.Manager_panel.Size = New System.Drawing.Size(565, 735)
        Me.Manager_panel.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "LOGIN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(558, 109)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MANAGER"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(69, 348)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(184, 27)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.Text = "Show Password"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Username:"
        '
        'lbl_capslockindi_manager
        '
        Me.lbl_capslockindi_manager.AutoSize = True
        Me.lbl_capslockindi_manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_capslockindi_manager.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capslockindi_manager.Location = New System.Drawing.Point(69, 388)
        Me.lbl_capslockindi_manager.Name = "lbl_capslockindi_manager"
        Me.lbl_capslockindi_manager.Size = New System.Drawing.Size(78, 25)
        Me.lbl_capslockindi_manager.TabIndex = 6
        Me.lbl_capslockindi_manager.Text = "Label3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(65, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 23)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Password:"
        '
        'tb_manager_username
        '
        Me.tb_manager_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tb_manager_username.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_manager_username.Location = New System.Drawing.Point(69, 245)
        Me.tb_manager_username.Name = "tb_manager_username"
        Me.tb_manager_username.Size = New System.Drawing.Size(167, 32)
        Me.tb_manager_username.TabIndex = 2
        '
        'btn_login_manager
        '
        Me.btn_login_manager.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_login_manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login_manager.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_manager.Location = New System.Drawing.Point(201, 451)
        Me.btn_login_manager.Name = "btn_login_manager"
        Me.btn_login_manager.Size = New System.Drawing.Size(134, 69)
        Me.btn_login_manager.TabIndex = 4
        Me.btn_login_manager.Text = "LOGIN"
        Me.btn_login_manager.UseVisualStyleBackColor = False
        '
        'tb_manager_password
        '
        Me.tb_manager_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tb_manager_password.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_manager_password.Location = New System.Drawing.Point(69, 310)
        Me.tb_manager_password.Name = "tb_manager_password"
        Me.tb_manager_password.Size = New System.Drawing.Size(167, 32)
        Me.tb_manager_password.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(202, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "MANAGER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(1818, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 61)
        Me.Button4.TabIndex = 14
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Cashier_panel
        '
        Me.Cashier_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Cashier_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cashier_panel.Controls.Add(Me.Label9)
        Me.Cashier_panel.Controls.Add(Me.Label11)
        Me.Cashier_panel.Controls.Add(Me.CheckBox1)
        Me.Cashier_panel.Controls.Add(Me.Label1)
        Me.Cashier_panel.Controls.Add(Me.lbl_CaplockIndi)
        Me.Cashier_panel.Controls.Add(Me.Label2)
        Me.Cashier_panel.Controls.Add(Me.Tb_Username)
        Me.Cashier_panel.Controls.Add(Me.btn_login_Cashier)
        Me.Cashier_panel.Controls.Add(Me.Tb_Password)
        Me.Cashier_panel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cashier_panel.Location = New System.Drawing.Point(0, 120)
        Me.Cashier_panel.Name = "Cashier_panel"
        Me.Cashier_panel.Size = New System.Drawing.Size(565, 736)
        Me.Cashier_panel.TabIndex = 7
        '
        'Tb_Password
        '
        Me.Tb_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Tb_Password.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Password.Location = New System.Drawing.Point(69, 310)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.Size = New System.Drawing.Size(167, 32)
        Me.Tb_Password.TabIndex = 3
        '
        'btn_login_Cashier
        '
        Me.btn_login_Cashier.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btn_login_Cashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login_Cashier.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_Cashier.Location = New System.Drawing.Point(201, 451)
        Me.btn_login_Cashier.Name = "btn_login_Cashier"
        Me.btn_login_Cashier.Size = New System.Drawing.Size(134, 69)
        Me.btn_login_Cashier.TabIndex = 4
        Me.btn_login_Cashier.Text = "LOGIN"
        Me.btn_login_Cashier.UseVisualStyleBackColor = False
        '
        'Tb_Username
        '
        Me.Tb_Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Tb_Username.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Username.Location = New System.Drawing.Point(69, 245)
        Me.Tb_Username.Name = "Tb_Username"
        Me.Tb_Username.Size = New System.Drawing.Size(167, 32)
        Me.Tb_Username.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'lbl_CaplockIndi
        '
        Me.lbl_CaplockIndi.AutoSize = True
        Me.lbl_CaplockIndi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_CaplockIndi.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CaplockIndi.Location = New System.Drawing.Point(69, 388)
        Me.lbl_CaplockIndi.Name = "lbl_CaplockIndi"
        Me.lbl_CaplockIndi.Size = New System.Drawing.Size(78, 25)
        Me.lbl_CaplockIndi.TabIndex = 6
        Me.lbl_CaplockIndi.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(69, 348)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(184, 27)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Fax", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(28, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(487, 109)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "CASHIER"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(236, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 28)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "LOGIN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        PictureBox1.Location = New System.Drawing.Point(565, 121)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(1355, 897)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Admin_Panel)
        Me.Panel1.Controls.Add(Me.Cashier_panel)
        Me.Panel1.Controls.Add(Me.Manager_panel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 897)
        Me.Panel1.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(150, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 23)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Login as:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Fax", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1920, 121)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "BURGERAN NI TONTON"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 1018)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Admin_Panel.ResumeLayout(False)
        Me.Admin_Panel.PerformLayout()
        Me.Manager_panel.ResumeLayout(False)
        Me.Manager_panel.PerformLayout()
        Me.Cashier_panel.ResumeLayout(False)
        Me.Cashier_panel.PerformLayout()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Admin_Panel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_capslockindi_admin As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_admin_username As TextBox
    Friend WithEvents btn_login_admin As Button
    Friend WithEvents tb_admin_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Manager_panel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_capslockindi_manager As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_manager_username As TextBox
    Friend WithEvents btn_login_manager As Button
    Friend WithEvents tb_manager_password As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Cashier_panel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_CaplockIndi As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Username As TextBox
    Friend WithEvents btn_login_Cashier As Button
    Friend WithEvents Tb_Password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
