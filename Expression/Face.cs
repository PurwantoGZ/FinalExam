using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif

namespace Expression
{
   public class Face
    {
        #region CTOR
        public Face()
        {

        }
        #endregion

        #region Properties
        private double centerMulutX, centerMulutY;
        private double centerMataX1, centerMataY1, centerMataX2, centerMataY2;
        private double centerMataX, centerMataY;
        private double centerAlisX1, centerAlisY1, centerAlisX2, centerAlisY2;
        private double centerDuaAlisX, centerDuaAlisY;
        #endregion

        #region DETECT FACE 
        public  void Detect(Mat image, string faceFileName, string eyeFileName, string mouthFileName, List<Rectangle> faces, List<Rectangle> eyes, List<Rectangle> mouths,
             ref int x1, ref int y1, ref int x2, ref int y2,
            ref int[] mataX1, ref int[] mataY1, ref int[] mataX2, ref int[] mataY2,
            ref int[] alisX1, ref int[] alisY1, ref int[] alisX2, ref int[] alisY2)
        {
            using (CascadeClassifier face = new CascadeClassifier(faceFileName))
            using (CascadeClassifier mouth = new CascadeClassifier(mouthFileName))
            using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
            {
                using (UMat ugray = new UMat())
                {
                    CvInvoke.CvtColor(image, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(ugray, ugray);
                    Rectangle[] facesDetected = face.DetectMultiScale(
                       ugray,
                       1.1,
                       10,
                       new Size(20, 20));

                    faces.AddRange(facesDetected);

                    foreach (Rectangle f in facesDetected)
                    {
                        using (UMat faceRegion = new UMat(ugray, f))
                        {
                            Rectangle[] eyesDetected = eye.DetectMultiScale(
                               faceRegion,
                               1.1,
                               10,
                               new Size(20, 20));
                            int i = 1;
                            foreach (Rectangle e in eyesDetected)
                            {
                                Rectangle eyeRect = e;
                                
                                eyeRect.Offset(f.X, f.Y);
                                if (eyes.Count==1)
                                {
                                    mataX1[1] = f.X; mataY1[1] = f.Y;
                                    mataX1[2] = (f.X + eyeRect.Width); mataY1[2] = (f.Y + eyeRect.Height);

                                    alisX1[1] = (f.X - eyeRect.Height); alisY1[1] = (f.Y - eyeRect.Height);
                                    alisX1[2] = ((f.X + eyeRect.Width) - eyeRect.Height); alisY1[2] = ((f.Y + eyeRect.Height) - eyeRect.Height);
                                }
                                if (eyes.Count==2)
                                {
                                    int jarak = 20;//pixel;
                                    mataX2[1] = f.X + jarak; mataY2[1] = f.Y + jarak;
                                    mataX2[2] = ((f.X + jarak) + eyeRect.Width); mataY2[2] = ((f.Y + jarak) + eyeRect.Height);

                                    alisX2[1] = ((f.X + jarak) - eyeRect.Height); alisY2[1] = ((f.Y + jarak) - eyeRect.Height);
                                    alisX2[2] = (((f.X + jarak) + eyeRect.Width) - eyeRect.Height); alisY2[2] = (((f.Y + jarak) + eyeRect.Height) - eyeRect.Height);
                                }

                                //if (i == 1)
                                //{
                                //    mataX1[1] = f.X; mataY1[1] = f.Y;
                                //    mataX1[2] = (f.X + eyeRect.Width); mataY1[2] = (f.Y + eyeRect.Height);

                                //    alisX1[1] = (f.X - eyeRect.Height); alisY1[1] = (f.Y - eyeRect.Height);
                                //    alisX1[2] = ((f.X + eyeRect.Width) - eyeRect.Height); alisY1[2] = ((f.Y + eyeRect.Height) - eyeRect.Height);
                                //}
                                //if (i == 2)
                                //{
                                //    mataX2[1] = f.X; mataY2[1] = f.Y;
                                //    mataX2[2] = ((f.X) + eyeRect.Width); mataY2[2] = ((f.Y) + eyeRect.Height);

                                //    alisX2[1] = ((f.X) - eyeRect.Height); alisY2[1] = ((f.Y) - eyeRect.Height);
                                //    alisX2[2] = (((f.X) + eyeRect.Width) - eyeRect.Height); alisY2[2] = (((f.Y) + eyeRect.Height) - eyeRect.Height);
                                //}

                                i++;
                                eyes.Add(eyeRect);
                            }

                            Rectangle[] mouthsDetected = mouth.DetectMultiScale(faceRegion,
                               1.1,
                               10,
                               new Size(20, 20));

                            foreach (Rectangle m in mouthsDetected)
                            {
                                Rectangle mouthRect = m;
                                mouthRect.Offset(f.X, f.Y);
                                x1 = f.X;
                                y1 = f.Y;
                                x2 = (f.X + mouthRect.Width);
                                y2 = (f.Y + mouthRect.Height);
                                mouths.Add(mouthRect);
                            }
                        }
                    }
                }

            }//end using haar
            /*
            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);
            */
        }
        #endregion

        #region ComputerMouthFeature
        public void Mouth(int x1, int y1, int x2, int y2, ref double F3)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Koordinat Fitur Mulut");
            Console.WriteLine("[x1,y1]={0},{1} dan [x2,y2]={2},{3}",x1,y1,x2,y2);
            centerMulutX = ((x2 - x1) / 2) + x1;
            centerMulutY = ((y2 - y1) / 2) + y1;
            F3 = (y2 - y1) * 1.0;
        }
        #endregion

