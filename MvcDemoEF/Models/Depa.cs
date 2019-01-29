using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemoEF.Models
{
    [MetadataType(typeof(DepartmentMeataData))]
    public partial class Dept
    {

    }

    public class DepartmentMeataData
    {
        [Display(Name="Department Name")]
        public string DeptName { get; set; }
    }
}