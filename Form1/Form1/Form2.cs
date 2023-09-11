using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()
        {
            InitializeComponent();

            DelFirstName = new DelegateText(Class1.getFirstName);
            DelMiddleName = new DelegateText(Class1.getMiddleName);
            DelLastName = new DelegateText(Class1.getLastName);
            DelAddress = new DelegateText(Class1.getAddress);
            DelProgram = new DelegateText(Class1.getProgram);
            DelNumContactNo = new DelegateNumber(Class1.getContactNo);      
            DelNumAge = new DelegateNumber(Class1.getAge);
            DelStudNo = new DelegateNumber(Class1.getStudentNo);
            
        }

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
