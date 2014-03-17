Imports System.Drawing.Imaging
' Utility class for image manipulation operations
Public Class HMImageUtils

    ' Takes a image buffer and applies a color matrix to set the opacity. imgOpac is a decimal value between 0 (fully transparent) and 1 (fully opaque)
    Public Shared Function SetImgOpacity(ByVal imgPic As Image, ByVal imgOpac As Double) As Image

        ' Initialize canvas and relevant objects
        Dim bmpPic As New Bitmap(imgPic.Width, imgPic.Height)
        Dim gfxPic As Graphics = Graphics.FromImage(bmpPic)
        Dim cmxPic As New ColorMatrix()
        Dim iaPic As New ImageAttributes()

        ' Apply the supplied to opacity value to the "cell" in the matrix representing the alpha channel
        cmxPic.Matrix33 = CSng(imgOpac)

        ' Apply the matrix
        iaPic.SetColorMatrix(cmxPic, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        ' Draw the image to the canvas
        gfxPic.DrawImage(imgPic, New Rectangle(0, 0, bmpPic.Width, bmpPic.Height), 0, 0, imgPic.Width, imgPic.Height, GraphicsUnit.Pixel, iaPic)

        ' Clean up to save memory
        gfxPic.Dispose()
        iaPic.Dispose()

        ' Return the new canvas which can be set in a picturebox, as a background etc
        Return bmpPic

    End Function

End Class
