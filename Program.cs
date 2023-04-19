
    int AdultosA, AdultosB, Adultos, Crianças, Pessoas, SemB;
    //Adultos A = Adultos que bebem Alcoól, B = Não Bebem, SemB = Sem Bebidas Alcoólicas.

    Double Acompanhamentos, Agua, Carne, Cerveja, Refri;

    Console.Clear();

    Console.Write("Adultos que bebem bebidas alcoólicas.......: ");
    AdultosA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Adultos que não bebem bebidas alcoólicas...: ");
    AdultosB = Convert.ToInt32(Console.ReadLine());

    Console.Write("Crianças...................................: ");
    Crianças = Convert.ToInt32(Console.ReadLine());

    Adultos = AdultosA + AdultosB;
    Pessoas = Adultos + Crianças;
    SemB = AdultosB + Crianças;

    Acompanhamentos = 0.2 * Pessoas;
    Agua = 0.4 * Pessoas;
    Carne = 0.4 * Adultos + 0.2 * Crianças;
    Cerveja = 2 * AdultosA;
    Refri = 0.5 * SemB;

    Console.WriteLine();
   
    Console.WriteLine($"Acompanhamentos........: {Acompanhamentos:N1}kg");
    Console.WriteLine($"Água...................: {Agua:N1}L");
    Console.WriteLine($"Carne..................: {Carne:N1}kg");
    Console.WriteLine($"Cerveja................: {Cerveja:N1}L");
    Console.WriteLine($"Refri..................: {Refri:N1}L");
