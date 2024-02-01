using Discord;
using Discord.WebSocket;
using System.Diagnostics;

namespace SampleDiscordBot.Discord
{
    // コードは下記サイトを参考にした
    // https://www.dice-programming-etc.com/c%E3%81%A7discord-bot%E9%96%8B%E7%99%BA%EF%BC%88discord-net%EF%BC%89/
    internal class BotClient
    {
        private readonly DiscordSocketClient _client;

        public BotClient()
        {
            _client = new DiscordSocketClient(
                new DiscordSocketConfig() {
                    GatewayIntents = GatewayIntents.Guilds | GatewayIntents.GuildMessages | GatewayIntents.MessageContent
                }
            );
            _client.Ready += onReady;
            _client.Log += Log;
            _client.MessageReceived += onMessage;
        }

        public async Task<BotClient> Start()
        { 
            await MainAsync(); 
            return this;
        }

        public void Stop() { _client.StopAsync(); }

        private async Task MainAsync()
        {
            await _client.LoginAsync(TokenType.Bot, "******");
            await _client.StartAsync();

            await Task.Delay(Timeout.Infinite);
        }

        //ログ吐き出し！
        private Task Log(LogMessage _message)
        {
            Debug.WriteLine(_message.ToString());
            return Task.CompletedTask;
        }

        private Task onReady()
        {
            Debug.WriteLine($"{_client.CurrentUser} is Running!!");
            return Task.CompletedTask;
        }

        private async Task onMessage(SocketMessage _message)
        {
            // 発言者がBotの場合は無視
            if (_message.Author.IsBot)
            {
                return;
            }

            // とりあえずオウム返し
            await _message.Channel.SendMessageAsync($"[BOT]{_message.Content}");
        }
    }
}
