using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    interface IGenerationView
    {
        void GenerateNewNumbers();

        void CloseView();
    }
}
