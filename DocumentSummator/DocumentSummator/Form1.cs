using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DocumentSummator
{
    public partial class Form1 : Form
    {
        public SqlConnection sqlConnection1;
        public Form1()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Task.mdf;Inte" +
    "grated Security=True;Connect Timeout=30";
            SqlCommand command = new SqlCommand("SELECT NAME FROM FIRM", sqlConnection1);
            sqlConnection1.Open();
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cmbFirm.Items.Add(sqlReader["NAME"].ToString());
            }
            sqlReader.Close();
            cmbFirm.SelectedIndex = 0;
            command.CommandText = "SELECT NAME FROM CITY";
            sqlReader = command.ExecuteReader();
            string temp;
            while (sqlReader.Read())
            {
                temp = sqlReader["NAME"].ToString();
                cmbJurCity.Items.Add(temp);
                cmbPostCity.Items.Add(temp);
            }
            sqlReader.Close();
            cmbJurCity.SelectedIndex = 0;
            cmbPostCity.SelectedIndex = 0;
        }

        public string QueryBuilder()
        {
            string query = "SELECT year(document.doc_date) AS Год, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE) = 1, DOCUMENT.SUM, 0)) AS Январь, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=2,DOCUMENT.SUM,0)) AS Февраль, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=3,DOCUMENT.SUM,0)) AS Март, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=4,DOCUMENT.SUM,0)) AS Апрель, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=5,DOCUMENT.SUM,0)) AS Май, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=6,DOCUMENT.SUM,0)) AS Июнь, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=7,DOCUMENT.SUM,0)) AS Июль, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=8,DOCUMENT.SUM,0)) AS Август, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=9,DOCUMENT.SUM,0)) AS Сентябрь, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=10,DOCUMENT.SUM,0)) AS Октябрь, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=11,DOCUMENT.SUM,0)) AS Ноябрь, " +
            "sum(IIf(month(DOCUMENT.DOC_DATE)=12,DOCUMENT.SUM,0)) AS Декабрь " +
           "FROM DOCUMENT INNER JOIN(SELECT FIRM.ID, FIRM.NAME AS FIRMN, JUR_CITY.NAME AS JUR, POST_CITY.NAME AS POST FROM FIRM " +
           "INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.ID " +
           "LEFT JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.ID " +
           "WHERE(CASE WHEN @firm_name = '' THEN 1 ELSE(CASE WHEN UPPER(@firm_name) = UPPER(FIRM.NAME) THEN 1 ELSE 0 END) " +
           "END) = 1 AND(CASE WHEN @jur_city_name = '' THEN 1 " +
           "ELSE(CASE WHEN UPPER(@jur_city_name) = UPPER(JUR_CITY.NAME) THEN 1 ELSE 0 END) END) = 1 " +
           "AND(CASE WHEN @post_city_name = '' THEN 1 " +
           "ELSE(CASE WHEN  UPPER(@post_city_name) = UPPER(POST_CITY.NAME) THEN 1 ELSE 0 END) " +
           "END) = 1) AS FIRMS ON DOCUMENT.FIRM_ID = FIRMS.ID " +
           "GROUP BY year(DOCUMENT.DOC_DATE); ";
            return query;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string buffer ="";
            SqlCommand command = new SqlCommand(QueryBuilder(), sqlConnection1);
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@firm_name", SqlDbType.VarChar);
            
            if(chkFirm.Checked)
            {
                if(radFirmCmb.Checked)
                {
                    buffer = cmbFirm.SelectedItem.ToString();
                }
                else
                {
                    buffer = txtFirm.Text;
                }
            }
            command.Parameters["@firm_name"].Value = buffer;
            buffer = "";

            command.Parameters.Add("@jur_city_name", SqlDbType.VarChar);
            if(chkJurCIty.Checked)
            {
                if(radJurCityCmb.Checked)
                {
                    buffer = cmbJurCity.SelectedItem.ToString();
                }
                else
                {
                    buffer = txtJurCity.Text;
                }
            }
            command.Parameters["@jur_city_name"].Value = buffer;
            buffer = "";

            command.Parameters.Add("@post_city_name", SqlDbType.VarChar);
            if(chkPostCIty.Checked)
            {
                if(radPostCityCmb.Checked)
                {
                    buffer = cmbPostCity.SelectedItem.ToString();
                }
                else
                {
                    buffer = txtPostCity.Text;
                }
            }
            command.Parameters["@post_city_name"].Value = buffer;
            buffer = "";

            SqlDataAdapter adapt = new SqlDataAdapter();
            adapt.SelectCommand = command;
            DataTable data = new DataTable();
            adapt.Fill(data);
            dataGridView1.DataSource = data;
            sqlConnection1.Close();
        }

        private void chkFirm_CheckedChanged(object sender, EventArgs e)
        {
            groupFirm.Enabled = chkFirm.Checked;
            
        }

        private void chkJurCIty_CheckedChanged(object sender, EventArgs e)
        {
            groupJurCIty.Enabled = chkJurCIty.Checked;

        }
        private void radFirmCmb_CheckedChanged(object sender, EventArgs e)
        {
            cmbFirm.Enabled = radFirmCmb.Checked;
        }
        private void radFirmTxt_CheckedChanged(object sender, EventArgs e)
        {
            txtFirm.Enabled = radFirmTxt.Checked;
        }

        private void radJurCityCmb_CheckedChanged(object sender, EventArgs e)
        {
            cmbJurCity.Enabled = radJurCityCmb.Checked;
        }

        private void radJurCityTxt_CheckedChanged(object sender, EventArgs e)
        {
            txtJurCity.Enabled = radJurCityTxt.Checked;
        }

        private void chkPostCIty_CheckedChanged(object sender, EventArgs e)
        {
            groupPostCIty.Enabled = chkPostCIty.Checked;
        }

        private void radPostCityCmb_CheckedChanged(object sender, EventArgs e)
        {
            cmbPostCity.Enabled = radPostCityCmb.Checked;
        }

        private void radPostCityTxt_CheckedChanged(object sender, EventArgs e)
        {
            txtPostCity.Enabled = radPostCityTxt.Checked;
        }
    }
}
