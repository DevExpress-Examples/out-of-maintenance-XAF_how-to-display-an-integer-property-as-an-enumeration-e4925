Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace IntAsEnumExample.Module.BusinessObjects

    <DefaultClassOptions>
    Public Class SampleObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private nameField As String

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", nameField, value)
            End Set
        End Property

        Private integerPropertyField As Integer

        Public Property IntegerProperty As Integer
            Get
                Return integerPropertyField
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue("IntegerProperty", integerPropertyField, value)
            End Set
        End Property
    End Class

    Public Enum SampleEnum
        Value1
        Value2
        Value3
    End Enum
End Namespace
