using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    // Principio de Responsabilidad Única (SRP): Esta clase tiene una única responsabilidad, que es imprimir recetas en la consola.
    public class ConsolePrinter
    {
        // Método que recibe una receta y la imprime en la consola.
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}