using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace View
{
    public class Menu : IMenu
    {
        private readonly IClient client;

        public Menu(IClient client)
        {
            this.client = client;
        }
        public void WriteLetter()
        {
            client.Create(1);
            client.FillDocument();
            Console.WriteLine(client.GetDocument().GetDocument());
        }
        public void WriteOrder()
        {
            client.Create(2);
            client.FillDocument();
            Console.WriteLine(client.GetDocument().GetDocument());
        }
        public void WriteDirective()
        {
            client.Create(3);
            client.FillDocument();
            Console.WriteLine(client.GetDocument().GetDocument());
        }
        public void WriteResourceRequest()
        {
            client.Create(4);
            client.FillDocument();
            Console.WriteLine(client.GetDocument().GetDocument());
        }
    }
}
