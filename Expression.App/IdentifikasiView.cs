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
using DirectShowLib;
using Expression;
using MetroFramework.Forms;
using Expression;
namespace Expression.App
{
    public partial class IdentifikasiView : MetroForm
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

        public int sad = 0, happy = 0;
        int numDataIdentifkasi = 1;
        double[] maxF = new double[6];
        double[][] identData;
        double yValues = 0;
        string Expression = null, key = null;
        double[] setting = new double[4];
        int numInput;
        int numHidden;
        int numOutput;
        double momentum;
        int numWeight1, numWeight2;
        Fann nn;
        Helper help = new Helper();
        #endregion

        #region Initialisasi JST
        private void initiliazedJst()
        {
            setting = help.GetSetJST("setting");
            numInput = Convert.ToInt32(setting[0]);
            numHidden = Convert.ToInt32(setting[1]);
            numOutput = Convert.ToInt32(setting[2]);
            momentum = setting[3];
            numWeight1 = help.TotalLines(@"weight.ghz");
            numWeight2 = (numInput * numHidden) + numHidden + (numHidden * numOutput) + numOutput;
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

        private void ComputeFeature()
        {
            idUser = "coba@coba.com";
            _face.Mouth(x1, y1, x2, y2, ref f3);
            _face.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
            _face.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);

            
            identData = new double[numDataIdentifkasi][];
            db.getMaxValues(out maxF);
            f1 = f1 / maxF[0];
            f2 = f2 / maxF[1];
            f3 = f3 / maxF[2];
            f4 = f4 / maxF[3];
            f5 = f5 / maxF[4];
            f6 = f6 / maxF[5];
            vF1.Text = "F1: " + f1.ToString("F3");
            vF2.Text = "F2: " + f2.ToString("F3");
            vF3.Text = "F3: " + f3.ToString("F3");
            vF4.Text = "F4: " + f4.ToString("F3");
            vF5.Text = "F5: " + f5.ToString("F3");
            vF6.Text = "F6: " + f6.ToString("F3");
            for (int i = 0; i < numDataIdentifkasi; i++)
            {
                identData[i] = new double[] {f1,f2,f3,f4,f5,f6 };
            }
            nn = new Fann(numInput, numHidden, numOutput);
            nn.InitializedWeightsDB(help._oldweight("weight"));
            nn.Indentification(identData, ref yValues);

            vOutput.Text = "yValues: " + yValues.ToString("F3");

            key = decimal.Round(Convert.ToDecimal(yValues)).ToString();

            help.accuracyOutput(yValues, out sad, out happy);
            db.getFinallyOutput(key, ref Expression);
            string message =" Citra Wajah Teridentifikasi sebagai Ekspres "+Expression+"\n Akurasi Sedih: "+sad.ToString()+"% , Senang: "+happy.ToString()+"%";
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public IdentifikasiView()
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
            initiliazedJst();
        }

        private void CamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupCapture(CamList.SelectedIndex);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    btnStart.Text = "Mulai";
                    btnStart.ImageIndex = 1;
                    _capture.Pause(); //Pause the capture
                    ComputeFeature();
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
                    btnStart.ImageIndex = 2;
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

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            using (ofd)
            {
                ofd.Title = "Open Image Training";
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    frame = new Mat(ofd.FileName, LoadImageType.Color);
                    runCapture();
                    ComputeFeature();
                }
            }
        }

    }
}
