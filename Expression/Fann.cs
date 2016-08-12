using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZedGraph;
namespace Expression
{
    public class Fann
    {
        #region Properties
        private Random rnd;
        private Database db = new Database();
        private int numInput;
        private int numHidden;
        private int numOutput;

        private double[] inputs;

        private double[][] ihWeights; // input-hidden
        private double[] hBiases;
        private double[] hOutputs;

        private double[][] hoWeights; // hidden-output
        private double[] oBiases;

        private double[] outputs;

        // back-prop specific arrays (these could be local to UpdateWeights)
        private double[] oGrads; // output gradients for back-propagation
        private double[] hGrads; // hidden gradients for back-propagation

        // back-prop momentum specific arrays (necessary as class members)
        private double[][] ihPrevWeightsDelta;  // for momentum with back-propagation
        private double[] hPrevBiasesDelta;
        private double[][] hoPrevWeightsDelta;
        private double[] oPrevBiasesDelta;
        #endregion

        #region CTOR
        public Fann(int numInput, int numHidden, int numOutput)
        {
            rnd = new Random(0);
            this.numInput = numInput;
            this.numHidden = numHidden;
            this.numOutput = numOutput;

            this.inputs = new double[numInput];

            this.ihWeights = MakeMatrix(numInput, numHidden);
            this.hBiases = new double[numHidden];
            this.hOutputs = new double[numHidden];

            this.hoWeights = MakeMatrix(numHidden, numOutput);
            this.oBiases = new double[numOutput];

            this.outputs = new double[numOutput];

            // back-prop related arrays below
            this.hGrads = new double[numHidden];
            this.oGrads = new double[numOutput];

            this.ihPrevWeightsDelta = MakeMatrix(numInput, numHidden);
            this.hPrevBiasesDelta = new double[numHidden];
            this.hoPrevWeightsDelta = MakeMatrix(numHidden, numOutput);
            this.oPrevBiasesDelta = new double[numOutput];
        }
        #endregion

        #region Function Activation
        private double f(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        private double derivative(double x)
        {
            return x * (1 - x);
        }
        #endregion

        #region View Matrix in Table
        public void ShowMatrix(double[][] matrix, int numRows, int decimals, bool newLine)
        {
            for (int i = 0; i < numRows; ++i)
            {
                Console.Write(i.ToString().PadLeft(3) + ": ");
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    Console.Write(matrix[i][j].ToString("F" + decimals) + " ");
                }
                Console.WriteLine("");
            }
            if (newLine == true) Console.WriteLine("");
        }
        #endregion

        #region Make Matrix
        public double[][] MakeMatrix(int rows, int cols) // helper for ctor
        {
            double[][] result = new double[rows][];
            for (int r = 0; r < result.Length; ++r)
                result[r] = new double[cols];
            return result;
        }
        #endregion

