using EASendMail;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniProjects
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Contains("santa"))
            {
                await SecretSanta.Run();
            }
        }
    }

}
