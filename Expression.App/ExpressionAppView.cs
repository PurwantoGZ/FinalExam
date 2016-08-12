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
using System.IO;

namespace Expression.App
{
    public partial class ExpressionAppView : MetroForm
    {
        Database db = new Database();

        #region Properties Favorite
        int epoch = 0;
        string[] favoriteName = new string[6];
        int[] idFavorite = new int[6];
        int[] priority = new int[6];

        #endregion


        private string idOutput;
        public int sad = 0, happy = 0;
        public string idUser = null, _pass = null;
        private Capture _capture = null;
        private bool _captureInProgress;
        int CameraDevice = 0;
        Video_Device[] WebCams;
        Mat frame = new Mat();
        Helper help = new Helper();
        LoginView lView = null;
        DetailProfilView dView = null;

        #region PROPERTIES FEATURES
        int faceCount = 0;
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
        double _f1 = 0, _f2 = 0, _f3 = 0, _f4 = 0, _f5 = 0, _f6 = 0;
        double[] maxF = new double[6];
        double yValues = 0;
        string Expression = null, key = null;
        int numDataTraining = 1;
        double[][] identData;
        double[][] trainData;
        Face _face = new Face();

        Bitmap extractedFace;
        Graphics FaceCanvas;
        Bitmap ExtFace;
        Random r = new Random();
        #endregion

        #region PROPESTIES JST
        Dictionary<int, double> mse = new Dictionary<int, double>();
        double[] setting = new double[4];
        int numInput;
        int numHidden;
        int numOutput;
        double momentum;
        int numWeight1, numWeight2;
        Fann nn;

        #endregion

