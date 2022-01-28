// See https://aka.ms/new-console-template for more information

using System.Text.Json.Nodes;
using AutoMapper;
using AutomapperTest;
using Newtonsoft.Json.Linq;

Console.WriteLine("Hello, World!");

var config = new MapperConfiguration(config =>
{
    config.CreateMap<Test, TestViewModel>();
});

var mapper = new Mapper(config);

var mode1l = new JObject { { "key", "value" } };

var model = new Test
{
    Testi = mode1l
};

var result = mapper.Map<TestViewModel>(model);


Console.WriteLine(result.Testi["key"]);