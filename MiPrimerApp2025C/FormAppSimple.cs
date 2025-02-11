namespace MiPrimerApp2025C
{
    public partial class FormAppSimple : Form
    {
        public FormAppSimple()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre es: P23130586. "+txtNombre.Text);
        }
    }
}
