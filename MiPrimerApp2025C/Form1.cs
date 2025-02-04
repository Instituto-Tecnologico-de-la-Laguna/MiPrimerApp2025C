namespace MiPrimerApp2025C
{
    public partial class trabajo1 : Form
    {
        public trabajo1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre es: P23131038 "+txtNombre.Text);
        }
    }
}
