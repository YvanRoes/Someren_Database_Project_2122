using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            this.Size = new Size(978, 544);
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            switch (panelName)
            {
                case "Dashboard":
                    // hide all other panels
                    pnlStudents.Hide();
                    pnlLecturers.Hide();
                    pnlActivities.Hide();
                    pnlRooms.Hide();
                    pnlStock.Hide();
                    pnlRegister.Hide();
                    pnlReport.Hide();

                    // show dashboard
                    pnlDashboard.Show();
                    imgDashboard.Show();
                    pnlDashboard.Dock = DockStyle.Fill;
                    break;
                case "Students":
                    // hide all other panels
                    pnlDashboard.Hide();
                    imgDashboard.Hide();
                    pnlLecturers.Hide();
                    pnlActivities.Hide();
                    pnlRooms.Hide();
                    pnlStock.Hide();
                    pnlRegister.Hide();
                    pnlReport.Hide();

                    // show students
                    pnlStudents.Show();
                    pnlStudents.Dock = DockStyle.Fill;
                    break;
                case "Lecturers":
                    //hide all other panels
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    imgDashboard.Hide();
                    pnlActivities.Hide();
                    pnlRooms.Hide();
                    pnlStock.Hide();
                    pnlRegister.Hide();
                    pnlReport.Hide();

                    //show lecturers
                    pnlLecturers.Show();
                    pnlLecturers.Dock = DockStyle.Fill;
                    break;
                case "Activities":
                    //hide all other panels 
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    pnlRooms.Hide();
                    pnlLecturers.Hide();
                    pnlStock.Hide();
                    pnlRegister.Hide();
                    pnlReport.Hide();

                    //show activities                    
                    pnlActivities.Show();
                    pnlActivities.Dock = DockStyle.Fill;
                    break;
                case "Rooms":
                    //hide all other panels
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    pnlActivities.Hide();
                    pnlLecturers.Hide();
                    pnlStudents.Hide();
                    pnlStock.Hide();
                    pnlRegister.Hide();
                    pnlReport.Hide();

                    //show rooms
                    pnlRooms.Show();
                    pnlRooms.Dock = DockStyle.Fill;
                    break;
                case "Stock management":
                    //hide
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    pnlActivities.Hide();
                    pnlLecturers.Hide();
                    pnlStudents.Hide();
                    pnlRooms.Hide();
                    pnlRegister.Hide();
                    pnlReport.Hide();

                    //show
                    pnlStock.Show();
                    pnlStock.Dock = DockStyle.Fill;
                    break;
                case "Cash register":
                    //hide
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    pnlActivities.Hide();
                    pnlLecturers.Hide();
                    pnlStudents.Hide();
                    pnlRooms.Hide();
                    pnlStock.Hide();
                    pnlReport.Hide();

                    //show
                    pnlRegister.Show();
                    pnlRegister.Dock = DockStyle.Fill;                   
                    break;
                case "Revenue report":
                    //hide
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    pnlActivities.Hide();
                    pnlLecturers.Hide();
                    pnlStudents.Hide();
                    pnlRooms.Hide();
                    pnlStock.Hide();
                    pnlRegister.Hide();
                    
                    //show
                    pnlReport.Show();
                    pnlReport.Dock = DockStyle.Fill;
                    break;

            }
            
            if (panelName == "Students")
            {               
                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;
                    
                    // clear the listview before filling it again
                    ListViewStudents.Clear();
                    ListViewStudents.View = View.Details;
                    ListViewStudents.FullRowSelect = true;
                    ListViewStudents.Columns.Add("ID", 254);
                    ListViewStudents.Columns.Add("First name", 254);
                    ListViewStudents.Columns.Add("Last name", 254);
                    
                    //List View
                    foreach (Student s in studentList)
                    {
                        string[] name = s.Name.Split(new[] {' '}, 2);
                        string[] item = { s.Number.ToString(), name[0], name[1] };
                        ListViewItem li = new ListViewItem(item);                        
                        ListViewStudents.Items.Add(li);

                    }
                    if (studentList.Count == 0)
                        throw new Exception("There is currently no content in this table. Sorry for the inconvenience");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }

            else if (panelName == "Lecturers")
            {
                try
                {
                    // fill the teachers listview with a list of teachers
                    TeacherService teacherService = new TeacherService(); ;
                    List<Teacher> teacherList = teacherService.GetTeachers(); ;
                    // clear the listview before filling it again
                    ListViewLecturers.Clear();
                    ListViewLecturers.View = View.Details;
                    ListViewLecturers.FullRowSelect = true;
                    ListViewLecturers.Columns.Add("ID", 254);
                    ListViewLecturers.Columns.Add("First name", 254);
                    ListViewLecturers.Columns.Add("Last name", 254);

                    //List View
                    foreach (Teacher teacher in teacherList)
                    {
                        string[] name = teacher.Name.Split(new[] { ' ' }, 2);
                        string[] item = { teacher.Number.ToString(), name[0], name[1] };
                        ListViewItem li = new ListViewItem(item);
                        ListViewLecturers.Items.Add(li);

                    }
                    if (teacherList.Count == 0)
                        throw new Exception("There is currently no content in this table. Sorry for the inconvenience");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                try
                {

                    RoomService roomService = new RoomService(); ;
                    List<Room> roomList = roomService.GetRooms(); ;

                    ListViewRooms.Clear();
                    ListViewRooms.View = View.Details;
                    ListViewRooms.FullRowSelect = true;
                    ListViewRooms.Columns.Add("Room number", 254);
                    ListViewRooms.Columns.Add("Number of beds", 254);
                    ListViewRooms.Columns.Add("Room type", 254);


                    foreach (Room room in roomList)
                    {
                        string roomType;
                        if (room.Type == 0)
                        {
                            roomType = "Student";
                        }
                        else
                        {
                            roomType = "Teacher";
                        }
                        string[] item = { room.Number.ToString(), room.Capacity.ToString(), roomType };
                        ListViewItem li = new ListViewItem(item);
                        ListViewRooms.Items.Add(li);

                    }
                    if (roomList.Count == 0)
                        throw new Exception("There is currently no content in this table. Sorry for the inconvenience");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash register");
        }

        private void StockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Stock management");
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue report");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewStock.Clear();
            ListViewStock.View = View.Details;
            ListViewStock.FullRowSelect = true;
            ListViewStock.Columns.Add("id", 150);
            ListViewStock.Columns.Add("Name", 150);
            ListViewStock.Columns.Add("Price", 150);
            ListViewStock.Columns.Add("Alcoholic", 150);
            ListViewStock.Columns.Add("Stock", 100);
            ListViewStock.Columns.Add("Sold");

            StockService Stock = new StockService();
            List<StockItem> items = Stock.GetItems();



            foreach (StockItem s in items)
            {
                string[] item = { s.Id.ToString(), s.Name, s.Price.ToString(), s.Alcohol ? "yes" : "no", s.Stock.ToString(), s.Sold.ToString() };
                ListViewItem li = new ListViewItem(item);
                ListViewStock.Items.Add(li);

            }
        }
    }
}
