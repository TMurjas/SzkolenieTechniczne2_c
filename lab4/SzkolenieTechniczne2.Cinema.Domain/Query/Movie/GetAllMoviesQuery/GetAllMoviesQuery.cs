using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Domain.Query.Dtos;

namespace SzkolenieTechniczne2.Cinema.Domain.Query.Movie.GetAllMoviesQuery
{
    public sealed record GetAllMoviesQuery : IRequest<List<MovieDto>>
    {
    }
}
