using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Common
{
    public class EntityValidationsConstants
    {
        public static class TrainingProgram
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;

            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 10;

            public const int ImageUrlMaxLength = 2048;
            public const int ImageUrlMinLength = 4;

            public const string PriceMaxValue = "1000";
            public const string PriceMinValue = "0";

            public const string DurationInWeeksMaxLength = "52";
            public const string DurationInWeeksMinLength = "1";
        }

        public static class Category
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
        }

        public static class Coach
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 5;

            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 5;

            public const int BioMaxLength = 1000;
            public const int BioMinLength = 10;

            public const int PhoneNumberMaxLength = 15;
            public const int PhoneNumberMinLength = 7;

        }
    }
}
