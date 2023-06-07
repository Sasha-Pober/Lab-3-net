using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }

    public class LetterFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new Letter();
        }
    }

    public class OrderFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new Order();
        }
    }

    public class DirectiveFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new Directive();
        }
    }

    public class ResourceRequestFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ResourceRequest();
        }
    }


}
