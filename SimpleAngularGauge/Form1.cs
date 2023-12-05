using System;
using System.Threading;
using System.Windows.Forms;
using LiveCharts.WinForms;


// This is simple example of how the LiveChart2 library's Angular Gauge works and how you can build and animate them to represent your
// telemetry data.

// It is important that you read the readme.md file within the Github repository as threads are necessary for animating these gauges.

// If the Angular Gauge is not available in the Deigner Toolbox, follow this codebase.

namespace SimpleAngularGauge
{
    public partial class Form1 : Form
    {
        // Create the three gauges
        AngularGauge gaugeAlititude = new AngularGauge();
        AngularGauge    gaugeVspeed = new AngularGauge();
        AngularGauge     gaugeSpeed = new AngularGauge();

        // create random number obj
        private Random rand = new Random();

        // boolean for the loop
        private bool looping = true;

        // stops thread event.
        private ManualResetEvent stopEvent = new ManualResetEvent(false);

        public Form1()
        {
            InitializeComponent();

            // build Needles on start up
            BuildNeedles();
        }

        private void BuildNeedles()
        {
            // these methods build the guages.
            SetLocation();
            Controls_Add();
            SetSize();
            SetbackgeoundImage();
            SetFromToValue();
            BringToTheFront();
            SetInvalidate();
        }

        // for simplicity, I have placed down 3 pictureboxes and sized them to my liking. I have then added an image to that 
        // picturebox. this allows me to see how the gauge will look. I also use all the attributes from the picturebox to design 
        // the gauage.

        // If you have the Angular Gauge in your toolbox (form1.cs[design]) go ahead and drag and drop the gauge instead of a picturebox.
        // However, if the gauge does not appear in the designer toolbox after nuiget installation, use the picturebox method.

        // This sets the location of the gauges via the picturebox. 
        private void SetLocation()
        {
            gaugeAlititude.Location = pictureBoxAltitude.Location;
               gaugeVspeed.Location = pictureBoxVspeed.Location;
                gaugeSpeed.Location = pictureBoxSpeed.Location;
        }

        // adds gauge
        private void Controls_Add()
        {
            this.Controls.Add(gaugeAlititude);
            this.Controls.Add(gaugeVspeed);
            this.Controls.Add(gaugeSpeed);
        }

        // Sets size (width, height)
        private void SetSize()
        {
            gaugeAlititude.Size = pictureBoxAltitude.Size;
               gaugeVspeed.Size = pictureBoxVspeed.Size;
                gaugeSpeed.Size = pictureBoxSpeed.Size;
        }

       
        // places the image of the gauge into the background.
        private void SetbackgeoundImage()
        {
            gaugeAlititude.BackgroundImage = pictureBoxAltitude.Image;
               gaugeVspeed.BackgroundImage = pictureBoxVspeed.Image;
                gaugeSpeed.BackgroundImage = pictureBoxSpeed.Image;

        }


        // For this demo I have not altered the values of the min/max values. You can set them to your liking.

        // sets the max and min values of the gauges.
        private void SetFromToValue()
        {
            //gaugeAlititude.FromValue = 0;
               //gaugeVspeed.FromValue = 0;
                //gaugeSpeed.FromValue = 0;

            //gaugeAlititude.ToValue = 100;
               //gaugeVspeed.ToValue = 300;
                //gaugeSpeed.ToValue = 1000;
        }


        // Because we are simulating an instance where the Angular Gauge doesn't appear in the Designer toolbox, we need to make sure that our
        // picture box is behind the gauge. To do this we will need to bring the gauge to the front. If you can't see your number label,
        // bring it to the front after the guages. For this demo there are no number labels, but you can see the place where they would sit.


        // As we have placed down a picturebox as a reference for our gauge, we will need to bring the Angular gauge in front of the 
        // picturebox. 
        void BringToTheFront()
        {
            gaugeAlititude.BringToFront();
               gaugeVspeed.BringToFront();
                gaugeSpeed.BringToFront();
        }


        // the last thing to do is invaliade the guages.
        void SetInvalidate()
        {
            gaugeAlititude.Invalidate();
               gaugeVspeed.Invalidate();
                gaugeSpeed.Invalidate();
        }
        /****************************************************************************
         ****************************************************************************/
        // Everything below here is used to animate the gauges.

        //click button to start the gauge animation
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // ensures the boolean is set to true.
            looping = true;
            // creates a thread pool so we can run the loop without freezing the whole gui.
            // executes the method below.
            ThreadPool.QueueUserWorkItem(state => RandomNeedleValues());
        }

        // makes the needles move by changing the value every loop.
        // this lets you see how the needles look in motion.
        // this also demostrates how to update the value of each needle.
        private void RandomNeedleValues()
        {
            // the loop allows for continuous change of value - this makes the needle move.
            while (looping)
            {
                //getting new numbers every loop
                double altitude = rand.NextDouble() * 100;
                double speed = rand.NextDouble() * 100;
                double vSpeed = rand.NextDouble() * 100;

                //updating the gauge value.
                BeginInvoke((MethodInvoker)delegate
                {
                    gaugeAlititude.Value = altitude;
                    gaugeSpeed.Value = speed;
                    gaugeVspeed.Value = vSpeed;

                });
                //creates a pause so you can see the cool needle animation.
                Thread.Sleep(1000);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            looping = false; // stops loop.
            stopEvent.Set(); // stops the event
        }
    }
}
