using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsATM.ConcreteCommands;
using WindowsATM.CustomPanels;
using WindowsATM.Helper_Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsATM
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

      
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ButtonFactory bf = new ButtonFactory();
            RegistrationHelper helperClass = new RegistrationHelper();
            this.currentPanel = new PinPanel();
            


            this.CancelButton = bf.getButton("Cancel");
            this.ClearButton = bf.getButton("Clear");
            this.EnterButton = bf.getButton("Enter");

            cancelCommand = new CancelCommand(currentPanel);
            clearCommand = new ClearCommand(currentPanel);
            enterCommand = new EnterCommand(currentPanel);

            this.keypadButtons = new List<ATMButton>();

            for (int i = 0; i < 10; i++)
            {
                this.keypadButtons.Add(bf.getButton(""+i));
                this.keypadButtons[i].Click += new System.EventHandler(this.button_Click);
                helperClass.registerObserverToSubject(this.currentPanel, this.keypadButtons[i]);
              
                this.Controls.Add(this.keypadButtons[i]);
            }
            this.SuspendLayout();
         

           //CANCEL BUTTON
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Button_Click);
            
          //CLEAR
            this.ClearButton.Click += new System.EventHandler(this.Clear_Button_Click);
            
            // ENTER         
            this.EnterButton.Click += new System.EventHandler(this.Enter_Button_Click);
           

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 481);
           
            this.Controls.Add(this.currentPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EnterButton);
           
            this.Name = "Form1";
            this.Text = "NetCash ATM";
            this.ResumeLayout(false);

           
        }

        //USED TO NOTIFY AN OBSERVER ONCE A SUBJECT HAS BEEN ACTED UPON
        private void button_Click(object sender, EventArgs e)
        {
            ATMButton b = (ATMButton)sender;
            b.notifyObservers();
         
        }
        private void Enter_Button_Click(object sender, EventArgs e)
        {
            ATMButton b = (ATMButton)sender;
            b.executeCommand(enterCommand);

        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            ATMButton b = (ATMButton)sender;
            b.executeCommand(clearCommand);

        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            ATMButton b = (ATMButton)sender;
            b.executeCommand(cancelCommand);

        }

        #endregion
        private List<ATMButton> keypadButtons;
        
        private ATMButton CancelButton;
        private ATMButton ClearButton;
        private ATMButton EnterButton;
        private  PinPanel currentPanel;
        CancelCommand cancelCommand;
        ClearCommand clearCommand;
        EnterCommand enterCommand;


    }
}

