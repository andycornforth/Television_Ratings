using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPersonRepository
    {
        void AddPerson(Person person);
        Person GetPersonByEmail(string userName);
    }

    public class PersonRepository : BaseSqlRepository, IPersonRepository
    {
        public PersonRepository(IConnectionStringProvider connectionStringProvider)
            : base(connectionStringProvider)
        {
        }

        public void AddPerson(Person person)
        {
            var command = GetCommand("AddPerson", System.Data.CommandType.StoredProcedure);

            AddParameter(command, "@FirstName", person.FirstName);
            AddParameter(command, "@LastName", person.LastName);
            AddParameter(command, "@Email", person.Email);
            AddParameter(command, "@Password", person.Password);

            ExecuteNonQueryChecked(command);
        }

        public Person GetPersonByEmail(string email)
        {
            var query = @"SELECT * FROM [Person] WHERE Email = @Email";
            var command = GetCommand(query, System.Data.CommandType.Text);

            AddParameter(command, "@Email", email);

            return GetEntitiesFromDatabase<Person>(command).FirstOrDefault();
        }

        protected override object MapRowToEntity(IDataReader reader)
        {
            return new Person()
            {
                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Password = reader.GetString(reader.GetOrdinal("Password"))
            };
        }
    }
}
