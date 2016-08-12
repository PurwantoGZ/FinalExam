using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Emgu.CV;
using DirectShowLib;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Expression.App
{
    public partial class CamSettingView : MetroForm
    {
        /*Hint use CTL+M and then CTL+O to callapse all fields*/
        #region Variables
        #region Camera Capture Variables
        private Capture _capture = null; //Camera
        private bool _captureInProgress = false; //Variable to track camera state
        int CameraDevice = 0; //Variable to track camera device selected
        Video_Device[] WebCams; //List containing all the camera available
        #endregion
        #region Camera Settings
        int Brightness_Store = 0;
        int Contrast_Store = 0;
        int Sharpness_Store = 0;
        #endregion
        #endregion

        public CamSettingView()
        {
            InitializeComponent();
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new Video_Device[_SystemCamereas.Length];
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
                CamList.Items.Add(WebCams[i].ToString());
            }
            if (CamList.Items.Count > 0)
            {
                CamList.SelectedIndex = 0; //Set the selected device the default
                btnStart.Enabled = true; //Enable the start
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            _capture.Retrieve(frame, 0);
            PreviewImage.Image = frame;
        }

        private void SetupCapture(int Camera_Identifier)
        {
            //update the selected device
            CameraDevice = Camera_Identifier;

            //Dispose of Capture if it was created before
            if (_capture != null) _capture.Dispose();
            try
            {
                //Set up capture device
                _capture = new Capture(CameraDevice);
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void StoreCameraSettings()
        {
            Brightness_Store = Brigtness_SLD.Value;
            Contrast_Store = Contrast_SLD.Value;
            Sharpness_Store = Sharpness_SLD.Value;
        }

        #region Sliders
        
        private void Brigtness_SLD_Scroll(object sender, EventArgs e)
        {
            Brigthness_LBL.Text = Brigtness_SLD.Value.ToString();
            if (_capture != null) _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Brightness, Brigtness_SLD.Value);
        }
        private void Contrast_SLD_Scroll(object sender, EventArgs e)
        {
            Contrast_LBL.Text = Contrast_SLD.Value.ToString();
            if (_capture != null) _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast, Contrast_SLD.Value);
        }
        private void Sharpness_SLD_Scroll(object sender, EventArgs e)
        {
            Sharpness_LBL.Text = Sharpness_SLD.Value.ToString();
            if (_capture != null) _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness, Sharpness_SLD.Value);
        }

        private void Slider_Enable(bool State)
        {
            Brigtness_SLD.Enabled = State;
            Contrast_SLD.Enabled = State;
            Sharpness_SLD.Enabled = State;
        }
        #endregion

        private void cbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDefault.Checked)
            {
                if (_capture != null)
                {
                    _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Brightness, Brightness_Store);
                    _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast, Contrast_Store);
                    _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness, Sharpness_Store);
                }
            }
            else
            {
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (_capture != null)
            {
                cbDefault_CheckedChanged(null, null);
                _capture.Dispose();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    btnStart.Text = "Start Capture"; 
                    Slider_Enable(false);
                    _capture.Pause();
                    _captureInProgress = false; 
                }
                else
                {
                    if (CamList.SelectedIndex != CameraDevice)
                    {
                        SetupCapture(CamList.SelectedIndex); 
                    }

                    btnStart.Text = "Stop";
                    StoreCameraSettings();
                    Slider_Enable(true); 
                    _capture.Start(); 
                    _captureInProgress = true; 
                }

            }
            else
            {
                SetupCapture(CamList.SelectedIndex);
                btnStart_Click(null, null);
            }
        }
    }
}
