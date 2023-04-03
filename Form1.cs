using CarModelLibrary;
using CarLibrary;
using SvgNet;
namespace CarDbDesign
{
    public partial class CarDb : Form
    {
        List<CarModel> Cars = new List<CarModel>();
        public CarDb()
        {
            InitializeComponent();
            LoadCarList();
            Dropdown.Text = "New";
        }

        private void LoadCarList()
        {
            Cars = SqliteDataAccess.AddCar();

            AddCarToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        private void AddCarToList()
        {
            CarDetailsBox.DataSource = null;
            CarDetailsBox.DataSource = Cars;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            CarModel c = new CarModel();
            c.CarBrand = CarBrandTextBox.Text;
            c.CarMark = CarMarkTextBox.Text;
            c.Color = CarColorTextBox.Text;
            c.VinCode = VinCodeTextBox.Text;
            c.ManufactureDate = ManufactureTextBox.Text;
            c.ImageURl = ImageUrlTextBox.Text;
            c.CarState = Dropdown.Text;
            c.DrivenDistance = int.Parse(DrivenDistanceTextBox.Text);

            if(MechanichButton.Checked == true)
            {
                c.Transmision = "Mechanic";
                MechanichButton.Checked = false;

            }
            else if(AutomaticButton.Checked == true)
            {
                c.Transmision = "Automatic";
                AutomaticButton.Checked = false;
            }
            else if(AutomaticButton.Checked && MechanichButton.Checked == true)
            {
                c.Transmision = "Both";
                AutomaticButton.Checked = false;
                MechanichButton.Checked = false;
            }

            SqliteDataAccess.SaveCar(c);
            LoadCarList();

            CarBrandTextBox.Text = "";
            CarMarkTextBox.Text = "";
            CarColorTextBox.Text = "";
            VinCodeTextBox.Text = "";
            ManufactureTextBox.Text = "";
            ImageUrlTextBox.Text = "";
            Dropdown.Text = "";


        }


        private void CarDetailsBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteDBButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteAllCars();
            LoadCarList();
        }

        private void SvgPictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}