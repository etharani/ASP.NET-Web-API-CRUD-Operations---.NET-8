namespace Crud_System.Models
{
    public class AddStudent
    {
        public required string StuName { get; set; }
        public string StuAddress { get; set; }
        public decimal? StuSalary { get; set; }
        public int StuAge { get; set; }
    }
}
