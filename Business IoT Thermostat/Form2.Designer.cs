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
            this.settingsBtn = new System.Windows.Forms.Button();
            this.mapBtn = new System.Windows.Forms.Button();
            this.generalBtn = new System.Windows.Forms.Button();
            this.userControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.settingsBtn);
            this.panel1.Controls.Add(this.mapBtn);
            this.panel1.Controls.Add(this.generalBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 647);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(12, 187);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(152, 47);
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.zoneBtn_Click);
            // 
            // mapBtn
            // 
            this.mapBtn.BackColor = System.Drawing.Color.Transparent;
            this.mapBtn.FlatAppearance.BorderSize = 0;
            this.mapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.mapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.mapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapBtn.ForeColor = System.Drawing.Color.White;
            this.mapBtn.Location = new System.Drawing.Point(12, 134);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(152, 47);
            this.mapBtn.TabIndex = 1;
            this.mapBtn.Text = "Map";
            this.mapBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mapBtn.UseVisualStyleBackColor = false;
            this.mapBtn.Click += new System.EventHandler(this.mapBtn_Click);
            // 
            // generalBtn
            // 
            this.generalBtn.BackColor = System.Drawing.Color.Transparent;
            this.generalBtn.FlatAppearance.BorderSize = 0;
            this.generalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.generalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.generalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalBtn.ForeColor = System.Drawing.Color.White;
            this.generalBtn.Location = new System.Drawing.Point(12, 81);
            this.generalBtn.Name = "generalBtn";
            this.generalBtn.Size = new System.Drawing.Size(152, 47);
            this.generalBtn.TabIndex = 0;
            this.generalBtn.Text = "General";
            this.generalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalBtn.UseVisualStyleBackColor = false;
            this.generalBtn.Click += new System.EventHandler(this.generalBtn_Click);
            // 
            // userControl
            // 
            this.userControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControl.Location = new System.Drawing.Point(199, 0);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(1273, 650);
            this.userControl.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 643);
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "HACK OH/IO demo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generalBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button mapBtn;
        private System.Windows.Forms.Panel userControl;
    }
}
