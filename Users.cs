namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("Users")]
    public partial class Users {
        [Dapper.Contrib.Extensions.Key]
        public string user_id { get; set; }
        public string parent_id { get; set; }
        public string group_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string full_name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string descs { get; set; }
        public string images { get; set; }
        public int orders { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public DateTime? last_login { get; set; }
        public DateTime? last_change_password { get; set; }
        public int flag { get; set; }
    }
}