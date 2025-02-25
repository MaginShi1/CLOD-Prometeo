﻿namespace ITS.Prometeo.ApplicationCore.Services;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class WeatherStationsService : IWeatherStationsService
{
    private readonly IWeatherStationsRepository _weatherStationsRepository;

    public WeatherStationsService(IWeatherStationsRepository weatherStationsRepository)
    {
        _weatherStationsRepository = weatherStationsRepository;
    }

    public Task<IEnumerable<WeatherStation>> GetListAsync()
    {
        return _weatherStationsRepository.GetListAsync();
    }

    public Task InsertAsync(WeatherStation station)
    {
        return _weatherStationsRepository.InsertAsync(station);
    }
}
