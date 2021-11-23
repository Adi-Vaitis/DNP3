using System.Collections.Generic;
using System.Text.Json.Serialization;
using DNP3.Models;

namespace Models {
public class Child : Person {

    [JsonIgnore]
    public List<Interest> Interests { get; set; }
    [JsonIgnore]
    public List<Pet> Pets { get; set; }
    public override string ToString()
    {
        return $"Full name: {FirstName} {LastName} \n Hair: {HairColor} Eyes: {EyeColor} Age: {Age} Weight: {Weight} Height: {Height} Gender: {Sex}" +
               $" Interests: {string.Join("\n",Interests)} Pets: {string.Join("\n",Pets)}";
    }
}
}