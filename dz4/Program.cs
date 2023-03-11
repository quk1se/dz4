using Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        private string name;
        private string surname;
        private string lastName;
        private string phone;
        private string adress;
        private DateTime birthday;
        private List<Int32> homeworkMarks;
        private List<Int32> creditMarks;
        private List<Int32> examMarks;

        //Constructor without parameters
        public Student()
        {
            setName("Sasha");
            setSurname("Kalyan");
            setLastName("Vitalievich");
            setPhone("9229103");
            setAdress("6353 Juan Tabo");
            setBirthday(DateTime.Now);
            homeworkMarks = new List<Int32>() { 4, 4, 5, 4 };
            creditMarks = new List<Int32>() { 3, 4, 4, 5 };
            examMarks = new List<Int32>() { 5, 5, 5, 3 };
        }

        //Constructor with parameters
        public Student(string name, string surname, string lastName, string phone, string adress, DateTime birthday, List<Int32> homework, List<Int32> credit, List<Int32> exam)
        {
            setName(name);
            setSurname(surname);
            setLastName(lastName);
            setPhone(phone);
            setAdress(adress);
            setBirthday(birthday);
            setHomeworkMarks(homework);
            setCreditMarks(credit);
            setExamsMarks(exam);
        }

        #region Setters
        public void setName(string name) { this.name = name; }
        public void setSurname(string surname) { this.surname = surname; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setPhone(string phone) { this.phone = phone; }
        public void setAdress(string adress) { this.adress = adress; }
        public void setBirthday(DateTime birthday) { this.birthday = birthday; }
        public void setHomeworkMarks(List<Int32> marks) { this.homeworkMarks = marks; }
        public void setCreditMarks(List<Int32> marks) { this.creditMarks = marks; }
        public void setExamsMarks(List<Int32> marks) { this.examMarks = marks; }
        #endregion
        #region Getters
        public string getName() { return this.name; }
        public string getSurname() { return this.surname; }
        public string getLastName() { return this.lastName; }
        public string getPhone() { return this.phone; }
        public string getAdress() { return this.adress; }
        public DateTime getBirthday() { return this.birthday; }
        #endregion
        //Show marks
        public void showMarks()
        {
            Console.Write("Homework marks: ");
            for (int i = 0; i < homeworkMarks.Count; i++)
            {
                Console.Write(homeworkMarks[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Credit marks: ");
            for (int i = 0; i < creditMarks.Count; i++)
            {
                Console.Write(creditMarks[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Exams marks: ");
            for (int i = 0; i < examMarks.Count; i++)
            {
                Console.Write(examMarks[i] + " ");
            }
            Console.WriteLine();
        }

        //Show info
        public override string ToString()
        {
            return "Name: " + name + "\n" + "Surname: " + surname + "\n" + "Last name: " + lastName + "\n" +
                "Phone: " + phone + "\n" + "Adress: " + adress + "\n" + "Birthday: " + birthday + "\n";
        }

    }
}


namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //New object 1
            Student st = new Student();
            Console.WriteLine(st);
            st.showMarks();
            Console.WriteLine("=============================================================");

            //Random marks
            List<Int32> hwMarks = new List<Int32>() { 5, 5, 2, 4 };
            List<Int32> creditMarks = new List<Int32>() { 4, 1, 3, 2 };
            List<Int32> examMarks = new List<Int32>() { 4, 4, 3, 5 };

            //New object 2
            Student st2 = new Student("Jesse", "Pinkman", "Bruce", "1483369", "9809 Margo Street", DateTime.Now.AddYears(2),hwMarks,creditMarks,examMarks);
            Console.WriteLine(st2);
            st2.showMarks();

            Console.Read();
        }
    }
}
