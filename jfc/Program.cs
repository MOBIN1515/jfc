using jfc;

using var db = new AppDbContext();

var course = new Course1 { Title = "Physics" };
db.Courses.Add(course);
db.SaveChanges(); 

var student = new Student1{ Name = "Mobin", Age = 21, CourseId = course.Id};

db.Students.Add(student);
db.SaveChanges();

