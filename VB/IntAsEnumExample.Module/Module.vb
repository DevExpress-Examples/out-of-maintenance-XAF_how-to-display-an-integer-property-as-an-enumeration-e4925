Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Updating

Namespace IntAsEnumExample.Module

    ' You can override various virtual methods and handle corresponding events to manage various aspects of your XAF application UI and behavior.
    Public NotInheritable Partial Class IntAsEnumExampleModule
        Inherits ModuleBase ' http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModuleBasetopic

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Return New ModuleUpdater() {updater}
        End Function
    ' Override the CustomizeTypesInfo method, to customize information on a particular class or property, before it is loaded to the Application Model. 
    'public override void CustomizeTypesInfo(ITypesInfo typesInfo) { // http://documentation.devexpress.com/Xaf/CustomDocument3224.aspx
    '    base.CustomizeTypesInfo(typesInfo);
    '    ITypeInfo theTypeInfo = typesInfo.FindTypeInfo(typeof(DomainObject1));
    '    if(theTypeInfo != null) {
    '        string memberName = "MyCustomMember";
    '        IMemberInfo theMemberInfo = theTypeInfo.FindMember(memberName);
    '        if(theMemberInfo == null) {
    '            theMemberInfo = theTypeInfo.CreateMember(memberName, typeof(string));
    '        }
    '        theTypeInfo.AddAttribute(new VisibleInDetailViewAttribute(false));
    '    }
    '}
    ' You can define a fully custom Application Model element or extend an existing one (http://documentation.devexpress.com/#Xaf/CustomDocument3169)
    'public override void ExtendModelInterfaces(ModelInterfaceExtenders extenders) {
    '    base.ExtendModelInterfaces(extenders);
    '    extenders.Add<IModelApplication, IModelMyModelExtension>();
    '}
    End Class
' Declaration of a custom Application Model element extension to keep your custom settings (http://documentation.devexpress.com/#Xaf/CustomDocument2579).
'public interface IModelMyModelExtension : IModelNode {
'    string MyCustomProperty { get; set; }
'}
End Namespace
