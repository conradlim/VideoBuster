Namespace Models

    Public Class Movie
        Private m_id As Integer
        Public Property id() As Integer
            Get
                Return m_id
            End Get
            Set(ByVal value As Integer)
                m_id = value
            End Set
        End Property


        Private m_Name As String
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(ByVal value As String)
                m_Name = value
            End Set
        End Property

        Private m_Genre As String
        Public Property Genre() As String
            Get
                Return m_Genre
            End Get
            Set(ByVal value As String)
                m_Genre = value
            End Set
        End Property

        Private m_ReleaseDate As Date
        Public Property ReleaseDate() As Date
            Get
                Return m_ReleaseDate
            End Get
            Set(ByVal value As Date)
                m_ReleaseDate = value
            End Set
        End Property

        'Private m_DateAddedToDb As DateTime
        'Public Property DateAddedToDb() As DateTime
        '    Get
        '        Return m_DateAddedToDb
        '    End Get
        '    Set(ByVal value As DateTime)
        '        m_DateAddedToDb = value
        '    End Set
        'End Property


        Private m_DateAddedToDb As DateTime = DateTime.MinValue
        Public Property DateAddedToDb() As DateTime
            Get
                Return If((m_DateAddedToDb = DateTime.MinValue), DateTime.Now(), m_DateAddedToDb)
            End Get
            Set
                m_DateAddedToDb = Value
            End Set
        End Property

        Private m_NumberInStock As Byte
        Public Property NumberInStock() As Byte
            Get
                Return m_NumberInStock
            End Get
            Set(ByVal value As Byte)
                m_NumberInStock = value
            End Set
        End Property


        Private m_MovieGenres As MovieGenres
        Public Property MovieGenres() As MovieGenres
            Get
                Return m_MovieGenres
            End Get
            Set(ByVal value As MovieGenres)
                m_MovieGenres = value
            End Set
        End Property


        'foreign key

        Private m_MovieGenresID As Byte
        Public Property MovieGenresID() As Integer
            Get
                Return m_MovieGenresID
            End Get
            Set(ByVal value As Integer)
                m_MovieGenresID = value
            End Set
        End Property

        Private m_MoviePoster As String
        Public Property MoviePoster() As String
            Get
                Return m_MoviePoster
            End Get
            Set(ByVal value As String)
                m_MoviePoster = value
            End Set
        End Property


    End Class
End Namespace