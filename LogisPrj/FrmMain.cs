using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace LogisPrj
{
    public partial class FrmMain : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        int index = 0;
        public string strLoginName;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLoginName.Text = "你好， " + usersInfo.UserName;
            btnBaseInfo_Click(null,null);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;           

            if (usersInfo.UserTypeId == "APP01" || usersInfo.UserTypeId == "APP02" || usersInfo.UserTypeId == "APP03")
            {
                panelBaseInfo.Visible = false;
                panelBusiness.Visible = false;
                panelAssist.Visible = false;
                panelDataDic.Visible = false;
                panelDataManager.Visible = false;
                panelSysSet.Visible = false;
                panelTransfer.Visible = false;
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            }
            if (usersInfo.UserTypeId == "WL01")
            {
                panelSysSet.Visible = false;
                List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                YueYePlat.Model.logiscompanyinfo logiscompanyInfo = logiscompanyList.Find(v => v.CompanyID.Equals(usersInfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
            }
           
        }      
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;           
            this.Close();
        }        

        private void tSBtnRefrigerationhouse_Click(object sender, EventArgs e)
        {
            FrmRefrigerationhouse house = FrmRefrigerationhouse.getInstance();
            if (house.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmRefrigerationhouse = new TabPage();
                tabPageFrmRefrigerationhouse.Text = "冷库信息";
                tabControl1.TabPages.Add(tabPageFrmRefrigerationhouse);
                house.tabPageTitle = tabPageFrmRefrigerationhouse.Text;
                house.FormBorderStyle = FormBorderStyle.None;
                house.TopLevel = false;
                house.Dock = DockStyle.Fill;
                house.Parent = tabPageFrmRefrigerationhouse;
                house.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(house.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnUserControl_Click(object sender, EventArgs e)
        {
            FrmUserControl userControl = FrmUserControl.getInstance();
            if (userControl.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmUserControl = new TabPage();
                tabPageFrmUserControl.Text = "用户权限";
                tabControl1.TabPages.Add(tabPageFrmUserControl);
                userControl.tabPageTitle = tabPageFrmUserControl.Text;
                userControl.FormBorderStyle = FormBorderStyle.None;
                userControl.TopLevel = false;
                userControl.Dock = DockStyle.Fill;
                userControl.Parent = tabPageFrmUserControl;
                userControl.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(userControl.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnUserType_Click(object sender, EventArgs e)
        {
            FrmUserType userType = FrmUserType.getInstance();
            if (userType.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmUserType = new TabPage();
                tabPageFrmUserType.Text = "用户类型";
                tabControl1.TabPages.Add(tabPageFrmUserType);
                userType.tabPageTitle = tabPageFrmUserType.Text;
                userType.FormBorderStyle = FormBorderStyle.None;
                userType.TopLevel = false;
                userType.Dock = DockStyle.Fill;
                userType.Parent = tabPageFrmUserType;
                userType.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(userType.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnTempVehicle_Click(object sender, EventArgs e)
        {
            FrmTempvehicle tempVehicle = FrmTempvehicle.getInstance();
            if (tempVehicle.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmTempvehicle = new TabPage();
                tabPageFrmTempvehicle.Text = "临时车辆";
                tabControl1.TabPages.Add(tabPageFrmTempvehicle);
                tempVehicle.tabPageTitle = tabPageFrmTempvehicle.Text;
                tempVehicle.FormBorderStyle = FormBorderStyle.None;
                tempVehicle.TopLevel = false;
                tempVehicle.Dock = DockStyle.Fill;
                tempVehicle.Parent = tabPageFrmTempvehicle;
                tempVehicle.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(tempVehicle.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnVehicle_Click(object sender, EventArgs e)
        {
            FrmVehicleinfo vehicle = FrmVehicleinfo.getInstance();
            if (vehicle.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmVehicle = new TabPage();
                tabPageFrmVehicle.Text = "车辆信息";
                tabControl1.TabPages.Add(tabPageFrmVehicle);
                vehicle.tabPageTitle = tabPageFrmVehicle.Text;
                vehicle.FormBorderStyle = FormBorderStyle.None;
                vehicle.TopLevel = false;
                vehicle.Dock = DockStyle.Fill;
                vehicle.Parent = tabPageFrmVehicle;
                vehicle.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(vehicle.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

     
        private void tSBtnTerminalDevice_Click(object sender, EventArgs e)
        {
            FrmTerminaldevice terminalDevice = FrmTerminaldevice.getInstance();
            terminalDevice.usersInfo = usersInfo;
            if (terminalDevice.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmTerminalDevice = new TabPage();
                tabPageFrmTerminalDevice.Text = "终端设备信息";
                tabControl1.TabPages.Add(tabPageFrmTerminalDevice);
                terminalDevice.tabPageTitle = tabPageFrmTerminalDevice.Text;
                terminalDevice.FormBorderStyle = FormBorderStyle.None;
                terminalDevice.TopLevel = false;
                terminalDevice.Dock = DockStyle.Fill;
                terminalDevice.Parent = tabPageFrmTerminalDevice;
                terminalDevice.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(terminalDevice.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnDeviceUse_Click(object sender, EventArgs e)
        {
            FrmDeviceUse deviceUse = FrmDeviceUse.getInstance();
            if (deviceUse.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmDeviceUse = new TabPage();
                tabPageFrmDeviceUse.Text = "设备使用情况";
                tabControl1.TabPages.Add(tabPageFrmDeviceUse);
                deviceUse.tabPageTitle = tabPageFrmDeviceUse.Text;
                deviceUse.FormBorderStyle = FormBorderStyle.None;
                deviceUse.TopLevel = false;
                deviceUse.Dock = DockStyle.Fill;
                deviceUse.Parent = tabPageFrmDeviceUse;
                deviceUse.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(deviceUse.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnExceptionType_Click(object sender, EventArgs e)
        {
            FrmExceptionType exceptiontype = FrmExceptionType.getInstance();
            if (exceptiontype.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmExceptionType = new TabPage();
                tabPageFrmExceptionType.Text = "异常信息类型";
                tabControl1.TabPages.Add(tabPageFrmExceptionType);
                exceptiontype.tabPageTitle = tabPageFrmExceptionType.Text;
                exceptiontype.FormBorderStyle = FormBorderStyle.None;
                exceptiontype.TopLevel = false;
                exceptiontype.Dock = DockStyle.Fill;
                exceptiontype.Parent = tabPageFrmExceptionType;
                exceptiontype.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(exceptiontype.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }

            }
        }      

        private void tSBtnJamphoto_Click(object sender, EventArgs e)
        {
            FrmJamphotomanger Jamphoto = FrmJamphotomanger.getInstance();
            if (Jamphoto.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmJamphoto = new TabPage();
                tabPageFrmJamphoto.Text = "堵车照片管理";
                tabControl1.TabPages.Add(tabPageFrmJamphoto);
                Jamphoto.tabPageTitle = tabPageFrmJamphoto.Text;
                Jamphoto.FormBorderStyle = FormBorderStyle.None;
                Jamphoto.TopLevel = false;
                Jamphoto.Dock = DockStyle.Fill;
                Jamphoto.Parent = tabPageFrmJamphoto;
                Jamphoto.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(Jamphoto.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void tSBtnRoadtoll_Click(object sender, EventArgs e)
        {
            FrmRoadtoll roadtoll = FrmRoadtoll.getInstance();
            if (roadtoll.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmRoadtoll = new TabPage();
                tabPageFrmRoadtoll.Text = "过路费用";
                tabControl1.TabPages.Add(tabPageFrmRoadtoll);
                roadtoll.tabPageTitle = tabPageFrmRoadtoll.Text;
                roadtoll.FormBorderStyle = FormBorderStyle.None;
                roadtoll.TopLevel = false;
                roadtoll.Dock = DockStyle.Fill;
                roadtoll.Parent = tabPageFrmRoadtoll;
                roadtoll.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(roadtoll.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            ShowTransferManager();

        }

        private void tSBtnVehicleType_Click(object sender, EventArgs e)
        {
            FrmVehicleType vehicleType = FrmVehicleType.getInstance();
            if (vehicleType.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmVehicleType = new TabPage();
                tabPageFrmVehicleType.Text = "车辆类型管理";
                tabControl1.TabPages.Add(tabPageFrmVehicleType);
                vehicleType.tabPageTitle = tabPageFrmVehicleType.Text;
                vehicleType.FormBorderStyle = FormBorderStyle.None;
                vehicleType.TopLevel = false;
                vehicleType.Dock = DockStyle.Fill;
                vehicleType.Parent = tabPageFrmVehicleType;
                vehicleType.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(vehicleType.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }
        private void btnGPS_Click(object sender, EventArgs e)
        {
            ShowLocationMonitor();
        }
        bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }
        #region 设置抽屉菜单
        public void ReSetBtnBackgroundImage()
        {
            btnBaseInfo.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnTransfer.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnBusiness.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnDataMonitor.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnAssist.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnDataDic.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnSysSet.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
            btnDataManager.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button0.png");
        }
        private void btnBaseInfo_Click(object sender, EventArgs e)
        {
            btnBaseInfo.Dock = DockStyle.Top;

            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Bottom;
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Bottom;
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Bottom;
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Bottom;
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Bottom;
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Bottom;
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelTransfer.SendToBack();
            panelBusiness.SendToBack();
            panelDataMonitor.SendToBack();
            panelAssist.SendToBack();
            panelDataDic.SendToBack();
            panelSysSet.SendToBack();
            panelDataManager.SendToBack();
            panelBaseInfo.BringToFront();
            panelBaseInfo.Dock = DockStyle.Fill;
            ReSetBtnBackgroundImage();
            btnBaseInfo.BackgroundImage = Image.FromFile(Application.StartupPath+"\\images\\button1.png");
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;

           
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Bottom;
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Bottom;
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Bottom;
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Bottom;
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Bottom;
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelBaseInfo.SendToBack();           
            panelBusiness.SendToBack();
            panelDataMonitor.SendToBack();
            panelAssist.SendToBack();
            panelDataDic.SendToBack();
            panelSysSet.SendToBack();
            panelDataManager.SendToBack();

            panelTransfer.BringToFront();
            panelTransfer.Dock = DockStyle.Fill;

            ReSetBtnBackgroundImage();
            btnTransfer.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            btnBusiness.Dock = DockStyle.Top;
            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;
           
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Bottom;
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Bottom;
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Bottom;
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Bottom;
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelBaseInfo.SendToBack();
            panelTransfer.SendToBack();           
            panelDataMonitor.SendToBack();
            panelAssist.SendToBack();
            panelDataDic.SendToBack();
            panelSysSet.SendToBack();
            panelDataManager.SendToBack();

            panelBusiness.BringToFront();
            panelBusiness.Dock = DockStyle.Fill;
            ReSetBtnBackgroundImage();
            btnBusiness.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");
        }

        private void btnDataMonitor_Click(object sender, EventArgs e)
        {
            btnDataMonitor.Dock = DockStyle.Top;
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Top;
            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;
            
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Bottom;
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Bottom;
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Bottom;
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelBaseInfo.SendToBack();
            panelTransfer.SendToBack();
            panelBusiness.SendToBack();
            panelAssist.SendToBack();
            panelDataDic.SendToBack();
            panelSysSet.SendToBack();
            panelDataManager.SendToBack();

            panelDataMonitor.BringToFront();
            panelDataMonitor.Dock = DockStyle.Fill;
            ReSetBtnBackgroundImage();
            btnDataMonitor.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");
        }

        private void btnAssist_Click(object sender, EventArgs e)
        {
            btnAssist.Dock = DockStyle.Top;
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Top;
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Top;
            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;
           
           
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Bottom;
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Bottom;
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelBaseInfo.SendToBack();
            panelTransfer.SendToBack();
            panelBusiness.SendToBack();
            panelDataMonitor.SendToBack();
            panelDataDic.SendToBack();
            panelSysSet.SendToBack();
            panelDataManager.SendToBack();

            panelAssist.BringToFront();
            panelAssist.Dock = DockStyle.Fill;
            ReSetBtnBackgroundImage();
            btnAssist.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");
        }

        private void btnDataDic_Click(object sender, EventArgs e)
        {
            btnDataDic.Dock = DockStyle.Top;
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Top;          
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Top;
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Top;
            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;


           
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Bottom;
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelBaseInfo.SendToBack();
            panelTransfer.SendToBack();
            panelBusiness.SendToBack();
            panelDataMonitor.SendToBack();
            panelAssist.SendToBack();
            panelSysSet.SendToBack();
            panelDataManager.SendToBack();

            panelDataDic.BringToFront();
            panelDataDic.Dock = DockStyle.Fill;

            ReSetBtnBackgroundImage();
            btnDataDic.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");
        }

        private void btnSysSet_Click(object sender, EventArgs e)
        {
            btnSysSet.Dock = DockStyle.Top;
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Top;
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Top;          
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Top;
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Top;
            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;  
                     
            btnDataManager.SendToBack();
            btnDataManager.Dock = DockStyle.Bottom;

            panelBaseInfo.SendToBack();
            panelTransfer.SendToBack();
            panelBusiness.SendToBack();
            panelDataMonitor.SendToBack();
            panelAssist.SendToBack();
            panelDataDic.SendToBack();
            panelDataManager.SendToBack();

            panelSysSet.BringToFront();
            panelSysSet.Dock = DockStyle.Fill;

            ReSetBtnBackgroundImage();
            btnSysSet.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");
        }

        private void btnDataManager_Click(object sender, EventArgs e)
        {
            btnDataManager.Dock = DockStyle.Top;
            btnSysSet.SendToBack();
            btnSysSet.Dock = DockStyle.Top;
            btnDataDic.SendToBack();
            btnDataDic.Dock = DockStyle.Top;
            btnAssist.SendToBack();
            btnAssist.Dock = DockStyle.Top;            
            btnDataMonitor.SendToBack();
            btnDataMonitor.Dock = DockStyle.Top;
            btnBusiness.SendToBack();
            btnBusiness.Dock = DockStyle.Top;
            btnTransfer.SendToBack();
            btnTransfer.Dock = DockStyle.Top;
            btnBaseInfo.SendToBack();
            btnBaseInfo.Dock = DockStyle.Top;

            panelBaseInfo.SendToBack();
            panelTransfer.SendToBack();
            panelBusiness.SendToBack();
            panelDataMonitor.SendToBack();
            panelAssist.SendToBack();
            panelDataDic.SendToBack();
            panelSysSet.SendToBack();

            panelDataManager.BringToFront();
            panelDataManager.Dock = DockStyle.Fill;

            ReSetBtnBackgroundImage();
            btnDataManager.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\button1.png");

        }
        void SetBaseInfoButtonImageIndex()
        {
            btnCompanyInfo.ImageIndex = 0;
            btnUserInfo.ImageIndex = 2;
            btnClientInfo.ImageIndex = 4;
            btnVehicleInfo.ImageIndex = 6;
            btnDriverInfo.ImageIndex = 8;
            btnDeviceInfo.ImageIndex = 10;
        }
        void SetTransferButtonImageIndex()
        {
            btnTransferManager.ImageIndex = 0;
            btnTransferPath.ImageIndex = 2;
            btnTransferFee.ImageIndex = 4;
            btnTransferEx.ImageIndex = 6;
            btnParking.ImageIndex = 8;           
        }
        void SetBusinessesButtonImageIndex()
        {
            btnTransferOrder.ImageIndex = 0;
            btnExceptionHandle.ImageIndex = 2;            
        }

        void SetDataMonitorsButtonImageIndex()
        {
            btnLocationMonitor.ImageIndex = 0;
            btnTempMonitor.ImageIndex = 2;
            btnVehicleStatusMonitor.ImageIndex = 4;
            btnExceptionMonitor.ImageIndex = 6;           
        }
        void SetAssistsButtonImageIndex()
        {
            btnVehicleMaintain.ImageIndex = 0;
            btnReportManager.ImageIndex = 2;
                 
        }
        void SetDataDicsButtonImageIndex()
        {
            btnUserType.ImageIndex = 0;
            btnProductInfo.ImageIndex = 2;
            btnLocationInfo.ImageIndex = 4;
            btnUserLimit.ImageIndex = 6;
            btnSpecification.ImageIndex = 8;
        }
        void SetSysSetsButtonImageIndex()
        {
            btnCompanyInfoSet.ImageIndex = 0;
            btnLogManager.ImageIndex = 2;
           
        }
        void SetDataManagersButtonImageIndex()
        {
            btnDataClear.ImageIndex = 0;
            btnDataBake.ImageIndex = 2;
            btnDataExport.ImageIndex = 4;

        }
        #endregion

        #region 按钮调用

        private void btnBaseInfos_Click(object sender,EventArgs e)
        {
            SetBaseInfoButtonImageIndex();
            Button btn= (Button)sender;
            btn.ImageIndex += 1;
            switch(btn.Name)
            {
                case "btnCompanyInfo":
                    ShowCompanyInfo();
                    break;
                case "btnClientInfo":
                    ShowClientInfo();
                    break;
                case "btnUserInfo":
                    ShowUserInfo();
                    break;
                case "btnDeviceInfo":
                    ShowDeviceInfo();
                    break;
                case "btnDriverInfo":
                    ShowDriverInfo();
                    break;
                case "btnVehicleInfo":
                    ShowVehicleInfo();
                    break;
            }
        }
        private void btnTransfers_Click(object sender, EventArgs e)
        {
            SetTransferButtonImageIndex();
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnTransferManager":
                    ShowTransferManager();
                    break;
                case "btnTransferPath":
                    ShowTransferPath();
                    break;
                case "btnTransferFee":
                    ShowTransferFee();
                    break;
                case "btnTransferEx":
                    ShowTransferEx();
                    break;
                case "btnParking":
                    ShowParkingArea();
                    break;

            }
        }
        private void btnBusineses_Click(object sender, EventArgs e)
        {
            SetBusinessesButtonImageIndex();
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnTransferOrder":
                    ShowTransferOrder();
                    break;
                case "btnExceptionHandle":
                    ShowExceptionHandle();
                    break;
            }
        }

        private void btnDataMonitors_Click(object sender, EventArgs e)
        {
            SetDataMonitorsButtonImageIndex();
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnLocationMonitor":
                    ShowLocationMonitor();
                    break;
                case "btnTempMonitor":
                    ShowTempMonitor();
                    break;
                case "btnVehicleStatus":
                    ShowVehicleStatus();
                    break;
                case "btnExceptionMonitor":
                    ShowExceptionMonitor();
                    break;
            }
        }

        private void btnAssists_Click(object sender, EventArgs e)
        {
            SetAssistsButtonImageIndex();
            int a = 1;
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnVehicleMaintain":
                    ShowReportManager();
                    break;
                case "btnReportManager":
                    ShowVehicleMaintain();
                    break;
            }
        }
        private void btnDataDics_Click(object sender, EventArgs e)
        {
            SetDataDicsButtonImageIndex();
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnUserType":
                    ShowUserType();
                    break;
                case "btnProductInfo":
                    ShowProductInfo();
                    break;
                case "btnLocationInfo":
                    ShowLocationInfo();
                    break;
                case "btnUserLimit":
                    ShowUserLimit();
                    break;
                case "btnSpecification":
                    ShowSpecification();
                    break;
            }
        }
        private void btnSysSets_Click(object sender, EventArgs e)
        {
            SetSysSetsButtonImageIndex();
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnCompanyInfoSet":
                    ShowCompanyInfoSet();
                    break;
                case "btnLogManager":
                    ShowLogManager();
                    break;
            }
        }
        private void btnDataManagers_Click(object sender, EventArgs e)
        {
            SetDataManagersButtonImageIndex();
            Button btn = (Button)sender;
            btn.ImageIndex += 1;
            switch (btn.Name)
            {
                case "btnDataClear":
                    ShowDataClear();
                    break;
                case "btnDataBake":
                    ShowDataBake();
                    break;
                case "btnDataExport":
                    ShowDataExport();
                    break;
            }
        }
        #endregion

        #region 功能模块

        private void ShowDataExport()
        {
            FrmDataExport dataExport = FrmDataExport.getInstance();
            dataExport.usersInfo = usersInfo;
            if (dataExport.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmDataExport = new TabPage();
                tabPageFrmDataExport.Text = "数据导出";
                tabControl1.TabPages.Add(tabPageFrmDataExport);
                dataExport.tabPageTitle = tabPageFrmDataExport.Text;
                dataExport.FormBorderStyle = FormBorderStyle.None;
                dataExport.TopLevel = false;
                dataExport.Dock = DockStyle.Fill;
                dataExport.Parent = tabPageFrmDataExport;
                dataExport.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(dataExport.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowDataBake()
        {
            //MessageBox.Show("数据备份");
        }

        private void ShowDataClear()
        {
            //MessageBox.Show("数据清理");
        }

        private void ShowLogManager()
        {
            //MessageBox.Show("日志管理");
        }

        private void ShowCompanyInfoSet()
        {
            //MessageBox.Show("公司信息设置");
        }

        private void ShowSpecification()
        {
            //MessageBox.Show("规格");
        }

        private void ShowUserLimit()
        {
            MessageBox.Show("请联系管理人员设置用户权限！");
            //FrmUserControl userControl = FrmUserControl.getInstance();
            //if (userControl.tabPageTitle.Equals(""))
            //{
            //    TabPage tabPageFrmUserControl = new TabPage();
            //    tabPageFrmUserControl.Text = "用户权限";
            //    tabControl1.TabPages.Add(tabPageFrmUserControl);
            //    userControl.tabPageTitle = tabPageFrmUserControl.Text;
            //    userControl.FormBorderStyle = FormBorderStyle.None;
            //    userControl.TopLevel = false;
            //    userControl.Dock = DockStyle.Fill;
            //    userControl.Parent = tabPageFrmUserControl;
            //    userControl.Show();
            //    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            //    index++;
            //}
            //else
            //{
            //    for (int i = 0; i < tabControl1.TabPages.Count; i++)
            //    {
            //        if (tabControl1.TabPages[i].Text.Equals(userControl.tabPageTitle))
            //        {
            //            tabControl1.SelectedTab = tabControl1.TabPages[i];
            //            break;
            //        }
            //    }
            //}
        }

        private void ShowLocationInfo()
        {
            //MessageBox.Show("位置信息");
        }

        private void ShowProductInfo()
        {
            FrmProduct product = FrmProduct.getInstance();
            product.usersInfo = usersInfo;
            if (product.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmProduct = new TabPage();
                tabPageFrmProduct.Text = "货品基本信息";
                tabControl1.TabPages.Add(tabPageFrmProduct);
                product.tabPageTitle = tabPageFrmProduct.Text;
                product.FormBorderStyle = FormBorderStyle.None;
                product.TopLevel = false;
                product.Dock = DockStyle.Fill;
                product.Parent = tabPageFrmProduct;
                product.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(product.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowUserType()
        {
            MessageBox.Show("如有需求请联系管理人员！");
            //FrmUserType userType = FrmUserType.getInstance();          
            //if (userType.tabPageTitle.Equals(""))
            //{
            //    TabPage tabPageFrmUserType = new TabPage();
            //    tabPageFrmUserType.Text = "用户类型";
            //    tabControl1.TabPages.Add(tabPageFrmUserType);
            //    userType.tabPageTitle = tabPageFrmUserType.Text;
            //    userType.FormBorderStyle = FormBorderStyle.None;
            //    userType.TopLevel = false;
            //    userType.Dock = DockStyle.Fill;
            //    userType.Parent = tabPageFrmUserType;
            //    userType.Show();
            //    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            //    index++;
            //}
            //else
            //{
            //    for (int i = 0; i < tabControl1.TabPages.Count; i++)
            //    {
            //        if (tabControl1.TabPages[i].Text.Equals(userType.tabPageTitle))
            //        {
            //            tabControl1.SelectedTab = tabControl1.TabPages[i];
            //            break;
            //        }
            //    }
            //}
        }

        private void ShowReportManager()
        {
            FrmReportManager report = FrmReportManager.getInstance();
            report.usersInfo = usersInfo;
            if (report.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmReport = new TabPage();
                tabPageFrmReport.Text = "报表管理";
                tabControl1.TabPages.Add(tabPageFrmReport);
                report.tabPageTitle = tabPageFrmReport.Text;
                report.FormBorderStyle = FormBorderStyle.None;
                report.TopLevel = false;
                report.Dock = DockStyle.Fill;
                report.Parent = tabPageFrmReport;
                report.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(report.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowVehicleMaintain()
        {

            FrmVehicleupkeep vehiclekeep = FrmVehicleupkeep.getInstance();
            vehiclekeep.usersInfo = usersInfo;
            if (vehiclekeep.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmVehiclekeep = new TabPage();
                tabPageFrmVehiclekeep.Text = "车辆保养";
                tabControl1.TabPages.Add(tabPageFrmVehiclekeep);
                vehiclekeep.tabPageTitle = tabPageFrmVehiclekeep.Text;
                vehiclekeep.FormBorderStyle = FormBorderStyle.None;
                vehiclekeep.TopLevel = false;
                vehiclekeep.Dock = DockStyle.Fill;
                vehiclekeep.Parent = tabPageFrmVehiclekeep;
                vehiclekeep.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(vehiclekeep.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowExceptionMonitor()
        {
            //MessageBox.Show("异常监控");
        }

        private void ShowVehicleStatus()
        {
            //MessageBox.Show("车辆状态管理");
        }

        private void ShowTempMonitor()
        {
            FrmLocationMonitor locationMonitor = FrmLocationMonitor.getInstance();
            locationMonitor.usersInfo = usersInfo;
            if (locationMonitor.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmLocationMonitor = new TabPage();
                tabPageFrmLocationMonitor.Text = "温湿度和定位监控";
                tabControl1.TabPages.Add(tabPageFrmLocationMonitor);
                locationMonitor.tabPageTitle = tabPageFrmLocationMonitor.Text;
                locationMonitor.FormBorderStyle = FormBorderStyle.None;
                locationMonitor.TopLevel = false;
                locationMonitor.Dock = DockStyle.Fill;
                locationMonitor.Parent = tabPageFrmLocationMonitor;
                locationMonitor.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(locationMonitor.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowLocationMonitor()
        {
            FrmLocationMonitor locationMonitor = FrmLocationMonitor.getInstance();
            locationMonitor.usersInfo = usersInfo;
            if (locationMonitor.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmLocationMonitor = new TabPage();
                tabPageFrmLocationMonitor.Text = "温湿度和定位监控";
                tabControl1.TabPages.Add(tabPageFrmLocationMonitor);
                locationMonitor.tabPageTitle = tabPageFrmLocationMonitor.Text;
                locationMonitor.FormBorderStyle = FormBorderStyle.None;
                locationMonitor.TopLevel = false;
                locationMonitor.Dock = DockStyle.Fill;
                locationMonitor.Parent = tabPageFrmLocationMonitor;
                locationMonitor.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(locationMonitor.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowExceptionHandle()
        {
            FrmException exception = FrmException.getInstance();
            exception.usersInfo = usersInfo;
            if (exception.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmException = new TabPage();
                tabPageFrmException.Text = "异常信息";
                tabControl1.TabPages.Add(tabPageFrmException);
                exception.tabPageTitle = tabPageFrmException.Text;
                exception.FormBorderStyle = FormBorderStyle.None;
                exception.TopLevel = false;
                exception.Dock = DockStyle.Fill;
                exception.Parent = tabPageFrmException;
                exception.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(exception.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }
        private void ShowTransferOrder()
        {
            FrmTranferOrder transferOrder = FrmTranferOrder.getInstance();
            transferOrder.usersInfo = usersInfo;
            if (transferOrder.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmTransferOrder = new TabPage();
                tabPageFrmTransferOrder.Text = "运单管理";
                tabControl1.TabPages.Add(tabPageFrmTransferOrder);
                transferOrder.tabPageTitle = tabPageFrmTransferOrder.Text;
                transferOrder.FormBorderStyle = FormBorderStyle.None;
                transferOrder.TopLevel = false;
                transferOrder.Dock = DockStyle.Fill;
                transferOrder.Parent = tabPageFrmTransferOrder;
                transferOrder.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(transferOrder.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }
        private void ShowTransferEx()
        {
            FrmException exception = FrmException.getInstance();
            exception.usersInfo = usersInfo;
            if (exception.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmException = new TabPage();
                tabPageFrmException.Text = "异常信息";
                tabControl1.TabPages.Add(tabPageFrmException);
                exception.tabPageTitle = tabPageFrmException.Text;
                exception.FormBorderStyle = FormBorderStyle.None;
                exception.TopLevel = false;
                exception.Dock = DockStyle.Fill;
                exception.Parent = tabPageFrmException;
                exception.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(exception.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }
        private void ShowParkingArea()
        {
            FrmRegionalparkmanage regionalpark = FrmRegionalparkmanage.getInstance();
            regionalpark.usersInfo = usersInfo;
            if (regionalpark.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmRegionalpark = new TabPage();
                tabPageFrmRegionalpark.Text = "区域停车管理";
                tabControl1.TabPages.Add(tabPageFrmRegionalpark);
                regionalpark.tabPageTitle = tabPageFrmRegionalpark.Text;
                regionalpark.FormBorderStyle = FormBorderStyle.None;
                regionalpark.TopLevel = false;
                regionalpark.Dock = DockStyle.Fill;
                regionalpark.Parent = tabPageFrmRegionalpark;
                regionalpark.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(regionalpark.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowTransferFee()
        {
          
            btnTransferFee.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Show(btnTransferFee, btnTransferFee.Width, btnTransferFee.Height);


            //FrmFee fee = FrmFee.getInstance();
            //fee.usersInfo = usersInfo;
            //if (fee.tabPageTitle.Equals(""))
            //{
            //    TabPage tabPageFrmFee = new TabPage();
            //    tabPageFrmFee.Text = "运输费用管理";
            //    tabControl1.TabPages.Add(tabPageFrmFee);
            //    fee.tabPageTitle = tabPageFrmFee.Text;
            //    fee.FormBorderStyle = FormBorderStyle.None;
            //    fee.TopLevel = false;
            //    fee.Dock = DockStyle.Fill;
            //    fee.Parent = tabPageFrmFee;
            //    fee.Show();
            //    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            //    index++;
            //}
            //else
            //{
            //    for (int i = 0; i < tabControl1.TabPages.Count; i++)
            //    {
            //        if (tabControl1.TabPages[i].Text.Equals(fee.tabPageTitle))
            //        {
            //            tabControl1.SelectedTab = tabControl1.TabPages[i];
            //            break;
            //        }
            //    }
            //}
        }
        private void ShowTransferPath()
        {
            FrmTransferPath transferPath = FrmTransferPath.getInstance();
            transferPath.usersInfo = usersInfo;
            if (transferPath.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmTransferPath = new TabPage();
                tabPageFrmTransferPath.Text = "运输路径管理";
                tabControl1.TabPages.Add(tabPageFrmTransferPath);
                transferPath.tabPageTitle = tabPageFrmTransferPath.Text;
                transferPath.FormBorderStyle = FormBorderStyle.None;
                transferPath.TopLevel = false;
                transferPath.Dock = DockStyle.Fill;
                transferPath.Parent = tabPageFrmTransferPath;
                transferPath.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(transferPath.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowTransferManager()
        {
            FrmTransferManager transport = FrmTransferManager.getInstance();
            transport.usersInfo = usersInfo;
            if (transport.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmTransport = new TabPage();
                tabPageFrmTransport.Text = "运输管理";
                tabControl1.TabPages.Add(tabPageFrmTransport);
                transport.tabPageTitle = tabPageFrmTransport.Text;
                transport.FormBorderStyle = FormBorderStyle.None;
                transport.TopLevel = false;
                transport.Dock = DockStyle.Fill;
                transport.Parent = tabPageFrmTransport;
                transport.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(transport.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowDeviceInfo()
        {
            FrmDeviceUse terminalDevice = FrmDeviceUse.getInstance();
            terminalDevice.usersInfo = usersInfo;
            if (terminalDevice.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmTerminalDevice = new TabPage();
                tabPageFrmTerminalDevice.Text = "终端设备信息";
                tabControl1.TabPages.Add(tabPageFrmTerminalDevice);
                terminalDevice.tabPageTitle = tabPageFrmTerminalDevice.Text;
                terminalDevice.FormBorderStyle = FormBorderStyle.None;
                terminalDevice.TopLevel = false;
                terminalDevice.Dock = DockStyle.Fill;
                terminalDevice.Parent = tabPageFrmTerminalDevice;
                terminalDevice.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(terminalDevice.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowDriverInfo()
        {
            FrmDriver driver = FrmDriver.getInstance();
            driver.usersInfo = usersInfo;
            if (driver.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmDriver = new TabPage();
                tabPageFrmDriver.Text = "驾驶员管理";
                tabControl1.TabPages.Add(tabPageFrmDriver);
                driver.tabPageTitle = tabPageFrmDriver.Text;
                driver.FormBorderStyle = FormBorderStyle.None;
                driver.TopLevel = false;
                driver.Dock = DockStyle.Fill;
                driver.Parent = tabPageFrmDriver;
                driver.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(driver.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowVehicleInfo()
        {
            FrmVehicleinfo vehicle = FrmVehicleinfo.getInstance();
            vehicle.usersInfo = usersInfo;
            if (vehicle.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmVehicle = new TabPage();
                tabPageFrmVehicle.Text = "车辆信息";
                tabControl1.TabPages.Add(tabPageFrmVehicle);
                vehicle.tabPageTitle = tabPageFrmVehicle.Text;
                vehicle.FormBorderStyle = FormBorderStyle.None;
                vehicle.TopLevel = false;
                vehicle.Dock = DockStyle.Fill;
                vehicle.Parent = tabPageFrmVehicle;
                vehicle.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(vehicle.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowUserInfo()
        {
            FrmUserManager userManager = FrmUserManager.getInstance();
            userManager.usersInfo = usersInfo;         
            if (userManager.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmUserManager = new TabPage();
                tabPageFrmUserManager.Text = "用户管理";
                tabControl1.TabPages.Add(tabPageFrmUserManager);
                userManager.tabPageTitle = tabPageFrmUserManager.Text;
                userManager.FormBorderStyle = FormBorderStyle.None;
                userManager.TopLevel = false;
                userManager.Dock = DockStyle.Fill;
                userManager.Parent = tabPageFrmUserManager;
                userManager.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(userManager.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowCompanyInfo()
        {
            FrmCompany company = FrmCompany.getInstance();
            company.usersInfo = usersInfo;
            if (company.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmCompany = new TabPage();
                tabPageFrmCompany.Text = "公司信息管理";
                tabControl1.TabPages.Add(tabPageFrmCompany);
                company.tabPageTitle = tabPageFrmCompany.Text;
                company.FormBorderStyle = FormBorderStyle.None;
                company.TopLevel = false;
                company.Dock = DockStyle.Fill;
                company.Parent = tabPageFrmCompany;
                company.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(company.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void ShowClientInfo()
        {
            FrmClient client = FrmClient.getInstance();
            client.usersInfo = usersInfo;
            if (client.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmClient = new TabPage();
                tabPageFrmClient.Text = "客户管理";
                tabControl1.TabPages.Add(tabPageFrmClient);
                client.tabPageTitle = tabPageFrmClient.Text;
                client.FormBorderStyle = FormBorderStyle.None;
                client.TopLevel = false;
                client.Dock = DockStyle.Fill;
                client.Parent = tabPageFrmClient;
                client.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(client.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        #endregion

        private void panelTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            ShowTransferOrder();
        }

        private void btnCurTemp_Click(object sender, EventArgs e)
        {
            ShowTempMonitor();
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;           
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnLogOut, "注销");
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnClose, "退出");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定退出跃叶物流监控管理平台吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMinSize_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnMinSize, "最小化");
        }

        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // 如果窗口已经最大化，则恢恢复为正常大小
                this.WindowState = FormWindowState.Normal;                
                
            }
            else
            {
                // 否则，窗口为正常时，将其最大化
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMaxSize_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // 如果窗口已经最大化，则恢恢复为正常大小
                ToolTip p = new ToolTip();
                p.ShowAlways = true;
                p.SetToolTip(this.btnMaxSize, "向下还原");

            }
            else
            {
                // 否则，窗口为正常时，将其最大化
                ToolTip p = new ToolTip();
                p.ShowAlways = true;
                p.SetToolTip(this.btnMaxSize, "");
                p.SetToolTip(this.btnMaxSize, "最大化");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TSMenuRufeling_Click(object sender, EventArgs e)
        {
            FrmRefueling refueling = FrmRefueling.getInstance();
            refueling.usersInfo = usersInfo;
            if (refueling.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmRefuling = new TabPage();
                tabPageFrmRefuling.Text = "加油费用管理";
                tabControl1.TabPages.Add(tabPageFrmRefuling);
                refueling.tabPageTitle = tabPageFrmRefuling.Text;
                refueling.FormBorderStyle = FormBorderStyle.None;
                refueling.TopLevel = false;
                refueling.Dock = DockStyle.Fill;
                refueling.Parent = tabPageFrmRefuling;
                refueling.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(refueling.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }

        private void TSMenuRoadtoll_Click(object sender, EventArgs e)
        {
            FrmRoadtoll roadtoll = FrmRoadtoll.getInstance();
            roadtoll.usersInfo = usersInfo;
            if (roadtoll.tabPageTitle.Equals(""))
            {
                TabPage tabPageFrmRoadtoll = new TabPage();
                tabPageFrmRoadtoll.Text = "过路费用管理";
                tabControl1.TabPages.Add(tabPageFrmRoadtoll);
                roadtoll.tabPageTitle = tabPageFrmRoadtoll.Text;
                roadtoll.FormBorderStyle = FormBorderStyle.None;
                roadtoll.TopLevel = false;
                roadtoll.Dock = DockStyle.Fill;
                roadtoll.Parent = tabPageFrmRoadtoll;
                roadtoll.Show();
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                index++;
            }
            else
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text.Equals(roadtoll.tabPageTitle))
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        break;
                    }
                }
            }
        }
    }
}
