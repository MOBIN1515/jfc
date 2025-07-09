
using System.ComponentModel.DataAnnotations.Schema;

namespace jfc;
[Table("Course45")]
public class Course1
{
    public int Id { get; set; }

    public string Title { get; set; }

    public List <Student1> Students { get; set; } = new();


}
