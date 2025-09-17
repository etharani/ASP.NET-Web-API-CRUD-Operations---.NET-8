namespace Crud_System.Models.Entities
{
    public class student
    {
        public Guid Id { get; set; }//Globally Unique Identifier
        public required string StuName { get; set;}
        public string StuAddress { get; set;}
        public decimal? StuSalary { get; set;}
        public int StuAge { get; set;}
    }
}
