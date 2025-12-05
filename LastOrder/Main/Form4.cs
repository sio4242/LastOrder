using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;

namespace Main
{
    public partial class Form4 : Form
    {
        private string connectionString = "User Id=pos; Password=1111;" + "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //LoadProductList();
            comboCategory.Items.AddRange(new string[] { "음료", "과자", "냉장", "기타" });
        }
        private void LoadProductList()
        {
            listViewProduct.Items.Clear();

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT pid, pname, price, stock, category FROM product ORDER BY pid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["pid"].ToString());
                        item.SubItems.Add(dr["pname"].ToString());
                        item.SubItems.Add(dr["price"].ToString());
                        item.SubItems.Add(dr["stock"].ToString());
                        item.SubItems.Add(dr["category"].ToString());

                        listViewProduct.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("상품 조회 오류: " + ex.Message);
            }
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0) return;

            var item = listViewProduct.SelectedItems[0];

            txtName.Text = item.SubItems[1].Text;
            txtPrice.Text = item.SubItems[2].Text;
            txtStock.Text = item.SubItems[3].Text;
            comboCategory.Text = item.SubItems[4].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "INSERT INTO product (pid, pname, price, stock, category) " +
                        "VALUES (:pid, :name, :price, :stock, :category)";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":name", txtName.Text);
                    cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                    cmd.Parameters.Add(":stock", int.Parse(txtStock.Text));
                    cmd.Parameters.Add(":category", comboCategory.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("상품이 추가되었습니다.");
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가 오류: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "UPDATE product SET pname=:name, price=:price, stock=:stock, category=:category " +
                        "WHERE pid=:pid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":name", txtName.Text);
                    cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                    cmd.Parameters.Add(":stock", int.Parse(txtStock.Text));
                    cmd.Parameters.Add(":category", comboCategory.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("상품 정보가 수정되었습니다.");
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("수정 오류: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 상품을 선택하세요.");
                return;
            }

            DialogResult r = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (r != DialogResult.Yes) return;

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM product WHERE pid = :pid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("상품이 삭제되었습니다.");
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("삭제 오류: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
