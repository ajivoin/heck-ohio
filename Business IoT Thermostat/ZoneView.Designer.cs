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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelText = new System.Windows.Forms.Label();
            this.tempText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humidText = new System.Windows.Forms.Label();
            this.tempSet = new System.Windows.Forms.Label();
            this.btnRaiseSet = new System.Windows.Forms.Button();
            this.btnLowerSet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.devicesLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.graph2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graph2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(47, 57);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(58, 25);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Zone";
            // 
            // tempText
            // 
            this.tempText.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tempText.Location = new System.Drawing.Point(20, 141);
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
            this.label1.Location = new System.Drawing.Point(59, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Temp.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Humidity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // humidText
            // 
            this.humidText.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.humidText.Location = new System.Drawing.Point(284, 271);
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
            this.tempSet.Location = new System.Drawing.Point(293, 141);
            this.tempSet.Name = "tempSet";
            this.tempSet.Size = new System.Drawing.Size(151, 87);
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
            this.btnRaiseSet.Location = new System.Drawing.Point(396, 164);
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
            this.btnLowerSet.Location = new System.Drawing.Point(287, 164);
            this.btnLowerSet.Name = "btnLowerSet";
            this.btnLowerSet.Size = new System.Drawing.Size(44, 49);
            this.btnLowerSet.TabIndex = 8;
            this.btnLowerSet.Text = "<";
            this.btnLowerSet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLowerSet.UseVisualStyleBackColor = false;
            this.btnLowerSet.Click += new System.EventHandler(this.btnLowerSet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set Temp.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Devices In Zone";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devicesLabel
            // 
            this.devicesLabel.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.devicesLabel.Location = new System.Drawing.Point(40, 271);
            this.devicesLabel.Name = "devicesLabel";
            this.devicesLabel.Size = new System.Drawing.Size(185, 49);
            this.devicesLabel.TabIndex = 11;
            this.devicesLabel.Text = "0";
            this.devicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graph2
            // 
            this.graph2.BorderlineWidth = 0;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BorderColor = System.Drawing.Color.Maroon;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.graph2.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.MaximumAutoSize = 20F;
            legend2.Name = "Legend1";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend2.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graph2.Legends.Add(legend2);
            this.graph2.Location = new System.Drawing.Point(15, 371);
            this.graph2.Margin = new System.Windows.Forms.Padding(4);
            this.graph2.Name = "graph2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.LightSkyBlue;
            series2.Legend = "Legend1";
            series2.Name = "Temperature (°F)";
            series2.YValuesPerPoint = 32;
            this.graph2.Series.Add(series2);
            this.graph2.Size = new System.Drawing.Size(454, 326);
            this.graph2.TabIndex = 21;
            this.graph2.Text = "chart2";
            this.graph2.Click += new System.EventHandler(this.graph2_Click);
            // 
            // ZoneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graph2);
            this.Controls.Add(this.devicesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Size = new System.Drawing.Size(484, 838);
            ((System.ComponentModel.ISupportInitialize)(this.graph2)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label devicesLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph2;
    }
}
