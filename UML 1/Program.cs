

using UML_1;


Pizza p1 = new Pizza(1, "Magarita", 75.5, "Tomat Ost");
Pizza p2 = new Pizza(2, "Abe", 55.5, "Abe, ost, skinke");
Kunde k1 = new Kunde("Jens", 31100, "vej 123");
Bestilling b1 = new Bestilling(p1, k1);

//Console.WriteLine(p1.ToString());
//Console.WriteLine(k1.ToString());
Console.WriteLine(b1.ToString());
Console.ReadLine();

// Ordre - counter (static)
// Reference punkter pizza - kunde
// CalculateTotalPrice.ref


// Daniel Hass // 