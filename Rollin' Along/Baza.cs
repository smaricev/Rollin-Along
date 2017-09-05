using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Rollin__Along
{
    public class Baza
    {
        static string connString = "Server=moops.ddns.net;Port=3306;Database=Rolling;Uid=mijo;Pwd=vpvpilj32";

        public MySqlConnection conn = new MySqlConnection(connString);
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;

        public Unos_i_upravljanje_inventara.FrmBicikli FrmBicikli
        {
            get => default(Unos_i_upravljanje_inventara.FrmBicikli);
            set
            {
            }
        }

        public Unos_i_upravljanje_inventara.FrmOprema FrmOprema
        {
            get => default(Unos_i_upravljanje_inventara.FrmOprema);
            set
            {
            }
        }
    }
}
