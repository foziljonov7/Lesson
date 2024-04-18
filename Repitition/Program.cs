using Repitition.Models;
using Repitition.Repository;

UserRepository service = new UserRepository();

while (true)
{
    Console.WriteLine("Loyihaga xush kelibsiz!");
    Console.WriteLine($"Kerakli bo'limlardan birini tanlang\n1) Barcha malumotlarni ko'rish" +
        $"\n2) Id raqami bo'yicha malumot qidirish\n3) Yangi user kiritish" +
        $"\n4) Id bo'yicha malumot o'chirish\n5) Loyihadan chiqish");

    int n = Convert.ToInt32(Console.ReadLine());

    switch (n)
    {
        case 1: GetUsers(); break;
        case 2: GetUser(); break;
        case 3: CreateUser(); break;
        case 4: DeleteUser(); break;
        case 5: Console.WriteLine("Dasturdan chiqilmoqda..."); return;
        default: Console.WriteLine($"{n} mavjud bo'lmagan bo'lim!"); break;
    }
}

void DeleteUser()
{
    int id;
    Console.Write("Id kiriting: ");
    id = Convert.ToInt32(Console.ReadLine());
    var res = service.DeleteUserAsync(id);
    Console.WriteLine(res);
}

void CreateUser()
{
    string u, ph, d, phn = "+998";
    int a, id;
    Console.Write("Username: ");
    u = Console.ReadLine();

    Console.Write("Address: ");
    d = Console.ReadLine();

    Console.Write("Phone number: ");
    ph = Console.ReadLine();

    Console.Write("Age: ");
    a = Convert.ToInt32(Console.ReadLine());

    phn += ph;

    Random rand = new Random();
    id = rand.Next(100, 1000);

    User user = new User
    {
        Id = id,
        Username = u,
        PhoneNumber = phn,
        Address = d,
        Age = a
    };

    var res = service.CreateUserAsync(user);
    Console.WriteLine(res);
}

void GetUsers()
{
    foreach (var user in service.GetUsersAsync())
    {
        Console.WriteLine(user.ToString());
    }
}

void GetUser()
{
    Console.Write("User Id sini kiriting: ");
    int n = Convert.ToInt32(Console.ReadLine());
    var user = service.GetUserAsync(n);
    Console.WriteLine(user.ToString());
}


