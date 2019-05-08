using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Login
{
    class LoginBusiness
    {
        public List<LoginDTO> Pesquisar()
        {
            LoginDatabase db = new LoginDatabase();
            return db.Pesquisar();
        }
    }
}
