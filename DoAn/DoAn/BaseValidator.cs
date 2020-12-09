using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public abstract class BaseValidator : Component
    {

        ErrorProvider errorProvider = new ErrorProvider();
        public bool CheckValidate = false;
        public string ErrorMessage { get; set; }
        public Icon ErrorIcon { get => errorProvider.Icon; set => errorProvider.Icon = value; }
        Control control2Validate;
        [TypeConverter(typeof(ReferenceConverter))]
        public Control ControlToValidate
        {
            get => control2Validate;
            set
            {
                if (control2Validate != null && !DesignMode)
                {
                    control2Validate.Validating -= Control2Validate_Validating;
                }
                control2Validate = value;

                if (control2Validate != null && !DesignMode)
                {
                    control2Validate.Validating += Control2Validate_Validating;
                }
            }
        }

        private void Control2Validate_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate())
            {
                errorProvider.SetError(control2Validate, ErrorMessage);
                CheckValidate = false;
            }
            else
            {
                errorProvider.SetError(control2Validate, "");
                CheckValidate = true;
            }
        }

        public abstract bool Validate();
    }
}
