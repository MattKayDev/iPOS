<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzas
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
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button15 = New System.Windows.Forms.Button()
        Me.button14 = New System.Windows.Forms.Button()
        Me.button16 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.dgvBasket = New System.Windows.Forms.DataGridView()
        Me.cProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button17 = New System.Windows.Forms.Button()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBasket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer1
        '
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(291, 43)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 13)
        Me.lblVersion.TabIndex = 46
        Me.lblVersion.Tag = ""
        Me.lblVersion.Text = "999.999.999.999"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(380, 43)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 13)
        Me.label2.TabIndex = 45
        Me.label2.Text = "by MattKayDev"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(753, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(135, 33)
        Me.lblTime.TabIndex = 44
        Me.lblTime.Text = "00:00:00"
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Black
        Me.pictureBox2.Location = New System.Drawing.Point(732, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(178, 50)
        Me.pictureBox2.TabIndex = 43
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(288, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(172, 31)
        Me.label1.TabIndex = 42
        Me.label1.Text = "iWAVE POS"
        '
        'button15
        '
        Me.button15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button15.Location = New System.Drawing.Point(12, 12)
        Me.button15.Name = "button15"
        Me.button15.Size = New System.Drawing.Size(73, 29)
        Me.button15.TabIndex = 41
        Me.button15.Text = "BACK"
        Me.button15.UseVisualStyleBackColor = True
        '
        'button14
        '
        Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button14.Location = New System.Drawing.Point(191, 219)
        Me.button14.Name = "button14"
        Me.button14.Size = New System.Drawing.Size(138, 41)
        Me.button14.TabIndex = 40
        Me.button14.Text = "MEAT FEAST"
        Me.button14.UseVisualStyleBackColor = True
        '
        'button16
        '
        Me.button16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button16.Location = New System.Drawing.Point(191, 407)
        Me.button16.Name = "button16"
        Me.button16.Size = New System.Drawing.Size(138, 41)
        Me.button16.TabIndex = 39
        Me.button16.Text = "DONNER TOPPING"
        Me.button16.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button13.Location = New System.Drawing.Point(191, 313)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(138, 41)
        Me.button13.TabIndex = 38
        Me.button13.Text = "EXTRA TOPPINGS"
        Me.button13.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button12.Location = New System.Drawing.Point(191, 172)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(138, 41)
        Me.button12.TabIndex = 37
        Me.button12.Text = "IL PADRINO"
        Me.button12.UseVisualStyleBackColor = True
        '
        'button11
        '
        Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button11.Location = New System.Drawing.Point(191, 125)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(138, 41)
        Me.button11.TabIndex = 36
        Me.button11.Text = "ITALIAN HOT"
        Me.button11.UseVisualStyleBackColor = True
        '
        'button10
        '
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button10.Location = New System.Drawing.Point(191, 78)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(138, 41)
        Me.button10.TabIndex = 35
        Me.button10.Text = "SEAFOOD"
        Me.button10.UseVisualStyleBackColor = True
        '
        'button9
        '
        Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button9.Location = New System.Drawing.Point(12, 454)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(138, 41)
        Me.button9.TabIndex = 34
        Me.button9.Text = "VEG"
        Me.button9.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.Location = New System.Drawing.Point(12, 407)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(138, 41)
        Me.button8.TabIndex = 33
        Me.button8.Text = "DONNER HOT"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.Location = New System.Drawing.Point(12, 360)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(138, 41)
        Me.button7.TabIndex = 32
        Me.button7.Text = "DONNER"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.Location = New System.Drawing.Point(12, 313)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(138, 41)
        Me.button6.TabIndex = 31
        Me.button6.Text = "SPICY CHICKEN"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.Location = New System.Drawing.Point(12, 266)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(138, 41)
        Me.button5.TabIndex = 30
        Me.button5.Text = "SOUTHERN"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(12, 219)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(138, 41)
        Me.button4.TabIndex = 29
        Me.button4.Text = "NAPOLI"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(12, 172)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(138, 41)
        Me.button3.TabIndex = 28
        Me.button3.Text = "TUSCANY"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(12, 125)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(138, 41)
        Me.button2.TabIndex = 27
        Me.button2.Text = "HAWAIIAN"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(12, 78)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(138, 41)
        Me.button1.TabIndex = 26
        Me.button1.Text = "MARGHERITA"
        Me.button1.UseVisualStyleBackColor = True
        '
        'dgvBasket
        '
        Me.dgvBasket.AllowUserToAddRows = False
        Me.dgvBasket.AllowUserToDeleteRows = False
        Me.dgvBasket.AllowUserToResizeColumns = False
        Me.dgvBasket.AllowUserToResizeRows = False
        Me.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBasket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cProduct, Me.cPrice})
        Me.dgvBasket.Location = New System.Drawing.Point(416, 78)
        Me.dgvBasket.Name = "dgvBasket"
        Me.dgvBasket.ReadOnly = True
        Me.dgvBasket.Size = New System.Drawing.Size(494, 426)
        Me.dgvBasket.TabIndex = 47
        '
        'cProduct
        '
        Me.cProduct.HeaderText = "Product"
        Me.cProduct.Name = "cProduct"
        Me.cProduct.ReadOnly = True
        Me.cProduct.Width = 350
        '
        'cPrice
        '
        Me.cPrice.HeaderText = "Price"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'Button17
        '
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(342, 475)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(68, 29)
        Me.Button17.TabIndex = 48
        Me.Button17.Text = "X"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'frmPizzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 517)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.dgvBasket)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button15)
        Me.Controls.Add(Me.button14)
        Me.Controls.Add(Me.button16)
        Me.Controls.Add(Me.button13)
        Me.Controls.Add(Me.button12)
        Me.Controls.Add(Me.button11)
        Me.Controls.Add(Me.button10)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "frmPizzas"
        Me.Text = "frmPizzas"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBasket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents timer1 As Timer
    Private WithEvents lblVersion As Label
    Private WithEvents label2 As Label
    Private WithEvents lblTime As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents button15 As Button
    Private WithEvents button14 As Button
    Private WithEvents button16 As Button
    Private WithEvents button13 As Button
    Private WithEvents button12 As Button
    Private WithEvents button11 As Button
    Private WithEvents button10 As Button
    Private WithEvents button9 As Button
    Private WithEvents button8 As Button
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents dgvBasket As DataGridView
    Friend WithEvents cProduct As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
    Private WithEvents Button17 As Button
End Class
