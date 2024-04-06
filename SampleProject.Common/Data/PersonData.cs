using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SampleProject.Common.Core;

namespace SampleProject.Common.Data
{
    public class PersonData : DataContext
    {
        public static List<Person> GetAll()
        {
            return Context.Person.ToList();
        }

        public static Person GetById(int id)
        {
            return Context.Person.FirstOrDefault(x => x.Id == id);
        }

        public static void Save(Person item)
        {
            if (Context.Entry(item).State == EntityState.Detached)
            {
                Context.Person.Add(item);
            }

            Context.SaveChanges();
        }
    }
}
