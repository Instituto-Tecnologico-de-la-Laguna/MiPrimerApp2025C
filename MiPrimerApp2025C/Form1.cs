namespace MiPrimerApp2025C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre es: P23130560 " + txtNombre.Text);
        }
    }
}
