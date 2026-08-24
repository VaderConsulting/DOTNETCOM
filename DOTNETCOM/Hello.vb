<ComClass(Hello.ClassId, Hello.InterfaceId, Hello.EventsId)> _
Public Class Hello

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "ea80fcd9-9ad6-4628-9f79-69dd882543e7"
    Public Const InterfaceId As String = "aa761cde-e0d6-498f-9b97-ea3ea72f9d40"
    Public Const EventsId As String = "a2f68f27-1989-4da5-b6f4-b1416d793156"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function HelloWorld(ByVal strName As String) As String
        Return "Hello " & strName
    End Function

End Class


