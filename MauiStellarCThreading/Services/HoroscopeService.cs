﻿using MauiStellarCThreading.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStellarCThreading.Services
{
    public class HoroscopeService
    {
        private HttpClient _client = new HttpClient();

        public HoroscopeService()
        {
            _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "18f5a624e0msha8f8a9383f69852p1a999fjsn6409c794f85f");
            _client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "best-daily-astrology-and-horoscope-api.p.rapidapi.com");
        }

        public async Task<Horoscope> getHoroscope(string zodiacSign)
        {
            string url = $"https://best-daily-astrology-and-horoscope-api.p.rapidapi.com/api/Detailed-Horoscope/?zodiacSign={zodiacSign}";
            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            Horoscope horoscope = JsonConvert.DeserializeObject<Horoscope>(jsonResponse);

            // Log the horoscope description to the console
            System.Diagnostics.Debug.WriteLine("Fetched Horoscope: ");
            System.Diagnostics.Debug.WriteLine($"Prediction: {horoscope.Prediction}");
            System.Diagnostics.Debug.WriteLine($"Number: {horoscope.Number}");
            System.Diagnostics.Debug.WriteLine($"Color: {horoscope.Color}");
            System.Diagnostics.Debug.WriteLine($"Mantra: {horoscope.Mantra}");
            System.Diagnostics.Debug.WriteLine($"Remedy: {horoscope.Remedy}");

            return horoscope;
        }
    }
}
