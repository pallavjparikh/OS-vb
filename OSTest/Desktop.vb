﻿Imports System.IO
Imports System.Net
Imports DotLiquid

Public Class Desktop

    Private Function SpamRefresh(times As Integer)
        For tmp = 0 To times
            Me.Refresh()
        Next
        Return 0
    End Function

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
            DeskMenu.Show()

        ElseIf e.KeyCode = Keys.E Then
            Settings.Show()
        End If

        If e.KeyCode = Keys.F1 Then
            Settings.Show()
        End If
        Return 0
    End Function

    Private Sub KeyDownEvent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub KeyDownEvent1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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
            Settings.Show()
        End If
        If e.KeyCode = Keys.F20 Then
            Internet.Show()
        End If

    End Sub
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.WallPaper_Set.Equals(True) Then
            'Desktop.ActiveForm.BackgroundImage = Image.FromFile(My.Settings.WallPaper_Path)
        End If
        DeskTime.Text = Date.Now.ToString("HH:mm")
        DeskDate.Text = MonthName(Month(DateTime.Now)) & Date.Now.ToString(" dd, yyyy")
        Timer1.Interval = 100
        Timer1.Enabled = True
        Try
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("https://httpbin.org/get"))
        Catch ex As Exception
            NoInternet.Show()
            NoInternet.MoreInfo.Text = ex.ToString
        End Try

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Debug.Print("Modal started")
        Dim modalResult = ModalBox.ShowModal("Shutdown", "Are you sure that you want to close Revenge OS?")
        ModalBox.Close()
        Debug.Print("Modal finished // " & modalResult.ToString)
        If modalResult = 1 Then
            Try
                DeskMenu.Close()
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoginForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DeskMenu.Show()
    End Sub

    Private Sub AdminIcon_Click(sender As Object, e As EventArgs)
        ModalBox.ShowModal("Administrator", "You're using the administrator account. To revert back to the normal user, press Shift+F3.", YesNoModal:=False)
        ModalBox.Close()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DeskTime.Text = Date.Now.ToString("HH:mm")
        DeskDate.Text = MonthName(Month(DateTime.Now)) & Date.Now.ToString(" dd, yyyy")
    End Sub

    Private Sub GSearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles GSearchBar.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            Internet.Show()
            Internet.WebBrowser1.Navigate("https://google.com/search?q=" + GSearchBar.Text)
            GSearchBar.Text = ""
            Try
                DeskMenu.Close()
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SettingsIcon_Click(sender As Object, e As EventArgs) Handles SettingsIcon.Click
        Settings.Show()
    End Sub

    Private Sub PaintIcon_Click(sender As Object, e As EventArgs) Handles PaintIcon.Click
        My.Forms.Paint.Show()
    End Sub

    Private Sub FilesIcon_Click(sender As Object, e As EventArgs) Handles FilesIcon.Click
        Files.Show()
    End Sub

    Private Sub NotesIcon_Click(sender As Object, e As EventArgs) Handles NotesIcon.Click
        Notes.Show()
    End Sub

    Private Sub BrowserIcon_Click(sender As Object, e As EventArgs) Handles BrowserIcon.Click
        Internet.Show()
    End Sub

    Private Sub DeskDate_Click(sender As Object, e As EventArgs) Handles DeskDate.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        GetHelp.Show()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("C:\Program Files\Google\Chrome\Application\Chrome.exe")

    End Sub

    Private Sub GSearchBar_TextChanged(sender As Object, e As EventArgs) Handles GSearchBar.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        GSearchBar.Enabled = True
    End Sub
    Private Sub GSearchBar_Click(sender As Object, e As EventArgs) Handles GSearchBar.TextChanged
        GSearchBar.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        GSearchBar.Enabled = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        GSearchBar.Enabled = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        App_drawer.Show()
    End Sub

End Class