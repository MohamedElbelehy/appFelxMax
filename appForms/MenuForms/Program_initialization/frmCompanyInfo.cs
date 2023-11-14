using appFelxMax.appForms.OtherForms;
using FlexMax_db;
using FlexMax_db.Commander;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace appFelxMax.appForms.MenuForms
{
    public partial class frmCompanyInfo : Form
    {
        #region Variable
        string vSourcePath = "";
        clsCommander<TBL_Company> cmdCompany = new clsCommander<TBL_Company>();
        TBL_Company vTblCompany = new TBL_Company();

        #endregion

        #region Constructor
        public frmCompanyInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region FormLoad
        private void frmCompanyInfo_Load(object sender, System.EventArgs e)
        {
            fnClear_Data();
        }
        #endregion

        #region Functions
        public int fnMax_ID()
        {
            var x = cmdCompany.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdCompany.GetAll().Where(id => id.Com_ID == cmdCompany.GetAll().Max(mID => mID.Com_ID)).FirstOrDefault();
                int vLastID = vLastRow.Com_ID;
                return vLastID + 1;
            }
            else return 1;
        }

        public void fnClear_Data()
        {
            try
            {
                txtCompanyID.Text = fnMax_ID().ToString();
                var x = cmdCompany.GetAll().ToList();
                if (x.Count == 1)
                {
                    vTblCompany = cmdCompany.GetAll().FirstOrDefault();
                    txtCompanyID.Text = vTblCompany.Com_ID.ToString();
                    txtCompanyName.Text = vTblCompany.Com_Name;
                    txtCompanyNote.Text = vTblCompany.Com_Note;
                    txtAddress.Text = vTblCompany.Com_Address;
                    txtComRec.Text = vTblCompany.Com_Commercial_Record;
                    txtPhone.Text = vTblCompany.Com_Mobile;
                    txtTaxCard.Text = vTblCompany.Com_Tax_Card;

                    Byte[] vByteImage = new byte[0];
                    vByteImage = vTblCompany.Com_Image;
                    MemoryStream vMemoryStrem = new MemoryStream(vByteImage);
                    picLogo.BackgroundImageLayout = ImageLayout.Stretch;
                    //picLOGO.Image = Image.FromStream(vMemoryStrem);
                    picLogo.Image = Image.FromStream(vMemoryStrem);
                    picLogo.BackgroundImage = Image.FromStream(vMemoryStrem);
                }
                else
                {
                    vTblCompany = cmdCompany.GetAll().FirstOrDefault();
                    if (vTblCompany != null)
                    {
                        txtCompanyID.Text = vTblCompany.Com_ID.ToString();
                        txtCompanyName.Text = vTblCompany.Com_Name;
                        txtCompanyNote.Text = vTblCompany.Com_Note;
                        txtAddress.Text = vTblCompany.Com_Address;
                        txtComRec.Text = vTblCompany.Com_Commercial_Record;
                        txtPhone.Text = vTblCompany.Com_Mobile;
                        txtTaxCard.Text = vTblCompany.Com_Tax_Card;

                        Byte[] vByteImage = new byte[0];
                        vByteImage = vTblCompany.Com_Image;
                        MemoryStream vMemoryStrem = new MemoryStream(vByteImage);
                        picLogo.BackgroundImageLayout = ImageLayout.Stretch;
                        //picLOGO.Image = Image.FromStream(vMemoryStrem);
                        picLogo.Image = Image.FromStream(vMemoryStrem);
                        picLogo.BackgroundImage = Image.FromStream(vMemoryStrem);
                    }
                }
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في تحميل البيانات", frmNotifications.enmType.vError);
            }

        }
        public bool fnValidation()
        {
            if (txtCompanyID.Text == "") return false;
            else if (txtComRec.Text == "") return false;
            else if (txtTaxCard.Text == "") return false;
            else if (txtAddress.Text == "") return false;
            else if (txtPhone.Text == "") return false;
            else if (txtCompanyName.Text == "") return false;
            else return true;
        }
        public void fnSave()
        {
            try
            {
                vTblCompany = cmdCompany.GetAll().Where(id => id.Com_ID == Convert.ToInt32(txtCompanyID.Text)).FirstOrDefault();
                if (vSourcePath != "" && fnValidation())
                {
                    FileStream vFileStr = new FileStream(vSourcePath, FileMode.Open, FileAccess.Read);
                    Byte[] vByteStr = new Byte[vFileStr.Length];
                    vFileStr.Read(vByteStr, 0, vByteStr.Length);
                    if (vTblCompany != null)
                    {
                        vTblCompany.Com_Name = txtCompanyName.Text;
                        vTblCompany.Com_Address = txtAddress.Text;
                        vTblCompany.Com_Commercial_Record = txtComRec.Text;
                        vTblCompany.Com_Tax_Card = txtTaxCard.Text;
                        vTblCompany.Com_Mobile = txtPhone.Text;
                        vTblCompany.Com_Note = txtCompanyNote.Text;
                        vTblCompany.Com_Title = txtCompanyNote.Text;
                        vTblCompany.Com_Image = vByteStr;
                        cmdCompany.Update_Data(vTblCompany);
                        vFileStr.Close();
                        vSourcePath = "";

                    }
                    else
                    {
                        vTblCompany = new TBL_Company();

                        vTblCompany.Com_ID = fnMax_ID();
                        vTblCompany.Com_Name = txtCompanyName.Text;
                        vTblCompany.Com_Address = txtAddress.Text;
                        vTblCompany.Com_Commercial_Record = txtComRec.Text;
                        vTblCompany.Com_Tax_Card = txtTaxCard.Text;
                        vTblCompany.Com_Mobile = txtPhone.Text;
                        vTblCompany.Com_Note = txtCompanyNote.Text;
                        vTblCompany.Com_Title = txtCompanyNote.Text;
                        vTblCompany.Com_Image = vByteStr;
                        cmdCompany.Insert_Data(vTblCompany);
                        vFileStr.Close();
                        vSourcePath = "";


                    }
                    fnClear_Data();
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تم حفظ البيانات", frmNotifications.enmType.vSuccess);
                }
                else if(vSourcePath == "" && fnValidation())
                {
                    if (vTblCompany != null)
                    {
                        vTblCompany.Com_Name = txtCompanyName.Text;
                        vTblCompany.Com_Address = txtAddress.Text;
                        vTblCompany.Com_Commercial_Record = txtComRec.Text;
                        vTblCompany.Com_Tax_Card = txtTaxCard.Text;
                        vTblCompany.Com_Mobile = txtPhone.Text;
                        vTblCompany.Com_Note = txtCompanyNote.Text;
                        vTblCompany.Com_Title = txtCompanyNote.Text;
                        cmdCompany.Update_Data(vTblCompany);
                        vSourcePath = "";
                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حفظ البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else
                    {
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("برجاء اختيار صورة", frmNotifications.enmType.vWarning);
                    }
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تأكد من إدخال البيانات المطلوبة", frmNotifications.enmType.vWarning);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Com_Name_Index"))
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم المؤسسة مسجل مسبقا", frmNotifications.enmType.vError);
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("خطأ في حفظ البيانات", frmNotifications.enmType.vError);
                }
            }
        }

        public void fnUpload_Image()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files (*.*) | *.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = new Bitmap(open.FileName);
                vSourcePath = open.FileName;
            }
        }

        public void fnDelete_Image()
        {
            picLogo.BackgroundImage = null;
            picLogo.Image = null;
            vSourcePath = "";
        }
        #endregion

        #region Events

        #endregion


        private void txtCompanyID_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (txtCompanyID.Text != "")
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(txtCompanyID.Text, "[^0-9]"))
                        {
                            vTblCompany = cmdCompany.GetAll().Where(id => id.Com_ID == Convert.ToInt32(txtCompanyID.Text)).FirstOrDefault();
                            if (vTblCompany != null)
                            {
                                txtCompanyID.Text = vTblCompany.Com_ID.ToString();
                                txtCompanyName.Text = vTblCompany.Com_Name;
                                txtCompanyNote.Text = vTblCompany.Com_Note;
                                txtAddress.Text = vTblCompany.Com_Address;
                                txtComRec.Text = vTblCompany.Com_Commercial_Record;
                                txtPhone.Text = vTblCompany.Com_Mobile;
                                txtTaxCard.Text = vTblCompany.Com_Tax_Card;

                                Byte[] vByteImage = new byte[0];
                                vByteImage = vTblCompany.Com_Image;
                                MemoryStream vMemoryStrem = new MemoryStream(vByteImage);
                                picLogo.BackgroundImageLayout = ImageLayout.Stretch;
                                //picLOGO.Image = Image.FromStream(vMemoryStrem);
                                picLogo.Image = Image.FromStream(vMemoryStrem);
                                picLogo.BackgroundImage = Image.FromStream(vMemoryStrem);
                            }
                            else
                            {
                                frmNotifications nfrm = new frmNotifications();
                                nfrm.fnShowAlert("لا يوجد بيانات", frmNotifications.enmType.vWarning);
                            }
                        }

                    }
                }
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في تحميل البيانات", frmNotifications.enmType.vError);
            }
        }

        private void txtCompanyID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCompanyID.Text, "[^0-9]"))
            {
                MessageBox.Show("برجاء ادخال ارقام فقط");
                txtCompanyID.Text = "";
            }
        }
    }
}
