namespace Casus___Containervervoer
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
            this.gbSetUp = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetShipWeight = new System.Windows.Forms.Button();
            this.gbContainerSetUp = new System.Windows.Forms.GroupBox();
            this.rdContainerStandard = new System.Windows.Forms.RadioButton();
            this.rbContainerCooled = new System.Windows.Forms.RadioButton();
            this.rbContainerValuable = new System.Windows.Forms.RadioButton();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContainerDeleteAll = new System.Windows.Forms.Button();
            this.btnContainerDelete = new System.Windows.Forms.Button();
            this.listContainers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContainerTotal = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblShipMinWeight = new System.Windows.Forms.Label();
            this.lblShipMaxWeight = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContainerWeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShipWidth = new System.Windows.Forms.Label();
            this.lblShipLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSetUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.gbContainerSetUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContainerWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetUp
            // 
            this.gbSetUp.Controls.Add(this.label6);
            this.gbSetUp.Controls.Add(this.numWidth);
            this.gbSetUp.Controls.Add(this.numLength);
            this.gbSetUp.Controls.Add(this.label1);
            this.gbSetUp.Controls.Add(this.btnSetShipWeight);
            this.gbSetUp.Location = new System.Drawing.Point(12, 12);
            this.gbSetUp.Name = "gbSetUp";
            this.gbSetUp.Size = new System.Drawing.Size(135, 101);
            this.gbSetUp.TabIndex = 0;
            this.gbSetUp.TabStop = false;
            this.gbSetUp.Text = "Ship set-up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Breedte";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(71, 32);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(58, 20);
            this.numWidth.TabIndex = 5;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(6, 32);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(58, 20);
            this.numLength.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lengte";
            // 
            // btnSetShipWeight
            // 
            this.btnSetShipWeight.Location = new System.Drawing.Point(6, 58);
            this.btnSetShipWeight.Name = "btnSetShipWeight";
            this.btnSetShipWeight.Size = new System.Drawing.Size(123, 23);
            this.btnSetShipWeight.TabIndex = 2;
            this.btnSetShipWeight.Text = "Set Size";
            this.btnSetShipWeight.UseVisualStyleBackColor = true;
            this.btnSetShipWeight.Click += new System.EventHandler(this.btnSetShipWeight_Click);
            // 
            // gbContainerSetUp
            // 
            this.gbContainerSetUp.Controls.Add(this.rdContainerStandard);
            this.gbContainerSetUp.Controls.Add(this.rbContainerCooled);
            this.gbContainerSetUp.Controls.Add(this.rbContainerValuable);
            this.gbContainerSetUp.Controls.Add(this.btnAddContainer);
            this.gbContainerSetUp.Controls.Add(this.label2);
            this.gbContainerSetUp.Controls.Add(this.numContainerWeight);
            this.gbContainerSetUp.Location = new System.Drawing.Point(13, 187);
            this.gbContainerSetUp.Name = "gbContainerSetUp";
            this.gbContainerSetUp.Size = new System.Drawing.Size(135, 159);
            this.gbContainerSetUp.TabIndex = 3;
            this.gbContainerSetUp.TabStop = false;
            this.gbContainerSetUp.Text = "Container Set-Up";
            // 
            // rdContainerStandard
            // 
            this.rdContainerStandard.AutoSize = true;
            this.rdContainerStandard.Checked = true;
            this.rdContainerStandard.Location = new System.Drawing.Point(6, 58);
            this.rdContainerStandard.Name = "rdContainerStandard";
            this.rdContainerStandard.Size = new System.Drawing.Size(68, 17);
            this.rdContainerStandard.TabIndex = 5;
            this.rdContainerStandard.TabStop = true;
            this.rdContainerStandard.Text = "Standard";
            this.rdContainerStandard.UseVisualStyleBackColor = true;
            // 
            // rbContainerCooled
            // 
            this.rbContainerCooled.AutoSize = true;
            this.rbContainerCooled.Location = new System.Drawing.Point(6, 81);
            this.rbContainerCooled.Name = "rbContainerCooled";
            this.rbContainerCooled.Size = new System.Drawing.Size(58, 17);
            this.rbContainerCooled.TabIndex = 4;
            this.rbContainerCooled.Text = "Cooled";
            this.rbContainerCooled.UseVisualStyleBackColor = true;
            // 
            // rbContainerValuable
            // 
            this.rbContainerValuable.AutoSize = true;
            this.rbContainerValuable.Location = new System.Drawing.Point(6, 104);
            this.rbContainerValuable.Name = "rbContainerValuable";
            this.rbContainerValuable.Size = new System.Drawing.Size(66, 17);
            this.rbContainerValuable.TabIndex = 3;
            this.rbContainerValuable.Text = "Valuable";
            this.rbContainerValuable.UseVisualStyleBackColor = true;
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Enabled = false;
            this.btnAddContainer.Location = new System.Drawing.Point(6, 127);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(123, 23);
            this.btnAddContainer.TabIndex = 2;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight in KG:";
            // 
            // numContainerWeight
            // 
            this.numContainerWeight.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numContainerWeight.Location = new System.Drawing.Point(6, 32);
            this.numContainerWeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numContainerWeight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numContainerWeight.Name = "numContainerWeight";
            this.numContainerWeight.Size = new System.Drawing.Size(123, 20);
            this.numContainerWeight.TabIndex = 0;
            this.numContainerWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContainerDeleteAll);
            this.groupBox1.Controls.Add(this.btnContainerDelete);
            this.groupBox1.Controls.Add(this.listContainers);
            this.groupBox1.Location = new System.Drawing.Point(154, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 334);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Containers";
            // 
            // btnContainerDeleteAll
            // 
            this.btnContainerDeleteAll.Location = new System.Drawing.Point(87, 223);
            this.btnContainerDeleteAll.Name = "btnContainerDeleteAll";
            this.btnContainerDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnContainerDeleteAll.TabIndex = 2;
            this.btnContainerDeleteAll.Text = "Delete All";
            this.btnContainerDeleteAll.UseVisualStyleBackColor = true;
            this.btnContainerDeleteAll.Click += new System.EventHandler(this.btnContainerDeleteAll_Click);
            // 
            // btnContainerDelete
            // 
            this.btnContainerDelete.Location = new System.Drawing.Point(6, 223);
            this.btnContainerDelete.Name = "btnContainerDelete";
            this.btnContainerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContainerDelete.TabIndex = 1;
            this.btnContainerDelete.Text = "Delete";
            this.btnContainerDelete.UseVisualStyleBackColor = true;
            this.btnContainerDelete.Click += new System.EventHandler(this.btnContainerDelete_Click);
            // 
            // listContainers
            // 
            this.listContainers.FormattingEnabled = true;
            this.listContainers.Location = new System.Drawing.Point(6, 16);
            this.listContainers.Name = "listContainers";
            this.listContainers.Size = new System.Drawing.Size(300, 199);
            this.listContainers.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Containers";
            // 
            // lblContainerTotal
            // 
            this.lblContainerTotal.AutoSize = true;
            this.lblContainerTotal.Location = new System.Drawing.Point(168, 47);
            this.lblContainerTotal.Name = "lblContainerTotal";
            this.lblContainerTotal.Size = new System.Drawing.Size(106, 13);
            this.lblContainerTotal.TabIndex = 4;
            this.lblContainerTotal.Text = "No containers added";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(6, 19);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(304, 88);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rtbLog);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 142);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Complete log";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblShipMinWeight);
            this.groupBox3.Controls.Add(this.lblShipMaxWeight);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnCalculation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblContainerWeight);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblShipWidth);
            this.groupBox3.Controls.Add(this.lblShipLength);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblContainerTotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(472, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 186);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // lblShipMinWeight
            // 
            this.lblShipMinWeight.AutoSize = true;
            this.lblShipMinWeight.Location = new System.Drawing.Point(168, 117);
            this.lblShipMinWeight.Name = "lblShipMinWeight";
            this.lblShipMinWeight.Size = new System.Drawing.Size(110, 13);
            this.lblShipMinWeight.TabIndex = 19;
            this.lblShipMinWeight.Text = "Ship has not been set";
            // 
            // lblShipMaxWeight
            // 
            this.lblShipMaxWeight.AutoSize = true;
            this.lblShipMaxWeight.Location = new System.Drawing.Point(168, 104);
            this.lblShipMaxWeight.Name = "lblShipMaxWeight";
            this.lblShipMaxWeight.Size = new System.Drawing.Size(110, 13);
            this.lblShipMaxWeight.TabIndex = 18;
            this.lblShipMaxWeight.Text = "Ship has not been set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(70, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Weight Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Min";
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(118, 155);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(94, 23);
            this.btnCalculation.TabIndex = 14;
            this.btnCalculation.Text = "Start Calculation";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Length";
            // 
            // lblContainerWeight
            // 
            this.lblContainerWeight.AutoSize = true;
            this.lblContainerWeight.Location = new System.Drawing.Point(168, 60);
            this.lblContainerWeight.Name = "lblContainerWeight";
            this.lblContainerWeight.Size = new System.Drawing.Size(106, 13);
            this.lblContainerWeight.TabIndex = 11;
            this.lblContainerWeight.Text = "No containers added";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Count";
            // 
            // lblShipWidth
            // 
            this.lblShipWidth.AutoSize = true;
            this.lblShipWidth.Location = new System.Drawing.Point(168, 91);
            this.lblShipWidth.Name = "lblShipWidth";
            this.lblShipWidth.Size = new System.Drawing.Size(110, 13);
            this.lblShipWidth.TabIndex = 8;
            this.lblShipWidth.Text = "Ship has not been set";
            // 
            // lblShipLength
            // 
            this.lblShipLength.AutoSize = true;
            this.lblShipLength.Location = new System.Drawing.Point(168, 78);
            this.lblShipLength.Name = "lblShipLength";
            this.lblShipLength.Size = new System.Drawing.Size(110, 13);
            this.lblShipLength.TabIndex = 6;
            this.lblShipLength.Text = "Ship has not been set";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ship";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbContainerSetUp);
            this.Controls.Add(this.gbSetUp);
            this.Name = "Form1";
            this.Text = "Berend Bootje Container Calculatie";
            this.gbSetUp.ResumeLayout(false);
            this.gbSetUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.gbContainerSetUp.ResumeLayout(false);
            this.gbContainerSetUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContainerWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetUp;
        private System.Windows.Forms.Button btnSetShipWeight;
        private System.Windows.Forms.GroupBox gbContainerSetUp;
        private System.Windows.Forms.RadioButton rdContainerStandard;
        private System.Windows.Forms.RadioButton rbContainerCooled;
        private System.Windows.Forms.RadioButton rbContainerValuable;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numContainerWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContainerTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnContainerDeleteAll;
        private System.Windows.Forms.Button btnContainerDelete;
        private System.Windows.Forms.ListBox listContainers;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblShipWidth;
        private System.Windows.Forms.Label lblShipLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContainerWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShipMinWeight;
        private System.Windows.Forms.Label lblShipMaxWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
    }
}

