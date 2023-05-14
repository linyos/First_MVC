using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDI.Controller;

namespace MVCDI
{
    static class Program
    {
        private static Autofac.IContainer container = null;


        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {

            var startUp = new StartUp();
            container = startUp.Initalize();
            using (var scope = container.BeginLifetimeScope())
            {
                var control = scope.Resolve<IMainController>();
                control.Dowork();
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
