using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDI.View;
using MVCDI.Service;
using MVCDI.Controller;
namespace MVCDI.ViewController
{
    public class ToolViewController: IToolViewController
    {


        private readonly IMessageBoxService _messageBoxService = null;
        private readonly IToolImportService _toolImportService = null;



        public ToolViewController(IMessageBoxService messageBoxService , IToolImportService toolImportService)
        {
            _messageBoxService = messageBoxService ?? throw new ArgumentNullException(nameof(IMessageBoxService));
            _toolImportService = toolImportService ?? throw new ArgumentNullException(nameof(IToolImportService));
        }

        public IToolView GetToolView(IToolImportController toolImportController)
        {
            ToolView view = new ToolView(_messageBoxService , toolImportController , _toolImportService);
            return view;
        }

    }
}
