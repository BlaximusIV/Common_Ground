using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.DataAccess;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Controllers
{
    public class CommonController
    {
        // private Repository references.
        private IndividualSql IndividualData;

        public CommonController()
        {
            // Initialize repositories
            IndividualData = new IndividualSql();

            
        }


        #region Activity 
        public Activity GetActivity(Activity activity)
        {
            return activity;
        }
        public List<Activity> GetActivityList(Individual individual)
        {
            return new List<Activity>();
        }

        public void SaveActivity(Activity activity)
        {

        }
        public void DeleteActivity(Activity activity)
        {

        }
        #endregion

        #region ActivityNote
        public ActivityNote GetActivityNote(ActivityNote note)
        {
            return note;
        }
        public List<ActivityNote> GetActivityNoteList(Activity activity)
        {
            return new List<ActivityNote>();
        }

        public void InsertActivityNote(ActivityNote note)
        {

        }
        #endregion

        #region EmergencyContact
        public EmergencyContact GetEmergencyContact(EmergencyContact contact)
        {
            return contact;
        }
        public List<EmergencyContact> GetEmergencyContactList(Individual individual)
        {
            return new List<EmergencyContact>();
        }

        public void InsertEmergencyContact(EmergencyContact contact)
        {

        }
        public void UpdateEmergencyContact(EmergencyContact contact)
        {

        }
        public void DeleteEmergencyContact(EmergencyContact contact)
        {

        }
        #endregion

        #region Individual
        public Individual GetIndividual(Individual individual)
        {
            return IndividualData.GetIndividual(individual);
        }
        public List<Individual> GetIndividualList(IndividualType type)
        {
            return IndividualData.GetIndividualList(type);
        }
        public List<Individual> GetIndividualList(Activity activity)
        {
            return IndividualData.GetIndividualList(activity);
        }

        public void SaveIndividual(Individual individual)
        {
            IndividualData.SaveIndividual(individual);
        }
        public void DeleteIndividual(Individual individual)
        {
            IndividualData.DeleteIndividual(individual);
        }
        #endregion

        #region IndividualNote
        public IndividualNote GetIndividualNote(IndividualNote note)
        {
            return note;
        }
        public List<IndividualNote> GetIndividualNoteList(Individual individual)
        {
            return new List<IndividualNote>();
        }

        public void InsertIndividualNote(IndividualNote note)
        {
            
        }
        #endregion

        #region IndividualType
        public IndividualType GetIndividualType(IndividualType type)
        {
            return type;
        }
        public List<IndividualType> GetIndividualTypeList()
        {
            return new List<IndividualType>();
        }
        #endregion

        #region Vehicle
        public Vehicle GetVehicle(Vehicle vehicle)
        {
            return vehicle;
        }
        public List<Vehicle> GetVehicleList(Activity activity)
        {
            return new List<Vehicle>();
        }

        public void InsertVehicle(Vehicle vehicle)
        {

        }
        public void UpdateVehicle(Vehicle vehicle)
        {

        }
        #endregion

    }
}
