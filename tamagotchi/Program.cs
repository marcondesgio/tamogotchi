
using System;
using RestSharp;

namespace invoke 
{
    class Program
    {
        static void Main(string[] args){                       
            InvokeGet(); //Call get
        }

        private static void InvokeGet(){
            string pokemon = "mewtwo"; //Select pokemon name for example

            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon}"); //Call API URL
            RestRequest request = new RestRequest("", Method.Get); //Select method
            var response = client.Execute(request); //Response from API in JSON format 

            if (response.StatusCode == System.Net.HttpStatusCode.OK){ //Verify return success or error
                Console.WriteLine(response.Content);

            }else{
                Console.WriteLine(response.ErrorMessage);
            }
            Console.ReadLine(); //Finalizing call API
        }
    
    }
}