namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblAges = new System.Windows.Forms.Label();
            this.lbAges = new System.Windows.Forms.ListBox();
            this.lbaverage = new System.Windows.Forms.Label();
            this.lbsum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbsum);
            this.groupBox1.Controls.Add(this.lbaverage);
            this.groupBox1.Controls.Add(this.lbAges);
            this.groupBox1.Controls.Add(this.lblAges);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de edades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la edad:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(87, 37);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(66, 20);
            this.tbAge.TabIndex = 1;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(159, 35);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Agregar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblAges
            // 
            this.lblAges.AutoSize = true;
            this.lblAges.Location = new System.Drawing.Point(7, 88);
            this.lblAges.Name = "lblAges";
            this.lblAges.Size = new System.Drawing.Size(105, 13);
            this.lblAges.TabIndex = 3;
            this.lblAges.Text = "Edades Registradas:";
            this.lblAges.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbAges
            // 
            this.lbAges.FormattingEnabled = true;
            this.lbAges.Location = new System.Drawing.Point(6, 104);
            this.lbAges.Name = "lbAges";
            this.lbAges.Size = new System.Drawing.Size(121, 108);
            this.lbAges.TabIndex = 4;
            // 
            // lbaverage
            // 
            this.lbaverage.AutoSize = true;
            this.lbaverage.Location = new System.Drawing.Point(159, 104);
            this.lbaverage.Name = "lbaverage";
            this.lbaverage.Size = new System.Drawing.Size(63, 13);
            this.lbaverage.TabIndex = 5;
            this.lbaverage.Text = "Promedio: 0";
            // 
            // lbsum
            // 
            this.lbsum.AutoSize = true;
            this.lbsum.Location = new System.Drawing.Point(162, 148);
            this.lbsum.Name = "lbsum";
            this.lbsum.Size = new System.Drawing.Size(46, 13);
            this.lbsum.TabIndex = 6;
            this.lbsum.Text = "Suma: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arreglos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbAges;
        private System.Windows.Forms.Label lblAges;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsum;
        private System.Windows.Forms.Label lbaverage;
    }
}

