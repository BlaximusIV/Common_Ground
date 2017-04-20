using System.Collections.Generic;
using Common_Ground_Project.DataAccess;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Controllers
{
    public class CommonController
    {
        // private Repository references.
        private ActivitySql ActivityData;
        private ActivityNoteSql ActivityNoteData;
        private EmergencyContactSql EmergencyContactData;
        private IndividualSql IndividualData;
        private IndividualNoteSql IndividualNoteData;
        private IndividualTypeSql IndividualTypeData;
        private VehicleSql VehicleData;

        public CommonController()
        {
            // Initialize repositories
            ActivityData = new ActivitySql();
            ActivityNoteData = new ActivityNoteSql();
            EmergencyContactData = new EmergencyContactSql();
            IndividualData = new IndividualSql();
            IndividualNoteData = new IndividualNoteSql();
            IndividualTypeData = new IndividualTypeSql();
            VehicleData = new VehicleSql();
        }


        #region Activity - Done.
        public Activity GetActivity(Activity activity, out string errorMessage)
        {
            return ActivityData.GetActivity(activity, out errorMessage);
        }
        public List<Activity> GetActivityList(Individual individual, out string errorMessage)
        {
            return ActivityData.GetActivityList(individual, out errorMessage);
        }

        public void SaveActivity(Activity activity, out string errorMessage)
        {
            ActivityData.SaveActivity(activity, out errorMessage);
        }
        public void DeleteActivity(Activity activity, out string errorMessage)
        {
            ActivityData.DeleteActivity(activity, out errorMessage);
        }
        #endregion

        #region ActivityNote - Done.
        public ActivityNote GetActivityNote(ActivityNote note, out string errorMessage)
        {
            return ActivityNoteData.GetActivityNote(note, out errorMessage);
        }
        public List<ActivityNote> GetActivityNoteList(Activity activity, out string errorMessage)
        {
            return ActivityNoteData.GetActivityNoteList(activity, out errorMessage);
        }

        public void InsertActivityNote(ActivityNote note, out string errorMessage)
        {
            ActivityNoteData.SaveActivityNote(note, out errorMessage);
        }
        #endregion

        #region EmergencyContact - Done.
        public EmergencyContact GetEmergencyContact(EmergencyContact contact, out string errorMessage)
        {
            return EmergencyContactData.GetEmergencyContact(contact, out errorMessage);
        }
        public List<EmergencyContact> GetEmergencyContactList(Individual individual, out string errorMessage)
        {
            return EmergencyContactData.GetEmergencyContactList(individual, out errorMessage);
        }

        public void SaveEmergencyContact(EmergencyContact contact, out string errorMessage)
        {
            EmergencyContactData.SaveEmergencyContact(contact, out errorMessage);
        }
        public void DeleteEmergencyContact(EmergencyContact contact, out string errorMessage)
        {
            EmergencyContactData.DeleteEmergencyContact(contact, out errorMessage);
        }
        #endregion

        #region Individual - Done.
        public Individual GetIndividual(Individual individual, out string errorMessage)
        {
            return IndividualData.GetIndividual(individual, out errorMessage);
        }
        public List<Individual> GetIndividualList(out string errorMessage)
        {
            return IndividualData.GetIndividualList(out errorMessage);
        }
        public List<Individual> GetIndividualList(IndividualType type, out string errorMessage)
        {
            return IndividualData.GetIndividualList(type, out errorMessage);
        }
        public List<Individual> GetIndividualList(Activity activity, out string errorMessage)
        {
            return IndividualData.GetIndividualList(activity, out errorMessage);
        }

        public void SaveIndividual(Individual individual, out string errorMessage)
        {
            IndividualData.SaveIndividual(individual, out errorMessage);
        }
        public void DeleteIndividual(Individual individual, out string errorMessage)
        {
            IndividualData.DeleteIndividual(individual, out errorMessage);
        }
        #endregion

        #region IndividualNote - Done.
        public IndividualNote GetIndividualNote(IndividualNote note, out string errorMessage)
        {
            return IndividualNoteData.GetIndividualNote(note, out errorMessage);
        }
        public List<IndividualNote> GetIndividualNoteList(Individual individual, out string errorMessage)
        {
            return IndividualNoteData.GetIndividualNoteList(individual, out errorMessage);
        }

        public void SaveIndividualNote(IndividualNote note, out string errorMessage)
        {
            IndividualNoteData.SaveIndividualNote(note, out errorMessage);
        }
        #endregion

        #region IndividualType - Done.
        public IndividualType GetIndividualType(IndividualType type, out string errorMessage)
        {
            return IndividualTypeData.GetIndividualType(type, out errorMessage);
        }
        public List<IndividualType> GetIndividualTypeList(out string errorMessage)
        {
            return IndividualTypeData.GetIndividualTypeList(out errorMessage);
        }
        #endregion

        #region Vehicle - Done.
        public Vehicle GetVehicle(Vehicle vehicle, out string errorMessage)
        {
            return VehicleData.GetVehicle(vehicle, out errorMessage);
        }
        public List<Vehicle> GetVehicleList(out string errorMessage)
        {
            return VehicleData.GetVehicleList(out errorMessage);
        }
        public List<Vehicle> GetVehicleList(Activity activity, out string errorMessage)
        {
            return VehicleData.GetVehicleList(activity, out errorMessage);
        }

        public void SaveVehicle(Vehicle vehicle, out string errorMessage)
        {
            VehicleData.SaveVehicle(vehicle, out errorMessage);
        }

        public void DeleteVehicle(Vehicle vehicle, out string errorMessage)
        {
            VehicleData.DeleteVehicle(vehicle, out errorMessage);
        }
        #endregion

    }
}
