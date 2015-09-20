using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProgrammeService
    {
        void AddProgramme(string title, int channelId);
    }

    public class ProgrammeService : IProgrammeService
    {
        private IProgrammeRepository _programmeRepository;

        public ProgrammeService(IProgrammeRepository programmeRepository)
        {
            _programmeRepository = programmeRepository;
        }

        public ProgrammeService()
        {
            _programmeRepository = new ProgrammeRepository(new ConnectionStringProvider());
        }

        public void AddProgramme(string title, int channelId)
        {
            var programme = new Programme()
            {
                Title = title,
                Channel = new Channel() { Id = channelId }
            };

            _programmeRepository.AddProgramme(programme);
        }
    }
}
