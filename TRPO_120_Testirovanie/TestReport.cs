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
    
    public partial class TestReport
    {
        public int ID { get; set; }
        public System.DateTime TestDate { get; set; }
        public int StudentID { get; set; }
        public int QuestionID { get; set; }
        public string Answer { get; set; }
        public int SpentTime { get; set; }
        public int QuestionsAmount { get; set; }
        public Nullable<int> CorrectAmount { get; set; }
        public Nullable<int> StudentMark { get; set; }
    
        public virtual StudenInformation StudenInformation { get; set; }
        public virtual TestQInformation TestQInformation { get; set; }
    }
}