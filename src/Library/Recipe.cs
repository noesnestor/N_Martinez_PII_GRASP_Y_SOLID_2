//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string CreateRecipe()
        {
            StringBuilder recipe_text = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                recipe_text.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            return recipe_text.ToString();
        }   /*
            Si tenemos en cuenta el principio Expert, la clase Recipe no debería de cambiar; ya que tiene los métodos
            que le corresponde a la clase porque es la que crea las recetas, agregar y remover pasos y imprimir la 
            receta. Por el otro lado, si lo analizamos en base al principio SRP, la clase tiene dos razones para 
            cambiar, por lo cual debemos de modificarla. 
            La primera razón es si queremos agregarle una función como
            clonar la receta para que otro objeto sea esa receta pero con cosas agregadas (una hamburguesa base es
            pan y carne, pero si queremos agregarle queso, en vez de crear una clase desde cero, podemos crear una 
            clase basada en la hamburguesa y le agregamos el paso de preparar el queso). 
            La segunda razón es el imprimir la receta. Si queremos imprimir la receta en papel en vez de en consola,
            tendríamos que cambiar la clase. Teniendo nuestras dos razones de cambio escritos, debemos de resolver 
            cómo modificaremos la clase. Debido a que la función principal de la clase Recipe es la de armar una
            receta, lo que haremos es quitarle la responsabilidad de imprimir la receta y se la designaremos a una
            nueva clase; "ConsolePrinter" que se encargue de imprimir la receta utilizando como colaborador 
            a la clase Recipe.
            */
    }
}