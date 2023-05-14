using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDI.Controller;
using MVCDI.View;
using MVCDI.Service;

namespace MVCDI.View
{
    public partial class MainView : Form, IMainView
    {

        private IMainController _control;
        private readonly IMessageBoxService _messageBoxService;

        public MainView(IMessageBoxService messageBoxService )
        {
            _messageBoxService = messageBoxService ?? throw new ArgumentNullException(nameof(IMessageBoxService));
            InitializeComponent();
        }



        public void SetControl(IMainController control)
        {
            _control = control;
        }


        public void ShowView()
        {
            Application.Run(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _control.OpenTool();
        }
    }
}
