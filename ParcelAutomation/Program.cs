using ParcelAutomation.Entites;
using ParcelAutomation.Utility;
using System;
using System.IO;

namespace ParcelAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Container.xml";
            Container container = GetContainer(path);

            if (container == null || container.Parcels == null)
                return;

            IDepartmentFactory departmentFactory = new DepartmentFactory();
            ParcelService parcelService= new ParcelService(departmentFactory);

            foreach (var parcel in container.Parcels.Parcel)
            {
                var result = parcelService.HandleParcel(parcel);
                Console.WriteLine($"Parcel from {parcel.Sender.Name} with weight { parcel.Weight} and value {parcel.Value} is Handled By " +
                    $"{result}");
            }

            Console.ReadLine();
        }

        private static Container GetContainer(string path)
        {
            Container container;
            using (var reader = new StreamReader(path))
            {
                container = XMLFormatter.Deserialize<Container>(reader);
            }

            return container;
        }
    }
}
