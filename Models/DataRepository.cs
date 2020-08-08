using System.Text.Json.Serialization;
using System;

namespace WebApiEEP.Models
{
    public class DataRepository
    {
        [JsonPropertyName("id")]
        public int id {get;set;}
        
        [JsonPropertyName("name")]
        public string name {get;set;}
        
        [JsonPropertyName("contractTypeName")]
        public string contractTypeName {get;set;}
        
        [JsonPropertyName("roleId")]
        public int roleId {get;set;}
        
        [JsonPropertyName("roleName")]
        public string roleName {get;set;}
        
        [JsonPropertyName("roleDescription")]
        public string roleDescription {get;set;}
        
        [JsonPropertyName("hourlySalary")]
        public double hourlySalary {get;set;}
        
        [JsonPropertyName("monthlySalary")]
        public double monthlySalary {get;set;}
       
    }    
}