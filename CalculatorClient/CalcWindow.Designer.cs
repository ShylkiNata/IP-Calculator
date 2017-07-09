namespace CalculatorClient
{
    partial class CalcWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcWindow));
            this.calculateButton = new System.Windows.Forms.Button();
            this.ipField = new System.Windows.Forms.TextBox();
            this.maskField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bcastIP = new System.Windows.Forms.TextBox();
            this.nodesNumber = new System.Windows.Forms.TextBox();
            this.lastIP = new System.Windows.Forms.TextBox();
            this.firstIP = new System.Windows.Forms.TextBox();
            this.network = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.calculateButton.Location = new System.Drawing.Point(230, 17);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 27);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ipField
            // 
            this.ipField.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipField.Location = new System.Drawing.Point(12, 20);
            this.ipField.Name = "ipField";
            this.ipField.Size = new System.Drawing.Size(131, 23);
            this.ipField.TabIndex = 1;
            this.ipField.Text = "IP address";
            this.ipField.Click += new System.EventHandler(this.ipField_GotFocus);
            // 
            // maskField
            // 
            this.maskField.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskField.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.maskField.Location = new System.Drawing.Point(150, 20);
            this.maskField.Name = "maskField";
            this.maskField.Size = new System.Drawing.Size(58, 23);
            this.maskField.TabIndex = 2;
            this.maskField.Text = "mask";
            this.maskField.Click += new System.EventHandler(this.maskField_GotFocus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bcastIP);
            this.panel1.Controls.Add(this.nodesNumber);
            this.panel1.Controls.Add(this.lastIP);
            this.panel1.Controls.Add(this.firstIP);
            this.panel1.Controls.Add(this.network);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 172);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "amount of nodes......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "broadcast IP address.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "last IP address......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "first IP address.....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "network..............";
            // 
            // bcastIP
            // 
            this.bcastIP.Enabled = false;
            this.bcastIP.Location = new System.Drawing.Point(167, 105);
            this.bcastIP.Name = "bcastIP";
            this.bcastIP.Size = new System.Drawing.Size(119, 23);
            this.bcastIP.TabIndex = 4;
            // 
            // nodesNumber
            // 
            this.nodesNumber.Enabled = false;
            this.nodesNumber.Location = new System.Drawing.Point(167, 136);
            this.nodesNumber.Name = "nodesNumber";
            this.nodesNumber.Size = new System.Drawing.Size(119, 23);
            this.nodesNumber.TabIndex = 3;
            // 
            // lastIP
            // 
            this.lastIP.Enabled = false;
            this.lastIP.Location = new System.Drawing.Point(167, 74);
            this.lastIP.Name = "lastIP";
            this.lastIP.Size = new System.Drawing.Size(119, 23);
            this.lastIP.TabIndex = 2;
            // 
            // firstIP
            // 
            this.firstIP.Enabled = false;
            this.firstIP.Location = new System.Drawing.Point(167, 43);
            this.firstIP.Name = "firstIP";
            this.firstIP.Size = new System.Drawing.Size(119, 23);
            this.firstIP.TabIndex = 1;
            // 
            // network
            // 
            this.network.Enabled = false;
            this.network.Location = new System.Drawing.Point(167, 12);
            this.network.Name = "network";
            this.network.ReadOnly = true;
            this.network.Size = new System.Drawing.Size(119, 23);
            this.network.TabIndex = 0;
            // 
            // CalcWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(328, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskField);
            this.Controls.Add(this.ipField);
            this.Controls.Add(this.calculateButton);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox ipField;
        private System.Windows.Forms.TextBox maskField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bcastIP;
        private System.Windows.Forms.TextBox nodesNumber;
        private System.Windows.Forms.TextBox lastIP;
        private System.Windows.Forms.TextBox firstIP;
        private System.Windows.Forms.TextBox network;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

