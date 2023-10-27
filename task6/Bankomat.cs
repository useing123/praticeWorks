namespace Bankomat
{
    class Program
    {
        static void Main()
        {
            // Создаем аккаунт и клиента
            var account = new Bank.Account(12345, "password123");
            var client = new Client.Client("1234-5678-9012-3456", "password123", account);

            int attempts = 3;

            // Ввод пароля
            while (attempts > 0)
            {
                Console.Write("Введите пароль: ");
                string inputPassword = Console.ReadLine();

                if (client.VerifyPassword(inputPassword))
                {
                    ShowMenu(client);
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль. Попыток осталось: {attempts}");
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Превышено количество попыток ввода пароля. Программа завершена.");
            }
        }

        static void ShowMenu(Client.Client client)
        {
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Проверить баланс");
                Console.WriteLine("2. Пополнить счет");
                Console.WriteLine("3. Снять деньги");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Баланс счета: ${client.GetBalance()}");
                        break;
                    case "2":
                        Console.Write("Введите сумму для пополнения: $");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            client.Deposit(depositAmount);
                            Console.WriteLine($"Счет пополнен. Новый баланс: ${client.GetBalance()}");
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат суммы.");
                        }
                        break;
                    case "3":
                        Console.Write("Введите сумму для снятия: $");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            if (client.Withdraw(withdrawAmount))
                            {
                                Console.WriteLine($"Сумма снята. Новый баланс: ${client.GetBalance()}");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств на счете.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат суммы.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Программа завершена.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие из меню.");
                        break;
                }
            }
        }
    }
}
