using System;
using System.Threading.Tasks;
using Nito.AsyncEx;
using Discord;
using Discord.Commands;
using Discord.WebSocket;


namespace PlaceHolder
{
    class Program
    {
        public static async Task Main(string[] args)
            => await Startup.RunAsync(args);
        /*
        public static void Main(string[] args) 
            => new Program().MainAsync.GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            
            string token = "";

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        */
    }
}
