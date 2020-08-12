using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Common.DataAccess;


namespace DataAccess
{
    public class FileSystemStore : IFileSystemStore
    {
        public void Save(string xml, string filePath)
        {
            System.IO.File.WriteAllText(filePath,xml);
        }

        public string Load(string filePath)
        {
            //XmlTextReader reader = new XmlTextReader(filePath);
            string xml;
            using (StreamReader reader = System.IO.File.OpenText(filePath) )
            {
                xml = reader.ReadToEnd();
            }

            //StreamReader reader1 = null;
            //try
            //{
            //    reader1 = System.IO.File.OpenText(filePath);
            //    xml = reader1.ReadToEnd();
            //}
            //finally
            //{
            //    if (reader1 != null)
            //    {
            //        IDisposable d = (IDisposable) reader1;
            //        d?.Dispose();
            //    }
            //}

            return xml;
        }

    }
}
