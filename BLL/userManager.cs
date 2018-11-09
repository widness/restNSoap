using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        const double CONVERSION = 0.08;
        public static int GetUID(string username)
        {
            return UserDB.GetUID(username);
        }
        public static int GetUID(int carteID)
        {
            return UserDB.GetUID(carteID);
        }
        public static string GetUsername(int uid)
        {
            return UserDB.GetUsername(uid);
        }
        public static void AddAmount(int amount, string username) // = transferMoney
        {
			int uid = GetUID(username);
            UserDB.AddAmount((amount + GetAvailableAmount(uid)), uid);
        }
        public static double GetAvailableAmount(string username)
        {
            int uid = GetUID(username);
            return UserDB.GetAmount(uid);
        }
        public static double GetAvailableAmount(int uid)
        {
            return UserDB.GetAmount(uid);
        }
    }
}
