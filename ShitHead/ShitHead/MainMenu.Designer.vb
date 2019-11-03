<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.cmdStore = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.Yellow
        Me.cmdPlay.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPlay.ForeColor = System.Drawing.Color.Yellow
        Me.cmdPlay.Location = New System.Drawing.Point(84, 60)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(207, 55)
        Me.cmdPlay.TabIndex = 0
        Me.cmdPlay.Text = "Play ShitHead"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'cmdStore
        '
        Me.cmdStore.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStore.ForeColor = System.Drawing.Color.Yellow
        Me.cmdStore.Location = New System.Drawing.Point(84, 142)
        Me.cmdStore.Name = "cmdStore"
        Me.cmdStore.Size = New System.Drawing.Size(207, 55)
        Me.cmdStore.TabIndex = 1
        Me.cmdStore.Text = "Store"
        Me.cmdStore.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.ForeColor = System.Drawing.Color.Yellow
        Me.cmdExit.Location = New System.Drawing.Point(84, 225)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(207, 55)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Quit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdLogOut
        '
        Me.cmdLogOut.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogOut.ForeColor = System.Drawing.Color.Yellow
        Me.cmdLogOut.Location = New System.Drawing.Point(84, 304)
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.Size = New System.Drawing.Size(207, 55)
        Me.cmdLogOut.TabIndex = 3
        Me.cmdLogOut.Text = "Log Out"
        Me.cmdLogOut.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(383, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdLogOut)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdStore)
        Me.Controls.Add(Me.cmdPlay)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdPlay As Button
    Friend WithEvents cmdStore As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdLogOut As Button
End Class
