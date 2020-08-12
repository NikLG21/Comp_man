using System;
using System.Collections.Generic;
using Common;
using Common.Extensions;
using Common.Model;
using Common.Model.Enum;
using Common.Services;

namespace Business.Services
{
    public class HackingService : IHackingService
    {

        public void CheckHackingEnabled(GameMenu game)
        {
            if(game.Person.Points > 10)
            {
                game.Hacking.HackingEnabled = true;
            }
            else
            {
                game.Hacking.HackingEnabled = false;
            }
        }

        public void ProgramExchange(GameMenu game, HackingPrograms programs)
        {
            switch (programs)
            {
                case HackingPrograms.PasswordCrack://Password Crack buy
                    if (game.Hacking.PasswordCrack)
                    {
                        //you have it
                        break;
                    }
                    if (game.Person.Money>=30)
                    {
                        game.Hacking.PasswordCrack = true;
                        game.Person.Money -= 30;
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case HackingPrograms.SystemAccessCrack:
                    if (game.Hacking.SystemAccessCrack)
                    {
                        //you have it
                        break;
                        
                    }
                    if (game.Hacking.PasswordCrack)
                    {
                        game.Hacking.SystemAccessCrack = true;
                    }
                    break;
                case HackingPrograms.Disguise:
                    if (game.Hacking.Disguise)
                    {
                        //you have it
                        break;
                    }
                    if (game.Person.Money >= 50)
                    {
                        game.Hacking.Disguise = true;
                        game.Person.Money -= 50;
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case HackingPrograms.SuperDisguise:
                    if (game.Hacking.SuperDisguise)
                    {
                        //you have it
                        break;
                    }
                    if (game.Person.Money >= 70)
                    {
                        game.Hacking.SuperDisguise = true;
                        game.Person.Money -= 70;
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case HackingPrograms.BombFile:
                    if (game.Hacking.BombFile)
                    {
                        //you have it
                        break;
                    }

                    if (game.Hacking.SuperDisguise)
                    {
                        game.Hacking.BombFile = true;
                    }
                    break;
                case HackingPrograms.NetworkVirus:
                    if (game.Hacking.NetworkVirus)
                    {
                        //you have it
                        break;
                    }

                    if (game.Person.Money>=120)
                    {
                        game.Hacking.NetworkVirus = true;
                        game.Person.Money -= 120;
                    }
                    else
                    {
                        //you don't have money
                    }
                    break;
                case HackingPrograms.NetwokAntivirus:
                    if (game.Hacking.NetworkAntivirus)
                    {
                        //you have it
                        break;
                    }

                    if (game.Hacking.BombFile && game.Hacking.BombFile)
                    {
                        game.Hacking.NetworkAntivirus = true;
                    }
                    break;
            }
        }

        public void HackingPointsCalculate(GameMenu game)
        {
            game.Hacking.HackingPoints = game.Hacking.SuccessfulHack + 
                                         2*(Convert.ToInt32(game.Hacking.PasswordCrack) +
                                            Convert.ToInt32(game.Hacking.BombFile)+ 
                                            Convert.ToInt32(game.Hacking.Disguise)+ 
                                            Convert.ToInt32(game.Hacking.SuperDisguise) + 
                                            Convert.ToInt32(game.Hacking.SystemAccessCrack) + 
                                            Convert.ToInt32(game.Hacking.NetworkVirus) +
                                            Convert.ToInt32(game.Hacking.NetworkAntivirus));
        }

        public int HackingTasksPick(GameMenu game)
        {
            game.Hacking.HackingTasks.Shuffle<HackingTask>();
            int k = -1;
            foreach (HackingTask task in game.Hacking.HackingTasks)
            {
                switch (task.FirstProgram)
                {
                    case HackingPrograms.Disguise:
                        if (!game.Hacking.Disguise)
                        {
                            continue;
                        }
                        break;
                    case HackingPrograms.SuperDisguise:
                        if (!game.Hacking.SuperDisguise)
                        {
                            continue;
                        }
                        break;
                    case HackingPrograms.BombFile:
                        if (!game.Hacking.BombFile)
                        {
                            continue;
                        }
                        break;
                    case HackingPrograms.SystemAccessCrack:
                        if (!game.Hacking.SystemAccessCrack)
                        {
                            continue;
                        }
                        break;
                    case HackingPrograms.NetworkVirus:
                        if (!game.Hacking.NetworkVirus)
                        {
                            continue;
                        }
                        break;
                    case HackingPrograms.NetwokAntivirus:
                        if (!game.Hacking.NetworkAntivirus)
                        {
                            continue;
                        }
                        break;
                }

                switch (task.SeconProgram)
                {
                    case HackingPrograms.Null:
                        break;
                    case HackingPrograms.NetwokAntivirus:
                        if(!game.Hacking.NetworkAntivirus)
                            continue;
                        break;
                    case HackingPrograms.BombFile:
                        if (!game.Hacking.BombFile)
                            continue;
                        break;
                    case HackingPrograms.NetworkVirus:
                        if (!game.Hacking.NetworkVirus)
                            continue;
                        break;
                    default:
                        continue;
                }

                k = game.Hacking.HackingTasks.IndexOf(task);
            }

            k = 3;
            game.Hacking.HackingTasks[k].FirstProgramUsed = false;
            game.Hacking.HackingTasks[k].SecondProgramUsed = false;
            game.Hacking.HackingTasks[k].ZeroProgramUsed = false;
            return k;
        }

        public void HackingDoing(GameMenu game, int task, int part,HackingPrograms hackingProgramUsed ,int moneyTake)
        {
            switch (part)
            {
                case 0:
                    if (game.Hacking.HackingTasks[task].ZeroProgram == hackingProgramUsed)
                    {
                        game.Hacking.HackingTasks[task].ZeroProgramUsed = true;
                    }
                    break;
                case 1:
                    if (game.Hacking.HackingTasks[task].FirstProgram == hackingProgramUsed)
                    {
                        game.Hacking.HackingTasks[task].FirstProgramUsed = true;
                    }
                    break;
                case 2:
                    if (game.Hacking.HackingTasks[task].SeconProgram == hackingProgramUsed)
                    {
                        game.Hacking.HackingTasks[task].SecondProgramUsed = true;
                        if (hackingProgramUsed == HackingPrograms.Null)
                        {
                            game.Person.Money += game.Hacking.HackingTasks[task].MoneyEarned[moneyTake];
                        }

                        game.Hacking.HackingPoints += game.Hacking.HackingTasks[task].PointsEarned;
                    }
                    break;
            }
        }
    }
}
