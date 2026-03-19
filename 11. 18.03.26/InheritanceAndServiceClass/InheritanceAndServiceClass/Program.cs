using InheritanceAndServiceClass.AppServices.Services;
using InheritanceAndServiceClass.Core.ServiceInterface;
using Microsoft.AspNetCore.Mvc;


namespace InheritanceAndServiceClass
{
    internal class Program
    {
        private readonly ICarServices _carServices;

        public Program
            (
                ICarServices carServices
            )
        {
            _carServices = carServices;
        }

        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddScoped<ICarServices, CarServices>();

            Console.WriteLine("Hello, World Switch!");
            int choice = int.Parse(Console.ReadLine());

            using (var scope = app.Services.CreateScope())
            {
                var carServices = scope.ServiceProvider.GetRequiredService<ICarServices>();
                var program = new Program(carServices);

                switch (choice)
                {
                case 1:
                    program.GetAsync();
                    break;

                case 2:
                    program.PostAsy
                    break;

                case 3:

                    break;

                case 4:

                    break;

                default:
                    Console.WriteLine("Error");
                    break;
                }
            }


        }

        public IActionResult GetAsync()
        {
            _carServices.GetData();

            return View();
        }



        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
