using HomeWork4.Class;

namespace HomeWork4
{
    public class Menu
    {
        public void MenuEmployee()
        {
            try
            {
                Console.WriteLine("Enter first employee salary: ");
                int salwork = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second employee salary: ");
                int secondSalwork = Convert.ToInt32(Console.ReadLine());

                SalaryEmployee workerSalary = new(salwork);
                Employee worker = new(1, "Vasya", "Kykorey", "3809741254", "VasyaKykareky@gmail.com", workerSalary.Salary);

                SalaryEmployee secondWorkerSalary = new(secondSalwork);
                Employee secondWorker = new(1, "Petya", "Kazanov", "3809874512", "PetyaMan@gmail.com", secondWorkerSalary.Salary);


                worker.InfoEmployee();
                secondWorker.InfoEmployee();

                Console.WriteLine("Enter 1 for add salary; 2 for take away salary; 3 for equals; 4 for more/less; ");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("Amout: ");
                    int amout = Convert.ToInt32(Console.ReadLine());

                    SalaryEmployee amoutSalary = new(amout);
                    SalaryEmployee newWorkerSalary = workerSalary + amoutSalary;
                    worker = new(1, "Vasya", "Kykorey", "3809741254", "qgnjwngwegjlw", newWorkerSalary.Salary);

                    worker.InfoEmployee();

                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    Console.WriteLine("Amout: ");
                    int amout = Convert.ToInt32(Console.ReadLine());

                    SalaryEmployee amoutSalary = new(amout);
                    SalaryEmployee newWorkerSalary = workerSalary - amoutSalary;
                    worker = new(1, "Vasya", "Kykorey", "3809741254", "qgnjwngwegjlw", newWorkerSalary.Salary);

                    worker.InfoEmployee();

                    Console.WriteLine();
                }
                else if (choose == 3)
                {
                    if (workerSalary == secondWorkerSalary)
                    {
                        Console.WriteLine("Equal");
                    }
                    else
                    {
                        Console.WriteLine("Not equal");
                    }
                }
                else if (choose == 4)
                {
                    if (workerSalary > secondWorkerSalary)
                    {
                        Console.WriteLine($"{worker.Name} has a higher salary");
                    }
                    else
                    {
                        Console.WriteLine($"{worker.Name} has a lower salary");
                    }
                }
                else
                {
                    throw new Exception("Incorrect action");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format!");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
        public void MenuMatrix()
        {
            try
            {
                Console.WriteLine("*Adding first matrix elements*");
                Console.WriteLine("First element: ");
                int firstMatElem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second element: ");
                int secondMatElem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Third element: ");
                int thirdMatElem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fourth element: ");
                int fourthMatElem = Convert.ToInt32(Console.ReadLine());

                Matrix firstMatrix = new(firstMatElem, secondMatElem, thirdMatElem, fourthMatElem);
                Console.WriteLine("*First matrix*");
                firstMatrix.ShowMatrix();

                Console.WriteLine("*Adding second matrix elements*");
                Console.WriteLine("First element: ");
                int firstSecondMatElem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second element: ");
                int secondSecondMatElem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Third element: ");
                int thirdSecondMatElem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fourth element: ");
                int fourthSecondMatElem = Convert.ToInt32(Console.ReadLine());

                Matrix secondMatrix = new(firstSecondMatElem, secondSecondMatElem, thirdSecondMatElem, fourthSecondMatElem);
                Console.WriteLine("*Second matrix*");
                secondMatrix.ShowMatrix();

                while(true)
                {
                    Console.WriteLine("Action: ");
                    Console.WriteLine("1 - add matrices; 2 - subtract matrices; 3 - multiply matrices; 4 - equals; 0 - exit");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Matrix adding = firstMatrix + secondMatrix;
                            adding.ShowMatrix();
                            break;
                        case 2:
                            Matrix substract = firstMatrix - secondMatrix;
                            substract.ShowMatrix();
                            break;
                        case 3:
                            Matrix multiply = firstMatrix * secondMatrix;
                            multiply.ShowMatrix();
                            break;
                        case 4:
                            if (firstMatrix == secondMatrix)
                            {
                                Console.WriteLine("Matrix equal!");
                            }
                            else
                            {
                                Console.WriteLine("Matrix not equal");
                            }
                            break;
                        
                    }
                    if (choose == 0)
                    {
                        Console.WriteLine("Bye-bye");
                        break;
                    }
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void MenuCity()
        {
            City Dnipro = new(966400);
            City Lviv = new(721301);

            Console.WriteLine($"Dnipro populace: {Dnipro.Populace}; Lviv populace: {Lviv.Populace}");

            Console.WriteLine("Action: ");
            while (true) 
            {
                Console.WriteLine("1 - add populace; 2 - subtract populace; 3 - equal populace; 4 - more/less populace; 0 - exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose) 
                {
                    case 1:
                        Console.WriteLine("Amout: ");
                        int addAmout = Convert.ToInt32(Console.ReadLine());
                        City add = new(addAmout);

                        Console.WriteLine("Choose city: 1 - Dnipro; 2 - Lviv");
                        int cityChooseAdd = Convert.ToInt32(Console.ReadLine());

                        if (cityChooseAdd == 1)
                        {
                            Dnipro = Dnipro + add;

                            Dnipro.ShowPeople();
                        }
                        else if (cityChooseAdd == 2)
                        {
                            Lviv = Lviv + add;

                            Lviv.ShowPeople();
                        }
                        else
                        {
                            throw new Exception("Incorrect city number!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Amout: ");
                        int substractAmout = Convert.ToInt32(Console.ReadLine());
                        City substract = new(substractAmout);

                        Console.WriteLine("Choose city: 1 - Dnipro; 2 - Lviv");
                        int cityChooseSubstract = Convert.ToInt32(Console.ReadLine());

                        if (cityChooseSubstract == 1)
                        {
                            Dnipro = Dnipro - substract;

                            Dnipro.ShowPeople();
                        }
                        else if (cityChooseSubstract == 2)
                        {
                            Lviv = Lviv - substract;

                            Lviv.ShowPeople();
                        }
                        else
                        {
                            throw new Exception("Incorrect city number!");
                        }
                        break;
                    case 3:
                        if (Dnipro == Lviv)
                        {
                            Console.WriteLine("Equal!");
                        }
                        else
                        {
                            Console.WriteLine("Not equal!");
                        }
                        break;
                    case 4:
                        if (Dnipro > Lviv)
                        {
                            Console.WriteLine("Dnipro populace > Lviv populace");
                        }
                        else
                        {
                            Console.WriteLine("Lviv populace > Dnipro populace");
                        }
                        break;
                }
                if (choose == 0)
                {
                    Console.WriteLine("Bye-bye");
                    break;
                }
            }


        }
        public void MenuCard()
        {
            CreditCard credit = new(23000);
            Console.WriteLine("Enter new CVV: ");
            int newCVV = Convert.ToInt32(Console.ReadLine());
            CardCVV cardCVV;
            if (newCVV >= 100 && newCVV <=999) 
            {
                cardCVV = new(newCVV);
            }
            else
            {
                throw new Exception("Incorrect CVV code. CVV support only 3 numbers!");          
            }
            
            while (true)
            {

                Console.WriteLine("1 - add money; 2 - subtract money; 3 - equal CVV; 4 - more/less money; 0 - exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose) 
                {
                    case 1:
                        Console.WriteLine("Enter quantity: ");
                        int amoutAdd = Convert.ToInt32(Console.ReadLine());
                        CreditCard add = new(amoutAdd);
                        Console.WriteLine("Adding...");
                        credit = credit + add;
                        credit.Information();
                        break;
                    case 2:
                        Console.WriteLine("Enter quantity: ");
                        int amoutSubstract = Convert.ToInt32(Console.ReadLine());
                        CreditCard substract = new(amoutSubstract);
                        Console.WriteLine("Takeing...");
                        credit = credit - substract;
                        credit.Information();
                        break;
                    case 3:
                        Console.WriteLine("Enter CVV: ");
                        int checkCVV = Convert.ToInt32(Console.ReadLine());
                        CardCVV check = new(checkCVV);
                        if (cardCVV == check)
                        {
                            Console.WriteLine("CVV equal!");
                        }
                        else
                        {
                            Console.WriteLine("CVV not equal!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the amount to compare: ");
                        int compare = Convert.ToInt32(Console.ReadLine());
                        CreditCard campareCredit = new(compare);
                        if (credit > campareCredit)
                        {
                            Console.WriteLine($"More money on your card: {credit.Money} > {campareCredit.Money}");
                        }
                        else
                        {
                            Console.WriteLine($"Less money on your card: {credit.Money} < {campareCredit.Money}");
                        }
                        break;
                }
                if (choose == 0)
                {
                    Console.WriteLine("Bye-bye");
                    break;
                }

            }

        }
    }
}
