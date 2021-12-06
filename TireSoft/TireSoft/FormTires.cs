using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TireSoft
{
    public partial class FormTires : Form
    {
       
        public FormTires()
        {
            InitializeComponent();
        }

        private List<Tires> ttiresList = new List<Tires>();
        Tires truck_tire = new TruckTires();

        private List<Tires> ctiresList = new List<Tires>();
        Tires car_tire = new CarTires();


        private void buttonTrcuk_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            ttiresList.Clear();
            var items = File.ReadAllLines("TruckTires.txt");
            for (int i = 0; i < items.Length; i++)
            {
                truck_tire = new TruckTires();
                string[] list = items[i].Split(' ');
                truck_tire.Brand = list[1];
                truck_tire.Size = list[4];
                truck_tire.Load_C = list[7];
                truck_tire.Price = list[10];
                ttiresList.Add(truck_tire);

            }
            var truck_tires = ttiresList.OrderBy(x => x.Brand);
            foreach (var truck_tire in truck_tires)
            {
                listBox1.Items.Add(truck_tire);
            };   

        }
       
        private void buttonCars_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ctiresList.Clear();
            var items = File.ReadAllLines("CarTires.txt");
            for (int i = 0; i < items.Length; i++)
            {
                car_tire = new CarTires();
                string[] list = items[i].Split(' ');
                car_tire.Brand = list[1];
                car_tire.Size = list[4];
                car_tire.Load_C = list[7];
                car_tire.Price = list[10];
                ctiresList.Add(car_tire);

            }
            var car_tires = ctiresList.OrderBy(x => x.Brand);
            foreach (var car_tire in car_tires)
            {
                listBox1.Items.Add(car_tire);
            };
            
        } 
    }
}
