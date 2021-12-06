namespace TireSoft
{
    partial class FormExistInfo
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
            this.buttonCancle = new System.Windows.Forms.Button();
            this.buttonCarInfo = new System.Windows.Forms.Button();
            this.buttonTireInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancle
            // 
            this.buttonCancle.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCancle.FlatAppearance.BorderSize = 0;
            this.buttonCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancle.Location = new System.Drawing.Point(64, 3);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(283, 80);
            this.buttonCancle.TabIndex = 0;
            this.buttonCancle.Text = "ГумиСофт";
            this.buttonCancle.UseVisualStyleBackColor = false;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonCarInfo
            // 
            this.buttonCarInfo.Location = new System.Drawing.Point(40, 114);
            this.buttonCarInfo.Name = "buttonCarInfo";
            this.buttonCarInfo.Size = new System.Drawing.Size(347, 48);
            this.buttonCarInfo.TabIndex = 1;
            this.buttonCarInfo.Text = "Информация за колите";
            this.buttonCarInfo.UseVisualStyleBackColor = true;
            this.buttonCarInfo.Click += new System.EventHandler(this.buttonCarInfo_Click);
            // 
            // buttonTireInfo
            // 
            this.buttonTireInfo.Location = new System.Drawing.Point(40, 193);
            this.buttonTireInfo.Name = "buttonTireInfo";
            this.buttonTireInfo.Size = new System.Drawing.Size(347, 48);
            this.buttonTireInfo.TabIndex = 2;
            this.buttonTireInfo.Text = "Информация за гумите";
            this.buttonTireInfo.UseVisualStyleBackColor = true;
            this.buttonTireInfo.Click += new System.EventHandler(this.buttonTireInfo_Click);
            // 
            // FormExistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.buttonTireInfo);
            this.Controls.Add(this.buttonCarInfo);
            this.Controls.Add(this.buttonCancle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExistInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormExistInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Button buttonCarInfo;
        private System.Windows.Forms.Button buttonTireInfo;
    }
}