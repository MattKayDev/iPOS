<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.lblIPOS = New System.Windows.Forms.Label()
        Me.btnCollection = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblByMattKayDev = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.pMain = New System.Windows.Forms.Panel()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(614, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(135, 33)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "00:00:00"
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.BackColor = System.Drawing.Color.Black
        Me.pictureBox2.Location = New System.Drawing.Point(593, 9)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(178, 50)
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'picBanner
        '
        Me.picBanner.BackgroundImage = CType(resources.GetObject("picBanner.BackgroundImage"), System.Drawing.Image)
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Location = New System.Drawing.Point(12, 9)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(328, 207)
        Me.picBanner.TabIndex = 16
        Me.picBanner.TabStop = False
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(256, -258)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(122, 47)
        Me.btnAdmin.TabIndex = 15
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        Me.btnAdmin.Visible = False
        '
        'button4
        '
        Me.button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button4.BackColor = System.Drawing.Color.Silver
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(644, -121)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(137, 47)
        Me.button4.TabIndex = 14
        Me.button4.Text = "Prices"
        Me.button4.UseVisualStyleBackColor = False
        Me.button4.Visible = False
        '
        'btnDelivery
        '
        Me.btnDelivery.BackColor = System.Drawing.Color.Green
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.Location = New System.Drawing.Point(3, 220)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(164, 60)
        Me.btnDelivery.TabIndex = 13
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = False
        '
        'lblIPOS
        '
        Me.lblIPOS.AutoSize = True
        Me.lblIPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPOS.ForeColor = System.Drawing.Color.Red
        Me.lblIPOS.Location = New System.Drawing.Point(415, 12)
        Me.lblIPOS.Name = "lblIPOS"
        Me.lblIPOS.Size = New System.Drawing.Size(81, 31)
        Me.lblIPOS.TabIndex = 12
        Me.lblIPOS.Text = "iPOS"
        '
        'btnCollection
        '
        Me.btnCollection.BackColor = System.Drawing.Color.Gold
        Me.btnCollection.FlatAppearance.BorderSize = 0
        Me.btnCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollection.Location = New System.Drawing.Point(3, 154)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(164, 60)
        Me.btnCollection.TabIndex = 11
        Me.btnCollection.Text = "Collection"
        Me.btnCollection.UseVisualStyleBackColor = False
        '
        'timer1
        '
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(418, 46)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 13)
        Me.lblVersion.TabIndex = 21
        Me.lblVersion.Tag = ""
        Me.lblVersion.Text = "999.999.999.999"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblByMattKayDev
        '
        Me.lblByMattKayDev.AutoSize = True
        Me.lblByMattKayDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblByMattKayDev.Location = New System.Drawing.Point(507, 46)
        Me.lblByMattKayDev.Name = "lblByMattKayDev"
        Me.lblByMattKayDev.Size = New System.Drawing.Size(80, 13)
        Me.lblByMattKayDev.TabIndex = 20
        Me.lblByMattKayDev.Text = "by MattKayDev"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(634, 253)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 47)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(224, -199)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 60)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Clear Order"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'pMain
        '
        Me.pMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMain.Controls.Add(Me.btnCollection)
        Me.pMain.Controls.Add(Me.btnDelivery)
        Me.pMain.Controls.Add(Me.btnClose)
        Me.pMain.Location = New System.Drawing.Point(12, 68)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(759, 303)
        Me.pMain.TabIndex = 23
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 383)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.pMain)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.lblIPOS)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblByMattKayDev)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "iPOS"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTime As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents picBanner As PictureBox
    Private WithEvents btnAdmin As Button
    Private WithEvents button4 As Button
    Private WithEvents btnDelivery As Button
    Private WithEvents lblIPOS As Label
    Private WithEvents btnCollection As Button
    Private WithEvents timer1 As Timer
    Private WithEvents lblVersion As Label
    Private WithEvents lblByMattKayDev As Label
    Private WithEvents btnClose As Button
    Private WithEvents Button6 As Button
    Friend WithEvents pMain As Panel
End Class
