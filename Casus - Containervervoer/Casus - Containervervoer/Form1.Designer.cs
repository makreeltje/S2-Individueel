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
            this.btnSetShipWeight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numShipWeight = new System.Windows.Forms.NumericUpDown();
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
            this.lblShipBalance = new System.Windows.Forms.Label();
            this.lblShipWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listPlace6 = new System.Windows.Forms.ListBox();
            this.listPlace5 = new System.Windows.Forms.ListBox();
            this.listPlace4 = new System.Windows.Forms.ListBox();
            this.listPlace3 = new System.Windows.Forms.ListBox();
            this.listPlace2 = new System.Windows.Forms.ListBox();
            this.listPlace1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContainerWeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFront = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSetUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShipWeight)).BeginInit();
            this.gbContainerSetUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContainerWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetUp
            // 
            this.gbSetUp.Controls.Add(this.btnSetShipWeight);
            this.gbSetUp.Controls.Add(this.label1);
            this.gbSetUp.Controls.Add(this.numShipWeight);
            this.gbSetUp.Location = new System.Drawing.Point(12, 12);
            this.gbSetUp.Name = "gbSetUp";
            this.gbSetUp.Size = new System.Drawing.Size(135, 90);
            this.gbSetUp.TabIndex = 0;
            this.gbSetUp.TabStop = false;
            this.gbSetUp.Text = "Ship set-up";
            // 
            // btnSetShipWeight
            // 
            this.btnSetShipWeight.Location = new System.Drawing.Point(6, 58);
            this.btnSetShipWeight.Name = "btnSetShipWeight";
            this.btnSetShipWeight.Size = new System.Drawing.Size(123, 23);
            this.btnSetShipWeight.TabIndex = 2;
            this.btnSetShipWeight.Text = "Set Weight";
            this.btnSetShipWeight.UseVisualStyleBackColor = true;
            this.btnSetShipWeight.Click += new System.EventHandler(this.btnSetShipWeight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weight in KG:";
            // 
            // numShipWeight
            // 
            this.numShipWeight.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numShipWeight.Location = new System.Drawing.Point(6, 32);
            this.numShipWeight.Maximum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.numShipWeight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numShipWeight.Name = "numShipWeight";
            this.numShipWeight.Size = new System.Drawing.Size(123, 20);
            this.numShipWeight.TabIndex = 0;
            this.numShipWeight.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // gbContainerSetUp
            // 
            this.gbContainerSetUp.Controls.Add(this.rdContainerStandard);
            this.gbContainerSetUp.Controls.Add(this.rbContainerCooled);
            this.gbContainerSetUp.Controls.Add(this.rbContainerValuable);
            this.gbContainerSetUp.Controls.Add(this.btnAddContainer);
            this.gbContainerSetUp.Controls.Add(this.label2);
            this.gbContainerSetUp.Controls.Add(this.numContainerWeight);
            this.gbContainerSetUp.Location = new System.Drawing.Point(12, 108);
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
            this.groupBox1.Size = new System.Drawing.Size(312, 255);
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
            this.rtbLog.Size = new System.Drawing.Size(304, 47);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rtbLog);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Complete log";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblContainerWeight);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblShipBalance);
            this.groupBox3.Controls.Add(this.lblShipWeight);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblContainerTotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(475, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 148);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // lblShipBalance
            // 
            this.lblShipBalance.AutoSize = true;
            this.lblShipBalance.Location = new System.Drawing.Point(168, 91);
            this.lblShipBalance.Name = "lblShipBalance";
            this.lblShipBalance.Size = new System.Drawing.Size(104, 13);
            this.lblShipBalance.TabIndex = 8;
            this.lblShipBalance.Text = "No calculation made";
            // 
            // lblShipWeight
            // 
            this.lblShipWeight.AutoSize = true;
            this.lblShipWeight.Location = new System.Drawing.Point(168, 78);
            this.lblShipWeight.Name = "lblShipWeight";
            this.lblShipWeight.Size = new System.Drawing.Size(72, 13);
            this.lblShipWeight.TabIndex = 6;
            this.lblShipWeight.Text = "No weight set";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblFront);
            this.groupBox4.Controls.Add(this.listPlace6);
            this.groupBox4.Controls.Add(this.listPlace5);
            this.groupBox4.Controls.Add(this.listPlace4);
            this.groupBox4.Controls.Add(this.listPlace3);
            this.groupBox4.Controls.Add(this.listPlace2);
            this.groupBox4.Controls.Add(this.listPlace1);
            this.groupBox4.Location = new System.Drawing.Point(12, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 165);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ship";
            // 
            // listPlace6
            // 
            this.listPlace6.FormattingEnabled = true;
            this.listPlace6.Location = new System.Drawing.Point(513, 90);
            this.listPlace6.Name = "listPlace6";
            this.listPlace6.Size = new System.Drawing.Size(230, 69);
            this.listPlace6.TabIndex = 5;
            // 
            // listPlace5
            // 
            this.listPlace5.FormattingEnabled = true;
            this.listPlace5.Location = new System.Drawing.Point(513, 19);
            this.listPlace5.Name = "listPlace5";
            this.listPlace5.Size = new System.Drawing.Size(230, 69);
            this.listPlace5.TabIndex = 4;
            // 
            // listPlace4
            // 
            this.listPlace4.FormattingEnabled = true;
            this.listPlace4.Location = new System.Drawing.Point(273, 91);
            this.listPlace4.Name = "listPlace4";
            this.listPlace4.Size = new System.Drawing.Size(230, 69);
            this.listPlace4.TabIndex = 3;
            // 
            // listPlace3
            // 
            this.listPlace3.FormattingEnabled = true;
            this.listPlace3.Location = new System.Drawing.Point(273, 16);
            this.listPlace3.Name = "listPlace3";
            this.listPlace3.Size = new System.Drawing.Size(230, 69);
            this.listPlace3.TabIndex = 2;
            // 
            // listPlace2
            // 
            this.listPlace2.FormattingEnabled = true;
            this.listPlace2.Location = new System.Drawing.Point(34, 90);
            this.listPlace2.Name = "listPlace2";
            this.listPlace2.Size = new System.Drawing.Size(230, 69);
            this.listPlace2.TabIndex = 1;
            // 
            // listPlace1
            // 
            this.listPlace1.FormattingEnabled = true;
            this.listPlace1.Location = new System.Drawing.Point(34, 16);
            this.listPlace1.Name = "listPlace1";
            this.listPlace1.Size = new System.Drawing.Size(230, 69);
            this.listPlace1.TabIndex = 0;
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
            // lblContainerWeight
            // 
            this.lblContainerWeight.AutoSize = true;
            this.lblContainerWeight.Location = new System.Drawing.Point(168, 60);
            this.lblContainerWeight.Name = "lblContainerWeight";
            this.lblContainerWeight.Size = new System.Drawing.Size(106, 13);
            this.lblContainerWeight.TabIndex = 11;
            this.lblContainerWeight.Text = "No containers added";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Balance";
            // 
            // lblFront
            // 
            this.lblFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFront.Location = new System.Drawing.Point(6, 16);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(22, 143);
            this.lblFront.TabIndex = 6;
            this.lblFront.Text = "F\r\nR\r\nO\r\nN\r\nT";
            this.lblFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 143);
            this.label6.TabIndex = 7;
            this.label6.Text = "B\r\nA\r\nC\r\nK";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbContainerSetUp);
            this.Controls.Add(this.gbSetUp);
            this.Name = "Form1";
            this.Text = "Berend Bootje Container Calculatie";
            this.gbSetUp.ResumeLayout(false);
            this.gbSetUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShipWeight)).EndInit();
            this.gbContainerSetUp.ResumeLayout(false);
            this.gbContainerSetUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContainerWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetUp;
        private System.Windows.Forms.Button btnSetShipWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numShipWeight;
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
        private System.Windows.Forms.Label lblShipBalance;
        private System.Windows.Forms.Label lblShipWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listPlace6;
        private System.Windows.Forms.ListBox listPlace5;
        private System.Windows.Forms.ListBox listPlace4;
        private System.Windows.Forms.ListBox listPlace3;
        private System.Windows.Forms.ListBox listPlace2;
        private System.Windows.Forms.ListBox listPlace1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContainerWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.Label label6;
    }
}

