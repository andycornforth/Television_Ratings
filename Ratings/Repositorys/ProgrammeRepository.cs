using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProgrammeRepository
    {
        void AddProgramme(Programme programme);
    }

    public class ProgrammeRepository : BaseSqlRepository, IProgrammeRepository
    {
        public ProgrammeRepository(IConnectionStringProvider connectionStringProvider)
            : base(connectionStringProvider)
        {
        }

        public void AddProgramme(Programme programme)
        {
            var command = GetCommand("AddProgramme", System.Data.CommandType.StoredProcedure);

            AddParameter(command, "@Title", programme.Title);
            AddParameter(command, "@ChannelId", programme.Channel.Id);

            ExecuteNonQueryChecked(command);
        }
    }
}
