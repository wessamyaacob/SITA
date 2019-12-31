using ParcelAutomation.Entites;

namespace ParcelAutomation
{ 
    public class RegularDepartment : IDepartment
    {
        public string HandleParce(Parcel parcel)
        {
            return "RegularDepartement";
        }
    } 
}