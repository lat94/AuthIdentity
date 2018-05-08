using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using Microsoft.AspNetCore.Http;
using AuthIdentity.Models.HomeViewModels;

namespace AuthIdentity.Services
{
    public class WebRestClient
    {
        private RestClient setRest(string urlBase, string user=null, string passwd=null)
        {
            RestClient rest = new RestClient(urlBase);
            if (!(String.IsNullOrEmpty(user) && String.IsNullOrEmpty(passwd)))
            {
                rest.Authenticator = new HttpBasicAuthenticator(user, passwd);
            }  

            return rest;

        }

        private RestRequest setRequest(string param, Method method)
        {
            var request = new RestRequest(param, method);

            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };


            return request;
        }






        public List<ClientViewModel> getClients()
        {
            List<ClientViewModel> clients = new List<ClientViewModel>();
            string urlBase = "http://www.mocky.io/";
            string param = "v2/5a69cc852e000037197a75ec";

            var rest = setRest(urlBase);
            var request = setRequest(param, Method.GET);

            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

            var response = rest.Execute<List<ClientViewModel>>(request);


            clients = response.Data;


            return clients;


        }

       



        public  List<SalesViewModel> getSales()
        {
            List<SalesViewModel> sales = new List<SalesViewModel>();
            string urlBase = "http://www.mocky.io/";
            string param = "v2/5a6a30652e0000542f7a7737";            

            var rest = setRest(urlBase);
            var request = setRequest(param, Method.GET);
            

            var response = rest.Execute<List<SalesViewModel>>(request);


            sales = response.Data;
            
            return sales;


        }    


        public  List<FreightViewModel> getFreights()
        {
            List<FreightViewModel> freights = new List<FreightViewModel>();
            string urlBase = "http://www.mocky.io/";
            string param = "v2/5a6f22ba3000005b276fe4e1";            

            var rest = setRest(urlBase);
            var request = setRequest(param, Method.GET);
            

            var response = rest.Execute<List<FreightViewModel>>(request);


            freights = response.Data;


            return freights;


        }      
        









         public List<CurvaABCViewModel> getEmployees()
        {
            List<CurvaABCViewModel> curvaABC = new List<CurvaABCViewModel>();
            string urlBase = "http://dummy.restapiexample.com/";
            string param = "api/v1/employees";

            var rest = setRest(urlBase);
            var request = setRequest(param, Method.GET);

            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

            var response = rest.Execute<List<CurvaABCViewModel>>(request);


            curvaABC = response.Data;


            return curvaABC;


        }











    }

}