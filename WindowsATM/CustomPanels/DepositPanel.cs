using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsATM.CustomPanels
{
    class DepositPanel : ATMPanel
    {
        protected static TextBox amountEntryBox;
        protected static Label depositLabel;
        protected static Label netCashLabel;
        public DepositPanel()
        {
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(109, 57);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(351, 194);
            this.TabIndex = 12;

            depositLabel = new Label();
            depositLabel.Text = "DEPOSIT";
            depositLabel.SetBounds(((this.Width / 2) - 25), (this.Height / 2), 100, 30);
            this.Controls.Add(depositLabel);

            amountEntryBox = new System.Windows.Forms.TextBox();
            amountEntryBox.Name = "ENTER AMOUNT";
            amountEntryBox.Text = "";
            amountEntryBox.SetBounds(((this.Width / 2) - 50), (this.Height / 2 + 30), 100, 40);
            this.Controls.Add(amountEntryBox);

            netCashLabel = new Label();
            netCashLabel.Text = "NET-CASH";
            netCashLabel.SetBounds(((this.Width / 2) - 30), ((this.Height / 2) - 30), 100, 40);
            this.Controls.Add(netCashLabel);
        }

        public void buttonInput(System.Windows.Forms.Button b)
        {
            if (b.Text == "Clear")
            {
                amountEntryBox.Text = "";
                amountEntryBox.Update();
            }
            else if (b.Text == "Cancel")
            {
                amountEntryBox.Text = "";
                amountEntryBox.Update();
            }
            else if (b.Text == "Enter")
            {
                //add to current funds in database
            }
            else
            {
                string additionalNumber = b.Text;
                amountEntryBox.Text += additionalNumber;
                amountEntryBox.Update();
            }
        }

    }
}
