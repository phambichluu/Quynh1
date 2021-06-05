using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUYNH.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [AllowHtml]
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
    }
}