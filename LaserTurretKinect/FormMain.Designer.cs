namespace LaserTurretKinect
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hScrollBar2y = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1y = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1z = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2x = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1x = new System.Windows.Forms.HScrollBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelXY = new System.Windows.Forms.Label();
            this.hScrollBarSpeed = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelXY);
            this.groupBox1.Controls.Add(this.labelZ);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Head tracking";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(264, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelZ
            // 
            this.labelZ.Location = new System.Drawing.Point(294, 28);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(86, 23);
            this.labelZ.TabIndex = 1;
            this.labelZ.Text = "N/A";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelY
            // 
            this.labelY.Location = new System.Drawing.Point(172, 28);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(86, 23);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "N/A";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelX
            // 
            this.labelX.Location = new System.Drawing.Point(50, 28);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(86, 23);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "N/A";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(62, 101);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(75, 21);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Turret:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(143, 100);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(224, 100);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hScrollBar2y);
            this.groupBox2.Controls.Add(this.hScrollBar1y);
            this.groupBox2.Controls.Add(this.hScrollBar1z);
            this.groupBox2.Controls.Add(this.hScrollBar2x);
            this.groupBox2.Controls.Add(this.hScrollBar1x);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servo calibration";
            // 
            // hScrollBar2y
            // 
            this.hScrollBar2y.Location = new System.Drawing.Point(50, 148);
            this.hScrollBar2y.Name = "hScrollBar2y";
            this.hScrollBar2y.Size = new System.Drawing.Size(490, 17);
            this.hScrollBar2y.TabIndex = 0;
            this.hScrollBar2y.Value = 50;
            // 
            // hScrollBar1y
            // 
            this.hScrollBar1y.Location = new System.Drawing.Point(50, 84);
            this.hScrollBar1y.Maximum = 0;
            this.hScrollBar1y.Minimum = -100;
            this.hScrollBar1y.Name = "hScrollBar1y";
            this.hScrollBar1y.Size = new System.Drawing.Size(490, 17);
            this.hScrollBar1y.TabIndex = 0;
            this.hScrollBar1y.Value = -50;
            // 
            // hScrollBar1z
            // 
            this.hScrollBar1z.Location = new System.Drawing.Point(50, 22);
            this.hScrollBar1z.Minimum = -100;
            this.hScrollBar1z.Name = "hScrollBar1z";
            this.hScrollBar1z.Size = new System.Drawing.Size(490, 17);
            this.hScrollBar1z.TabIndex = 0;
            this.hScrollBar1z.Value = -20;
            // 
            // hScrollBar2x
            // 
            this.hScrollBar2x.Location = new System.Drawing.Point(50, 128);
            this.hScrollBar2x.Name = "hScrollBar2x";
            this.hScrollBar2x.Size = new System.Drawing.Size(490, 17);
            this.hScrollBar2x.TabIndex = 0;
            this.hScrollBar2x.Value = 50;
            // 
            // hScrollBar1x
            // 
            this.hScrollBar1x.Location = new System.Drawing.Point(50, 64);
            this.hScrollBar1x.Maximum = 0;
            this.hScrollBar1x.Minimum = -100;
            this.hScrollBar1x.Name = "hScrollBar1x";
            this.hScrollBar1x.Size = new System.Drawing.Size(490, 17);
            this.hScrollBar1x.TabIndex = 0;
            this.hScrollBar1x.Value = -50;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(20, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Y:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Z:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bottom right corner:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "X:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Top left corner:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "X:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(396, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "(X,Y):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelXY
            // 
            this.labelXY.Location = new System.Drawing.Point(452, 28);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(114, 23);
            this.labelXY.TabIndex = 1;
            this.labelXY.Text = "N/A";
            this.labelXY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hScrollBarSpeed
            // 
            this.hScrollBarSpeed.Location = new System.Drawing.Point(393, 105);
            this.hScrollBarSpeed.Maximum = 1000;
            this.hScrollBarSpeed.Minimum = 1;
            this.hScrollBarSpeed.Name = "hScrollBarSpeed";
            this.hScrollBarSpeed.Size = new System.Drawing.Size(201, 17);
            this.hScrollBarSpeed.TabIndex = 0;
            this.hScrollBarSpeed.Value = 100;
            this.hScrollBarSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarSpeed_Scroll);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(333, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Speed:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.hScrollBarSpeed);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Laser Turret Kinect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1y;
        private System.Windows.Forms.HScrollBar hScrollBar1z;
        private System.Windows.Forms.HScrollBar hScrollBar1x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hScrollBar2y;
        private System.Windows.Forms.HScrollBar hScrollBar2x;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelXY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.HScrollBar hScrollBarSpeed;
        private System.Windows.Forms.Label label10;
    }
}

