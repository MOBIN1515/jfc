


using jfc;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Student1")]
public class Student1
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public int CourseId { get; set; }
    public Course1 Course { get; set; }
}

