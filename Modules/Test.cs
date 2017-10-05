using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiscordBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]

        public async Task Firsttest()
        {
            await Context.Channel.SendMessageAsync("success!");
        }
    }
}
