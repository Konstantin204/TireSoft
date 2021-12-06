namespace TireSoft
{
    partial class FormTires
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
            this.buttonTrcuk = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonTrcuk
            // 
            this.buttonTrcuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrcuk.Location = new System.Drawing.Point(12, 45);
            this.buttonTrcuk.Name = "buttonTrcuk";
            this.buttonTrcuk.Size = new System.Drawing.Size(175, 55);
            this.buttonTrcuk.TabIndex = 0;
            this.buttonTrcuk.Text = "Камиони";
            this.buttonTrcuk.UseVisualStyleBackColor = true;
            this.buttonTrcuk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTrcuk_MouseClick);
            // 
            // buttonCars
            // 
            this.buttonCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCars.Location = new System.Drawing.Point(12, 106);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(175, 55);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Леки автомобили";
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(289, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 436);
            this.listBox1.TabIndex = 2;
            // 
            // FormTires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCars);
            this.Controls.Add(this.buttonTrcuk);
            this.Name = "FormTires";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 20, 7);
            this.Text = "FormTires";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTrcuk;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.ListBox listBox1;
    }
}