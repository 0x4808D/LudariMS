namespace LudariMS
{
    public partial class AddServerForm : Form
    {
        public AddServerForm()
        {
            InitializeComponent();
        }

        private void addServer_Click(object sender, EventArgs e)
        {
            var name = this.nameInput.Text;
            var ip = this.ipInput.Text;
            var port = this.portInput.Text;

            Ludari.AddServerEntry(name, $"{ip}:{port}");
            this.Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
