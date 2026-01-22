using SGF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF
{
    public partial class MainSreen : Form
    {
        private UserModel _user;
        public MainSreen(UserModel user)
        {
            _user = user;

            InitializeComponent();

            labelUser.Text = $"Usuário: {_user.Name}";
        }

        
       
    }
}
