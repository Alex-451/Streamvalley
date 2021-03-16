using System.Collections.Generic;
using System.Linq;
using Streamvalley.Payloads.Models;

namespace Streamvalley.Payloads
{/*
    public class PayloadLoader
    {
        private readonly Payloads _payloadMethods;
        public PayloadLoader(Payloads payloadMethods)
        {
            _payloadMethods = payloadMethods;
            LoadPayloads();
        }

        public List<Payload> AllPayloads;

        private void LoadPayloads()
        {
            AllPayloads = new List<Payload>
            {
                new Payload
                {
                    Id = 1,
                    Name = "Money",
                    Description = "Gives 5.000 moneyz.",
                    Method = _payloadMethods.GiveMoney,
                    IsActive = false
                },
                new Payload
                {
                    Id = 2,
                    Name = "Freeze",
                    Description = "Freezes the player for five seconds.",
                    Method = _payloadMethods.Freeze,
                    IsActive = true
                },
                new Payload
                {
                    Id = 3,
                    Name = "Gender bender",
                    Description = "Changes to the opposite gender.",
                    Method = _payloadMethods.ChangeGender,
                    IsActive = true
                },
                new Payload
                {
                    Id = 4,
                    Name = "Divorce",
                    Description = "Divorces with waifu.",
                    Method = _payloadMethods.Divorce,
                    IsActive = true
                },
                new Payload
                {
                    Id = 5,
                    Name = "Knockout",
                    Description = "Knocksout the player.",
                    Method = _payloadMethods.Knockout,
                    IsActive = true
                }
            };
        }


        public List<Payload> GetAllPayloads()
        {
            return AllPayloads;
        }

        public Payload GetPayloadById(int id)
        {
            return AllPayloads.Single(p => p.Id == id);
        }
    }*/
}