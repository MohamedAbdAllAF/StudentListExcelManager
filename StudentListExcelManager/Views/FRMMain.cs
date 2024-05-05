using Microsoft.Extensions.DependencyInjection;
using StudentListExcelManager;
using StudentListExcelManager.IServices;
using StudentListExcelManager.Services;

namespace LMS.Views
{
    public partial class FRMMain : Form
    {
        private readonly IFormService _formService;
        private bool _isNormal = true;
        public FRMMain(FormService formService)
        {
            InitializeComponent();
            LoadForm(new FRMDashboard());
            _formService = formService;
        }

        #region Form Loader Controller

        private Form activeForm = null;
        public void LoadForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public async Task LoadFormAsync(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();

            // Use await to asynchronously show the form
            await Task.Yield(); // Ensure the control returns to the caller to maintain responsiveness
            childForm.Show();
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            //originalSizes = _resizer.GetControlSizes(this);
        }

        private void FRMMain_Resize(object sender, EventArgs e)
        {
            //_resizer.ResizeComponents(this, originalSizes);
        }

        #endregion

        #region Make The Form Movable Events
        bool drag = false;
        Point StartPoint = new Point(0, 0);
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point Current = PointToScreen(e.Location);
                this.Location = new Point(Current.X - StartPoint.X, Current.Y - StartPoint.Y);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        #region Exit Label Events

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.Red;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(19, 20, 50);
        }


        #endregion

        #region Minimize Label Events

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(50, 80, 150);
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(19, 20, 50);
        }


        #endregion

        #region Maximize Label Events
        private void lblMaxmize_Click(object sender, EventArgs e)
        {
            if (_isNormal)
            {
                WindowState = FormWindowState.Maximized;
                lblMaxmize.Image = StudentListExcelManager.Properties.Resources.icons8_restore_down_32;
                _isNormal = false;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                lblMaxmize.Image = StudentListExcelManager.Properties.Resources.icons8_maximize_24;
                _isNormal = true;
            }
        }

        private void lblMaxmize_MouseEnter(object sender, EventArgs e)
        {
            lblMaxmize.BackColor = Color.FromArgb(50, 80, 150);
        }

        private void lblMaxmize_MouseLeave(object sender, EventArgs e)
        {
            lblMaxmize.BackColor = Color.FromArgb(19, 20, 50);
        }
        #endregion

        private async void pctDashboard_Click(object sender, EventArgs e)
        {
            await LoadFormAsync(new FRMDashboard());
        }

        private async void btnAddNewStudent_Click_1(object sender, EventArgs e)
        {
            await LoadFormAsync(_formService.NewStudentForm());
        }

        private void btnConvertToExcel_Click(object sender, EventArgs e)
        {
            List<MyClass> data = new List<MyClass>
            {
                new MyClass { Id = 1, Name = "John", Age = 30 },
                new MyClass { Id = 2, Name = "Alice", Age = 25 },
                new MyClass { Id = 3, Name = "Bob", Age = 40 }
            };

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial directory (optional)
            folderBrowserDialog.SelectedPath = @"C:\";

            // Show the dialog and get the result
            DialogResult result = folderBrowserDialog.ShowDialog();

            // If the user clicked OK, proceed
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                // Combine the folder path with the file name to create the full path
                string fileName = "output.xlsx"; // Change this to your desired file name
                string fullPath = Path.Combine(folderPath, fileName);

                ExcelConverter.ConvertToExcel(data, fullPath);

                // Now you can save the file using the fullPath
                // For example:
                //File.WriteAllText(fullPath, "Your file content");
            }

            // Call the method to convert to Excel
            
        }
    }

    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
