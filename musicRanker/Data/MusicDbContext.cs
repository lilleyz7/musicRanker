using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace musicRanker.Data;
public class MusicDbContext : IdentityDbContext<IdentityUser>
{
    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
    {
        
    }
}
