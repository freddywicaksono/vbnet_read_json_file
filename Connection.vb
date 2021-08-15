Imports Newtonsoft.Json
Imports System.IO
Public Class Connection
    Private _filename As String
    Private _host As String
    Private _user As String
    Private _password As String
    Private _dbname As String
    Private _port As String

    Public Property Filename()
        Get
            Return _filename
        End Get
        Set(value)
            _filename = value
        End Set
    End Property

    Public ReadOnly Property DBHost()
        Get
            Return _host
        End Get

    End Property

    Public ReadOnly Property DBUser()
        Get
            Return _user
        End Get

    End Property

    Public ReadOnly Property DBPassword()
        Get
            Return _password
        End Get

    End Property

    Public ReadOnly Property DBName()
        Get
            Return _dbname
        End Get

    End Property

    Public ReadOnly Property DBPort()
        Get
            Return _port
        End Get

    End Property

    Public Sub Connect()
        Dim json = File.ReadAllText(_filename)

        Dim data As connectionModel = JsonConvert.DeserializeObject(Of connectionModel)(json)

        _host = data.host
        _user = data.user
        _password = data.password
        _dbname = data.dbname
        _port = data.port
    End Sub

End Class
