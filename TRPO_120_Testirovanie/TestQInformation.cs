//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRPO_120_Testirovanie
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestQInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestQInformation()
        {
            this.TestReport = new HashSet<TestReport>();
        }
    
        public int ID { get; set; }
        public int QuestTypeID { get; set; }
        public string Question { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Variant3 { get; set; }
        public string Variant4 { get; set; }
        public string CorrAnswer { get; set; }
    
        public virtual QuestType QuestType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestReport> TestReport { get; set; }
    }
}