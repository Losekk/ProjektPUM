//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPUM.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhontNumber { get; set; }
        public string ShipCity { get; set; }
        public string ShipStreet { get; set; }
        public string ShipNumber { get; set; }
        public string ShipPostalCode { get; set; }
        public int PaymentMethodID { get; set; }
        public int TransportMethodID { get; set; }
        public int Order_Price { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual TransportMethod TransportMethod { get; set; }
    }
}