using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using IntAsEnumExample.Module.BusinessObjects;

namespace IntAsEnumExample.Module.Win.Editors {
    [PropertyEditor(typeof(int), false)]
    public class MyEnumIntPropertyEditor : EnumIntPropertyEditor<SampleEnum> {
        public MyEnumIntPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }
    }
}
