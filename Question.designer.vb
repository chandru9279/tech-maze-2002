<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.hand = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.a4 = New System.Windows.Forms.RadioButton
        Me.a3 = New System.Windows.Forms.RadioButton
        Me.a2 = New System.Windows.Forms.RadioButton
        Me.a1 = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Qlabel = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 3750
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 340
        Me.LineShape5.X2 = 300
        Me.LineShape5.Y1 = 209
        Me.LineShape5.Y2 = 170
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 341
        Me.LineShape3.X2 = 380
        Me.LineShape3.Y1 = 208
        Me.LineShape3.Y2 = 170
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 340
        Me.LineShape2.X2 = 382
        Me.LineShape2.Y1 = 131
        Me.LineShape2.Y2 = 171
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 300
        Me.LineShape1.X2 = 339
        Me.LineShape1.Y1 = 170
        Me.LineShape1.Y2 = 131
        '
        'hand
        '
        Me.hand.Name = "hand"
        Me.hand.X1 = 340
        Me.hand.X2 = 340
        Me.hand.Y1 = 170
        Me.hand.Y2 = 130
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.hand, Me.LineShape1, Me.LineShape2, Me.LineShape3, Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(398, 253)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'a4
        '
        Me.a4.AutoSize = True
        Me.a4.Location = New System.Drawing.Point(12, 224)
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(85, 17)
        Me.a4.TabIndex = 9
        Me.a4.TabStop = True
        Me.a4.Text = "<No Option>"
        Me.a4.UseVisualStyleBackColor = True
        '
        'a3
        '
        Me.a3.AutoSize = True
        Me.a3.Location = New System.Drawing.Point(12, 189)
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(85, 17)
        Me.a3.TabIndex = 8
        Me.a3.TabStop = True
        Me.a3.Text = "<No Option>"
        Me.a3.UseVisualStyleBackColor = True
        '
        'a2
        '
        Me.a2.AutoSize = True
        Me.a2.Location = New System.Drawing.Point(12, 155)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(85, 17)
        Me.a2.TabIndex = 7
        Me.a2.TabStop = True
        Me.a2.Text = "<No Option>"
        Me.a2.UseVisualStyleBackColor = True
        '
        'a1
        '
        Me.a1.AutoSize = True
        Me.a1.Location = New System.Drawing.Point(12, 120)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(85, 17)
        Me.a1.TabIndex = 6
        Me.a1.TabStop = True
        Me.a1.Text = "<No Option>"
        Me.a1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(249, 221)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Qlabel
        '
        Me.Qlabel.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Qlabel.Enabled = False
        Me.Qlabel.Location = New System.Drawing.Point(11, 12)
        Me.Qlabel.Multiline = True
        Me.Qlabel.Name = "Qlabel"
        Me.Qlabel.Size = New System.Drawing.Size(375, 102)
        Me.Qlabel.TabIndex = 11
        '
        'Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(398, 253)
        Me.Controls.Add(Me.Qlabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.a4)
        Me.Controls.Add(Me.a3)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Question"
        Me.Text = "Question"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents hand As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents a4 As System.Windows.Forms.RadioButton
    Friend WithEvents a3 As System.Windows.Forms.RadioButton
    Friend WithEvents a2 As System.Windows.Forms.RadioButton
    Friend WithEvents a1 As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Qlabel As System.Windows.Forms.TextBox
End Class
