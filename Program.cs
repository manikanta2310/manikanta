using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Demo
{
    class Server
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public Server()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        public void AddClient()
        {
            int L = 0;
            Server names = new Server();

            names[0] = "mani";
            names[1] = "viswa";
            names[2] = "dineesh";
            names[3] = "Eswar";
            names[4] = "Sanju";
            names[5] = "Hari";
            Console.WriteLine("Names added");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public void Code()
        {
            Console.WriteLine("Enter the Code to view the Subscriber");
            int code = Convert.ToInt32(Console.ReadLine());
            if (code == 762931)
            {
                SubsPresent();
            }
            else
            {
                Console.WriteLine("INVALID CODE");
            }
        }
        public void SubsPresent()
        {

            for (int i = 0; i < Server.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public void SubsRemove()
        {
            Console.WriteLine("Enter the index of the name to be removed");
            int indx = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Server.size; i++)
            {
                while (i == indx)
                {
                    names[indx] = "Removed Recently";
                    break;
                }
            }
            for (int i = 0; i < Server.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
    class client
    {

    }
    class ViewSubs
    {

    }
    class RemoveClient
    {

    }
    class Program
    {
        public void choice()
        {
            Console.WriteLine("Enter 1 to Register Client\nEnter 2 to Veiw Client\nEnter 3 to Remove Client\nEnter 4 to check user present or not");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch ((choice))
            {
                case 1:
                    names.AddClient();
                    break;
                case 2:
                    v.Code();
                    break;
                case 3:
                    v.SubsRemove()
                        break;
                default:
                    break;
            }
        }

        public static void Main(string[] args)
        {
            int i = 1;
            while (i == 1)
            {
                Program p = new Program();
                p.choice();
                Console.ReadLine();
            }

        }
    }
}