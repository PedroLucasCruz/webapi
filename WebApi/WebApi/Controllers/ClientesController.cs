using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.Helpers;
using System.Web.Http;
namespace WebApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();
        //adicionado anotação
        //Anotação
        //Quando você colocar o nome do metodo como "Get", você não precisa usar a anotação
        //Caso o nome do metodo não seja "Get", vc tem que usar a anotação [HttpGet] em cima 
        //Do metodo de uso
        
        //Notação Especifica para Consulta de dados   
        [System.Web.Http.HttpGet]

        //Get retorna valor
        public List<Cliente> Get()
        {        
            return clientes;
        }

        //Quando você passar os parametros via postman dentro do corpo no postman(body),porém,
        //Para utilizar esta forma você usar a notãção [FromBody]
        //EX:
        // public void Post([FromBody] String nome)

        
        //Notação especifica para chamada Post, envio de dados
        [System.Web.Http.HttpPost]
        //Post não retorna valor
        public void Post(String nome)
        {
            if (nome.Length != 0 || nome != null)
            {
                clientes.Add(new Cliente(nome));
            }
            else
            {          
              
              
            }
        }

        //Notação especifica para chamada Delete
        [System.Web.Http.HttpDelete]
        public void Delete(String nome)
        {
            //1 - clientes.RemoveAt atingi o indice para mover
            //2 - clientes.RemoveIndexOf retorna a POSIÇÃO da cadeia de caracter passado
            //3 - clientes.First retorna a primeira ocorrencia encotrada

            Cliente valor1 = clientes.First(x => x.Nome == nome);
            int valor2 = clientes.IndexOf(valor1);
            clientes.RemoveAt(valor2); 

            //clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome == nome)));
        }

        [System.Web.Http.HttpPost]
        public void Update(string teste )
        {
            Console.Write(" teste teste o valor informado");        
           
        }
    }
}
