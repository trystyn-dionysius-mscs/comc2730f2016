<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tdionysius2E1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcOR = New System.Windows.Forms.Button()
        Me.btnCalcAND = New System.Windows.Forms.Button()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.txtYN = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnCalcEq = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order Amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcOR)
        Me.GroupBox1.Controls.Add(Me.btnCalcAND)
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.txtYN)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 131)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping with order over $100 with Savannah CC"
        '
        'btnCalcOR
        '
        Me.btnCalcOR.Location = New System.Drawing.Point(377, 53)
        Me.btnCalcOR.Name = "btnCalcOR"
        Me.btnCalcOR.Size = New System.Drawing.Size(95, 23)
        Me.btnCalcOR.TabIndex = 7
        Me.btnCalcOR.Text = "Calculate (Or)"
        Me.btnCalcOR.UseVisualStyleBackColor = True
        '
        'btnCalcAND
        '
        Me.btnCalcAND.Location = New System.Drawing.Point(377, 24)
        Me.btnCalcAND.Name = "btnCalcAND"
        Me.btnCalcAND.Size = New System.Drawing.Size(95, 23)
        Me.btnCalcAND.TabIndex = 6
        Me.btnCalcAND.Text = "Calculate (And)"
        Me.btnCalcAND.UseVisualStyleBackColor = True
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipping.Location = New System.Drawing.Point(239, 50)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(85, 23)
        Me.lblShipping.TabIndex = 5
        '
        'txtYN
        '
        Me.txtYN.Location = New System.Drawing.Point(119, 53)
        Me.txtYN.Name = "txtYN"
        Me.txtYN.Size = New System.Drawing.Size(34, 20)
        Me.txtYN.TabIndex = 4
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(19, 53)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(67, 20)
        Me.txtOrder.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Shipping Charge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Savannah (Y/N):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCom)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnCalc)
        Me.GroupBox2.Controls.Add(Me.btnCalcEq)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 122)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% commision for sales > 25000 with codes A1, B2, C3"
        '
        'lblCom
        '
        Me.lblCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCom.Location = New System.Drawing.Point(256, 48)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(85, 23)
        Me.lblCom.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(37, 51)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(36, 20)
        Me.txtID.TabIndex = 7
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(109, 51)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(95, 20)
        Me.txtSales.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Commission:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "&ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "&Sales:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(377, 48)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 23)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate (<>)"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnCalcEq
        '
        Me.btnCalcEq.Location = New System.Drawing.Point(377, 19)
        Me.btnCalcEq.Name = "btnCalcEq"
        Me.btnCalcEq.Size = New System.Drawing.Size(95, 23)
        Me.btnCalcEq.TabIndex = 0
        Me.btnCalcEq.Text = "Calculate (=)"
        Me.btnCalcEq.UseVisualStyleBackColor = True
        '
        'tdionysius2E1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 317)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "tdionysius2E1"
        Me.Text = "tdionysius2e1, AndAlso, Online"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalcOR As Button
    Friend WithEvents btnCalcAND As Button
    Friend WithEvents lblShipping As Label
    Friend WithEvents txtYN As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCom As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnCalcEq As Button
End Class
