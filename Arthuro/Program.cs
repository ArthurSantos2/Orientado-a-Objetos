using Arthuro.ContentContext;
using Arthuro.SubscriptionContext;

namespace Arthuro
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientação-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .net", "dotnet"));

            // foreach(var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var course = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            course.Add(courseOOP);
            course.Add(courseCsharp);
            course.Add(courseAspNet);

            

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Itemns.Add(careerItem2);
            careerDotnet.Itemns.Add(careerItem);
            careerDotnet.Itemns.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Itemns.OrderBy(x=>x.Order))
                {
                    //abaixo uma composição de string
                    Console.WriteLine($"{item.Order} - {item.Title}");

                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }
        }
    }
}