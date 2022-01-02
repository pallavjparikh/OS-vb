Public Class MusicPlayer
    Dim song_path As String
    Dim m As Integer = 0
    Dim s As Integer = 0
    Dim Song_is_Playing As Boolean = False
    Dim New_Song As Boolean = True
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        If (All_Music.Items.Count.Equals(0)) Then
            MessageBox.Show("Please choose a directory that has .mp3 or .mp4 file supported", "No Song Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (New_Song) Then
            Timer1.Enabled = False
            Dim Song As String = song_path + "\"
            Song = Song + All_Music.SelectedItem
            Player.URL = Song
            New_Song = False
            Label1.Text = Player.Ctlcontrols.currentPositionString
            Label2.Text = Player.currentMedia.durationString
            Timer1.Enabled = True
            TrackBar1.Maximum = Player.Ctlcontrols.currentItem.duration
        End If
        If (Song_is_Playing) Then
            Timer1.Enabled = False
            Player.Ctlcontrols.pause()
            Song_is_Playing = False
            Label1.Text = Player.Ctlcontrols.currentPositionString
        Else
            Label1.Text = Player.Ctlcontrols.currentPositionString
            Player.Ctlcontrols.play()
            Song_is_Playing = True
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub List_Click(sender As Object, e As EventArgs) Handles List.Click
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            My.Settings.Music_Path_Set = True
            Dim File_Path As New IO.FileInfo((OpenFileDialog1.FileName()))
            My.Settings.Music_Path = File_Path.DirectoryName()
            Dim Path As String = File_Path.DirectoryName()
            song_path = Path
            Dim Files() As String = System.IO.Directory.GetFiles(Path, "*.mp3")
            For Each item As String In Files
                All_Music.Items.Add(System.IO.Path.GetFileName(item))
            Next
            Files = System.IO.Directory.GetFiles(Path, "*.m4a")
            For Each item As String In Files
                All_Music.Items.Add(System.IO.Path.GetFileName(item))
            Next
            All_Music.SelectedIndex = 0
        End If
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        Dim Song As String = song_path + "\"
        Dim Song_name As String
        If (All_Music.Items.Count > 0) Then
            If (All_Music.SelectedIndex > 0) Then
                Timer1.Enabled = False
                Song_name = All_Music.Items(All_Music.SelectedIndex - 1)
                Song = Song + Song_name
                All_Music.SelectedItem = All_Music.Items(All_Music.SelectedIndex - 1)
                Timer1.Enabled = True
                Try
                    Player.URL = Song
                    TrackBar1.Maximum = Player.Ctlcontrols.currentItem.duration
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                Timer1.Enabled = False
                All_Music.SelectedItem = All_Music.Items(All_Music.Items.Count - 1)
                Song_name = All_Music.SelectedItem
                Song = Song + Song_name
                Player.URL = Song
                TrackBar1.Maximum = Player.Ctlcontrols.currentItem.duration
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Skip_Forward_Click(sender As Object, e As EventArgs) Handles Skip_Forward.Click
        If (Song_is_Playing) Then
            If (Player.Ctlcontrols.currentPosition > 0 And (Player.Ctlcontrols.currentPosition + 5) < Player.currentMedia.duration) Then
                Player.Ctlcontrols.currentPosition = Player.Ctlcontrols.currentPosition + 5
                Label1.Text = Player.Ctlcontrols.currentPositionString
            End If
        End If
    End Sub

    Private Sub Skip_Backward_Click(sender As Object, e As EventArgs) Handles Skip_Backward.Click
        If (Song_is_Playing) Then
            If (Player.Ctlcontrols.currentPosition > 5) Then
                Player.Ctlcontrols.currentPosition = Player.Ctlcontrols.currentPosition - 5
                Label1.Text = Player.Ctlcontrols.currentPositionString
            Else
                Player.Ctlcontrols.currentPosition = 0
                Label1.Text = Player.Ctlcontrols.currentPositionString
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TrackBar1.Maximum = Player.currentMedia.duration - 1D
        TrackBar1.Value = Player.Ctlcontrols.currentPosition - 1D
        Label1.Text = Player.Ctlcontrols.currentPositionString
        Label2.Text = Player.currentMedia.durationString
        If (TrackBar1.Value.Equals(TrackBar1.Maximum - 1)) Then
            If (All_Music.SelectedIndex < All_Music.Items.Count - 1) Then
                Timer1.Enabled = False
                All_Music.SelectedIndex = All_Music.SelectedIndex + 1
                Dim Song As String = song_path + "\"
                Song = Song + All_Music.SelectedItem
                Player.URL = Song
                Timer1.Enabled = True
            Else
                Timer1.Enabled = False
                All_Music.SelectedIndex = 0
                Dim Song As String = song_path + "\"
                Song = Song + All_Music.SelectedItem
                Player.URL = Song
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Player.Ctlcontrols.currentPosition = TrackBar1.Value
        Label1.Text = Player.Ctlcontrols.currentPositionString
    End Sub

    Private Sub All_Music_SelectedIndexChanged(sender As Object, e As EventArgs) Handles All_Music.SelectedIndexChanged
        New_Song = True
    End Sub

    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        Volume.Maximum = 200
        Player.settings.volume = Volume.Value
    End Sub

    Private Sub MusicPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player.settings.volume = 30
        Label2.Text = "00:00"
        Label1.Text = "00:00"
        song_path = My.Settings.Music_Path
        Dim Files() As String = System.IO.Directory.GetFiles(song_path, "*.mp3")
        For Each item As String In Files
            All_Music.Items.Add(System.IO.Path.GetFileName(item))
        Next
        Files = System.IO.Directory.GetFiles(song_path, "*.m4a")
        For Each item As String In Files
            All_Music.Items.Add(System.IO.Path.GetFileName(item))
        Next
        If (All_Music.Items.Count > 0) Then
            All_Music.SelectedIndex = 0
            New_Song = True
        End If
    End Sub
End Class