        #region ComputeEyeFeature
        public void Eye(int[] mataX1, int[] mataY1, int[] mataX2, int[] mataY2, ref double F2, ref double F5)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Fitur Mata");
            Console.WriteLine("1. Mata Kiri");
            Console.WriteLine("[x1,y1]={0},{1} dan [x2,y2]={2},{3}",mataX1[1],mataY1[1],mataX1[2],mataY1[2]);
            Console.WriteLine("2. Mata Kanan");
            Console.WriteLine("[x1,y1]={0},{1} dan [x2,y2]={2},{3}", mataX2[1], mataY2[1], mataX2[2], mataY2[2]);

            centerMataX1 = ((mataX1[2] - mataX1[1]) / 2) + mataX1[2];
            centerMataY1 = ((mataY1[2] - mataY1[2]) / 2) + mataY1[1];

            centerMataX2 = ((mataX2[2] - mataX2[1]) / 2) + mataX2[1];
            centerMataY2 = ((mataY2[2] - mataY2[1]) / 2) + mataY2[1];

            centerMataX = (centerMataX2 - centerMataX1) / 2;
            centerMataY = (centerMataY2 - centerMataY1) / 2;

            double a, b;
            a = centerMataX2 - centerMataX1;
            b = centerMataY2 - centerMataY1;
            F5 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));


            F2 = ((mataY1[2] - mataY1[1]) + (mataY2[2] - mataY2[1])) / 2;
        }
        #endregion

        #region ComputeEyeBrow
        public void EyeBrow(int[] alisX1, int[] alisY1, int[] alisX2, int[] alisY2, ref double F1, ref double F4, ref double F6)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Fitur Alis Mata");
            Console.WriteLine("1. Alis Kiri");
            Console.WriteLine("[x1,y1]={0},{1} dan [x2,y2]={2},{3}",alisX1[1],alisY1[1],alisX1[2],alisY1[2]);
            Console.WriteLine("2. Alis Kanan");
            Console.WriteLine("[x1,y1]={0},{1} dan [x2,y2]={2},{3}", alisX2[1], alisY2[1], alisX2[2], alisY2[2]);
            centerAlisX1 = ((alisX1[2] - alisX1[1]) / 2) + alisX1[1];
            centerAlisY1 = ((alisY1[2] - alisY1[1]) / 2) + alisY1[1];

            centerAlisX2 = ((alisX2[2] - alisX2[1]) / 2) + alisX2[1];
            centerAlisY2 = ((alisY2[2] - alisY2[1]) / 2) + alisY2[1];

            centerDuaAlisX = ((centerAlisX2 - centerAlisX1) / 2) + centerAlisX1;
            centerDuaAlisY = ((centerAlisY2 - centerAlisY1) / 2) + centerAlisY1;

            double a, b, c, d, e, f;
            a = centerDuaAlisX - centerMataX;
            b = centerDuaAlisY - centerMataY;
            F1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            c = centerAlisX2 - centerAlisX1;
            d = centerAlisY2 - centerAlisY1;
            F4 = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));

            e = centerMulutX - centerDuaAlisX;
            f = centerMulutY - centerDuaAlisY;
            F6 = Math.Sqrt(Math.Pow(e, 2) + Math.Pow(f, 2));
        }
        #endregion

    }
}
