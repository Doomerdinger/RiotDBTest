using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRuneButton_Click(object sender, EventArgs e)
        {
            //Data Source=titan.csse.rose-hulman.edu;Initial Catalog=LeagueStats;Persist Security Info=True;User ID=tiefenaw;Password=***********
            String conString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=LeagueStats;Persist Security Info=True;User ID=tiefenaw;Password=Loonytoons0";
            using (SqlConnection openCon = new SqlConnection(conString))
            {
                string addRuneString = " INSERT INTO Rune (runeID,runeNum,slotID) VALUES (@runeID,@runeNum,@slotID)";
                using(SqlCommand addRune = new SqlCommand())
                {
                    addRune.CommandText = "SET IDENTITY_INSERT Rune ON";
                    addRune.CommandText += addRuneString;
                    addRune.Connection = openCon;
                    //queryAddRune.Parameters.Add("@runeID", SqlDbType.VarChar, 30).Value = name;
                    int runeID = Convert.ToInt16(runeIDTextbox.Text);
                    if (runeID < 0)
                        return;
                    addRune.Parameters.AddWithValue("@runeID", runeID);

                    int runeNum = Convert.ToInt16(runeNumTextbox.Text);
                    if (runeNum < 0)
                        return;
                    addRune.Parameters.AddWithValue("@runeNum", runeNum);

                    int slotID = Convert.ToInt16(slotIDTextbox.Text);
                    if (slotID > 255 || slotID < 0)
                        return;
                    Byte slotIDByte = Convert.ToByte(slotID);
                    addRune.Parameters.AddWithValue("@slotID", slotID);
                    openCon.Open();
                    addRune.ExecuteNonQuery();
                    openCon.Close();
                }
            }


            //The following is just some random code to do stored procedures.
            /*using (SqlConnection openCon = new SqlConnection(conString))
            {
                SqlCommand cmdNewCustomer = new SqlCommand("Sales.uspNewCustomer", openCon);
                cmdNewCustomer.CommandType = CommandType.StoredProcedure;

                cmdNewCustomer.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                cmdNewCustomer.Parameters["@CustomerName"].Value = "SomeName";

                //NC-9 Add output parameter.
                cmdNewCustomer.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                cmdNewCustomer.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

                try
                {
                    //NC-11 Open the connection.
                    openCon.Open();

                    //NC-12 Run the stored procedure.
                    cmdNewCustomer.ExecuteNonQuery();

                    //NC-13 Customer ID is an IDENTITY value from the database. 
                    this.parsedCustomerID = (int)cmdNewCustomer.Parameters["@CustomerID"].Value;
                    this.txtCustomerID.Text = Convert.ToString(parsedCustomerID);

                }
                catch
                {
                    //NC-14 A simple catch.

                    MessageBox.Show("Customer ID was not returned. Account could not be created.");
                }
            } */
        }
    }
}
