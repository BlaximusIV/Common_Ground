using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_Ground_Project.Controllers;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Views
{
    public partial class VehicalView : UserControl
    {
        private CommonController Controller;

        public VehicalView()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
            PopulateVehicleGrid();
        }

        private void PopulateVehicleGrid()
        {
            string errorMessage = String.Empty;
            List<Vehicle> vehicles = Controller.GetVehicleList(out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {
                vehicleBindingSource.DataSource = vehicles;
                vehicleGrid.Columns[0].Visible = false;
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void ResetGridView()
        {
            vehicleBindingSource.DataSource = null;
            PopulateVehicleGrid();
        }

        private void vehicleGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string errorMessage = String.Empty;
            if (e.RowIndex >= 0)
            {
                Vehicle vehicle = (Vehicle)vehicleGrid.Rows[e.RowIndex].DataBoundItem;

                if (vehicle.Name == null)
                    vehicle.Name = String.Empty;
                if (vehicle.Description == null)
                    vehicle.Description = String.Empty;
                if (vehicle.VIN == null)
                    vehicle.VIN = String.Empty;

                if (vehicle != null)
                {
                    if (String.IsNullOrEmpty(vehicle.Name) && String.IsNullOrEmpty(vehicle.Description) && String.IsNullOrEmpty(vehicle.VIN))
                    {
                        DialogResult answer = MessageBox.Show("This Vehicle is currently empty, would you like to delete it?", "Approve Delete", MessageBoxButtons.YesNoCancel);
                        if (answer == DialogResult.Yes)
                        {
                            Controller.DeleteVehicle(vehicle, out errorMessage);
                            ResetGridView();
                        }
                        else if (answer == DialogResult.No)
                            Controller.SaveVehicle(vehicle, out errorMessage);
                    }
                    else 
                        Controller.SaveVehicle(vehicle, out errorMessage);
                }

                if (!String.IsNullOrEmpty(errorMessage))
                    MessageBox.Show(errorMessage);
            }
        }
    }
}
