<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurger))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button15 = New System.Windows.Forms.Button()
        Me.dgvBasket = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBasket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(409, 44)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 13)
        Me.lblVersion.TabIndex = 56
        Me.lblVersion.Tag = ""
        Me.lblVersion.Text = "999.999.999.999"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(498, 44)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 13)
        Me.label2.TabIndex = 55
        Me.label2.Text = "by MattKayDev"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(839, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(135, 33)
        Me.lblTime.TabIndex = 54
        Me.lblTime.Text = "00:00:00"
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.BackColor = System.Drawing.Color.Black
        Me.pictureBox2.Location = New System.Drawing.Point(818, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(178, 50)
        Me.pictureBox2.TabIndex = 53
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(406, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(172, 31)
        Me.label1.TabIndex = 52
        Me.label1.Text = "iWAVE POS"
        '
        'button15
        '
        Me.button15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button15.Location = New System.Drawing.Point(12, 12)
        Me.button15.Name = "button15"
        Me.button15.Size = New System.Drawing.Size(73, 29)
        Me.button15.TabIndex = 57
        Me.button15.Text = "BACK"
        Me.button15.UseVisualStyleBackColor = True
        '
        'dgvBasket
        '
        Me.dgvBasket.AllowUserToAddRows = False
        Me.dgvBasket.AllowUserToDeleteRows = False
        Me.dgvBasket.AllowUserToResizeColumns = False
        Me.dgvBasket.AllowUserToResizeRows = False
        Me.dgvBasket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBasket.Location = New System.Drawing.Point(502, 68)
        Me.dgvBasket.Name = "dgvBasket"
        Me.dgvBasket.ReadOnly = True
        Me.dgvBasket.Size = New System.Drawing.Size(494, 595)
        Me.dgvBasket.TabIndex = 58
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(654, 666)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 31)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "00.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(618, 666)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 31)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "£"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(496, 666)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 31)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "TOTAL:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button17
        '
        Me.Button17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(429, 629)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(68, 34)
        Me.Button17.TabIndex = 62
        Me.Button17.Text = "X"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.Location = New System.Drawing.Point(244, 68)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(138, 41)
        Me.button8.TabIndex = 70
        Me.button8.Text = "CHICKEN FILLET BURGER MEAL"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.Location = New System.Drawing.Point(12, 209)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(138, 41)
        Me.button7.TabIndex = 69
        Me.button7.Text = "CHICKEN TIKKA BURGER"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.Location = New System.Drawing.Point(12, 351)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(138, 41)
        Me.button6.TabIndex = 68
        Me.button6.Text = "HAWAIIAN BURGER"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.Location = New System.Drawing.Point(12, 304)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(138, 41)
        Me.button5.TabIndex = 67
        Me.button5.Text = "MEXICAN BURGER"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(12, 257)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(138, 41)
        Me.button4.TabIndex = 66
        Me.button4.Text = "CHICKEN SIZZLER BURGER"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(12, 162)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(138, 41)
        Me.button3.TabIndex = 65
        Me.button3.Text = "CHICKEN FILLET BURGER"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(12, 115)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(138, 41)
        Me.button2.TabIndex = 64
        Me.button2.Text = "CHEESE BURGER"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(12, 68)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(138, 41)
        Me.button1.TabIndex = 63
        Me.button1.Text = "BEEF BURGER"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(244, 115)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(138, 41)
        Me.Button9.TabIndex = 71
        Me.Button9.Text = "CHICKEN TIKKA BURGER MEAL"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(244, 162)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(138, 41)
        Me.Button10.TabIndex = 72
        Me.Button10.Text = "CHICKEN SIZZLER BURGER MEAL"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(244, 257)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(138, 41)
        Me.Button11.TabIndex = 73
        Me.Button11.Text = "ADD CHEESE"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(244, 304)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(138, 41)
        Me.Button12.TabIndex = 74
        Me.Button12.Text = "SALAD/SAUCE?"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(244, 519)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(138, 41)
        Me.Button13.TabIndex = 95
        Me.Button13.Text = "MAKE IT A MEAL"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(244, 397)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(138, 41)
        Me.Button14.TabIndex = 96
        Me.Button14.Text = "NO CHEESE"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'frmBurger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvBasket)
        Me.Controls.Add(Me.button15)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBurger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBasket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblVersion As Label
    Private WithEvents label2 As Label
    Private WithEvents lblTime As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents button15 As Button
    Private WithEvents dgvBasket As DataGridView
    Private WithEvents lblTotal As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Button17 As Button
    Private WithEvents button8 As Button
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents Button9 As Button
    Private WithEvents Button10 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Private WithEvents Button11 As Button
    Private WithEvents Button12 As Button
    Private WithEvents Button13 As Button
    Private WithEvents Button14 As Button
End Class
