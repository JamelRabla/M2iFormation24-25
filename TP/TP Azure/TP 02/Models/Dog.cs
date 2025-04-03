using System.ComponentModel.DataAnnotations;

namespace Exercice04.Models
{
    public class Dog
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Breed { get; set; }
        [Range(0, 50)]
        public int Age { get; set; }
    }
}
