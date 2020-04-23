using Movies.Models;
using Movies.Models.People;
using System.Threading.Tasks;

namespace Movies.Services.People
{
    public interface IPeopleService
    {
        Task<Person> FindByIdAsync(int personId, string language = "pt-BR");

        Task<SearchResponse<Person>> SearchByNameAsync(string query, int pageNumber = 1, string language = "pt-BR");

        Task<PersonImage> GetImagesAsync(int personId, string language = "pt-BR");
    }
}