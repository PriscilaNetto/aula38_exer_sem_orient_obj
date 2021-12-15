using System;

namespace aula38_exer_sem_orient_obj
{
    class Triangulo
    {
        //dentro da classe existe os membros que podem ser atributos e métodos como a seguir:

        //são atributos da classe
        public double A; //o public pode ser usado em outros arquivos - encapsulamento;
        public double B; 
        public double C;

        // o método criado precisa ficar dentro das chaves da classe triangulo
        //o double é o tipo de dado que retorna, para não retornar nada é colocado 'void'
        //não foi usado nenhum paramentro pq todos os dados usados já existem e pertencem à classe Triangulo.
        public double CalculateTrianguleArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }


    }
}
