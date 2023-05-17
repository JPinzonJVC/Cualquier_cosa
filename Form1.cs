namespace Entrega_Final_ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Hide();
        }
    }
}