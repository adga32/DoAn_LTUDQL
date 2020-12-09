using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public partial class RequiredFieldValidator : BaseValidator
    {
        public RequiredFieldValidator()
        {
            InitializeComponent();
            ErrorMessage = "Không được để trống";
        }

        public override bool Validate()
        {
            return ControlToValidate.Text.Length > 0;
        }
    }
}
