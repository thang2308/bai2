using System;
using System.Collections.Generic;
using System.Linq;

namespace baitaptuan2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "An", 16),
                new Student(2, "Khanh", 18),
                new Student(3, "Tien", 14),
                new Student(4, "Dat", 14),
                new Student(5, "Thang", 20)
            };

            PrintStudents("Danh sach tat ca học sinh:", students);

            // b. Tìm và in ra danh sách học sinh có tuổi từ 15 đến 18
            var ageGroup = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            PrintStudents("Danh sach hoc sinh tu 15 den 18:", ageGroup);

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var studentsStartingWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            PrintStudents("Danh sach  A:", studentsStartingWithA);

            // d. Tính tổng tuổi của tất cả học sinh
            int totalAge = students.Aggregate(0, (sum, student) => sum + student.Age);
            Console.WriteLine($"TTong tuoi cua cac hoc sinh: {totalAge}\n");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"Hoc sinh co tuoi lon nhat: {oldestStudent}\n");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra kết quả
            var sortedByAge = students.OrderBy(s => s.Age).ToList();
            PrintStudents("Danh sach hoc sinh tuoi tang dan:", sortedByAge);

            Console.ReadLine();
        }

        // Phương thức in danh sách học sinh
        static void PrintStudents(string message, List<Student> students)
        {
            Console.WriteLine(message);
            if (students.Any())
            {
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Khong co hoc sinh nao.");
            }
            Console.WriteLine();
        }
    }
}
