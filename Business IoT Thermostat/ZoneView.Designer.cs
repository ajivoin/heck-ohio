namespace Business_IoT_Thermostat {
    partial class ZoneView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelText = new System.Windows.Forms.Label();
            this.tempText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humidText = new System.Windows.Forms.Label();
            this.tempSet = new System.Windows.Forms.Label();
            this.btnRaiseSet = new System.Windows.Forms.Button();
            this.btnLowerSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(47, 57);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(73, 32);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Zone";
            // 
            // tempText
            // 
            this.tempText.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tempText.Location = new System.Drawing.Point(27, 131);
            this.tempText.Name = "tempText";
            this.tempText.Size = new System.Drawing.Size(285, 97);
            this.tempText.TabIndex = 2;
            this.tempText.Text = "70.8�";
            this.tempText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempText.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperature ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Humidity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // humidText
            // 
            this.humidText.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.humidText.Location = new System.Drawing.Point(288, 169);
            this.humidText.Name = "humidText";
            this.humidText.Size = new System.Drawing.Size(185, 49);
            this.humidText.TabIndex = 5;
            this.humidText.Text = "39%";
            this.humidText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempSet
            // 
            this.tempSet.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tempSet.Location = new System.Drawing.Point(104, 251);
            this.tempSet.Name = "tempSet";
            this.tempSet.Size = new System.Drawing.Size(124, 87);
            this.tempSet.TabIndex = 6;
            this.tempSet.Text = "70�";
            this.tempSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempSet.Click += new System.EventHandler(this.tempSet_Click);
            // 
            // btnRaiseSet
            // 
            this.btnRaiseSet.BackColor = System.Drawing.Color.Transparent;
            this.btnRaiseSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaiseSet.FlatAppearance.BorderSize = 0;
            this.btnRaiseSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiseSet.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiseSet.Location = new System.Drawing.Point(207, 270);
            this.btnRaiseSet.Name = "btnRaiseSet";
            this.btnRaiseSet.Size = new System.Drawing.Size(35, 49);
            this.btnRaiseSet.TabIndex = 7;
            this.btnRaiseSet.Text = ">";
            this.btnRaiseSet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRaiseSet.UseVisualStyleBackColor = false;
            this.btnRaiseSet.Click += new System.EventHandler(this.btnRaiseSet_Click);
            // 
            // btnLowerSet
            // 
            this.btnLowerSet.BackColor = System.Drawing.Color.Transparent;
            this.btnLowerSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLowerSet.FlatAppearance.BorderSize = 0;
            this.btnLowerSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowerSet.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowerSet.Location = new System.Drawing.Point(76, 270);
            this.btnLowerSet.Name = "btnLowerSet";
            this.btnLowerSet.Size = new System.Drawing.Size(44, 49);
            this.btnLowerSet.TabIndex = 8;
            this.btnLowerSet.Text = "<";
            this.btnLowerSet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLowerSet.UseVisualStyleBackColor = false;
            this.btnLowerSet.Click += new System.EventHandler(this.btnLowerSet_Click);
            // 
            // ZoneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLowerSet);
            this.Controls.Add(this.btnRaiseSet);
            this.Controls.Add(this.tempSet);
            this.Controls.Add(this.humidText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempText);
            this.Controls.Add(this.labelText);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ZoneView";
            this.Size = new System.Drawing.Size(1084, 838);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label tempText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label humidText;
        private System.Windows.Forms.Label tempSet;
        private System.Windows.Forms.Button btnRaiseSet;
        private System.Windows.Forms.Button btnLowerSet;
    }
}
