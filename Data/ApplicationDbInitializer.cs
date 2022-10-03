namespace assignment_3.Data;

public class ApplicationDbInitializer
{
    public static void Initialize(ApplicationDbContext database)
    {
        database.Database.EnsureDeleted();
        database.Database.EnsureCreated();
    }
}