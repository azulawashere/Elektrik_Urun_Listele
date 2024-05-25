using Elektrik_Urun_Listele.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektrik_Urun_Listele.DesignPatterns.SingLetonPattern
{
    public class DBTool
    {
        DBTool() { }

        static Context _dbInstance;

        public static Context DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new Context();
                return _dbInstance;
            }
        }
    }
}
