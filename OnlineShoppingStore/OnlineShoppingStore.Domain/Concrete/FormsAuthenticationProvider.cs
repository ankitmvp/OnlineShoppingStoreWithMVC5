using OnlineShoppingStore.Domain.Abstract;
using System.Linq;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class FormsAuthenticationProvider:IAuthentication
    {
        private readonly EFDbContext efDbContext=new EFDbContext();
       public bool Authenticate(string username, string password)
       {
           var result = efDbContext.Users.FirstOrDefault(u => u.UserId == username && u.Password == password);
           if (result == null)
           {
               return false;
           }
           return true;
       }

       public bool Logout()
       {
           return true;
       }
    }
}
