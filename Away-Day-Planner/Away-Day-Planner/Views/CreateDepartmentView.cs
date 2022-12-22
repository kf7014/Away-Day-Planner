using Away_Day_Planner.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Away_Day_Planner.Views
{
    public partial class CreateDepartmentView : Form, ICreateDepartmentView
    {
        private CreateDepartmentPresenter createDepartmentPresenter;

        public CreateDepartmentView()
        {
            InitializeComponent();
        }

        public void register(CreateDepartmentPresenter createDepartmentPresenter)
        {
            this.createDepartmentPresenter = createDepartmentPresenter;

            //CONSOLE CODE TO BE DELETED
            Console.WriteLine("current presenter: " + createDepartmentPresenter);
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            //NEEDS FORM SECURITY ADDING

            this.Close();
        }
    }
}
