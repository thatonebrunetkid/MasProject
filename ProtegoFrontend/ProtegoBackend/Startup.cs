using MasProjekt.Backoffice.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegoBackend
{
    public static class Startup
    {

        public static void Start()
        {
            DataManipulator.LoadData();
        }
    }
}
