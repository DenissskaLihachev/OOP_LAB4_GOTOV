using System;
using System.Xml.Linq;

namespace My_Libs
{
    public class Person
        {
            private string name { get; }
            private string secondName;
            private string gender;
            private int age;

            public Person()
            {
                this.name = "Name";
                this.secondName = "Second Name";
                this.gender = "Gender";
                this.age = 0;
            }

            public Person(string name, string secondName, string gender, int age)
            {
                this.name = name;
                this.secondName = secondName;
                this.gender = gender;
                this.age = age;
            }

            public void print(Person data)
            {
                Console.WriteLine("Имя: " + name + "\nФамилия: " + secondName + "\nПол: " + gender + "\nВозраст: " + age);
            }

            public override string ToString()
            {
                return name + " " + secondName + " " + gender + " " + age;
            }
        }


    public class ListQueue
    {
        int count = 0;
        internal class Element
        {
            public Person data = null;
            public Element next = null;
        }

        private Element head = null;

        public void add(Person chel)
        {
            Element e = new Element();
            e.data = chel;
            if (head == null)
            {
                head = e;
                count++;
            }
            else
            {
                Element temp = new Element();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = e;
                count++;
            }
        }

        public Person get()
        {
            Element temp = new Element();
            temp = head;
            if (head != null)
            {
                head = head.next;
                return temp.data;
            }
            else
            {
                return null;
            }
        }

        public Person? GetIndex(int index)
        {

            Element? cur = head;
            for (int i = 0; i < count; i++)
            {
                if (index == i)
                {
                    return cur?.data;
                }
                cur = cur?.next;
            }
            return null;
        }

        public void Set(Person? person, int index)
        {

            Element? cur = head;
            for (int i = 0; i < count; i++)
            {
                if (index == i)
                {
                    cur.data = person;
                    return;
                }
                cur = cur?.next;
            }
            return;
        }

        public void GetMassive()
        {
            Print();
            Console.WriteLine("\n\n");
            Sort();
            Print();
        }

        private void Sort()
        {
            int min = 0;
            int max = count - 1;
            int dir = min;
            do
            {
                for (int i = min; i <= max; i++)
                {
                    if (GetIndex(i)?.ToString()[0] > GetIndex(i + 1)?.ToString()[0])
                    {
                        Person? temp = GetIndex(i);
                        Set(GetIndex(i + 1), i);
                        Set(temp, i + 1);
                        dir = i + 1;
                    }
                }
                max = dir;
                for (int i = max; min <= i; i--)
                {
                    if (GetIndex(i)?.ToString()[0] < GetIndex(i - 1)?.ToString()[0])
                    {
                        Person? temp = GetIndex(i);
                        Set(GetIndex(i - 1), i);
                        Set(temp, i - 1);
                        dir = i - 1;
                    }
                }
                min = dir;
            } while (min != max);
        }

        private void Print()
        {
            Element? cur = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(cur?.data?.ToString());
                cur = cur?.next;
            }
        }
    }
}