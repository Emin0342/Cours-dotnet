
using newWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
namespace webapi;
using AutoMapper;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
         Assembly a = typeof(Program).Assembly;
        Console.WriteLine("Assembly identity={0}", a.FullName);
        // Add services to the container.
        builder.Services.AddDbContext<AppDbContext>();
        builder.Services.AddControllers();
        Console.WriteLine("Hello World!");
     
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}



public class MappingProfile : Profile {
     public MappingProfile() {
         // Add as many of these lines as you need to map your objects
         CreateMap<Book, BookUpdateDTO>(); // ici on map les champs de la table Book avec les champs du DTO
     }
 }