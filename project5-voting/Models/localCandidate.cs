//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project5_voting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class localCandidate
    {
        public long id { get; set; }
        public string candidateName { get; set; }
        public string election_area { get; set; }
        public string email { get; set; }
        public string national_id { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> birth_day { get; set; }
        public string religion { get; set; }
        public string typeOfChair { get; set; }
        public string listName { get; set; }
        public Nullable<long> counter { get; set; }
        public string img { get; set; }
        public Nullable<long> listKey { get; set; }
        public virtual localList localList { get; set; }
      
    }
    public class LocalCandidatesGroupedViewModel
    {
        public string ListName { get; set; }
        public List<localCandidate> Candidates { get; set; }
    }
}
