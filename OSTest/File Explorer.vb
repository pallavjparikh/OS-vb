Public Class File_Explorer
    Dim Path As String
    Dim Name As String
    Dim nextPath As String
    Dim bool As Boolean = False
    Dim drive_name() As String
    Dim Previous_Path As String

    Function Load(ByRef path As String)
        ListView1.Clear()
        Try
            For Each items In My.Computer.FileSystem.GetDirectories(path)
                ListView1.Items.Add(items.Substring(items.LastIndexOf("\") + 1))
            Next
            For Each items In My.Computer.FileSystem.GetFiles(path)
                ListView1.Items.Add(items.Substring(items.LastIndexOf("\") + 1))
            Next
        Catch ex As Exception
            MessageBox.Show("Directory not found. Please verify the path.", "No Directory Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Function

    Private Sub File_Explorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim total As Integer
        Dim i As Integer
        i = 0
        total = My.Computer.FileSystem.Drives.Count
        ReDim Preserve drive_name(total)
        For Each drive In My.Computer.FileSystem.Drives
            Dim D_Name = drive.ToString()
            drive_name(i) = D_Name
            D_Name = D_Name.TrimEnd("\")
            ListView1.Items.Add(D_Name)
            i = i + 1
        Next
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        On Error Resume Next
        bool = True
        Previous_Path = Path
        Path = nextPath
        Load(Path)
        TextBox1.Text = Path
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        On Error Resume Next
        nextPath = Path + e.Item.Text + "\"
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        On Error Resume Next

        If e.KeyCode = Keys.KeyCode.Enter Then
            bool = True
            Previous_Path = Path
            Path = nextPath
            Load(Path)
            TextBox1.Text = Path
        End If
        If e.KeyCode = Keys.KeyCode.Back Then
            ListView1.Clear()
            Previous_Path = My.Computer.FileSystem.GetParentPath(Path)
            For Each i In drive_name
                If (Path.Equals(i)) Then
                    bool = False
                End If
            Next
            If (bool.Equals(False)) Then
                For Each drive In My.Computer.FileSystem.Drives
                    Dim D_Name = drive.ToString()
                    D_Name = D_Name.TrimEnd("\")
                    ListView1.Items.Add(D_Name)
                    Previous_Path = ""
                    nextPath = ""
                    Path = ""
                    TextBox1.Text = ""
                Next
            Else
                Previous_Path = My.Computer.FileSystem.GetParentPath(Path)
                Load(Previous_Path)
                Path = Previous_Path
                TextBox1.Text = Path
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Path = TextBox1.Text
            Load(Path)
        Catch ex As Exception
            MessageBox.Show("Directory not found. Please verify the path.", "No Directory Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode.Equals(Keys.KeyCode.Enter)) Then
            Try
                Path = TextBox1.Text
                Load(Path)
            Catch ex As Exception
                MessageBox.Show("Directory not found. Please verify the path.", "No Directory Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class