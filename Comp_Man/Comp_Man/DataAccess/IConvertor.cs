using System.Xml.Linq;
using Common.Model;

namespace Common.DataAccess
{
    public interface IConvertor
    {
        string Save(GameMenu game);

        GameMenu Load(XDocument document);
    }
}
