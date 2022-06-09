using MVCCore6.Models;

namespace MVCCore6.Data
{
    public class ServiceData
    {
        public static List<Service> GetServices()
        {
            return new List<Service>()
            {
                new Service(1,"Heading 1","Some representative placeholder content for the three columns of text below the carousel. This is the first column.","Service-1.jpg","View details"),
                new Service(2,"Heading 2","Some representative placeholder content for the three columns of text below the carousel. This is the first column.","Service-2.jpg","View details"),
                new Service(3,"Heading 3","Some representative placeholder content for the three columns of text below the carousel. This is the first column.","Service-3.jpg","View details")
            };
        }

    }
}
