using System;
using System.Collections.Generic;
using SampleProject.Common.Data;

namespace SampleProject.Common.Services
{
    public class PersonService : IPersonService
    {
        public Person LoadPerson(int personId)
        {
            if (personId <= 0)
                throw new ArgumentOutOfRangeException(nameof(personId));

            return PersonData.GetById(personId);
        }

        public List<Person> GetAll()
        {
            return PersonData.GetAll();
        }
    }
}
