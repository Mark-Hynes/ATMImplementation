using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsATM.CustomPanels
{
    class BalancePanel : ATMPanel
    {
        protected static Label netCashLabel;
        protected static Label balanceLabel;
        protected static Label currentBalance;
        public BalancePanel()
        {
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(109, 57);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(351, 194);
            this.TabIndex = 12;
            
            netCashLabel = new Label();
            netCashLabel.Text = "NET-CASH";
            netCashLabel.SetBounds(((this.Width / 2) - 30), ((this.Height / 2) - 30), 100, 40);
            this.Controls.Add(netCashLabel);

            balanceLabel = new Label();
            balanceLabel.Text = "CURRENT BALANCE";
            balanceLabel.SetBounds(((this.Width / 2) - 50), (this.Height / 2 + 10), 150, 40);
            this.Controls.Add(balanceLabel);

            currentBalance = new Label();
            currentBalance.Text = "€ XXXXXX.XX";//Check database
            currentBalance.SetBounds(((this.Width / 2) - 30), (this.Height / 2 + 50), 100, 40);
            this.Controls.Add(currentBalance);
        }

        public void buttonInput(System.Windows.Forms.Button b)
        {
            if (b.Text == "Clear")
            {
            }
            else if (b.Text == "Cancel")
            {
            }
            else if (b.Text == "Enter")
            {
            }
            else
            {
            }
        }

    }
}
