using SGF.Models;

namespace SGF.Utils
{
    public class UserSession
    {
        public UserModel User { get; set; }
        public bool IsLogged { get; set; }
        public void Login (UserModel user)
        {
            User = user;
        }
        public void Logout ()
        {
            User = null;
        }

    }
}
