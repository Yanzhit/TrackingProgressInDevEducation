using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Comment
{
    public class GetCommentsByStudentA : ADTOAnswer
    {
        public string Text { get; set; }
        public int Estimation { get; set; }

        public GetCommentsByStudentA()
        {
        }

        public GetCommentsByStudentA(int id, string text, int estimation)
        {
            Id = id;
            Text = text;
            Estimation = estimation;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetCommentsByStudentA)obj);
        }

        private bool Equals(GetCommentsByStudentA other)
        {
            return Id == other.Id
                   && Text == other.Text
                   && Estimation == other.Estimation;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Text, Estimation);
        }
    }
}
