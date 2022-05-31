Public Class Users
    Private _id As Guid
    Private _email As String
    Private _password As String
    Private _createdat As Date
    Private _createdby As String
    Private _updatedat As Date
    Private _updatedby As String
    Sub New()

    End Sub

    Public Property Id As Guid
        Get
            Return _id
        End Get
        Set(value As Guid)
            _id = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Createdat As Date
        Get
            Return _createdat
        End Get
        Set(value As Date)
            _createdat = value
        End Set
    End Property

    Public Property Createdby As String
        Get
            Return _createdby
        End Get
        Set(value As String)
            _createdby = value
        End Set
    End Property

    Public Property Updatedat As Date
        Get
            Return _updatedat
        End Get
        Set(value As Date)
            _updatedat = value
        End Set
    End Property

    Public Property Updatedby As String
        Get
            Return _updatedby
        End Get
        Set(value As String)
            _updatedby = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim users = TryCast(obj, Users)
        Return users IsNot Nothing AndAlso
               _id.Equals(users._id) AndAlso
               _email = users._email AndAlso
               _password = users._password AndAlso
               _createdat = users._createdat AndAlso
               _createdby = users._createdby AndAlso
               _updatedat = users._updatedat AndAlso
               _updatedby = users._updatedby
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return HashCode.Combine(_id, _email, _password, _createdat, _createdby, _updatedat, _updatedby)
    End Function
End Class
