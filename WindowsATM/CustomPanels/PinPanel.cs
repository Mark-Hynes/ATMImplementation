using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsATM.Interfaces;

namespace WindowsATM.CustomPanels
{
    class PinPanel : ATMPanel
    {
        protected static TextBox pinEntryBox;
        protected static Label netCashLabel;
        public PinPanel()
        {
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(109, 57);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(351, 194);
            this.TabIndex = 12;


            pinEntryBox = new System.Windows.Forms.TextBox();
            pinEntryBox.Name = "ENTER PIN";
            pinEntryBox.Text = "";
            pinEntryBox.SetBounds(((this.Width / 2) - 50), this.Height / 2, 100, 40);
            this.Controls.Add(pinEntryBox);
           
             netCashLabel = new Label();
            netCashLabel.Text = "NET-CASH";
            netCashLabel.SetBounds(((this.Width / 2) - 30), ((this.Height / 2)-30), 100, 40);
            this.Controls.Add(netCashLabel);
        }


        //METHOD ONLY APPLIES TO FUNCTION BUTTONS -- WILL BE REFACTORED/REMOVED TO IMPLEMENT COMMAND
        public void buttonInput(System.Windows.Forms.Button b)
        {
            if (b.Text == "Clear")
            {
                pinEntryBox.Text = "";
                pinEntryBox.Update();
            }
            else if (b.Text == "Cancel")
            {
                pinEntryBox.Text = "";
                pinEntryBox.Update();
            }
            else if (b.Text == "Enter")
            {
                if (pinEntryBox.Text.Length < 4 || pinEntryBox.Text.Length > 4) { netCashLabel.Text = "Pin not correctly entered"; netCashLabel.Update(); }
                else pinEntryBox.Text = "PIN ENTERED";
                pinEntryBox.Update();
            }
           
        }

        //PART OF OBSERVER DESIGN PATTERN -- SUBJECT PASSES ITSELF AS PARAMETER TO GET TEXT FROM AND UPDATES

        public override void update(Subject e)
        {
            ATMButton b = (ATMButton)e;
            pinEntryBox.Text += b.Text;
            pinEntryBox.Update();
        }

        public override void cancel()
        {
            pinEntryBox.Clear();
            pinEntryBox.Update();
        }
        public override void clear()
        {
            pinEntryBox.Clear();
            pinEntryBox.Update();
        }
        public override void enter()
        {
            Debug.WriteLine("Enter button clicked while on PinPanel");
        }

    }
}
