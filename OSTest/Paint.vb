Public Class Paint
    Dim xStart, yStart, xEnd, yEnd As Integer
    Dim Drawbitmap As Bitmap
    Dim Drawgraphics As Graphics
    Dim myPen As New Pen(Color.Black, 3)
    Dim myBrushWidth As Integer
    Dim smootherLocation As New Point(0, 0)
    Dim draw As Boolean = False
    Private Sub KeyDownEvent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Me.Close()
        End If
        If e.KeyCode = Keys.F19 Then
            Settings.Show()
        End If
        If e.KeyCode = Keys.F20 Then
            Internet.Show()
        End If

    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        xStart = Control.MousePosition.X - (Me.Left + PictureBox1.Left)
        yStart = Control.MousePosition.Y - (Me.Top + PictureBox1.Top)
        draw = True
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        xEnd = Control.MousePosition.X - (Me.Left + PictureBox1.Left)
        yEnd = Control.MousePosition.Y - (Me.Top + PictureBox1.Top)
        smootherLocation = New Point(0, 0)
        draw = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ColorDialog1.ShowDialog()
        myPen.Color = ColorDialog1.Color
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If draw Then
            Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.None
            If Not smootherLocation = New Point(0, 0) Then
                Drawgraphics.DrawLine(myPen, smootherLocation.X, smootherLocation.Y, e.X, e.Y)
            End If
            smootherLocation = New Point(e.X, e.Y)
            PictureBox1.Image = Drawbitmap
        End If
    End Sub

    Private Sub drawMyline()
        PictureBox1.Image = Drawbitmap
        Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Drawgraphics.DrawLine(myPen, xStart, yStart, xEnd, yEnd)
    End Sub

    Private Sub Paint_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Label3.Click
        Drawbitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Drawgraphics = Graphics.FromImage(Drawbitmap)
        PictureBox1.Image = Drawbitmap
        Drawgraphics.Clear(Color.White)
        myBrushWidth = 4

    End Sub
End Class