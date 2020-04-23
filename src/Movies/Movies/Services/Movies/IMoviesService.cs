using Movies.Models;
using Movies.Models.Movie;
using System.Threading.Tasks;

namespace Movies.Services.Movies
{
    public interface IMoviesService
    {
        Task<Movie> FindByIdAsync(int movieId, string language = "pt-BR");

        Task<Movie> GetLatestAsync(string language = "pt-BR");

        Task<SearchResponse<Movie>> GetUpcomingAsync(int pageNumber = 1, string language = "pt-BR");

        Task<SearchResponse<Movie>> GetTopRatedAsync(int pageNumber = 1, string language = "pt-BR");

        Task<SearchResponse<Movie>> GetPopularAsync(int pageNumber = 1, string language = "pt-BR");

        Task<MovieCredit> GetCreditsAsync(int movieId, string language = "pt-BR");

        Task<MovieVideo> GetVideosAsync(int movieId, string language = "pt-BR");
    }
}