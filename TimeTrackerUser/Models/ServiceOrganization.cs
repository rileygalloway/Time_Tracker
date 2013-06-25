using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeTrackerUser.Models
{
    public class ServiceOrganization
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string OrganizationName { get; set; }
    }
}