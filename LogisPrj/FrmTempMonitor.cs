using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogisPrj
{
   
    public partial class FrmTempMonitor : Form
    {
        public string strDeliveryId;
        public YueYePlat.Model.usersinfo usersInfo;
        public FrmTempMonitor()
        {
            InitializeComponent();
        }

        private void FrmTempMonitor_Load(object sender, EventArgs e)
        {
            InitChart();
            // Zoom into the X axis
            //chart1.ChartAreas[0].AxisX.ScaleView.Zoom(2, 3);
            //chart1.Series[0].Label = "#PERCENT -- #VALY";
            // Enable range selection and zooming end user interface
            //chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            //chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            //将滚动内嵌到坐标轴中
            //chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            // 设置滚动条的大小
            // chart1.ChartAreas["Default"].AxisX.ScrollBar.Size = 10;

            // 设置滚动条的按钮的风格，下面代码是将所有滚动条上的按钮都显示出来
            // chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyle.All;

            // 设置自动放大与缩小的最小量
            //chart1.ChartAreas["Default"].AxisX.ScaleView.SmallScrollSize = double.NaN;
            // chart1.ChartAreas["Default"].AxisX.ScaleView.SmallScrollMinSize = 2;

            List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));

            if (tempList.Count > 0)
            {
                for (int i = 0; i < tempList.Count; i ++)
                {
                    int minTemp = 0;
                    if (tempList[i].Temperature1 < minTemp)
                    {
                        minTemp =int.Parse( tempList[i].Temperature1.ToString ());
                    }
                  //chart1.ChartAreas.                    
                    chart1.DataSource = tempList;
                    chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yy-MM-dd HH:mm:ss";
                    chart1.Series["Series1"].XValueMember = "CurrentTime";
                    chart1.Series["Series1"].YValueMembers = "Temperature1";
                    chart1.Series["Series2"].XValueMember = "CurrentTime";
                    chart1.Series["Series2"].YValueMembers = "Humidity1";
                    chart1.Series["Series3"].XValueMember = "CurrentTime";
                    chart1.Series["Series3"].YValueMembers = "Temperature2";
                    chart1.Series["Series4"].XValueMember = "CurrentTime";
                    chart1.Series["Series4"].YValueMembers = "Humidity2";
                    chart1.Series["Series5"].XValueMember = "CurrentTime";
                    chart1.Series["Series5"].YValueMembers = "Temperature3";
                    chart1.Series["Series6"].XValueMember = "CurrentTime";
                    chart1.Series["Series6"].YValueMembers = "Humidity3";
                }               
            }
            else
            {
                MessageBox.Show("该派送单无温湿度数据，请核查信息！");
                this.Close();
            }
        }

        private void InitChart()
        {
            //DateTime time = DateTime.Now;
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick_1;
            //chart1.DoubleClick += chart1_DoubleClick;

            //Series series = chart1.Series[0];
            //series.ChartType = SeriesChartType.Spline;

            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            //chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
            //chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            //chart1.ChartAreas[0].AxisX.ScrollBar.Size = 15;
            //chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            //chart1.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.SkyBlue;
            //chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = double.NaN;
            //chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 1;
            //chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            //chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //chart1.ChartAreas[0].AxisX.Interval = 10;
            //timer1.Start();

        }

        private void chart1_GetToolTipText(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            HitTestResult myTestResult = chart1.HitTest(e.X, e.Y, ChartElementType.DataPoint);//获取命中测试的结果  
            if (myTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = myTestResult.PointIndex;
                DataPoint dp = myTestResult.Series.Points[i];

                if (dp.LegendText == "温度1"|| dp.LegendText=="温度2"||dp.LegendText=="温度3")
                {                  
                    string YValue = dp.YValues[0].ToString();//获取数据点的Y值  
                    e.Text = "时间：" + DateTime.FromOADate(dp.XValue) + "\r\n温度：" + YValue;
                }
                if (dp.LegendText == "湿度1" || dp.LegendText == "湿度2" || dp.LegendText == "湿度3")
                {
                    string YValue = dp.YValues[0].ToString();//获取数据点的Y值  
                    e.Text = "时间：" + DateTime.FromOADate(dp.XValue) + "\r\n湿度：" + YValue;
                }             
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
            if (tempList.Count > 0)
            {
                for (int i = 0; i < tempList.Count; i++)
                {
                    double minTemp = 0;
                    minTemp = double.Parse(tempList[i].Temperature1.ToString ());
                    if (tempList[i].Temperature1 < minTemp)
                    {
                        minTemp = double.Parse(tempList[i].Temperature1.ToString());
                    }
                    //  chart1.ChartAreas.
                    chart1.DataSource = tempList;
                    chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yy-MM-dd HH:mm:ss";
                    chart1.Series["Series1"].XValueMember = "CurrentTime";
                    chart1.Series["Series1"].YValueMembers = "Temperature1";
                    chart1.Series["Series2"].XValueMember = "CurrentTime";
                    chart1.Series["Series2"].YValueMembers = "Humidity1";
                    chart1.Series["Series3"].XValueMember = "CurrentTime";
                    chart1.Series["Series3"].YValueMembers = "Temperature2";
                    chart1.Series["Series4"].XValueMember = "CurrentTime";
                    chart1.Series["Series4"].YValueMembers = "Humidity2";
                    chart1.Series["Series5"].XValueMember = "CurrentTime";
                    chart1.Series["Series5"].YValueMembers = "Temperature3";
                    chart1.Series["Series6"].XValueMember = "CurrentTime";
                    chart1.Series["Series6"].YValueMembers = "Humidity3";
                }
            }
        }          
        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            //chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
            //chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            //chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Random ra = new Random();
            //Series series = chart1.Series[0];
            //series.Points.AddXY(DateTime.Now, ra.Next(1, 10));
            //chart1.ChartAreas[0].AxisX.ScaleView.Position = series.Points.Count - 5;
            ////throw new NotImplementedException();
        }

        private void btnTemp1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
            if (tempList.Count > 0)
            {
               
                for (int i = 0; i < tempList.Count; i++)
                {
                    int minTemp = 0;
                    if (tempList[i].Temperature1 < minTemp)
                    {
                        minTemp = int.Parse(tempList[i].Temperature1.ToString());
                    }
                    //  chart1.ChartAreas.
                    chart1.DataSource = tempList;
                    chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yy-MM-dd HH:mm:ss";
                    chart1.Series["Series1"].XValueMember = "CurrentTime";
                    chart1.Series["Series1"].YValueMembers = "Temperature1";
                    chart1.Series["Series2"].XValueMember = "CurrentTime";
                    chart1.Series["Series2"].YValueMembers = "Humidity1";
                    chart1.Series["Series3"].XValueMember = "";
                    chart1.Series["Series3"].YValueMembers = "";
                    chart1.Series["Series4"].XValueMember = "";
                    chart1.Series["Series4"].YValueMembers = "";
                    chart1.Series["Series5"].XValueMember = "";
                    chart1.Series["Series5"].YValueMembers = "";
                    chart1.Series["Series6"].XValueMember = "";
                    chart1.Series["Series6"].YValueMembers = "";
                }
            }
        }

        private void btnTemp2_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
            if (tempList.Count > 0)
            {
                chart1.DataSource = tempList;
                for (int i = 0; i < tempList.Count; i++)
                {
                    int minTemp = 0;
                    if (tempList[i].Temperature1 < minTemp)
                    {
                        minTemp = int.Parse(tempList[i].Temperature1.ToString());
                    }                   
                    chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yy-MM-dd HH:mm:ss";
                    chart1.Series["Series1"].XValueMember = "";
                    chart1.Series["Series1"].YValueMembers = "";
                    chart1.Series["Series2"].XValueMember = "";
                    chart1.Series["Series2"].YValueMembers = "";
                    chart1.Series["Series3"].XValueMember = "CurrentTime";
                    chart1.Series["Series3"].YValueMembers = "Temperature2";
                    chart1.Series["Series4"].XValueMember = "CurrentTime";
                    chart1.Series["Series4"].YValueMembers = "Humidity2";
                    chart1.Series["Series5"].XValueMember = "";
                    chart1.Series["Series5"].YValueMembers = "";
                    chart1.Series["Series6"].XValueMember = "";
                    chart1.Series["Series6"].YValueMembers = "";
                }
            }
        }

        private void btnTemp3_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
            if (tempList.Count > 0)
            {
                chart1.DataSource = tempList;
                for (int i = 0; i < tempList.Count; i++)
                {
                    int minTemp = 0;
                    if (tempList[i].Temperature1 < minTemp)
                    {
                        minTemp = int.Parse(tempList[i].Temperature1.ToString());
                    }    
                    chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yy-MM-dd HH:mm:ss";
                    chart1.Series["Series1"].XValueMember = "";
                    chart1.Series["Series1"].YValueMembers = "";
                    chart1.Series["Series2"].XValueMember = "";
                    chart1.Series["Series2"].YValueMembers = "";
                    chart1.Series["Series3"].XValueMember = "";
                    chart1.Series["Series3"].YValueMembers = "";
                    chart1.Series["Series4"].XValueMember = "";
                    chart1.Series["Series4"].YValueMembers = "";                    
                    chart1.Series["Series5"].XValueMember = "CurrentTime";
                    chart1.Series["Series5"].YValueMembers = "Temperature3";
                    chart1.Series["Series6"].XValueMember = "CurrentTime";
                    chart1.Series["Series6"].YValueMembers = "Humidity3";
                }
            }
        }
    }
}
