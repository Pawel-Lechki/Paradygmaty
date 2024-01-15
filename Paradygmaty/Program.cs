using Paradygmaty.model;

/*
 Client c1 = new Client();
c1.setFirstName("Jan");
c1.setLastName("Nowak");
c1.setPersonalID("22222222222");

Console.WriteLine(c1.getClinetInfo());
*/
Address a1 = new Address("Hoża", "1B");
Client c2 = new Client("Jan", "Kowalski", "11111111116", a1);


Console.WriteLine(c2.getClinetInfo());

//Console.WriteLine();