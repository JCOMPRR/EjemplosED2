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

int numero = 9;
string numeroConCeros = "99"; 
numeroConCeros = numeroConCeros.PadLeft( 3 , '$');
Console.WriteLine(numeroConCeros);
