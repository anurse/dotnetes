﻿using System.IO;
using System.Threading.Tasks;

namespace Dotnetes.CommandLine
{
    internal static class ResourceHelper
    {
        public static async Task<string> ReadResourceFileAsync(string relativeName)
        {
            var fullName = $"Dotnetes.CommandLine.Resources.{relativeName}";

            await using var input = typeof(ResourceHelper).Assembly.GetManifestResourceStream(fullName);
            if (input == null)
            {
                throw new FileNotFoundException($"Resource file '{fullName}' not found");
            }

            using var reader = new StreamReader(input);
            return await reader.ReadToEndAsync();
        }
    }
}
