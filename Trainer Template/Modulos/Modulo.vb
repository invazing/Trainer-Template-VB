Imports FontAwesome.Sharp
Module Modulo
    Private currentBtn As IconButton
    Public Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            currentBtn = CType(senderBtn, IconButton)
            If currentBtn.IconChar = IconChar.ToggleOn Then
                currentBtn.IconChar = IconChar.ToggleOff
                currentBtn.ForeColor = Color.White
            Else
                If currentBtn.IconChar = IconChar.ToggleOff Then
                    currentBtn.IconChar = IconChar.ToggleOn
                    currentBtn.ForeColor = Color.Yellow
                Else
                    If currentBtn.IconChar = IconChar.VolumeMute Then
                        PlayMusic()
                        currentBtn.IconChar = IconChar.VolumeUp
                    Else
                        If currentBtn.IconChar = IconChar.VolumeUp Then
                            StopMusic()
                            currentBtn.IconChar = IconChar.VolumeMute
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub PlayMusic()
        My.Computer.Audio.Play(My.Resources.KeyGenWAV, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub StopMusic()
        My.Computer.Audio.Stop()
    End Sub
End Module
