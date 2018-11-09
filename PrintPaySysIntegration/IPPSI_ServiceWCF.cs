using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPaySysIntegration
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPPSI_ServiceWCF" in both code and config file together.
	[ServiceContract]
	public interface IPPSI_ServiceWCF
	{
		[OperationContract]
		void AddAmount(int amount, string username);
		[OperationContract]
		double GetAvailableAmount(string username);
	}
}
