namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System;
    [Table("modules")]
    public partial class Modules {
        [Dapper.Contrib.Extensions.Key]
        public int modules_id { get; set; }
        public string app_key { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string descs { get; set; }
        public string url { get; set; }
        public string positions { get; set; }
        public int orders { get; set; }
        public string created_by { get; set; }
        public DateTime? created_at { get; set; }
        public string updated_by { get; set; }
        public DateTime? updated_at { get; set; }
        public int flag { get; set; }
    }
}