using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud2023.DAL;
 

namespace Crud2023.BLL
{
    class LoginBLL
    {

    public bool GetLoginBLL(LoginDTO loginDTO)
        {
            //chamar a DAL
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.GetLoginDAL(loginDTO);
            return true;
        }

    }
}
