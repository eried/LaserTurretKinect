using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Kinect;

namespace LaserTurretKinect
{
    public partial class FormMain : Form
    {
        private KinectSensor _kinect;
        private float _lastX;
        private float _lastY;
        private float _lastZ;
        private SerialPort _serial;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Connect to the first kinect in the machine
            foreach (var k in KinectSensor.KinectSensors)
            {
                _kinect = k;

                var parameters = new TransformSmoothParameters
                                     {
                                         Smoothing = 0.3f,
                                         Correction = 0.0f,
                                         Prediction = 0.0f,
                                         JitterRadius = 1.0f,
                                         MaxDeviationRadius = 0.5f
                                     };
                _kinect.SkeletonStream.Enable(parameters);
                _kinect.SkeletonStream.Enable();
                //_kinect.AllFramesReady += new EventHandler(sensor_AllFramesReady);
                //_kinect.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                //_kinect.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                _kinect.SkeletonFrameReady += k_SkeletonFrameReady;
                _kinect.Start();
                return;
            }

            MessageBox.Show("No kinect detected!");
            Application.Exit();
        }

        private void k_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            using (var s = e.OpenSkeletonFrame())
            {
                if (s == null)
                    return;

                var t = e.OpenSkeletonFrame();

                // No skeleton yet
                if (t == null) return;

                var v = new Skeleton[t.SkeletonArrayLength];
                s.CopySkeletonDataTo(v);

                // Find tracked heads
                foreach (var head in
                        v.Select(sk => sk.Joints[JointType.Head]).Where(head => head.TrackingState != JointTrackingState.NotTracked))
                {
                    // Move the laser and shoot!
                    _lastX = head.Position.X;
                    _lastY = head.Position.Y;
                    _lastZ = head.Position.Z;

                    // Nothing more to do
                    return;
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_kinect != null)
                _kinect.Stop();
        }

        private static float map(float x, float inMin, float inMax, float outMin, float outMax, Boolean force)
        {
            var t = (x - inMin)*(outMax - outMin)/(inMax - inMin) + outMin;
            return force ? Math.Max(outMin, Math.Min(outMax, t)) : t;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            labelX.Text = "" + _lastX;
            labelY.Text = "" + _lastY;
            labelZ.Text = "" + _lastZ;

            // Adjust Z cut
            var t = _lastZ*100.0f;
            if (t > hScrollBar1z.Maximum)
                hScrollBar1z.Maximum = (int) t;
            else if (t < hScrollBar1z.Minimum)
                hScrollBar1z.Minimum = (int) t;

            var p = ConvertTo2D(_lastX, _lastY, _lastZ, hScrollBar1z.Value/100.0f);

            // Adjust X scrollbars limits
            AdjustScrollbar(p.X*100.0f, hScrollBar2x, hScrollBar1x);

            // Adjust Y scrollbars limits
            AdjustScrollbar(p.Y * 100.0f, hScrollBar2y, hScrollBar1y);

            // Maping
            int xx = 180 - (int) map(p.X, hScrollBar1x.Value/100.0f, hScrollBar2x.Value/100.0f, 0, 180, true),
                yy = 180 - (int) map(p.Y, hScrollBar1y.Value/100.0f, hScrollBar2y.Value/100.0f, 0, 180, true);

            labelXY.Text = xx + "," + yy;

            if (_serial == null || !_serial.IsOpen) return;

            try
            {
                _serial.Write(new[] {(byte) 'X', (byte) xx}, 0, 2);
                _serial.Write(new[] {(byte) 'Y', (byte) yy}, 0, 2);
            }
            catch
            {
            }
        }

        private void AdjustScrollbar(float t, ScrollBar scrollMax, ScrollBar scrollMin)
        {
            if (t > scrollMax.Maximum)
            {
                scrollMax.Maximum = (int) t;
                scrollMax.Minimum = scrollMin.Maximum;
            }

            if (t < scrollMin.Minimum)
            {
                scrollMin.Minimum = (int) t;
                scrollMin.Maximum = scrollMax.Minimum;
            }
        }

        private static PointF ConvertTo2D(float x, float y, float z, float d)
        {
            return new PointF((d/(z + d))*x, (d/(z + d))*y);
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            foreach (var s in SerialPort.GetPortNames())
                comboBoxPort.Items.Add(s);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _serial = null;
            try
            {
                _serial = new SerialPort(comboBoxPort.Text, 9600);
                _serial.Open();
            }
            catch
            {
                MessageBox.Show("Can't open specified port!");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
        }

        private void CloseSerialPort()
        {
            if (_serial == null) return;

            try
            {
                if (_serial.IsOpen)
                    _serial.Close();
            }
            catch
            {
            }
            _serial = null;
        }

        private void hScrollBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            timerUpdate.Interval = hScrollBarSpeed.Value;
        }
    }
}