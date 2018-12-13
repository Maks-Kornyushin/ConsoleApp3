using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Zoo
    {
        static void Main()
        {
            Cats cats = new Cats(12, 30, "Барсик","Чеширский");
            cats.Voice();

            Cats cats1 = new Cats(17, 25, "Финик", "Дворовый");
            cats1.Voice();

            Dogs dogs = new Dogs(15, 45, "Дружок", 35);
            dogs.Voice();

            Dogs dogs1 = new Dogs(20, 50, "Пирожок", 28);
            dogs1.Voice();

            Fishes fishes = new Fishes(1, 5, "Пипка", "Желтый");
            fishes.Voice();

            Fishes fishes1 = new Fishes(2, 4, "Немо", "Полосатый");
            fishes1.Voice();

        }
    }
}
