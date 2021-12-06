namespace TireSoft
{
    partial class FormMain
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
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCheckInfo = new System.Windows.Forms.Button();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(246, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(283, 98);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "ГумиСофт";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(320, 218);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 67);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добави нова информация";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCheckInfo
            // 
            this.buttonCheckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckInfo.Location = new System.Drawing.Point(57, 218);
            this.buttonCheckInfo.Name = "buttonCheckInfo";
            this.buttonCheckInfo.Size = new System.Drawing.Size(177, 67);
            this.buttonCheckInfo.TabIndex = 2;
            this.buttonCheckInfo.Text = "Записана информация";
            this.buttonCheckInfo.UseVisualStyleBackColor = true;
            this.buttonCheckInfo.Click += new System.EventHandler(this.buttonCheckInfo_Click);
            // 
            // buttonRepair
            // 
            this.buttonRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRepair.Location = new System.Drawing.Point(564, 218);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(177, 67);
            this.buttonRepair.TabIndex = 3;
            this.buttonRepair.Text = "Ремонт";
            this.buttonRepair.UseVisualStyleBackColor = true;
            this.buttonRepair.Click += new System.EventHandler(this.buttonRepair_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRepair);
            this.Controls.Add(this.buttonCheckInfo);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";         
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCheckInfo;
        private System.Windows.Forms.Button buttonRepair;
    }
}

