using System;
using System.Linq;
using TM.Core.Helper;
namespace Authentication.Core {
    public class Auth {
        private const string SessionAuth = "Auth";
        private const string SessionRoles = "Roles";
        private const string SessionAllowRoles = "AllowRoles";
        public const string API = "API";
        //private static Models.Users AuthAccount;
        public static Users SetAuth(Users Users) {
            try {
                TMAppContext.Http.Session.Set(SessionAuth, Newtonsoft.Json.JsonConvert.SerializeObject(Users));
                return Users;
            } catch (Exception) { throw; }
        }
        public static Users AuthUser {

            get {
                try {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Users>(TMAppContext.Http.Session.Get<string>(SessionAuth));
                } catch (Exception) { throw; }
            }
        }
        public static bool isAuth {
            get {
                if (TMAppContext.Http.Session.Get<string>(SessionAuth)!= null)
                    return true;
                return false;
            }
        }
        //public static Models.Users GetAuth()
        //{
        //    return Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Users>(AppHttpContext.Current.Session.Get<string>(SessionAuth));
        //    //return AuthAccount;
        //}
        public static bool inRoles(string[] r) {
            if (r.Contains(AuthUser.roles))
                return true;
            return false;
        }
        public static void Logout() {
            try { TMAppContext.Http.Session.Remove(SessionAuth); } catch (Exception) { throw; }
        }
        private static System.Collections.Generic.List<Users> ListAuthStatic() {
            var List = new System.Collections.Generic.List<Users>();
            var User = new Users();
            //tuanmjnh
            User.id = Guid.Parse("f4191f70-2c4a-442e-a62d-b4b6833b33f4");
            User.username = "tuanmjnh";
            User.password = "aa2de065c899d53d7031b0975c56062f"; //"Tuanmjnh@tm"; //"fc44d0279133a2f46178134ce9bf2167";//tuanmjnh@123
            User.salt = "1c114c58-69d9-41e6-bd3e-363906e04e50";
            User.full_name = "SuperAdmin";
            User.mobile = "0123456789";
            User.email = "tuanmjnh@SuperAdmin.com";
            User.address = "SuperAdmin";
            User.roles = Roles.superadmin;
            User.created_by = "f4191f70-2c4a-442e-a62d-b4b6833b33f4";
            User.created_at = DateTime.Now;
            User.updated_by = "f4191f70-2c4a-442e-a62d-b4b6833b33f4";
            User.updated_at = DateTime.Now;
            User.last_login = DateTime.Now;
            User.flag = 1;
            User.extras = null;
            //Add User to list
            List.Add(User);
            return List;
        }
        public static Users isAuthStatic(string username, string password) {
            foreach (var item in ListAuthStatic()) {
                if (item.username == username && item.password == TM.Core.Encrypt.MD5.CryptoMD5TM(password + item.salt)) {
                    return item;
                }
            }
            return null;
        }
        public static string getUserAction() {
            return "," + AuthUser.id + "," + AuthUser.username + "," + AuthUser.full_name + ",";
        }
    }
}