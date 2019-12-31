using ParcelAutomation.Entites;

namespace ParcelAutomation
{ 
    public class HeavyDepartment : IDepartment
    {
        public string HandleParce(Parcel parcel)
        {
            return "HeavyDepartement";
        }
    } 
}