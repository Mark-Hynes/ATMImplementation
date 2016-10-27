using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsATM.CustomPanels
{
    class PinResetPanel : ATMPanel
    {
        protected static TextBox pinEntryBox;
        protected static Label pinResetLabel;
        protected static Label netCashLabel;
        public PinResetPanel()
        {
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(109, 57);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(351, 194);
            this.TabIndex = 12;

            pinResetLabel = new Label();
            pinResetLabel.Text = "ENTER NEW PIN";
            pinResetLabel.SetBounds(((this.Width / 2) - 45), (this.Height / 2), 120, 40);
            this.Controls.Add(pinResetLabel);

            pinEntryBox = new System.Windows.Forms.TextBox();
            pinEntryBox.Name = "ENTER PIN";
            pinEntryBox.Text = "";
            pinEntryBox.SetBounds(((this.Width / 2) - 50), ((this.Height / 2) + 40), 100, 40);
            this.Controls.Add(pinEntryBox);

            netCashLabel = new Label();
            netCashLabel.Text = "NET-CASH";
            netCashLabel.SetBounds(((this.Width / 2) - 30), ((this.Height / 2) - 30), 100, 40);
            this.Controls.Add(netCashLabel);
        }

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
            else
            {
                string additionalNumber = b.Text;
                pinEntryBox.Text += additionalNumber;
                pinEntryBox.Update();
            }
        }

    }
}
