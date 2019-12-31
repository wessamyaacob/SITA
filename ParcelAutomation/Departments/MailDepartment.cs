using ParcelAutomation.Entites;

namespace ParcelAutomation
{ 
    public class MailDepartment : IDepartment
    {
        public string HandleParce(Parcel parcel)
        {
            return "MailDepartement";
        }
    } 
}