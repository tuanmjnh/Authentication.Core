namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table ("Users")]
    public partial class Users {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid id { get; set; }

        [StringLength (128)]
        public string username { get; set; }

        [StringLength (256)]
        public string password { get; set; }

        [StringLength (128)]
        public string salt { get; set; }

        [StringLength (256)]
        public string full_name { get; set; }

        [StringLength (128)]
        public string mobile { get; set; }

        [StringLength (256)]
        public string email { get; set; }
        public string address { get; set; }
        public string roles { get; set; }

        [StringLength (128)]
        public string created_by { get; set; }
        public DateTime created_at { get; set; }

        [StringLength (128)]
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? last_login { get; set; }

        [StringLength (256)]
        public string staff_id2 { get; set; }
        public Guid staff_id { get; set; }
        public string group_id { get; set; }
        public string user_id { get; set; }
        public int flag { get; set; }
        public string extras { get; set; }
    }
}