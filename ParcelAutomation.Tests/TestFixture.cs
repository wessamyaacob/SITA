using ParcelAutomation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelAutomation.Tests
{
    public class TestFixture : IDisposable
    {
        public ParcelService service; 
        public TestFixture()
        {
            IDepartmentFactory departmentFactory = new DepartmentFactory();
            service = new ParcelService(departmentFactory); 
        }

        public void Dispose()
        {

        }

    }
}
