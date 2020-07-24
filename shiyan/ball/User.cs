using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ball
{
    /// <summary>
    /// 用户类
    /// </summary>
    class User
    {
        private string loginId;
        public string LoginId
        {
            get { return this.loginId; }
            set { this.loginId = value; }
        }
        public string Password { get; set; }
        public User()
        {

        }
        public User(string loginId,string pwd)
        {
            this.LoginId = loginId;
            this.Password = pwd;
        }
        public void PrintUser()
        {
            Console.WriteLine("账号：{0}，密码：{1}",LoginId, Password);
        }
    }
}
