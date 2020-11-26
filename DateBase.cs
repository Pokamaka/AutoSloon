using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSloon
{
    class DateBase
    {
        AutoSaloonEntities db = new AutoSaloonEntities();

        /// <summary>
        /// Функция возращающая список всех пользователей в БД
        /// </summary>      
        /// <param name="param"></param>
        /// <returns>спискок пользователей</returns>
        public IEnumerable<Accounts> GetAccounts(int flag_param = 0, string login = "", string password = "")
        {
            if (flag_param == 1)
            {
                IEnumerable<Accounts> users = db.Accounts.Where(x => x.Login == login && x.Password == password);
                return users;
            }
            else
            {
                IEnumerable<Accounts> users = db.Accounts;
                return users;
            }
        }

        /// <summary>
        /// Функция возращающая список всех машин в БД
        /// </summary>
        /// <param name="param"></param>
        /// <returns>список машин</returns>
        public IEnumerable<Cars> GetCars(int flag_param = 0, int id = 0)
        {
            if (flag_param == 1)
            {
                IEnumerable<Cars> cars = db.Cars.Where(b => b.ID == id);
                return cars;
            }
            else
            {
                IEnumerable<Cars> cars = db.Cars;
                return cars;
            }
        }
    }
}
