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
        public Activity GetActivity(Activity activity)
        {
            return ActivityData.GetActivity(activity);
        }
        public List<Activity> GetActivityList(Individual individual)
        {
            return ActivityData.GetActivityList(individual);
        }

        public void SaveActivity(Activity activity)
        {
            ActivityData.SaveActivity(activity);
        }
        public void DeleteActivity(Activity activity)
        {
            ActivityData.DeleteActivity(activity);
        }
        #endregion

        #region ActivityNote - Done.
        public ActivityNote GetActivityNote(ActivityNote note)
        {
            return ActivityNoteData.GetActivityNote(note);
        }
        public List<ActivityNote> GetActivityNoteList(Activity activity)
        {
            return ActivityNoteData.GetActivityNoteList(activity);
        }

        public void InsertActivityNote(ActivityNote note)
        {
            ActivityNoteData.SaveActivityNote(note);
        }
        #endregion

        #region EmergencyContact - Done.
        public EmergencyContact GetEmergencyContact(EmergencyContact contact)
        {
            return EmergencyContactData.GetEmergencyContact(contact);
        }
        public List<EmergencyContact> GetEmergencyContactList(Individual individual)
        {
            return EmergencyContactData.GetEmergencyContactList(individual);
        }

        public void SaveEmergencyContact(EmergencyContact contact)
        {
            EmergencyContactData.SaveEmergencyContact(contact);
        }
        public void DeleteEmergencyContact(EmergencyContact contact)
        {
            EmergencyContactData.DeleteEmergencyContact(contact);
        }
        #endregion

        #region Individual - Done.
        public Individual GetIndividual(Individual individual)
        {
            return IndividualData.GetIndividual(individual);
        }
        public List<Individual> GetIndividualList()
        {
            return IndividualData.GetIndividualList();
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

        #region IndividualNote - Done.
        public IndividualNote GetIndividualNote(IndividualNote note)
        {
            return IndividualNoteData.GetIndividualNote(note);
        }
        public List<IndividualNote> GetIndividualNoteList(Individual individual)
        {
            return IndividualNoteData.GetIndividualNoteList(individual);
        }

        public void SaveIndividualNote(IndividualNote note)
        {
            IndividualNoteData.SaveIndividualNote(note);
        }
        #endregion

        #region IndividualType - Done.
        public IndividualType GetIndividualType(IndividualType type)
        {
            return IndividualTypeData.GetIndividualType(type);
        }
        public List<IndividualType> GetIndividualTypeList()
        {
            return IndividualTypeData.GetIndividualTypeList();
        }
        #endregion

        #region Vehicle
        public Vehicle GetVehicle(Vehicle vehicle)
        {
            return VehicleData.GetVehicle(vehicle);
        }
        public List<Vehicle> GetVehicleList(Activity activity)
        {
            return VehicleData.GetVehicleList(activity);
        }

        public void SaveVehicle(Vehicle vehicle)
        {
            VehicleData.SaveVehicle(vehicle);
        }
        #endregion

    }
}
