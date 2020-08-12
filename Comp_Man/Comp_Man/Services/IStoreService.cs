using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Services
{
    public interface IStoreService
    {
        void Save(GameMenu game, string filePath);
        void Load(GameMenu main,string filePath);
    }
}
