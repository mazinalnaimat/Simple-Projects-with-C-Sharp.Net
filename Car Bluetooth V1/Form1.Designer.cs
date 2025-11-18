namespace Car_Bluetooth_V1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pbUpArrow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbLeftArrow = new System.Windows.Forms.PictureBox();
            this.pbDownArrow = new System.Windows.Forms.PictureBox();
            this.pbRightArrow = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.pbarMotorsCharge = new System.Windows.Forms.ProgressBar();
            this.labMotorsCharge = new System.Windows.Forms.Label();
            this.pbLeftFrontSensor = new System.Windows.Forms.PictureBox();
            this.pbRightFrontSensor = new System.Windows.Forms.PictureBox();
            this.pbMiddleFrontSensor = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pbLeftBackSensor = new System.Windows.Forms.PictureBox();
            this.pbRightBackSensor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labPowerCharge = new System.Windows.Forms.Label();
            this.pbarPowerCharge = new System.Windows.Forms.ProgressBar();
            this.labDistanceValue = new System.Windows.Forms.Label();
            this.labDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftFrontSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightFrontSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleFrontSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftBackSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightBackSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadBufferSize = 1024;
            this.serialPort1.ReadTimeout = 200;
            this.serialPort1.WriteBufferSize = 512;
            this.serialPort1.WriteTimeout = 200;
            // 
            // pbCircle
            // 
            this.pbCircle.Image = global::Car_Bluetooth_V1.Properties.Resources.Red_Circle;
            this.pbCircle.Location = new System.Drawing.Point(119, 20);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(107, 91);
            this.pbCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCircle.TabIndex = 4;
            this.pbCircle.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(934, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 58);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pbUpArrow
            // 
            this.pbUpArrow.Image = global::Car_Bluetooth_V1.Properties.Resources.White_up_Arrow;
            this.pbUpArrow.Location = new System.Drawing.Point(484, 288);
            this.pbUpArrow.Name = "pbUpArrow";
            this.pbUpArrow.Size = new System.Drawing.Size(141, 114);
            this.pbUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpArrow.TabIndex = 10;
            this.pbUpArrow.TabStop = false;
            this.pbUpArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbUpArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbLeftArrow
            // 
            this.pbLeftArrow.Image = global::Car_Bluetooth_V1.Properties.Resources.White_Left_Arrow_;
            this.pbLeftArrow.Location = new System.Drawing.Point(257, 405);
            this.pbLeftArrow.Name = "pbLeftArrow";
            this.pbLeftArrow.Size = new System.Drawing.Size(141, 114);
            this.pbLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftArrow.TabIndex = 11;
            this.pbLeftArrow.TabStop = false;
            this.pbLeftArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLeftArrow_MouseDown);
            this.pbLeftArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLeftArrow_MouseUp);
            // 
            // pbDownArrow
            // 
            this.pbDownArrow.Image = global::Car_Bluetooth_V1.Properties.Resources.White_Down_Arrow;
            this.pbDownArrow.Location = new System.Drawing.Point(484, 557);
            this.pbDownArrow.Name = "pbDownArrow";
            this.pbDownArrow.Size = new System.Drawing.Size(141, 114);
            this.pbDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDownArrow.TabIndex = 12;
            this.pbDownArrow.TabStop = false;
            this.pbDownArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDownArrow_MouseDown);
            this.pbDownArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDownArrow_MouseUp);
            // 
            // pbRightArrow
            // 
            this.pbRightArrow.Image = global::Car_Bluetooth_V1.Properties.Resources.White_Right_Arrow_;
            this.pbRightArrow.Location = new System.Drawing.Point(699, 405);
            this.pbRightArrow.Name = "pbRightArrow";
            this.pbRightArrow.Size = new System.Drawing.Size(141, 114);
            this.pbRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightArrow.TabIndex = 13;
            this.pbRightArrow.TabStop = false;
            this.pbRightArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRightArrow_MouseDown);
            this.pbRightArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRightArrow_MouseUp);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbSpeed
            // 
            this.tbSpeed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbSpeed.LargeChange = 1;
            this.tbSpeed.Location = new System.Drawing.Point(920, 297);
            this.tbSpeed.Maximum = 9;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(221, 56);
            this.tbSpeed.TabIndex = 16;
            this.tbSpeed.TabStop = false;
            this.tbSpeed.Value = 9;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // pbarMotorsCharge
            // 
            this.pbarMotorsCharge.BackColor = System.Drawing.Color.White;
            this.pbarMotorsCharge.Location = new System.Drawing.Point(93, 649);
            this.pbarMotorsCharge.Name = "pbarMotorsCharge";
            this.pbarMotorsCharge.Size = new System.Drawing.Size(293, 48);
            this.pbarMotorsCharge.TabIndex = 18;
            // 
            // labMotorsCharge
            // 
            this.labMotorsCharge.AutoSize = true;
            this.labMotorsCharge.BackColor = System.Drawing.Color.Transparent;
            this.labMotorsCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labMotorsCharge.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labMotorsCharge.ForeColor = System.Drawing.Color.White;
            this.labMotorsCharge.Location = new System.Drawing.Point(324, 598);
            this.labMotorsCharge.Name = "labMotorsCharge";
            this.labMotorsCharge.Size = new System.Drawing.Size(64, 48);
            this.labMotorsCharge.TabIndex = 17;
            this.labMotorsCharge.Text = "0%";
            this.labMotorsCharge.UseCompatibleTextRendering = true;
            // 
            // pbLeftFrontSensor
            // 
            this.pbLeftFrontSensor.Image = global::Car_Bluetooth_V1.Properties.Resources.Go;
            this.pbLeftFrontSensor.Location = new System.Drawing.Point(350, 32);
            this.pbLeftFrontSensor.Name = "pbLeftFrontSensor";
            this.pbLeftFrontSensor.Size = new System.Drawing.Size(121, 90);
            this.pbLeftFrontSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftFrontSensor.TabIndex = 20;
            this.pbLeftFrontSensor.TabStop = false;
            // 
            // pbRightFrontSensor
            // 
            this.pbRightFrontSensor.Image = global::Car_Bluetooth_V1.Properties.Resources.Go;
            this.pbRightFrontSensor.Location = new System.Drawing.Point(699, 32);
            this.pbRightFrontSensor.Name = "pbRightFrontSensor";
            this.pbRightFrontSensor.Size = new System.Drawing.Size(121, 90);
            this.pbRightFrontSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightFrontSensor.TabIndex = 21;
            this.pbRightFrontSensor.TabStop = false;
            // 
            // pbMiddleFrontSensor
            // 
            this.pbMiddleFrontSensor.Image = global::Car_Bluetooth_V1.Properties.Resources.Go;
            this.pbMiddleFrontSensor.Location = new System.Drawing.Point(530, 32);
            this.pbMiddleFrontSensor.Name = "pbMiddleFrontSensor";
            this.pbMiddleFrontSensor.Size = new System.Drawing.Size(121, 90);
            this.pbMiddleFrontSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiddleFrontSensor.TabIndex = 22;
            this.pbMiddleFrontSensor.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pbLeftBackSensor
            // 
            this.pbLeftBackSensor.Image = global::Car_Bluetooth_V1.Properties.Resources.Go;
            this.pbLeftBackSensor.Location = new System.Drawing.Point(358, 720);
            this.pbLeftBackSensor.Name = "pbLeftBackSensor";
            this.pbLeftBackSensor.Size = new System.Drawing.Size(121, 90);
            this.pbLeftBackSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftBackSensor.TabIndex = 23;
            this.pbLeftBackSensor.TabStop = false;
            // 
            // pbRightBackSensor
            // 
            this.pbRightBackSensor.Image = global::Car_Bluetooth_V1.Properties.Resources.Go;
            this.pbRightBackSensor.Location = new System.Drawing.Point(645, 720);
            this.pbRightBackSensor.Name = "pbRightBackSensor";
            this.pbRightBackSensor.Size = new System.Drawing.Size(121, 90);
            this.pbRightBackSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightBackSensor.TabIndex = 24;
            this.pbRightBackSensor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(93, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 41);
            this.label1.TabIndex = 25;
            this.label1.Text = "Motors Charge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(710, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 41);
            this.label2.TabIndex = 28;
            this.label2.Text = "Power Charge";
            // 
            // labPowerCharge
            // 
            this.labPowerCharge.AutoSize = true;
            this.labPowerCharge.BackColor = System.Drawing.Color.Transparent;
            this.labPowerCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPowerCharge.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labPowerCharge.ForeColor = System.Drawing.Color.White;
            this.labPowerCharge.Location = new System.Drawing.Point(941, 583);
            this.labPowerCharge.Name = "labPowerCharge";
            this.labPowerCharge.Size = new System.Drawing.Size(64, 48);
            this.labPowerCharge.TabIndex = 26;
            this.labPowerCharge.Text = "0%";
            this.labPowerCharge.UseCompatibleTextRendering = true;
            // 
            // pbarPowerCharge
            // 
            this.pbarPowerCharge.BackColor = System.Drawing.Color.White;
            this.pbarPowerCharge.Location = new System.Drawing.Point(710, 634);
            this.pbarPowerCharge.Name = "pbarPowerCharge";
            this.pbarPowerCharge.Size = new System.Drawing.Size(293, 48);
            this.pbarPowerCharge.TabIndex = 27;
            // 
            // labDistanceValue
            // 
            this.labDistanceValue.AutoSize = true;
            this.labDistanceValue.BackColor = System.Drawing.Color.Transparent;
            this.labDistanceValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDistanceValue.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labDistanceValue.ForeColor = System.Drawing.Color.White;
            this.labDistanceValue.Location = new System.Drawing.Point(550, 184);
            this.labDistanceValue.Name = "labDistanceValue";
            this.labDistanceValue.Size = new System.Drawing.Size(86, 48);
            this.labDistanceValue.TabIndex = 30;
            this.labDistanceValue.Text = "0 cm";
            this.labDistanceValue.UseCompatibleTextRendering = true;
            // 
            // labDistance
            // 
            this.labDistance.AutoSize = true;
            this.labDistance.BackColor = System.Drawing.Color.Transparent;
            this.labDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDistance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labDistance.ForeColor = System.Drawing.Color.White;
            this.labDistance.Location = new System.Drawing.Point(358, 184);
            this.labDistance.Name = "labDistance";
            this.labDistance.Size = new System.Drawing.Size(153, 48);
            this.labDistance.TabIndex = 31;
            this.labDistance.Text = "Distance:";
            this.labDistance.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Bluetooth_V1.Properties.Resources.Black_Bcakground;
            this.ClientSize = new System.Drawing.Size(1193, 847);
            this.Controls.Add(this.labDistance);
            this.Controls.Add(this.labDistanceValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labPowerCharge);
            this.Controls.Add(this.pbarPowerCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRightBackSensor);
            this.Controls.Add(this.pbLeftBackSensor);
            this.Controls.Add(this.pbMiddleFrontSensor);
            this.Controls.Add(this.pbRightFrontSensor);
            this.Controls.Add(this.pbLeftFrontSensor);
            this.Controls.Add(this.labMotorsCharge);
            this.Controls.Add(this.pbarMotorsCharge);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.pbRightArrow);
            this.Controls.Add(this.pbDownArrow);
            this.Controls.Add(this.pbLeftArrow);
            this.Controls.Add(this.pbUpArrow);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pbCircle);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Bluetooth Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftFrontSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightFrontSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiddleFrontSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftBackSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightBackSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.PictureBox pbUpArrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbLeftArrow;
        private System.Windows.Forms.PictureBox pbDownArrow;
        private System.Windows.Forms.PictureBox pbRightArrow;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar pbarMotorsCharge;
        private System.Windows.Forms.Label labMotorsCharge;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.PictureBox pbLeftFrontSensor;
        private System.Windows.Forms.PictureBox pbRightFrontSensor;
        private System.Windows.Forms.PictureBox pbMiddleFrontSensor;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pbLeftBackSensor;
        private System.Windows.Forms.PictureBox pbRightBackSensor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPowerCharge;
        private System.Windows.Forms.ProgressBar pbarPowerCharge;
        public System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labDistanceValue;
        private System.Windows.Forms.Label labDistance;
    }
}

