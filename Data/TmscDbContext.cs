using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Components;
using TyphoonTaskingTool.Models;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Data;

public partial class TmscDbContext : DbContext
{
    public TmscDbContext(DbContextOptions<TmscDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //used during runtime to instantiate Db connection.
        => optionsBuilder.UseNpgsql("Name=NeonDBConnection"); //What kind of Db is the app communicating with?

    //EF Core convention is to puluralise tables in code.
    public virtual DbSet<LookupRank> LookupRanks { get; set; } //LookupRanks is a collection of LookupRank

    public virtual DbSet<LookupStatus> LookupStatuses { get; set; }

    public virtual DbSet<LookupTeam> LookupTeams { get; set; }

    public virtual DbSet<LookupUnit> LookupUnits { get; set; }

    public virtual DbSet<LookupTrafficLight> LookupTrafficLights { get; set; }

    public virtual DbSet<LookupPriority> LookupPriorities { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestUpdate> RequestUpdates { get; set; }

    public virtual DbSet<RequestAttachment> RequestAttachements { get; set; }

    public virtual DbSet<RigRequest> RigRequests { get; set; }

    //Used during model creation not runtime.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Owned<RigRequestSetupField>();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TmscDbContext).Assembly);
    }
}
