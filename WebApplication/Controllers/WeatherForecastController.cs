using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[Route("[controller]")]
[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly IRepositoryManager _repository;
    private Company _company;
    private Employee _employee;
    public WeatherForecastController(IRepositoryManager repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        _repository.Company.UpdateCompany(_company);
        _repository.Employee.CreateEmployee(_employee);
        return new string[] { "value1", "value2" };
    }
}