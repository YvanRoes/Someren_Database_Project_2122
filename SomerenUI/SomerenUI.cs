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
            showPanel("Login");
            menuStrip1.Visible = false;
        }

        private void showPanel(string panelName)
        {

            switch (panelName)
            {
                case "Dashboard":
                    // hide all other panels
                    HideAllpanels();

                    // show dashboard
                    pnlDashboard.Show();
                    imgDashboard.Show();
                    pnlDashboard.Dock = DockStyle.Fill;
                    menuStrip1.Visible = true;
                    break;
                case "Students":
                    // hide all other panels
                    HideAllpanels();

                    // show students
                    pnlStudents.Show();
                    pnlStudents.Dock = DockStyle.Fill;
                    break;
                case "Lecturers":
                    //hide all other panels
                    HideAllpanels();

                    //show lecturers
                    pnlLecturers.Show();
                    pnlLecturers.Dock = DockStyle.Fill;
                    break;
                case "Activities":
                    //hide all other panels 
                    HideAllpanels();

                    //show activities                    
                    pnlActivities.Show();
                    pnlActivities.Dock = DockStyle.Fill;
                    break;
                case "Rooms":
                    //hide all other panels
                    HideAllpanels();

                    //show rooms
                    pnlRooms.Show();
                    pnlRooms.Dock = DockStyle.Fill;
                    break;
                case "Stock management":
                    //hide
                    HideAllpanels();

                    //show
                    pnlStock.Show();
                    pnlStock.Dock = DockStyle.Fill;
                    ListAllStock();
                    break;
                case "Cash register":
                    //hide
                    HideAllpanels();

                    //disable the checkout button and reset the text
                    btnCheckoutCR.Enabled = false;
                    UpdateCheckoutInfo(0);
                    //show
                    pnlRegister.Show();
                    pnlRegister.Dock = DockStyle.Fill;
                    break;
                case "Revenue report":
                    //hide
                    HideAllpanels();
                    //show
                    pnlReport.Show();
                    pnlReport.Dock = DockStyle.Fill;
                    break;

                case "Activity Students":
                    //hide
                    HideAllpanels();
                    //show
                    pnlActivityStudent.Show();
                    pnlActivityStudent.Dock = DockStyle.Fill;

                    break;

                case "Activity Supervisors":
                    //hide
                    HideAllpanels();
                    //show
                    pnlActivitySuperviser.Show();
                    pnlActivitySuperviser.Dock = DockStyle.Fill;
                    break;

                case "Login":
                    HideAllpanels();

                    pnlLogin.Show();
                    pnlLogin.Dock = DockStyle.Fill;
                    break;
                    
            }

            if (panelName == "Students")
            {
                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents();

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
                        string[] name = s.Name.Split(new[] { ' ' }, 2);
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

            else if (panelName == "Cash register")
            {
                FillListViewCashRegister();
            }

            else if (panelName == "Activity Students")
            {
                FillListViewsActivityStudents();
            }
            else if(panelName == "Activity Supervisors")
            {
                FillForms();
            }

        }

        private void HideAllpanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
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

        private void activityStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activity Students");
        }

        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activity Supervisors");
        }


        //Variant A Yvan Roes
        private void ListAllStock()
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

        private void SelectStockItem()
        {            
            try
            {
                int Id = int.Parse(ListViewStock.FocusedItem.SubItems[0].Text);
                StockService stock = new StockService();
                StockItem item = stock.ItemById(Id);
                txtId.Text = item.Id.ToString();
                txtName.Text = item.Name.ToString();
                txtPrice.Text = item.Price.ToString();
                txtAlcoholic.Text = item.Alcohol ? "yes" : "no";
                txtStock.Text = item.Stock.ToString();

            }
            catch (Exception ex) { throw ex; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StockService stock = new StockService();
            StockItem item = new StockItem()
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Alcohol = txtAlcoholic.Text.ToLower() == "yes" ? true : false,
            };
            stock.UpdateItem(item);
            //update list & clear flields
            ListAllStock();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtName.Text = null;
            txtPrice.Text = null;
            txtAlcoholic.Text = null;
            txtStock.Text=null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockService stock = new StockService();
            StockItem item = new StockItem()
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Alcohol = txtAlcoholic.Text.ToLower() == "yes" ? true : false,
                Stock = int.Parse(txtStock.Text)
            };
            stock.AddItem(item);
            //update list & clear fields
            ListAllStock();
            btnClear_Click(sender, e);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(ListViewStock.SelectedItems[0].Text);
            StockService stock = new StockService();
            stock.DelItem(stock.ItemById(Id));
            //update list & clear fields
            ListAllStock();
            btnClear_Click(sender, e);
        }

        private void ListViewStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStockItem();
        }

        // Variant B - Lucas de Jong
        private void FillListViewCashRegister() 
        {
            try
            {
                // fill the students listview within the cash register panel with a list of students
                StudentService studService = new StudentService(); ;
                List<Student> studentList = studService.GetStudents(); ;

                // clear the listview before filling it again
                ListViewRegisterS.Clear();
                ListViewRegisterS.View = View.Details;
                ListViewRegisterS.FullRowSelect = true;
                ListViewRegisterS.Columns.Add("ID", 70);
                ListViewRegisterS.Columns.Add("Name", 120);

                //List View
                foreach (Student s in studentList)
                {
                    string[] item = { s.Number.ToString(), s.Name };
                    ListViewItem li = new ListViewItem(item);
                    ListViewRegisterS.Items.Add(li);

                }
                if (studentList.Count == 0)
                    throw new Exception("There is currently no content in this table. Sorry for the inconvenience");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }

            try
            {
                // fill the drinks listview within the cash register panel with a list of drinks
                DrinkService drinkService = new DrinkService(); ;
                List<Drink> drinkList = drinkService.GetDrinks(); ;

                // clear the listview before filling it again
                ListViewRegisterD.Clear();
                ListViewRegisterD.View = View.Details;
                ListViewRegisterD.FullRowSelect = true;
                ListViewRegisterD.Columns.Add("ID", 70);
                ListViewRegisterD.Columns.Add("Name", 70);
                ListViewRegisterD.Columns.Add("Alc/No", 70);
                ListViewRegisterD.Columns.Add("Price", 70);
                ListViewRegisterD.Columns.Add("Stock", 70);


                //List View
                foreach (Drink d in drinkList)
                {

                    string[] item = { d.Number.ToString(), d.Name, d.Type ? "No Alc" : "Alc", d.Price.ToString(), d.Stock.ToString() };
                    ListViewItem li = new ListViewItem(item);
                    ListViewRegisterD.Items.Add(li);

                }
                if (drinkList.Count == 0)
                    throw new Exception("There is currently no content in this table. Sorry for the inconvenience");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }

        private void UpdateCheckoutInfo(int resetNum)
        {
            //the reset number is a number that is defaulted to 0 every time the panel goes back to a default setting.
            try
            {
                if (resetNum != 0)
                {
                    throw new Exception("Invalid Parameters! \nUpdateCheckoutInfo()");
                }
                else
                {
                    lblCheckoutInfoCR.Text = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
        }

        private void ListViewRegisterS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verify that both a student and drink are selected
            if ((ListViewRegisterD.SelectedItems.Count != 0) && (ListViewRegisterS.SelectedItems.Count != 0))
            {
                UpdateCheckoutInfo(ListViewRegisterS.SelectedItems[0], ListViewRegisterD.SelectedItems[0]);
                btnCheckoutCR.Enabled = true;
            }
        }

        private void ListViewRegisterD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verify that both a student and drink are selected
            if ((ListViewRegisterD.SelectedItems.Count != 0) && (ListViewRegisterS.SelectedItems.Count != 0))
            {
                UpdateCheckoutInfo(ListViewRegisterS.SelectedItems[0], ListViewRegisterD.SelectedItems[0]);
                btnCheckoutCR.Enabled = true;
            }
        }

        private void UpdateCheckoutInfo(ListViewItem student, ListViewItem drink)
        {
            // make the text say a confirmation message once a drink and student are selected 
            try
            {
                string sName = student.SubItems[1].Text;
                string dName = drink.SubItems[1].Text;
                string price = drink.SubItems[3].Text;
                lblCheckoutInfoCR.Text = $"click the checkout button to confirm that {sName} is purchasing a {dName}.\nPrice: {price}";


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters! \nUpdateCheckoutInfo()");
                throw;
            }
        }

        private void btnCheckoutCR_Click(object sender, EventArgs e)
        {
            UpdateCheckoutInfo(0);

            Buy order = new Buy()
            {
                DrinkId = Convert.ToInt32(ListViewRegisterD.SelectedItems[0].SubItems[0].Text),
                PurchaserId = Convert.ToInt32(ListViewRegisterS.SelectedItems[0].SubItems[0].Text),
                PurchaseTime = DateTime.Now,
            };

            BuyService buyService = new BuyService();
            try
            {
                buyService.AddNewOrder(order);
                buyService.DecreaseStock(order.DrinkId);
                MessageBox.Show($"Purchase was successful.");
                FillListViewCashRegister();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: order already exists in the database!\n" + err.Message);
            }

        }

        // Variant C - Elias Tarin
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            listViewRevenueReport.Clear();
            listViewRevenueReport.View = View.Details;
            listViewRevenueReport.FullRowSelect = true;
            listViewRevenueReport.Columns.Add("Sales", 100);
            listViewRevenueReport.Columns.Add("Turnover", 100);
            listViewRevenueReport.Columns.Add("Number of customers", 150);

            RevenueReport report = new RevenueReport();
            RevenueReportService revenueReportService = new RevenueReportService();
            report = revenueReportService.GetRevenueReport(dateTimePickerStart.Value , dateTimePickerEnd.Value);

            ListViewItem li = new ListViewItem(report.Sales.ToString());
            li.SubItems.Add($"{report.Turnover.ToString()}");
            li.SubItems.Add($"{report.NumberOfCustomers.ToString()}");
            listViewRevenueReport.Items.Add(li);
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
             DateTime startDate = dateTimePickerStart.Value;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
             DateTime endDate = dateTimePickerEnd.Value;
        }


        // Vaiant C Yvan Roes 
        void FillListViewsActivityStudents()
        {
            //Participants
            ActivityStudentService service = new ActivityStudentService();
            List<Student> participants = service.GetParticipants();
            List<Student> nonParticipants = service.GetNonParticipants();

            ListViewActivityStudentP.Clear();
            ListViewActivityStudentP.View = View.Details;
            ListViewActivityStudentP.FullRowSelect = true;
            ListViewActivityStudentP.Columns.Add("Student_Id", 200);
            ListViewActivityStudentP.Columns.Add("Name", 200);
            ListViewActivityStudentP.Columns.Add("Activity", 200);

            foreach (Student p in participants)
            {
                string[] item = { p.Number.ToString(), p.Name , p.Activity};
                ListViewItem li = new ListViewItem(item);
                ListViewActivityStudentP.Items.Add(li);
            }

            //non participants
            ListViewActivityStudentNP.Clear();
            ListViewActivityStudentNP.View = View.Details;
            ListViewActivityStudentNP.FullRowSelect = true;
            ListViewActivityStudentNP.Columns.Add("ID", 254);
            ListViewActivityStudentNP.Columns.Add("Name", 254);

            foreach (Student np in nonParticipants.Distinct())
            {
                string[] item = { np.Number.ToString(), np.Name };
                ListViewItem li = new ListViewItem(item);
                ListViewActivityStudentNP.Items.Add(li);
            }

            List<ActivityStudent> activities = service.GetActivities();

            ListViewStudentActivityList.Clear();
            ListViewStudentActivityList.View = View.Details;
            ListViewStudentActivityList.FullRowSelect = true;
            ListViewStudentActivityList.Columns.Add("Id", 90);
            ListViewStudentActivityList.Columns.Add("Activity", 90);

            foreach(ActivityStudent a in activities)
            {
                string[] item = { a.Activity_ID.ToString(), a.Activity_Description };
                ListViewItem li = new ListViewItem(item);
                ListViewStudentActivityList.Items.Add(li);
            }

        }

        private void ListViewStudentActivityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectActivity();
        }

        void SelectActivity()
        {
            try
            {
                int Id = int.Parse(ListViewStudentActivityList.FocusedItem.SubItems[0].Text);               
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                ActivityStudentService service = new ActivityStudentService();
                int student_id = int.Parse(ListViewActivityStudentNP.FocusedItem.SubItems[0].Text);
                int activity_id = int.Parse(ListViewStudentActivityList.FocusedItem.SubItems[0].Text);
                service.AddStudentActivity(student_id, activity_id);
            }catch(Exception ex) { throw ex; }

            FillListViewsActivityStudents();
            
        }

        private void btnRemoveParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this student from the activity?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActivityStudentService service = new ActivityStudentService();
                    int student_id = int.Parse(ListViewActivityStudentP.FocusedItem.SubItems[0].Text);
                    service.RemoveStudentActivity(student_id);
                }
                
            }
            catch (Exception ex) { throw ex; }

            FillListViewsActivityStudents();
        }

        // Variant B - Elias
        void FillForms()
        {
            ActivitySuperviserService service = new ActivitySuperviserService();
            List<Teacher> participants = service.GetParticipants();
            List<Teacher> nonParticipants = service.GetNonParticipants();

            ListViewParticipants.Clear();
            ListViewParticipants.View = View.Details;
            ListViewParticipants.FullRowSelect = true;
            ListViewParticipants.Columns.Add("Teacher ID", 80);
            ListViewParticipants.Columns.Add("Name", 80);
            ListViewParticipants.Columns.Add("Activity", 80);

            foreach (Teacher teacher in participants)
            {
                string[] item = { teacher.Number.ToString(), teacher.Name, teacher.Activity };
                ListViewItem li = new ListViewItem(item);
                ListViewParticipants.Items.Add(li);
            }

            ListViewNonParticipants.Clear();
            ListViewNonParticipants.View = View.Details;
            ListViewNonParticipants.FullRowSelect = true;
            ListViewNonParticipants.Columns.Add("Teacher ID", 80);
            ListViewNonParticipants.Columns.Add("Teacher Name", 130);

            foreach (Teacher teacher in nonParticipants.Distinct())
            {
                string[] item = { teacher.Number.ToString(), teacher.Name };
                ListViewItem li = new ListViewItem(item);
                ListViewNonParticipants.Items.Add(li);
            }

            List<ActivitySuperviser> activities = service.GetActivities();

            ListViewActivityLecturersActivities.Clear();
            ListViewActivityLecturersActivities.View = View.Details;
            ListViewActivityLecturersActivities.FullRowSelect = true;
            ListViewActivityLecturersActivities.Columns.Add("Id", 30);
            ListViewActivityLecturersActivities.Columns.Add("Activity",  90);

            foreach (ActivitySuperviser activity in activities)
            {
                string[] item = { activity.ActivityId.ToString(), activity.ActivityDescription };
                ListViewItem li = new ListViewItem(item);
                ListViewActivityLecturersActivities.Items.Add(li);
            }
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
           ActivitySuperviserService service = new ActivitySuperviserService();
           int superviserId = int.Parse(ListViewNonParticipants.FocusedItem.SubItems[0].Text);
           int activityId = int.Parse(ListViewActivityLecturersActivities.FocusedItem.SubItems[0].Text);
           service.AddSuperviserActivity(superviserId, activityId);
           FillForms();
        }

        private void btnRemoveLecturer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this supervisor from the activity?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActivitySuperviserService service = new ActivitySuperviserService();
                    int teacherId = int.Parse(ListViewParticipants.FocusedItem.SubItems[0].Text);
                    service.RemoveSuperviserActivity(teacherId);
                }

            }
            catch (Exception ex) { throw ex; }
            FillForms();
        }

        void SelectActivitySuperviser()
        {
            try
            {
                int Id = int.Parse(ListViewActivityLecturersActivities.FocusedItem.SubItems[0].Text);
            }
            catch (Exception ex) { throw ex; }
        }

        private void ListViewActivityLecturersActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectActivitySuperviser();
        }


        //Week 5 Forgot password
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            PasswordReset p = new PasswordReset();
            p.ShowDialog();
        }
    }
}
