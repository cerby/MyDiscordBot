using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiscordBot
{
    public class Program
    {
        static void Main(string[] args)
        => new MyDiscordBot().StartAsync().GetAwaiter().GetResult();
    }
}
