using appFelxMax.appForms.OtherForms;
using FlexMax_db;
using FlexMax_db.Commander;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFelxMax.appForms.MenuForms.Program_initialization
{
    public partial class frmProductCard : Form
    {


        #region Variable
        clsCommander<TBL_Product> cmdProduct= new clsCommander<TBL_Product>();
        TBL_Product vTblProduct= new TBL_Product();

        clsCommander<TBL_Product_Details> cmdProduct_Details = new clsCommander<TBL_Product_Details>();
        TBL_Product_Details vTblProduct_Details = new TBL_Product_Details();
        
        clsCommander<TBL_Product_Group> cmdProduct_Group = new clsCommander<TBL_Product_Group>();
        TBL_Product_Group vTblProduct_Group = new TBL_Product_Group();
        
        clsCommander<TBL_Product_Sections> cmdProduct_Sections = new clsCommander<TBL_Product_Sections>();
        TBL_Product_Sections vTblProduct_Sections = new TBL_Product_Sections();
        
        clsCommander<TBL_Product_Units> cmdProduct_Units = new clsCommander<TBL_Product_Units>();
        TBL_Product_Units vTblProduct_Units = new TBL_Product_Units();
        
        clsCommander<TBL_Product_Image> cmdProduct_Image = new clsCommander<TBL_Product_Image>();
        TBL_Product_Image vTblProduct_Image = new TBL_Product_Image();
        
        clsCommander<TBL_Product_Bonus> cmdProduct_Bonus = new clsCommander<TBL_Product_Bonus>();
        TBL_Product_Bonus vTblProduct_Bonus = new TBL_Product_Bonus();
        
        clsCommander<TBL_Units> cmdUnits= new clsCommander<TBL_Units>();
        TBL_Units vTblUnits = new TBL_Units();
        
        clsCommander<TBL_Store_Branch> cmdStore_Branch = new clsCommander<TBL_Store_Branch>();
        TBL_Store_Branch vTblStore_Branch = new TBL_Store_Branch();
        
        clsCommander<TBL_Store> cmdStore = new clsCommander<TBL_Store>();
        TBL_Store vTblStore = new TBL_Store();
        
        clsCommander<TBL_Branch> cmdBranch = new clsCommander<TBL_Branch>();
        TBL_Branch vTblBranch = new TBL_Branch();
        
        clsCommander<TBL_Operations> cmdOperations= new clsCommander<TBL_Operations>();
        TBL_Operations vTblOperations = new TBL_Operations();
        
        clsCommander<TBL_Bond_Entry> cmdBond_Entry = new clsCommander<TBL_Bond_Entry>();
        TBL_Bond_Entry vTblBond_Entry = new TBL_Bond_Entry();
        
        clsCommander<TBL_Bond_E_Item> cmdBond_E_Item = new clsCommander<TBL_Bond_E_Item>();
        TBL_Bond_E_Item vTblBond_E_Item = new TBL_Bond_E_Item();
        
        clsCommander<TBL_Bond_E_Trans> cmdBond_E_Trans = new clsCommander<TBL_Bond_E_Trans>();
        TBL_Bond_E_Trans vTblBond_E_Trans = new TBL_Bond_E_Trans();
        
        clsCommander<TBL_Barcode> cmdBarcode = new clsCommander<TBL_Barcode>();
        TBL_Barcode vTblBarcode = new TBL_Barcode();


        #endregion


        #region Constructor
        public frmProductCard()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad
        private void frmProductCard_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region Functions
        public int fnMax_ID()
        {
            try
            {
                var x = cmdProduct.GetAll().ToList();
                if(x.Count != 0)
                {
                    var vLRow = cmdProduct.GetAll().FirstOrDefault(id => id.Pro_ID == cmdProduct.GetAll().Max(mid => mid.Pro_ID));
                    int vLID = vLRow.Pro_ID + 1;
                    return vLID;
                }
                else
                {
                    return 1;
                }
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public void fnGet_Group()
        {
            try
            {
                cmbItemGroup.DataSource = (from vGroup in cmdProduct_Group.GetAll()
                                           select new
                                           {
                                               ID = vGroup.Pro_Group_ID,
                                               Name = vGroup.Pro_Group_Name
                                           }).ToList();
                cmbItemGroup.DisplayMember = "Name";
                cmbItemGroup.ValueMember = "ID";
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في عرض بيانات مجموعات الأصناف", frmNotifications.enmType.vError);
            }
        }

        public void fnGet_Sections()
        {
            try
            {
                if(cmbItemGroup.Text != "")
                {
                    cmbItemSection.DataSource = (from vSection in cmdProduct_Sections.GetAll().Where(id=>id.Pro_Group_ID == cmbItemGroup.FindString(cmbItemGroup.Text))
                                                 select new
                                                 {
                                                     ID = vSection.Pro_Section_ID,
                                                     Name = vSection.Pro_Section_Name
                                                 }).ToList();
                    cmbItemGroup.DisplayMember = "Name";
                    cmbItemGroup.ValueMember = "ID";
                }
                
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في عرض بيانات مجموعات الأصناف", frmNotifications.enmType.vError);
            }
        }

        public void fnGet_Units()
        {
            var q = (from vUnit in cmdUnits.GetAll()
                     select new
                     {
                         ID = vUnit.Unit_ID,
                         Name = vUnit.Unit_Name
                     }).ToList();
            cmbBigUnit.DataSource = q;
            cmbBigUnit.DisplayMember = "Name";
            cmbBigUnit.ValueMember = "ID";

            cmbSmallUnit.DataSource = q;
            cmbSmallUnit.DisplayMember = "Name";
            cmbSmallUnit.ValueMember = "ID";
        }


        #endregion

        #region Events

        // Close Button
        private void btnESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
