namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("Users")]
    public partial class Users {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string user_id { get; set; }

        [StringLength(128)]
        public string parent_id { get; set; }

        [StringLength(512)]
        public string group_id { get; set; }

        [StringLength(128)]
        public string username { get; set; }

        [StringLength(256)]
        public string password { get; set; }

        [StringLength(128)]
        public string salt { get; set; }

        [StringLength(256)]
        public string full_name { get; set; }

        [StringLength(128)]
        public string mobile { get; set; }

        [StringLength(256)]
        public string email { get; set; }

        [StringLength(1024)]
        public string address { get; set; }

        [StringLength(2048)]
        public string details { get; set; }

        [StringLength(512)]
        public string images { get; set; }
        public int orders { get; set; }

        [StringLength(2048)]
        public string roles { get; set; }

        [StringLength(128)]
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }

        [StringLength(128)]
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }

        [StringLength(128)]
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public DateTime? last_login { get; set; }
        public DateTime? last_change_password { get; set; }
        public int flag { get; set; }
    }
}