using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.ComponentModel.Design;

namespace StudentCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            ArrayList aspirants = new ArrayList();
            LinkedList<Student> showstudents = new LinkedList<Student>();
            LinkedListNode<Student> student;
            LinkedList<Aspirant> showaspirants = new LinkedList<Aspirant>();
            LinkedListNode<Aspirant> aspirant;
            int count1 = 0;
            int count2 = 0;
            bool Exit = false;
            bool freebase1 = false;
            bool freebase2 = false;
            do
            {
                Console.WriteLine("Меню: \n1.Ввод данных. \n2.Вывод данных о всех студентах. \n3.Вывод данных о всех аспирантах. \n4.Удалить студента или аспиранта.\n5.Сортировка ArrayList. \n6.Выход.\nВведите цифру перед пунктом для перехода в пункт меню.");
                int navigate = InputInfo.InputInt();
                switch (navigate)
                {
                    case 1:
                        {
                            Console.WriteLine("Вы хотите ввести данные аспиранта или студента? \nВведите 1 - для ввода данных студента или 2 - для ввода данных аспиранта.");
                            int case1 = InputInfo.InputNavigate2();
                            switch (case1)
                            {
                                case 1:
                                    {
                                        bool newEnter = false;
                                        do
                                        {
                                            Console.WriteLine("Данные о скольки студентах вы хотите ввести?");
                                            count1 = InputInfo.InputInt();
                                            for (int i = 0; i < count1; i++)
                                            {
                                                students.Add(new Student());
                                            }
                                            freebase1 = true;
                                            Console.WriteLine("Хотите продолжить ввод. Нажмите 1 - для завершения, 2 - для продолжения.");
                                            int select1 = InputInfo.InputNavigate2();
                                            if (select1 == 1)
                                            {
                                                newEnter = true;
                                            }



                                        }
                                        while (newEnter == false);
                                        Console.WriteLine("Для возврата в главное меню нажмите нажмите - 1, для того, чтобы выйти -  2.");
                                        int select = InputInfo.InputNavigate2();
                                        if (select == 2)
                                        {
                                            Exit = true;
                                        }
                                        break;
                                    }
                                case 2:
                                    {

                                        bool newEnter = false;
                                        do
                                        {
                                            Console.WriteLine("Данные о скольки аспирантах вы хотите ввести?");
                                            count2 = InputInfo.InputInt();
                                            for (int i = 0; i < count2; i++)
                                            {
                                                aspirants.Add(new Aspirant());
                                            }
                                            freebase2 = true;
                                            Console.WriteLine("Хотите продолжить ввод. Нажмите 1 - для завершения, 2 - для продолжения.");
                                            int select1 = InputInfo.InputNavigate2();
                                            if (select1 == 1)
                                            {
                                                newEnter = true;
                                            }

                                        }
                                        while (newEnter == false);
                                        Console.WriteLine("Для возврата в главное меню нажмите нажмите - 1, для того, чтобы выйти -  2.");
                                        int select = InputInfo.InputNavigate2();
                                        if (select == 2)
                                        {
                                            Exit = true;
                                        }
                                        break;
                                    }
                            }
                            break;
                        }


                    case 2:
                        {
                            if (freebase1 == true)
                            {
                                foreach (Student s in students)
                                {
                                    s.Display();
                                }
                                Console.WriteLine("Хотите показать студента по его индексу? Введите 1 - если да, 2 - если нет.");
                                int select = InputInfo.InputNavigate2();
                                if (select == 1)
                                {
                                    Console.WriteLine("Для этого введите индекс.");
                                    int identification = InputInfo.InputInt();


                                    if (identification < students.Count && identification >= 0)
                                    {
                                        Student m = (Student)students[identification];
                                        m.Display();
                                        if (students.Count > 1)
                                        {
                                            if (identification >= 0)
                                            {
                                                int nextidentification = 0;
                                                nextidentification += identification;

                                                if (nextidentification < students.Count)
                                                {
                                                    bool Next = false;
                                                    do
                                                    {

                                                        Student f = (Student)students[nextidentification];

                                                        if (nextidentification > 0 && nextidentification < students.Count - 1)
                                                        {
                                                            Student n = (Student)students[nextidentification - 1];
                                                            Student d = (Student)students[nextidentification + 1];

                                                            student = showstudents.AddLast(f);
                                                            showstudents.AddLast(d);
                                                            showstudents.AddFirst(n);
                                                            Console.WriteLine("Показать предыдущего студента - 1 , показать следующего студента - 2, Для выхода - 3.");
                                                            int select3 = InputInfo.InputNavigate1();
                                                            switch (select3)
                                                            {
                                                                case 1:
                                                                    {
                                                                        nextidentification -= 1;

                                                                        if (student.Previous.Value != null)
                                                                        {

                                                                            student.Previous.Value.Display();
                                                                            showstudents.RemoveLast();
                                                                            showstudents.RemoveLast();
                                                                            showstudents.RemoveFirst();
                                                                        }
                                                                        else if (student.Previous.Value == null)
                                                                        {
                                                                            Console.WriteLine("Данных нет.");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Произошла ошибка.");
                                                                            break;
                                                                        }
                                                                        break;
                                                                    }
                                                                case 2:
                                                                    {

                                                                        nextidentification += 1;
                                                                        if (student.Next.Value != null)
                                                                        {
                                                                            student.Next.Value.Display();
                                                                            showstudents.RemoveLast();
                                                                            showstudents.RemoveLast();
                                                                            showstudents.RemoveFirst();

                                                                        }
                                                                        else if (student.Next.Value == null)
                                                                        {
                                                                            Console.WriteLine("Данных нет.");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Произошла ошибка.");
                                                                            break;
                                                                        }
                                                                        break;
                                                                    }
                                                                case 3:
                                                                    {
                                                                        Next = true;
                                                                        break;
                                                                    }


                                                            }
                                                        }

                                                        if (nextidentification == 0)
                                                        {
                                                            Student z = (Student)students[nextidentification + 1];
                                                            student = showstudents.AddFirst(f);
                                                            showstudents.AddLast(z);
                                                            Console.WriteLine("Показать следующего студента - 1, для выхода - 2.");
                                                            int select4 = InputInfo.InputNavigate2();
                                                            if (select4 == 1)
                                                            {
                                                                if (student.Next.Value != null)
                                                                {
                                                                    nextidentification += 1;
                                                                    student.Next.Value.Display();
                                                                    showstudents.RemoveLast();
                                                                    showstudents.RemoveLast();
                                                                }
                                                                else if (student.Next.Value == null)
                                                                {
                                                                    Console.WriteLine("Данных нет.");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Произошла ошибка.");
                                                                    break;
                                                                }
                                                            }
                                                            if (select4 == 2)
                                                            {
                                                                Next = true;

                                                            }
                                                        }
                                                        if (nextidentification == students.Count - 1)
                                                        {
                                                            Student z = (Student)students[nextidentification - 1];
                                                            student = showstudents.AddLast(f);
                                                            showstudents.AddFirst(z);
                                                            Console.WriteLine("Показать предыдущего студента - 1, для выхода - 2.");
                                                            int select4 = InputInfo.InputNavigate2();
                                                            if (select4 == 1)
                                                            {
                                                                nextidentification -= 1;
                                                                if (student.Previous.Value != null)
                                                                {

                                                                    student.Previous.Value.Display();
                                                                    showstudents.RemoveLast();
                                                                    showstudents.RemoveLast();
                                                                }
                                                                else if (student.Previous.Value == null)
                                                                {
                                                                    Console.WriteLine("Данных нет.");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Произошла ошибка.");
                                                                    break;
                                                                }
                                                            }
                                                            if (select4 == 2)
                                                            {
                                                                Next = true;
                                                            }
                                                        }

                                                    }

                                                    while (Next == false);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Следующего студента нет.");
                                                }
                                            }

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Студента под этим индексом не существует.");
                                    }
                                }
                                if (select == 2)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("База пустая.");
                            }

                            Console.WriteLine("Для возврата в главное меню нажмите нажмите - 1, для того, чтобы выйти -  2.");
                            int select2 = InputInfo.InputNavigate2();
                            if (select2 == 2)
                            {
                                Exit = true;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (freebase2 == true)
                            {
                                foreach (Aspirant a in aspirants)
                                {
                                    a.Display();
                                }
                                Console.WriteLine("Хотите показать аспиранта по его индексу? Введите 1 - если да, 2 - если нет.");
                                int select = InputInfo.InputNavigate2();
                                if (select == 1)
                                {
                                    Console.WriteLine("Для этого введите его индекс.");
                                    int identification = InputInfo.InputInt();


                                    if (identification < aspirants.Count && identification >= 0)
                                    {
                                        Aspirant m = (Aspirant)aspirants[identification];
                                        m.Display();
                                        if (aspirants.Count > 1)
                                        {
                                            if (identification >= 0)
                                            {
                                                int nextidentification = 0;
                                                nextidentification += identification;

                                                if (nextidentification < aspirants.Count)
                                                {
                                                    bool Next = false;
                                                    do
                                                    {

                                                        Aspirant f = (Aspirant)aspirants[nextidentification];

                                                        if (nextidentification > 0 && nextidentification < students.Count - 1)
                                                        {
                                                            Aspirant n = (Aspirant)aspirants[nextidentification - 1];
                                                            Aspirant d = (Aspirant)aspirants[nextidentification + 1];

                                                            aspirant = showaspirants.AddLast(f);
                                                            showaspirants.AddLast(d);
                                                            showaspirants.AddFirst(n);
                                                            Console.WriteLine("Показать предыдущего аспиранта - 1 , показать следующего аспиранта - 2, Для выхода - 3.");
                                                            int select3 = InputInfo.InputNavigate1();
                                                            switch (select3)
                                                            {
                                                                case 1:
                                                                    {
                                                                        nextidentification -= 1;

                                                                        if (aspirant.Previous.Value != null)
                                                                        {

                                                                            aspirant.Previous.Value.Display();
                                                                            showaspirants.RemoveLast();
                                                                            showaspirants.RemoveLast();
                                                                            showaspirants.RemoveFirst();
                                                                        }
                                                                        else if (aspirant.Previous.Value == null)
                                                                        {
                                                                            Console.WriteLine("Данных нет.");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Произошла ошибка.");
                                                                            break;
                                                                        }
                                                                        break;
                                                                    }
                                                                case 2:
                                                                    {

                                                                        nextidentification += 1;
                                                                        if (aspirant.Next.Value != null)
                                                                        {
                                                                            aspirant.Next.Value.Display();
                                                                            showaspirants.RemoveLast();
                                                                            showaspirants.RemoveLast();
                                                                            showaspirants.RemoveFirst();

                                                                        }
                                                                        else if (aspirant.Next.Value == null)
                                                                        {
                                                                            Console.WriteLine("Данных нет.");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Произошла ошибка.");
                                                                            break;
                                                                        }
                                                                        break;
                                                                    }
                                                                case 3:
                                                                    {
                                                                        Next = true;
                                                                        break;
                                                                    }


                                                            }
                                                        }

                                                        if (nextidentification == 0)
                                                        {
                                                            Aspirant z = (Aspirant)aspirants[nextidentification + 1];
                                                            aspirant = showaspirants.AddFirst(f);
                                                            showaspirants.AddLast(z);
                                                            Console.WriteLine("Показать следующего аспиранта - 1, для выхода - 2.");
                                                            int select4 = InputInfo.InputNavigate2();
                                                            if (select4 == 1)
                                                            {
                                                                if (aspirant.Next.Value != null)
                                                                {
                                                                    nextidentification += 1;
                                                                    aspirant.Next.Value.Display();
                                                                    showaspirants.RemoveLast();
                                                                    showaspirants.RemoveLast();
                                                                }
                                                                else if (aspirant.Next.Value == null)
                                                                {
                                                                    Console.WriteLine("Данных нет.");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Произошла ошибка.");
                                                                    break;
                                                                }
                                                            }
                                                            if (select4 == 2)
                                                            {
                                                                Next = true;
                                                            }
                                                        }
                                                        if (nextidentification == aspirants.Count - 1)
                                                        {
                                                            Aspirant z = (Aspirant)aspirants[nextidentification - 1];
                                                            aspirant = showaspirants.AddLast(f);
                                                            showaspirants.AddFirst(z);
                                                            Console.WriteLine("Показать предыдущего аспиранта - 1, для выхода - 2.");
                                                            int select4 = InputInfo.InputNavigate2();
                                                            if (select4 == 1)
                                                            {
                                                                nextidentification -= 1;
                                                                if (aspirant.Previous.Value != null)
                                                                {

                                                                    aspirant.Previous.Value.Display();
                                                                    showaspirants.RemoveLast();
                                                                    showaspirants.RemoveLast();
                                                                }
                                                                else if (aspirant.Previous.Value == null)
                                                                {
                                                                    Console.WriteLine("Данных нет.");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Произошла ошибка.");
                                                                    break;
                                                                }
                                                            }
                                                            if (select4 == 2)
                                                            {
                                                                Next = true;
                                                            }
                                                        }

                                                    }

                                                    while (Next == false);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Следующего аспиранта нет.");
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Аспиранта под этим индексом не существует.");
                                    }
                                }
                                if (select == 2)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("База пустая.");
                            }

                            Console.WriteLine("Для возврата в главное меню нажмите нажмите - 1, для того, чтобы выйти -  2.");
                            int select1 = InputInfo.InputNavigate2();
                            if (select1 == 2)
                            {
                                Exit = true;
                            }
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Вы хотите удалить студента или аспиранта. Введите 1 - для удаления студента. 2 - для удаления аспиранта.");
                            int select = InputInfo.InputNavigate2();
                            if (select == 1)
                            {
                                if (freebase1 == true)
                                {
                                    Console.WriteLine("Для этого введите индекс студента.");
                                    int identification = InputInfo.InputInt();
                                    if (students.Contains(students[identification]))
                                    {
                                        students.RemoveAt(identification);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Студента под этим индексом не существует.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("База пустая.");
                                }
                            }
                            else if (select == 2)
                            {
                                if (freebase2 == true)
                                {
                                    Console.WriteLine("Для этого введите индекс аспиранта.");
                                    int identification = InputInfo.InputInt();
                                    if (aspirants.Contains(aspirants[identification]))
                                    {
                                        aspirants.RemoveAt(identification);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Аспиранта под этим индексом не существует.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("База пустая.");
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            ArrayList forint = new ArrayList();
                            Console.WriteLine("Сколько чисел вы хотите ввести.");
                            bool isRight = false;
                            int numcount;
                            do
                            {
                                numcount = InputInfo.InputInt();
                                if (numcount <= 0)
                                {
                                    Console.WriteLine("Количество должно быть больше нуля.");
                                }
                                else
                                {
                                    isRight = true;
                                }
                            }
                            while (isRight == false);
                            for (int i = 0; i < numcount; i++)
                            {
                                Console.WriteLine($"Введите число под номером {i + 1}.");
                                int num = InputInfo.InputInt();
                                forint.Add(num);
                            }
                            forint.Sort();
                            Console.WriteLine("Отсортированный ArrayList:");
                            foreach (object i in forint)
                            {
                                Console.Write(i + "; ");
                            }
                            Console.WriteLine(" ");
                            break;
                        }
                    case 6:
                        {
                            Exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Произошла ошибка.");
                            break;
                        }



                }
            }
            while (Exit == false);

        }
    }
    public abstract class People
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public int Number { get; set; }
        public People()
        {
            Console.WriteLine("Введите имя.");
            Name = InputInfo.InputName();
            Console.WriteLine("Введите курс, на котором учится студент.");
            Course = InputInfo.InputNavigate1();
            Console.WriteLine("Введите номер зачетной книжки.");
            Number = InputInfo.InputInt();
        }
        public abstract void Display();

    }

    class Student : People
    {
        public Student()
            : base()
        {
        }
        public override void Display()
        {
            Console.WriteLine($"Студент {Name}, учится на {Course}-ом курсе, номер зачетной книжки: {Number}.");
        }

    }

    class Aspirant : People
    {
        string CandidateDiss { get; set; }

        public Aspirant()

        {
            Console.WriteLine("Введите название диссертации.");
            CandidateDiss = InputInfo.InputName();
        }
        public override void Display()
        {
            Console.WriteLine($"Студент {Name}, учится на {Course}-ом курсе, номер зачетной книжки: {Number}, {CandidateDiss} - название диссертации.");
        }
    }
    class InputInfo
    {
        public static string InputName()
        {
            string name;
            bool isRight = false;
            do
            {
                name = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        if (name[i] == j.ToString()[0])
                        {
                            isRight = false;
                            count += 1;
                            break;
                        }
                        if (count == 0)
                        {
                            isRight = true;
                        }
                    }
                }
                if (isRight == false)
                {
                    Console.WriteLine("Введите имя, состоящее из букв. Попробуйте снова.");
                }
            }
            while (isRight == false);
            return name;
        }
        public static int InputInt()
        {
            int number;
            bool isRight = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    isRight = true;
                }
                else
                {
                    Console.WriteLine("Введено неверное значение. Попробуйте снова.");
                }
            }
            while (isRight == false);
            return number;
        }
        public static int InputNavigate1()
        {
            int number;
            bool isRight = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0 && number <= 4)
                    {
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите одну из цифр: 1, 2, 3, 4.");
                    }
                }
                else
                {
                    Console.WriteLine("Введено неверное значение. Попробуйте снова.");
                }
            }
            while (isRight == false);
            return number;

        }
        public static int InputNavigate2()
        {
            int number;
            bool isRight = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0 && number <= 2)
                    {
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите: 1 или 2");
                    }
                }
                else
                {
                    Console.WriteLine("Введено неверное значение. Попробуйте снова.");
                }
            }
            while (isRight == false);
            return number;
        }

    }
}