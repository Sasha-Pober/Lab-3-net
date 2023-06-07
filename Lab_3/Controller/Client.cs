using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Model;

namespace Controller
{
    public class Client : IClient
    {
        private DocumentFactory factory;
        private Document doc;
        public void Create(int type)
        {
            switch (type)
            {
                case 1:
                    factory = new LetterFactory();
                    break;
                case 2:
                    factory = new OrderFactory();
                    break;
                case 3:
                    factory = new DirectiveFactory();
                    break;
                case 4:
                    factory = new ResourceRequestFactory();
                    break;
                default:
                    throw new Exception("invalid type" + type);
            }

            doc = factory.CreateDocument(); 
        }

        public Document GetDocument()
        {
            return doc;
        }

        public void FillDocument()
        {
            Console.WriteLine("The doc is created of type " + doc.GetType().Name);
        }
    }
}
