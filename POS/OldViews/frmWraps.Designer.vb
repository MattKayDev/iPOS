<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWraps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWraps))
        Me.Button17 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvBasket = New System.Windows.Forms.DataGridView()
        Me.button15 = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        CType(Me.dgvBasket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button17
        '
        Me.Button17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(428, 655)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(68, 34)
        Me.Button17.TabIndex = 84
        Me.Button17.Text = "X"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(654, 692)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 31)
        Me.lblTotal.TabIndex = 83
        Me.lblTotal.Text = "00.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(618, 692)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 31)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "£"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(496, 692)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 31)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "TOTAL:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.dgvBasket.Location = New System.Drawing.Point(502, 64)
        Me.dgvBasket.Name = "dgvBasket"
        Me.dgvBasket.ReadOnly = True
        Me.dgvBasket.Size = New System.Drawing.Size(494, 625)
        Me.dgvBasket.TabIndex = 80
        '
        'button15
        '
        Me.button15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button15.Location = New System.Drawing.Point(12, 8)
        Me.button15.Name = "button15"
        Me.button15.Size = New System.Drawing.Size(73, 29)
        Me.button15.TabIndex = 79
        Me.button15.Text = "BACK"
        Me.button15.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(468, 39)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 13)
        Me.lblVersion.TabIndex = 78
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
        Me.label2.Location = New System.Drawing.Point(557, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 13)
        Me.label2.TabIndex = 77
        Me.label2.Text = "by MattKayDev"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(839, 16)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(135, 33)
        Me.lblTime.TabIndex = 76
        Me.lblTime.Text = "00:00:00"
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.BackColor = System.Drawing.Color.Black
        Me.pictureBox2.Location = New System.Drawing.Point(818, 8)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(178, 50)
        Me.pictureBox2.TabIndex = 75
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(465, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(172, 31)
        Me.label1.TabIndex = 74
        Me.label1.Text = "iWAVE POS"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(12, 64)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(138, 41)
        Me.button3.TabIndex = 85
        Me.button3.Text = "DONNER WRAP"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 41)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "CHICKEN WRAP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 41)
        Me.Button2.TabIndex = 87
        Me.Button2.Text = "CHICKEN FILLET WRAP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 205)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 41)
        Me.Button4.TabIndex = 88
        Me.Button4.Text = "DONNER + CHICKEN MIX WRAP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(252, 205)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 41)
        Me.Button5.TabIndex = 92
        Me.Button5.Text = "DONNER + CHICKEN MIX WRAP MEAL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(252, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(138, 41)
        Me.Button6.TabIndex = 91
        Me.Button6.Text = "CHICKEN FILLET WRAP MEAL"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(252, 111)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(138, 41)
        Me.Button7.TabIndex = 90
        Me.Button7.Text = "CHICKEN WRAP MEAL"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(252, 64)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(138, 41)
        Me.Button8.TabIndex = 89
        Me.Button8.Text = "DONNER WRAP MEAL"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(12, 315)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(138, 41)
        Me.Button9.TabIndex = 93
        Me.Button9.Text = "ADD CHEESE"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(252, 464)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(138, 41)
        Me.Button12.TabIndex = 94
        Me.Button12.Text = "MAKE IT A MEAL"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(252, 315)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(138, 41)
        Me.Button10.TabIndex = 95
        Me.Button10.Text = "SALAD"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(252, 362)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(138, 41)
        Me.Button11.TabIndex = 96
        Me.Button11.Text = "SAUCE"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'frmWraps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.button3)
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
        Me.Name = "frmWraps"
        CType(Me.dgvBasket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button17 As Button
    Private WithEvents lblTotal As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents dgvBasket As DataGridView
    Private WithEvents button15 As Button
    Private WithEvents lblVersion As Label
    Private WithEvents label2 As Label
    Private WithEvents lblTime As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Private WithEvents button3 As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Private WithEvents Button8 As Button
    Private WithEvents Button9 As Button
    Private WithEvents Button12 As Button
    Private WithEvents Button10 As Button
    Private WithEvents Button11 As Button
End Class
