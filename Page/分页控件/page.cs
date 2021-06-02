using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collidal_Weigh.Page
{
    public partial class page : UserControl
    {
        public page()
        {
            InitializeComponent();
        }

        int pageSize = 0;     //每页显示行数
        int nMax = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号
        int nCurrent = 0;      //当前记录行
        DataSet ds = new DataSet();
        DataTable dtInfo = new DataTable();
        public DataGridView dataGridView;
        public int pagesizeNum;
        public void LoadData()
        {
            int nStartPos = 0;   //当前页面开始记录行
            int nEndPos = 0;     //当前页面结束记录行
            DataTable dtTemp = dtInfo.Clone();   //克隆DataTable结构框架

            if (pageCurrent == pageCount)
            {
                nEndPos = nMax;
            }
            else
            {
                nEndPos = pageSize * pageCurrent;
            }

            nStartPos = nCurrent;
            //从元数据源复制记录行
            for (int i = nStartPos; i < nEndPos; i++)
            {
                if (dtInfo.Rows.Count>0)
                {
                    dtTemp.ImportRow(dtInfo.Rows[i]);///复制
                    nCurrent++;
                }
              
            }

            dataGridView.DataSource = dtTemp;
        }


        private void InitDataSet()
        {
            pageSize = pagesizeNum;      //设置页面行数
            nMax = dtInfo.Rows.Count;
            pageCount = (nMax / pageSize);    //计算出总页数
            if ((nMax % pageSize) > 0) pageCount++;
            pageCurrent = 1;    //当前页数从1开始
            nCurrent = 0;       //当前记录数从0开始
            LoadData();

        }




        public void page_load(DataTable datatable, DataGridView datagridview)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = datatable;
            bindingNavigator1.BindingSource = bs;
            datagridview.DataSource = bs;
            dtInfo = datatable;
            InitDataSet();
            Sum_page.Text = "共" + pageCount.ToString() + "页";
            c_page.Text = "第" + pageCurrent.ToString() + "页";
            sum_data.Text = "共" + nMax.ToString() + "行";
            page_size.Text = "每页" + pageSize.ToString() + "行";
            datagridview.AllowUserToAddRows = false;


        }





        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frist_page_Click(object sender, EventArgs e)
        {
            Frist_page.Enabled = false;
            Last_page.Enabled = false;
            Next_page.Enabled = true;
            Not_page.Enabled = true;
            pageCurrent = 1;
            nCurrent = pageSize * (pageCurrent - 1);
            Sum_page.Text = "共" + pageCount.ToString() + "页";
            c_page.Text = "第" + pageCurrent.ToString() + "页";
            sum_data.Text = "共" + nMax.ToString() + "行";
            page_size.Text = "每页" + pageSize.ToString() + "行";
            LoadData();

        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Last_page_Click(object sender, EventArgs e)
        {
            pageCurrent--;
            Next_page.Enabled = true;
            Not_page.Enabled = true;
            Frist_page.Enabled = true;
            Last_page.Enabled = true;

            if (pageCurrent==1)
            {
                Frist_page.Enabled = false;
                Last_page.Enabled = false;
            }
            if (pageCurrent == 0)
            {
                pageCurrent++;
                MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                Sum_page.Text = "共" + pageCount.ToString() + "页";
                c_page.Text = "第" + pageCurrent.ToString() + "页";
                return;
            }
            else
            {
                nCurrent = pageSize * (pageCurrent - 1);
                Sum_page.Text = "共" + pageCount.ToString() + "页";
                c_page.Text = "第" + pageCurrent.ToString() + "页";
                sum_data.Text = "共" + nMax.ToString() + "行";
                page_size.Text = "每页" + pageSize.ToString() + "行";
                LoadData();

            }

        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_page_Click(object sender, EventArgs e)
        {

            Next_page.Enabled = true;
            Not_page.Enabled = true;
            Frist_page.Enabled = true;
            Last_page.Enabled = true;
            pageCurrent++;

            if (pageCurrent == pageCount)
            {
                nCurrent = pageSize * (pageCurrent - 1);
                Next_page.Enabled = false;
                Not_page.Enabled = false;
            }
            if (pageCurrent > pageCount)
            {
                pageCurrent--;
                MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                Sum_page.Text = "共" + pageCount.ToString() + "页";
                c_page.Text = "第" + pageCurrent.ToString() + "页";
                //Next_page.Enabled = false;
                //Not_page.Enabled = false;
                return;
            }
            else
            {
                nCurrent = pageSize * (pageCurrent - 1);
                
            }
            Sum_page.Text = "共" + pageCount.ToString() + "页";
            c_page.Text = "第" + pageCurrent.ToString() + "页";
            sum_data.Text = "共" + nMax.ToString() + "行";
            page_size.Text = "每页" + pageSize.ToString() + "行";
            LoadData();

        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Not_page_Click(object sender, EventArgs e)
        {
            Frist_page.Enabled = true;
            Last_page.Enabled = true;
            Next_page.Enabled = false;
            Not_page.Enabled = false;
            pageCurrent = pageCount;
            nCurrent = pageSize * (pageCurrent - 1);
            Sum_page.Text = "共" + pageCount.ToString() + "页";
            c_page.Text = "第" + pageCurrent.ToString() + "页";
            sum_data.Text = "共" + nMax.ToString() + "行";
            page_size.Text = "每页" + pageSize.ToString() + "行";
            LoadData();
        }
        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Next_page.Enabled = true;
            Not_page.Enabled = true;
            Frist_page.Enabled = true;
            Last_page.Enabled = true;
          
            if (this.tb_linkNum. Text != string.Empty)
            {
                int num = Convert.ToInt32(this.tb_linkNum.Text);
               
                if (num == pageCount)
                {
                    Next_page.Enabled = false;
                    Not_page.Enabled = false;
                }
                if (num==1)
                {

                    Frist_page.Enabled = false;
                    Last_page.Enabled = false;


                }


                if (num > pageCount)
                {
                    MessageBox.Show("此页不存在！");
                    this.tb_linkNum.Text = String.Empty;
                    return;
                }

                pageCurrent = num;
                nCurrent = pageSize * (pageCurrent - 1);
                Sum_page.Text = "共" + pageCount.ToString() + "页";
                c_page.Text = "第" + pageCurrent.ToString() + "页";
                sum_data.Text = "共" + nMax.ToString() + "行";
                page_size.Text = "每页" + pageSize.ToString() + "行";
                LoadData();
            }
            this.tb_linkNum.Text = String.Empty;
        }
    }
}
