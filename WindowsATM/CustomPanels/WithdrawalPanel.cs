using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsATM.CustomPanels
{
    class WithdrawalPanel : ATMPanel
    {
        protected static TextBox amountEntryBox;
        protected static Label withdrawalLabel;
        protected static Label netCashLabel;
        public WithdrawalPanel()
        {
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(109, 57);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(351, 194);
            this.TabIndex = 12;

            withdrawalLabel = new Label();
            withdrawalLabel.Text = "WITHDRAWAL";
            withdrawalLabel.SetBounds(((this.Width / 2) - 40), (this.Height / 2), 100, 30);
            this.Controls.Add(withdrawalLabel);

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
                //compare to the current funds available and what the ATM currently has available
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