        #region Function SadOrHappy
        private void SadOrHappy()
        {
            try
            {
                if (faceCount==1)
                {
                    #region Compute Features Only Face One Detect
                    identData = new double[numDataTraining][];
                    _face.Mouth(x1, y1, x2, y2, ref f3);
                    _face.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
                    _face.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);
                    db.getMaxValues(out maxF);
                    _f1 = f1; _f2 = f2; _f3 = f3; _f4 = f4; _f5 = f5; _f6 = f6;
                    f1 = f1 / maxF[0];
                    f2 = f2 / maxF[1];
                    f3 = f3 / maxF[2];
                    f4 = f4 / maxF[3];
                    f5 = f5 / maxF[4];
                    f6 = f6 / maxF[5];
                    for (int i = 0; i < numDataTraining; i++)
                    {
                        identData[i] = new double[] { f1, f2, f3, f4, f5, f6 };
                    }

                    nn = new Fann(numInput, numHidden, numOutput);
                    nn.InitializedWeightsDB(help._oldweight("weight"));
                    nn.Indentification(identData, ref yValues);

                    f1 = Math.Round(f1, 3); f2 = Math.Round(f2, 3); f3 = Math.Round(f3, 3);
                    f4 = Math.Round(f4, 3); f5 = Math.Round(f5, 3); f6 = Math.Round(f6, 3);

                    statusF1.Text = "F1: " + f1.ToString();
                    statusF2.Text = "F2: " + f2.ToString();
                    statusF3.Text = "F3: " + f3.ToString();
                    statusF4.Text = "F4: " + f4.ToString();
                    statusF5.Text = "F5: " + f5.ToString();
                    statusF6.Text = "F6: " + f6.ToString();

                    key = decimal.Round(Convert.ToDecimal(yValues)).ToString();
                    yValuesText.Text = "yValues: " + yValues.ToString("F3");

                    help.accuracyOutput(yValues, out sad, out happy);

                    db.getFinallyOutput(key, ref Expression);
                    ExpressionText.Text = Expression;
                    ProsentaseText.Text = "Sedih : " + sad.ToString() + "%, Senang: " + happy.ToString() + "%";
                    
                    /*Save Data Testing*/
                    if ((f1 != 0) && (f2 != 0) && (f3 != 0) && (f4 != 0) && (f5 != 0) && (f6 != 0))
                    {
                        string folder = @"E:\HasilCropping\";
                        string iName = r.NextDouble().ToString() + ".png";
                        Bitmap imgSave = new Bitmap(ExtFace,new Size(212, 206));
                        picCropped.Image = imgSave;
                        imgSave.Save(folder + iName);
                        string dataImage = iName;
                        //db.saveTesting(Convert.ToInt32(key), _f1, _f2, _f3, _f4, _f5, _f6, idUser, sad, happy,dataImage);
                    }
                    #endregion
                }
                else
                {
                    string ShownMessage = null;
                    
                    TrayIcon.BalloonTipIcon = ToolTipIcon.Warning;
                    TrayIcon.BalloonTipTitle = "Peringatan";
                    if (faceCount>1)
                    {
                        ShownMessage = faceCount.ToString() + " Wajah Terdeteksi.";
                    }else
                    {
                        ShownMessage ="Objek Wajah tidak Terdeteksi.";
                    }
                    TrayIcon.BalloonTipText = ShownMessage;
                    TrayIcon.ShowBalloonTip(800);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
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

        #region TrainDataUser
        private void trainDataUser()
        {
            int numData = db.countTrain(idUser);
            trainData = new double[numData][];
            double[] _f1a = new double[numData];
            double[] _f2a = new double[numData];
            double[] _f3a = new double[numData];
            double[] _f4a = new double[numData];
            double[] _f5a = new double[numData];
            double[] _f6a = new double[numData];
            double[] tValuesa = new double[numData];
            db.populateDataTrainingbyUser(out _f1a, out _f2a, out _f3a, out _f4a, out _f5a, out _f6a, out tValuesa, idUser, numData);
            for (int i = 0; i < numData; i++)
            {
                trainData[i] = new double[] { _f1a[i], _f2a[i], _f3a[i], _f4a[i], _f5a[i], _f6a[i], tValuesa[i] };
            }
            #region Create NeuronNetwork
            nn = new Fann(numInput, numHidden, numOutput);
            if ((help.isFileFound("weight")) && (numWeight1 == numWeight2))
            {
                nn.InitializedWeightsDB(help._oldweight("weight"));
                Console.WriteLine("Gunakan Bobot DB");
            }
            else
            {
                nn.InitializedWeights();
                Console.WriteLine("Bobot Random");
            }
            #endregion
            string result = null;
            mse = nn.TrainBP(trainData, 0.1, 1000, 0.1, 0.5, ref result);
            help.saveWeightNote(nn.Getweights(), "weight");
            ErrorText.Text = result;
        }
        #endregion

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                _capture.Retrieve(frame, 0);
                runCapture();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void ReleaseData()
        {
            try
            {
                if (_capture != null)
                    _capture.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        #region Tray Icon Meny
        private void AdminMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowMenu_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void ExpressionAppView_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
                TrayIcon.BalloonTipTitle = "Informasi";
                TrayIcon.BalloonTipText = "My Assistant Minimalized";
                TrayIcon.ShowBalloonTip(700);
            }
        }
        #endregion


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
            FaceCount.Text = faces.Count.ToString();
            faceCount = faces.Count;
            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);

            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);
                extractedFace = new Bitmap(face.Width, face.Height);
                FaceCanvas = Graphics.FromImage(extractedFace);
                FaceCanvas.DrawImage(frame.ToImage<Bgr, Byte>().ToBitmap(), 0, 0, face, GraphicsUnit.Pixel);
                ExtFace = extractedFace;
            }
            /*
            foreach (Rectangle mouth in mouths)
                CvInvoke.Rectangle(frame, mouth, new Bgr(Color.Aquamarine).MCvScalar, 2);

            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(frame, eye, new Bgr(Color.GreenYellow).MCvScalar, 2);
            */
            PreviewImage.Image = frame;
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

