var builder = DistributedApplication.CreateBuilder(args);

var pg = builder.AddPostgres("pg")
    .WithDataVolume("shoplab-pg")
    .WithPgAdmin();

// One database per service, all declared up front (no init.sql).
pg.AddDatabase("catalogdb");
pg.AddDatabase("customerdb");
pg.AddDatabase("inventorydb");
pg.AddDatabase("orderingdb");
pg.AddDatabase("paymentdb");
pg.AddDatabase("discountdb");
pg.AddDatabase("flashsaledb");
pg.AddDatabase("storedb");

builder.Build().Run();
