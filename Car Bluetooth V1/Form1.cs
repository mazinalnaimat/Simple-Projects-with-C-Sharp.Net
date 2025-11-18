using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Bluetooth_V1
{


    public partial class Form1 : Form
    {
        String[] Values = {"f","r","b","l"};
        string ValuesSensors = "11100";
        int MotorsChargeValue = 0;
        int PowerChargeValue = 0;
        int FirstInTimer3 = 0;
        bool FirstInTimer2 = false;


        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");

        }
  
        private void btnConnect_Click(object sender, EventArgs e)
        {
          
           if (!serialPort1.IsOpen)
            {

                this.Cursor = Cursors.WaitCursor;

                FirstInTimer2 = false;
                FirstInTimer3 = 0;
                try
                {
                   
                    // Open the serial port
                    serialPort1.Open();

                    // Write data to the serial port
                    serialPort1.WriteLine("###");

                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer3.Enabled = true;
                    pbCircle.Image = Properties.Resources.Green_Circle;
                    if (serialPort1.IsOpen)
                    {
                        if (tbSpeed.Value == 9)

                            serialPort1.WriteLine("q");
                        else
                            serialPort1.WriteLine((tbSpeed.Value + 1).ToString());
                    }

                }
                catch 
                {
                    MessageBox.Show("The serial Port is not connecting!!!", "Error", MessageBoxButtons.OK);
                    this.Cursor = Cursors.Default;
                }
                finally
                {
                    try
                    {// Close the serial port when done
                        //if (serialPort1.IsOpen)
                        //{
                        //    if (tbSpeed.Value == 9)

                        //        serialPort1.WriteLine("q");
                        //    else
                        //        serialPort1.WriteLine((tbSpeed.Value + 1).ToString());
                        //}
                    }
                    catch { }
                }

                //                Thread.Sleep(500);

                this.Cursor = Cursors.Default;

            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Value = 0;

        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //Value = -1;
            pbUpArrow.Image = Properties.Resources.White_up_Arrow;

        }
        private void pbRightArrow_MouseDown(object sender, MouseEventArgs e)
        {
           //Value = 1;
        }

        private void pbRightArrow_MouseUp(object sender, MouseEventArgs e)
        {
           //Value = -1;
            pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;
        }

        private void pbDownArrow_MouseDown(object sender, MouseEventArgs e)
        {
           //Value = 2;
        }

        private void pbDownArrow_MouseUp(object sender, MouseEventArgs e)
        {
           //Value = -1;
            pbDownArrow.Image = Properties.Resources.White_Down_Arrow;
        }

        private void pbLeftArrow_MouseDown(object sender, MouseEventArgs e)
        {
           //Value = 3;
        }

        private void pbLeftArrow_MouseUp(object sender, MouseEventArgs e)
        {
           //Value = -1;
            pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
        }
        private void txtCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Up)
            {
                MessageBox.Show("Key Press");
            }

        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            try {

                if (serialPort1.IsOpen)
                    if (tbSpeed.Value == 9)
                        serialPort1.WriteLine("q");

                    else     
                             serialPort1.WriteLine((tbSpeed.Value + 1).ToString());
                    
            }
            catch
            {

                serialPort1.Close();
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;

                pbCircle.Image = Properties.Resources.Red_Circle;
                pbarMotorsCharge.Value = 0;
                labMotorsCharge.Text = "0%";
                pbarPowerCharge.Value = 0;
                labPowerCharge.Text = "0%";
                pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;

                pbUpArrow.Image = Properties.Resources.White_up_Arrow;

                pbDownArrow.Image = Properties.Resources.White_Down_Arrow;

                pbRightFrontSensor.Image = Properties.Resources.Go;
                pbLeftFrontSensor.Image = Properties.Resources.Go;
                pbMiddleFrontSensor.Image = Properties.Resources.Go;
                pbRightBackSensor.Image = Properties.Resources.Go;
                pbLeftBackSensor.Image = Properties.Resources.Go;

                Values[0] = "f";
                Values[1] = "r";
                Values[2] = "b";
                Values[3] = "l";
                MessageBox.Show("Serial port closed. sspeed");
            }
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W )
                Values[0] = "f";

            if (e.KeyCode == Keys.S)
                Values[2] = "b";

            if (e.KeyCode == Keys.D)
                Values[1] = "r";

            if (e.KeyCode == Keys.A)
                Values[3] = "l";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Focus();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.W)
                Values[0] = "F";

            else if (keyData == Keys.S)
                Values[2] = "B";

            else if (keyData  == Keys.D)
                Values[1] = "R";

            else if (keyData == Keys.A)
                Values[3] = "L";

            

            if(keyData == Keys.Right && tbSpeed.Value <9)
            {
                tbSpeed.Value = ++tbSpeed.Value;
            }
            else if (keyData == Keys.Left && tbSpeed.Value >0)
            {
                tbSpeed.Value = --tbSpeed.Value;
            }

            return true;

           // return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Focus();
            try
            {
              
                if (serialPort1.IsOpen)
                {


                    // serialPort1.WriteLine("9");

                    if (Values[0] == "F" && Values[1] == "r" && Values[3] == "l" && Values[2] == "b")
                    {
                        int Distance = 0;

                        serialPort1.WriteLine("F");

                      //  Distance = (serialPort1.ReadByte());
                      //  Distance += Distance << 8 + serialPort1.ReadByte();
                        labDistanceValue.Text = Distance.ToString();
                        labDistanceValue.Text += " cm";
                        pbUpArrow.Image = Properties.Resources.Red_Up_Arrow;
                        pbDownArrow.Image = Properties.Resources.White_Down_Arrow;
                        pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                        pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;

                    }
                    else if (Values[0] == "f" && Values[1] == "r" && Values[3] == "l" && Values[2] == "B")
                    {
                        serialPort1.WriteLine("B");
                        pbUpArrow.Image = Properties.Resources.White_up_Arrow;
                        pbDownArrow.Image = Properties.Resources.Red_Down_Arrowy_;
                        pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                        pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;
                    }

                    else if (Values[1] == "R" && Values[3] == "l")
                    {
                        serialPort1.WriteLine("R");
                        pbRightArrow.Image = Properties.Resources.Red_Right_Arrow;
                        pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                        if (Values[0] == "f")
                            pbUpArrow.Image = Properties.Resources.White_up_Arrow;
                        else
                            pbUpArrow.Image = Properties.Resources.Red_Up_Arrow;

                        if (Values[2] == "b")
                            pbDownArrow.Image = Properties.Resources.White_Down_Arrow;
                        else
                            pbDownArrow.Image = Properties.Resources.Red_Down_Arrowy_;

                    }

                    else if (Values[1] == "r" && Values[3] == "L")
                    {
                        serialPort1.WriteLine("L");
                        pbLeftArrow.Image = Properties.Resources.Red_Left_Arrow_;
                        pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;
                        if (Values[0] == "f")
                            pbUpArrow.Image = Properties.Resources.White_up_Arrow;
                        else
                            pbUpArrow.Image = Properties.Resources.Red_Up_Arrow;

                        if (Values[2] == "b")
                            pbDownArrow.Image = Properties.Resources.White_Down_Arrow;
                        else
                            pbDownArrow.Image = Properties.Resources.Red_Down_Arrowy_;

                    }
                    else if (Values[0] == "f" && Values[1] == "r" && Values[3] == "l" && Values[2] == "b")

                    {

                        serialPort1.WriteLine("S");
                        pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                        pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;

                        pbUpArrow.Image = Properties.Resources.White_up_Arrow;

                        pbDownArrow.Image = Properties.Resources.White_Down_Arrow;

                    }


                }

            }
            catch
            {

                serialPort1.Close();
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;

                pbCircle.Image = Properties.Resources.Red_Circle;
                pbarMotorsCharge.Value = 0;
                labMotorsCharge.Text = "0%";
                pbarPowerCharge.Value = 0;
                labPowerCharge.Text = "0%";
                pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;

                pbUpArrow.Image = Properties.Resources.White_up_Arrow;

                pbDownArrow.Image = Properties.Resources.White_Down_Arrow;
                pbRightFrontSensor.Image = Properties.Resources.Go;
                pbLeftFrontSensor.Image = Properties.Resources.Go;
                pbMiddleFrontSensor.Image = Properties.Resources.Go;
                pbRightBackSensor.Image = Properties.Resources.Go;
                pbLeftBackSensor.Image = Properties.Resources.Go;


                Values[0] = "f";
                Values[1] = "r";
                Values[2] = "b";
                Values[3] = "l";

                MessageBox.Show("Serial port closed. timer1");
            }
            finally
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                if (serialPort1.IsOpen )
                {
                  
                    if ((Values[0] == "f" && Values[1] == "r" && Values[3] == "l" && Values[2] == "b"))
                    {
                        int PreviousMotorChargeValue = MotorsChargeValue;
                        int PreviousPowerChargeValue = PowerChargeValue;

                        serialPort1.WriteLine("z");
                        MotorsChargeValue = serialPort1.ReadByte();
                        PowerChargeValue = serialPort1.ReadByte();
                        if (MotorsChargeValue <= 100 && PreviousMotorChargeValue - MotorsChargeValue < 2)
                            pbarMotorsCharge.Value = ((MotorsChargeValue));
                        labMotorsCharge.Text = (pbarMotorsCharge.Value.ToString()) + "%";

                        if (PowerChargeValue <= 100 && PreviousPowerChargeValue - PowerChargeValue < 2)
                            pbarPowerCharge.Value = ((PowerChargeValue));
                        labPowerCharge.Text = (pbarPowerCharge.Value.ToString()) + "%";
                    }
                }

            }
            catch
            {
                if(FirstInTimer2 == true)
                { 
                serialPort1.Close();
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;

                pbCircle.Image = Properties.Resources.Red_Circle;
                pbarMotorsCharge.Value = 0;
                labMotorsCharge.Text = "0%";
                pbarPowerCharge.Value = 0;
                labPowerCharge.Text = "0%";
                pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;

                pbUpArrow.Image = Properties.Resources.White_up_Arrow;

                pbDownArrow.Image = Properties.Resources.White_Down_Arrow;

                pbRightFrontSensor.Image = Properties.Resources.Go;
                pbLeftFrontSensor.Image = Properties.Resources.Go;
                pbMiddleFrontSensor.Image = Properties.Resources.Go;
                pbRightBackSensor.Image = Properties.Resources.Go;
                pbLeftBackSensor.Image = Properties.Resources.Go;

                Values[0] = "f";
                Values[1] = "r";
                Values[2] = "b";
                Values[3] = "l";

                MessageBox.Show("Serial port closed. timer2");

            }
            FirstInTimer2 = true;
        }
          

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {


                
                    serialPort1.WriteLine("i");
                 
                    ValuesSensors = (Convert.ToChar(serialPort1.ReadByte())).ToString();



                    while (ValuesSensors[ValuesSensors.Length - 1] != 0)
                    {
                        ValuesSensors += (Convert.ToChar(serialPort1.ReadByte())).ToString();
                    }

                    if (ValuesSensors[0] == '0')
                        pbLeftFrontSensor.Image = Properties.Resources.Go;
                    else
                        pbLeftFrontSensor.Image = Properties.Resources.Stop;

                    if (ValuesSensors[1] == '0')
                        pbMiddleFrontSensor.Image = Properties.Resources.Go;
                    else
                        pbMiddleFrontSensor.Image = Properties.Resources.Stop;

                    if (ValuesSensors[2] == '0')
                        pbRightFrontSensor.Image = Properties.Resources.Go;
                    else
                        pbRightFrontSensor.Image = Properties.Resources.Stop;

                    if (ValuesSensors[3] == '1')
                        pbLeftBackSensor.Image = Properties.Resources.Go;
                    else
                        pbLeftBackSensor.Image = Properties.Resources.Stop;
                    if (ValuesSensors[4] == '1')
                        pbRightBackSensor.Image = Properties.Resources.Go;
                    else
                        pbRightBackSensor.Image = Properties.Resources.Stop;
                }

            }
            catch
            {
                if (FirstInTimer3 >50)

                {
                    serialPort1.Close();
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;

                    pbCircle.Image = Properties.Resources.Red_Circle;
                    pbarMotorsCharge.Value = 0;
                    labMotorsCharge.Text = "0%";
                    pbarPowerCharge.Value = 0;
                    labPowerCharge.Text = "0%";
                    pbLeftArrow.Image = Properties.Resources.White_Left_Arrow_;
                    pbRightArrow.Image = Properties.Resources.White_Right_Arrow_;

                    pbUpArrow.Image = Properties.Resources.White_up_Arrow;

                    pbDownArrow.Image = Properties.Resources.White_Down_Arrow;



                    Values[0] = "f";
                    Values[1] = "r";
                    Values[2] = "b";
                    Values[3] = "l";

                    MessageBox.Show("Serial port closed. timer3");
                }
                FirstInTimer3+=1;

            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {

        }



        //// private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        // {
        //     //MessageBox.Show("Hi 0000000");
        // }
    }
}
