using MVCDI.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDI.View
{
   public interface IMainView
    {

        void SetControl(IMainController control);
     

        void ShowView();

    }
}
