using MVCDI.Controller;
using MVCDI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDI.ViewController
{
    public interface IToolViewController
    {

        IToolView GetToolView(IToolImportController toolImportController);
    }
}
