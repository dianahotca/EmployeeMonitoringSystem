using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BossService
    {
        public BossService(BossRepository bossRepository)
        {
            BossRepository = bossRepository;
        }

        BossRepository BossRepository { get; set; }

        public void LogIn(string username, string password)
        {
            BossRepository.LogIn(username, password);
        }
    }
}
