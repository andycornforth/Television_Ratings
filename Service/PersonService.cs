using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPersonService
    {
        void AddPerson(string firstname, string lastname, string email, string password);
        Person GetPersonByEmail(string email);
    }

    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public PersonService()
        {
            _personRepository = new PersonRepository(new ConnectionStringProvider());
        }

        public void AddPerson(string firstname, string lastname, string email, string password)
        {
            var person = new Person()
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Password = password
            };

            _personRepository.AddPerson(person);
        }

        public Person GetPersonByEmail(string userName)
        {
            return _personRepository.GetPersonByEmail(userName);
        }
    }
}
