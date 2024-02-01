using SampleDiscordBot.Discord;

namespace SampleDiscordBot
{
    public partial class MainForm : Form
    {
        // DiscordClient
        private Task<BotClient>? _client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SetStatus(false);
        }

        private void BtnBoot_Click(object sender, EventArgs e)
        {
            _client = new BotClient().Start();
            SetStatus(true);
        }

        private void SetStatus(bool _status)
        {
            LblStatus.Text = _status ? "é¿çsíÜ" : "ë“ã@";
        }
    }
}
