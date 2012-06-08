using System;
using System.Linq;
using Orchard.Localization.Services;
using Orchard.Projections.ModelBinding;
using Orchard.Projections.PropertyEditors.Forms;

namespace Orchard.Projections.PropertyEditors {
    public class DateTimePropertyEditor : IPropertyEditor {
        private readonly Lazy<string> _culture;

        public DateTimePropertyEditor(
            ICultureSelector cultureSelector,
            IWorkContextAccessor workContextAccessor) {
                _culture = new Lazy<string>(() => cultureSelector.GetCulture(workContextAccessor.GetContext().HttpContext).CultureName);
        }
        public bool CanHandle(Type type) {
            return new[] { typeof(DateTime), typeof(DateTime?) }.Contains(type);
        }

        public string FormName {
            get { return DateTimePropertyForm.FormName; }
        }

        public dynamic Format(dynamic display, object value, dynamic formState) {
            return DateTimePropertyForm.FormatDateTime(display, Convert.ToDateTime(value), formState, _culture.Value);
        }
    }
}