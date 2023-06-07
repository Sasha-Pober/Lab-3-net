using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    public interface IClient
    {
        void Create(int type);
        Document GetDocument();
        void FillDocument();
    }
}
