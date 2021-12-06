using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TireSoft
{
    public partial class FormCars : Form
    {

        private List<Car> carList = new List<Car>();

        Car car = new Car();

        public FormCars()
        {
            InitializeComponent();
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            listBoxCars.Items.Clear();
            carList.Clear();
            if (!File.Exists("Cars"))
                return;
            List<Car> items = new List<Car>();
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Cars", FileMode.Open))
            {
               items = (List<Car>)formatter.Deserialize(fs);
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Coupe != "car") continue;
                car = new Car();          
                car.Brand = items[i].Brand;
                car.Model = items[i].Model;
                car.Coupe = items[i].Coupe;
                car.TireS = items[i].TireS;                            
                carList.Add(car);
            
            }

            var cars = carList.OrderBy(x => x.Brand);
            foreach (var car in cars)
            {
                listBoxCars.Items.Add(car);
            }
        }

        private void buttonTruck_Click(object sender, EventArgs e)
        {
            listBoxCars.Items.Clear();
            carList.Clear();
            if (!File.Exists("Cars"))
                return;
            List<Car> items = new List<Car>();
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Cars", FileMode.Open))
            {
                items = (List<Car>)formatter.Deserialize(fs);
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Coupe != "truck") continue;
                car = new Car();
                car.Brand = items[i].Brand;
                car.Model = items[i].Model;
                car.Coupe = items[i].Coupe;
                car.TireS = items[i].TireS;
                carList.Add(car);

            }
            var cars = carList.OrderBy(x => x.Brand).ThenBy(x => x.Model);
            foreach (var car in cars)
            {
                listBoxCars.Items.Add(car);
            }
        }
    }
}
