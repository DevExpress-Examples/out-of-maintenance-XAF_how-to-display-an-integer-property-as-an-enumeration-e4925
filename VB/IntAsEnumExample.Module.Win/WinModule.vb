Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Updating

Namespace IntAsEnumExample.Module.Win

    <ToolboxItemFilter("Xaf.Platform.Win")>
    Public NotInheritable Partial Class IntAsEnumExampleWindowsFormsModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Return ModuleUpdater.EmptyModuleUpdaters
        End Function
    End Class
End Namespace
