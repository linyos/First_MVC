using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MVCDI.Controller;
using MVCDI.View;
using MVCDI.Service;
using MVCDI.ViewController;
namespace MVCDI
{
   public class StartUp
    {
        public StartUp()
        {

        }

        public Autofac.IContainer Initalize()
        {
            var builder = new ContainerBuilder();


            builder.RegisterModule<Autofac.Extras.NLog.NLogModule>();


            // 註冊Controller
            builder.RegisterType<MainController>().As<IMainController>().InstancePerLifetimeScope();
            builder.RegisterType<ToolImportController>().As<IToolImportController>().InstancePerLifetimeScope();


            //註冊ViewController
            builder.RegisterType<ToolViewController>().As<IToolViewController>().InstancePerLifetimeScope();



            //註冊Views
            builder.RegisterType<MainView>().As<IMainView>().InstancePerLifetimeScope();
            builder.RegisterType<ToolView>().As<IToolView>().InstancePerLifetimeScope();

            //註冊Services
            builder.RegisterType<MessageBoxService>().As<IMessageBoxService>().InstancePerLifetimeScope();
            builder.RegisterType<ToolImportService>().As<IToolImportService>().InstancePerLifetimeScope();

            var container = builder.Build();
            return container;
        }
    }





}
