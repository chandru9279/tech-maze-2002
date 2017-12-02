<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.EasyDataSet = New TecMaze.easyDataSet
        Me.You = New Microsoft.VisualBasic.PowerPacks.OvalShape
        Me.KeyListener = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DownNav = New System.Windows.Forms.Button
        Me.RightNav = New System.Windows.Forms.Button
        Me.LeftNav = New System.Windows.Forms.Button
        Me.UpNav = New System.Windows.Forms.Button
        Me.Start = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SCR = New System.Windows.Forms.TextBox
        Me.Time = New System.Windows.Forms.TextBox
        Me.TimerTotal = New System.Windows.Forms.Timer(Me.components)
        Me.QDS = New TecMaze.QDS
        Me.hta = New TecMaze.QDSTableAdapters.HardTableAdapter
        Me.tam = New TecMaze.QDSTableAdapters.TableAdapterManager
        Me.qta = New TecMaze.QDSTableAdapters.questionsTTableAdapter
        Me.HardDataSet = New TecMaze.hardDataSet
        Me.HardTableAdapter = New TecMaze.hardDataSetTableAdapters.HardTableAdapter
        Me.HTableAdapterManager = New TecMaze.hardDataSetTableAdapters.TableAdapterManager
        Me.QuestionsTTableAdapter = New TecMaze.easyDataSetTableAdapters.questionsTTableAdapter
        Me.ETableAdapterManager = New TecMaze.easyDataSetTableAdapters.TableAdapterManager
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.EasyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.QDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HardDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(120, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.AutoScroll = True
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.You})
        Me.ShapeContainer1.Size = New System.Drawing.Size(636, 476)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'EasyDataSet
        '
        Me.EasyDataSet.DataSetName = "easyDataSet"
        Me.EasyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'You
        '
        Me.You.BackColor = System.Drawing.Color.Red
        Me.You.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.You.BorderWidth = 2
        Me.You.Location = New System.Drawing.Point(2, 463)
        Me.You.Name = "OvalShape1"
        Me.You.Size = New System.Drawing.Size(10, 10)
        '
        'KeyListener
        '
        Me.KeyListener.BackColor = System.Drawing.Color.Cornsilk
        Me.KeyListener.Enabled = False
        Me.KeyListener.ForeColor = System.Drawing.Color.Black
        Me.KeyListener.Location = New System.Drawing.Point(1, 288)
        Me.KeyListener.Name = "KeyListener"
        Me.KeyListener.Size = New System.Drawing.Size(110, 75)
        Me.KeyListener.TabIndex = 13
        Me.KeyListener.Text = "Click me and keep me in focus to use keyboard. WSAD corespond to Up,Down,Left,Rig" & _
            "ht"
        Me.KeyListener.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.DownNav)
        Me.Panel2.Controls.Add(Me.RightNav)
        Me.Panel2.Controls.Add(Me.LeftNav)
        Me.Panel2.Controls.Add(Me.UpNav)
        Me.Panel2.Location = New System.Drawing.Point(1, 375)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(113, 129)
        Me.Panel2.TabIndex = 12
        '
        'DownNav
        '
        Me.DownNav.BackColor = System.Drawing.Color.Cornsilk
        Me.DownNav.Enabled = False
        Me.DownNav.ForeColor = System.Drawing.Color.Black
        Me.DownNav.Location = New System.Drawing.Point(37, 86)
        Me.DownNav.Name = "DownNav"
        Me.DownNav.Size = New System.Drawing.Size(35, 35)
        Me.DownNav.TabIndex = 9
        Me.DownNav.Text = "\/"
        Me.DownNav.UseVisualStyleBackColor = False
        '
        'RightNav
        '
        Me.RightNav.BackColor = System.Drawing.Color.Cornsilk
        Me.RightNav.Enabled = False
        Me.RightNav.ForeColor = System.Drawing.Color.Black
        Me.RightNav.Location = New System.Drawing.Point(72, 45)
        Me.RightNav.Name = "RightNav"
        Me.RightNav.Size = New System.Drawing.Size(35, 35)
        Me.RightNav.TabIndex = 8
        Me.RightNav.Text = ">"
        Me.RightNav.UseVisualStyleBackColor = False
        '
        'LeftNav
        '
        Me.LeftNav.BackColor = System.Drawing.Color.Cornsilk
        Me.LeftNav.Enabled = False
        Me.LeftNav.ForeColor = System.Drawing.Color.Black
        Me.LeftNav.Location = New System.Drawing.Point(1, 45)
        Me.LeftNav.Name = "LeftNav"
        Me.LeftNav.Size = New System.Drawing.Size(35, 35)
        Me.LeftNav.TabIndex = 7
        Me.LeftNav.Text = "<"
        Me.LeftNav.UseVisualStyleBackColor = False
        '
        'UpNav
        '
        Me.UpNav.BackColor = System.Drawing.Color.Cornsilk
        Me.UpNav.Enabled = False
        Me.UpNav.ForeColor = System.Drawing.Color.Black
        Me.UpNav.Location = New System.Drawing.Point(37, 4)
        Me.UpNav.Name = "UpNav"
        Me.UpNav.Size = New System.Drawing.Size(35, 35)
        Me.UpNav.TabIndex = 6
        Me.UpNav.Text = "/\"
        Me.UpNav.UseVisualStyleBackColor = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Cornsilk
        Me.Start.ForeColor = System.Drawing.Color.Black
        Me.Start.Location = New System.Drawing.Point(12, 14)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(81, 56)
        Me.Start.TabIndex = 11
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(3, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Switch Views"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.TextBox1.Location = New System.Drawing.Point(6, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(105, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(3, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 27)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "IW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.Location = New System.Drawing.Point(60, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 27)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "SC"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SCR
        '
        Me.SCR.BackColor = System.Drawing.Color.PeachPuff
        Me.SCR.Enabled = False
        Me.SCR.Location = New System.Drawing.Point(6, 262)
        Me.SCR.Name = "SCR"
        Me.SCR.Size = New System.Drawing.Size(105, 20)
        Me.SCR.TabIndex = 18
        Me.SCR.Text = "0"
        Me.SCR.Visible = False
        '
        'Time
        '
        Me.Time.BackColor = System.Drawing.Color.PeachPuff
        Me.Time.Enabled = False
        Me.Time.Location = New System.Drawing.Point(6, 236)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(105, 20)
        Me.Time.TabIndex = 19
        '
        'TimerTotal
        '
        Me.TimerTotal.Interval = 60000
        '
        'QDS
        '
        Me.QDS.DataSetName = "QDS"
        Me.QDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'hta
        '
        Me.hta.ClearBeforeFill = True
        '
        'tam
        '
        Me.tam.BackupDataSetBeforeUpdate = False
        Me.tam.HardTableAdapter = Me.hta
        Me.tam.questionsTTableAdapter = Me.qta
        Me.tam.UpdateOrder = TecMaze.QDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'qta
        '
        Me.qta.ClearBeforeFill = True
        '
        'HardDataSet
        '
        Me.HardDataSet.DataSetName = "hardDataSet"
        Me.HardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HardTableAdapter
        '
        Me.HardTableAdapter.ClearBeforeFill = True
        '
        'HTableAdapterManager
        '
        Me.HTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.HTableAdapterManager.HardTableAdapter = Me.HardTableAdapter
        Me.HTableAdapterManager.UpdateOrder = TecMaze.hardDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuestionsTTableAdapter
        '
        Me.QuestionsTTableAdapter.ClearBeforeFill = True
        '
        'ETableAdapterManager
        '
        Me.ETableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.ETableAdapterManager.questionsTTableAdapter = Me.QuestionsTTableAdapter
        Me.ETableAdapterManager.UpdateOrder = TecMaze.easyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(166, 509)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(780, 544)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.SCR)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KeyListener)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Test"
        Me.Text = "w"
        Me.Panel1.ResumeLayout(False)
        CType(Me.EasyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.QDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HardDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents You As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents KeyListener As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DownNav As System.Windows.Forms.Button
    Friend WithEvents RightNav As System.Windows.Forms.Button
    Friend WithEvents LeftNav As System.Windows.Forms.Button
    Friend WithEvents UpNav As System.Windows.Forms.Button
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SCR As System.Windows.Forms.TextBox
    Friend WithEvents Time As System.Windows.Forms.TextBox
    Friend WithEvents TimerTotal As System.Windows.Forms.Timer
    Friend WithEvents QDS As TecMaze.QDS
    Friend WithEvents hta As TecMaze.QDSTableAdapters.HardTableAdapter
    Friend WithEvents tam As TecMaze.QDSTableAdapters.TableAdapterManager
    Friend WithEvents qta As TecMaze.QDSTableAdapters.questionsTTableAdapter
    Friend WithEvents HardDataSet As TecMaze.hardDataSet
    Friend WithEvents HardTableAdapter As TecMaze.hardDataSetTableAdapters.HardTableAdapter
    Friend WithEvents HTableAdapterManager As TecMaze.hardDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EasyDataSet As TecMaze.easyDataSet
    Friend WithEvents QuestionsTTableAdapter As TecMaze.easyDataSetTableAdapters.questionsTTableAdapter
    Friend WithEvents ETableAdapterManager As TecMaze.easyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
