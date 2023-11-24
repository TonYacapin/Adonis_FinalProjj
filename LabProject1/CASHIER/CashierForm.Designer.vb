<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashierForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_ALLITEMS = New System.Windows.Forms.Button()
        Me.BTN_FOOD = New System.Windows.Forms.Button()
        Me.BTN_DRINKS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_DESSERT = New System.Windows.Forms.Button()
        Me.btn_CASHIERLOGOUT = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Panel_ALLITEMS = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.panel_FOOD = New System.Windows.Forms.Panel()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Panel_DRINKS = New System.Windows.Forms.Panel()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.panel_DESSERT = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserActivity = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_CashierID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel_ALLITEMS.SuspendLayout()
        Me.panel_FOOD.SuspendLayout()
        Me.Panel_DRINKS.SuspendLayout()
        Me.panel_DESSERT.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_ALLITEMS
        '
        Me.BTN_ALLITEMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BTN_ALLITEMS.BackgroundImage = CType(resources.GetObject("BTN_ALLITEMS.BackgroundImage"), System.Drawing.Image)
        Me.BTN_ALLITEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_ALLITEMS.Location = New System.Drawing.Point(12, 302)
        Me.BTN_ALLITEMS.Name = "BTN_ALLITEMS"
        Me.BTN_ALLITEMS.Size = New System.Drawing.Size(126, 69)
        Me.BTN_ALLITEMS.TabIndex = 1
        Me.BTN_ALLITEMS.UseVisualStyleBackColor = False
        '
        'BTN_FOOD
        '
        Me.BTN_FOOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BTN_FOOD.BackgroundImage = CType(resources.GetObject("BTN_FOOD.BackgroundImage"), System.Drawing.Image)
        Me.BTN_FOOD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_FOOD.Location = New System.Drawing.Point(12, 377)
        Me.BTN_FOOD.Name = "BTN_FOOD"
        Me.BTN_FOOD.Size = New System.Drawing.Size(126, 69)
        Me.BTN_FOOD.TabIndex = 2
        Me.BTN_FOOD.UseVisualStyleBackColor = False
        '
        'BTN_DRINKS
        '
        Me.BTN_DRINKS.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BTN_DRINKS.BackgroundImage = CType(resources.GetObject("BTN_DRINKS.BackgroundImage"), System.Drawing.Image)
        Me.BTN_DRINKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DRINKS.Location = New System.Drawing.Point(12, 453)
        Me.BTN_DRINKS.Name = "BTN_DRINKS"
        Me.BTN_DRINKS.Size = New System.Drawing.Size(126, 69)
        Me.BTN_DRINKS.TabIndex = 3
        Me.BTN_DRINKS.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 55)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MENU"
        '
        'BTN_DESSERT
        '
        Me.BTN_DESSERT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BTN_DESSERT.BackgroundImage = CType(resources.GetObject("BTN_DESSERT.BackgroundImage"), System.Drawing.Image)
        Me.BTN_DESSERT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DESSERT.Location = New System.Drawing.Point(12, 527)
        Me.BTN_DESSERT.Name = "BTN_DESSERT"
        Me.BTN_DESSERT.Size = New System.Drawing.Size(126, 69)
        Me.BTN_DESSERT.TabIndex = 5
        Me.BTN_DESSERT.UseVisualStyleBackColor = False
        '
        'btn_CASHIERLOGOUT
        '
        Me.btn_CASHIERLOGOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_CASHIERLOGOUT.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CASHIERLOGOUT.Location = New System.Drawing.Point(1783, 12)
        Me.btn_CASHIERLOGOUT.Name = "btn_CASHIERLOGOUT"
        Me.btn_CASHIERLOGOUT.Size = New System.Drawing.Size(125, 38)
        Me.btn_CASHIERLOGOUT.TabIndex = 6
        Me.btn_CASHIERLOGOUT.Text = "LOGOUT"
        Me.btn_CASHIERLOGOUT.UseVisualStyleBackColor = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(125, 28)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(126, 23)
        Me.lbl_user.TabIndex = 7
        Me.lbl_user.Text = "SampleText"
        '
        'Panel_ALLITEMS
        '
        Me.Panel_ALLITEMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_ALLITEMS.Controls.Add(Me.Button10)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button11)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button12)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button8)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button9)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button6)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button5)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button3)
        Me.Panel_ALLITEMS.Location = New System.Drawing.Point(397, 252)
        Me.Panel_ALLITEMS.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_ALLITEMS.Name = "Panel_ALLITEMS"
        Me.Panel_ALLITEMS.Size = New System.Drawing.Size(414, 294)
        Me.Panel_ALLITEMS.TabIndex = 8
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(293, 197)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 70)
        Me.Button10.TabIndex = 8
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(155, 197)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 70)
        Me.Button11.TabIndex = 7
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(22, 197)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(100, 70)
        Me.Button12.TabIndex = 6
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(224, 100)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 70)
        Me.Button8.TabIndex = 4
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(94, 100)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 70)
        Me.Button9.TabIndex = 3
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(293, 11)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 70)
        Me.Button6.TabIndex = 2
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(154, 11)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 70)
        Me.Button5.TabIndex = 1
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(10, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 70)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.Location = New System.Drawing.Point(22, 25)
        Me.Button21.Margin = New System.Windows.Forms.Padding(2)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(100, 70)
        Me.Button21.TabIndex = 0
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.Location = New System.Drawing.Point(155, 25)
        Me.Button20.Margin = New System.Windows.Forms.Padding(2)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(100, 70)
        Me.Button20.TabIndex = 1
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.Location = New System.Drawing.Point(293, 25)
        Me.Button19.Margin = New System.Windows.Forms.Padding(2)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(100, 70)
        Me.Button19.TabIndex = 2
        Me.Button19.UseVisualStyleBackColor = True
        '
        'panel_FOOD
        '
        Me.panel_FOOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel_FOOD.Controls.Add(Me.Button19)
        Me.panel_FOOD.Controls.Add(Me.Button20)
        Me.panel_FOOD.Controls.Add(Me.Button21)
        Me.panel_FOOD.Location = New System.Drawing.Point(397, 252)
        Me.panel_FOOD.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_FOOD.Name = "panel_FOOD"
        Me.panel_FOOD.Size = New System.Drawing.Size(414, 296)
        Me.panel_FOOD.TabIndex = 9
        '
        'Button30
        '
        Me.Button30.BackgroundImage = CType(resources.GetObject("Button30.BackgroundImage"), System.Drawing.Image)
        Me.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button30.Location = New System.Drawing.Point(94, 25)
        Me.Button30.Margin = New System.Windows.Forms.Padding(2)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(100, 70)
        Me.Button30.TabIndex = 0
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.BackgroundImage = CType(resources.GetObject("Button29.BackgroundImage"), System.Drawing.Image)
        Me.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button29.Location = New System.Drawing.Point(225, 25)
        Me.Button29.Margin = New System.Windows.Forms.Padding(2)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(100, 70)
        Me.Button29.TabIndex = 1
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Panel_DRINKS
        '
        Me.Panel_DRINKS.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_DRINKS.Controls.Add(Me.Button29)
        Me.Panel_DRINKS.Controls.Add(Me.Button30)
        Me.Panel_DRINKS.Location = New System.Drawing.Point(397, 254)
        Me.Panel_DRINKS.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_DRINKS.Name = "Panel_DRINKS"
        Me.Panel_DRINKS.Size = New System.Drawing.Size(414, 294)
        Me.Panel_DRINKS.TabIndex = 10
        '
        'Button39
        '
        Me.Button39.BackgroundImage = CType(resources.GetObject("Button39.BackgroundImage"), System.Drawing.Image)
        Me.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button39.Location = New System.Drawing.Point(22, 25)
        Me.Button39.Margin = New System.Windows.Forms.Padding(2)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(100, 70)
        Me.Button39.TabIndex = 0
        Me.Button39.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.BackgroundImage = CType(resources.GetObject("Button38.BackgroundImage"), System.Drawing.Image)
        Me.Button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button38.Location = New System.Drawing.Point(155, 25)
        Me.Button38.Margin = New System.Windows.Forms.Padding(2)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(100, 70)
        Me.Button38.TabIndex = 1
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.BackgroundImage = CType(resources.GetObject("Button37.BackgroundImage"), System.Drawing.Image)
        Me.Button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button37.Location = New System.Drawing.Point(293, 25)
        Me.Button37.Margin = New System.Windows.Forms.Padding(2)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(100, 70)
        Me.Button37.TabIndex = 2
        Me.Button37.UseVisualStyleBackColor = True
        '
        'panel_DESSERT
        '
        Me.panel_DESSERT.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel_DESSERT.Controls.Add(Me.Button37)
        Me.panel_DESSERT.Controls.Add(Me.Button38)
        Me.panel_DESSERT.Controls.Add(Me.Button39)
        Me.panel_DESSERT.Location = New System.Drawing.Point(397, 254)
        Me.panel_DESSERT.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_DESSERT.Name = "panel_DESSERT"
        Me.panel_DESSERT.Size = New System.Drawing.Size(414, 294)
        Me.panel_DESSERT.TabIndex = 11
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1058)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1920, 22)
        Me.StatusStrip1.TabIndex = 13
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
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.ProductIDCol, Me.QuantityCol, Me.PriceCol})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(21, 23)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 49
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(531, 711)
        Me.DataGridView1.TabIndex = 1
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "ProductName"
        Me.ProductName.MinimumWidth = 6
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Width = 120
        '
        'ProductIDCol
        '
        Me.ProductIDCol.HeaderText = "ProductID"
        Me.ProductIDCol.MinimumWidth = 6
        Me.ProductIDCol.Name = "ProductIDCol"
        Me.ProductIDCol.Width = 120
        '
        'QuantityCol
        '
        Me.QuantityCol.HeaderText = "Quantity"
        Me.QuantityCol.MinimumWidth = 6
        Me.QuantityCol.Name = "QuantityCol"
        Me.QuantityCol.Width = 120
        '
        'PriceCol
        '
        Me.PriceCol.HeaderText = "Price"
        Me.PriceCol.MinimumWidth = 6
        Me.PriceCol.Name = "PriceCol"
        Me.PriceCol.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Hi,"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CashierID:"
        '
        'lbl_CashierID
        '
        Me.lbl_CashierID.AutoSize = True
        Me.lbl_CashierID.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CashierID.Location = New System.Drawing.Point(579, 28)
        Me.lbl_CashierID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_CashierID.Name = "lbl_CashierID"
        Me.lbl_CashierID.Size = New System.Drawing.Size(126, 23)
        Me.lbl_CashierID.TabIndex = 17
        Me.lbl_CashierID.Text = "SampleText"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1318, 144)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 914)
        Me.Panel2.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(155, 772)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Place Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BTN_ALLITEMS)
        Me.Panel3.Controls.Add(Me.BTN_FOOD)
        Me.Panel3.Controls.Add(Me.BTN_DRINKS)
        Me.Panel3.Controls.Add(Me.BTN_DESSERT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 994)
        Me.Panel3.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lbl_user)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.lbl_CashierID)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(169, 64)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1751, 80)
        Me.Panel4.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Fax", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1920, 64)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = "BURGERAN NI TONTON"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel_ALLITEMS)
        Me.Panel5.Controls.Add(Me.panel_FOOD)
        Me.Panel5.Controls.Add(Me.Panel_DRINKS)
        Me.Panel5.Controls.Add(Me.panel_DESSERT)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(169, 144)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1751, 914)
        Me.Panel5.TabIndex = 22
        '
        'CashierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_CASHIERLOGOUT)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CashierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashierForm"
        Me.Panel_ALLITEMS.ResumeLayout(False)
        Me.panel_FOOD.ResumeLayout(False)
        Me.Panel_DRINKS.ResumeLayout(False)
        Me.panel_DESSERT.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_ALLITEMS As Button
    Friend WithEvents BTN_FOOD As Button
    Friend WithEvents BTN_DRINKS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_DESSERT As Button
    Friend WithEvents btn_CASHIERLOGOUT As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents Panel_ALLITEMS As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents panel_FOOD As Panel
    Friend WithEvents Button30 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Panel_DRINKS As Panel
    Friend WithEvents Button39 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents panel_DESSERT As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents UserActivity As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_CashierID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
End Class
