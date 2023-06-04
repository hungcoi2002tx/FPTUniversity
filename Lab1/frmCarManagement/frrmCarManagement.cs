using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Respository;
using AutomobileWinApp;

namespace frmCarManagement
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();

        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dvgCarList.CellDoubleClick += dvgCarList_CellDoubleClick;
        }

        private void dvgCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Update car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = carRepository
            };
        }
        private Car GetCarObject()
        {
            return null;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmCarManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}