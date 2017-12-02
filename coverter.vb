Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Public Class coverter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim presentstate As New sqstate
        presentstate.status = New List(Of List(Of Integer))

        Dim objStreamWriter As New StreamReader("c:\Test2.txt")

        presentstate.startx = Integer.Parse(objStreamWriter.ReadLine())
        presentstate.starty = Integer.Parse(objStreamWriter.ReadLine())
        presentstate.endx = Integer.Parse(objStreamWriter.ReadLine())
        presentstate.endy = Integer.Parse(objStreamWriter.ReadLine())
        For x = 0 To 47
            presentstate.status.Add(New List(Of Integer))
            For y = 0 To 63
                presentstate.status(x).Add(Integer.Parse(objStreamWriter.ReadLine()))
            Next y
        Next x
        objStreamWriter.Close()
        Dim psf As Stream = File.Create(Interaction.InputBox("FileName"))
        Dim serializer As New BinaryFormatter
        serializer.Serialize(psf, presentstate)
        psf.Close()
    End Sub
End Class