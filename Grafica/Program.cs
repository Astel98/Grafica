using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafica
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var window = new Game(800, 600, "LearnOpenTK - Hello Triangle!"))
            {
                window.Run(60.0);
            }
        }
    }
}
