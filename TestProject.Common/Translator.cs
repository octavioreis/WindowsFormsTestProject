using System;
using System.Collections.Generic;

namespace TestProject.Common
{
    public class Translator
    {
        private readonly Dictionary<string, string> _translatedValues =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "CommonGasoline", "Gasolina Comum" },
            { "AdditivatedGasoline", "Gasolina Aditivada" },
            { "Ethanol", "Etanol" },
            { "Diesel", "Diesel" },
        };

        private static Translator _instance { get; } = new Translator();
        private Translator() { }

        public static string Translate(string key)
        {
            if (_instance._translatedValues.ContainsKey(key))
                return _instance._translatedValues[key];

            return string.Empty;
        }
    }
}
