using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDI.View;
using MVCDI.ViewController;
using MVCDI.Controller;
namespace MVCDI.Service
{
    public class ToolImportService: IToolImportService
    {
        private readonly IMessageBoxService _messageBoxService = null;

        public ToolImportService(IMessageBoxService messageBoxService)
        {
            _messageBoxService = messageBoxService ?? throw new ArgumentNullException(nameof(IMessageBoxService));
        }


        public int plue(int a, int b)
        {
            _messageBoxService.ShowInformation("加");

            return a + b;
        }


    }
}
