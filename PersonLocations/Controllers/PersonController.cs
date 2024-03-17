using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonLocations.Controllers
{
    [ApiController]
    [Route("api/persons")]
    public class PersonsController : ControllerBase
    {
        private List<PersonLocations> _persons;

        public PersonsController()
        {
            _persons = new List<PersonLocations>
    {
        // 17.03.2024
        new PersonLocations("001A", "Сотрудник", 1, "in", "17.03.2024 16:30:00"),
        new PersonLocations("001B", "Сотрудник", 1, "out", "17.03.2024 16:45:00"),

        new PersonLocations("002A", "Клиент", 2, "in", "17.03.2024 16:45:00"),
        new PersonLocations("002B", "Клиент", 2, "out", "17.03.2024 17:00:00"),

        new PersonLocations("003A", "Сотрудник", 3, "in", "17.03.2024 17:15:00"),
        new PersonLocations("003B", "Сотрудник", 3, "out", "17.03.2024 17:30:00"),

        new PersonLocations("004A", "Клиент", 4, "in", "17.03.2024 17:45:00"),
        new PersonLocations("004B", "Клиент", 4, "out", "17.03.2024 18:00:00"),

        new PersonLocations("005A", "Сотрудник", 5, "in", "17.03.2024 18:15:00"),
        new PersonLocations("005B", "Сотрудник", 5, "out", "17.03.2024 18:30:00"),

        new PersonLocations("006A", "Клиент", 6, "in", "17.03.2024 18:45:00"),
        new PersonLocations("006B", "Клиент", 6, "out", "17.03.2024 19:00:00"),

        // 18.03.2024
        new PersonLocations("007A", "Сотрудник", 7, "in", "18.03.2024 09:00:00"),
        new PersonLocations("007B", "Сотрудник", 7, "out", "18.03.2024 09:15:00"),

        new PersonLocations("008A", "Клиент", 8, "in", "18.03.2024 10:30:00"),
        new PersonLocations("008B", "Клиент", 8, "out", "18.03.2024 10:45:00"),

        new PersonLocations("009A", "Сотрудник", 9, "in", "18.03.2024 13:00:00"),
        new PersonLocations("009B", "Сотрудник", 9, "out", "18.03.2024 13:15:00"),

        new PersonLocations("010A", "Клиент", 10, "in", "18.03.2024 15:30:00"),
        new PersonLocations("010B", "Клиент", 10, "out", "18.03.2024 15:45:00"),

        new PersonLocations("011A", "Сотрудник", 11, "in", "18.03.2024 17:00:00"),
        new PersonLocations("011B", "Сотрудник", 11, "out", "18.03.2024 17:15:00"),

        new PersonLocations("012A", "Клиент", 12, "in", "18.03.2024 19:30:00"),
        new PersonLocations("012B", "Клиент", 12, "out", "18.03.2024 19:45:00"),

        new PersonLocations("013A", "Сотрудник", 13, "in", "19.03.2024 08:30:00"),
        new PersonLocations("013B", "Сотрудник", 13, "out", "19.03.2024 08:45:00"),

        new PersonLocations("014A", "Клиент", 14, "in", "19.03.2024 11:00:00"),
        new PersonLocations("014B", "Клиент", 14, "out", "19.03.2024 11:15:00"),

        new PersonLocations("015A", "Сотрудник", 15, "in", "19.03.2024 13:30:00"),
        new PersonLocations("015B", "Сотрудник", 15, "out", "19.03.2024 13:45:00"),

        new PersonLocations("016A", "Клиент", 16, "in", "19.03.2024 16:00:00"),
        new PersonLocations("016B", "Клиент", 16, "out", "19.03.2024 16:15:00"),

        new PersonLocations("017A", "Сотрудник", 17, "in", "19.03.2024 18:30:00"),
        new PersonLocations("017B", "Сотрудник", 17, "out", "19.03.2024 18:45:00"),

        new PersonLocations("018A", "Клиент", 18, "in", "19.03.2024 21:00:00"),
        new PersonLocations("018B", "Клиент", 18, "out", "19.03.2024 21:15:00"),

        new PersonLocations("019A", "Сотрудник", 19, "in", "20.03.2024 09:30:00"),
        new PersonLocations("019B", "Сотрудник", 19, "out", "20.03.2024 09:45:00"),

        new PersonLocations("020A", "Клиент", 20, "in", "20.03.2024 12:00:00"),
        new PersonLocations("020B", "Клиент", 20, "out", "20.03.2024 12:15:00"),

        new PersonLocations("021A", "Сотрудник", 21, "in", "20.03.2024 14:30:00"),
        new PersonLocations("021B", "Сотрудник", 21, "out", "20.03.2024 14:45:00"),

        new PersonLocations("022A", "Клиент", 22, "in", "20.03.2024 17:00:00"),
        new PersonLocations("022B", "Клиент", 22, "out", "20.03.2024 17:15:00")
    };
        }

        [HttpGet]
        public IEnumerable<PersonLocations> GetPersons()
        {
            return _persons;
        }
    }
}
