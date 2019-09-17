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
        private List<PeopleModel> availableTeamMembers = GlobalConfig.Connection.GetPeople_All();
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
            selectTeamMemberComboBox.DataSource = null; 
            selectTeamMemberComboBox.DataSource = availableTeamMembers;
            selectTeamMemberComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
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

                personModel = GlobalConfig.Connection.CreatePeople(personModel);

                selectedTeamMembers.Add(personModel);
                WireUpList();


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

        private void AdddTeamMemberButton_Click(object sender, EventArgs e)
        {
            PeopleModel p =(PeopleModel)selectTeamMemberComboBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                selectTeamMemberComboBox.Refresh();
                teamMembersListBox.Refresh();

                WireUpList(); 
            }

          
        }

        private void DeleteSelectedMembersButton_Click(object sender, EventArgs e)
        {

            PeopleModel p = (PeopleModel)teamMembersListBox.SelectedItem;

            if (p != null )
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);

                selectTeamMemberComboBox.Refresh();
                teamMembersListBox.Refresh();

                WireUpList();  
            }

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameTextBoxOne.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            //TODO - if we arent closing this form after creation, reset the form.
        }
    }
}
