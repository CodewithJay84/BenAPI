using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ben.API.Models;

namespace Ben.API
{
    public class MemberDataStore
    {
        public static MemberDataStore Current { get; } = new MemberDataStore();
        public List<Member> Members { get; set; }

        public MemberDataStore()
        {
            Members = new List<Member>()
            {
                    new Member()
                {
                    Id = 1,
                    Forename = "Frank",
                    Surname = "Thomas"
                },
                new Member()
                {
                    Id = 2,
                    Forename = "Thomas",
                    Surname = "Franks"
                },
                new Member()
                {
                    Id = 3,
                    Forename = "Wanda",
                    Surname = "Perri"
                },
                new Member()
                {
                    Id = 4,
                    Forename = "Jason",
                    Surname = "McMullen"
                }
            };
            
        }

    }
}
