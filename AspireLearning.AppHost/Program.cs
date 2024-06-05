var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireLearning_ApiService>("apiservice");

builder.AddProject<Projects.AspireLearning_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
