using System;
using System.Collections.Generic;
using System.Text;

namespace POO_MediaProdutos
{
    class Produto
    {
        //Definição das variáveis: Nome e Preço
        public string Name { get; set; }
        public double Price { get; set; }

        /*Construtores
        public Produto(string name, double price)
        {
            _name = name;
            _price = price;
        }

        //Armazenamento das informações para Name e Price
        //Aplicação do Properties: Get e Set
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
        */
    }

}
