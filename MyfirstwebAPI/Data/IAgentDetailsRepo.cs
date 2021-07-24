using System;
using System.Collections.Generic;
using MyfirstwebAPI.Models;

namespace MyfirstwebAPI.Data
{
    public interface IAgentDetailsRepo
    {
        IEnumerable<AgentsDetails> GetAgentsDetails();

        AgentsDetails GetAgentsDetailsById(int Id);
    }
}
