using OOP;

var preson1 = new Preson();//Đối tượng preson1 được tạo từ lớp Preson
//preson1.SetName("Nguyen Van A"); //Gọi phương thức SetName để đặt tên cho đối tượng
preson1.Name = "Nguyen Van A"; //Truy cập trực tiếp vào thuộc tính Name để đặt tên
preson1.SayName(); //Gọi phương thức SayName để in tên


var preson2 = new Preson("Jane Doe", 25);
preson2.SayName(); // In ra tên của preson2

Console.Read();