using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Classes
    {
        private string textIdent ;
        private List<Teachers> teachers;
        private string details;

        public List<Teachers> Teachers { get; set; }
        public string TextIdent { get; set; }
        public string Details { get; set; }

        public Classes (string textIdent, List<Teachers> teachers, string details = null)
        {
            this.TextIdent = textIdent;
            this.Teachers = teachers;
            this.Details = details;
        }
    }
}
