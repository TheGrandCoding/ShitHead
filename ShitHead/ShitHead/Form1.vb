Public Class Form1
    Dim MadeCard As Card
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenCards()
        ListBox1.Items.Add(GenCards)
    End Sub

    Public Function GenCards()
        Dim usedNums As New List(Of Integer)
        Dim NewCards As New Random
        Dim CurrCard As Integer
        For x = 0 To 52
            CurrCard = NewCards.Next(1, 52)
            If usedNums.Contains(CurrCard) Then
                While usedNums.Contains(CurrCard)
                    CurrCard = NewCards.Next(1, 52)
                End While
            Else
                If CurrCard >= 1 And CurrCard <= 13 Then
                    MadeCard.Suit = "Hearts"
                    If CurrCard >= 1 And CurrCard <= 10 Then
                        MadeCard.Number = CurrCard
                        MadeCard.Type = "Number"
                    ElseIf CurrCard >= 11 And CurrCard <= 13 Then
                        MadeCard.Type = "Picture"
                        MadeCard.Number = CurrCard
                    End If
                End If

                If CurrCard > 13 And CurrCard <= 26 Then
                    MadeCard.Suit = "Spades"
                    If CurrCard >= 1 And CurrCard <= 10 Then
                        MadeCard.Number = CurrCard
                        MadeCard.Type = "Number"
                    ElseIf CurrCard >= 11 And CurrCard <= 13 Then
                        MadeCard.Type = "Picture"
                        MadeCard.Number = CurrCard
                    End If
                End If

                If CurrCard > 26 And CurrCard <= 39 Then
                    MadeCard.Suit = "Clubs"
                    If CurrCard >= 1 And CurrCard <= 10 Then
                        MadeCard.Number = CurrCard
                        MadeCard.Type = "Number"
                    ElseIf CurrCard >= 11 And CurrCard <= 13 Then
                        MadeCard.Type = "Picture"
                        MadeCard.Number = CurrCard
                    End If
                End If

                If CurrCard > 39 And CurrCard <= 52 Then
                    MadeCard.Suit = "Diamonds"
                    If CurrCard >= 1 And CurrCard <= 10 Then
                        MadeCard.Number = CurrCard
                        MadeCard.Type = "Number"
                    ElseIf CurrCard >= 11 And CurrCard <= 13 Then
                        MadeCard.Type = "Picture"
                        MadeCard.Number = CurrCard
                    End If
                End If

                If playerCards.Count <> 9 Then
                    playerCards.Add(MadeCard)

                Else
                    SpareCards.Add(MadeCard)

                End If
            End If
        Next

        Return playerCards
        Return SpareCards
    End Function
End Class
