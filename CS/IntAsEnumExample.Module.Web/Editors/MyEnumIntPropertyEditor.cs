using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using IntAsEnumExample.Module.BusinessObjects;
using DevExpress.ExpressApp.Model;

namespace IntAsEnumExample.Module.Web.Editors {
    [PropertyEditor(typeof(int), false)]
    public class ASPxMyEnumIntPropertyEditor : ASPxEnumIntPropertyEditor<SampleEnum> {
        public ASPxMyEnumIntPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }
    }
}