        #region View Weights
        public void ShowVector(double[] vector, int valsPerRow, int decimals, bool newLine)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                if (i % valsPerRow == 0) Console.WriteLine("");
                Console.Write(vector[i].ToString("F" + decimals).PadLeft(decimals + 4) + " ");
            }
            if (newLine == true) Console.WriteLine("");
        }
        #endregion

        #region SetWeights
        public void SetWeights(double[] weights)
        {
            int numWeights = (numInput * numHidden) + (numHidden * numOutput) + numHidden + numOutput;
            if (weights.Length != numWeights)
            {
                throw new Exception("Bad weights array lenght");
            }
            int k = 0;
            /*1. Retrieve Weight input to hidden*/
            for (int i = 0; i < numInput; i++)
            {
                for (int j = 0; j < numHidden; ++j)
                {
                    ihWeights[i][j] = weights[k++];
                }
            }
            /*2. Retrieve bias weight to hidden */
            for (int i = 0; i < numHidden; ++i)
            {
                hBiases[i] = weights[k++];
            }
            /*3. Retrieve weights hidden to output*/
            for (int i = 0; i < numHidden; ++i)
            {
                for (int j = 0; j < numOutput; ++j)
                {
                    hoWeights[i][j] = weights[k++];
                }
            }
            /*4. Retrieve bias weights to output*/
            for (int i = 0; i < numOutput; ++i)
            {
                oBiases[i] = weights[k++];
            }
        }
        #endregion

        #region Initialized weight from DB
        public void InitializedWeightsDB(double[] oldWeights)
        {
            int numweights = (numInput * numHidden) + (numHidden * numOutput) + numHidden + numOutput;
            double[] initialWeights = new double[numweights];
            for (int i = 0; i < initialWeights.Length; ++i)
            {
                initialWeights[i] = oldWeights[i];
            }
            this.SetWeights(initialWeights);
        }
        #endregion

        #region Initialized Weights Random Value
        public void InitializedWeights()
        {
            int numweights = (numInput * numHidden) + (numHidden * numOutput) + numHidden + numOutput;
            double[] initialWeights = new double[numweights];
            for (int i = 0; i < initialWeights.Length; ++i)
            {
                initialWeights[i] = (0.001 - 0.0001) * rnd.NextDouble() + 0.0001;
            }
            this.SetWeights(initialWeights);
        }
        #endregion

        #region Get Weights after Training
        public double[] Getweights()
        {
            int numWeights = (numInput * numHidden) + (numHidden * numOutput) + numHidden + numOutput;
            double[] result = new double[numWeights];
            int k = 0;
            /*1. Get Weights input to hidden*/
            for (int i = 0; i < ihWeights.Length; ++i)
            {
                for (int j = 0; j < ihWeights[0].Length; ++j)
                {
                    result[k++] = ihWeights[i][j];
                }
            }
            /*2. Get bias Weights to Hidden */
            for (int i = 0; i < hBiases.Length; ++i)
            {
                result[k++] = hBiases[i];
            }
            /*3. Get Weights hidden to output*/
            for (int i = 0; i < hoWeights.Length; ++i)
            {
                for (int j = 0; j < hoWeights[0].Length; ++j)
                {
                    result[k++] = hoWeights[i][j];
                }
            }
            /*4. Get bias Weights */
            for (int i = 0; i < oBiases.Length; ++i)
            {
                result[k++] = oBiases[i];
            }
            return result;
        }
        #endregion

        #region Compute Outputs
        private double[] ComputeOutputs(double[] xValues)
        {
            if (xValues.Length != numInput)
            {
                throw new Exception("Bad xValues array length");
            }

            double[] hsums = new double[numHidden];
            double[] oSums = new double[numOutput];

            for (int i = 0; i < xValues.Length; ++i)
            {
                this.inputs[i] = xValues[i];
            }
            /*1.Compute Total (input*weights) */
            for (int j = 0; j < numHidden; ++j)
            {
                for (int i = 0; i < numInput; ++i)
                {
                    hsums[j] += this.inputs[i] * this.ihWeights[i][j];
                }
            }
            /*2. Compute Total (Bias*biasweights)*/
            for (int i = 0; i < numHidden; ++i)
            {
                hsums[i] += this.hBiases[i];
            }
            /*3. Compute Z apply activation sogmoid*/
            for (int i = 0; i < numHidden; ++i)
            {
                this.hOutputs[i] = f(hsums[i]);
            }
            /*4. Compute Sum Hidden to Output*/
            for (int j = 0; j < numOutput; ++j)
            {
                for (int i = 0; i < numHidden; ++i)
                {
                    oSums[j] += hOutputs[i] * hoWeights[i][j];
                }
            }
            /*5. Compute Sum Bias Hidden to Ouput*/
            for (int i = 0; i < numOutput; ++i)
            {
                oSums[i] += oBiases[i];
            }
            /*6. Compute yValues*/
            double[] _y = new double[oSums.Length];
            for (int i = 0; i < numOutput; ++i)
            {
                _y[i] = f(oSums[i]);
            }
            Array.Copy(_y, outputs, _y.Length);
            double[] retResults = new double[numOutput];
            Array.Copy(this.outputs, retResults, retResults.Length);
            return retResults;
        }
        #endregion

        #region Update Weights
        private void UpdateWeights(double[] tValues, double learnRate, double momentum)
        {
            if (tValues.Length != numOutput)
            {
                throw new Exception("Target values not same length as output");
            }
            /*1. Compute Ouput Gradients (Teta)*/
            for (int i = 0; i < oGrads.Length; ++i)
            {
                oGrads[i] = derivative(outputs[i]) * (tValues[i] - outputs[i]);
            }
            /*2. Compute Hidden Gradien (Teta)*/
            for (int i = 0; i < hGrads.Length; ++i)
            {
                double sum = 0.0;// Teta In Z
                for (int j = 0; j < numOutput; ++j)
                {
                    double x = oGrads[j] * hoWeights[i][j];
                    sum += x;
                }
                hGrads[i] = derivative(hOutputs[i]) * sum;
            }
            /*3. Update Input-Hidden Weights (Gradients must be Compute)*/
            for (int i = 0; i < ihWeights.Length; ++i)
            {
                for (int j = 0; j < ihWeights[0].Length; ++j)
                {
                    double delta = learnRate * hGrads[j] * inputs[i];
                    ihWeights[i][j] += delta;// Update
                    ihWeights[i][j] += momentum * ihPrevWeightsDelta[i][j];
                    ihPrevWeightsDelta[i][j] = delta;
                }
            }
            /*4. Update Hidden Biases*/
            for (int i = 0; i < hBiases.Length; ++i)
            {
                double delta = learnRate * hGrads[i] * 1.0;//1.0 is the constant input biases
                hBiases[i] += delta;
                hBiases[i] += momentum * hPrevBiasesDelta[i];// add Momentum
                hPrevBiasesDelta[i] = delta;
            }
            /*5. Update Hidden- Ouput weights*/
            for (int i = 0; i < hoWeights.Length; ++i)
            {
                for (int j = 0; j < hoWeights[0].Length; ++j)
                {
                    double delta = learnRate * oGrads[j] * hOutputs[i];
                    hoWeights[i][j] += delta;
                    hoWeights[i][j] += momentum * hoPrevWeightsDelta[i][j];// Momentum
                    hoPrevWeightsDelta[i][j] = delta;
                }
            }
            /*6. Update Ouput Biases*/
            for (int i = 0; i < oBiases.Length; ++i)
            {
                double delta = learnRate * oGrads[i] * 1.0;
                oBiases[i] += delta;
                oBiases[i] += momentum * oPrevBiasesDelta[i];//Momentum
                oPrevBiasesDelta[i] = delta;
            }
        }
        #endregion

        #region Compute MSE
        private double MSE(double[][] trainData)
        {
            try
            {
                double sumError = 0.0;
                double[] xValues = new double[numInput];
                double[] tValues = new double[numOutput];

                for (int i = 0; i < trainData.Length; ++i)
                {
                    Array.Copy(trainData[i], xValues, numInput);
                    Array.Copy(trainData[i], numInput, tValues, 0, numOutput);
                    double[] yValues = this.ComputeOutputs(xValues);
                    for (int j = 0; j < numOutput; ++j)
                    {
                        double err = tValues[j] - yValues[j];
                        sumError +=Math.Round(  (Math.Pow(err, 2)),5);
                    }
                }
                return Math.Round ((sumError / trainData.Length),5);
                //return sumError;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
                return 0.0;
            }
        }
        #endregion

        #region Shuffle Data Training
        private void Shuffle(int[] sequence)
        {
            for (int i = 0; i < sequence.Length; ++i)
            {
                int r = rnd.Next(1, sequence.Length);
                int tmp = sequence[r];
                sequence[r] = sequence[i];
                sequence[i] = tmp;
            }
        }
        #endregion

        #region Accuracy Training Data
        public double Accuracy(double[][] testData)
        {
            double[] xValues = new double[numInput];
            double[] tValues = new double[numOutput];
            double[] yValues;
            double _accuracy = 0;
            double[][] result = new double[testData.Length][];
            for (int i = 0; i < testData.Length; ++i)
            {
                Array.Copy(testData[i], xValues, numInput);
                Array.Copy(testData[i], numInput, tValues, 0, numOutput);
                yValues = this.ComputeOutputs(xValues);
                //Console.WriteLine("data ke-{0} {1} - {2} : {3}", i, tValues[0], yValues[0], sumA(tValues[0], yValues[0]));
                _accuracy += sumA(Math.Round(tValues[0]),Math.Round(yValues[0]));
            }
            Console.WriteLine("Hasil={0} %",Math.Round(_accuracy/testData.Length)*100);
            return 0;
        }

        private double sumA(double enSum,double diSum)
        {

            double result = 0;
            result = 1 - (Math.Abs(enSum-diSum));
            return Math.Round(result);
        }
        #endregion

        #region MaxIndex
        private int MaxIndex(double[] vector)
        {
            int bigIndex = 0;
            double biggestVal = vector[0];
            for (int i = 0; i < vector.Length; ++i)
            {
                if (vector[i] > biggestVal)
                {
                    biggestVal = vector[i]; bigIndex = 1;
                }
            }
            return bigIndex;
        }
        #endregion

        #region Train Backpropagation
        public Dictionary<int,double> TrainBP(double[][] trainData, double maxError, int maxEpoch, double learnRate, double momentum,ref string hasil)
        {
            int epoch = 0;
            double mse = 0;
            Dictionary<int, double> _mse = new Dictionary<int, double>();
            double[] xValues = new double[numInput];// Input Values
            double[] tValues = new double[numOutput];//Target Values

            int[] sequence = new int[trainData.Length];
            for (int i = 0; i < sequence.Length; ++i)
            {
                sequence[i] = i;
            }
            try
            {
                do
                {
                    epoch++;
                    mse = MSE(trainData);
                    Shuffle(sequence);
                    for (int i = 0; i < trainData.Length; ++i)
                    {
                        int idx = sequence[i];
                        Array.Copy(trainData[idx], xValues, numInput);
                        Array.Copy(trainData[idx], numInput, tValues, 0, numOutput);
                        ComputeOutputs(xValues);
                        UpdateWeights(tValues, learnRate, momentum);
                    }
                    //if (epoch % 10 == 0)
                    //{
                    //    Console.WriteLine(epoch + " : " + mse);
                    //}
                    //_mse.Add(epoch, mse);

                } while ((epoch < maxEpoch) && (mse > maxError));
                hasil = "SSE : " + mse.ToString("F4") + ", Iterasi : " + epoch.ToString();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return _mse;
        }
        #endregion

        #region Test Backpropagation
        public void TestBP(double[][] testData,ref ListBox Terminal,ref double _accuracy)
        {
            //Terminal.Items.Clear();
            double[] xValues = new double[numInput];
            double[] tValues = new double[numOutput];
            double[] yValues;
            double numCorrect = 0;
            try
            {
                for (int i = 0; i < testData.Length; ++i)
                {
                    Array.Copy(testData[i], xValues, numInput);
                    Array.Copy(testData[i], numInput, tValues, 0, numOutput);
                    yValues = this.ComputeOutputs(xValues);
                    string xOuput = null;
                    string yOutput = null;
                    string _target = null;
                    string _hasil = null;
                    for (int j = 0; j < numOutput; j++)
                    {
                        //Terminal.Items.Add("yValues- " + j + " = " + yValues[j].ToString("F4"));
                        xOuput += (Math.Round(yValues[j])).ToString();
                        yOutput += (Math.Round(tValues[j])).ToString();
                    }
                    db.getFinallyOutput(yOutput, ref _target);
                    db.getFinallyOutput(xOuput, ref _hasil);
                    string _maches = (xOuput == yOutput) ? "BENAR" : "SALAH";
                    numCorrect += (xOuput == yOutput) ? 1 : 0;
                    Terminal.Items.Add("Data-"+(i+1)+" Target: "+yOutput+" ("+_target+") , Output: "+xOuput+" ("+_hasil+"), Kecocokan:"+_maches);
                    Terminal.Items.Add("---------------------------------------------------------------------------------------");
                }
                _accuracy = numCorrect / testData.Length;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region Indentification Backpropagation
        public void Indentification(double[][] identData,ref double yOutput)
        {
            double[] xValues = new double[numInput];
            double[] yValues;
            try
            {
                for (int i = 0; i < identData.Length; ++i)
                {
                    Array.Copy(identData[i], xValues, numInput);
                    //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",xValues[0], xValues[1], xValues[2], xValues[3], xValues[4], xValues[5]);
                    yValues = this.ComputeOutputs(xValues);
                    for (int j = 0; j < numOutput; j++)
                    {
                        yOutput = yValues[j];
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
