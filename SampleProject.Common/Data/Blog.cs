//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject.Common.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int Id { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ViewCount { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
