using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application
{
    internal interface ICRUD
    {
        void Add();
        void Update();
        void Delete();
        void View();
    }
}
