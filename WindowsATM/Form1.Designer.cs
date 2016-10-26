using System;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsATM.CustomPanels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsATM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonFactory bf = new ButtonFactory();
            this.button1 = bf.getButton("1");
            this.button2 = bf.getButton("2");
            this.button3 = bf.getButton("3");
            this.button4 = bf.getButton("4");
            this.button5 = bf.getButton("5");
            this.button6 = bf.getButton("6");
            this.button7 = bf.getButton("7");
            this.button8 = bf.getButton("8");
            this.button9 = bf.getButton("9");
            this.button13 = bf.getButton("0");
            this.button10 = bf.getButton("Cancel");
            this.button11 = bf.getButton("Clear");
            this.button12 = bf.getButton("Enter");
            this.currentPanel = new PinPanel();
           
            this.SuspendLayout();
         
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
      
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
           
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 

           
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
          
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
           
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            //


            //

            //PinNumberTextBox
            //



            //



            // 
            // button13
            // 
            
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 481);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.currentPanel);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "NetCash ATM";
            this.ResumeLayout(false);

        }

        private void button_Click(object sender, EventArgs e)
        {
            currentPanel.buttonInput((System.Windows.Forms.Button)sender);
        }

        #endregion

        private ATMButton button1;
        private ATMButton button2;
        private ATMButton button3;
        private ATMButton button4;
        private ATMButton button5;
        private ATMButton button6;
        private ATMButton button7;
        private ATMButton button8;
        private ATMButton button9;
        private ATMButton button10;
        private ATMButton button11;
        private ATMButton button12;
        private PinPanel currentPanel;
        private ATMButton button13;
    
    }
}

