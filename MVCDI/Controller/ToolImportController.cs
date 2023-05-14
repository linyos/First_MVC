using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDI.View;
using MVCDI.Service;
using MVCDI.ViewController;


namespace MVCDI.Controller
{
   public class ToolImportController :IToolImportController
    {

        private readonly IMessageBoxService _messageBoxService = null;
        private readonly IToolViewController _toolViewController = null;

        private ToolView toolView = null;

        public ToolImportController(IMessageBoxService messageBoxService , IToolViewController toolViewController)
        {
            _messageBoxService = messageBoxService ?? throw new ArgumentNullException(nameof(IMessageBoxService));
            _toolViewController = toolViewController ?? throw new ArgumentNullException(nameof(IToolViewController));

        }

        public void DoWork()
        {
            using (toolView = (ToolView)_toolViewController.GetToolView(this))
            {
                toolView.ShowDialog();
            }
        }



    }
}
