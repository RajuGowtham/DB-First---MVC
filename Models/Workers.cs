using System.ComponentModel.DataAnnotations;

namespace CodeFirstApplication.Models
{
    public class Workers
    {
            [Key]
            public int workerId { get; set; }
            public string workerName { get; set; }
            public string Role { get; set; }
            public decimal DailyCost { get; set; }
    }
}
