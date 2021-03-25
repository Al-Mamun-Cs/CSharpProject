using ConPJ1.DTO;
using ConPJ1.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.MyApp
{
    class AppProducts : IMyApps
    {
        IRepository<Product> repo = new RepoProduct();
        public ActionType Action { get; set; }

        

        public void AboutThisProject()
        {
            
            Console.WriteLine("\n=======Welcome to my first Project====== \nThis Is the project about Product's Information.");
        } 

        public void AddNewItemAction()
        {
            Product obj = new Product();
            Console.Write("Enter a Product Name: ");
            obj.ProductName = Console.ReadLine();


            Console.Write("Enter the Product Price: ");
            obj.Price = int.Parse(Console.ReadLine());

            Console.Write("Enter the Product Quantity");
           obj.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter the Product Buyer");
            obj.Buyer = Console.ReadLine();

            obj = repo.Add(obj);
            Console.WriteLine("\nThe Product is Succesfully added. \nYour Product Id is: {0}", obj.ProductID);
        }

        public void DeleteByIDAction()
        {
            Product obj = new Product();
            Console.Write("Enter a valid ID:");
            int id = int.Parse(Console.ReadLine());
            repo.Remove(id);
            if(repo.Remove(id))
            {
                Console.WriteLine("The Entered Id is Removed");
            }
            else
            {
                Console.WriteLine("The Entered Id is not Here");
            }

        }

        public void DevelopedBy()
        {
            Console.WriteLine("\n\tThe Project is developed by Al-Mamun. \n\tTraineeID  : 1257299.\n\tBatch ID   : ESAD-CS/USSL/44/01.\n\tTspCentre  : US-Software Limited.");
        }

        public void ManageAllAction()
        {
            switch (Action)
            {
                case ActionType.ShowAllData: this.ShowAllDataAction();
                    this.WaitForGoBack();
                    break;
                case ActionType.SearchByName: this.SearchByNameAction();
                    this.WaitForGoBack();
                    break;
                case ActionType.SearchByID: this.SearchByIDAction();
                    this.WaitForGoBack();
                    break;
                case ActionType.AddNewItem: this.AddNewItemAction();
                    this.WaitForGoBack();
                    break;
                case ActionType.UpdateByID: this.UpdateByIDAction();
                    this.WaitForGoBack();
                    break;
                case ActionType.DeleteByID: this.DeleteByIDAction();
                    this.WaitForGoBack();
                    break;
                case ActionType.AboutThisProject:this.AboutThisProject();
                    this.WaitForGoBack();
                    break;
                case ActionType.DevelopedBy:this.DevelopedBy();
                    this.WaitForGoBack();
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Operation");
                    this.WaitForGoBack();
                    break;
            }
        }

        public void ReadMenuSelection()
        {
           try
            {
                string key;
                do
                {
                    Console.Clear();
                    this.ShowMenu();
                    Console.Write("Please Enter a Action Number: [S to Stop]");
                    key = Console.ReadLine();
                    if (key.ToLower() != "S")
                    {
                        Console.Clear();
                        int temp = 0;
                        temp = int.Parse(key);
                        Action = (ActionType)temp;
                        this.ManageAllAction();
                    }
                } while (key.ToLower() != "S"); 
            } 
            catch (Exception ex)
            {

            }
           
        }

        public void SearchByIDAction()
        {
            Console.Write("Enter Product ID");
            int id = int.Parse(Console.ReadLine());
            var data = repo.Get(id);
            if (data != null)
            {
                Console.WriteLine($"{data.ProductID} {data.ProductName} {data.Price} {data.Quantity} {data.Buyer}");
            }
            else if (data == null)
            {
                Console.WriteLine("You enter a invalid ID.");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void SearchByNameAction()
        {
            Console.Write("\nEnter a Product Name:");
            string Name = Console.ReadLine();
            var data = repo.Name(Name);
            if (Name!=null)
            {
                Console.WriteLine($"{data.ProductID} {data.ProductName} {data.Price}{data.Quantity}{data.Buyer}");
            }
            else if (Name==null)
            {
                Console.WriteLine("You enter a invalid ID");
            }
            
        }

        public void ShowAllDataAction()
        {
            
            var items = repo.GetAll();
            foreach (var obj in items)
                Console.WriteLine($"{obj.ProductID} {obj.ProductName} {obj.Price} {obj.Quantity}{obj.Buyer}");
           
         }

        public void ShowMenu()
        {
            
            Array ShowOutput = Enum.GetValues(typeof(ActionType));
            foreach (var En in ShowOutput)
            {
                Console.WriteLine(" " + (int)En + ")" + En );
            }
        }

        public void UpdateByIDAction()
        {
            Console.Write("Press any key to show all data:  ");
            string name = Console.ReadLine();

            Console.Write("Enter the updateable Product ID: ");
            long ID = long.Parse(Console.ReadLine());
            var Data = repo.Get(ID);             
            Console.WriteLine($"{Data.ProductID} {Data.ProductName}  {Data.Price} {Data.Quantity} {Data.Buyer}");


            this.ShowAllDataAction();
            Console.Write("\nDo you want to update ");
            Console.Write("\nPress any key to update...\n");
            this.WaitForGoBack();

            Product obj2 = new Product();
            ConColor obj = new ConColor();
            obj.WriteMessage("Enter a valid ID: ", MessageType.Warning);
            obj2.ProductID = long.Parse(Console.ReadLine());

            obj.WriteMessage("\nEnter your Product Name: ", MessageType.Warning);
            obj2.ProductName = Console.ReadLine();

            obj.WriteMessage("Enter the Product Price: ", MessageType.Warning);
            obj2.Price = int.Parse(Console.ReadLine());

            obj.WriteMessage("Enter the Product Quantity: ", MessageType.Warning);
            obj2.Quantity = int.Parse(Console.ReadLine());

            obj.WriteMessage("\nEnter your Buyer: ", MessageType.Warning);
            obj2.Buyer = Console.ReadLine();


            repo.Update(obj2);
            obj.WriteMessage("\nThe Product is Succesfully Updated.",MessageType.Success);
        }

        public void WaitForGoBack()
        {
            string Back = "";
            do
            {
                Console.WriteLine("\nTo Go Back Press Q  then Enter:");
                Back = Console.ReadLine();
                if (Back.ToLower() != "q")
                {
                    return;
                }
            }
            while (Back.ToLower() != "q");
        }
    }//c
}//ns
