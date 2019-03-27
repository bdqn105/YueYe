using Log;
using Qiniu.IO;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmRetrunOrder : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strReturnOrderUrl = "";
        public string strReturnOrderName = "";
        string strqiniu = "http://p94gz7ls5.bkt.clouddn.com";
        private const double step = 0.1;
        private const int zoomStep = 50;
        int mouseX;
        int mouseY;
        int picX;
        int picY;
        int panX;
        Point mouseDownPoint;
        bool isSelected ;
        bool isMove;
        public FrmRetrunOrder()
        {
            InitializeComponent();
        }

        private void FrmRetrunOrder_Load(object sender, EventArgs e)
        {
            this.MouseWheel += Form1_MouseWheel;
            this.pictureBox1.Cursor = Cursors.SizeAll;
            QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
            QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
            QiniuInfo.Bucket = "yueye";
            QiniuInfo.UrlPrefix = "https://portal.qiniu.com/user/key";
            Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
            int expireInSeconds = 3600;
            if (strReturnOrderUrl != null)
            {
                string accUrl = "";
                if (!strReturnOrderUrl.Contains(strqiniu))
                {
                    accUrl = strqiniu + "/" + strReturnOrderUrl;

                }
                else
                {
                    accUrl = DownloadManager.CreateSignedUrl(mac, strReturnOrderUrl, expireInSeconds);
                }               
                //图片异步加载完成后的处理事件 
                pictureBox1.LoadCompleted += new AsyncCompletedEventHandler(pictureBox1_LoadCompleted);
                //图片加载时，显示等待光标 
                pictureBox1.UseWaitCursor = true;
                //采用异步加载方式 
                pictureBox1.WaitOnLoad = false;
                //开始异步加载，图片的地址，请自行更换 

                if (!ImageLoad(accUrl).ToString().Contains("error"))
                {
                    pictureBox1.LoadAsync(accUrl);
                }
                else
                {
                    this.Close();
                    MessageBox.Show("未能正确加载该图片，请核查！");
                }                

            }           
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0) //放大图片
            {
                pictureBox1.Size = new Size(pictureBox1.Width + 50, pictureBox1.Height + 50);
            }
            else
            {  //缩小图片  
                if (pictureBox1.Size.Height > 100 && pictureBox1.Size.Width > 100)
                {
                    pictureBox1.Size = new Size(pictureBox1.Width - 50, pictureBox1.Height - 50);
                }
            }
            //设置图片在窗体居中
            pictureBox1.Location = new Point((this.Width - pictureBox1.Width) / 2, (this.Height - pictureBox1.Height) / 2);


            //int x = e.Location.X;
            //int y = e.Location.Y;
            //int ow = pictureBox1.Width;
            //int oh = pictureBox1.Height;
            //int VX, VY;     //因缩放产生的位移矢量
            //if (e.Delta > 0)    //放大
            //{
            //    //第①步
            //    pictureBox1.Width += zoomStep;
            //    pictureBox1.Height += zoomStep;
            //    //第②步
            //    PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
            //        BindingFlags.NonPublic);
            //    Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
            //    //第③步
            //    pictureBox1.Width = rect.Width;
            //    pictureBox1.Height = rect.Height;
            //}
            //if (e.Delta < 0)    //缩小
            //{
            //    //防止一直缩成负值
            //    if (pictureBox1.Width < 50)
            //        return;

            //    pictureBox1.Width -= zoomStep;
            //    pictureBox1.Height -= zoomStep;
            //    PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
            //        BindingFlags.NonPublic);
            //    Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
            //    pictureBox1.Width = rect.Width;
            //    pictureBox1.Height = rect.Height;
            //}
            ////第④步，求因缩放产生的位移，进行补偿，实现锚点缩放的效果
            //VX = (int)((double)x * (ow - pictureBox1.Width) / ow);
            //VY = (int)((double)y * (oh - pictureBox1.Height) / oh);
            //pictureBox1.Location = new Point(pictureBox1.Location.X + VX, pictureBox1.Location.Y + VY);

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.UseWaitCursor = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            picX = this.pictureBox1.Left;
            picY = this.pictureBox1.Top;
            panX = this.panel1.Left;       

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int y = Cursor.Position.Y - mouseY + picY;
            int x = Cursor.Position.X - mouseX + picX;
            if (e.Button == MouseButtons.Left)
            {
                this.pictureBox1.Top = y;
                this.pictureBox1.Left = x;
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            mouseX = 0;
            mouseY = 0;
            if (this.pictureBox1.Location.X < 0)
            {
                this.pictureBox1.Left = 0;

            }
            if (this.pictureBox1.Location.Y < 0)
            {
                this.pictureBox1.Top = 0;
            }
            if ((this.pictureBox1.Left + this.pictureBox1.Width) > this.ClientSize.Width)
            {
                this.pictureBox1.Left = this.ClientSize.Width - this.pictureBox1.Width;
            }
            if ((this.pictureBox1.Top + this.pictureBox1.Height) > this.ClientSize.Height)
            {
                this.pictureBox1.Top = this.ClientSize.Height - this.pictureBox1.Height;
            }
        }
        private bool IsMouseInPanel()
        {
            if (this.pictureBox1.Left < PointToClient(Cursor.Position).X
            && PointToClient(Cursor.Position).X < this.pictureBox1.Left + this.pictureBox1.Width
            && this.pictureBox1.Top < PointToClient(Cursor.Position).Y
            && PointToClient(Cursor.Position).Y < this.pictureBox1.Top + this.pictureBox1.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }     
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawImage(pictureBox1.Image,20,20,pictureBox1.Image.Width,pictureBox1.Image .Height );
            //e.Graphics.DrawImage(this.pictureBox1.Image, new Rectangle(0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height ));
            //e.Graphics.DrawImage(pictureBox1.Image, 10, 10, pictureBox1.Image.Width, pictureBox1.Image.Height);

            //var scr = Screen.FromPoint(this.Location);
            //using (var bmp = new Bitmap(scr.Bounds.Width, scr.Bounds.Height))
            //{
            //    using (var gr = Graphics.FromImage(bmp))
            //    {
            //        gr.CopyFromScreen(new Point(scr.Bounds.Left, scr.Bounds.Top), Point.Empty, bmp.Size);
            //    }
            //    // Determine scaling
            //    float scale = 1.0f;
            //    scale = Math.Min(scale, (float)e.MarginBounds.Width / bmp.Width);
            //    scale = Math.Min(scale, (float)e.MarginBounds.Height / bmp.Height);
            //    // Set scaling and offset
            //    e.Graphics.TranslateTransform(e.MarginBounds.Left + (e.MarginBounds.Width - bmp.Width * scale) / 2,
            //                                  e.MarginBounds.Top + (e.MarginBounds.Height - bmp.Height * scale) / 2);
            //    e.Graphics.ScaleTransform(scale, scale);
            //    // And draw
            //    e.Graphics.DrawImage(bmp, 0, 0);
            //}
            try
            {
                if (pictureBox1.Image != null)
                {
                    e.Graphics.DrawImage(pictureBox1.Image,e.Graphics.VisibleClipBounds);
                    e.HasMorePages = false;
                }
            }
            catch (Exception exception)
            {
                
            }
        }
       

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Landscape = true;
        }
        private static object  ImageLoad(string accUrl)
        {
            string url =accUrl;           
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(url);            
            request.Method = "GET";
            // 添加header
            HttpWebResponse response;
            string strValue = "";
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                Stream s;
                s = response.GetResponseStream();
                string StrDate = "";
                
                using (StreamReader Reader = new StreamReader(s, Encoding.UTF8))
                {
                    while ((StrDate = Reader.ReadLine()) != null)
                    {
                        strValue += StrDate + "\r\n";
                    }
                    return strValue;
                }
            }
            catch (Exception ex)
            {
                return strValue = "error";
            }
            
            
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog MyPrintDg = new PrintDialog();
            MyPrintDg.Document = printDocument1;
            if (MyPrintDg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch
                {   //停止打印
                    printDocument1.PrintController.OnEndPrint(printDocument1, new System.Drawing.Printing.PrintEventArgs());
                }
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "图片保存";
            saveImageDialog.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            saveImageDialog.Filter = @"jpeg|*.jpg|bmp|*.bmp";
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveImageDialog.FileName.ToString();
                if (fileName != "" && fileName != null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();
                    System.Drawing.Imaging.ImageFormat imgformat = null;
                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            default:
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                        }
                        try
                        {
                            Bitmap bit = new Bitmap(pictureBox1.Image);
                            MessageBox.Show(fileName);
                            pictureBox1.Image.Save(fileName, imgformat);
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            //pictureBox1.Width += 50;
            //pictureBox1.Height += 50;
            try
            {
                pictureBox1.Width = pictureBox1.Width + int.Parse(Math.Ceiling(pictureBox1.Width * step).ToString());
                pictureBox1.Height = pictureBox1.Height + int.Parse(Math.Ceiling(pictureBox1.Height * step).ToString());

                pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, (panel1.Height - pictureBox1.Height) / 2);
            }
            catch { }
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Width > 50 && pictureBox1.Height > 50)
            //{
            //    pictureBox1.Width -= 50;
            //    pictureBox1.Height -= 50;
            //}
            if (pictureBox1.Width >200 && pictureBox1.Height > 200)
            {
                pictureBox1.Width = pictureBox1.Width - int.Parse(Math.Ceiling(pictureBox1.Width * step).ToString());
                pictureBox1.Height = pictureBox1.Height - int.Parse(Math.Ceiling(pictureBox1.Height * step).ToString());
            }
            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, (panel1.Height - pictureBox1.Height) / 2);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Focus();  //鼠标不在picturebox上时焦点给别的控件，此时无法缩放            
            if (isMove)
            {
                int x, y;           //新的pictureBox1.Location(x,y)
                int moveX, moveY;   //X方向，Y方向移动大小。
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;   //记录鼠标左键按下时位置
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
            }
        }
    }
}
