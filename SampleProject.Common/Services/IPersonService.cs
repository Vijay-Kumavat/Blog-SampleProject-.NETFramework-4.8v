using System.Collections.Generic;
using SampleProject.Common.Data;

namespace SampleProject.Common.Services
{
    public interface IPersonService
    {
        Person LoadPerson(int personId);

        List<Person> GetAll();
    }
}