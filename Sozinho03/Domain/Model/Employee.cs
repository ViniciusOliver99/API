using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sozinho03.Domain.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int     id       { get; set; }
        public string  name     { get; set; }
        public int     age      { get; set; }
        public string? photo    { get; set; }
        public bool    activen  { get; set; }


        public Employee(string name, int age, string photo) 
        {
            this.name = name;
            this.age = age;
            this.photo = photo;
            this.activen = true;
        }

        public void Up(string name, int age, string photo)
        {
            this.name = name;
            this.age = age;
            this.photo = photo;
            this.activen = true;
        }

        public void Disable()
        {
            this.activen = false;
        }
    }
}
