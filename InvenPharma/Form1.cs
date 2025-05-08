namespace InvenPharma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnRegistrarMedicamento_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cl
        }
    }
}
