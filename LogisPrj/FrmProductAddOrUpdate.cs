using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmProductAddOrUpdate : Form
    {
        public YueYePlat.Model.productinfo product;
        public YueYePlat.Model.usersinfo usersInfo;
        public FrmProductAddOrUpdate()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (product != null)
            {
                product .ProductId = lblProductId.Text;
                product.ProductName = txtProductName.Text;
                product.ProductType = txtProductType.Text;
                product.Specification = txtSpecification.Text;
                product.Manufaturer = txtManufaturer.Text;
                product.BatchNum = txtBatchNum.Text;
                product.DataofManufaturer = dTDataofManufaturer.Value;
                product.UnitofMeasurement = txtUnitofMeasurement.Text;
                if (new YueYePlat.BLL.productinfo().Update(product))
                {
                    MessageBox.Show("修改成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                YueYePlat.Model.productinfo info = new YueYePlat.Model.productinfo();
                info.ProductId = lblProductId.Text;
                info.ProductName = txtProductName.Text;
                info.ProductType = txtProductType.Text;
                info.Specification = txtSpecification.Text;
                info.Manufaturer = txtManufaturer.Text;
                info.BatchNum = txtBatchNum.Text;
                if (this.dTDataofManufaturer.Text == " ")
                {
                }
                else
                {
                    info.DataofManufaturer = dTDataofManufaturer.Value ;
                }                   
                info.UnitofMeasurement = txtUnitofMeasurement.Text;
                if (lblProductId.Text != "" && txtProductName.Text != "")
                {
                    if (new YueYePlat.BLL.productinfo().Add(info))
                    {
                        MessageBox.Show("增加成功！");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("请完善货品资料信息！");
                }
            }
        }

        private void FrmProductAddOrUpdate_Load(object sender, EventArgs e)
        {
            lblProductId.Text = "";
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            dTDataofManufaturer.Format = DateTimePickerFormat.Custom;
            dTDataofManufaturer.CustomFormat = " ";            
            dTDataofManufaturer.Checked = false;   
            if (product != null)
            {
                lblProductId.Text= product.ProductId;
                txtProductName.Text= product.ProductName ;
                txtProductType.Text = product.ProductType;
                txtSpecification.Text = product.Specification;
                txtManufaturer.Text=product.Manufaturer;
                txtBatchNum.Text=product.BatchNum  ;
                dTDataofManufaturer.Text  =product.DataofManufaturer.ToString ()  ;
                txtUnitofMeasurement.Text=product.UnitofMeasurement  ;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static string GetSpellCode(string CnStr)
        {

            string strTemp = "";

            int iLen = CnStr.Length;

            int i = 0;

            for (i = 0; i <= iLen - 1; i++)
            {

                strTemp += GetCharSpellCode(CnStr.Substring(i, 1));

            }

            return strTemp;

        }

        /// <summary>
        /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母
        /// </summary>
        /// <param name="CnChar">单个汉字</param>
        /// <returns>单个大写字母</returns>

        private static string GetCharSpellCode(string CnChar)
        {

            long iCnChar;

            byte[] ZW = System.Text.Encoding.Default.GetBytes(CnChar);

            //如果是字母，则直接返回

            if (ZW.Length == 1)
            {

                return CnChar.ToUpper();

            }

            else
            {

                // get the array of byte from the single char

                int i1 = (short)(ZW[0]);

                int i2 = (short)(ZW[1]);

                iCnChar = i1 * 256 + i2;

            }

            // iCnChar match the constant

            if ((iCnChar >= 45217) && (iCnChar <= 45252))
            {

                return "A";

            }

            else if ((iCnChar >= 45253) && (iCnChar <= 45760))
            {

                return "B";

            }
            else if ((iCnChar >= 45761) && (iCnChar <= 46317))
            {

                return "C";

            }
            else if ((iCnChar >= 46318) && (iCnChar <= 46825))
            {

                return "D";

            }
            else if ((iCnChar >= 46826) && (iCnChar <= 47009))
            {

                return "E";

            }
            else if ((iCnChar >= 47010) && (iCnChar <= 47296))
            {

                return "F";

            }
            else if ((iCnChar >= 47297) && (iCnChar <= 47613))
            {

                return "G";

            }
            else if ((iCnChar >= 47614) && (iCnChar <= 48118))
            {

                return "H";

            }
            else if ((iCnChar >= 48119) && (iCnChar <= 49061))
            {

                return "J";

            }
            else if ((iCnChar >= 49062) && (iCnChar <= 49323))
            {

                return "K";

            }
            else if ((iCnChar >= 49324) && (iCnChar <= 49895))
            {

                return "L";

            }
            else if ((iCnChar >= 49896) && (iCnChar <= 50370))
            {

                return "M";

            }
            else if ((iCnChar >= 50371) && (iCnChar <= 50613))
            {

                return "N";

            }
            else if ((iCnChar >= 50614) && (iCnChar <= 50621))
            {

                return "O";

            }
            else if ((iCnChar >= 50622) && (iCnChar <= 50905))
            {

                return "P";

            }
            else if ((iCnChar >= 50906) && (iCnChar <= 51386))
            {

                return "Q";

            }
            else if ((iCnChar >= 51387) && (iCnChar <= 51445))
            {

                return "R";

            }
            else if ((iCnChar >= 51446) && (iCnChar <= 52217))
            {

                return "S";

            }
            else if ((iCnChar >= 52218) && (iCnChar <= 52697))
            {

                return "T";

            }
            else if ((iCnChar >= 52698) && (iCnChar <= 52979))
            {

                return "W";

            }
            else if ((iCnChar >= 52980) && (iCnChar <= 53640))
            {

                return "X";

            }
            else if ((iCnChar >= 53689) && (iCnChar <= 54480))
            {

                return "Y";

            }
            else if ((iCnChar >= 54481) && (iCnChar <= 55289))
            {

                return "Z";

            }
            else

                return ("?");

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            string strProductName = GetSpellCode(txtProductName.Text).ToLower();
            lblProductId.Text = GenerateProductID(strProductName);
        }
        private string GenerateProductID(string ProductName)
        {
            string str = ProductName;            
            List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId like '{0}%' order by ProductId desc", str));
            if (productList.Count == 0)
            {
                return str + "01";
            }
            else
            {
                string cId = productList[0].ProductId;

                string cidCount = "1" + cId.Substring(cId.Length -2);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }

        private void dTDataofManufaturer_ValueChanged(object sender, EventArgs e)
        {
            this.dTDataofManufaturer.Format = DateTimePickerFormat.Custom;
            this.dTDataofManufaturer.CustomFormat = "yyyy-MM-dd 00:00:00";
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            if (txtProductName.Text.Trim() != "")
            {
                List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format ("ProductName='{0}'",txtProductName.Text .Trim ()));
                if (productList.Count > 0)
                {
                    MessageBox.Show("该货品已经存在！");
                    txtProductName.Text = "";
                    lblProductId.Text = "";
                }
              
            }
        }
    }
}
