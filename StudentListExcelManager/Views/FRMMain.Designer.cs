namespace LMS.Views
{
    partial class FRMMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMain));
            pnlContainer = new Panel();
            lblMaxmize = new Label();
            lblExit = new Label();
            lblMinimize = new Label();
            picLoader = new PictureBox();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlLogo = new Panel();
            pctDashboard = new PictureBox();
            pnlSideBar = new Panel();
            btnSearch = new Button();
            btnAddNewStudent = new Button();
            btnConvertToExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)picLoader).BeginInit();
            pnlHeader.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDashboard).BeginInit();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainer.Location = new Point(230, 40);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1050, 680);
            pnlContainer.TabIndex = 2;
            // 
            // lblMaxmize
            // 
            lblMaxmize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMaxmize.ForeColor = Color.White;
            lblMaxmize.Image = StudentListExcelManager.Properties.Resources.icons8_maximize_24;
            lblMaxmize.Location = new Point(1197, 0);
            lblMaxmize.Name = "lblMaxmize";
            lblMaxmize.Size = new Size(40, 40);
            lblMaxmize.TabIndex = 2;
            lblMaxmize.TextAlign = ContentAlignment.MiddleCenter;
            lblMaxmize.Click += lblMaxmize_Click;
            lblMaxmize.MouseEnter += lblMaxmize_MouseEnter;
            lblMaxmize.MouseLeave += lblMaxmize_MouseLeave;
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(1237, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(40, 40);
            lblExit.TabIndex = 0;
            lblExit.Text = "X";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            lblExit.Click += lblExit_Click;
            lblExit.MouseEnter += lblExit_MouseEnter;
            lblExit.MouseLeave += lblExit_MouseLeave;
            // 
            // lblMinimize
            // 
            lblMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinimize.ForeColor = Color.White;
            lblMinimize.Image = StudentListExcelManager.Properties.Resources.icons8_minimize_24;
            lblMinimize.Location = new Point(1157, 0);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new Size(40, 40);
            lblMinimize.TabIndex = 1;
            lblMinimize.TextAlign = ContentAlignment.MiddleCenter;
            lblMinimize.Click += lblMinimize_Click;
            lblMinimize.MouseEnter += lblMinimize_MouseEnter;
            lblMinimize.MouseLeave += lblMinimize_MouseLeave;
            // 
            // picLoader
            // 
            picLoader.Image = StudentListExcelManager.Properties.Resources._752;
            picLoader.Location = new Point(227, 0);
            picLoader.Name = "picLoader";
            picLoader.Size = new Size(51, 40);
            picLoader.SizeMode = PictureBoxSizeMode.Zoom;
            picLoader.TabIndex = 10;
            picLoader.TabStop = false;
            picLoader.Visible = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(19, 20, 50);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblMinimize);
            pnlHeader.Controls.Add(picLoader);
            pnlHeader.Controls.Add(lblExit);
            pnlHeader.Controls.Add(lblMaxmize);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 40);
            pnlHeader.TabIndex = 1;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            pnlHeader.MouseMove += pnlHeader_MouseMove;
            pnlHeader.MouseUp += pnlHeader_MouseUp;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EduWay System";
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pctDashboard);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 120);
            pnlLogo.TabIndex = 0;
            // 
            // pctDashboard
            // 
            pctDashboard.Dock = DockStyle.Top;
            pctDashboard.Image = StudentListExcelManager.Properties.Resources.Logo;
            pctDashboard.Location = new Point(0, 0);
            pctDashboard.Name = "pctDashboard";
            pctDashboard.Size = new Size(230, 120);
            pctDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pctDashboard.TabIndex = 0;
            pctDashboard.TabStop = false;
            pctDashboard.Click += pctDashboard_Click;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(19, 20, 50);
            pnlSideBar.Controls.Add(btnConvertToExcel);
            pnlSideBar.Controls.Add(btnSearch);
            pnlSideBar.Controls.Add(btnAddNewStudent);
            pnlSideBar.Controls.Add(pnlLogo);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 40);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(230, 680);
            pnlSideBar.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(50, 80, 150);
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 80, 150);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 20, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(0, 160);
            btnSearch.Margin = new Padding(1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(230, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddNewStudent
            // 
            btnAddNewStudent.Dock = DockStyle.Top;
            btnAddNewStudent.FlatAppearance.BorderColor = Color.FromArgb(50, 80, 150);
            btnAddNewStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 80, 150);
            btnAddNewStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 20, 50);
            btnAddNewStudent.FlatStyle = FlatStyle.Flat;
            btnAddNewStudent.ForeColor = Color.White;
            btnAddNewStudent.Location = new Point(0, 120);
            btnAddNewStudent.Margin = new Padding(1);
            btnAddNewStudent.Name = "btnAddNewStudent";
            btnAddNewStudent.Size = new Size(230, 40);
            btnAddNewStudent.TabIndex = 1;
            btnAddNewStudent.Text = "Add New Student";
            btnAddNewStudent.UseVisualStyleBackColor = true;
            btnAddNewStudent.Click += btnAddNewStudent_Click_1;
            // 
            // btnConvertToExcel
            // 
            btnConvertToExcel.Dock = DockStyle.Bottom;
            btnConvertToExcel.FlatAppearance.BorderColor = Color.FromArgb(50, 80, 150);
            btnConvertToExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 80, 150);
            btnConvertToExcel.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 20, 50);
            btnConvertToExcel.FlatStyle = FlatStyle.Flat;
            btnConvertToExcel.ForeColor = Color.White;
            btnConvertToExcel.Location = new Point(0, 640);
            btnConvertToExcel.Margin = new Padding(1);
            btnConvertToExcel.Name = "btnConvertToExcel";
            btnConvertToExcel.Size = new Size(230, 40);
            btnConvertToExcel.TabIndex = 3;
            btnConvertToExcel.Text = "Export as Excel";
            btnConvertToExcel.UseVisualStyleBackColor = true;
            btnConvertToExcel.Click += btnConvertToExcel_Click;
            // 
            // FRMMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlContainer);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "FRMMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FRMMain_Load;
            Resize += FRMMain_Resize;
            ((System.ComponentModel.ISupportInitialize)picLoader).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctDashboard).EndInit();
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private Label lblMaxmize;
        private Label lblExit;
        private Label lblMinimize;
        private PictureBox picLoader;
        private Panel pnlHeader;
        private Panel pnlLogo;
        private PictureBox pctDashboard;
        private Panel pnlSideBar;
        private Button btnAddNewStudent;
        private Button btnSearch;
        private Label lblTitle;
        private Button btnConvertToExcel;
    }
}