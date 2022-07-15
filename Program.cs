using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionExercise
{
    public class Program
    {
        public static void DisplayPublicProperties()
        {
            Student student = Activator.CreateInstance<Student>();
            
            PropertyInfo[] informationProp = student.GetType().GetProperties(); 
            

            Console.WriteLine("____PUBLIC PROPRERTIES____");

            foreach (var prop in informationProp)
            {
                Console.WriteLine(prop.Name);
            }
        }

        public static void CreateInstance()
        {
            Student student = Activator.CreateInstance<Student>();

            PropertyInfo[] createNewInformation = student.GetType().GetProperties();

            Console.WriteLine("___STUDENT LIST___");

            foreach(var create in createNewInformation)
            {
                if (create.Name == "Name") create.SetValue(student, "Pedro Almeida Cardoso");
                if (create.Name == "University") create.SetValue(student, "UFRPE");
                if (create.Name == "RollNumber") create.SetValue(student, 815879);
            }
            student.DisplayInfo();

            foreach (var create in createNewInformation)
            {
                if (create.Name == "Name") create.SetValue(student, "Júlia Constatinopla");
                if (create.Name == "University") create.SetValue(student, "UFAL");
                if (create.Name == "RollNumber") create.SetValue(student, 254697);
            }
            student.DisplayInfo();

        }

        static void Main(string[] args)
        {
            DisplayPublicProperties();
            Console.WriteLine("");
            CreateInstance();
        }
    }
}