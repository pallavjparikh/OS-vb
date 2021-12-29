Public Class Settings
    Private e As Object

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub


    Private Sub KeyDownEvent1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Then
            Internet.Show()
        End If
        If e.KeyCode = Keys.F13 Then
            Me.Close()
        End If
        If e.KeyCode = Keys.F15 Then
            LoginForm.Show()
        End If
        If e.KeyCode = Keys.F16 Then
            Notes.Show()
        End If
        If e.KeyCode = Keys.F17 Then
            Files.Show()
        End If
        If e.KeyCode = Keys.F18 Then
            My.Forms.Paint.Show()
        End If
        If e.KeyCode = Keys.F19 Then
            Me.Close()
        End If
        If e.KeyCode = Keys.F20 Then
            Internet.Show()
        End If

    End Sub


    Public Function ProcessKeys(e As KeyEventArgs)
        If e.KeyCode = Keys.F3 And My.Computer.Keyboard.ShiftKeyDown Then
            If My.Settings.Admin Then
                My.Settings.Admin = False
            Else
                My.Settings.Admin = True
            End If
        ElseIf e.KeyCode = Keys.OemMinus And My.Computer.Keyboard.AltKeyDown And My.Computer.Keyboard.CtrlKeyDown Then
            FatalError.Show()
        ElseIf e.KeyCode = Keys.S And My.Computer.Keyboard.AltKeyDown Then
            Internet.Show()

        ElseIf e.KeyCode = Keys.E Then
            Desktop.Show()
        End If


        Return 0
    End Function
    Private Sub BottomLabel_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox4.Click, Label4.Click
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://github.com/Pallavjparikh")
        Me.Close()
    End Sub

    Private Sub Label3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 
        If e.KeyChar = Convert.ToChar(13) Then
            MsgBox("enter key pressd ")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub WallpaperChange_Click(sender As Object, e As EventArgs) Handles WallpaperChange.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = My.Settings.DefaultPatf_Image
            OpenFileDialog1.Title = "Select an image"
            OpenFileDialog1.Filter = "image|*.jpg"
            Settings.ActiveForm.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            Desktop.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            My.Settings.BackGroundImage = OpenFileDialog1.FileName
            My.Settings.DefaultPatf_Image = OpenFileDialog1.InitialDirectory
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Settings.ActiveForm.BackgroundImage = Image.FromFile(My.Settings.BackGroundImage)
    End Sub
End Class