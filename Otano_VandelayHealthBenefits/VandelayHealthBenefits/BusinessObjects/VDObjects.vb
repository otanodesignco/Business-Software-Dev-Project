Imports System.Data
Imports System.Data.OleDb

Public Class VDObjects

    Public Shared strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Rickey\Desktop\Friends\business software dev\RickeyOtano\VandelayDB.accdb;Persist Security Info=False"

    Public Class Department

        ' department id
        Private DeptIDVal As String
        Public Property DeptID() As String
            Get
                Return DeptIDVal
            End Get
            Set(ByVal value As String)
                DeptIDVal = value
            End Set
        End Property

        ' department description
        Private DeptDescrVal As String
        Public Property DeptDescr() As String
            Get
                Return DeptDescrVal
            End Get
            Set(ByVal value As String)
                DeptDescrVal = value
            End Set
        End Property

        ' populate the combo box
        Public Shared Sub PopulateDropDown(ByRef cboDepartment As ComboBox)

            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn

            ' sql to get dept id's
            Dim qry As String = "SELECT DepartmentID FROM tblDepartments"
            Dim cmd As New OleDb.OleDbCommand(qry, con)

            Try
                'clear entires first
                cboDepartment.Items.Clear()

                'run query add entries
                con.Open()

                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

                While reader.Read()
                    cboDepartment.Items.Add(reader.GetString(0))
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

        End Sub

        Public Shared Function Insert(ByRef dept As Department) As Boolean

            Dim con As New OleDb.OleDbConnection
            Dim Inserted As Boolean = False
            con.ConnectionString = strConn

            Dim InsertSQL As String = "INSERT INTO tblDepartments (DepartmentID, DeptDescr) "
            InsertSQL += "VALUES (?,?)"
            Dim cmd As New OleDb.OleDbCommand(InsertSQL, con)
            cmd.Parameters.AddWithValue("DepartmentID", dept.DeptID)
            cmd.Parameters.AddWithValue("DeptDescr", dept.DeptDescr)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                Inserted = True

            Catch ex As Exception

                MsgBox(ex.ToString)

            Finally

                con.Close()

            End Try

            Return Inserted

        End Function

        Public Shared Function Read(ByRef dept As Department) As Boolean

            Dim Readed As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn

            Dim qry As String = "SELECT * FROM tblDepartments "
            qry += "Where DepartmentID = ?"

            Dim cmd As New OleDb.OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DeptDescr", dept.DeptID)

            Try

                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                While reader.Read()

                    dept.DeptID = reader.GetString(0)
                    dept.DeptDescr = reader.GetString(1)

                End While

                Readed = True

            Catch ex As Exception

                MsgBox(ex.ToString)

            Finally

                con.Close()

            End Try

            Return Readed

        End Function

        Public Shared Function Update(ByRef dept As Department) As Boolean

            Dim Updated As Boolean = False
            Dim con As New OleDb.OleDbConnection

            con.ConnectionString = strConn

            Dim qry As String = "Update tblDepartments "
            qry += "SET DeptDescr = ? "
            qry += "Where DepartmentID = ?"

            Dim cmd As New OleDb.OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DeptDescr", dept.DeptDescr)
            cmd.Parameters.AddWithValue("DepartmentID", dept.DeptID)

            Try

                con.Open()
                cmd.ExecuteNonQuery()
                Updated = True

            Catch ex As Exception

                MsgBox(ex.ToString)

            Finally

                con.Close()

            End Try

            Return Updated

        End Function

        Public Shared Function Delete(ByRef dept As Department) As Boolean

            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim Deleted As Boolean = False
            Dim qry As String = "DELETE FROM tblDepartments "
            qry += "Where DepartmentID = ?"

            Dim cmd As New OleDb.OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DepartmentID", dept.DeptID)

            Try

                con.Open()
                cmd.ExecuteNonQuery()
                Deleted = True


            Catch ex As Exception

                MsgBox(ex.ToString)

            Finally

                con.Close()

            End Try

            Return Deleted

        End Function

    End Class
    ' class that handles all of the dependent form crud
    Public Class DependentCode

        ' variables
        Private Code As String
        Private Descr As String

        ' properties that get or set private variables
        Public Property DependCode() As String

            Get

                Return Code

            End Get

            Set(value As String)

                Code = value

            End Set

        End Property

        Public Property DependDescr() As String

            Get

                Return Descr

            End Get

            Set(value As String)

                Descr = value

            End Set

        End Property

        Public Shared Function Insert(ByRef depend As DependentCode) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection

            con.ConnectionString = strConn

            Dim qry As String = "INSERT INTO tblDependentCodes (DependentCode,DependentDescr)"
            qry += " VALUES (?,?)"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DependentCode", depend.DependCode)
            cmd.Parameters.AddWithValue("DependentDescr", depend.DependDescr)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c

        End Function

        Public Shared Function Read(ByRef depend As DependentCode) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection

            con.ConnectionString = strConn

            Dim qry As String = "SELECT * FROM tblDependentCodes"
            qry += " WHERE DependentCode = ?"

            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DependentCode", depend.DependCode)

            Try
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                While reader.Read()
                    depend.DependCode = reader.GetString(0)
                    depend.DependDescr = reader.GetString(1)
                End While

                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try


            Return c

        End Function

        Public Shared Function Delete(ByRef depend As DependentCode) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection

            con.ConnectionString = strConn

            Dim qry As String = "DELETE FROM tblDependentCodes"
            qry += " WHERE DependentCode = ?"

            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DependentCode", depend.DependCode)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c

        End Function

        Public Shared Function Update(ByRef depend As DependentCode) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection

            con.ConnectionString = strConn

            Dim qry As String = "Update tblDependentCodes"
            qry += " SET DependentDescr = ?"
            qry += " WHERE DependentCode = ?"

            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("DependentDescr", depend.DependDescr)
            cmd.Parameters.AddWithValue("DependentCode", depend.DependCode)

            Try

                con.Open()
                cmd.ExecuteNonQuery()
                c = True

            Catch ex As Exception

                MsgBox(ex.ToString)

            Finally

                con.Close()

            End Try

            Return c

        End Function
        ' used to fill hidden combo box used to do edits, on selectedindexchange fill text boxes with the right values
        Public Shared Sub FillCombox(ByRef combox As ComboBox)
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT DependentCode FROM tblDependentCodes"
            Dim cmd As New OleDbCommand(qry, con)

            Try
                combox.Items.Clear()
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                While reader.Read()
                    combox.Items.Add(reader.GetString(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try


        End Sub

    End Class

    Public Class InsCompany

        Private isname As String
        Private iscode As String
        Private isdescr As String

        Public Property Name() As String
            Get
                Return isname
            End Get
            Set(value As String)
                isname = value
            End Set
        End Property

        Public Property Code() As String
            Get
                Return iscode
            End Get
            Set(value As String)
                iscode = value
            End Set
        End Property

        Public Property Descr() As String
            Get
                Return isdescr
            End Get
            Set(value As String)
                isdescr = value
            End Set
        End Property

        Public Shared Function Insert(ByRef isCom As InsCompany) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "INSERT INTO tblInsuranceCos (CompanyCode,CompanyName,CompanyDescr)"
            qry += " VALUES (?,?,?)"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyCode", isCom.Code)
            cmd.Parameters.AddWithValue("CompanyName", isCom.Name)
            cmd.Parameters.AddWithValue("CompanyDescr", isCom.Descr)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c

        End Function

        Public Shared Function Read(ByRef isCom As InsCompany) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT * FROM tblInsuranceCos"
            qry += " WHERE CompanyCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyCode", isCom.Code)

            Try
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read()
                    isCom.Code = reader.GetString(0)
                    isCom.Name = reader.GetString(1)
                    isCom.Descr = reader.GetString(2)
                End While
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c

        End Function

        Public Shared Function Update(ByRef isCom As InsCompany) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "UPDATE tblInsuranceCos "
            qry += "SET CompanyName = ?, CompanyDescr = ? "
            qry += "WHERE CompanyCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyName", isCom.Name)
            cmd.Parameters.AddWithValue("CompanyDescr", isCom.Descr)
            cmd.Parameters.AddWithValue("CompanyCode", isCom.Code)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c

        End Function

        Public Shared Function Delete(ByRef isCom As InsCompany) As Boolean

            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "DELETE FROM tblInsuranceCos "
            qry += "WHERE CompanyCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyCode", isCom.Code)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c

        End Function

        Public Shared Sub FillList(ByRef cbox As ComboBox)
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT CompanyCode FROM tblInsuranceCos "
            Dim cmd As New OleDbCommand(qry, con)

            Try
                cbox.Items.Clear()
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read
                    cbox.Items.Add(reader.GetString(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End Sub

    End Class

    Public Class Rate
        Private _depCode As String
        Private _insCode As String
        Private _rate As String

        Public Property DepCode() As String
            Get
                Return _depCode
            End Get
            Set(value As String)
                _depCode = value
            End Set
        End Property
        Public Property insCode() As String
            Get
                Return _insCode
            End Get
            Set(value As String)
                _insCode = value
            End Set
        End Property
        Public Property Rates() As Decimal
            Get
                Return _rate
            End Get
            Set(value As Decimal)
                _rate = value
            End Set
        End Property

        Public Shared Function Insert(ByRef r As Rate) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "INSERT INTO tblRates (CompanyCode,DependentCode,Rate) "
            qry += "Values (?,?,?)"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyCo", r.insCode)
            cmd.Parameters.AddWithValue("DependentCode", r.DepCode)
            cmd.Parameters.AddWithValue("Rate", r.Rates)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Read(ByRef r As Rate) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT * FROM tblRates"
            qry += " WHERE CompanyCo = ? AND DependentCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyCo", r.insCode)
            cmd.Parameters.AddWithValue("DependentCode", r.DepCode)

            Try
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read()
                    r.insCode = reader.GetString(0)
                    r.DepCode = reader.GetString(1)
                    r.Rates = reader.GetDecimal(2)
                End While
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Update(ByRef r As Rate) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "UPDATE tblRates "
            qry += "SET Rate = ?"
            qry += "WHERE CompanyCo = ? AND DepedentCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("Rate", r.Rates)
            cmd.Parameters.AddWithValue("CompanyCo", r.insCode)
            cmd.Parameters.AddWithValue("DependentCode", r.DepCode)


            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Delete(ByRef r As Rate) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "DELETE FROM tblRates "
            qry += "WHERE CompanyCode = ? AND DependentCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("CompanyCo", r.insCode)
            cmd.Parameters.AddWithValue("DependentCode", r.DepCode)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Sub FillList(ByRef cbo As ComboBox)
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT Rates FROM tblRates "
            Dim cmd As New OleDbCommand(qry, con)

            Try
                cbo.Items.Clear()
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read
                    cbo.Items.Add(reader.GetString(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

        End Sub
    End Class

    Public Class Employee
        Private _ID, _Dept, _Fname, _Lname, _Addr, _City, _State As String
        Private _Zip, _Ext As Integer

        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property
        Public Property Dept() As String
            Get
                Return _Dept
            End Get
            Set(value As String)
                _Dept = value
            End Set
        End Property
        Public Property Fname() As String
            Get
                Return _Fname
            End Get
            Set(value As String)
                _Fname = value
            End Set
        End Property
        Public Property Lname() As String
            Get
                Return _Lname
            End Get
            Set(value As String)
                _Lname = value
            End Set
        End Property
        Public Property Addr() As String
            Get
                Return _Addr
            End Get
            Set(value As String)
                _Addr = value
            End Set
        End Property
        Public Property City() As String
            Get
                Return _City
            End Get
            Set(value As String)
                _City = value
            End Set
        End Property
        Public Property State() As String
            Get
                Return _State
            End Get
            Set(value As String)
                _State = value
            End Set
        End Property
        Public Property Zip() As Integer
            Get
                Return _Zip
            End Get
            Set(value As Integer)
                _Zip = value
            End Set
        End Property
        Public Property Ext() As Integer
            Get
                Return _Ext
            End Get
            Set(value As Integer)
                _Ext = value
            End Set
        End Property

        Public Shared Function Insert(ByRef e As Employee) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "INSERT INTO tblEmployees (EmployeeID,DepartmentID,FirstName,LastName,Address,City,State,Zip,Ext) "
            qry += "VALUES (?,?,?,?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.ID)
            cmd.Parameters.AddWithValue("DepartmentID", e.Dept)
            cmd.Parameters.AddWithValue("FirstName", e.Fname)
            cmd.Parameters.AddWithValue("LastName", e.Lname)
            cmd.Parameters.AddWithValue("Address", e.Addr)
            cmd.Parameters.AddWithValue("City", e.City)
            cmd.Parameters.AddWithValue("State", e.State)
            cmd.Parameters.AddWithValue("Zip", e.Zip)
            cmd.Parameters.AddWithValue("Ext", e.Ext)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Read(ByRef e As Employee) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT * FROM tblEmployees"
            qry += " WHERE EmployeeID = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.ID)

            Try
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read()
                    e.ID = reader.GetString(0)
                    e.Dept = reader.GetString(1)
                    e.Fname = reader.GetString(2)
                    e.Lname = reader.GetString(3)
                    e.Addr = reader.GetString(4)
                    e.City = reader.GetString(5)
                    e.State = reader.GetString(6)
                    e.Zip = reader.GetInt32(7)
                    e.Ext = reader.GetInt32(8)
                End While
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Update(ByRef e As Employee) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "UPDATE tblEmployees "
            qry += "SET EmployeeID = ?, DepartmentID  = ?, FirstName = ?, LastName = ?, Address = ?, City = ?, State = ?, Zip = ?, Ext = ?"
            qry += "WHERE EmployeeID = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.ID)
            cmd.Parameters.AddWithValue("DepartmentID", e.Dept)
            cmd.Parameters.AddWithValue("FirstName", e.Fname)
            cmd.Parameters.AddWithValue("LastName", e.Lname)
            cmd.Parameters.AddWithValue("Address", e.Addr)
            cmd.Parameters.AddWithValue("City", e.City)
            cmd.Parameters.AddWithValue("State", e.State)
            cmd.Parameters.AddWithValue("Zip", e.Zip)
            cmd.Parameters.AddWithValue("Ext", e.Ext)
            cmd.Parameters.AddWithValue("EmpID", e.ID)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Delete(ByRef e As Employee) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "DELETE FROM tblEmployees "
            qry += "WHERE EmployeeID = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.ID)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Sub FillList(ByRef cbo As ComboBox)
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT EmployeeID FROM tblEmployees "
            Dim cmd As New OleDbCommand(qry, con)

            Try
                cbo.Items.Clear()
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read
                    cbo.Items.Add(reader.GetString(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End Sub
    End Class

    Public Class Enrollment
        Private _empID, _insCode, _depCode As String
        Private _effctDate As Date
        Public Property EmpID() As String
            Get
                Return _empID
            End Get
            Set(value As String)
                _empID = value
            End Set
        End Property
        Public Property InsCode() As String
            Get
                Return _insCode
            End Get
            Set(value As String)
                _insCode = value
            End Set
        End Property
        Public Property DepCode() As String
            Get
                Return _depCode
            End Get
            Set(value As String)
                _depCode = value
            End Set
        End Property
        Public Property EffctDate() As Date
            Get
                Return _effctDate
            End Get
            Set(value As Date)
                _effctDate = value
            End Set
        End Property

        Public Shared Function Insert(ByRef e As Enrollment) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "INSERT INTO tblEnrollments (EmployeeID, CompanyCode, DependentCode, EffectiveDate) "
            qry += "VALUES (?,?,?,?)"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.EmpID)
            cmd.Parameters.AddWithValue("CompanyCode", e.InsCode)
            cmd.Parameters.AddWithValue("DependentCode", e.DepCode)
            cmd.Parameters.AddWithValue("EffectiveDate", e.EffctDate)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Read(ByRef e As Enrollment) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "SELECT * FROM tblEnrollments "
            qry += " WHERE EmployeeID = ? AND CompanyCode = ? AND DependentCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.EmpID)
            cmd.Parameters.AddWithValue("CompanyCode", e.InsCode)
            cmd.Parameters.AddWithValue("DependentCode", e.DepCode)

            Try
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read()
                    e.EmpID = reader.GetString(0)
                    e.InsCode = reader.GetString(1)
                    e.DepCode = reader.GetString(2)
                    e.EffctDate = reader.GetDateTime(3)
                End While
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Update(ByRef e As Enrollment) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "UPDATE tblEnrollments "
            qry += "SET EmployeeID = ?, CompanyCode = ?, DependentCode = ?, EffectiveDate = ?"
            qry += "WHERE EmployeeID = ? AND CompanyCode = ? AND DependentCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.EmpID)
            cmd.Parameters.AddWithValue("CompanyCode", e._insCode)
            cmd.Parameters.AddWithValue("DependentCode", e.DepCode)
            cmd.Parameters.AddWithValue("EffectiveDate", e.EffctDate)
            cmd.Parameters.AddWithValue("EmployeeID2", e.EmpID)
            cmd.Parameters.AddWithValue("CompanyCode2", e._insCode)
            cmd.Parameters.AddWithValue("DependentCode2", e.DepCode)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function

        Public Shared Function Delete(ByRef e As Enrollment) As Boolean
            Dim c As Boolean = False
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = strConn
            Dim qry As String = "DELETE FROM tblEnrollments "
            qry += "WHERE EmployeeID = ? AND CompanyCode = ? AND DependentCode = ?"
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("EmployeeID", e.EmpID)
            cmd.Parameters.AddWithValue("CompanyCode", e._insCode)
            cmd.Parameters.AddWithValue("DependentCode", e.DepCode)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                c = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Return c
        End Function
    End Class

    Public Class FirstUCase
        Public Shared Function Convert(ByVal txt As String) As String
            Dim arrayTxt() As Char = txt.ToCharArray
            arrayTxt(0) = Char.ToUpper(arrayTxt(0))
            Return New String(arrayTxt)
        End Function
    End Class

End Class
