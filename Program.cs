using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInLine = 3;
            int picturesTotal = 52;
            int filledRows = picturesTotal / picturesInLine;
            int remainsPicture = picturesTotal % picturesInLine;

            Console.WriteLine($"Полностью заполненных рядов {filledRows}, а картинок сверх меры {remainsPicture}.");
            Console.ReadKey();
        }
    }
}