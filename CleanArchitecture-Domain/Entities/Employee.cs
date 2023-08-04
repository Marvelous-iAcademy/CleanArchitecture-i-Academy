using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture_Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        [ForeignKey(nameof(Company))]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
