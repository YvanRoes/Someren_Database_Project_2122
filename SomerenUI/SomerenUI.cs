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

                    // show dashboard
                    pnlDashboard.Show();
                    imgDashboard.Show();
                    break;
                case "Students":
                    // hide all other panels
                    pnlDashboard.Hide();
                    imgDashboard.Hide();
                    pnlLecturers.Hide();
                    pnlActivities.Hide();
                    pnlRooms.Hide();

                    // show students
                    pnlStudents.Show();
                    break;
                case "Lecturers":
                    //hide all other panels
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    imgDashboard.Hide();
                    pnlActivities.Hide();
                    pnlRooms.Hide();

                    //show lecturers
                    pnlLecturers.Show();
                    break;
                case "Activities":
                    //hide all other panels 
                    pnlDashboard.Hide();
                    pnlStudents.Hide();
                    pnlRooms.Hide();

                    //show activities                    
                    pnlActivities.Show();
                    break;
                case "Rooms":
                    //hide all other panels
                    pnlDashboard.Hide();
                    pnlStudents.Hide();

                    //show rooms
                    pnlRooms.Show();
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
                    listViewStudents.Clear();
                    listViewStudents.View = View.Details;
                    listViewStudents.FullRowSelect = true;
                    listViewStudents.Columns.Add("ID", 254);
                    listViewStudents.Columns.Add("First name", 254);
                    listViewStudents.Columns.Add("Last name", 254);

                    //List View
                    foreach (Student s in studentList)
                    {
                        string[] name = s.Name.Split(new[] { ' ' }, 2);
                        string[] item = { s.Number.ToString(), name[0], name[1] };
                        ListViewItem li = new ListViewItem(item);
                        listViewStudents.Items.Add(li);

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
                    ListviewLecturers.Clear();
                    ListviewLecturers.View = View.Details;
                    ListviewLecturers.FullRowSelect = true;
                    ListviewLecturers.Columns.Add("ID", 254);
                    ListviewLecturers.Columns.Add("First name", 254);
                    ListviewLecturers.Columns.Add("Last name", 254);

                    //List View
                    foreach (Teacher teacher in teacherList)
                    {
                        string[] name = teacher.Name.Split(new[] { ' ' }, 2);
                        string[] item = { teacher.Number.ToString(), name[0], name[1] };
                        ListViewItem li = new ListViewItem(item);
                        ListviewLecturers.Items.Add(li);

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
                    // fill the teachers listview with a list of teachers
                    RoomService roomService = new RoomService(); ;
                    List<Room> roomList = roomService.GetRooms(); ;
                    // clear the listview before filling it again
                    listViewRooms.Clear();
                    listViewRooms.View = View.Details;
                    listViewRooms.FullRowSelect = true;
                    listViewRooms.Columns.Add("Room number", 254);
                    listViewRooms.Columns.Add("Number of beds", 254);
                    listViewRooms.Columns.Add("Room type", 254);

                    //List View
                    foreach (Room room in roomList)
                    {
                        string roomType = room.Type.ToString();
                        string[] item = { room.Number.ToString(), room.Capacity.ToString(), roomType};
                        ListViewItem li = new ListViewItem(item);
                        listViewRooms.Items.Add(li);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
