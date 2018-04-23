Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Win.Editors
Imports IntAsEnumExample.Module.BusinessObjects

Namespace IntAsEnumExample.Module.Win.Editors
	<PropertyEditor(GetType(Integer), False)> _
	Public Class MyEnumIntPropertyEditor
		Inherits EnumIntPropertyEditor(Of SampleEnum)
		Public Sub New(ByVal objectType As Type, ByVal model As IModelMemberViewItem)
			MyBase.New(objectType, model)
		End Sub
	End Class
End Namespace
