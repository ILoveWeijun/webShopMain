//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class db_OrderInfo
    {
        public int Id { get; set; }
        public int UserAddressId { get; set; }
        public string userName { get; set; }
        public double priceTote { get; set; }
        public double SalePriceTote { get; set; }
        public System.DateTime createTime { get; set; }
        public int orderStateId { get; set; }
        public int MoneyType { get; set; }
        public string PostName { get; set; }
        public double PostMoney { get; set; }
        public Nullable<System.DateTime> sendDate { get; set; }
        public Nullable<System.DateTime> payDate { get; set; }
    
        public virtual db_UserAddressInfo db_UserAddressInfo { get; set; }
    }
}