using System;
using System.Collections.Generic;

namespace ostad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            teacher te = new teacher();
            string answer;
            int idd;

            do
            {
                System.Console.WriteLine(" add  /  del  / vir  /  yes  / no");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "add":
                        te.Add();
                        te.print();
                        break;
                    case "del":

                        System.Console.WriteLine("enter id for delete");
                        idd = int.Parse(Console.ReadLine());
                        te.delete(idd);
                        te.print();
                        break;
                    case "vir":
                        System.Console.WriteLine("enter id for edit");
                        idd = int.Parse(Console.ReadLine());
                        te.virayesh(idd);
                        te.print();
                        break;

                   
                }
                System.Console.WriteLine(" do you want continue y/n");
                answer = Console.ReadLine();

            } while (answer=="yes"|| answer=="y"||answer=="Y");

        }
    }
    abstract class process
    {
        public abstract string Add();
        public abstract bool delete(int id);
        public abstract bool virayesh(int id);
        public abstract void print();


    }
    class teacher : process
    {
        public string name;
        public string phone;
        public int id;
        static List<teacher> teach = new List<teacher>();
        static int count = 1;
        public override string Add()
        {

            string check;
            do
            {
                teacher t = new teacher();
                t.id = count;
                System.Console.WriteLine("name"+count);
                t.name = Console.ReadLine();
                System.Console.WriteLine("phone"+count);
                t.phone = Console.ReadLine();
                teach.Add(t);
                count++;
                System.Console.WriteLine("do you want to continue y or n");

                check = Console.ReadLine();




            } while (check == "y");
            return "add shod";
        }

        public override bool delete(int id)
        {

            foreach (var item in teach)
            {
                if (item.id == id)
                {
                    teach.Remove(item);

                    return true;
                }
            }


            return false;


        }

        public override bool virayesh(int id)
        {
            foreach (var item in teach)
            {
                if (item.id == id)
                {
                    System.Console.WriteLine("name");
                    item.name = Console.ReadLine();
                    System.Console.WriteLine("phone");
                    item.phone = Console.ReadLine();

                    return true;
                }
            }

            return false;
        }

        public override void print()
        {
            foreach (var item in teach)
            {
                System.Console.WriteLine(item.id+"--"+item.name+"--"+item.phone);  
            }
        }


    }
}

