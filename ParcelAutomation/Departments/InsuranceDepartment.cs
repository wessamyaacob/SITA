using ParcelAutomation.Entites;

namespace ParcelAutomation
{ 
    public class InsuranceDepartment : IDepartment
    {
        public string HandleParce(Parcel parcel)
        {
            return "InsuranceDepartement";
        }
    }
}