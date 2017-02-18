namespace LiveUnitTest
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public double AdjustedGrade { get; set; }

        public double AdjustedGradeByPercentage()
        {
            double curve = ((Grade * 4) / 5) + 20;
            AdjustedGrade = curve;
            return curve;
        }

        public void LogClassAverage()
        {

        }
    }
}
