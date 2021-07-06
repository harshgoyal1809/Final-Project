﻿using Component_Processing.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Component_Processing.Repositry
{
    public class ComponentRepo : IComponentRepo
    {

        public ProcessResponse GetResponse(string Name, long ContactNumber, long CreditCardNumber, string ComponentType, string ComponentName, int Quantity, bool IsPriority)
        {
            ProcessRequest request = new ProcessRequest();
            ProcessResponse res = new ProcessResponse();
            string uri = string.Format("https://localhost:44345/getPackagingDeliveryCharge/{0}/{1}", ComponentType, Quantity);
            if (ComponentType == "Integral")
            {
                if (IsPriority == false)
                {
                    using (var client = new HttpClient())
                    {

                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        var cost = client.GetAsync(uri).Result;
                        if (cost.IsSuccessStatusCode)
                        {
                            string responseString = cost.Content.ReadAsStringAsync().Result;
                            string responseString2 = JsonConvert.DeserializeObject<string>(responseString);
                            res.PackagingandDeliveryCharge = Convert.ToDouble(responseString2);
                        }
                    }
                    res.ProcessingCharge = 500*Quantity;
                    res.DateOfDelivery = DateTime.Now.AddDays(5);
                }
                else
                {
                    using (var client = new HttpClient())
                    {

                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                        var cost = client.GetAsync(uri).Result;
                        if (cost.IsSuccessStatusCode)
                        {
                            string responseString = cost.Content.ReadAsStringAsync().Result;
                            string responseString2 = JsonConvert.DeserializeObject<string>(responseString);
                            res.PackagingandDeliveryCharge = Convert.ToDouble(responseString2);
                        }
                        res.ProcessingCharge = 700*Quantity;
                        res.DateOfDelivery = DateTime.Now.AddDays(2);
                    }
                }

            }
            if (ComponentType == "Accessory")
            {
                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    var cost = client.GetAsync(uri).Result;
                    if (cost.IsSuccessStatusCode)
                    {
                        string responseString = cost.Content.ReadAsStringAsync().Result;
                        string responseString2 = JsonConvert.DeserializeObject<string>(responseString);
                        res.PackagingandDeliveryCharge = Convert.ToDouble(responseString2);
                    }
                }

                res.ProcessingCharge = 300*Quantity;
                res.DateOfDelivery = DateTime.Now.AddDays(5);
            }
            return res;
        }

        public string GetCompletion(int RequestId, long CreditCardNumber, double CreditLimit, double ProcessingCharge)
        {
            ProcessResponse response = new ProcessResponse();
            ProcessRequest request = new ProcessRequest();

            string balance = "";
            using (var client = new HttpClient())
            {


                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string uri = string.Format("https://localhost:44335/GetpaymentDetails/{0}/{1}/{2}/{3}", RequestId, CreditCardNumber, CreditLimit, ProcessingCharge);

                var cost = client.GetAsync(uri).Result;
                if (cost.IsSuccessStatusCode)
                {
                    string responseString = cost.Content.ReadAsStringAsync().Result;
                    string responseString2 = JsonConvert.DeserializeObject<string>(responseString);
                    balance = responseString2;

                }
                return ("Your Confirmation is Successful and your Balance is  " + balance);
            }


        }
    }
}