using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    abstract class Participant
    {
        private string name;
        private string dob;
        private int RFIDNo;
        public int RFIDNO { get { return RFIDNo; } }
        public Participant(string name, string dob, int RFIDNo)
        {
            this.name = name;
            this.dob = dob;
            this.RFIDNo = RFIDNo;
        }
        public virtual string Info()
        {
            return "Name: " + this.name + " D.O.B: " + this.dob + " RFID number: " + this.RFIDNo;
        }
    }
}
