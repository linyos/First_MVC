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
using MVCDI.Service;
using MVCDI.ViewController;


namespace MVCDI.View
{
    public partial class ToolView : Form , IToolView
    {
        private readonly IMessageBoxService _messageBoxService = null;
        private readonly IToolImportController _toolImportController = null;
        private readonly IToolImportService _toolImportService= null;

        public ToolView(IMessageBoxService messageBoxService , IToolImportController toolImportController,
                        IToolImportService toolImportService)
        {

            _messageBoxService = messageBoxService ?? throw new ArgumentNullException(nameof(IMessageBoxService));
            _toolImportController = toolImportController ?? throw new ArgumentNullException(nameof(IToolImportController));
            _toolImportService = toolImportService ?? throw new ArgumentNullException(nameof(IToolImportService));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            label2.Text = (_toolImportService.plue(int.Parse(textBox1.Text), int.Parse(textBox2.Text))).ToString();
        }
    }
}
