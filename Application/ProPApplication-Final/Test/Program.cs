using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{

			string password = "abc";
			var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
			Console.WriteLine(hashedPassword);
			//string s = "INSERT INTO `employee`(`AccountNo`, `AccountReview`, `Balance`, `TicketPaidMethod`, `TicketPrice`, `TicketNo`, `NumberOfEvent`, `CampingSpotNo`, `VisitorNo`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7],[value-8],[value-9])";
			string s = string.Format("INSERT INTO employee(FirstName,LastName,Password,Role,RFIDNo,ManagerNo,ShopNo,UserName) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}'", "quoc", "cho", Convert.ToString(hashedPassword), "manager","123123", 0,1, "quoc");
			int i = DBConnection.ExecuteNonQuery(s);
			///*string createVisitorQuerry = "INSERT INTO visitor(UserName,Password,FirstName,L*/
			//astName,Email,DOB,PhoneNumber,Address,Country) VALUES (null,null, 'abc','','' ,'','','',null)";
			//int nrOfRowVisitorInsert = DBConnection.ExecuteNonQuery(createVisitorQuerry);
			//break;
			Console.ReadKey();
		}
	}
}
