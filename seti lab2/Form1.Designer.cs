namespace seti_lab2
{
    partial class Form1
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
            this.buttonInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputAdress = new System.Windows.Forms.TextBox();
            this.labelWideAdress = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelNumberOfNodes = new System.Windows.Forms.Label();
            this.labelNetworkMask = new System.Windows.Forms.Label();
            this.textBoxInputPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(227, 58);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "Ввод";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ввод";
            // 
            // textBoxInputAdress
            // 
            this.textBoxInputAdress.Location = new System.Drawing.Point(12, 58);
            this.textBoxInputAdress.Name = "textBoxInputAdress";
            this.textBoxInputAdress.Size = new System.Drawing.Size(157, 23);
            this.textBoxInputAdress.TabIndex = 2;
            this.textBoxInputAdress.Text = "192.168.137.1";
            // 
            // labelWideAdress
            // 
            this.labelWideAdress.AutoSize = true;
            this.labelWideAdress.Location = new System.Drawing.Point(200, 99);
            this.labelWideAdress.Name = "labelWideAdress";
            this.labelWideAdress.Size = new System.Drawing.Size(0, 15);
            this.labelWideAdress.TabIndex = 3;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(76, 130);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(10, 15);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = " ";
            // 
            // labelNumberOfNodes
            // 
            this.labelNumberOfNodes.AutoSize = true;
            this.labelNumberOfNodes.Location = new System.Drawing.Point(121, 156);
            this.labelNumberOfNodes.Name = "labelNumberOfNodes";
            this.labelNumberOfNodes.Size = new System.Drawing.Size(0, 15);
            this.labelNumberOfNodes.TabIndex = 5;
            // 
            // labelNetworkMask
            // 
            this.labelNetworkMask.AutoSize = true;
            this.labelNetworkMask.Location = new System.Drawing.Point(76, 182);
            this.labelNetworkMask.Name = "labelNetworkMask";
            this.labelNetworkMask.Size = new System.Drawing.Size(0, 15);
            this.labelNetworkMask.TabIndex = 6;
            // 
            // textBoxInputPrefix
            // 
            this.textBoxInputPrefix.Location = new System.Drawing.Point(175, 59);
            this.textBoxInputPrefix.Name = "textBoxInputPrefix";
            this.textBoxInputPrefix.Size = new System.Drawing.Size(46, 23);
            this.textBoxInputPrefix.TabIndex = 7;
            this.textBoxInputPrefix.Text = "24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "широко вещательный адесс сети:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = " адесс сети:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "колличество узлов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "маска сети:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInputPrefix);
            this.Controls.Add(this.labelNetworkMask);
            this.Controls.Add(this.labelNumberOfNodes);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelWideAdress);
            this.Controls.Add(this.textBoxInputAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInput);
            this.Name = "Form1";
            this.Text = "Ip calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonInput;
        private Label label1;
        private TextBox textBoxInputAdress;
        private Label labelWideAdress;
        private Label labelAdress;
        private Label labelNumberOfNodes;
        private Label labelNetworkMask;
        private TextBox textBoxInputPrefix;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}