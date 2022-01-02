<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicPlayer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusicPlayer))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Play = New System.Windows.Forms.Button()
        Me.List = New System.Windows.Forms.Button()
        Me.Next_S = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.Skip_Forward = New System.Windows.Forms.Button()
        Me.Skip_Backward = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.All_Music = New System.Windows.Forms.ListBox()
        Me.Master_Volume = New System.Windows.Forms.Label()
        Me.Volume = New System.Windows.Forms.TrackBar()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(713, 415)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(75, 23)
        Me.Player.TabIndex = 0
        Me.Player.Visible = False
        '
        'Play
        '
        Me.Play.Location = New System.Drawing.Point(12, 338)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(95, 43)
        Me.Play.TabIndex = 1
        Me.Play.Text = "Play/Pause"
        Me.Play.UseVisualStyleBackColor = True
        '
        'List
        '
        Me.List.Location = New System.Drawing.Point(157, 338)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(95, 43)
        Me.List.TabIndex = 2
        Me.List.Text = "Select a directory"
        Me.List.UseVisualStyleBackColor = True
        '
        'Next_S
        '
        Me.Next_S.Location = New System.Drawing.Point(309, 338)
        Me.Next_S.Name = "Next_S"
        Me.Next_S.Size = New System.Drawing.Size(95, 43)
        Me.Next_S.TabIndex = 3
        Me.Next_S.Text = "Next_S"
        Me.Next_S.UseVisualStyleBackColor = True
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(441, 338)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(95, 43)
        Me.Previous.TabIndex = 4
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'Skip_Forward
        '
        Me.Skip_Forward.Location = New System.Drawing.Point(557, 338)
        Me.Skip_Forward.Name = "Skip_Forward"
        Me.Skip_Forward.Size = New System.Drawing.Size(95, 43)
        Me.Skip_Forward.TabIndex = 5
        Me.Skip_Forward.Text = "Skip_Forward"
        Me.Skip_Forward.UseVisualStyleBackColor = True
        '
        'Skip_Backward
        '
        Me.Skip_Backward.Location = New System.Drawing.Point(683, 338)
        Me.Skip_Backward.Name = "Skip_Backward"
        Me.Skip_Backward.Size = New System.Drawing.Size(95, 43)
        Me.Skip_Backward.TabIndex = 6
        Me.Skip_Backward.Text = "Skip_Backward"
        Me.Skip_Backward.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(75, 401)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(559, 56)
        Me.TrackBar1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!)
        Me.Label1.Location = New System.Drawing.Point(18, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!)
        Me.Label2.Location = New System.Drawing.Point(640, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'All_Music
        '
        Me.All_Music.FormattingEnabled = True
        Me.All_Music.ItemHeight = 16
        Me.All_Music.Location = New System.Drawing.Point(0, -2)
        Me.All_Music.Name = "All_Music"
        Me.All_Music.Size = New System.Drawing.Size(677, 340)
        Me.All_Music.TabIndex = 11
        '
        'Master_Volume
        '
        Me.Master_Volume.AutoSize = True
        Me.Master_Volume.Location = New System.Drawing.Point(691, 292)
        Me.Master_Volume.Name = "Master_Volume"
        Me.Master_Volume.Size = New System.Drawing.Size(97, 16)
        Me.Master_Volume.TabIndex = 19
        Me.Master_Volume.Text = "Master Volume"
        '
        'Volume
        '
        Me.Volume.Location = New System.Drawing.Point(713, 95)
        Me.Volume.Name = "Volume"
        Me.Volume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Volume.Size = New System.Drawing.Size(56, 104)
        Me.Volume.TabIndex = 20
        '
        'MusicPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 469)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.Master_Volume)
        Me.Controls.Add(Me.All_Music)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Skip_Backward)
        Me.Controls.Add(Me.Skip_Forward)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.Next_S)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Player)
        Me.Name = "MusicPlayer"
        Me.Text = "MusicPlayer"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Play As Button
    Friend WithEvents List As Button
    Friend WithEvents Next_S As Button
    Friend WithEvents Previous As Button
    Friend WithEvents Skip_Forward As Button
    Friend WithEvents Skip_Backward As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents All_Music As ListBox
    Friend WithEvents Master_Volume As Label
    Friend WithEvents Volume As TrackBar
End Class
