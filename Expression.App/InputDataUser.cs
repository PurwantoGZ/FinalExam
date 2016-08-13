using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using MetroFramework.Forms;
using DirectShowLib;
using Expression;
namespace Expression.App
{
    public partial class InputDataUser : MetroForm
    {
        #region Properties
        OpenFileDialog ofd = new OpenFileDialog();
        Database db = new Database();

        private string idOutput;
        private string idUser;
        private Capture _capture = null;
        private bool _captureInProgress;
        int CameraDevice = 0;
        Video_Device[] WebCams;
        Mat frame = new Mat();
        #endregion

        #region PROPERTIES FEATURES
        int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
        int[] mataX1 = new int[3];
        int[] mataX2 = new int[3];
        int[] mataY1 = new int[3];
        int[] mataY2 = new int[3];

        int[] alisX1 = new int[3];
        int[] alisX2 = new int[3];
        int[] alisY1 = new int[3];
        int[] alisY2 = new int[3];
        double f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0;
        Face _face = new Face();
        #endregion

        #region Camera Settings
        int Brightness_Store = 0;
        int Contrast_Store = 0;
        int Sharpness_Store = 0;
        #endregion

        #region Allow Camera
        private void allowCamera()
        {
            DialogResult dialogResult = MessageBox.Show("Ijin Akses Camera \n Anda Mengijinkan ?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CvInvoke.UseOpenCL = false;
                try
                {
                    _capture = new Capture();
                    _capture.ImageGrabbed += ProcessFrame;
                    _capture.Start();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        #endregion

        private void ProcessFrame(object sender, EventArgs arg)
        {
            //Mat frame = new Mat();
            _capture.Retrieve(frame, 0);
            runCapture();
            //PreviewImage.Image = frame;
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        public InputDataUser()
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

        private void runCapture()
        {
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> mouths = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            String faceFileName = "haarcascade_frontalface_default.xml";
            String mouthFileName = "haarcascade_mcs_mouth.xml";
            String eyeFileName = "haarcascade_eye.xml";

            _face.Detect(frame, faceFileName, mouthFileName, eyeFileName,
                faces, mouths, eyes, ref x1, ref y1, ref x2, ref y2,
                ref mataX1, ref mataY1, ref mataX2, ref mataY2,
                ref alisX1, ref alisY1, ref alisX2, ref alisY2);
            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);
            /*
            foreach (Rectangle mouth in mouths)
                CvInvoke.Rectangle(frame, mouth, new Bgr(Color.Aquamarine).MCvScalar, 2);

            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(frame, eye, new Bgr(Color.GreenYellow).MCvScalar, 2);
            */
            PreviewImage.Image = frame;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string message = "Simpa Data Latih untuk,\nID USER \t:" + idUser + "\nEKSPRESI \t: " + cbOutput.Text +"?";
            DialogResult dialogResult = MessageBox.Show(message, "Konfirmasi Simpan Data", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string pesan = (db.saveTrainingData(idUser, idOutput, F1.Text, F2.Text, F3.Text, F4.Text, F5.Text, F6.Text)) ? "Data Berhasil Disimpan" : "Gagal Simpan data";
                    MessageBox.Show(pesan, "Informasi Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                btnSaveData.Enabled = false;
            } else
            {
            }
        }

        private void ComputeFeature()
        {
            _face.Mouth(x1, y1, x2, y2, ref f3);
            _face.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
            _face.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);

            F1.Text = f1.ToString("#.##");
            F2.Text = f2.ToString("#.##");
            F3.Text = f3.ToString("#.##");
            F4.Text = f4.ToString("#.##");
            F5.Text = f5.ToString("#.##");
            F6.Text = f6.ToString("#.##");
        }

        private void SetupCapture(int Camera_Identifier)
        {
            CvInvoke.UseOpenCL = false;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    btnStart.Text = "Mulai";
                    btnStart.ImageIndex = 2;
                    _capture.Pause(); //Pause the capture
                    ComputeFeature();
                    btnSaveData.Enabled = true;
                    _captureInProgress = false; //Flag the state of the camera
                }
                else
                {
                    //Check to see if the selected device has changed
                    if (CamList.SelectedIndex != CameraDevice)
                    {
                        SetupCapture(CamList.SelectedIndex); //Setup capture with the new device
                    }
                    btnStart.Text = "Stop";
                    btnStart.ImageIndex = 3;
                    _capture.Start(); //Start the capture
                    _captureInProgress = true; //Flag the state of the camera
                }

            }
            else
            {
                //set up capture with selected device
                SetupCapture(CamList.SelectedIndex);
                //Be lazy and Recall this method to start camera
                btnStart_Click(null, null);
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                if (_capture != null)
                {
                    _capture.Dispose();
                }
                this.Hide();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            using (ofd)
            {
                ofd.Title = "Open Image Training";
                ofd.Filter = "Jpg Files (*.jpg)|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    frame = new Mat(ofd.FileName, LoadImageType.Color);
                    runCapture();
                    ComputeFeature();
                    btnSaveData.Enabled = true;
                }
            }
        }

        private void InputDataUser_Load(object sender, EventArgs e)
        {
            db.getAllUser(ref cbUserId);
            db.getOutput(ref cbOutput);
            cbUserId.SelectedIndex = 0;
            cbOutput.SelectedIndex = 0;
            db.getIdOutput(cbOutput.Text, ref idOutput);
            db.UserId(ref idUser, cbUserId.Text);
        }

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.getIdOutput(cbOutput.Text, ref idOutput);
        }

        private void cbUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.UserId(ref idUser, cbUserId.Text);
        }
    }
}
