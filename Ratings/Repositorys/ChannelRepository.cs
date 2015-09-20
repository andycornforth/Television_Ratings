using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IChannelRepository
    {
        void AddChannel(Channel channel);
    }

    public class ChannelRepository : BaseSqlRepository, IChannelRepository
    {
        public ChannelRepository(IConnectionStringProvider connectionStringProvider)
            : base(connectionStringProvider)
        {
        }

        public void AddChannel(Channel channel)
        {
            var command = GetCommand("AddChannel", System.Data.CommandType.StoredProcedure);

            AddParameter(command, "@Title", channel.Title);

            ExecuteNonQueryChecked(command);
        }
    }
}
