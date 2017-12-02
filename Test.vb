Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Class Test

    Dim presentstate As sqstate
    Dim qcount, hcount As Integer
    Dim pos As New List(Of Point)
    Dim currentstage As Integer = 0
    Dim currentimage As Integer = 1000
    Dim maps As New List(Of String)
    Dim obs As New List(Of String)
    Dim switch As Boolean = False
    Dim nos As Integer = 0
    Dim lastwin As Boolean = False
    Dim score As Integer = 0
    Dim mapeasy As Boolean = True
    Dim teamname As String
    Dim log As Login
    Dim minutes As Integer
    Dim fintime, info As String
    Public Property LGN() As Login
        Get
            Return login
        End Get
        Set(ByVal value As Login)
            login = value
        End Set
    End Property
    Public Property TName() As String
        Get
            Return TeamName
        End Get
        Set(ByVal value As String)
            teamname = value
        End Set
    End Property

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        'for now
        'Dim ofd As New OpenFileDialog
        'ofd.Title = "Select the image"
        'ofd.DefaultExt = "bmp"
        'ofd.Filter = "TechZ Bitmap Files (*.bmp)|*.bmp"
        'ofd.ShowDialog()
        'Panel1.BackgroundImage = Image.FromFile(ofd.FileName)
        'ofd.Title = "Select the coresponding object"
        'ofd.DefaultExt = "tcz"
        'ofd.Filter = "TechZ Object Files (*.tcz)|*.tcz"
        'ofd.ShowDialog()
        'GetObjectFromFile(ofd.FileName)
        'end for now
        TimerTotal.Enabled = True
        Time.Text = "Remaining : " & minutes.ToString()
        Randomize()
        currentimage = CInt(Int((3 * Rnd())))
        Try
            Panel1.BackgroundImage = Image.FromFile(My.MySettings.Default.customdirectory & "\images\" & maps(currentimage))
            GetObjectFromFile(My.MySettings.Default.customdirectory & "\objects\" & obs(currentimage))
        Catch err As Exception
            Try
                Panel1.BackgroundImage = Image.FromFile("C:\Windows\symantecna\images\" & maps(currentimage))
                GetObjectFromFile("C:\Windows\symantecna\objects\" & obs(currentimage))
            Catch er As Exception
                MessageBox.Show("Stage loading problem! Contact supervisor..")
                UpNav.Enabled = False
                DownNav.Enabled = False
                LeftNav.Enabled = False
                RightNav.Enabled = False
                KeyListener.Enabled = False
                Panel1.Enabled = False
            End Try
        End Try
        You.Left = presentstate.startx * 10
        You.Top = presentstate.starty * 10
        UpNav.Enabled = True
        DownNav.Enabled = True
        LeftNav.Enabled = True
        RightNav.Enabled = True
        KeyListener.Enabled = True
        Panel1.Enabled = True
    End Sub

    Private Sub Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EasyDataSet.questionsT' table. You can move, or remove it, as needed.
        Me.QuestionsTTableAdapter.Fill(Me.EasyDataSet.questionsT)
        'TODO: This line of code loads data into the 'HardDataSet.Hard' table. You can move, or remove it, as needed.
        Me.HardTableAdapter.Fill(Me.HardDataSet.Hard)
        minutes = My.MySettings.Default.time
        SCR.Visible = My.MySettings.Default.score
        Me.hta.Fill(Me.QDS.Hard)
        Me.qta.Fill(Me.QDS.questionsT)
        qcount = QDS.questionsT.Rows.Count
        hcount = QDS.Hard.Rows.Count
        maps.Add("map1.bmp")
        maps.Add("map3.bmp")
        maps.Add("map4.bmp")
        maps.Add("map2.bmp")
        maps.Add("map5.bmp")
        maps.Add("map1b.bmp")
        maps.Add("map3b.bmp")
        maps.Add("map4b.bmp")
        maps.Add("map2b.bmp")
        maps.Add("map5b.bmp")
        obs.Add("map1.tcz")
        obs.Add("map3.tcz")
        obs.Add("map4.tcz")
        obs.Add("map2.tcz")
        obs.Add("map5.tcz")
        pos.Add(New Point(350, 140))
        pos.Add(New Point(360, 150))
        pos.Add(New Point(370, 160))
        pos.Add(New Point(380, 170))
        pos.Add(New Point(370, 180))
        pos.Add(New Point(360, 190))
        pos.Add(New Point(350, 200))
        pos.Add(New Point(340, 210))
        pos.Add(New Point(330, 200))
        pos.Add(New Point(320, 190))
        pos.Add(New Point(310, 180))
        pos.Add(New Point(300, 170))
        pos.Add(New Point(310, 160))
        pos.Add(New Point(320, 150))
        pos.Add(New Point(330, 140))
        pos.Add(New Point(340, 130))
    End Sub

    Private Sub GetObjectFromFile(ByVal file1 As String)
        Dim gsf As Stream = File.OpenRead(file1)
        Dim deserializer As New BinaryFormatter
        presentstate = CType(deserializer.Deserialize(gsf), sqstate)
    End Sub


    Private Sub UP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpNav.Click
        Try
            GoingUP()
        Catch err As Exception
        End Try
    End Sub

    Sub GoingUP()
        Dim ptop, ntop As Integer
        ptop = You.Top
        ntop = ptop - 10
        If ntop < 0 Then
            Return
        End If
        Dim s = presentstate.status.Item(ntop / 10).Item(You.Left / 10)
        If Not ptop = 0 AndAlso (s = 0 Or s = 3) Then
            You.Top = ntop
        End If
        If s = 2 Then
            If askquestion() Then
                presentstate.status.Item(ntop / 10).Item(You.Left / 10) = 3
            End If
        End If
        wincheck()
    End Sub

    Private Sub Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownNav.Click
        Try
            GoingDOWN()
        Catch err As Exception
        End Try
    End Sub

    Sub GoingDOWN()
        Dim ptop, ntop As Integer
        ptop = You.Top
        ntop = ptop + 10
        If ntop > 470 Then
            Return
        End If
        Dim s = presentstate.status.Item(ntop / 10).Item(You.Left / 10)
        If Not ptop = 470 AndAlso (s = 0 Or s = 3) Then
            You.Top = ntop
        End If
        If s = 2 Then
            If askquestion() Then
                presentstate.status.Item(ntop / 10).Item(You.Left / 10) = 3
            End If
        End If
        wincheck()
    End Sub

    Private Sub Left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftNav.Click
        Try
            GoingLEFT()
        Catch err As Exception
        End Try
    End Sub

    Sub GoingLEFT()
        Dim pleft, nleft As Integer
        pleft = You.Left
        nleft = pleft - 10
        If nleft < 0 Then
            Return
        End If
        Dim s = presentstate.status.Item(You.Top / 10).Item(nleft / 10)
        If Not pleft = 0 AndAlso (s = 0 Or s = 3) Then
            You.Left = nleft
        End If
        If s = 2 Then
            If askquestion() Then
                presentstate.status.Item(You.Top / 10).Item(nleft / 10) = 3
            End If
        End If
        wincheck()
    End Sub

    Private Sub Right_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightNav.Click
        Try
            GoingRIGHT()
        Catch err As Exception
        End Try
    End Sub

    Sub GoingRIGHT()
        Dim pleft, nleft As Integer
        pleft = You.Left
        nleft = pleft + 10
        If nleft > 630 Then
            Return
        End If
        Dim s = presentstate.status.Item(You.Top / 10).Item(nleft / 10)
        If Not pleft = 630 AndAlso (s = 0 Or s = 3) Then
            You.Left = nleft
        End If
        If s = 2 Then
            If askquestion() Then
                presentstate.status.Item(You.Top / 10).Item(nleft / 10) = 3
            End If
        End If
        wincheck()
    End Sub

    Private Sub wincheck()
        If You.Top = presentstate.endy * 10 And You.Left = presentstate.endx * 10 Then
            If lastwin Then
                Panel1.BackgroundImage = Nothing
                Panel1.BackColor = Color.Black
                TimerTotal.Enabled = False
                MessageBox.Show("You Have WON! Please do not close the application...")
                info = "WON!"
                Try
                    Dim objStreamWriter As StreamWriter
                    objStreamWriter = New StreamWriter(My.MySettings.Default.notepad, True, Encoding.Unicode)
                    objStreamWriter.WriteLine("This team WON")
                    objStreamWriter.WriteLine(teamname)
                    objStreamWriter.WriteLine(score.ToString())
                    fintime = DateTime.Now.ToString()
                    objStreamWriter.WriteLine(fintime)
                    objStreamWriter.WriteLine("Minutes Remaining" & minutes.ToString())
                    objStreamWriter.Close()
                Catch ex As Exception
                End Try
                UpNav.Enabled = False
                DownNav.Enabled = False
                LeftNav.Enabled = False
                RightNav.Enabled = False
                KeyListener.Enabled = False
                Panel1.Enabled = False
                Return
            End If
            nos = nos + 1
            If Not nos = 2 Then
                MessageBox.Show("Win! Next Stage...........")
                Randomize()
                maps.RemoveAt(currentimage + 5)
                maps.RemoveAt(currentimage)
                obs.RemoveAt(currentimage)
                currentimage = CInt(Int((2 * Rnd())))
                Try
                    Panel1.BackgroundImage = Image.FromFile(My.MySettings.Default.customdirectory & "\images\" & maps(currentimage))
                    GetObjectFromFile(My.MySettings.Default.customdirectory & "\objects\" & obs(currentimage))
                Catch e As Exception
                    Panel1.BackgroundImage = Image.FromFile("C:\Windows\symantecna\images\" & maps(currentimage))
                    GetObjectFromFile("C:\Windows\symantecna\objects\" & obs(currentimage))
                End Try
                You.Left = presentstate.startx * 10
                You.Top = presentstate.starty * 10
            Else
                lastwin = True
                mapeasy = False
                MessageBox.Show("Win! Next Stage...........")
                Randomize()
                maps.RemoveAt(currentimage + maps.Count / 2)
                maps.RemoveAt(currentimage)
                obs.RemoveAt(currentimage)
                currentimage = CInt(Int((2 * Rnd()) + 1))
                Try
                    Panel1.BackgroundImage = Image.FromFile(My.MySettings.Default.customdirectory & "\images\" & maps(currentimage))
                    GetObjectFromFile(My.MySettings.Default.customdirectory & "\objects\" & obs(currentimage))
                Catch
                    Panel1.BackgroundImage = Image.FromFile("C:\Windows\symantecna\images\" & maps(currentimage))
                    GetObjectFromFile("C:\Windows\symantecna\objects\" & obs(currentimage))
                End Try
                You.Left = presentstate.startx * 10
                You.Top = presentstate.starty * 10
            End If
        End If
    End Sub

    Private Function askquestion() As Boolean
        Randomize()
        Dim wast As Boolean
        If mapeasy Then
            Dim value As Integer = CInt(Int((qcount * Rnd())))
            Dim q As QDS.questionsTRow = QDS.questionsT.Item(value)
            Dim qdialog As New Question(pos, q.Question, q.Aone, q.Atwo, q.Athree, q.Afour, q.Acorrect)
            If qdialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If qdialog.result = True Then
                    score = score + 5
                Else
                    score = score - 2
                End If
                SCR.Text = score.ToString()
                wast = qdialog.result
                qdialog.Dispose()
                Return wast
            End If
        Else
            Dim value As Integer = CInt(Int((hcount * Rnd())))
            Dim q As QDS.HardRow = QDS.Hard.Item(value)
            Dim qdialog As New Question(pos, q.Question, q.Aone, q.Atwo, q.Athree, q.Afour, q.Acorrect)
            If qdialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If qdialog.result = True Then
                    score = score + 10
                Else
                    score = score - 4
                End If
                SCR.Text = score.ToString()
                wast = qdialog.result
                qdialog.Dispose()
                Return wast
            End If
        End If
        Return False
    End Function

    Private Sub KeyListener_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KeyListener.KeyPress
        Select Case e.KeyChar
            Case "w"
                Try
                    GoingUP()
                Catch err As Exception
                End Try
            Case "s"
                Try
                    GoingDOWN()
                Catch err As Exception
                End Try
            Case "a"
                Try
                    GoingLEFT()
                Catch err As Exception
                End Try
            Case "d"
                Try
                    GoingRIGHT()
                Catch err As Exception
                End Try
            Case Else
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not TextBox1.Text.Equals("elevenoclock") Then
            Return
        Else
            TextBox1.Clear()
            If currentimage = 1000 Then
                Return
            End If
            If switch Then
                Panel1.BackgroundImage = Image.FromFile(CurDir() & "\images\" & maps(currentimage))
                switch = False
            Else
                Panel1.BackgroundImage = Image.FromFile(CurDir() & "\images\" & maps(currentimage + maps.Count / 2))
                switch = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not TextBox1.Text.Equals("elevenoclock") Then
            Return
        Else
            TextBox1.Clear()
            You.Top = presentstate.endy * 10
            You.Left = presentstate.endx * 10
            wincheck()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text.Equals("elevenoclock") Then
            TextBox1.Clear()
            MessageBox.Show(info & "  " & score.ToString() & "  " & fintime & "  " & teamname)
        Else
            Return
        End If
    End Sub

    Private Sub Test_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LGN.Close()
        TimerTotal.Dispose()
    End Sub

    Private Sub TimerTotal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTotal.Tick
        minutes = minutes - 1
        Time.Text = "Remaining : " & minutes.ToString()
        If minutes = 0 Then
            TimerTotal.Enabled = False
            Panel1.BackgroundImage = Nothing
            Panel1.BackColor = Color.Black
            MessageBox.Show("Time is up! Please do NOT close the application...")
            Try
                Dim objStreamWriter As StreamWriter
                objStreamWriter = New StreamWriter(My.MySettings.Default.notepad, True, Encoding.Unicode)
                objStreamWriter.WriteLine("This team has timed out")
                info = "Timed Out"
                objStreamWriter.WriteLine(teamname)
                objStreamWriter.WriteLine(score.ToString())
                fintime = DateTime.Now.ToString()
                objStreamWriter.WriteLine(fintime)
                objStreamWriter.WriteLine("Minutes Remaining" & minutes.ToString())
                objStreamWriter.Close()
            Catch ex As Exception
            End Try
            UpNav.Enabled = False
            DownNav.Enabled = False
            LeftNav.Enabled = False
            RightNav.Enabled = False
            KeyListener.Enabled = False
            Panel1.Enabled = False
            Return
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a = HardDataSet.Hard.Count
        For i = 0 To HardDataSet.Hard.Count - 1
            QDS.Hard.AddHardRow(HardDataSet.Hard.Item(i).Question, HardDataSet.Hard.Item(i).ID, HardDataSet.Hard.Item(i).Aone, HardDataSet.Hard.Item(i).Atwo, HardDataSet.Hard.Item(i).Athree, HardDataSet.Hard.Item(i).Afour, HardDataSet.Hard.Item(i).Acorrect)
        Next
        For i = 0 To EasyDataSet.questionsT.Count - 1
            QDS.questionsT.AddquestionsTRow(EasyDataSet.questionsT.Item(i).Question, EasyDataSet.questionsT.Item(i).ID, EasyDataSet.questionsT.Item(i).Aone, EasyDataSet.questionsT.Item(i).Atwo, EasyDataSet.questionsT.Item(i).Athree, EasyDataSet.questionsT.Item(i).Afour, EasyDataSet.questionsT.Item(i).Acorrect)
        Next
        Me.tam.UpdateAll(Me.QDS)
    End Sub
End Class
