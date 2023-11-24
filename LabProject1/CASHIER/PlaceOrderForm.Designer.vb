<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceOrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceOrderForm))
        Me.OrderPicture = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPRODUCTNAME = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.OrderPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderPicture
        '
        Me.OrderPicture.Location = New System.Drawing.Point(220, 80)
        Me.OrderPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderPicture.Name = "OrderPicture"
        Me.OrderPicture.Size = New System.Drawing.Size(142, 120)
        Me.OrderPicture.TabIndex = 0
        Me.OrderPicture.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(248, 245)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(90, 32)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.Location = New System.Drawing.Point(236, 290)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(126, 31)
        Me.btnAddOrder.TabIndex = 2
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 211)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantity:"
        '
        'lblPRODUCTNAME
        '
        Me.lblPRODUCTNAME.AutoSize = True
        Me.lblPRODUCTNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPRODUCTNAME.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPRODUCTNAME.Location = New System.Drawing.Point(236, 37)
        Me.lblPRODUCTNAME.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPRODUCTNAME.Name = "lblPRODUCTNAME"
        Me.lblPRODUCTNAME.Size = New System.Drawing.Size(126, 23)
        Me.lblPRODUCTNAME.TabIndex = 4
        Me.lblPRODUCTNAME.Text = "SampleText"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "thumb-1920-121821.jpg")
        Me.ImageList1.Images.SetKeyName(1, "3267_hot_dog.jpg")
        Me.ImageList1.Images.SetKeyName(2, "classic-fries.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Coke-Glass.jpg")
        Me.ImageList1.Images.SetKeyName(4, "319566.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Sans-Rival-FB-10-CR.jpg")
        Me.ImageList1.Images.SetKeyName(6, "halo-halo-filipino-dessert-recipe.jpg")
        Me.ImageList1.Images.SetKeyName(7, "chocolate-cake-with-chocolate-frosting-recipe-13.jpg")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(236, 325)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlaceOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPRODUCTNAME)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.OrderPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PlaceOrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlaceOrderForm"
        CType(Me.OrderPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderPicture As PictureBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPRODUCTNAME As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
End Class
