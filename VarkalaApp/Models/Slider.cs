using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarkalaApp.Models
{
    public class Slider
    {
        public int SliderId { get; set; }
        public string FirstSlogan { get; set; }
        public string SecondSlogan { get; set; }
        public string ThirdSlogan { get; set; }
        public string SloganButon { get; set; }
        public string Image { get; set; }
        public string Active { get; set; }
    }
}
