using System;

namespace ObjectOrientedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodManager metodManager = new MetodManager();
            metodManager.ShowTeams();
            metodManager.ChooseTeam();
        }
    }
}


//Alıştırma
//Futbolcu'ya random biçimde 3 ayrı takım teklifi yapılsın.
//Futbolcu bu teklifler arasında 1 tane takım seçsin
//Seçilen takıma göre ona ücret bilgisi gösterilsin.