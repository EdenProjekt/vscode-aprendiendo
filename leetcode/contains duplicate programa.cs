using System;
using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso del método ContainsDuplicate

        // Array de prueba
        int[] numeros = { 1, 2, 3, 4, 5, 3 };

        // Crear una instancia de la clase Solution
        Solution sol = new Solution();

        // Llamar al método ContainsDuplicate
        bool resultado = sol.ContainsDuplicate(numeros);

        // Mostrar el resultado
        Console.WriteLine("¿Contiene duplicados?: " + resultado);
    }
}