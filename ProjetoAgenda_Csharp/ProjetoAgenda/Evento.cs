using System;
namespace ProjetoAgenda
{
    public class Evento
    {
        //atributos
        private Horario hora;
        private Data data;
        private string descricao;

        //métodos construtores
        public Evento(string desc,Data d,Horario h)
        {
            setDescricao(desc);
            setData(d);
            setHora(h);
        }
        public Evento(string dc,Data dt) : this(dc,dt,null) 
        {
            //Usa isso para referenciar o método com 3 parâmetros. Não tem importância a posição do método (por exemplo, não referencia pq tá em cima).
        }

        //métodos
        public Horario getHora()
        {
            return this.hora;
        }
        public Data getData()
        {
            return this.data;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setData(Data data)
        {
            if(data==null)
                throw new Exception("PROIBIDO DATA VAZIA");
            this.data = data; //THIS.DATA referencia ao atributo, já DATA é a variável nova
        }
        public void setHora(Horario hora)
        {
            //vou permitir NULL, pq se for null é o dia inteiro
            this.hora = hora;
        }
        public void setDescricao(string descricao)
        {
            if(descricao==null || descricao.Trim().Length==0) //Trim() = tira os espaços da direita e esquerda       //Length = retorna quantos caracteres têm no texto   //se depois de limpar os espaços e o tamanho=0, aí cai no IF
                throw new Exception("PROIBIDA DESCRIÇÃO VAZIA");
            this.descricao = descricao;
        }
    }
}