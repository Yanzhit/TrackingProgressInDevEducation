using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Comment
{
    public class SetCommentsA : ADTOAnswer
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int? StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int? TeamId { get; set; }
        public int? Estimation { get; set; }

        public SetCommentsA()
        {
        }


    }
}
