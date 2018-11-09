using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPaySysIntegration
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PPSI_ServiceWCF" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select PPSI_ServiceWCF.svc or PPSI_ServiceWCF.svc.cs at the Solution Explorer and start debugging.
	public class PPSI_ServiceWCF : IPPSI_ServiceWCF
	{
		public void AddAmount(int amount, string username)
		{
			UserManager.AddAmount(amount, username);
		}
		public double GetAvailableAmount(string username)
		{
			double amount = UserManager.GetAvailableAmount(username);
			return amount;
		}
	}
}
