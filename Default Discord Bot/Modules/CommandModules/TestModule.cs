using Discord.Commands;
using System.Threading.Tasks;

namespace Default_Discord_Bot.Modules.Modules
{
    public class BotModule : ModuleBase<SocketCommandContext>
    {
        // With the [Remainder] the bot will take the remaining part of the message and puts it in the string "message".
        [Command("copy", RunMode = RunMode.Async)]
        public async Task CopyCommand([Remainder] string message)
        {
            await Context.Channel.SendMessageAsync(message);
        }

        // Wihtout the [Remainder] Attribute the message must exist of one string (in this case). This means either 1 word or between "")
        [Command("wordcopy", RunMode = RunMode.Async)]
        public async Task WordCopyCommand(string message)
        {
            await Context.Channel.SendMessageAsync(message);
        }
    }
}
