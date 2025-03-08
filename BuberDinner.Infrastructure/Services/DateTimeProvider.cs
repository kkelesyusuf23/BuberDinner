using BuberDinner.Application.Common.Interfaces.Services;
using System;

namespace BuberDinner.Infrastructure.Services;

public class DateTimeProvider:IDateTimeProvider{
    public DateTime UtcNow => DateTime.UtcNow;  
}