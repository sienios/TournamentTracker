using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PeopleModel> availableTeamMembers = new List<PeopleModel>();
        private List<PeopleModel> selectedTeamMembers = new List<PeopleModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
         //   CreateSampleData();
            WireUpList();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PeopleModel { FirstName = "Tst", LastName = "testfds" });

            selectedTeamMembers.Add(new PeopleModel { FirstName = "dwa", LastName = "dwa" });
        }


        private void WireUpList()
        {
            selectTeamMemberComboBox.DataSource = availableTeamMembers;
            selectTeamMemberComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PeopleModel personModel = new PeopleModel();
                personModel.FirstName = firstNameTextBoxOne.Text;
                personModel.LastName = lastNameTextBox.Text;
                personModel.EmailAddress = emailTextBox.Text;
                personModel.Phone = phoneTextBox.Text;

                GlobalConfig.Connection.CreatePeople(personModel);

                firstNameTextBoxOne.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Incorect data");
            }

        }

        private bool ValidateForm()
        {
            if(firstNameTextBoxOne.Text.Length ==0)
            {
                return false;
            }

            if(lastNameTextBox.Text.Length ==0)
            {
                return false;

            }

            if(emailTextBox.Text.Length ==0)
            {
                return false;
            }

            if (phoneTextBox.Text.Length==0)
            {
                return false;
            }





            return true;
        }
    }
}
