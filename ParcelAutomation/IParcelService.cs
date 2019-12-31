using ParcelAutomation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelAutomation
{
    public interface IParcelService
    {
        string HandleParcel(Parcel parcel);
    }
}
