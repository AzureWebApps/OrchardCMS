using System;
using System.Linq;
using Orchard.Projections.ModelBinding;
using Orchard.Projections.PropertyEditors.Forms;

namespace Orchard.Projections.PropertyEditors {
    public class NumericPropertyEditor : IPropertyEditor {

        public bool CanHandle(Type type) {
            return new[] {
                typeof(Byte), 
                typeof(SByte), 
                typeof(Int16), 
                typeof(Int32), 
                typeof(Int64), 
                typeof(UInt16), 
                typeof(UInt32), 
                typeof(UInt64), 
                typeof(float), 
                typeof(double), 
                typeof(decimal), 
            }.Contains(type);
        }

        public string FormName {
            get { return NumericPropertyForm.FormName; }
        }

        public dynamic Format(dynamic display, object value, dynamic formState) {
            return NumericPropertyForm.FormatNumber(Convert.ToDecimal(value), formState);
        }
    }
}