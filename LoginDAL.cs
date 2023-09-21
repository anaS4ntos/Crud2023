using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud2023.DAL
{
    class LoginDAL
    {

        // fake de conexão
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            if (loginDTO.User == "Wagnr" && loginDTO.Secret == "1234")
            return true;

            return false;
        }

    }
}
