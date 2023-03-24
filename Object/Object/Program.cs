using System;
namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            MainCharacters mc1 = new MainCharacters();
            mc1.name = "Gu Santong";
            mc1.age = "1000 years";
            mc1.cultivation = "Stage Big Shot";

            mc1.CultivationStage();
            mc1.KillCount();
        }
    }
}