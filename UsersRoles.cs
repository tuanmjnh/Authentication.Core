namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System;
    [Table("users_roles")]
    public partial class UsersRoles {
        [Dapper.Contrib.Extensions.Key]
        public int id { get; set; }
        public string user_id { get; set; }
        public string role_key { get; set; }
        public string role_value { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
    }
}