using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProPApplication
{
    public class Staff: Participant
    {
        private int shopNo;
        private int employeeNo;
        private string role;
        private int managerNo;
        private decimal totalMoneyMade;
        public int EmployeeNo { get { return this.employeeNo; } }
        public int ShopNo { get { return this.shopNo; } }
        public string Role { get { return this.role; } }
        public int ManagerNo { get { return this.managerNo; } }
        public Staff(string name, string dob, string RFIDNo, int employeeNo, string role, int shopNo, int managerNo): base(name, dob, RFIDNo)
        {   
            this.employeeNo = employeeNo;
            this.role = role;
            this.shopNo = shopNo;
            this.managerNo = managerNo;
        }

        public bool SellItem(Item item)
        {
            return false;
        }

        public void ReturnItem(Item item)
        {

        }

        public string PrintReceipt()
        {
            string receipt = "";
            return receipt;
        }

        public bool CheckParticipant()
        {
            return false;
        }

        public bool CheckLoanMaterial()
        {
            return false;
        }

        public void LoanTent(int tentNo, int accountNo)
        {

        }
        
        public decimal GetTotalMoneyMade()
        {
            string sql = string.Format("select sum(total) from ordernumber where employeeno = {0} group by employeeno", this.employeeNo);
            totalMoneyMade = DBConnection.ExecuteScalar(sql);
            return this.totalMoneyMade;
        }

        public override string ToString()
        {
            return base.ToString()+ "-EmplopyeeNo: " + this.employeeNo.ToString() + "-Role: " + this.role.ToString() + "-Manager number: " + this.managerNo.ToString() + "-shop number: " + this.shopNo.ToString() + "-total money made: " + this.GetTotalMoneyMade().ToString()+"-*******************************"; 
        }

        public string ReadLogFile(string fileName)
        {
            string result = "";
            //index 0 = fail, 1 = successful
            int[] status = new int[2];
            string successDetail = "";
            string failDetail = "";
            int success = 1;
            int fail = 1;
            int totalTransactions = 0;
            using (FileStream fsRead = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fsRead))
                {
                    string line = sr.ReadLine();
                    while(!sr.EndOfStream)
                    {
                        sr.ReadLine();
                        sr.ReadLine();
                        totalTransactions = Convert.ToInt32(sr.ReadLine());
                        for (int i = 0; i < totalTransactions; i++)
                        {
                            //Split account number and transaction amount
                            string transaction = sr.ReadLine();
                            string[] account = transaction.Split(' ');
                            //get current balance
                            string sqlGetCurrentBalance = "select ifnull(balance, 0) from eventaccount where accountno = " + account[0];
                            string[,] getCurrentBalance = DBConnection.ExecuteQuery1(1, sqlGetCurrentBalance, 1);
                            if(getCurrentBalance == null)
                            {
                                failDetail = fail + ", ID: " + account[0] + ", amount" + account[1] + "\r\n";
                                fail++;
                                status[0] += 1;
                            }
                            else
                            {
                                decimal currentBalance = Convert.ToDecimal(getCurrentBalance[0, 0]) + Convert.ToDecimal(account[1]);
                                //update balance
                                string sqlUpdateBalance = string.Format("update eventaccount set balance = '{0}' where accountno = '{1}'", currentBalance, Convert.ToInt32(account[0]));
                                DBConnection.ExecuteNonQuery(sqlUpdateBalance);
                                successDetail = success + ", ID: " + account[0] + ", amount" + account[1] + "\r\n";
                                success++;
                                status[1] += 1;
                            }
                        }
                    }
                }
            }
            result = "Successful transactions:\r\n" + successDetail + "Failed transactions: " + failDetail + "\r\n**********************\r\nTotal sucessful transactions: " + status[1] + "\r\nTotal failed transactions: " + status[0] + "\r\nTotal transactions made: " + totalTransactions;
            return result;
        }
    }
}
