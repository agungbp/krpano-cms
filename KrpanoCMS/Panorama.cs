//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KrpanoCMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Panorama
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string UserId { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string PictureUrl { get; set; }
    }
}
