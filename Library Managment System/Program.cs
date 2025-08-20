using LibraryManagmentSystem;


Book book1 = new Book("Clean Code", "Mark Skeet");
Book book2 = new Book("C# Basics", "John Doe");

TeacherMember teacher = new TeacherMember("Ahmad", 123456);
StudentMember student = new StudentMember("Khalid", 112233);

teacher.BorrowBook(book1);
student.BorrowBook(book2);

Console.WriteLine($"Is {book1.getTitle()} Borrowed ? {book1.GetIsBorrowed()}.");
Console.WriteLine($"Is {book2.getTitle()} Borrowed ? {book2.GetIsBorrowed()}.");

int studentLateDays = 4;
int teacherLateDays = 3;

student.Returnbook(book2);
double studentFee = student.CalculateLateFee(studentLateDays);
Console.WriteLine($"Student {student.name} is late {studentLateDays} days to return {book2.getTitle()} the cost is : {studentFee} JOD");

teacher.Returnbook(book1);
double teacherFee = teacher.CalculateLateFee(teacherLateDays);
Console.WriteLine($"Techer {teacher.name} is late {teacherLateDays} days to return {book1.getTitle()} the cost is : {teacherFee} JOD");
