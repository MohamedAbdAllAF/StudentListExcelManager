namespace StudentListExcelManager
{
    partial class FRMNewStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            btnDeleteStudent = new Button();
            btnSaveStudent = new Button();
            groupBox6 = new GroupBox();
            groupBox8 = new GroupBox();
            txtPostalCodeOfParent = new TextBox();
            label31 = new Label();
            cmbParentCountry = new ComboBox();
            cmbParentGovernorate = new ComboBox();
            cmbParentCity = new ComboBox();
            label32 = new Label();
            label33 = new Label();
            txtParentStreet = new TextBox();
            label34 = new Label();
            label35 = new Label();
            groupBox10 = new GroupBox();
            txtParentJob = new TextBox();
            label45 = new Label();
            txtParentName = new TextBox();
            label46 = new Label();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            txtDegree = new TextBox();
            label19 = new Label();
            txtSeatNumber = new TextBox();
            label23 = new Label();
            dtpQualificationYear = new DateTimePicker();
            label16 = new Label();
            txtPreQualification = new TextBox();
            label17 = new Label();
            groupBox3 = new GroupBox();
            btnDeletePhoneNumber = new Button();
            btnSavePhoneNumber = new Button();
            groupBox4 = new GroupBox();
            cmbPhoneType = new ComboBox();
            label15 = new Label();
            txtPhoneNumber = new TextBox();
            label14 = new Label();
            label13 = new Label();
            lvPhonesList = new ListView();
            PhoneId = new ColumnHeader();
            PhoneType = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            txtPostalCode = new TextBox();
            label12 = new Label();
            cmbCountry = new ComboBox();
            cmbGovernorate = new ComboBox();
            cmbCity = new ComboBox();
            label18 = new Label();
            label20 = new Label();
            txtStreet = new TextBox();
            label21 = new Label();
            label22 = new Label();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label24 = new Label();
            txtPassword = new TextBox();
            label11 = new Label();
            txtReleasePlace = new TextBox();
            label9 = new Label();
            txtPlaceOfBirth = new TextBox();
            label10 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label7 = new Label();
            txtStudentCode = new TextBox();
            label8 = new Label();
            cmbNationality = new ComboBox();
            cmbReligion = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbGender = new ComboBox();
            label3 = new Label();
            txtNationalID = new TextBox();
            label4 = new Label();
            txtNameEnglish = new TextBox();
            label2 = new Label();
            txtNameArabic = new TextBox();
            label1 = new Label();
            pnlMain.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(btnDeleteStudent);
            pnlMain.Controls.Add(btnSaveStudent);
            pnlMain.Controls.Add(groupBox6);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1050, 680);
            pnlMain.TabIndex = 0;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(746, 888);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(139, 104);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Visible = false;
            // 
            // btnSaveStudent
            // 
            btnSaveStudent.Location = new Point(891, 888);
            btnSaveStudent.Name = "btnSaveStudent";
            btnSaveStudent.Size = new Size(139, 104);
            btnSaveStudent.TabIndex = 3;
            btnSaveStudent.Text = "Save";
            btnSaveStudent.UseVisualStyleBackColor = true;
            btnSaveStudent.Click += btnSaveStudent_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox8);
            groupBox6.Controls.Add(groupBox10);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.ForeColor = Color.FromArgb(19, 20, 50);
            groupBox6.Location = new Point(2, 648);
            groupBox6.Margin = new Padding(0);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(0);
            groupBox6.Size = new Size(1031, 237);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Parent's Data";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtPostalCodeOfParent);
            groupBox8.Controls.Add(label31);
            groupBox8.Controls.Add(cmbParentCountry);
            groupBox8.Controls.Add(cmbParentGovernorate);
            groupBox8.Controls.Add(cmbParentCity);
            groupBox8.Controls.Add(label32);
            groupBox8.Controls.Add(label33);
            groupBox8.Controls.Add(txtParentStreet);
            groupBox8.Controls.Add(label34);
            groupBox8.Controls.Add(label35);
            groupBox8.Location = new Point(7, 93);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1018, 135);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Communication Data";
            // 
            // txtPostalCodeOfParent
            // 
            txtPostalCodeOfParent.Location = new Point(660, 60);
            txtPostalCodeOfParent.Name = "txtPostalCodeOfParent";
            txtPostalCodeOfParent.Size = new Size(333, 29);
            txtPostalCodeOfParent.TabIndex = 17;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(495, 62);
            label31.Name = "label31";
            label31.Size = new Size(121, 24);
            label31.TabIndex = 16;
            label31.Text = "Postal Code :";
            // 
            // cmbParentCountry
            // 
            cmbParentCountry.FormattingEnabled = true;
            cmbParentCountry.Location = new Point(141, 23);
            cmbParentCountry.Name = "cmbParentCountry";
            cmbParentCountry.Size = new Size(348, 32);
            cmbParentCountry.TabIndex = 15;
            cmbParentCountry.SelectedIndexChanged += cmbParentCountry_SelectedIndexChanged;
            // 
            // cmbParentGovernorate
            // 
            cmbParentGovernorate.FormattingEnabled = true;
            cmbParentGovernorate.Location = new Point(141, 58);
            cmbParentGovernorate.Name = "cmbParentGovernorate";
            cmbParentGovernorate.Size = new Size(348, 32);
            cmbParentGovernorate.TabIndex = 14;
            cmbParentGovernorate.SelectedIndexChanged += cmbParentGovernorate_SelectedIndexChanged;
            // 
            // cmbParentCity
            // 
            cmbParentCity.FormattingEnabled = true;
            cmbParentCity.Location = new Point(141, 93);
            cmbParentCity.Name = "cmbParentCity";
            cmbParentCity.Size = new Size(348, 32);
            cmbParentCity.TabIndex = 13;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(6, 97);
            label32.Name = "label32";
            label32.Size = new Size(50, 24);
            label32.TabIndex = 9;
            label32.Text = "City :";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 62);
            label33.Name = "label33";
            label33.Size = new Size(124, 24);
            label33.TabIndex = 4;
            label33.Text = "Governorate :";
            // 
            // txtParentStreet
            // 
            txtParentStreet.Location = new Point(660, 25);
            txtParentStreet.Name = "txtParentStreet";
            txtParentStreet.Size = new Size(333, 29);
            txtParentStreet.TabIndex = 3;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(495, 27);
            label34.Name = "label34";
            label34.Size = new Size(68, 24);
            label34.TabIndex = 2;
            label34.Text = "Street :";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(6, 27);
            label35.Name = "label35";
            label35.Size = new Size(85, 24);
            label35.TabIndex = 0;
            label35.Text = "Country :";
            // 
            // groupBox10
            // 
            groupBox10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox10.Controls.Add(txtParentJob);
            groupBox10.Controls.Add(label45);
            groupBox10.Controls.Add(txtParentName);
            groupBox10.Controls.Add(label46);
            groupBox10.Location = new Point(7, 22);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(1018, 65);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            groupBox10.Text = "Main Data";
            // 
            // txtParentJob
            // 
            txtParentJob.Location = new Point(663, 23);
            txtParentJob.Name = "txtParentJob";
            txtParentJob.Size = new Size(330, 29);
            txtParentJob.TabIndex = 3;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(495, 25);
            label45.Name = "label45";
            label45.Size = new Size(51, 24);
            label45.TabIndex = 2;
            label45.Text = "Job :";
            // 
            // txtParentName
            // 
            txtParentName.Location = new Point(161, 23);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(328, 29);
            txtParentName.TabIndex = 1;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(6, 25);
            label46.Name = "label46";
            label46.Size = new Size(71, 24);
            label46.TabIndex = 0;
            label46.Text = "Name :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.FromArgb(19, 20, 50);
            groupBox1.Location = new Point(2, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(1031, 648);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student's Data";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDegree);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(txtSeatNumber);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(dtpQualificationYear);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(txtPreQualification);
            groupBox5.Controls.Add(label17);
            groupBox5.Location = new Point(10, 525);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1021, 117);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "PreQualification Data";
            // 
            // txtDegree
            // 
            txtDegree.Location = new Point(660, 72);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new Size(333, 29);
            txtDegree.TabIndex = 25;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(495, 74);
            label19.Name = "label19";
            label19.Size = new Size(83, 24);
            label19.TabIndex = 24;
            label19.Text = "Degree :";
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Location = new Point(158, 72);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(331, 29);
            txtSeatNumber.TabIndex = 23;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 74);
            label23.Name = "label23";
            label23.Size = new Size(131, 24);
            label23.TabIndex = 22;
            label23.Text = "Seat Number :";
            // 
            // dtpQualificationYear
            // 
            dtpQualificationYear.Location = new Point(660, 37);
            dtpQualificationYear.Name = "dtpQualificationYear";
            dtpQualificationYear.Size = new Size(333, 29);
            dtpQualificationYear.TabIndex = 21;
            dtpQualificationYear.ValueChanged += dtpQualificationYear_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(495, 39);
            label16.Name = "label16";
            label16.Size = new Size(166, 24);
            label16.TabIndex = 20;
            label16.Text = "Qualification Year :";
            // 
            // txtPreQualification
            // 
            txtPreQualification.Location = new Point(158, 37);
            txtPreQualification.Name = "txtPreQualification";
            txtPreQualification.Size = new Size(331, 29);
            txtPreQualification.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 39);
            label17.Name = "label17";
            label17.Size = new Size(151, 24);
            label17.TabIndex = 18;
            label17.Text = "PreQualification :";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnDeletePhoneNumber);
            groupBox3.Controls.Add(btnSavePhoneNumber);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(lvPhonesList);
            groupBox3.Controls.Add(txtPostalCode);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(cmbCountry);
            groupBox3.Controls.Add(cmbGovernorate);
            groupBox3.Controls.Add(cmbCity);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(txtStreet);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Location = new Point(10, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1018, 245);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Communication Data";
            // 
            // btnDeletePhoneNumber
            // 
            btnDeletePhoneNumber.Enabled = false;
            btnDeletePhoneNumber.FlatStyle = FlatStyle.Flat;
            btnDeletePhoneNumber.Location = new Point(580, 153);
            btnDeletePhoneNumber.Name = "btnDeletePhoneNumber";
            btnDeletePhoneNumber.Size = new Size(74, 67);
            btnDeletePhoneNumber.TabIndex = 22;
            btnDeletePhoneNumber.Text = "Delete";
            btnDeletePhoneNumber.UseVisualStyleBackColor = true;
            btnDeletePhoneNumber.Click += btnDeletePhoneNumber_Click;
            // 
            // btnSavePhoneNumber
            // 
            btnSavePhoneNumber.FlatStyle = FlatStyle.Flat;
            btnSavePhoneNumber.Location = new Point(495, 153);
            btnSavePhoneNumber.Name = "btnSavePhoneNumber";
            btnSavePhoneNumber.Size = new Size(68, 67);
            btnSavePhoneNumber.TabIndex = 21;
            btnSavePhoneNumber.Text = "Add";
            btnSavePhoneNumber.UseVisualStyleBackColor = true;
            btnSavePhoneNumber.Click += btnSavePhoneNumber_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbPhoneType);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtPhoneNumber);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(6, 130);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(483, 100);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Phone";
            // 
            // cmbPhoneType
            // 
            cmbPhoneType.FormattingEnabled = true;
            cmbPhoneType.Location = new Point(152, 58);
            cmbPhoneType.Name = "cmbPhoneType";
            cmbPhoneType.Size = new Size(318, 32);
            cmbPhoneType.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 25);
            label15.Name = "label15";
            label15.Size = new Size(140, 24);
            label15.TabIndex = 21;
            label15.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(152, 23);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(318, 29);
            txtPhoneNumber.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 61);
            label14.Name = "label14";
            label14.Size = new Size(114, 24);
            label14.TabIndex = 23;
            label14.Text = "Phone Type";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(495, 97);
            label13.Name = "label13";
            label13.Size = new Size(159, 24);
            label13.TabIndex = 19;
            label13.Text = "Phone Numbers :";
            // 
            // lvPhonesList
            // 
            lvPhonesList.Columns.AddRange(new ColumnHeader[] { PhoneId, PhoneType, PhoneNumber });
            lvPhonesList.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lvPhonesList.FullRowSelect = true;
            lvPhonesList.GridLines = true;
            lvPhonesList.Location = new Point(660, 95);
            lvPhonesList.Name = "lvPhonesList";
            lvPhonesList.Size = new Size(333, 135);
            lvPhonesList.TabIndex = 18;
            lvPhonesList.UseCompatibleStateImageBehavior = false;
            lvPhonesList.View = View.Details;
            lvPhonesList.SelectedIndexChanged += lvPhonesList_SelectedIndexChanged;
            // 
            // PhoneId
            // 
            PhoneId.Text = "ID";
            PhoneId.Width = 30;
            // 
            // PhoneType
            // 
            PhoneType.Text = "Phone Type";
            PhoneType.Width = 100;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Width = 200;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(660, 60);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(333, 29);
            txtPostalCode.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(495, 62);
            label12.Name = "label12";
            label12.Size = new Size(121, 24);
            label12.TabIndex = 16;
            label12.Text = "Postal Code :";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(141, 23);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(348, 32);
            cmbCountry.TabIndex = 15;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // cmbGovernorate
            // 
            cmbGovernorate.FormattingEnabled = true;
            cmbGovernorate.Location = new Point(141, 58);
            cmbGovernorate.Name = "cmbGovernorate";
            cmbGovernorate.Size = new Size(348, 32);
            cmbGovernorate.TabIndex = 14;
            cmbGovernorate.SelectedIndexChanged += cmbGovernorate_SelectedIndexChanged;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(141, 93);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(348, 32);
            cmbCity.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 97);
            label18.Name = "label18";
            label18.Size = new Size(50, 24);
            label18.TabIndex = 9;
            label18.Text = "City :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 62);
            label20.Name = "label20";
            label20.Size = new Size(124, 24);
            label20.TabIndex = 4;
            label20.Text = "Governorate :";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(660, 25);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(333, 29);
            txtStreet.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(495, 27);
            label21.Name = "label21";
            label21.Size = new Size(68, 24);
            label21.TabIndex = 2;
            label21.Text = "Street :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 27);
            label22.Name = "label22";
            label22.Size = new Size(85, 24);
            label22.TabIndex = 0;
            label22.Text = "Country :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtReleasePlace);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPlaceOfBirth);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtStudentCode);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbNationality);
            groupBox2.Controls.Add(cmbReligion);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbGender);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNationalID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNameEnglish);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNameArabic);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(10, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1018, 243);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Main Data";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(642, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(351, 29);
            txtEmail.TabIndex = 25;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(495, 201);
            label24.Name = "label24";
            label24.Size = new Size(67, 24);
            label24.TabIndex = 24;
            label24.Text = "Email :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(348, 29);
            txtPassword.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 201);
            label11.Name = "label11";
            label11.Size = new Size(93, 24);
            label11.TabIndex = 22;
            label11.Text = "Pasword :";
            // 
            // txtReleasePlace
            // 
            txtReleasePlace.Location = new Point(642, 164);
            txtReleasePlace.Name = "txtReleasePlace";
            txtReleasePlace.Size = new Size(351, 29);
            txtReleasePlace.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(495, 166);
            label9.Name = "label9";
            label9.Size = new Size(141, 24);
            label9.TabIndex = 20;
            label9.Text = "Release Place :";
            // 
            // txtPlaceOfBirth
            // 
            txtPlaceOfBirth.Location = new Point(141, 164);
            txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            txtPlaceOfBirth.Size = new Size(348, 29);
            txtPlaceOfBirth.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 166);
            label10.Name = "label10";
            label10.Size = new Size(129, 24);
            label10.TabIndex = 18;
            label10.Text = "Place of Birth :";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(642, 129);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(351, 29);
            dtpDateOfBirth.TabIndex = 17;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 131);
            label7.Name = "label7";
            label7.Size = new Size(120, 24);
            label7.TabIndex = 16;
            label7.Text = "Date of Birth :";
            // 
            // txtStudentCode
            // 
            txtStudentCode.Location = new Point(141, 129);
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(348, 29);
            txtStudentCode.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 131);
            label8.Name = "label8";
            label8.Size = new Size(135, 24);
            label8.TabIndex = 14;
            label8.Text = "Student Code :";
            // 
            // cmbNationality
            // 
            cmbNationality.FormattingEnabled = true;
            cmbNationality.Location = new Point(141, 91);
            cmbNationality.Name = "cmbNationality";
            cmbNationality.Size = new Size(348, 32);
            cmbNationality.TabIndex = 13;
            // 
            // cmbReligion
            // 
            cmbReligion.FormattingEnabled = true;
            cmbReligion.Location = new Point(642, 91);
            cmbReligion.Name = "cmbReligion";
            cmbReligion.Size = new Size(351, 32);
            cmbReligion.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(495, 95);
            label5.Name = "label5";
            label5.Size = new Size(89, 24);
            label5.TabIndex = 11;
            label5.Text = "Religion :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 95);
            label6.Name = "label6";
            label6.Size = new Size(105, 24);
            label6.TabIndex = 9;
            label6.Text = "Nationality :";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(642, 56);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(351, 32);
            cmbGender.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 60);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 6;
            label3.Text = "Gender :";
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(141, 58);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(348, 29);
            txtNationalID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 60);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 4;
            label4.Text = "National ID :";
            // 
            // txtNameEnglish
            // 
            txtNameEnglish.Location = new Point(642, 23);
            txtNameEnglish.Name = "txtNameEnglish";
            txtNameEnglish.Size = new Size(351, 29);
            txtNameEnglish.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 25);
            label2.Name = "label2";
            label2.Size = new Size(139, 24);
            label2.TabIndex = 2;
            label2.Text = "English Name :";
            // 
            // txtNameArabic
            // 
            txtNameArabic.Location = new Point(141, 23);
            txtNameArabic.Name = "txtNameArabic";
            txtNameArabic.Size = new Size(348, 29);
            txtNameArabic.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 0;
            label1.Text = "Arabic Name :";
            // 
            // FRMNewStudent
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 680);
            Controls.Add(pnlMain);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FRMNewStudent";
            Text = "Form1";
            pnlMain.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNameEnglish;
        private Label label2;
        private TextBox txtNameArabic;
        private Label label1;
        private ComboBox cmbGender;
        private Label label3;
        private TextBox txtNationalID;
        private Label label4;
        private ComboBox cmbReligion;
        private Label label5;
        private Label label6;
        private ComboBox cmbNationality;
        private Label label7;
        private TextBox txtStudentCode;
        private Label label8;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtReleasePlace;
        private Label label9;
        private TextBox txtPlaceOfBirth;
        private Label label10;
        private TextBox txtPassword;
        private Label label11;
        private GroupBox groupBox3;
        private ComboBox cmbCountry;
        private ComboBox cmbGovernorate;
        private ComboBox cmbCity;
        private Label label18;
        private Label label20;
        private TextBox txtStreet;
        private Label label21;
        private Label label22;
        private TextBox txtPostalCode;
        private Label label12;
        private ListView lvPhonesList;
        private Label label13;
        private ColumnHeader PhoneId;
        private ColumnHeader PhoneNumber;
        private ColumnHeader PhoneType;
        private GroupBox groupBox4;
        private ComboBox cmbPhoneType;
        private Label label15;
        private TextBox txtPhoneNumber;
        private Label label14;
        private Button btnSavePhoneNumber;
        private Button btnDeletePhoneNumber;
        private GroupBox groupBox5;
        private DateTimePicker dtpQualificationYear;
        private Label label16;
        private TextBox txtPreQualification;
        private Label label17;
        private Label label19;
        private TextBox txtSeatNumber;
        private Label label23;
        private GroupBox groupBox6;
        private GroupBox groupBox8;
        private TextBox txtPostalCodeOfParent;
        private Label label31;
        private ComboBox cmbParentCountry;
        private ComboBox cmbParentGovernorate;
        private ComboBox cmbParentCity;
        private Label label32;
        private Label label33;
        private TextBox txtParentStreet;
        private Label label34;
        private Label label35;
        private GroupBox groupBox10;
        private TextBox txtParentJob;
        private Label label45;
        private TextBox txtParentName;
        private Label label46;
        private TextBox txtEmail;
        private Label label24;
        private TextBox txtDegree;
        private Button btnSaveStudent;
        private Button btnDeleteStudent;
    }
}
