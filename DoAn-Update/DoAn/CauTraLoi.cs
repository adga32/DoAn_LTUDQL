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
        public CauTraLoi()
        {
            InitializeComponent();
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
       
    }
}
