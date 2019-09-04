namespace Casus___Circustrein
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddAnimal = new System.Windows.Forms.Button();
            this.GbAddAnimal = new System.Windows.Forms.GroupBox();
            this.BtnAddAnimalAdd = new System.Windows.Forms.Button();
            this.TbName = new System.Windows.Forms.TextBox();
            this.RadBig = new System.Windows.Forms.RadioButton();
            this.RadMedium = new System.Windows.Forms.RadioButton();
            this.RadSmall = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RadCarnivore = new System.Windows.Forms.RadioButton();
            this.RadHerbivore = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GbAddAnimal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(704, 401);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(785, 401);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddAnimal
            // 
            this.BtnAddAnimal.Location = new System.Drawing.Point(13, 13);
            this.BtnAddAnimal.Name = "BtnAddAnimal";
            this.BtnAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAnimal.TabIndex = 2;
            this.BtnAddAnimal.Text = "Add Animal";
            this.BtnAddAnimal.UseVisualStyleBackColor = true;
            this.BtnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // GbAddAnimal
            // 
            this.GbAddAnimal.Controls.Add(this.BtnAddAnimalAdd);
            this.GbAddAnimal.Controls.Add(this.TbName);
            this.GbAddAnimal.Controls.Add(this.RadBig);
            this.GbAddAnimal.Controls.Add(this.RadMedium);
            this.GbAddAnimal.Controls.Add(this.RadSmall);
            this.GbAddAnimal.Controls.Add(this.label3);
            this.GbAddAnimal.Controls.Add(this.label1);
            this.GbAddAnimal.Controls.Add(this.panel1);
            this.GbAddAnimal.Location = new System.Drawing.Point(12, 42);
            this.GbAddAnimal.Name = "GbAddAnimal";
            this.GbAddAnimal.Size = new System.Drawing.Size(225, 133);
            this.GbAddAnimal.TabIndex = 3;
            this.GbAddAnimal.TabStop = false;
            this.GbAddAnimal.Text = "Add Animal";
            // 
            // BtnAddAnimalAdd
            // 
            this.BtnAddAnimalAdd.Location = new System.Drawing.Point(144, 101);
            this.BtnAddAnimalAdd.Name = "BtnAddAnimalAdd";
            this.BtnAddAnimalAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAnimalAdd.TabIndex = 4;
            this.BtnAddAnimalAdd.Text = "Add";
            this.BtnAddAnimalAdd.UseVisualStyleBackColor = true;
            this.BtnAddAnimalAdd.Click += new System.EventHandler(this.BtnAddAnimalAdd_Click);
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(48, 17);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(164, 20);
            this.TbName.TabIndex = 8;
            // 
            // RadBig
            // 
            this.RadBig.AutoSize = true;
            this.RadBig.Location = new System.Drawing.Point(172, 78);
            this.RadBig.Name = "RadBig";
            this.RadBig.Size = new System.Drawing.Size(40, 17);
            this.RadBig.TabIndex = 7;
            this.RadBig.TabStop = true;
            this.RadBig.Text = "Big";
            this.RadBig.UseVisualStyleBackColor = true;
            // 
            // RadMedium
            // 
            this.RadMedium.AutoSize = true;
            this.RadMedium.Location = new System.Drawing.Point(104, 78);
            this.RadMedium.Name = "RadMedium";
            this.RadMedium.Size = new System.Drawing.Size(62, 17);
            this.RadMedium.TabIndex = 6;
            this.RadMedium.TabStop = true;
            this.RadMedium.Text = "Medium";
            this.RadMedium.UseVisualStyleBackColor = true;
            // 
            // RadSmall
            // 
            this.RadSmall.AutoSize = true;
            this.RadSmall.Location = new System.Drawing.Point(48, 78);
            this.RadSmall.Name = "RadSmall";
            this.RadSmall.Size = new System.Drawing.Size(50, 17);
            this.RadSmall.TabIndex = 5;
            this.RadSmall.TabStop = true;
            this.RadSmall.Text = "Small";
            this.RadSmall.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RadCarnivore);
            this.panel1.Controls.Add(this.RadHerbivore);
            this.panel1.Location = new System.Drawing.Point(10, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 24);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // RadCarnivore
            // 
            this.RadCarnivore.AutoSize = true;
            this.RadCarnivore.Location = new System.Drawing.Point(38, 5);
            this.RadCarnivore.Name = "RadCarnivore";
            this.RadCarnivore.Size = new System.Drawing.Size(70, 17);
            this.RadCarnivore.TabIndex = 3;
            this.RadCarnivore.TabStop = true;
            this.RadCarnivore.Text = "Carnivore";
            this.RadCarnivore.UseVisualStyleBackColor = true;
            // 
            // RadHerbivore
            // 
            this.RadHerbivore.AutoSize = true;
            this.RadHerbivore.Location = new System.Drawing.Point(131, 5);
            this.RadHerbivore.Name = "RadHerbivore";
            this.RadHerbivore.Size = new System.Drawing.Size(71, 17);
            this.RadHerbivore.TabIndex = 4;
            this.RadHerbivore.TabStop = true;
            this.RadHerbivore.Text = "Herbivore";
            this.RadHerbivore.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(360, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 173);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 436);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnAddAnimal);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.GbAddAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbAddAnimal.ResumeLayout(false);
            this.GbAddAnimal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddAnimal;
        private System.Windows.Forms.GroupBox GbAddAnimal;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.RadioButton RadBig;
        private System.Windows.Forms.RadioButton RadMedium;
        private System.Windows.Forms.RadioButton RadSmall;
        private System.Windows.Forms.RadioButton RadHerbivore;
        private System.Windows.Forms.RadioButton RadCarnivore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddAnimalAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

