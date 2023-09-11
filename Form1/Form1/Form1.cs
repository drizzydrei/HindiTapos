namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.FirstName = textBoxFName.Text.ToString();
            Class1.LastName = textBoxLName.Text.ToString();
            Class1.MiddleName = textBoxMName.Text.ToString();
            Class1.Address = textBoxAddress.Text.ToString();
            Class1.Program = cbProgram.Text.ToString();
            Class1.Age = Convert.ToInt64(textBoxAge.Text);
            Class1.ContactNumber = Convert.ToInt64(textBoxContactNum.Text);
            Class1.StudentNo = Convert.ToInt64(textBoxStudentNo.Text);

        }
    }
}