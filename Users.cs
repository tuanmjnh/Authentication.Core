namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("Users")]
    public partial class Users {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string UserID { get; set; }

        [StringLength(128)]
        public string parentId { get; set; }

        [StringLength(512)]
        public string groupId { get; set; }

        [StringLength(128)]
        public string username { get; set; }

        [StringLength(256)]
        public string password { get; set; }

        [StringLength(128)]
        public string salt { get; set; }

        [StringLength(256)]
        public string fullname { get; set; }

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
        public string createdBy { get; set; }
        public DateTime? createdAt { get; set; }

        [StringLength(128)]
        public string updatedBy { get; set; }
        public DateTime? updatedAt { get; set; }

        [StringLength(128)]
        public string deletedBy { get; set; }
        public DateTime? deletedAt { get; set; }
        public DateTime? lastlogin { get; set; }
        public DateTime? lastChangePassword { get; set; }
        public int flag { get; set; }
        public string extras { get; set; }
    }
}