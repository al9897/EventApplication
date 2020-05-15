using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    public abstract class Participant
    {
        private string name;
        private string dob;
        private string RFIDNo;
        public string RFIDNO { get { return this.RFIDNo; } }
        public string Name { get { return this.name; } }
        public string Dob { get { return this.dob; } }
        public Participant(string name, string dob, string RFIDNo)
        {
            this.name = name;
            this.dob = dob;
            this.RFIDNo = RFIDNo;
        }
        //Change from Info() to ToString()
        public override string ToString()
        {
            return "-Name: " + this.name + "-D.O.B: " + this.dob + "-RFIDnumber: " + this.RFIDNo;
        }
    }
}
