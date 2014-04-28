Imports System.Globalization

''' <summary>
''' A text control that only allows numbers. May be configured to allow decimals numbers and/or negative numbers and/or spaces
''' </summary>
''' <remarks></remarks>
Public Class NumericTextbox
    Inherits TextBox

    Private SpaceOK As Boolean = False
    Private DecimalOK As Boolean = False
    Private NegativeOK As Boolean = False
    Private DecimalSeparator As String
    Private NegativeSign As String

    ' Restricts the entry of characters to digits (including hex),
    ' the negative sign, the e decimal point, and editing keystrokes (backspace).
    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)

        Dim numberFormatInfo As NumberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
        DecimalSeparator = numberFormatInfo.NumberDecimalSeparator
        NegativeSign = numberFormatInfo.NegativeSign

        Dim keyInput As String = e.KeyChar.ToString()

        If [Char].IsDigit(e.KeyChar) Then
            ' Digits are OK
        ElseIf Me.DecimalOK AndAlso keyInput.Equals(DecimalSeparator) AndAlso Not HasDecimalSeparator() Then
            ' Decimal separator is OK
        ElseIf Me.NegativeOK AndAlso keyInput.Equals(negativeSign) AndAlso Not HasNegativeSign() Then

            ' Negative input is OK
        ElseIf e.KeyChar = vbBack Then

        ElseIf Me.SpaceOK AndAlso e.KeyChar = " "c Then

        Else
            ' Consume this invalid key and beep.
            e.Handled = True
        End If

    End Sub

    ''' <summary>
    ''' Returns true if the text field already has a negative sign
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function HasNegativeSign() As Boolean
        Return Me.Text.IndexOf(NegativeSign) > -1
    End Function

    ''' <summary>
    ''' Returns true if the text field already has a decimal seperator
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function HasDecimalSeparator() As Boolean
        Return Me.Text.IndexOf(DecimalSeparator) > -1
    End Function

    ''' <summary>
    ''' Returns the integer value of the control (0 if non-parseable)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IntValue() As Integer
        Get
            Try
                Return Int32.Parse(Me.Text)
            Catch ex As Exception
                Return 0
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Returns the decimal value of the control (.0 if non-parseable)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DecimalValue() As Decimal
        Get
            Try
                Return [Decimal].Parse(Me.Text)
            Catch ex As Exception
                Return 0
            End Try
        End Get
    End Property


    ''' <summary>
    ''' Sets whether or not spaces are allowed 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AllowSpace() As Boolean
        Get
            Return Me.SpaceOK
        End Get
        Set(ByVal value As Boolean)
            Me.SpaceOK = value
        End Set
    End Property

    ''' <summary>
    ''' Sets whether or not decimal numbers are allowed
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AllowDecimal() As Boolean
        Get
            Return Me.DecimalOK
        End Get
        Set(ByVal value As Boolean)
            Me.DecimalOK = value
        End Set
    End Property

    ''' <summary>
    ''' Sets whehter or not negative numbers are allowed
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AllowNegative() As Boolean
        Get
            Return Me.NegativeOK
        End Get
        Set(ByVal value As Boolean)
            Me.NegativeOK = value
        End Set
    End Property
End Class
