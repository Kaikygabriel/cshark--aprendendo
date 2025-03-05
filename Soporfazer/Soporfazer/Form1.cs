namespace Soporfazer
{
    public partial class Form1 : Form
    {
        static bool sair = false;
        public Form1()
        {
          
            
                InitializeComponent();
                this.Visible = true;
                Form2 form2 = new Form2();
                form2.Visible = false;
                Form3 form3 = new Form3();
                form3.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
