using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Extensions
{
    public static class GameMenuExtensions
    {
        public static void DeepCopy(this GameMenu to, GameMenu from)
        {
            to.Bss = from.Bss;
            to.Person = from.Person;
            to.Hacking = from.Hacking;
            to.Virus = from.Virus;
            to.Computer = from.Computer;
            to.Time = from.Time;

        }
    }
}
