using System.Collections.Generic;
using Common.Model.Enum;

namespace Common.Dictionaries
{
    public class HackingTaskDictionary
    {
        private Dictionary<HackingPrograms, string> haveToDoDictionary;
        private Dictionary<HackingPrograms, string> rightMadeDictionary;
        private Dictionary<HackingPrograms, string> wrongMadeDictionary;
        public HackingTaskDictionary()
        {
            haveToDoDictionary = new Dictionary<HackingPrograms, string>();
            rightMadeDictionary = new Dictionary<HackingPrograms, string>();
            wrongMadeDictionary = new Dictionary<HackingPrograms, string>();
            FullFirstDictionary();
            FullSecondDictionary();
            FullThirdDictionary();
        }
        private void FullFirstDictionary()
        {

        }
        private void FullSecondDictionary()
        {

        }
        private void FullThirdDictionary()
        {

        }
    }
}
