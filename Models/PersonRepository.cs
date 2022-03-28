using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();
        public int NumberOfPerson
        {
 get
 {
 return persons.Count();
 }
        }
public IEnumerable<Person> GetAllResponses
{
    get
    {
        return persons;
    }
}
        public void AddResponse(Person pers)
        {//Для возможности добавления персон в коллекцию в классе реализуется метод:
            persons.Add(pers);
        }

    }
}