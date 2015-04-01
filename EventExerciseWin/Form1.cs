using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExerciseWin
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeVehicles_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 500; i++)
            {
                var index = i + 1;
                vehicles.Add(new Vehicle { Name = "Vehicle " + index });
            }

            for (int i = 10; i < 99; i++)
            {
                vehicles[i].OnHit += vehicleHit;
            }

            displayVehicles();

        }

        private void vehicleHit(object sender, EventArgs e)
        {
            var vehicle = (Vehicle) sender;
            lstReport.Items.Add(string.Format("vehicle {0} has sustained damage", vehicle.Name));
        }

        private void displayVehicles()
        {
            lstVehicles.Items.Clear();
            lstVehicles.Items.AddRange(vehicles.ToArray());
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var firstIndex = random.Next(500);
            var secondIndex = random.Next(500);

            var firstVehicle = vehicles[firstIndex];
            var secondVehicle = vehicles[secondIndex];

            firstVehicle.Hit(secondVehicle);

            lstHistory.Items.Add(string.Format("{0} hit {1}", firstVehicle.Name, secondVehicle.Name));

            displayVehicles();
        }
    }
}
