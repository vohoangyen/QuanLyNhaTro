using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLNhaTro
{
    class KiemTra
    {
        public int Check(string ten, string mk)
        {
            Data d = new Data();
            SqlDataReader rd = d.ExecuteReader("SELECT * FROM TaoTaiKhoan");
            while (rd.Read())
            {
                if (rd[1].ToString() == ten && rd[2].ToString() == mk)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
