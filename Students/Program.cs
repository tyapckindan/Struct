internal class Program
{
        struct Student
        {
            public string Surname,
                Initials,
                GroupNum;

            public int[] Marks;

            public Student(string surname, string initials, string groupnum, int[] marks)
            {
                Surname = surname;
                Initials = initials;
                GroupNum = groupnum;
                Marks = marks;
            }
        }

    private static void Main(string[] args)
    {
        Student[] students = new Student[7];

        students[0] = new("Бакаев", "А.С.", "22ИТ17", new int[] { 2, 2, 2, 2, 2});
        students[1] = new("Печкин", "М.С.", "23ИТ21", new int[] { 3, 3, 3, 3, 3});
        students[2] = new("Белый", "Ю.Т.", "21ИТ35", new int[] { 5, 5, 5, 5, 5});
        students[3] = new("Чёрный", "И.Д.", "22ИТ35", new int[] { 4, 4, 4, 4, 4});
        students[4] = new("Петров", "В.М.", "22ИТ35", new int[] { 2, 4, 4, 5, 4});
        students[5] = new("Сколкова", "Ю.И.", "23ИТ12", new int[] { 3, 3, 4, 5, 2});
        students[6] = new("Бразова", "Ю.И.", "21ИТ18", new int[] { 2, 5, 5, 5, 4});

        /* Для наглядности
        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Студент группы {students[i].GroupNum} {students[i].Surname} {students[i].Initials} средний балл: {ArifMean(students[i].Marks)}\n");
        }
        */

        for (int i = 0; i < students.Length; i++)
            for (int j = 0; j < students.Length; j++)
                if (ArifMean(students[i].Marks) < ArifMean(students[j].Marks))
                {
                    Student[] buf = new Student[1];
                    buf[0] = students[i];
                    students[i] = students[j];
                    students[j] = buf[0];
                }

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Студент группы {students[i].GroupNum} {students[i].Surname} {students[i].Initials} - ");
            for (int j = 0; j < students[i].Marks.Length; j++)
                Console.Write($"{students[i].Marks[j]} ");
            Console.WriteLine("");
        }
    }

    static double ArifMean(int[] nums)
    {
        double res = 0;
        for (int i = 0; i < nums.Length; i++)
            res += nums[i];
        
        return res / nums.Length;
    }
}