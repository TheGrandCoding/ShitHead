Imports System.Data.OleDb   'this library includes functions to connect to a database
Public Class LogOn
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As New OleDbConnection
    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        'make the following your access database file path
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\cca07\C14\SeyJar14\GitHub\ShitHead\UserLogs.accdb"   'sets up the database handler and file in a string
        myConnection.ConnectionString = connString
        'query to check if the username and password are found in database
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Users] WHERE [username] = '" _
            & txtUserName.Text & "' AND [password] = '" & txtPassword.Text & "'", myConnection)
        myConnection.Open() 'open the connection to the database file
        Dim dr As OleDbDataReader = cmd.ExecuteReader   'create database reader 
        ' the following variable holds True if user is found, and False if user is not found 
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""

        'if found:
        If dr.Read Then   ' True if matched search fields
            userFound = True
            FirstName = dr("FirstName").ToString    'get the data from that record, store in FirstName
            LastName = dr("LastName").ToString      'and LastName
        End If
        'then do something with the result if user is found/not found
        If userFound = True Then
            MainMenu.Show()
            Me.Hide()

        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
            txtUserName.Focus()
        End If
        myConnection.Close()    'close the database file at the end of the sub

    End Sub

    Private Sub CmdCreate_Click(sender As Object, e As EventArgs) Handles CmdCreate.Click
        'create a new user
        Dim SQL As String
        Dim objCmd As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "\\cca07\C14\SeyJar14\GitHub\ShitHead\UserLogs.accdb"
        connString = provider & dataFile    'sets up the database and file in a string
        myConnection.ConnectionString = connString
        'add the textbox fields to the database
        SQL = "INSERT INTO Users VALUES ('" & txtUname.Text & "', '" & txtPwd.Text & "', '" &
            txtFname.Text & "', '" & txtSname.Text & "', 0 )"

        myConnection.Open() 'open the database file
        'should have some error checking in here to make sure user doesn't already exist and that


        'all input fields are appropriately completed
        Try
            objCmd = New OleDbCommand(SQL, myConnection)    'run the SQL command to insert new record
            objCmd.ExecuteNonQuery() 'update the database file
            MsgBox("Account created succesfully")
            myConnection.Close()    'close the database file
        Catch ex As Exception
            MsgBox("Account already exists please try again")
            myConnection.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
