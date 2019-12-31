using System;
using System.Collections.Generic;

namespace ParcelAutomation
{ 
    public interface IDepartmentFactory
    {
        List<IDepartment> CreateDepartments(double Weight, double value);
    } 
}
