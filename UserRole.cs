namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("user_role")]
    public partial class UserRole {
        public string user_id { get; set; }
        public string role_id { get; set; }
        public string module_id { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
    }
}