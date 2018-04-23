Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace IntAsEnumExample.Module.BusinessObjects
	<DefaultClassOptions> _
	Public Class SampleObject
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", name_Renamed, value)
			End Set
		End Property
		Private integerProperty_Renamed As Integer
		Public Property IntegerProperty() As Integer
			Get
				Return integerProperty_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("IntegerProperty", integerProperty_Renamed, value)
			End Set
		End Property
	End Class

	Public Enum SampleEnum
		Value1
		Value2
		Value3
	End Enum
End Namespace
