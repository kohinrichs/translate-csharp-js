using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
     static void Main(string[] args)
        {
            Guest marilyn = new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model");
            Guest abe = new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war");
            Guest martin = new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner");
            Guest rosa = new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist");
            Guest peter = new Guest("Peter Sellers", "entertainer", bio: "(1925 - 1980) British actor and comedian");
            Guest alan = new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world");
            Guest grace = new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds");
            Guest indira = new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977");

            List<Guest> guestList = new List<Guest>() { marilyn, abe, martin, rosa, peter, alan, grace, indira };

            List<Guest> table1 = new List<Guest>();
            List<Guest> table2 = new List<Guest>();

            Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>() {
                { "Table 1", table1 },
                { "Table 2", table2 }
            };

            foreach(Guest guest in guestList)
            {
                IEnumerable<string> table1Occupations = tables["Table 1"].Select(g => g.Occupation);

                if(table1Occupations.Contains(guest.Occupation))
                {
                    tables["Table 2"].Add(guest);
                } 
                else
                {
                    tables["Table 1"].Add(guest);
                } 
            }

            foreach (var table in tables)
            {
                List<Guest> tableGuests = tables[table.Key];
                
                Console.WriteLine(table.Key);

                foreach (Guest guest in tableGuests)
                {
                    Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                }

            }
        
        }
    }
}
