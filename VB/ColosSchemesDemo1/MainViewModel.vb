Imports DevExpress.Core
Imports DevExpress.Mvvm

Public Class MainViewModel
    Inherits ViewModelBase

    Public Sub New()
        Me.ColorSchemeName = Me.ColorSchemeNames(0)
    End Sub

    Protected _ColorSchemeNames As List(Of String)
    Public ReadOnly Property ColorSchemeNames() As List(Of String)
        Get
            If Me._ColorSchemeNames Is Nothing Then
                Me._ColorSchemeNames = New List(Of String)() From {
                    ThemeManager.GenericSchemeName,
                    ThemeManager.Win8SchemeName
                }
            End If
            Return Me._ColorSchemeNames
        End Get
    End Property

    Protected _Themes As List(Of ElementTheme)

    Public ReadOnly Property Themes() As List(Of ElementTheme)
        Get
            If Me._Themes Is Nothing Then
                Me._Themes = New List(Of ElementTheme)() From {
                    ElementTheme.Light,
                    ElementTheme.Dark
                }
            End If
            Return Me._Themes
        End Get
    End Property

    Public Property ColorSchemeName() As String
        Get
            Return ThemeManager.CurrentColorSchemeName
        End Get
        Set
            ThemeManager.CurrentColorSchemeName = Value
            Me.RaisePropertyChanged("ColorSchemeName")
        End Set
    End Property

End Class