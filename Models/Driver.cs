using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace DiscoverApi.Models;
public class Driver
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public bool Status { get; set; }
    public string? Description { get; set; }
    public  string? Category { get; set; }
    public int Rating { get; set; }
    public ArraySegment<string> Routes { get; set; }
    public User User { get; set; }
}
