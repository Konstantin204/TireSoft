using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TireSoft 
{
    public partial class FormAddInfo : Form 
    {

        public List<Car> listCars = new List<Car>();
        public FormAddInfo()
        {
            InitializeComponent();
            // this.Car = new Car();
            // this.CarTires = new CarTires();
            // this.TruckTires = new TruckTires();
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Cars", FileMode.Open))
            {
                listCars = (List<Car>)formatter.Deserialize(fs);
            }
        }
       // public Car Car
       // {
       //     get;
       //     set;
       // }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            var car = new Car();
            car.Brand = textBox_Car_Brand.Text;
            car.Model = textBox_Car_Model.Text;
            car.Coupe = textBox_Car_Coupe.Text;
            car.TireS = textBox_Car_tSize.Text;
            listCars.Add(car);

            //car.Input_Data(car.Brand, car.Model, car.Coupe, car.TireS);
           

            textBox_Car_Brand.Clear();
            textBox_Car_Coupe.Clear();
            textBox_Car_Model.Clear();
            textBox_Car_tSize.Clear();

        }

    //    public CarTires CarTires
    //    {
    //        get;
    //        set;
    //    }
    //
    //    public TruckTires TruckTires
    //    {
    //        get;
    //        set;
    //    }

        private void buttonTire_Click(object sender, EventArgs e)
        {
            Tires car_tire = new CarTires();
            car_tire.Brand = textBox_Tire_Brand.Text;
            car_tire.Size = textBox_Tire_Size.Text;
            car_tire.Load_C = textBox_Tire_Capacity.Text;
            car_tire.Price = textBox_Tire_Price.Text;
            car_tire.Input_Data(car_tire.Brand, car_tire.Size, car_tire.Load_C, car_tire.Price);
            


            Tires truck_tire = new TruckTires();    
            truck_tire.Brand = textBox_Tire_Brand.Text;
            truck_tire.Size = textBox_Tire_Size.Text;
            truck_tire.Load_C = textBox_Tire_Capacity.Text;
            truck_tire.Price = textBox_Tire_Price.Text;
            truck_tire.Input_Data(truck_tire.Brand, truck_tire.Size, truck_tire.Load_C, truck_tire.Price);


            textBox_Tire_Brand.Clear();
            textBox_Tire_Capacity.Clear();
            textBox_Tire_Price.Clear();
            textBox_Tire_Size.Clear();
        }

        private void FormAddInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
           var formatter = new BinaryFormatter();
           using (FileStream fs = new FileStream("Cars", FileMode.OpenOrCreate))
           {
               formatter.Serialize(fs, listCars);
           }
        }
    }
}
