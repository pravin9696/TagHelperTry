using Humanizer;

namespace TagHelperTry.Models
{
    public class Languages
    {
        public string ID { get; set; }
        public string Lang { get; set; }
    }
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnumGender Gender { get; set; }
        public int Age { get; set; }
        public String Designation { get; set; }
        public int Salary { get; set; }
        public String Married { get; set; }
        public string  Description { get; set; }
    }
    public enum EnumGender
    {
        Male,Female,Trans
    }
}
