namespace TP29052024Paredes
{
    public partial class Form1 : Form
    {
        Usuario usuario = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario.ValidarUsuario(txtUsuario.Text, txtPass.Text);
            if (usuario.estadoConexion == "Usuario EXISTE")
            {
                usuario.RegistroLogInicioSesion();
                MessageBox.Show(usuario.estadoConexion);
            }
            else MessageBox.Show("Usuario no existe.");
        }
    }
}
