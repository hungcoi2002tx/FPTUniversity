using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace DEMO_CRUD
{
    public partial class frmCRUD : Form
    {
        ManageCategory manageCategory = new ManageCategory();
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void frmCRUD_Load(object sender, EventArgs e) => LoadCategory();

        private void LoadCategory()
        {
            var categories = manageCategory.GetCategories();
            manageCategory.GetCategories();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", categories, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", categories, "CategoryName");
            dgvData.DataSource = categories;


        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                CategoryID = int.Parse(txtCategoryID.Text),
                CategoryName = txtCategoryName.Text
            };
            manageCategory.InsertCategories(category);
            LoadCategory();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                CategoryID = int.Parse(txtCategoryID.Text),
                CategoryName = txtCategoryName.Text
            };
            manageCategory.UpdateCategories(category);
            LoadCategory();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var category = new Category
            {
                CategoryID = int.Parse(txtCategoryID.Text),
                CategoryName = txtCategoryName.Text
            };
            manageCategory.DeleteCategories(category);
            LoadCategory();
        }
    }
}