using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFCHell
{
    class Program
    {
        static void Main(string[] args)
        {

            PeopleAdmin[] ts = inputPeopleAdmin();
            employee[] em = inputemployee();
            foodDelivery[] fd = inputfoodDelivery();
            KFCStore k1 = new KFCStore("KFC Surin", "Surin", ts, em, fd);


            int numInput = 0;
            int key;
            do
            {
                MeneGet();
                Console.Write(" :");
                key = int.Parse(Console.ReadLine());
                Choose(key, ts, em, fd, k1);


            } while (numInput != -1);

            Console.ReadKey();




        }
        public static void Choose(int menu, PeopleAdmin[] ts, employee[] em, foodDelivery[] fd, KFCStore k1)
        {
            if (menu == 1)
            {
                StoreInfo(k1);
            }
            if (menu == 2)
            {
                Printfoundingmembers(ts);
            }
            if (menu == 3)
            {
                PrintALLmembers(em, fd);
            }
            if (menu == 4)
            {
                print4();
            }
        }

        public static void MeneGet()
        {
            Console.WriteLine("---------Menu---------");
            Console.WriteLine("1.Store Information");
            Console.WriteLine("2.Founder");
            Console.WriteLine("3.Employer information");
            Console.WriteLine("4.Income and expenses information");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Exit input -1");
        }
        public static PeopleAdmin[] inputPeopleAdmin()
        {
            Console.WriteLine("founding members");
            PeopleAdmin[] ts = new PeopleAdmin[3];

            int i = 0;
            while (i < ts.Length)
            {
                Console.WriteLine("name ,surname ,id");
                PeopleAdmin TS = new PeopleAdmin(InputString(), InputString(), InputString());
                ts[i] = TS;
                i++;
            }

            return ts;
        }
        public static employee[] inputemployee()
        {
            employee[] em = new employee[3];

            int j = 0;
            while (j < em.Length)
            {

                Console.WriteLine("shop staff : name ,surname ,age,salary");
                Console.WriteLine("********************************************************");
                employee EM = new employee(InputString(), InputString(), InputInt(), InputInt());
                Console.WriteLine("********************************************************");
                em[j] = EM;
                j++;
            }
            return em;
        }

        public static foodDelivery[] inputfoodDelivery()
        {
            foodDelivery[] fd = new foodDelivery[2];
            int k = 0;
            while (k < fd.Length)
            {

                Console.WriteLine("shop delivery: name ,surname ,age,salary");
                Console.WriteLine("********************************************************");
                foodDelivery FD = new foodDelivery(InputString(), InputString(), InputInt(), InputInt());
                Console.WriteLine("********************************************************");
                fd[k] = FD;
                k++;
            }

            return fd;
        }

        public static void Printfoundingmembers(PeopleAdmin[] ts)
        {
            int i = 0;
            while (i < ts.Length)
            {
                Console.WriteLine("{0} {1} {2}", ts[i].nameAdmin, ts[i].surnameAdmin, ts[i].id_admin);
                i++;
            }

        }

        public static void StoreInfo(KFCStore ks)
        {
            Console.WriteLine("Registered capital 1 million baht");
            Console.WriteLine("{0} {1} {2}", ks.moneyValue, ks.branchShopName, ks.LocalStore);

        }

        public static void PrintALLmembers(employee[] em, foodDelivery[] fd)
        {
            int i = 0;
            while (i < em.Length)
            {
                Console.WriteLine(" store staff {0} {1} {2} {3}", em[i].nameEmploy, em[i].SurnameEmploy, em[i].ageEmloy, em[i].SalaryEmploy);
                i++;
            }


            int j = 0;
            while (j < 2)
            {
                Console.WriteLine(" food delivery man {0} {1} {2} {3}", fd[j].nameDelivery, fd[j].SurnameDelivery, fd[j].ageDelivery, fd[j].SalaryDelivery);
                j++;
            }

        }

        public static void print4()
        {
            KFC4 k1 = new KFC4();
            Console.WriteLine("Total revenue {0},Total expenses {1} Total Balance {2}", k1.revenue, k1.expenses, k1.balance);
        }



        public static string InputString()
        {
            Console.Write("Input String: ");

            return Console.ReadLine();
        }
        public static float InputFloat()
        {
            Console.Write("Input float: ");
            string price = Console.ReadLine();

            if (float.TryParse(price, out float number))
            {
                return number;
            }

            throw new Exception("Please input decimal data.");
        }
        public static int InputInt()
        {
            Console.Write("Input int: ");
            string price = Console.ReadLine();

            if (int.TryParse(price, out int number))
            {
                return number;
            }

            throw new Exception("Please input decimal data.");
        }


    }

    class ExcuteKFC1
    {
        public int storeSales = 127;
        public int AllDelivery = 367;

        public int[] storeSales_Time; //จำนวนยอดขายหน้าร้าน ครั้ง
        public int[] storeCalculate; //จำนวนยอดขายหน้าร้าน (บาท)
        public int[] storeDelivery_Time; //จำนวนยอด Delivery (ครั้ง)
        public int[] deliveryCalculate; //จำนวนยอด Delivery รวมค่าจัดส่ง (บาท)

        //รวมยอด
        public int All_storeTime; //จำนวนยอดขายหน้าร้าน ครั้ง
        public int All_storeSales; //จำนวนยอดขายหน้าร้าน (บาท)
        public int All_DeliveryTime; //จำนวนยอด Delivery (ครั้ง)
        public int All_Delivery_Calculate; //จำนวนยอด Delivery รวมค่าจัดส่ง (บาท)

        public ExcuteKFC1(int[] storeSales_Time, int[] storeDelivery_Time)
        {
            this.storeSales_Time = storeSales_Time;
            this.storeDelivery_Time = storeDelivery_Time;


        }

        public void CalculateInMonth() //จำนวนยอดขายหน้าร้าน
        {
            for (int i = 0; i < storeSales_Time.Length; i++)
            {
                storeCalculate[i] = storeSales_Time[i] * 127;
                All_storeSales += storeCalculate[i];
            }
        }


        public void CalculateInMonthDelivery() //จำนวนยอดขายหน้าร้าน
        {
            for (int i = 0; i < storeDelivery_Time.Length; i++)
            {
                deliveryCalculate[i] = storeDelivery_Time[i] * 357;
                All_Delivery_Calculate += deliveryCalculate[i];
            }
        }

    }

    class PeopleAdmin
    {
        public string nameAdmin = "";
        public string surnameAdmin = "";
        public string id_admin = "";

        public PeopleAdmin(string nameAdmin, string surnameAdmin, string id_admin)
        {
            this.nameAdmin = nameAdmin;
            this.surnameAdmin = surnameAdmin;
            this.id_admin = id_admin;
        }

    }

    class employee
    {
        public string nameEmploy = "";
        public string SurnameEmploy = "";
        public int ageEmloy;
        public int SalaryEmploy;

        //public int travelEx;
        //public int salesShare;

        public employee(string nameEmploy, string SurnameEmploy, int ageEmloy, int SalaryEmploy)
        {
            this.nameEmploy = nameEmploy;
            this.SurnameEmploy = SurnameEmploy;
            this.ageEmloy = ageEmloy;
            this.SalaryEmploy = SalaryEmploy;
        }
    }

    class foodDelivery
    {
        public string nameDelivery = "";
        public string SurnameDelivery = "";
        public int ageDelivery;
        public int SalaryDelivery;

        /*
        public int travelEx;
        public int salesShare;
        public int Cost_foreach_food; */

        public foodDelivery(string nameDelivery, string SurnameDelivery, int ageDelivery, int SalaryDelivery)
        {
            this.nameDelivery = nameDelivery;
            this.SurnameDelivery = SurnameDelivery;
            this.ageDelivery = ageDelivery;
            this.SalaryDelivery = SalaryDelivery;
        }

    }

    class KFCStore
    {
        public int moneyValue = 1000000;
        public string branchShopName = "";
        public string LocalStore = "";
        public PeopleAdmin[] peopleAdmin = new PeopleAdmin[3];
        public employee[] emClass = new employee[5];
        public foodDelivery[] emDelivery = new foodDelivery[2];


        public KFCStore(string branchShopName, string LocalStore, PeopleAdmin[] peopleAdmin, employee[] emClass, foodDelivery[] emDelivery)
        {
            this.branchShopName = branchShopName;
            this.LocalStore = LocalStore;
            this.peopleAdmin = peopleAdmin;
            this.emClass = emClass;
            this.emDelivery = emDelivery;

        }

    }

    public class KFC4
    {
        public int revenue;
        public int expenses;
        public int balance;

        public KFC4()
        {
            revenue = 236154;
            expenses = 213069;
            balance = 23084;
        }
    }
}
