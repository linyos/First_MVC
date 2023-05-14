using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDI.View;
using MVCDI.ViewController;
using MVCDI.Controller;
using System.Data;
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

        public DataTable  CreateData()
        {
            ////Parent table  
            DataTable dtstudent = new DataTable();
            // add column to datatable     
            dtstudent.Columns.Add("Student_ID", typeof(int));
            dtstudent.Columns.Add("Student_Name", typeof(string));
            dtstudent.Columns.Add("Student_RollNo", typeof(string));

            //Child table  
            DataTable dtstudentMarks = new DataTable();
            dtstudentMarks.Columns.Add("Student_ID", typeof(int));
            dtstudentMarks.Columns.Add("Student_Name", typeof(string));
            //dtstudentMarks.Columns.Add("Subject_Name", typeof(string));
            //dtstudentMarks.Columns.Add("Marks", typeof(int));


            //Adding Rows  

            dtstudent.Rows.Add(111, "Devesh", "03021013014");
            dtstudent.Rows.Add(222, "ROLI", "0302101444");
            dtstudent.Rows.Add(333, "ROLI Ji", "030212222");
            dtstudent.Rows.Add(444, "NIKHIL", "KANPUR");

            // data for devesh ID=111  

            dtstudentMarks.Rows.Add(111, "AAAD");
            dtstudentMarks.Rows.Add(111, "ASDSAD");
            dtstudentMarks.Rows.Add(111, "ASDASD");
            dtstudentMarks.Rows.Add(111, "SDFSDF");

            dtstudentMarks.Rows.Add(333, "AAAD");
            dtstudentMarks.Rows.Add(333, "ASDSAD");

            //Add two DataTables  in Dataset   
            DataSet dsDataset = new DataSet();
            dsDataset.Tables.Add(dtstudent);
            dsDataset.Tables.Add(dtstudentMarks);


            DataRelation Datatablerelation = new DataRelation("DetailsMarks", dtstudent.Columns["Student_ID"], dtstudentMarks.Columns["Student_ID"]);
            dsDataset.Relations.Add(Datatablerelation);

            return dsDataset.Tables[0];
        }


    }
}
