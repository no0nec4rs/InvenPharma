namespace InvenPharma
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnngresar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string pass = "admin";

            if (txtContraseña.Text == pass
                && txtUsuario.Text == usuario)
            {
                txtUsuario.Clear();
                txtContraseña.Clear();
                Form1 principal = new Form1();
                MessageBox.Show("BIenvenido!");

                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}