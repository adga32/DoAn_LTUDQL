﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAn
{
    public partial class RegExValidator : BaseValidator
    {
        string regexStr;
        public string RegexStr
        {
            get => regexStr;
            set
            {
                regexStr = value;
                re = new Regex(regexStr);
            }
        }
        Regex re;

        public override bool Validate()
        {
            return re.IsMatch(ControlToValidate.Text);
        }

        public RegExValidator()
        {
            InitializeComponent();
        }
    }
}
