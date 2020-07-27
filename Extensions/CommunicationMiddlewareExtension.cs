using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Middleware;
using Microsoft.AspNetCore.Builder;

namespace TicTacToe.Extensions
{
    public static class CommunicationMiddlewareExtension
    {
        public static IApplicationBuilder useCommunicationMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CommunicationMiddleware>();
        }
    }
}
