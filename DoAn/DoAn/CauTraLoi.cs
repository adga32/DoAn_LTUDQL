using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{ 
    public partial class CauTraLoi : UserControl
    {
        RequiredFieldValidator requiedNoiDung = new RequiredFieldValidator();
        public CauTraLoi()
        {
            InitializeComponent();
            requiedNoiDung.ControlToValidate = txtNoiDung;
        }
      
        public string NoiDung
        {
            get => txtNoiDung.Text;
            set {
                txtNoiDung.Text = value;
            }
        }

        public bool CheckBox
        {
            get => ckBA.Checked;
            set {
                ckBA.Checked = value;
            }
        }
        public bool Readonly
        {
            set
            {
                txtNoiDung.ReadOnly = value;
            }
        }
       
        public bool Validator
        {
            get => requiedNoiDung.CheckValidate;
            set
            {
                requiedNoiDung.CheckValidate = value;
            }
        }
    }
}
