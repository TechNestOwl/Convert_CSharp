namespace Convert
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            convertBtn = new Button();
            exitBtn = new Button();
            fahrLbl = new Label();
            celciusLbl = new Label();
            fahrToCelRadio = new RadioButton();
            celToFahrRadio = new RadioButton();
            celTxtBox = new TextBox();
            fahrTxtBox = new TextBox();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // convertBtn
            // 
            convertBtn.BackColor = SystemColors.MenuHighlight;
            convertBtn.Location = new Point(103, 389);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(83, 25);
            convertBtn.TabIndex = 0;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = false;
            convertBtn.Click += button1_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Orange;
            exitBtn.Location = new Point(483, 389);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(83, 25);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += button2_Click;
            // 
            // fahrLbl
            // 
            fahrLbl.AutoSize = true;
            fahrLbl.Location = new Point(374, 115);
            fahrLbl.Name = "fahrLbl";
            fahrLbl.Size = new Size(72, 17);
            fahrLbl.TabIndex = 2;
            fahrLbl.Text = "Fahrenhetit";
            fahrLbl.Click += label1_Click;
            // 
            // celciusLbl
            // 
            celciusLbl.AutoSize = true;
            celciusLbl.Location = new Point(374, 190);
            celciusLbl.Name = "celciusLbl";
            celciusLbl.Size = new Size(48, 17);
            celciusLbl.TabIndex = 3;
            celciusLbl.Text = "Celsius";
            // 
            // fahrToCelRadio
            // 
            fahrToCelRadio.AutoSize = true;
            fahrToCelRadio.Location = new Point(103, 115);
            fahrToCelRadio.Name = "fahrToCelRadio";
            fahrToCelRadio.Size = new Size(146, 21);
            fahrToCelRadio.TabIndex = 4;
            fahrToCelRadio.TabStop = true;
            fahrToCelRadio.Text = "Fahrenheit to Celsius";
            fahrToCelRadio.UseVisualStyleBackColor = true;
            fahrToCelRadio.CheckedChanged += fahrToCelRadio_CheckedChanged;
            // 
            // celToFahrRadio
            // 
            celToFahrRadio.AutoSize = true;
            celToFahrRadio.Location = new Point(103, 188);
            celToFahrRadio.Name = "celToFahrRadio";
            celToFahrRadio.Size = new Size(146, 21);
            celToFahrRadio.TabIndex = 5;
            celToFahrRadio.TabStop = true;
            celToFahrRadio.Text = "Celsius to Fahrenheit";
            celToFahrRadio.UseVisualStyleBackColor = true;
            celToFahrRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // celTxtBox
            // 
            celTxtBox.Location = new Point(467, 182);
            celTxtBox.Name = "celTxtBox";
            celTxtBox.Size = new Size(110, 25);
            celTxtBox.TabIndex = 6;
            celTxtBox.TextChanged += celTxtBox_TextChanged;
            // 
            // fahrTxtBox
            // 
            fahrTxtBox.Location = new Point(467, 112);
            fahrTxtBox.Name = "fahrTxtBox";
            fahrTxtBox.Size = new Size(110, 25);
            fahrTxtBox.TabIndex = 7;
            fahrTxtBox.TextChanged += fahrTxtBox_TextChanged;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.GradientInactiveCaption;
            clearBtn.Location = new Point(285, 389);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 25);
            clearBtn.TabIndex = 8;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            Controls.Add(clearBtn);
            Controls.Add(fahrTxtBox);
            Controls.Add(celTxtBox);
            Controls.Add(celToFahrRadio);
            Controls.Add(fahrToCelRadio);
            Controls.Add(celciusLbl);
            Controls.Add(fahrLbl);
            Controls.Add(exitBtn);
            Controls.Add(convertBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertBtn;
        private Button exitBtn;
        private Label fahrLbl;
        private Label celciusLbl;
        private RadioButton fahrToCelRadio;
        private RadioButton celToFahrRadio;
        private TextBox celTxtBox;
        private TextBox fahrTxtBox;
        private Button clearBtn;
    }
}
