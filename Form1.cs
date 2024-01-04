using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//cj george
//11/26/23
//11-1
namespace _11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //initialize initial set up (everything missing but two radio buttons) + the radio button
            //event handlers to check if its checked status has changed
            InitializeComponent();
            InitHideAll();
            this.radBtnProWorker.CheckedChanged += new System.EventHandler(this.EmployeeType_CheckedChanged);
            this.radBtnShiftSup.CheckedChanged += new System.EventHandler(this.EmployeeType_CheckedChanged);
           
        }

        //function that chooses whats rendered on the inital start up
        //everything is hidden except the radio buttons
        private void InitHideAll()
        {
            lblAnnualBonus.Visible = false;
            lblAnnualSalary.Visible = false;
            lblEmployeeName.Visible = false;
            lblEmployeeNum.Visible = false;
            lblHourlyRate.Visible = false;
            lblShiftNum.Visible = false;
            lblShiftNumInstruction.Visible = false;

            txtBoxAnnualBonus.Visible = false;
            txtBoxAnnualSalary.Visible = false;
            txtBoxEmpName.Visible = false;
            txtBoxEmpNum.Visible = false;
            txtBoxRate.Visible = false;
            txtBoxShiftNum.Visible = false;
            
        }

        //function for the event handlers that changes whats displayed
        //according to what radio button is checked
        private void EmployeeType_CheckedChanged(object sender, EventArgs e)
        {
            //if the prod worker is checked,
            //only fields pertaining to that class are visible
            if (radBtnProWorker.Checked)
            {
                lblShiftNum.Visible = true;
                lblShiftNumInstruction.Visible = true;
                txtBoxShiftNum.Visible = true;

                lblHourlyRate.Visible = true;
                txtBoxRate.Visible = true;

                lblEmployeeNum.Visible = true;
                txtBoxEmpNum.Visible = true;

                lblEmployeeName.Visible = true;
                txtBoxEmpName.Visible = true;

                txtBoxAnnualSalary.Visible = false;
                lblAnnualSalary.Visible = false; 
                txtBoxAnnualBonus.Visible = false;
                lblAnnualBonus.Visible = false;
            }

            //otherwise if the shift sup button is clicked, the fields for that class are visible instead
            else if (radBtnShiftSup.Checked)
            {
                lblShiftNum.Visible = true;
                lblShiftNumInstruction.Visible = true;
                txtBoxShiftNum.Visible = true;

                lblHourlyRate.Visible = false;
                txtBoxRate.Visible = false;

                lblEmployeeNum.Visible = true;
                txtBoxEmpNum.Visible = true;

                lblEmployeeName.Visible = true;
                txtBoxEmpName.Visible = true;

                txtBoxAnnualSalary.Visible = true;
                lblAnnualSalary.Visible = true;
                txtBoxAnnualBonus.Visible = true;
                lblAnnualBonus.Visible = true;
            }
        }


        //closes application when button clicked
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //clears all txtboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxEmpName.Clear();
            txtBoxEmpNum.Clear();
            txtBoxRate.Clear();
            txtBoxShiftNum.Clear();
            txtBoxAnnualBonus.Clear();
            txtBoxAnnualSalary.Clear();
        }

        //when submit btn is clicked...
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name;
            int empNum;
            int shift;

            // common fields for both prod workers and shift sups
            name = txtBoxEmpName.Text;

            //try to parse the employee num and shift num (checks to make sure its int)
            if (!int.TryParse(txtBoxEmpNum.Text, out empNum))
            {
                MessageBox.Show("Invalid Employee Number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBoxShiftNum.Text, out shift))
            {
                MessageBox.Show("Invalid Shift Number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // if-else clause to display first, second, third, unknown
            string shiftInfo;
            if (shift == 1)
            {
                shiftInfo = "First";
            }
            else if (shift == 2)
            {
                shiftInfo = "Second";
            }
            else if (shift == 3)
            {
                shiftInfo = "Third";
            }
            else
            {
                shiftInfo = "Unknown";
            }

            //if prod worker button is checked...

            if (radBtnProWorker.Checked)
            {
                //try to parse hourly rate
                if (!decimal.TryParse(txtBoxRate.Text, out decimal rate))
                {
                    MessageBox.Show("Invalid Hourly Rate!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //create instance of prod worker
                ProductionWorker w = new ProductionWorker(name, empNum, shift, rate);

                //format output + display messagebox
                string infoFormat = $"Name: {w.Name}\nNumber: {w.EmpNum}\nShift: {shiftInfo}\nHourly Rate: {w.HourlyRate:C}";
                MessageBox.Show(infoFormat, "Production Worker Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //otherwise if shift sup is checked..
            else if (radBtnShiftSup.Checked)
            {
                //parse annual slary and bonus
                if (!decimal.TryParse(txtBoxAnnualSalary.Text, out decimal annualSalary))
                {
                    MessageBox.Show("Invalid Annual Salary!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtBoxAnnualBonus.Text, out decimal annualBonus))
                {
                    MessageBox.Show("Invalid Annual Bonus!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //create shift sup instance 
                ShiftSupervisor supervisor = new ShiftSupervisor(name, empNum, annualSalary, annualBonus);
                //format and display
                string infoFormat = $"Name: {supervisor.Name}\nNumber: {supervisor.EmpNum}\nShift: {shiftInfo}\nAnnual Salary: {supervisor.AnnualSalary:C}\nAnnual Bonus: {supervisor.AnnualBonus:C}";
                MessageBox.Show(infoFormat, "Shift Supervisor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
