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
using RiotSharp;

namespace DBTestForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var api = RiotApi.GetInstance("efd26477-6526-4a14-afa2-79d0b8a571ea");
            String summName = this.SummonerNameTextBox.Text;
            //var staticAPI = StaticRiotApi.GetInstance("efd26477-6526-4a14-afa2-79d0b8a571ea");
            #region OLD CODE TO POPULATE RUNE
            //var runes = staticAPI.GetRunes(RiotSharp.Region.na, RiotSharp.StaticDataEndpoint.RuneData.stats);
            
            //var runes2 = staticAPI.GetRune()
            //List<String> runeNames = new List<String>();
            //List<String> runeTypes = new List<String>();
            //int maxLength = 0;
            //String maxName = "";
            //String maxDesc = "";
            //foreach(var s in runes.Runes.Values)
            //{
            //    if (runeNames.Contains(s.Name) == false)
            //    {
            //        Console.WriteLine("NAME: " + s.Name);
            //        if (maxLength < s.Name.Length)
            //        {
            //            maxLength = s.Name.Length;
            //            maxName = s.Name;
            //        }
            //        if (maxDesc.Length < s.Description.Length)
            //            maxDesc = s.Description;
            //        runeNames.Add(s.Name);
            //    }

            //    if (runeTypes.Contains(s.Metadata.Type) == false)
            //    {
            //        //Console.WriteLine("NAME: " + s.Name);
            //        runeTypes.Add(s.Metadata.Type);
            //    }
            //    //Console.WriteLine(s.Name);
            //}
            //foreach(var s in runeTypes)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("MAX LENGTH: " + maxLength);
            //Console.WriteLine("MAX NAME: " + maxName);
            //Console.WriteLine("MAX DESC L: " + maxDesc.Length);
            //Console.WriteLine("MAX DESC: " + maxDesc);

            /*try
            {
                //RiotSharp.SummonerEndpoint.Summoner sum = api.GetSummoner(RiotSharp.Region.na, summName);
                //Console.WriteLine("REGION: " + sum.Region);
                String conString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=LeagueStats;Persist Security Info=True;User ID=tiefenaw;Password=Loonytoons0";
                using (SqlConnection openCon = new SqlConnection(conString))
                {
                    string addRuneString = " INSERT INTO RuneInfo (runeNum, description, tier, type, name) VALUES (@runeNum, @description, @tier, @type, @name)";
                    using (SqlCommand addSummoner = new SqlCommand())
                    {
                        //addSummoner.CommandText = "SET IDENTITY_INSERT Rune ON";
                        //addSummoner.Connection = openCon;
                        //addSummoner.CommandText = "add_or_update_summoner";
                        //addSummoner.CommandType = CommandType.StoredProcedure;

                        //SqlParameter param = new SqlParameter("@summonerID", sum.Id);
                        //addSummoner.Parameters.Add(param);

                        //param = new SqlParameter("@region", sum.Region.ToString());
                        //addSummoner.Parameters.Add(param);

                        //param = new SqlParameter("@profileIconID", sum.ProfileIconId);
                        //addSummoner.Parameters.Add(param);

                        //param = new SqlParameter("@summonerLevel", sum.Level);
                        //addSummoner.Parameters.Add(param);

                        //param = new SqlParameter("@summonerName", sum.Name);
                        //addSummoner.Parameters.Add(param);
                        addSummoner.CommandText += addRuneString;
                        addSummoner.Connection = openCon;
                        openCon.Open();
                        foreach (var s in runes.Runes.Values)
                        {
                            addSummoner.Parameters.Add("@runeNum", Convert.ToInt16(s.Id));
                            addSummoner.Parameters.Add("@description", s.Description);
                            addSummoner.Parameters.Add("@tier", Convert.ToByte(s.Metadata.Tier));
                            addSummoner.Parameters.Add("@type", s.Metadata.Type);
                            addSummoner.Parameters.Add("@name", s.Name);
                            addSummoner.ExecuteNonQuery();
                            addSummoner.Parameters.Clear();
                            //if(s.Metadata.Type.CompareTo("black") == 0)
                            //{
                            //    for(int i = 28; i <= 30; i++)
                            //    {
                            //        addSummoner.Parameters.Add("@runeNum", Convert.ToInt16(s.Id));
                            //        addSummoner.Parameters.Add("@slotID", Convert.ToByte(i));
                            //        addSummoner.Parameters.Add("@description", s.Description);
                            //        addSummoner.Parameters.Add("@tier", Convert.ToByte(s.Metadata.Tier));
                            //        addSummoner.Parameters.Add("@type", s.Metadata.Type);
                            //        addSummoner.Parameters.Add("@name", s.Name);
                            //        addSummoner.ExecuteNonQuery();
                            //        addSummoner.Parameters.Clear();
                            //    }
                            //}
                            //else if(s.Metadata.Type.CompareTo("red") == 0)
                            //{
                            //    for(int i = 1; i <= 9; i++)
                            //    {
                            //        addSummoner.Parameters.Add("@runeNum", Convert.ToInt16(s.Id));
                            //        addSummoner.Parameters.Add("@slotID", Convert.ToByte(i));
                            //        addSummoner.Parameters.Add("@description", s.Description);
                            //        addSummoner.Parameters.Add("@tier", Convert.ToByte(s.Metadata.Tier));
                            //        addSummoner.Parameters.Add("@type", s.Metadata.Type);
                            //        addSummoner.Parameters.Add("@name", s.Name);
                            //        addSummoner.ExecuteNonQuery();
                            //        addSummoner.Parameters.Clear();
                            //    }
                            //} else if(s.Metadata.Type.CompareTo("yellow") == 0)
                            //{
                            //    for(int i = 10; i <= 18; i++)
                            //    {
                            //        addSummoner.Parameters.Add("@runeNum", Convert.ToInt16(s.Id));
                            //        addSummoner.Parameters.Add("@slotID", Convert.ToByte(i));
                            //        addSummoner.Parameters.Add("@description", s.Description);
                            //        addSummoner.Parameters.Add("@tier", Convert.ToByte(s.Metadata.Tier));
                            //        addSummoner.Parameters.Add("@type", s.Metadata.Type);
                            //        addSummoner.Parameters.Add("@name", s.Name);
                            //        addSummoner.ExecuteNonQuery();
                            //        addSummoner.Parameters.Clear();
                            //    }
                            //} else if(s.Metadata.Type.CompareTo("blue") == 0)
                            //{
                            //    for(int i = 19; i <= 27; i++)
                            //    {
                            //        addSummoner.Parameters.Add("@runeNum", Convert.ToInt16(s.Id));
                            //        addSummoner.Parameters.Add("@slotID", Convert.ToByte(i));
                            //        addSummoner.Parameters.Add("@description", s.Description);
                            //        addSummoner.Parameters.Add("@tier", Convert.ToByte(s.Metadata.Tier));
                            //        addSummoner.Parameters.Add("@type", s.Metadata.Type);
                            //        addSummoner.Parameters.Add("@name", s.Name);
                            //        addSummoner.ExecuteNonQuery();
                            //        addSummoner.Parameters.Clear();
                            //    }
                            //}
                            //addSummoner.Parameters.Add("@runeNum", Convert.ToInt16(s.Id));
                            //addSummoner.Parameters.Add("@slotID", Convert.ToByte(s.));
                            //addSummoner.Parameters.Add("@runeNum", SqlDbType.SmallInt).Value = Convert.ToInt16(s.Id);
                            //int runeID = Convert.ToInt16(runeIDTextbox.Text);
                            //if (runeNames.Contains(s.Name) == false)
                            //{
                            //    Console.WriteLine("NAME: " + s.Name);
                            //    if (maxLength < s.Name.Length)
                            //    {
                            //        maxLength = s.Name.Length;
                            //        maxName = s.Name;
                            //    }
                            //    if (maxDesc.Length < s.Description.Length)
                            //        maxDesc = s.Description;
                            //    runeNames.Add(s.Name);
                            //}

                            //if (runeTypes.Contains(s.Metadata.Type) == false)
                            //{
                            //    //Console.WriteLine("NAME: " + s.Name);
                            //    runeTypes.Add(s.Metadata.Type);
                            //}
                            ////Console.WriteLine(s.Name);
                        }
                        //addSummoner.Parameters.Add("@runeNum", SqlDbType.VarChar, 30).Value = name;
                        //int runeID = Convert.ToInt16(runeIDTextbox.Text);

                        //addSummoner.Parameters.AddWithValue("@runeID", runeID);

                        //int runeNum = Convert.ToInt16(runeNumTextbox.Text);
                        //if (runeNum < 0)
                        //    return;
                        //addSummoner.Parameters.AddWithValue("@runeNum", runeNum);

                        //int slotID = Convert.ToInt16(slotIDTextbox.Text);
                        //if (slotID > 255 || slotID < 0)
                        //    return;
                        //Byte slotIDByte = Convert.ToByte(slotID);
                        //addSummoner.Parameters.AddWithValue("@slotID", slotID);
                        //openCon.Open();
                        //addSummoner.ExecuteNonQuery();
                        openCon.Close();
                    }
                }
            }
            catch (Exception cept)
            {
                throw (cept);
            } */
            #endregion
            if (this.RegionCombo.Text == "na")
            {
                try
                {
                    RiotSharp.SummonerEndpoint.Summoner sum = api.GetSummoner(RiotSharp.Region.na, summName);
                    Console.WriteLine("REGION: " + sum.Region);
                    String conString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=LeagueStats;Persist Security Info=True;User ID=tiefenaw;Password=Loonytoons0";
                    using (SqlConnection openCon = new SqlConnection(conString))
                    {
                        //string addRuneString = " INSERT INTO Rune (runeID,runeNum,slotID) VALUES (@runeID,@runeNum,@slotID)";
                        using (SqlCommand addSummoner = new SqlCommand())
                        {
                            addSummoner.Connection = openCon;
                            addSummoner.CommandText = "add_or_update_summoner";
                            addSummoner.CommandType = CommandType.StoredProcedure;

                            SqlParameter param = new SqlParameter("@summonerID", sum.Id);
                            addSummoner.Parameters.Add(param);

                            param = new SqlParameter("@region", sum.Region.ToString());
                            addSummoner.Parameters.Add(param);

                            param = new SqlParameter("@profileIconID", sum.ProfileIconId);
                            addSummoner.Parameters.Add(param);

                            param = new SqlParameter("@summonerLevel", sum.Level);
                            addSummoner.Parameters.Add(param);

                            param = new SqlParameter("@summonerName", sum.Name);
                            addSummoner.Parameters.Add(param);
                            //addSummoner.CommandText += addRuneString;

                            openCon.Open();
                            addSummoner.ExecuteNonQuery();
                            openCon.Close();
                        }
                    }
                } catch(Exception cept)
                {
                    Console.WriteLine("ERROR");
                }
            }
            
            //var me = EF.RiotApi.Client.RiotWeb.API.Summoner.GetSummoner("Doomerdinger");
            //Console.WriteLine("Name:{0} ID:{1} Level:{2}", sum.Name, sum.Id, sum.Level);
            //var me = EF.RiotApi.Client.RiotWeb.API.Summoner.GetSummoner("Dome");
            //Console.WriteLine("{0}:{1}", me.Name, me.Id);
        }
    }
}
