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
using System.Configuration;

namespace eYes_DesktopApp_Proj
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void recordHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBRecordHistoryDataSet);

        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBRecordHistoryDataSet.RecordHistory' table. You can move, or remove it, as needed.
            this.recordHistoryTableAdapter.Fill(this.dBRecordHistoryDataSet.RecordHistory);

        }

        private void CekPesanToday()
        {
            RecordTime record = new RecordTime(totalTimeTextBox.Text, timePerUseTextBox.Text);
            record.Masukan(record.Baca1, record.Baca2);
            if (record.scan1 <= 4 && record.scan1 > 0)
            {
                if (record.scan2 <= 1 && record.scan2 > 0)
                {
                    MessageBox.Show("Berikut laporan penggunaanmu hari ini");
                    Pesan1 pesannya = new Pesan1();
                    pesannya.PesanPesan();
                }
                else if (record.scan2 > 1 && record.scan2 <= 24)
                {
                    MessageBox.Show("Berikut laporan penggunaanmu hari ini");
                    Pesan2 pesannya = new Pesan2();
                    pesannya.PesanPesan();
                }
            }
            else if (record.scan1 > 4 && record.scan1 <= 24)
            {
                if (record.scan2 <= 1 && record.scan2 > 0)
                {
                    MessageBox.Show("Berikut laporan penggunaanmu hari ini");
                    Pesan3 pesannya = new Pesan3();
                    pesannya.PesanPesan();
                }
                else if (record.scan2 > 1 && record.scan2 <= 24)
                {
                    MessageBox.Show("Berikut laporan penggunaanmu hari ini");
                    Pesan4 pesannya = new Pesan4();
                    pesannya.PesanPesan();
                }
            }
            totalTimeTextBox.Text = String.Empty;
            timePerUseTextBox.Text = String.Empty;
        }
        private void btnPesan_Click(object sender, EventArgs e)
        {
            CekPesanToday();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            this.chartHistory.Series["Total waktu penggunaan"].XValueMember = "Date";
            this.chartHistory.Series["Total waktu penggunaan"].YValueMembers = "TotalTime";
            this.chartHistory.Series["Durasi setiap penggunaan"].XValueMember = "Date";
            this.chartHistory.Series["Durasi setiap penggunaan"].YValueMembers = "TimePerUse";
            var connectionString = ConfigurationManager.ConnectionStrings["ModelHistory"].ConnectionString;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string command = "SELECT * FROM RecordHistory";
            SqlCommand cmd = new SqlCommand(command, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            this.chartHistory.DataSource = table;
            this.chartHistory.DataBind();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            using (var db = new ModelHistory())
            {
                var query = from history in db.RecordHistories where history.Date == dtFilter.Value.Date select history;
                foreach (var item in query)
                {
                    tbTampilkanDate.Text = item.Date.ToString();
                    tbTampilkanTotalTime.Text = item.TotalTime.ToString();
                    tbTampilkanTimePerUse.Text = item.TimePerUse.ToString();
                }
            }
        }

        private void totalTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && totalTimeTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void timePerUseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && timePerUseTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
