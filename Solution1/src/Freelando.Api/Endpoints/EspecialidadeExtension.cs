
namespace Freelando.Api.Endpoints;

public static class EspecialidadeExtensions
{
    public static void AddEndPointEspecialidades(this WebApplication app)
    {
        app.MapGet("/especialidades", async (FreelandoContext context) =>
        {
            return Results.Ok(await context.Especialidades.ToListAsync());
        });
    }
}
