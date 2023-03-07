namespace Week7Homework6Q1Q2;

class MainClass
{
    
    public static void Main(string[] args) 
  {
        Professor p1 = new Professor();
        p1.prof_name = "Alice";
        p1.class_teach = "Java";
        p1.SetSalary(9000);
    
        Professor p2 = new Professor();
        p2.prof_name = "Bob";
        p2.class_teach = "Math";
        p2.SetSalary(8000);

        Student s1 = new Student();
        s1.stu_name = "Lisa";
        s1.class_enroll = "Java";
        s1.SetGrade(90);

        Student s2 = new Student();
        s2.stu_name = "Tom";
        s2.class_enroll = "Math";
        s2.SetGrade(80);

        double sal_diff;
        double tot_grade;

        sal_diff = (p1.GetSalary() - p2.GetSalary());
        tot_grade = (s1.GetGrade() + s2.GetGrade());

        Console.WriteLine($"Professor {p1.prof_name} teaches {p1.class_teach}, and the salary is {p1.GetSalary()}");
        Console.WriteLine($"Professor {p2.prof_name} teaches {p2.class_teach}, and the salary is {p2.GetSalary()}");  
        Console.WriteLine($"Student {s1.stu_name} enrolls {s1.class_enroll}, and the grade is {s1.GetGrade()}");
        Console.WriteLine($"Student {s2.stu_name} enrolls {s2.class_enroll}, and the grade is {s2.GetGrade()}"); 
        Console.WriteLine($"The salary difference between Alice and Bob is: {sal_diff}");
        Console.WriteLine($"The total grade for Lisa and Bob is: {tot_grade}");
  }
  
    class Professor
  {
        public string? prof_name = null;
        public string? class_teach = null;
        private double salary;
        public void SetSalary(double salary_amount)
    {
      this.salary = salary_amount;
    }  
       public double GetSalary()
    {
        return this.salary;
    }   
  
  }

    class Student
  {
      public string? stu_name = null;
      public string? class_enroll = null;
      private double grade;
      public void SetGrade(double grade_points)
    {
      this.grade = grade_points;
    }
      public double GetGrade()
     {
      return this.grade;
     }
  }   

}
