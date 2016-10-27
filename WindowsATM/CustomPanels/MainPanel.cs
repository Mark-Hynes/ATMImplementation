﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsATM.CustomPanels
{
    class MainPanel : ATMPanel
    {
        protected static Label netCashLabel;
        protected static Label withdrawalLabel;
        protected static Label depositLabel;
        protected static Label balanceLabel;
        protected static Label pinResetLabel;
        protected static Label printReceiptLabel;
        protected static Label exitLabel;
        public MainPanel()
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

            withdrawalLabel = new Label();
            withdrawalLabel.Text = "1 : WITHDRAWAL";
            withdrawalLabel.SetBounds(0 , (this.Height / 2), 100, 40);
            this.Controls.Add(withdrawalLabel);

            depositLabel = new Label();
            depositLabel.Text = "3 : DEPOSIT";
            depositLabel.SetBounds(0, ((this.Height / 2) + 40), 100, 40);
            this.Controls.Add(depositLabel);

            printReceiptLabel = new Label();
            printReceiptLabel.Text = "5 : PRINT RECEIPT";
            printReceiptLabel.SetBounds(0, ((this.Height / 2) + 80), 150, 40);
            this.Controls.Add(printReceiptLabel);

            balanceLabel = new Label();
            balanceLabel.Text = "BALANCE : 2";            
            balanceLabel.SetBounds((this.Width - 73), (this.Height / 2), 100, 40);
            this.Controls.Add(balanceLabel);

            pinResetLabel = new Label();
            pinResetLabel.Text = "PIN RESET : 4";
            pinResetLabel.SetBounds((this.Width - 80), ((this.Height / 2) + 40), 100, 40);
            this.Controls.Add(pinResetLabel);

            exitLabel = new Label();
            exitLabel.Text = "EXIT : 6";
            exitLabel.SetBounds((this.Width - 47), ((this.Height / 2) + 80), 100, 40);
            this.Controls.Add(exitLabel);


        }

        public void buttonInput(System.Windows.Forms.Button b)
        {
           if (b.Text == "1")
            {
                //Change to withdrawalLabel Panel
            }
            else if (b.Text == "2")
            {
                //Change to balanceLabel Panel
            }
            else if (b.Text == "3")
            {
                //Change to depositLabel Panel
            }
            else if (b.Text == "4")
            {
                //Change to Pin Reset Panel
            }
            else if (b.Text == "5")
            {
                //print receipt
            }
            else if (b.Text == "6")
            {
                //exitLabel
            }
        }

    }
}
