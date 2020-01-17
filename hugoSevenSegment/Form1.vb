Public Class Form1
    Dim second As Int32 = -1
    Dim pattern = New Integer(9, 6) {
        {1, 1, 1, 1, 1, 1, 0},
        {0, 1, 1, 0, 0, 0, 0},
        {1, 1, 0, 1, 1, 0, 1},
        {1, 1, 1, 1, 0, 0, 1},
        {0, 1, 1, 0, 0, 1, 1},
        {1, 0, 1, 1, 0, 1, 1},
        {1, 0, 1, 1, 1, 1, 1},
        {1, 1, 1, 0, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 0, 1, 1}
    }
    Dim btns(6) As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 6
            btns(i) = CType(Me.Controls("Button" & i), Button)
        Next

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1

        For i As Integer = 0 To 6
            If pattern(second, i) = 1 Then
                btns(i).BackColor = Color.Black
            Else
                btns(i).BackColor = Color.White
            End If
        Next

        If second = 9 Then
            second = 0
        End If
    End Sub
End Class
