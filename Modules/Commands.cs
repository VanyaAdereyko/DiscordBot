using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Anime")]
        public async Task Ping()
        {
            //TODO: сделать вывод рандомного значения
            await ReplyAsync("P ong");
        }
    }
}
