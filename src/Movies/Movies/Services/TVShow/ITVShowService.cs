using Movies.Models;
using System.Threading.Tasks;

namespace Movies.Services.TVShow
{
    public interface ITVShowService
    {
        Task<Models.TVShow.TVShow> FindByIdAsync(int tvShowId, string language = "pt-BR");

        Task<Models.TVShow.TVShow> GetLatestAsync(string language = "pt-BR");

        Task<SearchResponse<Models.TVShow.TVShow>> GetTopRatedAsync(int pageNumber = 1, string language = "pt-BR");

        Task<SearchResponse<Models.TVShow.TVShow>> GetPopularAsync(int pageNumber = 1, string language = "pt-BR");
    }
}