using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz
{
    class ShowStu
    {
       public DataTable GetStu()
      {
          ShowStudents ss = new ShowStudents();
          return ss.Read();
      }


    }
}
