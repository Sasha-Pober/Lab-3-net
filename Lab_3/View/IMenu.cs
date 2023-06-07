using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IMenu
    {
        void WriteLetter();
        void WriteOrder();
        void WriteDirective();
        void WriteResourceRequest();

    }
}
