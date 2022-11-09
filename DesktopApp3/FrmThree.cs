//**********************************************************************************
//Programmer: Toton Liantoro
//CIT Number: CIT241675
//Software: Microsoft Visual Studio 2022 Community Edition. 
//Platform: Microsoft Windows 11 Home (64-Bit)
//Purpose: Comply Assessment 3 (Task No.3), Subject: Apply advanced object-oriented language skills 
//**********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Assessment3_Toton.FrmThree;
using static Assessment3_Toton.FrmTwo;

namespace Assessment3_Toton
{
   
    public partial class FrmThree : Form
    {
        public FrmThree()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }

        public class Car : IComparable<Car>
        {
            public string CarMaker { get; set; }
            public string CarPower { get; set; }
            public int CompareTo(Car other)
            //'other' refers to the other (adjacent) element in the myList
            {
                if (this.CarMaker == other.CarMaker)
                    return this.CarPower.CompareTo(other.CarPower);
                //Does an alphabetic sort on Name if Salary is equal
                return this.CarMaker.CompareTo(other.CarMaker);
                //Does a default sort in descending order
                //Use the code below to sort in ascending order
                //return this.Salary.CompareTo(other.Salary);
            }
            public override string ToString()
            {
                return this.CarMaker.ToString() + ":" + this.CarPower;
            }


        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car()
            {
                CarMaker = "Kia",
                CarPower = "Diesel"
            });
            cars.Add(new Car()
            {
                CarMaker = "Holden ",
                CarPower = "Diesel"
            });
            cars.Add(new Car()
            {
                CarMaker = "Subaru",
                CarPower = "Petrol"
            });
            
            cars.Add(new Car()
            {
                CarMaker = "Tesla",
                CarPower = "Electric"
            });
            cars.Add(new Car()
            {
                CarMaker = "Honda",
                CarPower = "Petrol"
            });
           
            cars.Add(new Car()
            {
                CarMaker = "Subaru",
                CarPower = "Diesel"
            });
            cars.Add(new Car()
            {
                CarMaker = "Honda ",
                CarPower = "Electric"
            });
            cars.Add(new Car()
            {
                CarMaker = "Kia",
                CarPower = "Petrol"
            });
           

            cars.Add(new Car()
            {
                CarMaker = "Holden ",
                CarPower = "Petrol"
            });

            cars.Add(new Car()
            {
                CarMaker = "Honda",
                CarPower = "Diesel"
            });
            foreach (var car in cars)
                lstCurrentData.Items.Add(car);

            cars.Sort();
            foreach (var car in cars)
                lstSortedData.Items.Add(car);

        }

        private void btnSortByMaker_Click(object sender, EventArgs e)
        {
            //foreach (var car in lstCurrentData.Items)    
            //lstSortedData.Items.Add(car);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
