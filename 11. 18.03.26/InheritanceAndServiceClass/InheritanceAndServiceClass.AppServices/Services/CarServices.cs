using InheritanceAndServiceClass.Core.ServiceInterface;


namespace InheritanceAndServiceClass.AppServices.Services
{
    public class CarServices : ICarServices
    {
        public void GetData()
        {
            Console.WriteLine("Car Services Get");
        }

        public void PostData()
        {
            Console.WriteLine("Car Services Post");
        }

        public void UpdateData()
        {
            Console.WriteLine("Car Services Update");
        }

        public void DeleteData()
        {
            Console.WriteLine("Car Services Delete");
        }
    }
}
