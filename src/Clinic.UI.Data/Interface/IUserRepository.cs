using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.UI.Data.Model;

namespace Clinic.UI.Data.Interface
{
    public interface IUserRepository
    {
        Guid CreateUser(ApplicationUsers users);
    }
}
