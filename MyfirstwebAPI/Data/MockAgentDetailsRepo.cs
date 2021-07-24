using System;
using System.Collections.Generic;
using MyfirstwebAPI.Models;

namespace MyfirstwebAPI.Data
{
    public class MockAgentDetailsRepo : IAgentDetailsRepo
    {
        public IEnumerable<AgentsDetails> GetAgentsDetails()
        {
            List<AgentsDetails> AgentsList = new List<AgentsDetails>();

            AgentsList.Add(new AgentsDetails
            {
                Id = 1,
                Username = "Omo",
                FullName = "Who Cares",
                Gender = 'M',
                Age = 25,
                EmailAddress = "user@gmail.com",
                PhoneNumber = 08075492356
            });
            AgentsList.Add(new AgentsDetails
            {
                Id = 1,
                Username = "babamiFada",
                FullName = "The Father",
                Gender = 'M',
                Age = 35,
                EmailAddress = "user@gmail.com",
                PhoneNumber = 09046576877
            });
            AgentsList.Add(new AgentsDetails
            {
                Id = 1,
                Username = "sheamus",
                FullName = "FullStack",
                Gender = 'M',
                Age = 31,
                EmailAddress = "user@gmail.com",
                PhoneNumber = 07045346576
            });
            AgentsList.Add(new AgentsDetails
            {
                Id = 1,
                Username = "beroona",
                FullName = "Bereau D' change",
                Gender = 'F',
                Age = 27,
                EmailAddress = "user@gmail.com",
                PhoneNumber = 09145657687
            });
            AgentsList.Add(new AgentsDetails
            {
                Id = 1,
                Username = "Shield",
                FullName = "King",
                Gender = 'M',
                Age = 25,
                EmailAddress = "user@gmail.com",
                PhoneNumber = 08154657688
            });

            return AgentsList;
        }

        public AgentsDetails GetAgentsDetailsById(int Id)
        {
            return new AgentsDetails
            {
                Id = 1,
                Username = "Omo",
                FullName = "Who Cares",
                Gender = 'M',
                Age = 25,
                EmailAddress = "user@gmail.com",
                PhoneNumber = 08075492356
            };
        }
    }
}
 