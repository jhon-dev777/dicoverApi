using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using DiscoverApi.Shared.Enums;
namespace DiscoverApi.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("FirstName")]
    public string FirstName { get; set; } = null!;
    [BsonElement("SecondName")]
    public string SecondName { get; set; } = null!;
    public int Ci { get; set; }
    public string Email { get;set; } = null!;
    public int Phone { get; set;}
    public Rol Rol {get;set;} = Rol.PERSONAL;
    public string Address {get;set;} = null!;
}