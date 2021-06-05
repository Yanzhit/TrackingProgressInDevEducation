using System;

namespace TrackingProgressInDevEducationUI
{
    public class GenVerification
    {
        public int GenerateKey()
        {
            Random random = new();
            return random.Next(1000, 9999);
        }
    }
}