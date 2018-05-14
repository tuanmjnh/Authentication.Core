namespace Authentication.Core {
    using System.ComponentModel.DataAnnotations.Schema;
    [Table ("Roles")]
    public partial class Roles {
        //public string TABLE_CATALOG { get; set; }

        public enum RoleMethod {
            GET = 1,
            POST = 2,
            PUT = 3,
            DELETE = 4,
        }
        public enum RoleAction {
            SELECT = 1,
            INSERT = 2,
            UPDATE = 3,
            DELETE = 4,
            VERIFY = 5,
            REMOVE = 6
        }

        public const string Allow = "ALLOW";
        //Static
        public const string superadmin = "187eb627-0a7b-44a8-83c4-ceb4829709a3";
        public const string admin = "ee82e7f1-592c-4f5c-95fa-7cad30b14a2d";
        public const string managerBill = "114EE7A8-29AF-4CC5-ACC8-1C12456F0755";
        public const string mod = "238391cd-990d-4f3b-8d0c-0300416f9263";
        public const string director = "121ab8e5-1ad2-4b78-8ff2-4d953c9b71a8";
        public const string manager = "3a32dc87-eb43-45f0-9bea-fb9030afeaf0";
        public const string leader = "d0443498-09c4-4267-a7c9-2a20dde8e925";
        public const string staff = "dc67601d-ad74-4813-8293-8d4a07db1d31";
    }
}