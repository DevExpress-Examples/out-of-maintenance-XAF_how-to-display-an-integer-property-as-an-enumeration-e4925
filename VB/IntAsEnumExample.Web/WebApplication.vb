Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Web
Imports System.Collections.Generic
'using DevExpress.ExpressApp.Security;

Namespace IntAsEnumExample.Web
	' You can override various virtual methods and handle corresponding events to manage various aspects of your XAF application UI and behavior.
	Partial Public Class IntAsEnumExampleAspNetApplication ' http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
		Inherits WebApplication
		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
		Private module3 As IntAsEnumExample.Module.IntAsEnumExampleModule
		Private module4 As IntAsEnumExample.Module.Web.IntAsEnumExampleAspNetModule
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection

		Public Sub New()
			InitializeComponent()
		End Sub

		' Override to execute custom code after a logon has been performed, the SecuritySystem object is initialized, logon parameters have been saved and user model differences are loaded.
		Protected Overrides Sub OnLoggedOn(ByVal args As LogonEventArgs) ' http://documentation.devexpress.com/#Xaf/DevExpressExpressAppXafApplication_LoggedOntopic
			MyBase.OnLoggedOn(args)
		End Sub

		' Override to execute custom code after a user has logged off.
		Protected Overrides Sub OnLoggedOff() ' http://documentation.devexpress.com/#Xaf/DevExpressExpressAppXafApplication_LoggedOfftopic
			MyBase.OnLoggedOff()
		End Sub

		Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
			args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection, true)
		End Sub

		Private Sub IntAsEnumExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub

		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
			Me.module3 = New IntAsEnumExample.Module.IntAsEnumExampleModule()
			Me.module4 = New IntAsEnumExample.Module.Web.IntAsEnumExampleAspNetModule()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=IntAsEnumExample"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' IntAsEnumExampleAspNetApplication
			' 
			Me.ApplicationName = "IntAsEnumExample"
			Me.Connection = Me.sqlConnection1
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)

'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.IntAsEnumExampleAspNetApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
