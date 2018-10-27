namespace Business_IoT_Thermostat {
    partial class MapView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapView));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxFloor = new System.Windows.Forms.ComboBox();
            this.floor1 = new System.Windows.Forms.PictureBox();
            this.floor0 = new System.Windows.Forms.PictureBox();
            this.floor2 = new System.Windows.Forms.PictureBox();
            this.zone01 = new System.Windows.Forms.PictureBox();
            this.zone00 = new System.Windows.Forms.PictureBox();
            this.zone10 = new System.Windows.Forms.PictureBox();
            this.zone11 = new System.Windows.Forms.PictureBox();
            this.zone12 = new System.Windows.Forms.PictureBox();
            this.zone21 = new System.Windows.Forms.PictureBox();
            this.zone20 = new System.Windows.Forms.PictureBox();
            this.zone22 = new System.Windows.Forms.PictureBox();
            this.userControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone22)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Building Layout";
            this.label1.UseWaitCursor = true;
            // 
            // cboxFloor
            // 
            this.cboxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFloor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFloor.FormattingEnabled = true;
            this.cboxFloor.Items.AddRange(new object[] {
            "Floor 0",
            "Floor 1",
            "Floor 2"});
            this.cboxFloor.Location = new System.Drawing.Point(302, 72);
            this.cboxFloor.Name = "cboxFloor";
            this.cboxFloor.Size = new System.Drawing.Size(148, 33);
            this.cboxFloor.TabIndex = 2;
            this.cboxFloor.SelectedIndexChanged += new System.EventHandler(this.cboxFloor_SelectedIndexChanged);
            // 
            // floor1
            // 
            this.floor1.BackColor = System.Drawing.Color.Transparent;
            this.floor1.Image = ((System.Drawing.Image)(resources.GetObject("floor1.Image")));
            this.floor1.InitialImage = ((System.Drawing.Image)(resources.GetObject("floor1.InitialImage")));
            this.floor1.Location = new System.Drawing.Point(34, 105);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(473, 395);
            this.floor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor1.TabIndex = 3;
            this.floor1.TabStop = false;
            // 
            // floor0
            // 
            this.floor0.BackColor = System.Drawing.Color.Transparent;
            this.floor0.Image = ((System.Drawing.Image)(resources.GetObject("floor0.Image")));
            this.floor0.InitialImage = ((System.Drawing.Image)(resources.GetObject("floor0.InitialImage")));
            this.floor0.Location = new System.Drawing.Point(34, 105);
            this.floor0.Name = "floor0";
            this.floor0.Size = new System.Drawing.Size(473, 395);
            this.floor0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor0.TabIndex = 4;
            this.floor0.TabStop = false;
            // 
            // floor2
            // 
            this.floor2.BackColor = System.Drawing.Color.Transparent;
            this.floor2.Image = ((System.Drawing.Image)(resources.GetObject("floor2.Image")));
            this.floor2.InitialImage = ((System.Drawing.Image)(resources.GetObject("floor2.InitialImage")));
            this.floor2.Location = new System.Drawing.Point(34, 105);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(473, 395);
            this.floor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor2.TabIndex = 5;
            this.floor2.TabStop = false;
            // 
            // zone01
            // 
            this.zone01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone01.Location = new System.Drawing.Point(109, 155);
            this.zone01.Name = "zone01";
            this.zone01.Size = new System.Drawing.Size(327, 180);
            this.zone01.TabIndex = 6;
            this.zone01.TabStop = false;
            this.zone01.Click += new System.EventHandler(this.zone01_Click);
            // 
            // zone00
            // 
            this.zone00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone00.Location = new System.Drawing.Point(194, 155);
            this.zone00.Name = "zone00";
            this.zone00.Size = new System.Drawing.Size(242, 302);
            this.zone00.TabIndex = 7;
            this.zone00.TabStop = false;
            this.zone00.Click += new System.EventHandler(this.zone00_Click);
            // 
            // zone10
            // 
            this.zone10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone10.Location = new System.Drawing.Point(109, 155);
            this.zone10.Name = "zone10";
            this.zone10.Size = new System.Drawing.Size(327, 180);
            this.zone10.TabIndex = 8;
            this.zone10.TabStop = false;
            this.zone10.Click += new System.EventHandler(this.zone10_Click);
            // 
            // zone11
            // 
            this.zone11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone11.Location = new System.Drawing.Point(194, 349);
            this.zone11.Name = "zone11";
            this.zone11.Size = new System.Drawing.Size(127, 108);
            this.zone11.TabIndex = 9;
            this.zone11.TabStop = false;
            this.zone11.Click += new System.EventHandler(this.zone11_Click);
            // 
            // zone12
            // 
            this.zone12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone12.Location = new System.Drawing.Point(337, 349);
            this.zone12.Name = "zone12";
            this.zone12.Size = new System.Drawing.Size(99, 108);
            this.zone12.TabIndex = 10;
            this.zone12.TabStop = false;
            this.zone12.Click += new System.EventHandler(this.zone12_Click);
            // 
            // zone21
            // 
            this.zone21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone21.Location = new System.Drawing.Point(337, 155);
            this.zone21.Name = "zone21";
            this.zone21.Size = new System.Drawing.Size(99, 302);
            this.zone21.TabIndex = 11;
            this.zone21.TabStop = false;
            this.zone21.Click += new System.EventHandler(this.zone21_Click);
            // 
            // zone20
            // 
            this.zone20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone20.Location = new System.Drawing.Point(109, 155);
            this.zone20.Name = "zone20";
            this.zone20.Size = new System.Drawing.Size(212, 180);
            this.zone20.TabIndex = 12;
            this.zone20.TabStop = false;
            this.zone20.Click += new System.EventHandler(this.zone20_Click);
            // 
            // zone22
            // 
            this.zone22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.zone22.Location = new System.Drawing.Point(194, 349);
            this.zone22.Name = "zone22";
            this.zone22.Size = new System.Drawing.Size(127, 108);
            this.zone22.TabIndex = 13;
            this.zone22.TabStop = false;
            this.zone22.Click += new System.EventHandler(this.zone22_Click);
            // 
            // userControl
            // 
            this.userControl.Location = new System.Drawing.Point(468, 3);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(556, 595);
            this.userControl.TabIndex = 14;
            // 
            // MapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.cboxFloor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zone00);
            this.Controls.Add(this.zone01);
            this.Controls.Add(this.zone21);
            this.Controls.Add(this.zone20);
            this.Controls.Add(this.zone22);
            this.Controls.Add(this.zone10);
            this.Controls.Add(this.zone11);
            this.Controls.Add(this.zone12);
            this.Controls.Add(this.floor1);
            this.Controls.Add(this.floor2);
            this.Controls.Add(this.floor0);
            this.Name = "MapView";
            this.Size = new System.Drawing.Size(1024, 598);
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxFloor;
        private System.Windows.Forms.PictureBox floor1;
        private System.Windows.Forms.PictureBox floor0;
        private System.Windows.Forms.PictureBox floor2;
        private System.Windows.Forms.PictureBox zone01;
        private System.Windows.Forms.PictureBox zone00;
        private System.Windows.Forms.PictureBox zone10;
        private System.Windows.Forms.PictureBox zone11;
        private System.Windows.Forms.PictureBox zone12;
        private System.Windows.Forms.PictureBox zone21;
        private System.Windows.Forms.PictureBox zone20;
        private System.Windows.Forms.PictureBox zone22;
        private System.Windows.Forms.Panel userControl;
    }
}
