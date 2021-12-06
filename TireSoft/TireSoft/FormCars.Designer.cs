namespace TireSoft
{
    partial class FormCars
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.buttonCar = new System.Windows.Forms.Button();
            this.buttonTruck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.HorizontalScrollbar = true;
            this.listBoxCars.ItemHeight = 20;
            this.listBoxCars.Location = new System.Drawing.Point(267, 7);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.ScrollAlwaysVisible = true;
            this.listBoxCars.Size = new System.Drawing.Size(491, 411);
            this.listBoxCars.TabIndex = 0;
            // 
            // buttonCar
            // 
            this.buttonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCar.Location = new System.Drawing.Point(12, 106);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(175, 55);
            this.buttonCar.TabIndex = 2;
            this.buttonCar.Text = "Леки автомобили";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonTruck
            // 
            this.buttonTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTruck.Location = new System.Drawing.Point(12, 45);
            this.buttonTruck.Name = "buttonTruck";
            this.buttonTruck.Size = new System.Drawing.Size(175, 55);
            this.buttonTruck.TabIndex = 3;
            this.buttonTruck.Text = "Камиони";
            this.buttonTruck.UseVisualStyleBackColor = true;
            this.buttonTruck.Click += new System.EventHandler(this.buttonTruck_Click);
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 425);
            this.Controls.Add(this.buttonTruck);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.listBoxCars);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCars";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 20, 7);
            this.Text = "FormCars";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonTruck;
    }
}