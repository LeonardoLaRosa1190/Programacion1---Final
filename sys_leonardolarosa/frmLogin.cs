namespace sys_LeonardoLaRosa
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

         private void btnAceptar_Click(object sender, EventArgs e)
        {
            //lee la contraseña de un txt y la guarda en una variable string 
            StreamReader passConfirmacion = new StreamReader("Contraseña.txt");
            string confirmacionTxt = passConfirmacion.ReadToEnd();
            //guarda en una variable string el contenido de la caja de texto
            string confirmacionBox = txtContraseña.Text.ToString();
            //corrobora que la contraseña ingresada sea correcta en caso contrario muestra un mensaje de error
            if (string.Equals(confirmacionTxt,confirmacionBox))
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
           
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //cuando se carga el formulario se posiciona el cursor en la caja de texto contraseña
            txtContraseña.Focus();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //cuando se pulsa este boton se minimiza el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cuando se pulsa este boton la aplicacion termina
            Application.Exit();
        }
    }
}