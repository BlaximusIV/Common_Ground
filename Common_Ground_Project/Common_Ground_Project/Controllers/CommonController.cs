using System;
using System.Collections.Generic;
using System.Data;
using Common_Ground_Project.DataAccess;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Controllers
{
    public class CommonController
    {
        public Permission Permission { get; set; }

        // private Repository references.
        private ActivitySql ActivityData;
        private ActivityNoteSql ActivityNoteData;
        private ActivityTypeSql ActivityTypeData;
        private EmergencyContactSql EmergencyContactData;
        private IndividualSql IndividualData;
        private IndividualNoteSql IndividualNoteData;
        private IndividualTypeSql IndividualTypeData;
        private PermissionSql PermissionData;
        private ReportSql ReportData;
        private StaffSql StaffData;
        private VehicleSql VehicleData;

        public CommonController()
        {
            Permission = new Permission();

            // Initialize repositories
            ActivityData = new ActivitySql();
            ActivityNoteData = new ActivityNoteSql();
            ActivityTypeData = new ActivityTypeSql();
            EmergencyContactData = new EmergencyContactSql();
            IndividualData = new IndividualSql();
            IndividualNoteData = new IndividualNoteSql();
            IndividualTypeData = new IndividualTypeSql();
            PermissionData = new PermissionSql();
            ReportData = new ReportSql();
            StaffData = new StaffSql();
            VehicleData = new VehicleSql();
        }


        #region Authorization 
        public bool IsAuthenticated(string username, string password)
        {
            string errorMessage = String.Empty;
            Permission.UserName = username;
            if (username.ToLower() == "admin")
            {
                Permission.PermissionID = 5;
                Permission.Name = "Admin";
                Permission.IsAllowedEntry = true;

                if (password == LoginCredentials.Password)
                    return true;
                else
                    return false;
            }
            else
            {
                int permissionID = StaffData.AuthenticateStaff(username, password, out errorMessage);
                Permission = new Permission(permissionID);

                if (permissionID > 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Activity - Done.
        public Activity GetActivity(Activity activity, out string errorMessage)
        {
            return ActivityData.GetActivity(activity, out errorMessage);
        }
        public List<Activity> GetActivityList(DateTime date, out string errorMessage)
        {
            return ActivityData.GetActivityList(date, out errorMessage);
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

        #region ActivityType - Done.
        public ActivityType GetActivityType(ActivityType type, out string errorMessage)
        {
            return ActivityTypeData.GetActivityType(type, out errorMessage);
        }
        public List<ActivityType> GetActivityTypeList(out string errorMessage)
        {
            return ActivityTypeData.GetActivityTypeList(out errorMessage);
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

        public void ResetIndividualWaiver(out string errorMessage)
        {
            IndividualData.ResetIndividualWaiver(out errorMessage);
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

        #region Permission - Done.
        public Permission GetPermission(Permission permission, out string errorMessage)
        {
            return PermissionData.GetPermission(permission, out errorMessage);
        }
        public List<Permission> GetPermissionList(out string errorMessage)
        {
            return PermissionData.GetPermissionList(out errorMessage);
        }
        #endregion

        #region Reports
        public DataTable UserDayReport(DateTime startTime, DateTime endTime, out string errorMessage)
        {
            return ReportData.UserDayReport(startTime, endTime, out errorMessage);
        }
        public DataTable FrequentCallerReport(out string errorMessage)
        {
            return ReportData.FrequentCallerReport(out errorMessage);
        }

        #endregion 

        #region Staff
        public Staff GetStaff(Staff staff, out string errorMessage)
        {
            return StaffData.GetStaff(staff, out errorMessage);
        }
        public List<Staff> GetStaffList(out string errorMessage)
        {
            return StaffData.GetStaffList(out errorMessage);
        }
        public void SaveStaff(Staff staff, out string errorMessage)
        {
            StaffData.SaveStaff(staff, out errorMessage);
        }
        public string PasswordStaff(Staff staff, out string errorMessage)
        {
            string password = "PoorForgottenPuppies";
            StaffData.SaveStaffPassword(staff, password, out errorMessage);
            return password;
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
