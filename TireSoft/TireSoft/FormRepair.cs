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
    public partial class FormRepair : Form
    {
        public FormRepair()
        {
            InitializeComponent();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Car> items = new List<Car>();
            listBoxCarTires.Items.Clear();
            string car = textBoxCarSearch.Text;
            var car_info = car.Split(' ');
            if (car_info[2] == "car")
            {
                var formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("Cars", FileMode.Open))
                {
                    items = (List<Car>)formatter.Deserialize(fs);
                }
                foreach (var item in items)
                {
                    if(item.Brand == car_info[0] && item.Model == car_info[1])
                    {
                        using (FileStream ft = File.Open("CarTires.txt", FileMode.Open))
                        {
                            using (var k = new StreamReader(ft))
                            {
                                string tire_line;
                                while ((tire_line = k.ReadLine()) != null)
                                {
                                    string[] tires = tire_line.Split(' ');
                                    if (tires[4] == item.TireS)
                                    {
                                        string line = "BRAND " + tires[1] + " / SIZE " + tires[4] + " / CAPACITY " + tires[7] + " / PRICE " + tires[10] + ' ' + ';';
                                        listBoxCarTires.Items.Add(string.Join(Environment.NewLine, line));

                                    }
                                }
                            }
                        }
                    }        
                }
            }
            else if (car_info[2] == "truck")
            {
                var formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("Cars", FileMode.Open))
                {
                    items = (List<Car>)formatter.Deserialize(fs);
                }
                foreach (var item in items)
                {
                    if (item.Brand == car_info[0] && item.Model == car_info[1])
                    {
                        using (FileStream ft = File.Open("TruckTires.txt", FileMode.Open))
                        {
                            using (var k = new StreamReader(ft))
                            {
                                string tire_line;
                                while ((tire_line = k.ReadLine()) != null)
                                {
                                    string[] tires = tire_line.Split(' ');
                                    if (tires[4] == item.TireS)
                                    {
                                        string line = "BRAND " + tires[1] + " / SIZE " + tires[4] + " / CAPACITY " + tires[7] + " / PRICE " + tires[10] + ' ' + ';';
                                        listBoxCarTires.Items.Add(string.Join(Environment.NewLine, line));

                                    }
                                }
                            }
                        }
                    }               
                }
            }
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            string line = listBoxCarTires.SelectedItem.ToString();
            string[] list_line = line.Split(' ');
            int price = Convert.ToInt32(list_line[10]) * Convert.ToInt32(textBox1.Text);
            textBoxPrice.Text = Convert.ToString(price);
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            return bm;
        }

        PictureBox org;

        private void listBoxCarTires_DoubleClick(object sender, EventArgs e)
        {
            string tire = listBoxCarTires.SelectedItem.ToString();
            string[] tire_info = tire.Split(' ');
            string imagename = @"C:\Users\kocaa\source\repos\TireSoft\TiresPictures\" + tire_info[1] + tire_info[4] + tire_info[7] + ".jpg";
            pictureBoxTire.Image = Image.FromFile(imagename);
            org.Image = pictureBoxTire.Image;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                pictureBoxTire.Image = null;
                pictureBoxTire.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void FormRepair_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBoxTire.Image;
        }
    }
}
