Imports System.Data
Imports System.Data.OleDb

Public Class CRUD

    Private ConStr As String
    Private Tbl As String
    Private con As OleDb.OleDbConnection

    ' method that creates a new entry in the database
    Public Function Create() As Boolean
        Dim c As Boolean = False

        Return c
    End Function

    ' method that reads from a database
    Public Function Read(ByVal Filter As Boolean, Optional ByVal Clause As String = "") As Boolean

        Dim Readed As Boolean = False
        Dim qry As String = "SELECT * FROM " & Me.Tbl

        If Filter Then

            qry += "WHERE " & Clause

        Else
            ' do nothing select everything
        End If

        Dim cmd As New OleDbCommand(qry, Me.con)

        Try

            con.Open()
            Dim Reader As OleDbDataReader = cmd.ExecuteReader()

            While Reader.Read()



            End While

        Catch ex As Exception

        Finally

            con.Close()

        End Try




        Return Readed

    End Function

    Public Function Update() As Boolean

        Dim Updated As Boolean = False

        Return Updated

    End Function

    ' method that deletes from the database
    Public Function Delete() As Boolean

        Dim Deleted As Boolean = False

        Return Deleted

    End Function

    Sub New(ByVal Connection As String, ByVal Table As String)

        Me.ConStr = ConStr
        Me.Tbl = Table
        Me.con.ConnectionString = Me.ConStr ' connect to db in contructor

    End Sub

End Class
