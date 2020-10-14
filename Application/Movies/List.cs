using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Movies
{
    public class List
    {
        public class Query : IRequest<List<Movie>> {}

        public class Handler : IRequestHandler<Query, List<Movie>>
        {
            private readonly DataContext context;
            public Handler(DataContext context) => this.context = context;

            public Task<List<Movie>> Handle(Query request, CancellationToken cancellationToken)
            {
                return this.context.Movies.ToListAsync();
            }
        }
    }
}