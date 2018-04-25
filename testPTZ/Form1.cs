using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Documentation http://www.aforgenet.com/framework/docs/
using AForge.Video.DirectShow;
using System.Windows.Forms;

namespace testPTZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private VideoCaptureDevice Cam1;
        private FilterInfoCollection VideoCaptureDevices;
        CameraProperty PanControl, TiltControl, ZoomControl;

        private void foo()
        {
            Cam1.DisplayPropertyPage(IntPtr.Zero); //This will display a form with camera controls
        }

        private void SelectCamera(int whichOne )
        {
            Cam1 = new VideoCaptureDevice(VideoCaptureDevices[whichOne].MonikerString);
            PanControl = new CameraProperty(Cam1, CameraControlProperty.Pan);
            btnPanLeft.Enabled = PanControl.enabled;
            btnPanRight.Enabled = PanControl.enabled;

            TiltControl = new CameraProperty(Cam1, CameraControlProperty.Tilt);
            btnTiltDown.Enabled = TiltControl.enabled;
            btnTiltUp.Enabled = TiltControl.enabled;

            ZoomControl = new CameraProperty(Cam1, CameraControlProperty.Zoom);
            btnZoomIn.Enabled = ZoomControl.enabled;
            btnZoomOut.Enabled = ZoomControl.enabled;

            status.Text += "\r\nConnecting to " + VideoCaptureDevices[whichOne].Name;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == btnZoomOut)
                ZoomControl.decrease();
            else ZoomControl.increase();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in VideoCaptureDevices)
            {
                status.Text += "\r\nDevice name: " + device.Name;
                cbCameras.Items.Add(device.Name);
            }
            btnPanLeft.Enabled = false;
            btnPanRight.Enabled = false;
            btnTiltDown.Enabled = false;
            btnTiltUp.Enabled = false;
            btnZoomIn.Enabled = false;
            btnZoomOut.Enabled = false;
        }

        private void OnChangeCamera(object sender, EventArgs e)
        {
            int sel = cbCameras.SelectedIndex;
            SelectCamera(sel);
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == btnPanLeft)
                PanControl.decrease();
            else PanControl.increase();
        }

        private void btnTilt_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == btnTiltDown)
                TiltControl.decrease();
            else TiltControl.increase();
        }


    }
}
