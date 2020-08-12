using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataAccess
{
    public interface IFileSystemStore
    {
        void Save(string xml, string filePath);

        string Load(string filePath);
    }
}
