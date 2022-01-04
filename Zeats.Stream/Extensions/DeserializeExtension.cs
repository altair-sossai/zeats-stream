using System.Threading.Tasks;
using Zeats.Json;

namespace Zeats.Stream.Extensions;

public static class DeserializeExtension
{
    public static async Task<T> Deserialize<T>(this System.IO.Stream stream)
    {
        return await JsonSerializer.DeserializeAsync<T>(stream);
    }
}