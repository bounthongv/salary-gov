Public Class FrmButton
    Dim IsCreated(99) As Boolean
    Dim Buttons As New Dictionary(Of String, Button)

    Private Sub FrmButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyButton(10) As Label
        Dim MyPoint As Point
        Dim I As Integer
        Dim Xpos As Integer
        Dim Ypos As Integer

        REM set initial X and Y location for first button
        Xpos = 23
        Ypos = 23

        For I = 1 To 10
            REM create Point object to use with Location
            MyPoint.X = Xpos
            MyPoint.Y = Ypos
            REM create a new button
            MyButton(I) = New Label
            MyButton(I).Name = "LBW" & I
            MyButton(I).Text = "LBW" & I
            MyButton(I).Location = MyPoint
            MyButton(I).Visible = True
            REM add new button to "Me" which is Form1
            Me.Controls.Add(MyButton(I))
            Xpos = Xpos + 100
        Next I

        For I = 1 To 10
            If I Mod 2 = 0 Then
                MyButton(I).Visible = False
            End If
        Next

    End Sub


End Class