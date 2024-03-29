﻿Public Class Card
    Public Suit As String
    Public Number As Integer
    Public Type As String

    Public Shared Function GenCards() As Tuple(Of List(Of Card), List(Of Card))
        Dim playerCards As New List(Of Card)
        Dim SpareCards As New List(Of Card)
        Dim usedNums As New List(Of Integer)
        Dim NewCards As New Random()
        Dim CurrCard As Integer

        For x = 1 To 52
            CurrCard = NewCards.Next(1, 53)

            If usedNums.Contains(CurrCard) Then
                While usedNums.Contains(CurrCard)
                    CurrCard = NewCards.Next(1, 53)
                End While
            End If
            usedNums.Add(CurrCard)
            Dim MadeCard As New Card

            If CurrCard >= 1 And CurrCard <= 13 Then
                MadeCard.Suit = "Hearts"
                If CurrCard >= 1 And CurrCard < 10 Then
                    If CurrCard = 1 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 2 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 3 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 4 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 5 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 6 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 7 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 8 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 9 Then
                        MadeCard.Number = 10
                        MadeCard.Type = "Number"
                    End If

                ElseIf CurrCard = 10 Then
                    MadeCard.Number = 1
                    MadeCard.Type = "ace"

                ElseIf CurrCard > 10 And CurrCard <= 13 Then
                    If CurrCard = 11 Then
                        MadeCard.Type = "Jack"
                    ElseIf CurrCard = 12 Then
                        MadeCard.Type = "Queen"
                    ElseIf CurrCard = 13 Then
                        MadeCard.Type = "King"
                    End If

                End If
            End If



            If CurrCard > 13 And CurrCard <= 26 Then
                MadeCard.Suit = "Spades"
                If CurrCard > 13 And CurrCard <= 22 Then
                    If CurrCard = 14 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 15 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 16 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 17 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 18 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 19 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 20 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 21 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 22 Then
                        MadeCard.Number = 10
                        MadeCard.Type = "Number"
                    End If

                ElseIf CurrCard = 23 Then
                    MadeCard.Number = 1
                    MadeCard.Type = "ace"

                ElseIf CurrCard > 23 And CurrCard <= 26 Then
                    If CurrCard = 24 Then
                        MadeCard.Type = "Jack"
                    ElseIf CurrCard = 25 Then
                        MadeCard.Type = "Queen"
                    ElseIf CurrCard = 26 Then
                        MadeCard.Type = "King"
                    End If


                End If
            End If



            If CurrCard > 26 And CurrCard <= 39 Then
                MadeCard.Suit = "Clubs"
                If CurrCard > 26 And CurrCard <= 35 Then
                    If CurrCard = 27 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 28 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 29 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 30 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 31 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 32 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 33 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 34 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 35 Then
                        MadeCard.Number = 10
                        MadeCard.Type = "Number"
                    End If

                ElseIf CurrCard = 36 Then
                    MadeCard.Number = 1
                    MadeCard.Type = "ace"

                ElseIf CurrCard > 36 And CurrCard <= 39 Then
                    If CurrCard = 37 Then
                        MadeCard.Type = "Jack"
                    ElseIf CurrCard = 38 Then
                        MadeCard.Type = "Queen"
                    ElseIf CurrCard = 39 Then
                        MadeCard.Type = "King"
                    End If
                End If
            End If



            If CurrCard > 39 And CurrCard <= 52 Then
                MadeCard.Suit = "Diamonds"
                If CurrCard > 39 And CurrCard <= 48 Then
                    If CurrCard = 40 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 41 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 42 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 43 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 44 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 45 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 46 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 47 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "Number"
                    ElseIf CurrCard = 48 Then
                        MadeCard.Number = 10
                        MadeCard.Type = "Number"
                    End If

                ElseIf CurrCard = 49 Then
                    MadeCard.Number = 1
                    MadeCard.Type = "ace"
                ElseIf CurrCard >= 50 And CurrCard <= 52 Then
                    If CurrCard = 50 Then
                        MadeCard.Type = "Jack"
                    ElseIf CurrCard = 51 Then
                        MadeCard.Type = "Queen"
                    ElseIf CurrCard = 52 Then
                        MadeCard.Type = "King"
                    End If

                End If
            End If

            If playerCards.Count <> 9 Then
                playerCards.Add(MadeCard)

            Else
                SpareCards.Add(MadeCard)

            End If


        Next

        Return New Tuple(Of List(Of Card), List(Of Card))(playerCards, SpareCards)

    End Function
End Class

