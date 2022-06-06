/*
Ejercicio 1
Crea una estructura de datos para un cliente con estos campos:

Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
*/

Client cliente1 = new Client("Pablo Marrero", 1188123456, "New York, 1224", "Pablo.York@gmail.com", true);

Console.WriteLine(cliente1);
public struct Client
{
    public Client(string name, int tel, string address,string email, bool isNewClient)
    {
        NAME = name;
        TEL = tel;
        ADDRESS = address;
        EMAIL = email;
        ISNEWCLIENT = isNewClient;
     }
    public string NAME { get; set; }
    public int TEL { get; set; }
    public string ADDRESS { get; set; }
    public string EMAIL { get; set; }
    public bool ISNEWCLIENT { get; set; }

    public override string ToString()
    {
        return $"Full name: {NAME}, tel: {TEL}, address: {ADDRESS}, email: {EMAIL}, isNewCLient:  {ISNEWCLIENT}";
    }

}
