namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("roles")]
    public partial class Roles {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string id { get; set; }
        public string name { get; set; }
        public string roles { get; set; }
        public int orders { get; set; }
        public string descs { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime? deleted_at { get; set; }
        public int flag { get; set; }
        public string color { get; set; }
    }
}