//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMP_PR11.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane()
        {
            this.ApplicationForTheConditionOfTheAircraft = new HashSet<ApplicationForTheConditionOfTheAircraft>();
        }
    
        public int PlaneID { get; set; }
        public string PlaneName { get; set; }
        public string Model { get; set; }
        public int QuantityOfSeats { get; set; }
        public int NumberOfUnitsInThePark { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public int Wingspan { get; set; }
        public int CruisingSpeed { get; set; }
        public int MaximumFlightAltitude { get; set; }
        public int MaximumFlightRange { get; set; }
        public int SupplierId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationForTheConditionOfTheAircraft> ApplicationForTheConditionOfTheAircraft { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual TicketInfo TicketInfo { get; set; }
    }
}
