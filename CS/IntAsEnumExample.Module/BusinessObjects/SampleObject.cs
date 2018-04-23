using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;

namespace IntAsEnumExample.Module.BusinessObjects {
    [DefaultClassOptions]
    public class SampleObject : BaseObject {
        public SampleObject(Session session) : base(session) { }
        private string name;
        public string Name {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }
        private int integerProperty;
        public int IntegerProperty {
            get { return integerProperty; }
            set { SetPropertyValue("IntegerProperty", ref integerProperty, value); }
        }
    }

    public enum SampleEnum { Value1, Value2, Value3}
}
