using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;

namespace Parking
{
    public partial class Form1 : Form
    {
        private OzekiCamera _camera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _connector;
        private CameraURLBuilderWF _myCameraUrlBuilder;

        public Form1()
        {
            InitializeComponent();

            _connector = new MediaConnector();
            _imageProvider = new DrawingImageProvider();
            // Create video viewer UI control
            _myCameraUrlBuilder = new CameraURLBuilderWF();
            // Bind the camera image to the UI control
            videoViewerWF1.SetImageProvider(_imageProvider);
            Console.WriteLine("InitializeComponent");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL;

                btn_Connect.Enabled = true;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (_camera != null)
            {
                _camera.CameraStateChanged -= _camera_CameraStateChanged;
                _camera.Disconnect();
                _connector.Disconnect(_camera.VideoChannel, _imageProvider);
                _camera.Dispose();
                _camera = null;
            }

            btn_Connect.Enabled = false;

            var url = tb_cameraUrl.Text;

            _camera = new OzekiCamera(url);

            

            _camera.CameraStateChanged += _camera_CameraStateChanged;

            _connector.Connect(_camera.VideoChannel, _imageProvider);

            _camera.Start();
            
            videoViewerWF1.Start();
            
        }

        void _camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeThread(() =>
            {
                StateChanged(e.State);

                if (e.State == CameraState.Streaming)
                    Streaming();

                if (e.State == CameraState.Disconnected)
                    Disconnect();
            });
        }
        void InvokeThread(Action action)
        {
            BeginInvoke(action);
        }

        private void StateChanged(CameraState state)
        {
            //statusLabel.Text = state.ToString();
        }

        private void Disconnect()
        {
            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
        }

        private void Streaming()
        {
            btn_Disconnect.Enabled = true;
            System.Console.WriteLine("URL=" + _camera.CurrentRtspUri);
            txtRtspUrl.Text = _camera.CurrentRtspUri;
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (_camera == null) return;

            _camera.Disconnect();
            _connector.Disconnect(_camera.VideoChannel, _imageProvider);
            _camera = null;
        }

        private void addUserMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new UserManagement();
            myForm.Show();
        }


        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();

            if (e.KeyChar != 13)
            {
                _barcode.Add(e.KeyChar);
                _lastKeystroke = DateTime.Now;
                Console.WriteLine("Adding...");
            }
            else if (e.KeyChar == 13 && _barcode.Count > 0)
            {
                string msg = new String(_barcode.ToArray());
                MessageBox.Show(msg);
                _barcode.Clear();
                Console.WriteLine("DONE!!");
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //tb_cameraUrl.Enabled = false;
            this.Focus();
            Console.WriteLine("Focus");
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
