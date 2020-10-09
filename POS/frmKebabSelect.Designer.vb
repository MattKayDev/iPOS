<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKebabSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKebabSelect))
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(50, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(205, 33)
        Me.label1.TabIndex = 29
        Me.label1.Text = "Pita or Naan?"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(156, 73)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(138, 41)
        Me.button1.TabIndex = 27
        Me.button1.Text = "NAAN"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(12, 73)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(138, 41)
        Me.button3.TabIndex = 26
        Me.button3.Text = "PITA"
        Me.button3.UseVisualStyleBackColor = True
        '
        'frmKebabSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 132)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKebabSelect"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents button3 As Button
End Class
