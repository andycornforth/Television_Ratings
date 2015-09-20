using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IChannelService
    {
        void AddChannel(string title);
    }

    public class ChannelService : IChannelService
    {
        private IChannelRepository _channelRepository;

        public ChannelService(IChannelRepository channelRepository)
        {
            _channelRepository = channelRepository;
        }

        public ChannelService()
        {
            _channelRepository = new ChannelRepository(new ConnectionStringProvider());
        }

        public void AddChannel(string title)
        {
            var channel = new Channel()
            {
                Title = title
            };

            _channelRepository.AddChannel(channel);
        }
    }
}
