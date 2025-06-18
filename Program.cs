builder.Services.AddScoped<EventService>();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("EventDb")); // (Optional)
