namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("db_nguoidung")]
    public partial class DBNguoidung {
        [Dapper.Contrib.Extensions.Key]
        public int nguoidung_id { get; set; }
        public int? donvi_id { get; set; }
        public string ma_nd { get; set; }
        public string matkhau { get; set; }
        public string ten_nd { get; set; }
        public int quantri { get; set; }
        public int nhom_nd_id { get; set; }
        public int trangthai { get; set; }
        public int nhanvien_id { get; set; }
        public string ma_nv { get; set; }
        public string ten_nv { get; set; }
        public string ten_tn { get; set; }
        public string diachi_nv { get; set; }
        public int gioitinh { get; set; }
        public string chucdanh { get; set; }
        public string so_dt { get; set; }
        public string email { get; set; }
        public DateTime? ngay_sn { get; set; }
        public int loaidv_id { get; set; }
    }
    public partial class DBnguoidungRoles : DBNguoidung {
        public string roles_id { get; set; }
        public string roles_name { get; set; }
        public string color { get; set; }
    }

    [Table("nguoidung")]
    public partial class nguoidung {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int nguoidung_id { get; set; }
        public string salt { get; set; }
        public string matkhau { get; set; }
        public string roles_id { get; set; }
        public string roles { get; set; }
        public DateTime? last_login { get; set; }
        public DateTime? last_change_pass { get; set; }
        public string token { get; set; }
    }
    public partial class nguoidung_role {
        public int nguoidung_id { get; set; }
        public string roles_id { get; set; }

    }
    public partial class nguoidung_auth : DBNguoidung {
        public string roles { get; set; }
        public string token { get; set; }
        public DateTime? last_login { get; set; }
        public DateTime? last_change_pass { get; set; }
    }
}