' Class for dealing with music and sfx
Public Class HMAudio
    ' TODO 
    ' - Loop background music

    Private Shared BackgroundAudio As String = "Resources\Aftermath.mp3" ' http://incompetech.com/music/royalty-free/index.html?collection=037 © 2010 Kevin MacLeod
    Private Shared ClickSfx As String = "Resources\Click.mp3" ' http://www.freesound.org/people/gelo_papas/sounds/69396/
    Private Shared BodyPartSfx As String = "Resources\BodyPart.mp3" ' http://www.freesound.org/people/m_O_m/sounds/107772/

    ' Windows API Declarations
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Int32, ByVal hwndCallback As Int32) As Int32

    Private Shared _IsMuted As Boolean = False

    Public Shared ReadOnly Property IsMuted As Boolean
        Get
            Return _IsMuted
        End Get
    End Property

    Public Shared Sub LoadSounds()
        mciSendString("open """ & BackgroundAudio & """ type mpegvideo alias bgaudio", Nothing, 0, CInt(CInt(IntPtr.Zero)))
        mciSendString("open """ & ClickSfx & """ type mpegvideo alias clicksfx", Nothing, 0, CInt(IntPtr.Zero))
        mciSendString("open """ & BodyPartSfx & """ type mpegvideo alias bodypartsfx", Nothing, 0, CInt(IntPtr.Zero))
    End Sub

    Public Shared Sub StartBackgroundMusic()
        mciSendString("play bgaudio from 0", Nothing, 0, CInt(IntPtr.Zero))
    End Sub

    Public Shared Sub StopBackgroundMusic()
        mciSendString("stop bgaudio", Nothing, 0, CInt(IntPtr.Zero))
    End Sub

    Public Shared Sub PlayClickSound()
        If Not IsMuted Then
            mciSendString("play clicksfx from 0", Nothing, 0, CInt(IntPtr.Zero))
        End If
    End Sub

    Public Shared Sub PlayBodyPartSound()
        If Not IsMuted Then
            mciSendString("play bodypartsfx from 0", Nothing, 0, CInt(IntPtr.Zero))
        End If
    End Sub

    Public Shared Sub ToggleAudio()
        If IsMuted Then
            _IsMuted = False
            StartBackgroundMusic()
        Else
            _IsMuted = True
            StopBackgroundMusic()
        End If
    End Sub

End Class
