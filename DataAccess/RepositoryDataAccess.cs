using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using WebApiEEP.Models;

namespace WebApiEEP.DataAccess
{
    public static class RepositoryDataAccess{
        private static readonly HttpClient client = new HttpClient();
        private static string UR = "http://masglobaltestapi.azurewebsites.net/api/Employees";
        public static async Task<List<DataRepository>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                
            var streamTask = client.GetStreamAsync(UR);
            
            List<DataRepository> repositories = 
            await JsonSerializer.DeserializeAsync<List<DataRepository>>(await streamTask);
            
            return repositories;

        }

    }

}