using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace Expression
{
    public class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        Random r = new Random();

        #region CONSTRUKTOR
        public Database()
        {
            Initialize();
        }
        #endregion

        #region INITIALIZE DATABASE CONFIG
        private void Initialize()
        {
            server = "localhost";
            database = "emotion";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        #endregion

        #region CONNECTION
        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Koneksi ke Server Error !","Kegagalan",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;

                    case 1045:
                        MessageBox.Show("Username/Password Tidak Ditemukan !", "Kegagalan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region GET OUTPUT
        public void getOutput(ref ComboBox cbOutput)
        {
            this.CloseConnection();
            string query = "select * from output";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbOutput.Items.Add(reader.GetString("Output"));
                }
                reader.Close();

                this.CloseConnection();
            }
        }
        #endregion

        #region Get USER ID
        public void getUserID(ref ComboBox cbUserId)
        {
            this.CloseConnection();
            string query = "SELECT user.`idUser` FROM `emotion`.`user`;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbUserId.Items.Add(reader.GetString("idUser"));
                }
                reader.Close();

                this.CloseConnection();
            }
        }
        #endregion

        #region Get UserIDByFullName
        public void UserId(ref string idUser,string fullname)
        {
            this.CloseConnection();
            string query = "SELECT user.`idUser` FROM `emotion`.`user` WHERE user.`fullName`='"+fullname+"';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idUser= reader.GetString("idUser");
                }
                reader.Close();

                this.CloseConnection();
            }
        }
        #endregion

        #region Get All User
        public void getAllUser(ref ComboBox cbUserId)
        {
            this.CloseConnection();
            string query = "SELECT user.`fullName` FROM `emotion`.`user`;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbUserId.Items.Add(reader.GetString("fullName"));
                }
                reader.Close();

                this.CloseConnection();
            }
        }
        #endregion

        #region GET ID OUTPUT
        public void getIdOutput(string Output, ref string idOutput)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "select * from output";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(ds1, "output1");
                DataTable dt1 = ds1.Tables["output1"];
                DataColumn[] col1 = new DataColumn[1];
                col1[0] = dt1.Columns["output"];
                dt1.PrimaryKey = col1;
                DataRow rw1 = dt1.Rows.Find(Output);
                idOutput = (string)rw1["idOutput"];

            }
        }
        #endregion

        #region Get Finally Output
        public void getFinallyOutput(string key, ref string outputName)
        {
            this.CloseConnection();
            if (this.OpenConnection())
            {
                string query = "SELECT `output`.`Output` FROM `emotion`.`output` WHERE `idOutput`='" + key + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    outputName = reader.GetString("Output");
                }
                reader.Close();

            }
            this.CloseConnection();
        }
        #endregion

        #region SAVE DATA TRAINING
        public bool saveTrainingData(string idUser, string idOutput, string F1, string F2, string F3, string F4, string F5, string F6)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "INSERT INTO `emotion`.`training` (`idOutput`, `F1`, `F2`, `F3`, `F4`, `F5`, `F6`, `idUser`)" +
                        "VALUES ('" + idOutput + "', '" + F1 + "', '" + F2 + "', '" + F3 + "', '" + F4 + "', '" + F5 + "', '" + F6 + "', '" + idUser + "'); ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        #endregion

        #region VIEW DATA TRAINING TABLE
        public void viewDataTraining(ref DataGridView dataTraining, string idUser)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT `training`.`F1` , `training`.`F2`, `training`.`F3`, `training`.`F4`" +
                               ", `training`.`F5`, `training`.`F6`, `output`.`Output`, `training`.`idUser`" +
                               "FROM `emotion`.`training` INNER JOIN `emotion`.`output` ON(`training`.`idOutput` = `output`.`idOutput`)" +
                               "INNER JOIN `emotion`.`user` ON(`training`.`idUser` = `user`.`idUser`)WHERE `emotion`.`training`.`idUser`='" + idUser + "' ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(ds1, "training");
                dataTraining.DataSource = ds1;
                dataTraining.DataMember = "training";
                //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                //checkBoxColumn.HeaderText = "Pilih";
                //checkBoxColumn.Width = 100;
                //checkBoxColumn.Name = "checkBoxColumn";
                //dataTraining.Columns.Insert(0, checkBoxColumn);
                CheckBox checkboxHeader = new CheckBox();
                dataTraining.Columns[1].HeaderText = "F1";
                dataTraining.Columns[2].HeaderText = "F2";
                dataTraining.Columns[3].HeaderText = "F3";
                dataTraining.Columns[4].HeaderText = "F4";
                dataTraining.Columns[5].HeaderText = "F5";
                dataTraining.Columns[6].HeaderText = "F6";
                dataTraining.Columns[7].HeaderText = "Target";
                dataTraining.Columns[8].HeaderText = "User ID";
                dataTraining.Columns[1].Width = 70;
                dataTraining.Columns[2].Width = 70;
                dataTraining.Columns[3].Width = 70;
                dataTraining.Columns[4].Width = 70;
                dataTraining.Columns[5].Width = 70;
                dataTraining.Columns[6].Width = 70;
                dataTraining.Columns[7].Width = 60;
                dataTraining.Columns[8].Width = 160;
                
                this.CloseConnection();
            }
        }
        #endregion

        #region View Data ChechList
        public void viewDataTable(ref DataGridView dataTraining, string idUser) {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT `training`.`idTraining`, `training`.`F1` , `training`.`F2`, `training`.`F3`, `training`.`F4`" +
                               ", `training`.`F5`, `training`.`F6`, `output`.`Output`" +
                               "FROM `emotion`.`training` INNER JOIN `emotion`.`output` ON(`training`.`idOutput` = `output`.`idOutput`)" +
                               "INNER JOIN `emotion`.`user` ON(`training`.`idUser` = `user`.`idUser`)WHERE `emotion`.`training`.`idUser`='" + idUser + "' ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(ds1, "training");
                dataTraining.DataSource = ds1;
                dataTraining.DataMember = "training";

                CheckBox checkboxHeader = new CheckBox();
                dataTraining.Columns[1].HeaderText = "ID";
                dataTraining.Columns[2].HeaderText = "F1";
                dataTraining.Columns[3].HeaderText = "F2";
                dataTraining.Columns[4].HeaderText = "F3";
                dataTraining.Columns[5].HeaderText = "F4";
                dataTraining.Columns[6].HeaderText = "F5";
                dataTraining.Columns[7].HeaderText = "F6";
                dataTraining.Columns[8].HeaderText = "Target";
                dataTraining.Columns[1].Width = 70;
                dataTraining.Columns[2].Width = 70;
                dataTraining.Columns[3].Width = 70;
                dataTraining.Columns[4].Width = 70;
                dataTraining.Columns[5].Width = 70;
                dataTraining.Columns[6].Width = 70;
                dataTraining.Columns[7].Width = 60;
                dataTraining.Columns[8].Width = 160;

                this.CloseConnection();
            }
        }
        #endregion

        #region View Data ALL
        public void ViewDataAll(ref DataGridView DataAll)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT `training`.`idTraining`, `user`.`idUser`"+
                                ", `user`.`fullName`, `training`.`F1`,`training`.`F2`"+
                                ", `training`.`F3`, `training`.`F4`, `training`.`F5`, `training`.`F6`"+
                                ", `output`.`Output` FROM `emotion`.`training` INNER JOIN `emotion`.`user`"+ 
                                "ON(`training`.`idUser` = `user`.`idUser`) INNER JOIN `emotion`.`output`"+ 
                                "ON(`training`.`idOutput` = `output`.`idOutput`); ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(ds1, "alldata");
                DataAll.DataSource = ds1;
                DataAll.DataMember = "alldata";

                DataAll.Columns[0].HeaderText = "ID";
                DataAll.Columns[1].HeaderText = "ID USER";
                DataAll.Columns[2].HeaderText = "FULLNAME";
                DataAll.Columns[3].HeaderText = "F1";
                DataAll.Columns[4].HeaderText = "F2";
                DataAll.Columns[5].HeaderText = "F3";
                DataAll.Columns[6].HeaderText = "F4";
                DataAll.Columns[7].HeaderText = "F5";
                DataAll.Columns[8].HeaderText = "F6";
                DataAll.Columns[9].HeaderText = "IDENTIFIKASI";
                DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                DataAll.Columns.Add(detail);
                detail.HeaderText = "";
                detail.Text = "Detail";
                detail.Name = "btnDetail";
                detail.UseColumnTextForButtonValue = true;
                
                DataAll.Columns.Add(delete);
                delete.HeaderText = "";
                delete.Text = "Hapus";
                delete.Name = "btnDel";
                delete.UseColumnTextForButtonValue = true;

                DataAll.Columns[0].Width = 40;
                DataAll.Columns[1].Width = 120;
                DataAll.Columns[2].Width = 120;
                DataAll.Columns[3].Width = 60;
                DataAll.Columns[4].Width = 60;
                DataAll.Columns[5].Width = 60;
                DataAll.Columns[6].Width = 60;
                DataAll.Columns[7].Width = 60;
                DataAll.Columns[8].Width = 60;
                DataAll.Columns[9].Width = 80;
                DataAll.Columns[10].Width = 70;
                DataAll.Columns[11].Width = 70;

            }
            this.CloseConnection();
        }
        #endregion

        #region View Data Testing
        public void viewDataTesting(ref DataGridView dataTesting)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT `testing`.`idTesting`, `testing`.`F1`, `testing`.`F2`, `testing`.`F3`, `testing`.`F4`, `testing`.`F5`, `testing`.`F6`, `output`.`Output`" +
                                ", `testing`.`sad`, `testing`.`happy`, `user`.`fullName`" +
                                "FROM `emotion`.`testing` INNER JOIN `emotion`.`output` ON(`testing`.`idOutput` = `output`.`idOutput`) INNER JOIN `emotion`.`user`" +
                                "ON(`testing`.`idUser` = `user`.`idUser`) WHERE sad>= 5 AND `happy`<= 95 ORDER BY `idTesting` ; ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(ds1, "testing");
                dataTesting.DataSource = ds1;
                dataTesting.DataMember = "testing";

                dataTesting.Columns[0].HeaderText = "ID";
                dataTesting.Columns[1].HeaderText = "F1";
                dataTesting.Columns[2].HeaderText = "F2";
                dataTesting.Columns[3].HeaderText = "F3";
                dataTesting.Columns[4].HeaderText = "F4";
                dataTesting.Columns[5].HeaderText = "F5";
                dataTesting.Columns[6].HeaderText = "F6";
                dataTesting.Columns[7].HeaderText = "Hasil";
                dataTesting.Columns[8].HeaderText = "Sedih(%)";
                dataTesting.Columns[9].HeaderText = "Senang(%)";
                dataTesting.Columns[10].HeaderText = "Nama User";

                dataTesting.Columns[0].Width = 40;
                dataTesting.Columns[1].Width = 50;
                dataTesting.Columns[2].Width = 70;
                dataTesting.Columns[3].Width = 70;
                dataTesting.Columns[4].Width = 70;
                dataTesting.Columns[5].Width = 70;
                dataTesting.Columns[6].Width = 70;
                dataTesting.Columns[7].Width = 70;
                dataTesting.Columns[8].Width = 70;
                dataTesting.Columns[9].Width = 70;
                dataTesting.Columns[10].Width = 150;

            }
            this.CloseConnection();
        }
        #endregion

        #region GET COUNT TRAINING
        public int countTrain(string idUser)
        {
            this.CloseConnection();
            this.OpenConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM `emotion`.`training` WHERE `idUser`='" + idUser + "';";
                MySqlCommand cmd;
                using (cmd = new MySqlCommand(query, connection))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }
        #endregion

        #region POPULATE DATA TRAINING
        public void populateDataTraining(out double[] F1, out double[] F2, out double[] F3, out double[] F4, out double[] F5, out double[] F6
            , out double[] tValues, int num, string idUser)
        {
            F1 = new double[num];
            F2 = new double[num];
            F3 = new double[num];
            F4 = new double[num];
            F5 = new double[num];
            F6 = new double[num];
            tValues = new double[num];
            this.CloseConnection();
            this.OpenConnection();
            /*
            string query = "SELECT `emotion`.`training`.`idOutput`, (`F1`/(SELECT GREATEST(MAX(`F1`),MAX(`F2`),MAX(`F3`),MAX(`F4`),MAX(`F5`),MAX(`F6`)) FROM `training`))AS 'F1',"+
                    "(`F2`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F2',"+
					"(`F3`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F3',"+
					"(`F4`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F4',"+
					"(`F5`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F5',"+
					"(`F6`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F6'"+
                    "FROM `emotion`.`training`; ";
            */
            string query = "SELECT `emotion`.`training`.`idOutput`,(`F1`/(SELECT MAX(F1) FROM `emotion`.`training`))AS 'F1'," +
                           "(`F2`/ (SELECT MAX(F2) FROM `emotion`.`training`))AS 'F2',(`F3`/ (SELECT MAX(F3) FROM `emotion`.`training`))AS 'F3'," +
                           "(`F4`/ (SELECT MAX(F4) FROM `emotion`.`training`))AS 'F4',(`F5`/ (SELECT MAX(F5) FROM `emotion`.`training`))AS 'F5'," +
                           "(`F6`/ (SELECT MAX(F6) FROM `emotion`.`training`))AS 'F6' FROM `training` WHERE `idUser`= '" + idUser + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            for (int i = 0; i < num; i++)
            {
                reader.Read();
                double f1 = Convert.ToDouble(reader.GetString("F1"));
                double f2 = Convert.ToDouble(reader.GetString("F2"));
                double f3 = Convert.ToDouble(reader.GetString("F3"));
                double f4 = Convert.ToDouble(reader.GetString("F4"));
                double f5 = Convert.ToDouble(reader.GetString("F5"));
                double f6 = Convert.ToDouble(reader.GetString("F6"));
                double target = Convert.ToDouble(reader.GetString("idOutput"));
                F1[i] = f1;
                F2[i] = f2;
                F3[i] = f3;
                F4[i] = f4;
                F5[i] = f5;
                F6[i] = f6;
                tValues[i] = target;
            }
            reader.Close();
            this.CloseConnection();

        }
        #endregion

        #region Update Weight
        public void UpdateWeight(double[] weight, double cerebrofit)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "UPDATE `emotion`.`weight` SET `wi1` = '" + weight[0] + "' , `wi2` = '" + weight[1] + "' , `wi3` = '" + weight[2] + "' ," +
                                   "`wi4` = '" + weight[3] + "' , `wi5` = '" + weight[4] + "' , `wi6` = '" + weight[5] + "' , `wi7` = '" + weight[6] + "' , `wi8` = '" + weight[7] + "' ," +
                                   "`wi9` = '" + weight[8] + "' , `wi10` = '" + weight[9] + "' , `wi11` = '" + weight[10] + "' , `wi12` = '" + weight[11] + "' , `wi13` = '" + weight[12] + "' ," +
                                   "`wi14` = '" + weight[13] + "' , `wi15` = '" + weight[14] + "' , `wi16` = '" + weight[15] + "' , `wi17` = '" + weight[16] + "' , `wi18` = '" + weight[17] + "' ," +
                                   "`bi1` = '" + weight[18] + "' , `bi2` = '" + weight[19] + "' , `bi3` = '" + weight[20] + "' , `wj1` = '" + weight[21] + "' , `wj2` = '" + weight[22] + "' , `wj3` = '" + weight[23] + "' ," +
                                   "`bj1` = '" + weight[24] + "' , `kb` = '" + cerebrofit + "' WHERE `idWeight` = 'W01';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                this.CloseConnection();
            }
        }
        #endregion

        #region SaveWeightUser
        public bool newWeightUser(string idUser)
        {
            double[] weights = new double[25];
            double cerebrofit = setCerebrofit();
            for (int i = 0; i < 25; i++)
            {
                weights[i] = r.NextDouble();
            }
            string query = "INSERT INTO `emotion`.`weight` (`wi1`, `wi2`, `wi3`, `wi4`, `wi5`, `wi6`, `wi7`," +
                "`wi8`, `wi9`, `wi10`, `wi11`, `wi12`, `wi13`, `wi14`, `wi15`, `wi16`, `wi17`, `wi18`, `bi1`," +
                "`bi2`, `bi3`, `wj1`, `wj2`, `wj3`, `bj1`, `kb`, `idUser`) VALUES ('" + weights[0] + "', '" + weights[1] + "', '" + weights[2] + "', '" + weights[3] + "'," +
                "'" + weights[4] + "', '" + weights[5] + "', '" + weights[6] + "', '" + weights[7] + "', '" + weights[8] + "', '" + weights[9] + "', '" + weights[10] + "', " +
                "'" + weights[11] + "', '" + weights[12] + "', '" + weights[13] + "', '" + weights[14] + "', '" + weights[15] + "', '" + weights[16] + "', '" + weights[17] + "'," +
                "'" + weights[18] + "', '" + weights[19] + "', '" + weights[20] + "', '" + weights[21] + "', '" + weights[22] + "', '" + weights[23] + "', '" + weights[24] + "', '" + cerebrofit + "', '" + idUser + "'); ";
            this.CloseConnection();
            try
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        #endregion

        #region getWeightsByUser
        public bool getWeightByUser(out double[] initialWeights, out double cerebrofit, string idUser)
        {
            this.CloseConnection();
            cerebrofit = 0.5;
            initialWeights = new double[29];
            try
            {
                this.OpenConnection();
                string query = " SELECT * FROM `weight` WHERE `weight`.`idUser`='" + idUser + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    initialWeights[0] = Convert.ToDouble(reader.GetString("wi1"));
                    initialWeights[1] = Convert.ToDouble(reader.GetString("wi2"));
                    initialWeights[2] = Convert.ToDouble(reader.GetString("wi3"));
                    initialWeights[3] = Convert.ToDouble(reader.GetString("wi4"));
                    initialWeights[4] = Convert.ToDouble(reader.GetString("wi5"));

                    initialWeights[5] = Convert.ToDouble(reader.GetString("wi6"));
                    initialWeights[6] = Convert.ToDouble(reader.GetString("wi7"));
                    initialWeights[7] = Convert.ToDouble(reader.GetString("wi8"));
                    initialWeights[8] = Convert.ToDouble(reader.GetString("wi9"));
                    initialWeights[9] = Convert.ToDouble(reader.GetString("wi10"));

                    initialWeights[10] = Convert.ToDouble(reader.GetString("wi11"));
                    initialWeights[11] = Convert.ToDouble(reader.GetString("wi12"));
                    initialWeights[12] = Convert.ToDouble(reader.GetString("wi13"));
                    initialWeights[13] = Convert.ToDouble(reader.GetString("wi14"));
                    initialWeights[14] = Convert.ToDouble(reader.GetString("wi15"));

                    initialWeights[15] = Convert.ToDouble(reader.GetString("wi16"));
                    initialWeights[16] = Convert.ToDouble(reader.GetString("wi17"));
                    initialWeights[17] = Convert.ToDouble(reader.GetString("wi18"));

                    initialWeights[18] = Convert.ToDouble(reader.GetString("bi1"));
                    initialWeights[19] = Convert.ToDouble(reader.GetString("bi2"));
                    initialWeights[20] = Convert.ToDouble(reader.GetString("bi3"));

                    initialWeights[21] = Convert.ToDouble(reader.GetString("wj1"));
                    initialWeights[22] = Convert.ToDouble(reader.GetString("wj2"));
                    initialWeights[23] = Convert.ToDouble(reader.GetString("wj3"));
                    initialWeights[24] = Convert.ToDouble(reader.GetString("bj1"));
                    cerebrofit = Convert.ToDouble(reader.GetString("kb"));
                }
                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        #region PopulateDataTrainingbyUser
        public void populateDataTrainingbyUser(out double[] F1, out double[] F2, out double[] F3, out double[] F4, out double[] F5, out double[] F6
           , out double[] tValues, string idUser, int numRows)
        {

            this.CloseConnection();
            this.OpenConnection();
            /*
            string query = "SELECT `emotion`.`training`.`idOutput`, (`F1`/(SELECT GREATEST(MAX(`F1`),MAX(`F2`),MAX(`F3`),MAX(`F4`),MAX(`F5`),MAX(`F6`)) FROM `training`))AS 'F1'," +
                    "(`F2`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F2'," +
                    "(`F3`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F3'," +
                    "(`F4`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F4'," +
                    "(`F5`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F5'," +
                    "(`F6`/ (SELECT GREATEST(MAX(`F1`), MAX(`F2`), MAX(`F3`), MAX(`F4`), MAX(`F5`), MAX(`F6`)) FROM `training`))AS 'F6'" +
                    "FROM `emotion`.`training` WHERE `idUser`='" + idUser + "'; ";
                    */
            string query = "SELECT `emotion`.`training`.`idOutput`,(`F1`/(SELECT MAX(F1) FROM `emotion`.`training`))AS 'F1'," +
                           "(`F2`/ (SELECT MAX(F2) FROM `emotion`.`training`))AS 'F2',(`F3`/ (SELECT MAX(F3) FROM `emotion`.`training`))AS 'F3'," +
                           "(`F4`/ (SELECT MAX(F4) FROM `emotion`.`training`))AS 'F4',(`F5`/ (SELECT MAX(F5) FROM `emotion`.`training`))AS 'F5'," +
                           "(`F6`/ (SELECT MAX(F6) FROM `emotion`.`training`))AS 'F6' FROM `training` WHERE `idUser`= '" + idUser + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            F1 = new double[numRows];
            F2 = new double[numRows];
            F3 = new double[numRows];
            F4 = new double[numRows];
            F5 = new double[numRows];
            F6 = new double[numRows];
            tValues = new double[numRows];
            for (int i = 0; i < numRows; i++)
            {
                reader.Read();
                double f1 = Convert.ToDouble(reader.GetString("F1"));
                double f2 = Convert.ToDouble(reader.GetString("F2"));
                double f3 = Convert.ToDouble(reader.GetString("F3"));
                double f4 = Convert.ToDouble(reader.GetString("F4"));
                double f5 = Convert.ToDouble(reader.GetString("F5"));
                double f6 = Convert.ToDouble(reader.GetString("F6"));
                double target = Convert.ToDouble(reader.GetString("idOutput"));
                F1[i] = f1;
                F2[i] = f2;
                F3[i] = f3;
                F4[i] = f4;
                F5[i] = f5;
                F6[i] = f6;
                tValues[i] = target;
            }
            reader.Close();
            this.CloseConnection();

        }
        #endregion

        #region DataTrainingChoosed
        public void populateDataChoosed(ref double F1, ref double F2, ref double F3, ref double F4, ref double F5, ref double F6
           , ref double tValues, string idUser)
        {
            this.CloseConnection();
            this.OpenConnection();
            string query = "SELECT `emotion`.`training`.`idOutput`,(`F1`/(SELECT MAX(F1) FROM `emotion`.`training`))AS 'F1',"+
                           "(`F2`/ (SELECT MAX(F2) FROM `emotion`.`training`))AS 'F2',(`F3`/ (SELECT MAX(F3) FROM `emotion`.`training`))AS 'F3',"+
                           "(`F4`/ (SELECT MAX(F4) FROM `emotion`.`training`))AS 'F4',(`F5`/ (SELECT MAX(F5) FROM `emotion`.`training`))AS 'F5',"+
                           "(`F6`/ (SELECT MAX(F6) FROM `emotion`.`training`))AS 'F6' FROM `training` WHERE `emotion`.`training`.`idTraining`= '"+idUser+"'; ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 F1 = Convert.ToDouble(reader.GetString("F1"));
                 F2 = Convert.ToDouble(reader.GetString("F2"));
                 F3 = Convert.ToDouble(reader.GetString("F3"));
                 F4 = Convert.ToDouble(reader.GetString("F4"));
                 F5 = Convert.ToDouble(reader.GetString("F5"));
                 F6 = Convert.ToDouble(reader.GetString("F6"));
                tValues = Convert.ToDouble(reader.GetString("idOutput"));
                //Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}",F1,F2,F3,F4,F5,F6,tValues);
            }
            reader.Close();
            this.CloseConnection();
        }
        #endregion

        #region Update WeightsbyUser
        public void UpdateWeightbyUser(double[] weight, double cerebrofit, string idUser)
        {
            this.CloseConnection();
            this.OpenConnection();
            try
            {
                string query = "UPDATE `emotion`.`weight` SET `wi1` = '" + weight[0] + "' , `wi2` = '" + weight[1] + "' , `wi3` = '" + weight[2] + "' , `wi4` = '" + weight[3] + "' , `wi5` = '" + weight[4] + "' , `wi6` = '" + weight[5] + "' ," +
                                "`wi7` = '" + weight[6] + "' , `wi8` = '" + weight[7] + "' , `wi9` = '" + weight[8] + "' , `wi10` = '" + weight[9] + "' , `wi11` = '" + weight[10] + "' , `wi12` = '" + weight[11] + "' , `wi13` = '" + weight[12] + "' , `wi14` = '" + weight[13] + "' ," +
                                "`wi15` = '" + weight[14] + "' , `wi16` = '" + weight[15] + "' , `wi17` = '" + weight[16] + "' , `wi18` = '" + weight[17] + "' , `bi1` = '" + weight[18] + "' , `bi2` = '" + weight[19] + "' , `bi3` = '" + weight[20] + "' , `wj1` = '" + weight[21] + "' , " +
                                "`wj2` = '" + weight[22] + "' , `wj3` = '" + weight[23] + "' , `bj1` = '" + weight[24] + "' , `kb` = '" + cerebrofit + "' WHERE `weight`.`idUser`= '" + idUser + "'; ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.CloseConnection();
        }
        #endregion

        #region SetCerebrofit
        public double setCerebrofit()
        {
            this.CloseConnection();
            this.OpenConnection();
            try
            {
                string query = "SELECT setting.`Value` FROM `emotion`.`setting` WHERE `setting`.`Setting`='cerebrofit';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return (Convert.ToDouble(reader.GetString("Value")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0.0;
            }
        }
        #endregion

        #region GetWeight
        public void getWeight(out double[] initialWeights, out double cerebrofit)
        {
            this.CloseConnection();
            initialWeights = new double[29];
            this.OpenConnection();
            string query = "select * from weight";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            initialWeights[0] = Convert.ToDouble(reader.GetString("wi1"));
            initialWeights[1] = Convert.ToDouble(reader.GetString("wi2"));
            initialWeights[2] = Convert.ToDouble(reader.GetString("wi3"));
            initialWeights[3] = Convert.ToDouble(reader.GetString("wi4"));
            initialWeights[4] = Convert.ToDouble(reader.GetString("wi5"));

            initialWeights[5] = Convert.ToDouble(reader.GetString("wi6"));
            initialWeights[6] = Convert.ToDouble(reader.GetString("wi7"));
            initialWeights[7] = Convert.ToDouble(reader.GetString("wi8"));
            initialWeights[8] = Convert.ToDouble(reader.GetString("wi9"));
            initialWeights[9] = Convert.ToDouble(reader.GetString("wi10"));

            initialWeights[10] = Convert.ToDouble(reader.GetString("wi11"));
            initialWeights[11] = Convert.ToDouble(reader.GetString("wi12"));
            initialWeights[12] = Convert.ToDouble(reader.GetString("wi13"));
            initialWeights[13] = Convert.ToDouble(reader.GetString("wi14"));
            initialWeights[14] = Convert.ToDouble(reader.GetString("wi15"));

            initialWeights[15] = Convert.ToDouble(reader.GetString("wi16"));
            initialWeights[16] = Convert.ToDouble(reader.GetString("wi17"));
            initialWeights[17] = Convert.ToDouble(reader.GetString("wi18"));

            initialWeights[18] = Convert.ToDouble(reader.GetString("bi1"));
            initialWeights[19] = Convert.ToDouble(reader.GetString("bi2"));
            initialWeights[20] = Convert.ToDouble(reader.GetString("bi3"));

            initialWeights[21] = Convert.ToDouble(reader.GetString("wj1"));
            initialWeights[22] = Convert.ToDouble(reader.GetString("wj2"));
            initialWeights[23] = Convert.ToDouble(reader.GetString("wj3"));
            initialWeights[24] = Convert.ToDouble(reader.GetString("bj1"));
            cerebrofit = Convert.ToDouble(reader.GetString("kb"));
            reader.Close();
            this.CloseConnection();
        }
        #endregion

        #region getMaxValue
        public void getMaxValues(out double[] maxF)
        {
            maxF = new double[6];
            try
            {
                this.CloseConnection();
                this.OpenConnection();
                string query = "SELECT MAX(F1)AS 'F1',MAX(F2)AS 'F2',MAX(F3)AS 'F3',MAX(F4)AS 'F4',MAX(F5)AS 'F5',MAX(F6)AS 'F6' FROM `emotion`.`training`;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                maxF[0] = Convert.ToDouble(reader.GetString("F1"));
                maxF[1] = Convert.ToDouble(reader.GetString("F2"));
                maxF[2] = Convert.ToDouble(reader.GetString("F3"));
                maxF[3] = Convert.ToDouble(reader.GetString("F4"));
                maxF[4] = Convert.ToDouble(reader.GetString("F5"));
                maxF[5] = Convert.ToDouble(reader.GetString("F6"));
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.CloseConnection();
        }
        #endregion

        #region SAVE USER
        public bool saveUser(string idUser, string fullName, string pass)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "insert into user(idUser,fullName,password) values('" + idUser + "','" + fullName + "','" + pass + "')";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        #endregion

        #region SAVE FAVORITE
        public bool saveFavorite(string favoriteName, string idUser, int priority)
        {
            this.CloseConnection();
            string query = "insert into favorite(favoriteName,priority,idUser) values" +
                            "('" + favoriteName + "','" + priority + "','" + idUser + "')";
            try
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }


        }
        #endregion


        #region CHECK USER ID
        public bool checkId(string key)
        {
            this.CloseConnection();
            this.OpenConnection();
            try
            {
                string query = "SELECT idUser FROM `emotion`.`user` WHERE  `idUser`= '" + key + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                return (count == 1) ? true : false;

            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.ToString());
                return false;
            }
        }
        #endregion

        #region LOGIN
        public bool loginCheck(string id, string _pass, ref string idUser)
        {
            this.CloseConnection();
            this.OpenConnection();
            try
            {
                string query = "SELECT `emotion`.`user`.`idUser`,`fullName` " +
                    "FROM `emotion`.`user` WHERE `emotion`.`user`.`idUser`='" + id + "' " +
                    "and password='" + _pass + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                    idUser = reader.GetString("idUser");
                }
                return (count == 1) ? true : false;

            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.ToString());
                return false;
            }

        }
        #endregion

        #region Get Favorite User
        public void getFavorite(string idUser, out string[] favoriteName, out int[] priority, out int[] idFavorite)
        {
            this.CloseConnection();
            this.OpenConnection();
            favoriteName = new string[6];
            priority = new int[6];
            idFavorite = new int[6];
            string query = "SELECT `idFavorite`,`favoriteName`,`priority` FROM `favorite` WHERE `idUser`='" + idUser + "';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            for (int i = 0; i < 6; i++)
            {
                reader.Read();
                idFavorite[i] = Convert.ToInt16(reader.GetString("idFavorite"));
                favoriteName[i] = reader.GetString("favoriteName");
                priority[i] = Convert.ToInt16(reader.GetString("priority"));
            }
            reader.Close();
            this.CloseConnection();

        }
        #endregion

        #region UpdateFavorite
        public bool updateFavorite(int idFavorite, string favoriteName)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "UPDATE `emotion`.`favorite` SET `favoriteName` = '" + favoriteName + "' WHERE `idFavorite` = '" + idFavorite + "';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString()); return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool updateFavoriteAll(string favoriteName, string idUser, int priority)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "UPDATE `emotion`.`favorite` SET `favorite`.`favoriteName`='"+favoriteName+"' WHERE `favorite`.`priority`="+priority+" AND `favorite`.`idUser`='"+idUser+"';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString()); return false;
                }
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region User Data
        public string getUser(string idUser)
        {
            this.CloseConnection();
            string FullName = null;
            if (this.OpenConnection() == true)
            {
                string query = "SELECT `fullName` FROM `emotion`.`user` WHERE user.`idUser`='" + idUser + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FullName = reader.GetString("fullName");
                }
                reader.Close();
                return FullName;
            }
            else
            {
                return "Not Found";
            }
        }
        public void getFullUser(string idUser, ref string fullName)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM `emotion`.`user` WHERE `emotion`.`user`.`idUser`='" + idUser + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fullName = reader.GetString("fullName");
                }
                reader.Close();
            }
            this.CloseConnection();
        }
        #endregion


        #region Update User
        public bool updateUserData(string fullName, string idUser)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "UPDATE `emotion`.`user` SET `fullName` = '" + fullName + "' WHERE `idUser` = '" + idUser + "'; ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region View Data User
        public void viewDataUser(ref DataGridView userTabel)
        {
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT `emotion`.`user`.`idUser`,user.`fullName`" +
                    " FROM `emotion`.`user` ORDER BY 1 ASC LIMIT 0,1000;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(ds1, "userData");
                userTabel.DataSource = ds1;
                userTabel.DataMember = "userData";
                userTabel.Columns[0].HeaderText = "ID USER";
                userTabel.Columns[1].HeaderText = "NAMA LENGKAP";
                userTabel.Columns[0].Width = 100;
                userTabel.Columns[1].Width = 150;
            }
            this.CloseConnection();
        }
        #endregion

        #region View Count Data Testing
        public void getCountTesting(ref int countTesting, ref int countSad, ref int countHappy)
        {

            this.CloseConnection();
            string query = "SELECT 	COUNT(*)AS 'countTesting'," +
                    "(SELECT COUNT(`testing`.`idOutput`) FROM `emotion`.`testing` WHERE `testing`.`idOutput`= 0)AS 'countSad'," +
                    "(SELECT COUNT(`testing`.`idOutput`) FROM `emotion`.`testing` WHERE `testing`.`idOutput`= 1)AS 'countHappy'" +
                    "FROM `emotion`.`testing`; ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    countTesting = Convert.ToInt32(reader.GetString("countTesting"));
                    countSad = Convert.ToInt32(reader.GetString("countSad"));
                    countHappy = Convert.ToInt32(reader.GetString("countHappy"));
                }
            }
            this.CloseConnection();
        }
        #endregion

        #region Save Data Testing
        public void saveTesting(int idOutput, double f1, double f2, double f3, double f4, double f5, double f6, string idUser, double sad, double happy, string citra = null)
        {
            this.CloseConnection();
            string query = null;

            if (citra == null)
            {
                query = "INSERT INTO `emotion`.`testing` (`idOutput`, `F1`, `F2`, `F3`, `F4`, `F5`, `F6`, `idUser`, `sad`, `happy`)" +
                " VALUES ('" + idOutput + "', '" + f1 + "', '" + f2 + "', '" + f3 + "'," +
                " '" + f4 + "', '" + f5 + "', '" + f6 + "', '" + idUser + "', '" + sad + "', '" + happy + "');";
            }
            else
            {
                query = "INSERT INTO `emotion`.`testing` (`idOutput`, `F1`, `F2`, `F3`, `F4`, `F5`, `F6`, `idUser`, `sad`, `happy`,`citra`)" +
                " VALUES ('" + idOutput + "', '" + f1 + "', '" + f2 + "', '" + f3 + "', '" + f4 + "', '" + f5 + "', '" + f6 + "'," +
                " '" + idUser + "', '" + sad + "', '" + happy + "','" + citra + "');";
            }


            try
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.CloseConnection();
        }
        #endregion

        #region Get Detail Data Testing
        public void getDetailTesting(string idTesting, out string[] dataTesting)
        {
            this.CloseConnection();
            this.OpenConnection();
            dataTesting = new string[12];
            string query = "SELECT `testing`.`idTesting`, `testing`.`F1`, `testing`.`F2`, `testing`.`F3`, `testing`.`F4`, `testing`.`F5`, `testing`.`F6`, `output`.`Output`" +
                                ", `testing`.`sad`, `testing`.`happy`, `user`.`fullName`,`testing`.`citra`" +
                                "FROM `emotion`.`testing` INNER JOIN `emotion`.`output` ON(`testing`.`idOutput` = `output`.`idOutput`) INNER JOIN `emotion`.`user`" +
                                "ON(`testing`.`idUser` = `user`.`idUser`) WHERE `idTesting`= '" + idTesting + "'  ORDER BY `idTesting` ; ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataTesting[0] = reader.GetString("idTesting");
                dataTesting[1] = reader.GetString("F1");
                dataTesting[2] = reader.GetString("F2");
                dataTesting[3] = reader.GetString("F3");
                dataTesting[4] = reader.GetString("F4");
                dataTesting[5] = reader.GetString("F5");
                dataTesting[6] = reader.GetString("F6");
                dataTesting[7] = reader.GetString("Output");
                dataTesting[8] = reader.GetString("sad");
                dataTesting[9] = reader.GetString("happy");
                dataTesting[10] = reader.GetString("fullName");
                dataTesting[11] = reader.GetString("citra");
            }
            this.CloseConnection();
        }
        #endregion

        #region Count Data User
        public void getCountUser(ref int count)
        {
            this.CloseConnection();
            string query = "SELECT COUNT(*)AS 'countUser' FROM `emotion`.`user`;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = Convert.ToInt32(reader.GetString("countUser"));
                }
            }
            this.CloseConnection();
        }
        #endregion
    }
}
