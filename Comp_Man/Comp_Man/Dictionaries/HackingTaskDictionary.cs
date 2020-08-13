using System.Collections.Generic;
using Common.Model.Enum;

namespace Common.Dictionaries
{
    public class HackingTaskDictionary
    {
        private Dictionary<HackingPrograms, string> beforePartDictionary;
        private Dictionary<HackingPrograms, string> afterTaskTrueDictionary;
        private Dictionary<HackingPrograms, string> afterTaskWrongDictionary;
        public HackingTaskDictionary()
        {
            beforePartDictionary = new Dictionary<HackingPrograms, string>();
            afterTaskTrueDictionary = new Dictionary<HackingPrograms, string>();
            afterTaskWrongDictionary = new Dictionary<HackingPrograms, string>();
            FullFirstDictionary();
            FullSecondDictionary();
            FullThirdDictionary();
        }
        private void FullFirstDictionary()
        {
            beforePartDictionary.Add(HackingPrograms.PasswordCrack, "Oh, You need to enter a password... or crack it.");
            beforePartDictionary.Add(HackingPrograms.SystemAccessCrack, "You need access to the system. It's time to use your programs");
            beforePartDictionary.Add(HackingPrograms.Disguise, "You need to use disguise to continue the attack.");
            beforePartDictionary.Add(HackingPrograms.SuperDisguise, "You need to use super disguise to continue the attack");
            beforePartDictionary.Add(HackingPrograms.BombFile, "Now let's run the bomb file.");
            beforePartDictionary.Add(HackingPrograms.NetworkVirus, "It's time to start the virus");
            beforePartDictionary.Add(HackingPrograms.NetwokAntivirus, "They have strong protection, you need to use a network antivirus.");
            beforePartDictionary.Add(HackingPrograms.Null, "We take the money and get off.");
        }
        private void FullSecondDictionary()
        {
            afterTaskTrueDictionary.Add(HackingPrograms.PasswordCrack, "Correct password. You are lucky that program works.");
            afterTaskTrueDictionary.Add(HackingPrograms.SystemAccessCrack, "Accessed. Do business and get out");
            afterTaskTrueDictionary.Add(HackingPrograms.Disguise, "The disguise worked successfully, no one knows about your presence");
            afterTaskTrueDictionary.Add(HackingPrograms.SuperDisguise, "The disguise worked successfully, no one knows about your presence");
            afterTaskTrueDictionary.Add(HackingPrograms.BombFile, "Boom!!! System was totally destroyed.");
            afterTaskTrueDictionary.Add(HackingPrograms.NetworkVirus, "The virus did its job. Time to get out.");
            afterTaskTrueDictionary.Add(HackingPrograms.NetwokAntivirus, "Nobody sees you. Time to have fun.");
            afterTaskTrueDictionary.Add(HackingPrograms.Null, "Money taken successfully.");
        }
        private void FullThirdDictionary()
        {
            afterTaskWrongDictionary.Add(HackingPrograms.PasswordCrack, "Something wrong, you haven't cracked a password. The police now know who you are.");
            afterTaskWrongDictionary.Add(HackingPrograms.SystemAccessCrack, "Access is denied. Something let you down.");
            afterTaskWrongDictionary.Add(HackingPrograms.Disguise, "Oops, you were discovered, maybe you were using the wrong disguise?");
            afterTaskWrongDictionary.Add(HackingPrograms.SuperDisguise, "Oops, you were discovered, maybe you were using the wrong disguise?");
            afterTaskWrongDictionary.Add(HackingPrograms.BombFile, "System is OK, and now the police know about you.");
            afterTaskWrongDictionary.Add(HackingPrograms.NetworkVirus, "Something went wrong and the virus didn't work. Run Forrest Run.");
            afterTaskWrongDictionary.Add(HackingPrograms.NetwokAntivirus, "The antivirus did not work and the operation stopped.");
            afterTaskWrongDictionary.Add(HackingPrograms.Null, "Is it too much at a time?Is it too much at a time?");
        }
    }
}
