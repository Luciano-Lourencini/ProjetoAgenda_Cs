using System;

namespace ProjetoAgenda
{
    public class Horario
    {
        //atributos
        private int horas; //0->23         //private para não alterarem o limite das horas
        private int minutos;//0 -> 59

        //métodos construtores  (inicializar com algum valor != de 0)
        public Horario(int h, int m) //não padrão
        {
            setHoras(h);
            setMinutos(m);
        }

        public Horario() //padrão
        {
            setHoras(17); //por padrão o horário é 17:09
            setMinutos(9);
        }
        
        //métodos
        public int getHoras()
        {
            return horas;
        }

        public int getMinutos()
        {
            return minutos;
        }

        public void setHoras(int novaHora)
        {
            if(novaHora<0||novaHora>23) //Hora errada
                throw new Exception("Hora inválida!");
            horas = novaHora;
        }

        public void setMinutos(int novoMinuto)
        {
            if(novoMinuto<0||novoMinuto>59)
                throw new Exception("Minuto inválido!");
            minutos = novoMinuto;
        }
    }
}