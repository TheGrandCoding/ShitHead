﻿Public Class Form1
    Dim MadeCard As New Card
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenCards()
        Try
            For i = 0 To (playerCards.Count - 1)
                ListBox1.Items.Add(playerCards(i).Number)
                ListBox1.Items.Add(playerCards(i).Suit)
                ListBox1.Items.Add(playerCards(i).Type)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Function GenCards()
        Dim usedNums As New List(Of Integer)
        Dim NewCards As New Random
        Dim CurrCard As Integer
        Dim forcecount As Integer = 0
        Dim firstF As Integer = 0
        Dim second As Integer = 0
        Dim toggle As Boolean = False
        For x = 0 To 52
            CurrCard = NewCards.Next(1, 52)

            If usedNums.Contains(CurrCard) Then
                While usedNums.Contains(CurrCard)
                    CurrCard = NewCards.Next(CurrCard)

                    If toggle = False Then
                        firstF = CurrCard
                        toggle = True
                    Else
                        second = CurrCard
                        toggle = False
                    End If
                    If firstF = second Then
                        forcecount += 1
                    End If
                    If forcecount > 3 Then
                        Exit While
                    End If

                End While
                usedNums.Add(CurrCard)
            Else
                usedNums.Add(CurrCard)
            End If

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

        Return playerCards
        Return SpareCards
    End Function
End Class