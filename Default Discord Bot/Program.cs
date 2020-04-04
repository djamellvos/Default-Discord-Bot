using Default_Discord_Bot.Modules;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Default_Discord_Bot
{
    public class Program
    {
        private DiscordSocketClient _client;
        private CommandHandler _handler;
        // Uncomment the next line (and line 22) to enable message caching. This is needed for deleted message logging and etc.
        //private DiscordSocketConfig _socketConfig = new DiscordSocketConfig { ExclusiveBulkDelete = true, MessageCacheSize = 100 };

        public static void Main() => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            // Comment out the previous line and uncomment the next line to enable message caching
            //_client = new DiscordSocketClient(_socketConfig);
            _client.Log += Log;
            _handler = new CommandHandler(this._client, new CommandService());

            await _handler.InstallCommandsAsync();

            await _client.LoginAsync(TokenType.Bot, "{Njk1OTQ5OTc1NTQ4MzMwMDE0.Xoiu-w.Pe55ZU0iKFE8tyghvCb9NDNVe3Y}");
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
