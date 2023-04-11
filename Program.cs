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
            int pictureLine = 3;
            int pictureTotal = 52;
            int rowsFilled = pictureTotal / pictureLine;
            int pictureRemains = pictureTotal % pictureLine;

            Console.WriteLine($"Полностью заполненных рядов {rowsFilled}, а картинок сверх меры {pictureRemains}.");
        }
    }
}