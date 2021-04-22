using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedTest
{
    class MetodManager
    {
        public void ShowTeams()
        {
            #region ShowTeams
            string[] teams = { "Real Madrid", "Barcelona", "Fenerbahçe", "BayernMunih", "Palmerias" };
            int[] secilenler;
            Random rnd = new Random();  // Rastgele sayı üretmek için
            int end = 0;
            for (int i = 1; i < 4; i++)
            {
            start:
                int elemanSecimi = rnd.Next(0, teams.Length); //Dizinin kaçıncı elemanından itibaren arama yapıcak
                if (elemanSecimi == end)
                {
                    goto start;
                }
                end = elemanSecimi;
                

                Console.WriteLine(teams[elemanSecimi] + " " + i);

                foreach (var item in teams)
                {

                }
            }
            #endregion
            
        }
        public void ChooseTeam()
        {
            Console.WriteLine("\n Hangi takıma transfer olmak istiyorsunuz?");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("You chose number 1");
                    break;
                case 2:
                    Console.WriteLine("You chose number 2");
                    break;
                case 3:
                    Console.WriteLine("You chose number 3");
                    break;
                default:
                    Console.WriteLine("Yanlis bir secim yaptiniz - yeni teklifleriniz... \n");
                    break;
            }
            Console.ReadLine();
        }
    }
}
