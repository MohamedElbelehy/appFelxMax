using appFelxMax.appForms.MainForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace appFelxMax.appClass.clsDesign
{
    public  class clsUIDesign
    {
        // Virables
        private static int vMinWidth = 21;
        private static int vMaxWidth = 300;

        // Tape Page
        public static void OpenFormInTap(Form frmForm, Panel pnlPanel, Panel panelContainer)
        {
            // Instant
            var vINS = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == frmForm.Name);
            var vFRM = Activator.CreateInstance(frmForm.GetType()) as Form;
            TapPage vTapPage;
            Panel vPanel;
            if (pnlPanel.Controls.OfType<TabPage>().Where(x => x.Name == "vTapPage" + vFRM.Name).Count() <= 0)
            {
                vPanel = new Panel();
                vTapPage = new appForms.MainForms.TapPage();


                vTapPage.Name = "vTapPage" + vFRM.Name;
                vTapPage.Text = vFRM.Text;
                vTapPage.Visible = true;
                vTapPage.Dock = DockStyle.Right;
                vTapPage.panelCOntainer = panelContainer;
                vTapPage.panelDir = pnlPanel;
                vTapPage.formWorping = vFRM;

                vFRM.TopLevel = false;
                vFRM.Dock = DockStyle.Fill;
                vFRM.Parent = vPanel;
                vPanel.Name = "vTapPage" + vFRM.Name;
                vPanel.Dock = DockStyle.Fill;
                vPanel.Controls.Add(vFRM);
                pnlPanel.Controls.Add(vTapPage);
                vPanel.BackColor = Color.Transparent;
                panelContainer.Controls.Add(vPanel);
                vFRM.FormClosing += (s, ee) => {
                    pnlPanel.Controls.Remove(vTapPage);
                };
                vFRM.Show();
                vPanel.BringToFront();
                vTapPage.lbl_Title_Click(null, null);
            }
            else
            {
                vTapPage = pnlPanel.Controls.OfType<TapPage>().Single(x => x.Name == "vTapPage" + vFRM.Name);
                vPanel = panelContainer.Controls.OfType<Panel>().Single(x => x.Name == "vTapPage" + vFRM.Name);
                vPanel.BringToFront();
                vTapPage.lbl_Title_Click(null, null);

            }
        }

        // Datagridview
        // DGV Colors
        private static Color vDGVHeaderBackColor = ColorTranslator.FromHtml("#2980b9");
        private static Color vDGVCellSelectionBackColor = ColorTranslator.FromHtml("#3498db");

        // DGV - Row Selection - Config
        public static void fnRowSelectionConfig(MouseEventArgs e, DataGridView pDGV, ContextMenuStrip pCMS)
        {
            // Check Mouse Button Is Right Click
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    // RowIndex - GET
                    int vRowIndex = pDGV.HitTest(e.X, e.Y).RowIndex;
                    // DGV - Clear Selection
                    pDGV.ClearSelection();
                    // Select Row
                    pDGV.Rows[vRowIndex].Selected = true;

                }
                catch (Exception ex)
                {
                    // Clear
                    pDGV.ClearSelection();
                    // CMS - Hide
                    pCMS.Hide();
                }
            }
        }

        // DGV - Config
        public static void fnDGVConfig(DataGridView pDGV)
        {
            // DGV - Style
            pDGV.BackgroundColor = Color.White;
            pDGV.EnableHeadersVisualStyles = false;
            // DGV - Cell
            pDGV.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            pDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            pDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // DGV - Row
            pDGV.RowTemplate.Height = 25;

            // DGV - Column Header
            pDGV.ColumnHeadersDefaultCellStyle.BackColor = vDGVHeaderBackColor;
            pDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            pDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            pDGV.ColumnHeadersHeight = 40;
            pDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // DGV - Layout
            pDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pDGV.RowHeadersVisible = false;
            pDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pDGV.AllowUserToResizeRows = false;
            pDGV.AllowUserToAddRows = false;
            pDGV.AllowUserToDeleteRows = false;
            pDGV.BorderStyle = BorderStyle.None;
        }

        // DGV - Search
        public static void fnDGVSearch(string pSearchText, DataGridView pDGV, List<string> plstSearchClm)
        {
            // BS
            BindingSource vBS = new BindingSource();
            // BS
            vBS.DataSource = pDGV.DataSource;

            // Search Filter
            //string vSearchFilter = string.Format("BookName LIKE '%{0}%' OR BookAuther LIKE '%{0}%' ", pSearchText);
            string vSearchFilter = string.Empty;

            // Search Columns
            foreach (string vClmName in plstSearchClm)
            {
                vSearchFilter += string.Format(vClmName + " LIKE '%{0}%' OR", pSearchText);
            }

            vBS.Filter = vSearchFilter;

            // DGV - NewSource
            pDGV.DataSource = vBS;

        }

        // PnlData - Config
        public static void fnPnlDataConfig(Panel pPnlData, bool pIsToggle, bool pIsOpen)
        {
            // Toogle
            pPnlData.Width = (pIsToggle) ? ((pPnlData.Width == vMaxWidth) ? vMinWidth : vMaxWidth) : ((pIsOpen) ? vMaxWidth : vMinWidth);
        }
    }
}
