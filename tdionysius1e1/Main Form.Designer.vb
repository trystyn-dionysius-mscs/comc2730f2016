<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblCalc = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAssessed = New System.Windows.Forms.TextBox()
        Me.lblPropTax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCalc
        '
        Me.lblCalc.AutoSize = True
        Me.lblCalc.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalc.Location = New System.Drawing.Point(187, 39)
        Me.lblCalc.Name = "lblCalc"
        Me.lblCalc.Size = New System.Drawing.Size(161, 32)
        Me.lblCalc.TabIndex = 0
        Me.lblCalc.Text = "Tax Calculator"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(64, 106)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(110, 20)
        Me.lblValue.TabIndex = 1
        Me.lblValue.Text = "&Assessed value:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(44, 215)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(108, 31)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(158, 215)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 31)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(272, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 31)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(386, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 31)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAssessed
        '
        Me.txtAssessed.Location = New System.Drawing.Point(184, 103)
        Me.txtAssessed.Name = "txtAssessed"
        Me.txtAssessed.Size = New System.Drawing.Size(100, 27)
        Me.txtAssessed.TabIndex = 2
        '
        'lblPropTax
        '
        Me.lblPropTax.AutoSize = True
        Me.lblPropTax.Location = New System.Drawing.Point(292, 106)
        Me.lblPropTax.Name = "lblPropTax"
        Me.lblPropTax.Size = New System.Drawing.Size(92, 20)
        Me.lblPropTax.TabIndex = 3
        Me.lblPropTax.Text = "Property tax:"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(390, 104)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 27)
        Me.lblTax.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 278)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtAssessed)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPropTax)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Richardson County"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalc As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAssessed As TextBox
    Friend WithEvents lblPropTax As Label
    Friend WithEvents lblTax As Label
End Class
