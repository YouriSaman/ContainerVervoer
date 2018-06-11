namespace ContainerVervoer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSchipGewicht = new System.Windows.Forms.Button();
            this.upDownSchipGewicht = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteContainer = new System.Windows.Forms.Button();
            this.btnStartVerdeling = new System.Windows.Forms.Button();
            this.rBtnWaardevol = new System.Windows.Forms.RadioButton();
            this.rBtnGekoeld = new System.Windows.Forms.RadioButton();
            this.rBtnStandaard = new System.Windows.Forms.RadioButton();
            this.btnVoegContainerToe = new System.Windows.Forms.Button();
            this.upDownContainerGewicht = new System.Windows.Forms.NumericUpDown();
            this.lBContainers = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAantalContainers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBalans = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGewichtContainers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMinGewicht = new System.Windows.Forms.Label();
            this.lblMaxGewicht = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBContainer1 = new System.Windows.Forms.ListBox();
            this.lBContainer2 = new System.Windows.Forms.ListBox();
            this.lBContainer4 = new System.Windows.Forms.ListBox();
            this.lBContainer3 = new System.Windows.Forms.ListBox();
            this.lBContainer6 = new System.Windows.Forms.ListBox();
            this.lBContainer5 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSchipGewicht)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownContainerGewicht)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSchipGewicht);
            this.groupBox1.Controls.Add(this.upDownSchipGewicht);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ship";
            // 
            // btnSchipGewicht
            // 
            this.btnSchipGewicht.Location = new System.Drawing.Point(62, 60);
            this.btnSchipGewicht.Name = "btnSchipGewicht";
            this.btnSchipGewicht.Size = new System.Drawing.Size(75, 37);
            this.btnSchipGewicht.TabIndex = 2;
            this.btnSchipGewicht.Text = "Gewicht vastzeten!";
            this.btnSchipGewicht.UseVisualStyleBackColor = true;
            this.btnSchipGewicht.Click += new System.EventHandler(this.btnSchipGewicht_Click);
            // 
            // upDownSchipGewicht
            // 
            this.upDownSchipGewicht.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownSchipGewicht.Location = new System.Drawing.Point(10, 37);
            this.upDownSchipGewicht.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.upDownSchipGewicht.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.upDownSchipGewicht.Name = "upDownSchipGewicht";
            this.upDownSchipGewicht.Size = new System.Drawing.Size(184, 20);
            this.upDownSchipGewicht.TabIndex = 1;
            this.upDownSchipGewicht.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gewicht in kg:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteContainer);
            this.groupBox2.Controls.Add(this.btnStartVerdeling);
            this.groupBox2.Controls.Add(this.rBtnWaardevol);
            this.groupBox2.Controls.Add(this.rBtnGekoeld);
            this.groupBox2.Controls.Add(this.rBtnStandaard);
            this.groupBox2.Controls.Add(this.btnVoegContainerToe);
            this.groupBox2.Controls.Add(this.upDownContainerGewicht);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Container";
            // 
            // btnDeleteContainer
            // 
            this.btnDeleteContainer.Location = new System.Drawing.Point(108, 93);
            this.btnDeleteContainer.Name = "btnDeleteContainer";
            this.btnDeleteContainer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContainer.TabIndex = 8;
            this.btnDeleteContainer.Text = "Delete";
            this.btnDeleteContainer.UseVisualStyleBackColor = true;
            this.btnDeleteContainer.Click += new System.EventHandler(this.btnDeleteContainer_Click);
            // 
            // btnStartVerdeling
            // 
            this.btnStartVerdeling.Location = new System.Drawing.Point(53, 122);
            this.btnStartVerdeling.Name = "btnStartVerdeling";
            this.btnStartVerdeling.Size = new System.Drawing.Size(86, 23);
            this.btnStartVerdeling.TabIndex = 7;
            this.btnStartVerdeling.Text = "Start verdeling!";
            this.btnStartVerdeling.UseVisualStyleBackColor = true;
            this.btnStartVerdeling.Click += new System.EventHandler(this.btnStartVerdeling_Click);
            // 
            // rBtnWaardevol
            // 
            this.rBtnWaardevol.AutoSize = true;
            this.rBtnWaardevol.Location = new System.Drawing.Point(90, 73);
            this.rBtnWaardevol.Name = "rBtnWaardevol";
            this.rBtnWaardevol.Size = new System.Drawing.Size(77, 17);
            this.rBtnWaardevol.TabIndex = 6;
            this.rBtnWaardevol.TabStop = true;
            this.rBtnWaardevol.Text = "Waardevol";
            this.rBtnWaardevol.UseVisualStyleBackColor = true;
            // 
            // rBtnGekoeld
            // 
            this.rBtnGekoeld.AutoSize = true;
            this.rBtnGekoeld.Location = new System.Drawing.Point(90, 47);
            this.rBtnGekoeld.Name = "rBtnGekoeld";
            this.rBtnGekoeld.Size = new System.Drawing.Size(65, 17);
            this.rBtnGekoeld.TabIndex = 5;
            this.rBtnGekoeld.TabStop = true;
            this.rBtnGekoeld.Text = "Gekoeld";
            this.rBtnGekoeld.UseVisualStyleBackColor = true;
            // 
            // rBtnStandaard
            // 
            this.rBtnStandaard.AutoSize = true;
            this.rBtnStandaard.Checked = true;
            this.rBtnStandaard.Location = new System.Drawing.Point(10, 57);
            this.rBtnStandaard.Name = "rBtnStandaard";
            this.rBtnStandaard.Size = new System.Drawing.Size(74, 17);
            this.rBtnStandaard.TabIndex = 4;
            this.rBtnStandaard.TabStop = true;
            this.rBtnStandaard.Text = "Standaard";
            this.rBtnStandaard.UseVisualStyleBackColor = true;
            // 
            // btnVoegContainerToe
            // 
            this.btnVoegContainerToe.Enabled = false;
            this.btnVoegContainerToe.Location = new System.Drawing.Point(8, 93);
            this.btnVoegContainerToe.Name = "btnVoegContainerToe";
            this.btnVoegContainerToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegContainerToe.TabIndex = 3;
            this.btnVoegContainerToe.Text = "Voeg toe!";
            this.btnVoegContainerToe.UseVisualStyleBackColor = true;
            this.btnVoegContainerToe.Click += new System.EventHandler(this.btnVoegContainerToe_Click);
            // 
            // upDownContainerGewicht
            // 
            this.upDownContainerGewicht.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownContainerGewicht.Location = new System.Drawing.Point(10, 20);
            this.upDownContainerGewicht.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.upDownContainerGewicht.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.upDownContainerGewicht.Name = "upDownContainerGewicht";
            this.upDownContainerGewicht.Size = new System.Drawing.Size(184, 20);
            this.upDownContainerGewicht.TabIndex = 0;
            this.upDownContainerGewicht.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // lBContainers
            // 
            this.lBContainers.FormattingEnabled = true;
            this.lBContainers.Location = new System.Drawing.Point(248, 18);
            this.lBContainers.Name = "lBContainers";
            this.lBContainers.Size = new System.Drawing.Size(313, 264);
            this.lBContainers.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(909, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset!";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAantalContainers);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblBalans);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblGewichtContainers);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblMinGewicht);
            this.groupBox3.Controls.Add(this.lblMaxGewicht);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(598, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuratie";
            // 
            // lblAantalContainers
            // 
            this.lblAantalContainers.AutoSize = true;
            this.lblAantalContainers.Location = new System.Drawing.Point(139, 87);
            this.lblAantalContainers.Name = "lblAantalContainers";
            this.lblAantalContainers.Size = new System.Drawing.Size(16, 13);
            this.lblAantalContainers.TabIndex = 9;
            this.lblAantalContainers.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Aantal containers:";
            // 
            // lblBalans
            // 
            this.lblBalans.AutoSize = true;
            this.lblBalans.Location = new System.Drawing.Point(139, 111);
            this.lblBalans.Name = "lblBalans";
            this.lblBalans.Size = new System.Drawing.Size(16, 13);
            this.lblBalans.TabIndex = 7;
            this.lblBalans.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Balans:";
            // 
            // lblGewichtContainers
            // 
            this.lblGewichtContainers.AutoSize = true;
            this.lblGewichtContainers.Location = new System.Drawing.Point(139, 72);
            this.lblGewichtContainers.Name = "lblGewichtContainers";
            this.lblGewichtContainers.Size = new System.Drawing.Size(16, 13);
            this.lblGewichtContainers.TabIndex = 5;
            this.lblGewichtContainers.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gewicht containers:";
            // 
            // lblMinGewicht
            // 
            this.lblMinGewicht.AutoSize = true;
            this.lblMinGewicht.Location = new System.Drawing.Point(139, 37);
            this.lblMinGewicht.Name = "lblMinGewicht";
            this.lblMinGewicht.Size = new System.Drawing.Size(16, 13);
            this.lblMinGewicht.TabIndex = 3;
            this.lblMinGewicht.Text = "...";
            // 
            // lblMaxGewicht
            // 
            this.lblMaxGewicht.AutoSize = true;
            this.lblMaxGewicht.Location = new System.Drawing.Point(139, 20);
            this.lblMaxGewicht.Name = "lblMaxGewicht";
            this.lblMaxGewicht.Size = new System.Drawing.Size(16, 13);
            this.lblMaxGewicht.TabIndex = 2;
            this.lblMaxGewicht.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Schip minimaal gewicht: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Schip maximaal gewicht: ";
            // 
            // lBContainer1
            // 
            this.lBContainer1.FormattingEnabled = true;
            this.lBContainer1.Location = new System.Drawing.Point(66, 299);
            this.lBContainer1.Name = "lBContainer1";
            this.lBContainer1.Size = new System.Drawing.Size(250, 134);
            this.lBContainer1.TabIndex = 5;
            // 
            // lBContainer2
            // 
            this.lBContainer2.FormattingEnabled = true;
            this.lBContainer2.Location = new System.Drawing.Point(66, 454);
            this.lBContainer2.Name = "lBContainer2";
            this.lBContainer2.Size = new System.Drawing.Size(250, 134);
            this.lBContainer2.TabIndex = 6;
            // 
            // lBContainer4
            // 
            this.lBContainer4.FormattingEnabled = true;
            this.lBContainer4.Location = new System.Drawing.Point(364, 454);
            this.lBContainer4.Name = "lBContainer4";
            this.lBContainer4.Size = new System.Drawing.Size(250, 134);
            this.lBContainer4.TabIndex = 8;
            // 
            // lBContainer3
            // 
            this.lBContainer3.FormattingEnabled = true;
            this.lBContainer3.Location = new System.Drawing.Point(364, 299);
            this.lBContainer3.Name = "lBContainer3";
            this.lBContainer3.Size = new System.Drawing.Size(250, 134);
            this.lBContainer3.TabIndex = 7;
            // 
            // lBContainer6
            // 
            this.lBContainer6.FormattingEnabled = true;
            this.lBContainer6.Location = new System.Drawing.Point(671, 454);
            this.lBContainer6.Name = "lBContainer6";
            this.lBContainer6.Size = new System.Drawing.Size(250, 134);
            this.lBContainer6.TabIndex = 10;
            // 
            // lBContainer5
            // 
            this.lBContainer5.FormattingEnabled = true;
            this.lBContainer5.Location = new System.Drawing.Point(671, 299);
            this.lBContainer5.Name = "lBContainer5";
            this.lBContainer5.Size = new System.Drawing.Size(250, 134);
            this.lBContainer5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 606);
            this.Controls.Add(this.lBContainer6);
            this.Controls.Add(this.lBContainer5);
            this.Controls.Add(this.lBContainer4);
            this.Controls.Add(this.lBContainer3);
            this.Controls.Add(this.lBContainer2);
            this.Controls.Add(this.lBContainer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lBContainers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSchipGewicht)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownContainerGewicht)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSchipGewicht;
        private System.Windows.Forms.NumericUpDown upDownSchipGewicht;
        private System.Windows.Forms.Button btnVoegContainerToe;
        private System.Windows.Forms.NumericUpDown upDownContainerGewicht;
        private System.Windows.Forms.ListBox lBContainers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMaxGewicht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinGewicht;
        private System.Windows.Forms.RadioButton rBtnWaardevol;
        private System.Windows.Forms.RadioButton rBtnGekoeld;
        private System.Windows.Forms.RadioButton rBtnStandaard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGewichtContainers;
        private System.Windows.Forms.Button btnStartVerdeling;
        private System.Windows.Forms.ListBox lBContainer1;
        private System.Windows.Forms.ListBox lBContainer2;
        private System.Windows.Forms.ListBox lBContainer4;
        private System.Windows.Forms.ListBox lBContainer3;
        private System.Windows.Forms.ListBox lBContainer6;
        private System.Windows.Forms.ListBox lBContainer5;
        private System.Windows.Forms.Label lblAantalContainers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteContainer;
    }
}

