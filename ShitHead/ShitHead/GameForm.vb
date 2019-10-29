Public Class GameForm
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim PBList As New List(Of PictureBox) From {TableCard1, TableCard2, TableCard3}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim ReturnedLists = Card.GenCards()
        playerCards = ReturnedLists.Item1
        SpareCards = ReturnedLists.Item2
        Try
            For Each card In playerCards
                ListBox1.Items.Add($"{card.Suit} - {card.Type} - {card.Number}")
            Next
            For Each card In SpareCards
                ListBox2.Items.Add($"{card.Suit} - {card.Type} - {card.Number}")
            Next
        Catch ex As Exception

        End Try
        For l = 0 To 2
            Dim rm As Resources.ResourceManager = My.Resources.ResourceManager
            Dim resname As String = "5C"
            Dim p As Image = CType(rm.GetObject(resname), Image)
            Dim pb = PBList(l)

            'pb.Image = p
            'Dim CardVal As String = "5C"

            'pb.Image = My.Resources.ezgif_6_551fa5ce788d



        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        Dim Confrim = MsgBox("Are you sure you want to quit?", vbYesNo)
        If Confrim = vbYes Then
            Me.Close()
        Else

        End If
    End Sub
End Class
