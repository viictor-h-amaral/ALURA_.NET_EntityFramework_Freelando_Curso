﻿using Freelando.Dados;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Freelando.Api.Endpoints;

public static class ProjetoExtension
{
    public static void AddEndPointProjeto(this WebApplication app)
    {
        app.MapGet("/projetos", async (FreelandoContext context) => 
        {
            return Results.Ok(await context.Projetos.ToListAsync());
        });
    }
}
