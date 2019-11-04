Public Class MainMenu
    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        GameForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmdStore_Click(sender As Object, e As EventArgs) Handles cmdStore.Click
        Store.Show()
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim Confrim = MsgBox("Are you sure you want to quit?", vbYesNo)
        If Confrim = vbYes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub cmdLogOut_Click(sender As Object, e As EventArgs) Handles cmdLogOut.Click
        LogOn.Show()
        Me.Hide()
    End Sub
End Class