' Custom control for all buttons in the game which allows for a consistent look
' Uses a sprite to show different images on normal, hover and click state. The sprite should have
' width equal to the button's with and 3x the height, with each button state stacked on top of each other

Public Class HMctlButton

    Protected ImageNormal As Bitmap ' This is just a copy of the whole sprite, we don't chop of the top part to save time
    Protected ImageHover As Bitmap ' This is the hover state image, ie. the middle part of the sprite
    Protected ImageDown As Bitmap ' This is the click state image, ie. the bottom part of the sprite
    Protected SpriteIsInitalized As Boolean = False ' We do a lazy init of the sprite, triggered by the first mousemove event

    Public Sub New()
        InitializeComponent()

        ' Set common properties
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(32, 32)
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.BackColor = System.Drawing.Color.Transparent
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Padding = New System.Windows.Forms.Padding(0)

    End Sub

    Protected Sub InitSprite()
        ' Don't bomb if there isn't a sprite set
        If Me.Image Is Nothing Then
            Exit Sub
        End If

        ImageNormal = CType(Me.Image, Bitmap)
        ImageHover = New Bitmap(Me.Width, Me.Height)
        ImageDown = New Bitmap(Me.Width, Me.Height)

        Dim gfxHover, gfxDown As Graphics

        ' Get hover part, Y offset as height of the button
        gfxHover = Graphics.FromImage(ImageHover)
        gfxHover.DrawImage(Me.Image, _
            New Rectangle(0, 0, Me.Width, Me.Height), _
            New Rectangle(0, Me.Height, Me.Width, Me.Height),
            GraphicsUnit.Pixel
        )

        ' Get clicked part, Y offset twice the height of the button
        gfxDown = Graphics.FromImage(ImageDown)
        gfxDown.DrawImage(Me.Image, _
            New Rectangle(0, 0, Me.Width, Me.Height), _
            New Rectangle(0, Me.Height * 2, Me.Width, Me.Height),
            GraphicsUnit.Pixel
        )

        SpriteIsInitalized = True

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        ' Lazy init of the sprite
        If Not SpriteIsInitalized Then
            InitSprite()
        End If
        ' Failsafe in case no sprite is set
        If ImageHover Is Nothing Then
            Exit Sub
        End If
        ' Set hover image
        Me.Image = ImageHover
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If ImageDown Is Nothing Then
            Exit Sub
        End If
        ' Set clicked image
        Me.Image = ImageDown
        ' We play a click sound already on mousedown. Onclick trigger onmouse up, making the sound feel late
        HMAudio.PlayClickSound()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        If ImageNormal Is Nothing Then
            Exit Sub
        End If
        ' Reset to normal
        Me.Image = ImageNormal
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        If ImageNormal Is Nothing Then
            Exit Sub
        End If
        ' Reset to normal
        Me.Image = ImageNormal
    End Sub

End Class
