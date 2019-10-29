namespace Casus___Circustrein_v2
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
            this.TextName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioBig = new System.Windows.Forms.RadioButton();
            this.RadioMedium = new System.Windows.Forms.RadioButton();
            this.RadioSmall = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioHerbivore = new System.Windows.Forms.RadioButton();
            this.RadioCarnivore = new System.Windows.Forms.RadioButton();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ListAnimals = new System.Windows.Forms.ListBox();
            this.ListWagons = new System.Windows.Forms.ListBox();
            this.ListTrains = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(59, 13);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(154, 20);
            this.TextName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioBig);
            this.panel1.Controls.Add(this.RadioMedium);
            this.panel1.Controls.Add(this.RadioSmall);
            this.panel1.Location = new System.Drawing.Point(59, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 77);
            this.panel1.TabIndex = 1;
            // 
            // RadioBig
            // 
            this.RadioBig.AutoSize = true;
            this.RadioBig.Location = new System.Drawing.Point(4, 52);
            this.RadioBig.Name = "RadioBig";
            this.RadioBig.Size = new System.Drawing.Size(40, 17);
            this.RadioBig.TabIndex = 2;
            this.RadioBig.Text = "Big";
            this.RadioBig.UseVisualStyleBackColor = true;
            // 
            // RadioMedium
            // 
            this.RadioMedium.AutoSize = true;
            this.RadioMedium.Location = new System.Drawing.Point(4, 28);
            this.RadioMedium.Name = "RadioMedium";
            this.RadioMedium.Size = new System.Drawing.Size(62, 17);
            this.RadioMedium.TabIndex = 1;
            this.RadioMedium.Text = "Medium";
            this.RadioMedium.UseVisualStyleBackColor = true;
            // 
            // RadioSmall
            // 
            this.RadioSmall.AutoSize = true;
            this.RadioSmall.Checked = true;
            this.RadioSmall.Location = new System.Drawing.Point(4, 4);
            this.RadioSmall.Name = "RadioSmall";
            this.RadioSmall.Size = new System.Drawing.Size(50, 17);
            this.RadioSmall.TabIndex = 0;
            this.RadioSmall.TabStop = true;
            this.RadioSmall.Text = "Small";
            this.RadioSmall.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadioHerbivore);
            this.panel2.Controls.Add(this.RadioCarnivore);
            this.panel2.Location = new System.Drawing.Point(59, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 77);
            this.panel2.TabIndex = 3;
            // 
            // RadioHerbivore
            // 
            this.RadioHerbivore.AutoSize = true;
            this.RadioHerbivore.Location = new System.Drawing.Point(4, 28);
            this.RadioHerbivore.Name = "RadioHerbivore";
            this.RadioHerbivore.Size = new System.Drawing.Size(71, 17);
            this.RadioHerbivore.TabIndex = 1;
            this.RadioHerbivore.Text = "Herbivore";
            this.RadioHerbivore.UseVisualStyleBackColor = true;
            // 
            // RadioCarnivore
            // 
            this.RadioCarnivore.AutoSize = true;
            this.RadioCarnivore.Checked = true;
            this.RadioCarnivore.Location = new System.Drawing.Point(4, 4);
            this.RadioCarnivore.Name = "RadioCarnivore";
            this.RadioCarnivore.Size = new System.Drawing.Size(70, 17);
            this.RadioCarnivore.TabIndex = 0;
            this.RadioCarnivore.TabStop = true;
            this.RadioCarnivore.Text = "Carnivore";
            this.RadioCarnivore.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(13, 255);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(39, 23);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(145, 255);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(67, 23);
            this.ButtonReset.TabIndex = 5;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ListAnimals
            // 
            this.ListAnimals.FormattingEnabled = true;
            this.ListAnimals.Location = new System.Drawing.Point(218, 40);
            this.ListAnimals.Name = "ListAnimals";
            this.ListAnimals.Size = new System.Drawing.Size(120, 238);
            this.ListAnimals.TabIndex = 6;
            // 
            // ListWagons
            // 
            this.ListWagons.FormattingEnabled = true;
            this.ListWagons.Location = new System.Drawing.Point(344, 40);
            this.ListWagons.Name = "ListWagons";
            this.ListWagons.Size = new System.Drawing.Size(120, 238);
            this.ListWagons.TabIndex = 7;
            // 
            // ListTrains
            // 
            this.ListTrains.FormattingEnabled = true;
            this.ListTrains.Location = new System.Drawing.Point(470, 40);
            this.ListTrains.Name = "ListTrains";
            this.ListTrains.Size = new System.Drawing.Size(120, 238);
            this.ListTrains.TabIndex = 8;
            this.ListTrains.SelectedIndexChanged += new System.EventHandler(this.ListTrains_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dieren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wagonnen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Treinen";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(59, 255);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(80, 23);
            this.ButtonCalculate.TabIndex = 13;
            this.ButtonCalculate.Text = "Bereken";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Grootte:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(218, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 238);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 286);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListTrains);
            this.Controls.Add(this.ListWagons);
            this.Controls.Add(this.ListAnimals);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextName);
            this.Name = "Form1";
            this.Text = "CircusTrein";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioBig;
        private System.Windows.Forms.RadioButton RadioMedium;
        private System.Windows.Forms.RadioButton RadioSmall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadioHerbivore;
        private System.Windows.Forms.RadioButton RadioCarnivore;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.ListBox ListAnimals;
        private System.Windows.Forms.ListBox ListWagons;
        private System.Windows.Forms.ListBox ListTrains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
    }
}

