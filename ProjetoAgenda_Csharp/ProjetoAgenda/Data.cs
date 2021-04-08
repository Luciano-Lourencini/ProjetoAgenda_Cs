using System;

namespace ProjetoAgenda
{
    public class Data
    {
        // atributos
        private int dia;
        private int mes;
        private int ano;

        // método construtor
        public Data(int d, int m, int a) //não padrão (vai precisar colocar)
        {
            this.setAno(a);
            this.setMes(m);
            this.setDia(d);
        }
        // métodos
        public int getDia()
        {
            return this.dia; //this referencia o objeto em memória (não é necessário, mas é usado para referenciar o atributo "puro")
        }

        public int getMes()
        {
            return this.mes;
        }

        public int getAno()
        {
            return this.ano;
        }

        public void setAno(int ano)
        {
            if(ano<1522 || ano>2100)
                throw new Exception("Ano inválido!");

            this.ano = ano; //sempre que houver o mesmo nome p/ variável e atributo, ele referencia var. THIS é para referenciar o atributo
        }

        public void setMes(int mes)
        {
            if (mes<1 || mes>12)
                throw new Exception("Mês inválido!");

            this.mes = mes;
        }

        public void setDia(int dia)
        {
            int max = this.diasDoMes();

            if (dia<1 || dia>max)
                throw new Exception("Dia inválido");
            
            this.dia = dia;
        }

        private int diasDoMes()
        {
            switch(this.mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31; //não usa BREAK pq já tem o RETURN (que já para)
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default: //fevereiro
                    if (this.ano%4==0) //bissexto
                        return 29;
                    else
                        return 28;
            }
        }
    }
}