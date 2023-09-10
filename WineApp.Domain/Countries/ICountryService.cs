﻿using DataContract;

namespace WineApp.Domain.Countries
{
    public interface ICountryService
    {
        public Task<Result<PagedList<IEnumerable<Country>>>> GetAll(int page, int pageSize);

        public Task<Result<PagedList<IEnumerable<Country>>>> Search(string name, string isoCode, int page, int pageSize);

        public Task<Result<Country>> Get(int id);

        Task<Result<IEnumerable<CountryLookup>>> GetLookup();

        Task<Result> Put(Country country);

        Task<Result> Post(CountryInbound country);

        Task<Result> Delete(int countryId);
    }
}