using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public RocketseatAuctionDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}


// aqui estamos dando poder para várias classes acessarem a nossa tabela, vamos refatorar o código
// Vamos dividir em camadas e a regra de negócio nao terá acesso ao dbcontext