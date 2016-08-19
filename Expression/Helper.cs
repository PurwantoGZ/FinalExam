using System.IO;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Expression
{
    public class Helper
    {
        #region Fungsi Mencari Nilai Tertinggi
        public double getHeightsValue(double[] nilai, int elemen)
        {
            int temp = 0;
            for (int j = 0; j < (elemen - 1); j += 1)
            {
                for (int i = 0; i < (elemen - 1); i += 1)
                {
                    if (nilai[i] < nilai[(i + 1)])
                    {
                        temp = Convert.ToInt32(nilai[i]);
                        nilai[i] = Convert.ToInt32(nilai[(i + 1)]);
                        nilai[(i + 1)] = Convert.ToInt32(temp);
                    }
                }
            }
            return nilai[0];
        }
        #endregion

        #region Fungsi Validasi Email
        public bool IsValidEmail(string email)
        {
            try
            {
                string expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(email, expresion))
                {
                    if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Accuracy Output
        public void accuracyOutput(double yValues, out int sad, out int happy)
        {
            int accuracy = 0;
            try
            {
                accuracy = Convert.ToInt32(Math.Round(yValues, 2) * 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            sad = 100 - accuracy;
            happy = 100 - sad;
        }
        #endregion

        #region Convert Image to Byte
        public byte[] ConvertToBytes(BitmapImage bitmapImage)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        public BitmapImage byteToImage()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var imageSource = new BitmapImage();
                imageSource.BeginInit();
                imageSource.StreamSource = ms;
                imageSource.CacheOption = BitmapCacheOption.OnLoad;
                imageSource.EndInit();
                return imageSource;
            }
        }

        public byte[] imageToByteArray(PictureBox image)
        {

            byte[] data;
            if (image.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                image.Image.Save(ms, image.Image.RawFormat);
                data = ms.GetBuffer();
            }
            else
            {
                data = null;
            }

            return data;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion

        #region Check File Weight
        public  bool isFileFound(string fileName)
        {
            string _fileName = @"" + fileName + ".ghz";
            try
            {
                return (File.Exists(_fileName)) ? true : false;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }
        #endregion

        #region Save WeightNotePad
        public void saveWeightNote(double[] data, string fileName)
        {
            string _fileName = @"" + fileName;
            if (File.Exists(_fileName))
            {
                using (StreamWriter sw = File.AppendText(_fileName))
                {
                    for (int i = 0; i < data.Length; ++i)
                    {
                        sw.WriteLine(data[i]);
                    }
                    sw.Close();
                }
            }
            else
            {
                var writer = new StreamWriter(fileName + ".ghz");
                for (int i = 0; i < data.Length; ++i)
                {
                    writer.WriteLine(data[i]);
                }
                writer.Close();
            }

        }
        #endregion

        #region ReadWeight
        public int TotalLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    int i = 0;
                    while (r.ReadLine() != null) { i++; }
                    return i;
                }
            }else
            {
                return 0;
            }
            
        }
        public double[] _oldweight(string fileName)
        {
            try
            {
                string _fileName = @"" + fileName + ".ghz";
                int rowCount = TotalLines(_fileName);
                double[] _weights = new double[rowCount];
                if (File.Exists(_fileName))
                {
                    using (TextReader tr = new StreamReader(_fileName))
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            _weights[i] = double.Parse(tr.ReadLine());
                        }
                    }
                }
                return _weights;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Save KeyNotePad
        public void saveKeyNote(int[] data, string fileName)
        {
            string _fileName = @"" + fileName;
            if (File.Exists(_fileName))
            {
                using (StreamWriter sw = File.AppendText(_fileName))
                {
                    for (int i = 0; i < data.Length; ++i)
                    {
                        sw.WriteLine(data[i]);
                    }
                    sw.Close();
                }
            }
            else
            {
                var writer = new StreamWriter(fileName + ".ghz");
                for (int i = 0; i < data.Length; ++i)
                {
                    writer.WriteLine(data[i]);
                }
                writer.Close();
            }

        }
        #endregion

        #region GetKeyData
        public int[] GetKeyData(string fileName)
        {
            try
            {
                string _fileName = @"" + fileName + ".ghz";
                int rowCount = TotalLines(_fileName);
                int[] _weights = new int[rowCount];
                if (File.Exists(_fileName))
                {
                    using (TextReader tr = new StreamReader(_fileName))
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            _weights[i] = int.Parse(tr.ReadLine());
                        }
                    }
                }
                return _weights;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Save Setting JST
        public bool saveSettingJst(double[] data, string fileName)
        {
            string _fileName = @"" + fileName;
            if (File.Exists(_fileName))
            {
                using (StreamWriter sw = File.AppendText(_fileName))
                {
                    for (int i = 0; i < data.Length; ++i)
                    {
                        sw.WriteLine(data[i]);
                    }
                    sw.Close();
                }
            }
            else
            {
                var writer = new StreamWriter(fileName + ".jst");
                for (int i = 0; i < data.Length; ++i)
                {
                    writer.WriteLine(data[i]);
                }
                writer.Close();
            }
            return true;
        }
        #endregion

        #region ReadSettingJst
        public double[] GetSetJST(string fileName)
        {
            try
            {
                string _fileName = @"" + fileName + ".jst";
                int rowCount = TotalLines(_fileName);
                double[] _weights = new double[rowCount];
                if (File.Exists(_fileName))
                {
                    using (TextReader tr = new StreamReader(_fileName))
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            _weights[i] = double.Parse(tr.ReadLine());
                        }
                    }
                }
                return _weights;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Validate File Check
        public bool isCheckFile(string FileName)
        {
            if (File.Exists(FileName))
            {
                return true;
            }else
            {
                return false;
            }
        }
        #endregion

        #region Check Connection
        Database db = new Database();
        public bool isConnected()
        {
            if (db.OpenConnection())
            {
                return true;
            }else
            {
                return false;
            }
        }
        #endregion

    }
}
