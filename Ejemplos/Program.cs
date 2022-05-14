//string nombre = " ";
//Console.WriteLine(nombre.Length);

//if (string.IsNullOrWhiteSpace (nombre))
//{
//    Console.WriteLine("string vacio");
//}
//else
//{
//    Console.WriteLine(nombre);
//}

//int numero = 9;
//string numeroConCeros = "99"; 
//numeroConCeros = numeroConCeros.PadLeft( 3 , '$');
//Console.WriteLine(numeroConCeros);


string nombre = "Jose";
string apellido = "Rodriguez";
int edad = 20;

//string NombreyEdad = nombre + "|" + apellido + "|" + edad;
//Console.WriteLine(NombreyEdad);

//string NombreyEdad = string.Format("{0}|{1}|{2}", nombre, apellido, edad);
//Console.WriteLine(NombreyEdad);

//El mejor metodo
string NombreyEdad = $"{nombre}|{apellido}|{edad}";
Console.WriteLine(NombreyEdad);

//Investigar concat