using ParcelAutomation.Entites;
using System;

namespace ParcelAutomation
{
    public class ParcelService
    {
        private IDepartmentFactory _departmentFactory;
        public ParcelService(IDepartmentFactory departmentFactory)
        {
            _departmentFactory = departmentFactory;
        }

        public string HandleParcel(Parcel parcel)
        {
            if (parcel == null)
                throw new ArgumentNullException();

            if (parcel.Weight <= 0)
                throw new ArgumentException($"Weight must be greater than zero {parcel.Weight}");

            string result = string.Empty;
            var departments = _departmentFactory.CreateDepartments(parcel.Weight, parcel.Value);
            foreach (var department in departments)
            {
                result += $"{department.HandleParce(parcel)},";
            }

            return result.Remove(result.Length - 1, 1);
        }
    }
}
