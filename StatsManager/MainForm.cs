namespace StatsManager
{
    public partial class MainForm : Form
    {
        MTsocketAPI.MT5.Terminal mt5;

        public MainForm()
        {
            InitializeComponent();

            mt5 = new MTsocketAPI.MT5.Terminal();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenTerminals_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mt5.Connect();
        }
    }
}
