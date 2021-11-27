using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP3Client.Models;

namespace DNP3Client.Data.Impl
{
    public class FamilyService : IFamilyService
    {
        private string uri = "https://localhost:5001";

        private readonly HttpClient client;

        public FamilyService()
        {
            client = new HttpClient();
        }


        public async Task<IList<Family>> GetAllFamiliesAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Families");
            string message = await stringAsync;
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            return result;
        }
        
        public async Task<Family> GetFamilyAsync(int id)
        {
            Task<string> stringAsync = client.GetStringAsync($"{uri}/Families/{id}");
            string message = await stringAsync;
            Family result = JsonSerializer.Deserialize<Family>(message);
            return result;
        }
        
        public async Task AddFamilyAsync(Family family)
        { 
            string familyAsJson = JsonSerializer.Serialize(family);
            HttpContent content = new StringContent(familyAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/Families", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("Client > Successfully family added.");
            }
        }

        public async Task<Family> RemoveFamilyAsync(int familyId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/Families/{familyId}");
            string reply = await response.Content.ReadAsStringAsync();

            Family removedFamily = JsonSerializer.Deserialize<Family>(reply);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return removedFamily;
            }

            return null;
        }

        public async Task UpdateAsync(Family family)
        {
            string familyAsJson = JsonSerializer.Serialize(family);
            HttpContent content = new StringContent(familyAsJson,
                Encoding.UTF8,
                "application/json");
            var response = await client.PatchAsync($"{uri}/Families/{family.Id}", content);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.ReasonPhrase);
            }
        }

    }
}