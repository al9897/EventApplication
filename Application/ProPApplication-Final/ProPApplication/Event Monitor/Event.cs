using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class Event
    {
        private List<Participant> listOfPeople;
        private string eventName;
        public Event(string name)
        {
            this.eventName = name;
            listOfPeople = new List<Participant>();
        }

        public Participant FindPerson(string RFIDNo)
        {
            foreach(Participant search in listOfPeople)
            {
                if(search.RFIDNO == RFIDNo)
                {
                    return search;
                }
            }
            return null;
        }

        public bool AddPerson(Participant person)
        {
            foreach(Participant search in listOfPeople)
            {
                if(person.RFIDNO == search.RFIDNO)
                {
                    return false;
                }
            }
            listOfPeople.Add(person);
            return true;
        }

        public int checkInNo()
        {
            int total = 0;
            foreach(Participant search in listOfPeople)
            {
                if(search is Visitor visitor1)
                {
                    if(visitor1.CheckIn == true)
                    {
                        total += 1;
                    }
                }
            }
            return total;
        }

        public List<Participant> FindGroupInTent(int tentNo)
        {
            List<Participant> temp = new List<Participant>();
            foreach(Participant search in listOfPeople)
            {
                if(search is Visitor visitor1)
                {
                    if(visitor1.TentNo == tentNo)
                    {
                        temp.Add(search);
                    }
                }
            }
            return temp;
        }

        public List<Participant> GetAllPeople()
        {
            return listOfPeople;
        }

        public List<Participant> GetAllVisitor()
        {
            List<Participant> temp = new List<Participant>();
            foreach(Participant search in listOfPeople)
            {
                if(search is Visitor)
                {
                    temp.Add(search);
                }
            }
            return temp;
        }

        public List<Participant> GetAllEmployee()
        {
            List<Participant> temp = new List<Participant>();
            foreach(Participant search in listOfPeople)
            {
                if(search is Staff)
                {
                    temp.Add(search);
                }
            }
            return temp;
        }


    }
}
