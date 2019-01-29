using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TM.Core.Cookies;
namespace Authentication.Core {
    public class Auth {
        private const string KeyAuth = "Authentication";
        private const string KeyRoles = "Roles";
        private const string KeyAllowRoles = "AllowRoles";
        public const string API = "API";
        //private static Models.Users AuthAccount;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public Auth(IHttpContextAccessor httpContextAccessor) {
            _httpContextAccessor = httpContextAccessor;
        }
        public static void SetAuth(Users Users, List<RolesAcess> Roles = null, List<RolesAcess> AllowRoles = null) {
            try {
                var options = new CookieOptions() { Expires = DateTime.Now.AddMinutes(30), HttpOnly = true };
                TM.Core.HttpContext.Http.Response.Cookies.Set(KeyAuth, Users, options);
                TM.Core.HttpContext.Http.Response.Cookies.Set(KeyRoles, Roles, options);
                TM.Core.HttpContext.Http.Response.Cookies.Set(KeyAllowRoles, AllowRoles, options);
            } catch (Exception) { throw; }
        }
        public static Users AuthUser {
            get {
                try {
                    //return Newtonsoft.Json.JsonConvert.DeserializeObject<Users>(TMAppContext.Http.Session.Get<string>(SessionAuth));
                    return TM.Core.HttpContext.Http.Request.Get<Users>(KeyAuth);
                } catch (Exception) { return null; }
            }
        }
        public static List<RolesAcess> AuthRoles {
            get {
                try {
                    //return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RolesAcess>>(TMAppContext.Http.Session.Get<string>(SessionRoles));
                    return TM.Core.HttpContext.Http.Request.Get<List<RolesAcess>>(KeyRoles);
                } catch (Exception) { return null; }
            }
        }
        public static List<RolesAcess> AuthAllowRoles {
            get {
                try {
                    //return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RolesAcess>>(TMAppContext.Http.Session.Get<string>(SessionAllowRoles));
                    return TM.Core.HttpContext.Http.Request.Get<List<RolesAcess>>(KeyAllowRoles);
                } catch (Exception) { return null; }
            }
        }
        public static bool isAuth {
            get {
                try {
                    //var a = TM.Core.Helper.TMAppContext.HttpHelper.HttpContext.Session.Get<string>("Authentication");
                    if (TM.Core.HttpContext.Http.Request.Get<Users>(KeyAuth) != null)
                        return true;
                    return false;
                } catch (Exception) { return false; }
            }
        }
        //public static Models.Users GetAuth()
        //{
        //    return Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Users>(AppHttpContext.Current.Session.Get<string>(SessionAuth));
        //    //return AuthAccount;
        //}
        public static bool inRoles(string[] r) {
            //if (r.Contains(AuthUser.roles))
                return true;
            //return false;
        }
        public static void Logout() {
            try { TM.Core.HttpContext.Http.Response.Remove(KeyAuth); } catch (Exception) { throw; }
        }
        private static System.Collections.Generic.List<Users> ListAuthStatic() {
            var List = new System.Collections.Generic.List<Users>();
            var User = new Users();
            //tuanmjnh
            User.user_id = "f4191f702c4a442ea62db4b6833b33f4".ToUpper();
            User.username = "tuanmjnh";
            User.password = "aa2de065c899d53d7031b0975c56062f"; //"Tuanmjnh@tm"; //"fc44d0279133a2f46178134ce9bf2167";//tuanmjnh@123
            User.salt = "1c114c58-69d9-41e6-bd3e-363906e04e50";
            User.full_name = "SuperAdmin";
            User.mobile = "0123456789";
            User.email = "tuanmjnh@SuperAdmin.com";
            User.address = "SuperAdmin";
            User.created_by = "admin";
            User.created_at = DateTime.Now;
            User.updated_by = "admin";
            User.updated_at = DateTime.Now;
            User.last_login = DateTime.Now;
            User.flag = 1;
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
            return "," + AuthUser.user_id + "," + AuthUser.username + "," + AuthUser.full_name + ",";
        }
    }
}