        private void checkUser()
        {
            try
            {
                string fileLoc = @"session.ind";
                if (File.Exists(fileLoc))
                {
                    using (TextReader tr = new StreamReader(fileLoc))
                    {
                        idUser = tr.ReadLine();
                        _pass = tr.ReadLine();
                        HomeMenu.Text = db.getUser(idUser);
                        db.getFavorite(idUser, out favoriteName, out priority, out idFavorite);
                        allowCamera();
                        timer1.Start();
                        tr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Anda belum terdaftar, Silahkan daftar dahulu.");
                    HomeMenu.Text = "Login";
                    timer1.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void allowCamera()
        {
            DialogResult dialogResult = MessageBox.Show("Ijin Akses Camera \n Anda Mengijinkan ?", "Konfirmasi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                CvInvoke.UseOpenCL = false;
                try
                {
                    _capture = new Capture();
                    _capture.ImageGrabbed += ProcessFrame;
                    _capture.Start();
                    btnStart.ImageIndex = 4;
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }

        }

        private void TampilNotif(string Title,string expresi,string content)
        {
            try
            {
                content = content.Replace(" ", "+");
                Notification.TitleText = Title;
                Notification.Expression = expresi;
                Notification.MessageInfo = "Silahkan Klik Link dibawah Ini";
                Notification.ContentText = content;
                Notification.ShowCloseButton = true;
                Notification.ShowOptionsButton = true;
                Notification.ShowGrip = true;
                Notification.Delay = 7000;
                Notification.AnimationInterval = 70;
                Notification.AnimationDuration = 70;
                Notification.TitlePadding = new Padding(3);
                Notification.ContentPadding = new Padding(3);
                Notification.ImagePadding = new Padding(3);
                Notification.Scroll = true;
                Bitmap resized = new Bitmap(ExtFace, new Size(40, 40));
                Notification.Image = resized;
               
                Notification.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                if (_capture != null)
                {
                    //_capture.Pause();
                    _capture.Dispose();
                }
                Application.ExitThread();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public ExpressionAppView()
        {
            InitializeComponent();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolExit.Text=="Masuk")
                {
                    lView = new LoginView();
                    lView.FormClosed += new FormClosedEventHandler(loginFormClosed);
                    lView.ShowDialog();
                    checkUser();
                }else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExpressionAppView_Load(object sender, EventArgs e)
        {
            try
            {
                initiliazedJst();
                checkUser();
                trainDataUser();
                timer1.Interval = 300;
                timer1.Tick += timer1_Tick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string Title = null;
                string content = null;
                TxtJam.Text = DateTime.Now.ToString("[HH:mm:ss tt]");
                if (DateTime.Now.Second%10==0)
                {
                    SadOrHappy();
                    if (Expression.Equals("Sedih"))
                    {
                        if (epoch==6)
                        {
                            epoch = 0;
                        }
                        content = favoriteName[epoch];
                        Title = HomeMenu.Text;
                        TampilNotif(Title, Expression, content);
                        Console.Beep();
                        epoch++;
                    }else
                    {
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStart.ImageIndex == 2)
                {
                    checkUser();
                    toolExit.Text = "Keluar";
                }
                else
                {
                    _capture.Dispose();
                    timer1.Stop();
                    PreviewImage.Image = null;
                    HomeMenu.Text = "Login";
                    toolExit.Text = "Masuk";
                    btnStart.ImageIndex = 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HomeMenu_Click(object sender, EventArgs e)
        {
            
        }

        delegate void loginUnloaded(object sender, FormClosedEventArgs e);
        private void loginFormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void toolDetail_Click(object sender, EventArgs e)
        {
            Bitmap imgProfil = new Bitmap(ExtFace, new Size(220, 220));
            dView = new DetailProfilView(idUser,imgProfil);
            dView.FormClosed += new FormClosedEventHandler(dViewClosed);
            toolDetail.Enabled = false;
            dView.ShowDialog();
        }
        delegate void detailUnloaded(object sender, FormClosedEventArgs e);
        private void dViewClosed(object sender, FormClosedEventArgs e)
        { 
            toolDetail.Enabled = true;
        }
    }
}
