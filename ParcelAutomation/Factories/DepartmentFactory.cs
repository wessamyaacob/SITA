using System;
using System.Collections.Generic;

namespace ParcelAutomation
{
    public class DepartmentFactory : IDepartmentFactory
    {
        private readonly Dictionary<Type, IDepartment> _departments;
        public DepartmentFactory()
        {
            _departments = new Dictionary<Type, IDepartment>();
            _departments.Add(typeof(InsuranceDepartment), new InsuranceDepartment());
            _departments.Add(typeof(HeavyDepartment), new HeavyDepartment());
            _departments.Add(typeof(MailDepartment), new MailDepartment());
            _departments.Add(typeof(RegularDepartment), new RegularDepartment());
        }

        public List<IDepartment> CreateDepartments(double Weight, double value)
        {
            var list = new List<IDepartment>();
            CreateValueDepartment(value, list);
            CreateWeightDepartment(Weight, list);

            return list;
        }

        private void CreateWeightDepartment(double Weight, List<IDepartment> list)
        {
            if (Weight > 10)
                list.Add(_departments[typeof(HeavyDepartment)]);
            else if (Weight > 1)
                list.Add(_departments[typeof(RegularDepartment)]);
            else
                list.Add(_departments[typeof(MailDepartment)]);
        }

        private void CreateValueDepartment(double value, List<IDepartment> list)
        {
            if (value > 1000)
                list.Add(_departments[typeof(InsuranceDepartment)]);
        }
    }
}
