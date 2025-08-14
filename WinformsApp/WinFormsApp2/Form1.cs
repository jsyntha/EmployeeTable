namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<EmployeeClass> employees = new List<EmployeeClass>();


        public Form1()
        {
            SetUpData();
            InitializeComponent();
        }


        private void SetUpData()
        {
            EmployeeClass e1 = new EmployeeClass(1, "Joshua :3 >3<", "Student", 10000);
            EmployeeClass e2 = new EmployeeClass(2, "Maureen", "Professor", 2289485);
            EmployeeClass e3 = new EmployeeClass(3, "Billy", "Lecturer", 100);
            EmployeeClass e4 = new EmployeeClass(4, "Patrick", "Homeless", 0);

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVList.DataSource = employees;

            var emps = employees.Select(
                emp => new
                {
                    emp.EmpName,
                    emp.EmpPosition,
                    emp.EmpSalary
                }
                );

            DataGridViewButtonColumn editColumn =
            new DataGridViewButtonColumn();
            editColumn.HeaderText = "";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Text = "Edit";
            DGVList.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn =
            new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Text = "Delete";
            DGVList.Columns.Add(deleteColumn);


        }

        private void DGVList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int EditIndex = 4;
            const int DeleteIndex = 5;
            

            if (e.ColumnIndex == EditIndex ||
                e.ColumnIndex == DeleteIndex)
            {

                if (e.ColumnIndex == EditIndex)
                    MessageBox.Show("Edit");
                else if (e.ColumnIndex == DeleteIndex)
                    MessageBox.Show("Delete");
            }
        }
    }
}
