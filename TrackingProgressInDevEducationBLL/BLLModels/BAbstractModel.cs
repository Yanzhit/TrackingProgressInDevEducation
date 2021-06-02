using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.BLLModels
{
    public class BAbstractModel
    {
        protected BAbstractModel()
        {
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return -1;
        }
    }
}
