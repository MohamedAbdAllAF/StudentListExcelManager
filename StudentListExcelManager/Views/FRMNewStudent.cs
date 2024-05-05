
using StudentListExcelManager.IServices;
using StudentListExcelManager.Models;
using StudentListExcelManager.Models.Enum;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentListExcelManager
{
    public partial class FRMNewStudent : Form
    {
        private readonly ILocationService _locationService;
        private readonly IStudentService _studentService;
        private List<(int id, string number, PhoneType type)> phonesList = new List<(int, string, PhoneType)>();
        public string Status = "New";
        public bool IsPicked_dtpDateOfBirth = false;
        public bool IsPicked_dtpQualificationYear = false;

        public FRMNewStudent(ILocationService locationService, IStudentService studentService)
        {
            _locationService = locationService;
            _studentService = studentService;
            InitializeComponent();
            InitializeComboBoxs();
        }

        private async void InitializeComboBoxs()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(Enum.GetNames(typeof(Gender)));

            cmbNationality.Items.Clear();
            cmbNationality.Items.AddRange(Enum.GetNames(typeof(Nationality)));

            cmbReligion.Items.Clear();
            cmbReligion.Items.AddRange(Enum.GetNames(typeof(Religion)));

            cmbPhoneType.Items.Clear();
            cmbPhoneType.Items.AddRange(Enum.GetNames(typeof(PhoneType)));

            #region fill cmbCountry with data
            EventHandlerManager.SetEventHandlerEnabled(cmbCountry, "SelectedIndexChanged", cmbCountry_SelectedIndexChanged, false);

            List<Country> countries = await _locationService.GetCountriesAsync();
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";
            cmbCountry.DataSource = countries;
            cmbCountry.SelectedIndex = -1;

            EventHandlerManager.SetEventHandlerEnabled(cmbCountry, "SelectedIndexChanged", cmbCountry_SelectedIndexChanged, true);
            #endregion

            #region fill cmbParentCountry with data
            EventHandlerManager.SetEventHandlerEnabled(cmbParentCountry, "SelectedIndexChanged", cmbParentCountry_SelectedIndexChanged, false);

            cmbParentCountry.DisplayMember = "Name";
            cmbParentCountry.ValueMember = "Id";
            cmbParentCountry.DataSource = countries;
            cmbParentCountry.SelectedIndex = -1;

            EventHandlerManager.SetEventHandlerEnabled(cmbParentCountry, "SelectedIndexChanged", cmbParentCountry_SelectedIndexChanged, true);
            #endregion
        }

        private void btnSavePhoneNumber_Click(object sender, EventArgs e)
        {
            int newId = 1;
            if (phonesList.Count != 0)
                newId = phonesList.Max(f => f.id) + 1;

            var phoneType = (PhoneType)cmbPhoneType.SelectedIndex + 1;
            var phoneNumber = txtPhoneNumber.Text.ToString();

            ListViewItem item = new ListViewItem(new[] { newId.ToString(), phoneType.ToString(), phoneNumber });
            lvPhonesList.Items.Add(item);

            phonesList.Add((newId, phoneNumber, phoneType));
        }

        private void lvPhonesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhonesList.SelectedItems.Count > 0)
            {
                btnDeletePhoneNumber.Enabled = true;
            }
            else
            {
                btnDeletePhoneNumber.Enabled = false;
            }
        }

        private void btnDeletePhoneNumber_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lvPhonesList.SelectedItems.Count > 0)
                {
                    List<(int id, string number, PhoneType type)> deletedPhones = new List<(int, string, PhoneType)>();

                    foreach (ListViewItem selectedItem in lvPhonesList.SelectedItems)
                    {
                        lvPhonesList.Items.Remove(selectedItem);

                        int selectedIndex = phonesList.FindIndex(item => item.id == int.Parse(selectedItem.SubItems[0].Text));
                        deletedPhones.Add(phonesList[selectedIndex]);

                        if (selectedIndex != -1)
                        {
                            phonesList.RemoveAt(selectedIndex);
                        }
                    }
                    if (Status == "Edit")
                    {
                        //var done = await _filesController.DeleteFiles(AdminId, deletedFiles);
                    }
                    MessageBox.Show("Phone number deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you to save?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DateTime? dateOfBirth = null;
                DateTime? qualificationYear = null;
                if (IsPicked_dtpDateOfBirth)
                    dateOfBirth = dtpDateOfBirth.Value;
                if (IsPicked_dtpQualificationYear)
                    qualificationYear = dtpQualificationYear.Value;

                Country selectedCountry = (Country)cmbCountry.SelectedItem;
                int selectedCountryId = selectedCountry.Id;

                Governorate selectedGovernorate = (Governorate)cmbGovernorate.SelectedItem;
                int selectedGovernorateId = selectedCountry.Id;

                City selectedCity = (City)cmbCity.SelectedItem;
                int selectedCityId = selectedCity.Id;

                Country selectedCountryP = (Country)cmbParentCountry.SelectedItem;
                int selectedCountryIdP = selectedCountry.Id;

                Governorate selectedGovernorateP = (Governorate)cmbParentGovernorate.SelectedItem;
                int selectedGovernorateIdP = selectedCountry.Id;

                City selectedCityP = (City)cmbParentCity.SelectedItem;
                int selectedCityIdP = selectedCity.Id;

                Gender? selectedGenderEnum = null;
                if (cmbGender.SelectedIndex != -1)
                {
                    var selectedGenderName = cmbGender.SelectedItem.ToString();
                    if (Enum.TryParse(selectedGenderName, out Gender gender))
                    {
                        selectedGenderEnum = gender;
                        // Now 'selectedGenderEnum' contains the selected enum value
                        // You can use it as needed
                    }
                    else
                    {
                        // Handle the case where parsing fails
                    }
                }
                else
                {
                    // Handle the case where no item is selected
                }

                Nationality? selectedNationality = null;
                if(cmbNationality.SelectedIndex != -1)
                {
                    var selectedNationalityName = cmbNationality.SelectedItem.ToString();
                    if (Enum.TryParse(selectedNationalityName, out Nationality nationality))
                    {
                        selectedNationality = nationality;
                        // Now 'selectedGenderEnum' contains the selected enum value
                        // You can use it as needed
                    }
                    else
                    {
                        // Handle the case where parsing fails
                    }
                }

                Religion? selectedReligion = null;
                if(cmbReligion.SelectedIndex != -1)
                {
                    var selectedReligionName = cmbReligion.SelectedItem.ToString();
                    if (Enum.TryParse(selectedReligionName, out Religion religion))
                    {
                        selectedReligion = religion;
                        // Now 'selectedGenderEnum' contains the selected enum value
                        // You can use it as needed
                    }
                    else
                    {
                        // Handle the case where parsing fails
                    }
                }

                List<Phone> phones = phonesList.Select(t => new Phone
                {
                    Id = t.id, // Assuming Id is assigned in the tuple
                    PhoneNumber = t.number,
                    Type = t.type
                }).ToList();

                Student student = new Student
                {
                    NameArabic = txtNameArabic.Text,
                    NameEnglish = txtNameEnglish.Text,
                    NationalID = txtNationalID.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    ConfirmPasswor = txtPassword.Text,
                    PlaceOfBirth = txtPlaceOfBirth.Text,
                    Gender = (Gender)selectedGenderEnum,
                    StudentCode = txtStudentCode.Text,
                    Nationality = (Nationality)selectedNationality,
                    Religion = (Religion)selectedReligion,
                    ReleasePlace = txtReleasePlace.Text,
                    DateOfBirth = dateOfBirth,
                    CountryId = selectedCountryId,
                    GovernorateId = selectedGovernorateId,
                    CityId = selectedCityId,
                    Street = txtStreet.Text,
                    PostalCode = txtPostalCode.Text,
                    PreQualification = txtPreQualification.Text,
                    SeatNumber = int.Parse(txtSeatNumber.Text),
                    QualificationYear = qualificationYear,
                    Degree = (decimal?)double.Parse(txtDegree.Text),
                    ParentName = txtParentName.Text,
                    ParentJob = txtParentJob.Text,
                    ParentCountryId = selectedCountryIdP,
                    ParentGovernorateId = selectedGovernorateIdP,
                    ParentCityId = selectedCityIdP,
                    ParentStreet = txtParentStreet.Text,
                    PostalCodeOfParent = txtPostalCodeOfParent.Text,
                    Phones = phones
                };

                var result = await _studentService.AddStudent(student);
                if (result > 0)
                    MessageBox.Show("Student added successfully successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            IsPicked_dtpDateOfBirth = true;
        }

        private void dtpQualificationYear_ValueChanged(object sender, EventArgs e)
        {
            IsPicked_dtpQualificationYear = true;
        }

        private async void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventHandlerManager.SetEventHandlerEnabled(cmbGovernorate, "SelectedIndexChanged", cmbGovernorate_SelectedIndexChanged, false);

            Country selectedCountry = (Country)cmbCountry.SelectedItem;
            int selectedCountryId = selectedCountry.Id;

            List<Governorate> governorates = await _locationService.GetGovernoratesByCountryIdAsync(selectedCountryId);
            cmbGovernorate.DataSource = null;
            cmbCity.DataSource = null;
            cmbGovernorate.DisplayMember = "Name";
            cmbGovernorate.ValueMember = "Id";
            cmbGovernorate.DataSource = governorates;
            cmbGovernorate.SelectedIndex = -1;

            EventHandlerManager.SetEventHandlerEnabled(cmbGovernorate, "SelectedIndexChanged", cmbGovernorate_SelectedIndexChanged, true);
        }

        private async void cmbGovernorate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Governorate selectedCountry = (Governorate)cmbGovernorate.SelectedItem;
            int selectedCountryId = selectedCountry.Id;

            List<City> cities = await _locationService.GetCitiesByGovernorateIdAsync(selectedCountryId);
            cmbCity.DataSource = null;
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";
            cmbCity.DataSource = cities;
            cmbCity.SelectedIndex = -1;
        }

        private async void cmbParentCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventHandlerManager.SetEventHandlerEnabled(cmbParentGovernorate, "SelectedIndexChanged", cmbParentGovernorate_SelectedIndexChanged, false);

            Country selectedCountry = (Country)cmbParentCountry.SelectedItem;
            int selectedCountryId = selectedCountry.Id;

            List<Governorate> governorates = await _locationService.GetGovernoratesByCountryIdAsync(selectedCountryId);
            cmbParentGovernorate.DataSource = null;
            cmbParentCity.DataSource = null;
            cmbParentGovernorate.DisplayMember = "Name";
            cmbParentGovernorate.ValueMember = "Id";
            cmbParentGovernorate.DataSource = governorates;
            cmbParentGovernorate.SelectedIndex = -1;

            EventHandlerManager.SetEventHandlerEnabled(cmbParentGovernorate, "SelectedIndexChanged", cmbParentGovernorate_SelectedIndexChanged, true);
        }

        private async void cmbParentGovernorate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Governorate selectedCountry = (Governorate)cmbParentGovernorate.SelectedItem;
            int selectedCountryId = selectedCountry.Id;

            List<City> cities = await _locationService.GetCitiesByGovernorateIdAsync(selectedCountryId);
            cmbParentCity.DataSource = null;
            cmbParentCity.DisplayMember = "Name";
            cmbParentCity.ValueMember = "Id";
            cmbParentCity.DataSource = cities;
            cmbParentCity.SelectedIndex = -1;
        }
    }

    public class EventHandlerManager
    {
        public static void SetEventHandlerEnabled(Control control, string eventName, EventHandler eventHandler, bool isEnabled)
        {
            if (control == null || string.IsNullOrEmpty(eventName) || eventHandler == null)
                return;

            var eventInfo = control.GetType().GetEvent(eventName);
            if (eventInfo == null)
                return;

            if (isEnabled)
            {
                eventInfo.AddEventHandler(control, eventHandler);
            }
            else
            {
                eventInfo.RemoveEventHandler(control, eventHandler);
            }
        }
    }
}
