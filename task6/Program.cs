using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPictures = 52;
            int picturesInRow = 3;

            int fullRows;
            int picturesRemains;

            fullRows = amountOfPictures / picturesInRow;
            picturesRemains = amountOfPictures % picturesInRow;

            Console.WriteLine("Полных рядов = "  + fullRows + " " + ", картинок осталось =  "+ picturesRemains);
        }
    }
}
