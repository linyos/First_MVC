using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDI.View;
using MVCDI.Service;
using NLog;
using NLog.Config;
using NLog.Targets;
namespace MVCDI.Controller
{
    public class MainController : IMainController
    {

        // Nlog
        private Logger _logger = LogManager.GetCurrentClassLogger();
        // 頁面
        private MainView mainView = null;

        private readonly IMessageBoxService _messageBoxService = null;

        // 工具的Contoller
        private readonly IToolImportController _toolImportController = null;


        public MainController(IMessageBoxService messageBoxService , IToolImportController toolImportContorller)
        {
            _messageBoxService = messageBoxService ?? throw new ArgumentNullException(nameof(IMessageBoxService));
            //_logger = logger ?? throw new ArgumentNullException(nameof(Autofac.Extras.NLog.ILogger));
            CreateLogger();
            _toolImportController = toolImportContorller ?? throw new ArgumentNullException(nameof(IToolImportController));
        
        }

    
        public void Dowork()
        {
            using (mainView = new MainView(_messageBoxService))
            {
                _logger.Info("開始執行");
                _messageBoxService.ShowInformation("開始執行");
                mainView.SetControl(this);
                Application.Run(mainView); 
            }
        }


        public void OpenTool ()
        {
            _logger.Info("執行刀具表");
            _toolImportController.DoWork();
        }



        private static void CreateLogger()
        {
            var config = new LoggingConfiguration();
            var fileTarget = new FileTarget
            {
                FileName = "${basedir}/logs/${shortdate}.log",
                Layout = "${date:format=yyyy-MM-dd HH\\:mm\\:ss} [${uppercase:${level}}] ${message}",
            };
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, fileTarget);
            LogManager.Configuration = config;
        }
    }
}
