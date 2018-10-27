namespace Business_IoT_Thermostat {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoneBtn = new System.Windows.Forms.Button();
            this.mapBtn = new System.Windows.Forms.Button();
            this.generalBtn = new System.Windows.Forms.Button();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.zonePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zoneBtn);
            this.panel1.Controls.Add(this.mapBtn);
            this.panel1.Controls.Add(this.generalBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 496);
            this.panel1.TabIndex = 0;
            // 
            // zoneBtn
            // 
            this.zoneBtn.BackColor = System.Drawing.Color.Transparent;
            this.zoneBtn.FlatAppearance.BorderSize = 0;
            this.zoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoneBtn.Location = new System.Drawing.Point(28, 220);
            this.zoneBtn.Name = "zoneBtn";
            this.zoneBtn.Size = new System.Drawing.Size(152, 47);
            this.zoneBtn.TabIndex = 2;
            this.zoneBtn.Text = "Zones";
            this.zoneBtn.UseVisualStyleBackColor = false;
            this.zoneBtn.Click += new System.EventHandler(this.zoneBtn_Click);
            // 
            // mapBtn
            // 
            this.mapBtn.BackColor = System.Drawing.Color.Transparent;
            this.mapBtn.FlatAppearance.BorderSize = 0;
            this.mapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mapBtn.Location = new System.Drawing.Point(28, 138);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(152, 47);
            this.mapBtn.TabIndex = 1;
            this.mapBtn.Text = "Map";
            this.mapBtn.UseVisualStyleBackColor = false;
            this.mapBtn.Click += new System.EventHandler(this.mapBtn_Click);
            // 
            // generalBtn
            // 
            this.generalBtn.BackColor = System.Drawing.Color.Transparent;
            this.generalBtn.FlatAppearance.BorderSize = 0;
            this.generalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generalBtn.Location = new System.Drawing.Point(28, 60);
            this.generalBtn.Name = "generalBtn";
            this.generalBtn.Size = new System.Drawing.Size(152, 47);
            this.generalBtn.TabIndex = 0;
            this.generalBtn.Text = "General";
            this.generalBtn.UseVisualStyleBackColor = false;
            this.generalBtn.Click += new System.EventHandler(this.generalBtn_Click);
            // 
            // generalPanel
            // 
            this.generalPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generalPanel.Location = new System.Drawing.Point(225, 12);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(581, 496);
            this.generalPanel.TabIndex = 1;
            // 
            // mapPanel
            // 
            this.mapPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.mapPanel.Location = new System.Drawing.Point(225, 12);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(581, 496);
            this.mapPanel.TabIndex = 2;
            // 
            // zonePanel
            // 
            this.zonePanel.BackColor = System.Drawing.Color.Khaki;
            this.zonePanel.Location = new System.Drawing.Point(225, 12);
            this.zonePanel.Name = "zonePanel";
            this.zonePanel.Size = new System.Drawing.Size(581, 496);
            this.zonePanel.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 520);
            this.Controls.Add(this.zonePanel);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generalBtn;
        private System.Windows.Forms.Button zoneBtn;
        private System.Windows.Forms.Button mapBtn;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Panel zonePanel;
    }
}
