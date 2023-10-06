namespace Anket_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbSpeciality.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = txtBoxName.Text,
                Surname = txtBoxSurname.Text,
                Speciality = cmbSpeciality.SelectedItem.ToString(),
                Age = DateTime.Now.Year - dtpBirtDate.Value.Year,
                EntryDate = dtpEntryDate.Value,
                NativeLanguage = rbAzerbaijan.Checked ? rbAzerbaijan.Text : rbEnglish.Text
            };

            if (user != null) { FileHelper.WriteJson(user); }

            MessageBox.Show($"Data added {user?.Name}.json", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearComponents();
        }

        private void ClearComponents()
        {
            txtBoxName.Clear();
            txtBoxSurname.Clear();
            cmbSpeciality.SelectedIndex = 0;
            dtpBirtDate.Value = DateTime.Now;
            dtpEntryDate.Value = DateTime.Now;
            rbAzerbaijan.Checked = true;
            rbEnglish.Checked = false;
        }
        
    }
}