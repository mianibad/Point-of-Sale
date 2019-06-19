using PointOfSale.POSBLL;
using PointOfSale.POSDTO;
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

namespace PointOfSale.UserControls.OrderManage
{
    public partial class AddOrderProducts : Form
    {
        ProductManagementBLL productBLL;
        ProductCategoryBLL pCategoryBLL;
        OrderProductBLL orderProductBLL;
        Int64 orderId;

        public AddOrderProducts(Int64 Id)
        {
            InitializeComponent();
            orderId = Id;
        }
        

        private void AddOrderProducts_Load(object sender, EventArgs e)
        {
            insert_PCategory_comboBox_Pop();
        }


        void ClearAllFields()
        {
            cmbCategory.Text = "";
            cmbProduct.Text = "";
            tbQuantity.Text = "";
            cmbSize.Text = "";
        }


        void insert_PCategory_comboBox_Pop()    // categories comboBox population method
        {
            pCategoryBLL = new ProductCategoryBLL();
            List<string> result = new List<string>();

            result = pCategoryBLL.productInsertComboPopu();

            for (int i = 0; i < result.Count; i++)
            {
                cmbCategory.Items.Add(result[i]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string catname = cmbCategory.Text;
            cmbProduct.Items.Clear();
            ProductDTO pDto = new ProductDTO(1,"","","","",1,catname);
            productBLL = new ProductManagementBLL();
            ArrayList arr = productBLL.searchProdOfCategory(pDto);
            foreach(object o in arr)
            {
                ProductDTO dtp = (ProductDTO)o;
                cmbProduct.Items.Add(dtp.PNAME);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pname = cmbProduct.Text;
            string pcategory = cmbCategory.Text;
            string pQuantity = tbQuantity.Text;
            string pSize = cmbSize.Text;

            ProductDTO dto = new ProductDTO(0,pname,"","","",1,pcategory);////// To
            productBLL = new ProductManagementBLL();///////////////////////////  Convert product name
            Int64 productID = productBLL.prodNameToID(dto);/////////////////////////////////////   to ID

            OrderProductDTO oDTO = new OrderProductDTO(orderId,productID,pQuantity,pSize);
            orderProductBLL = new OrderProductBLL();
            orderProductBLL.insert(oDTO);
            ClearAllFields();
        }
    }
}
