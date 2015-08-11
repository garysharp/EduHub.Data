﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EduHub.Data
{
    public abstract class EduHubContextBase
    {
        /// <summary>
        /// eduHub Data Set Directory
        /// </summary>
        public string EduHubDirectory { get; private set; }
        /// <summary>
        /// Data Set CSV Suffix
        /// </summary>
        public string EduHubSiteIdentifier { get; private set; }

        /// <summary>
        /// Default directory used when creating a context if none is provided to the constructor
        /// </summary>
        public static string DefaultEduHubDirectory { get; set; } = @"D:\eduHub";

        /// <summary>
        /// Default site identifier used when creating a context if none is provided to the constructor
        /// </summary>
        public static string DefaultEduHubSiteIdentifier { get; set; } = null;

        /// <summary>
        /// Creates an EduHubContextBase
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub CSV Data Sets</param>
        /// <param name="EduHubSiteIdentifier">Data Set Suffix for each CSV file</param>
        protected EduHubContextBase(string EduHubDirectory, string EduHubSiteIdentifier)
        {
            // Use default directory if none provided
            if (string.IsNullOrWhiteSpace(EduHubDirectory))
            {
                EduHubDirectory = DefaultEduHubDirectory;
            }

            // Use default identifier if none provided
            if (string.IsNullOrWhiteSpace(EduHubSiteIdentifier))
            {
                if (DefaultEduHubSiteIdentifier == null)
                {
                    DefaultEduHubSiteIdentifier = GetSiteIdentifier(EduHubDirectory);
                }
                EduHubSiteIdentifier = DefaultEduHubSiteIdentifier;
            }

            // Ensure directory exists
            if (!Directory.Exists(EduHubDirectory))
                throw new ArgumentException($"EduHub Directory [{EduHubDirectory}] does not exist");

            this.EduHubDirectory = EduHubDirectory;
            this.EduHubSiteIdentifier = EduHubSiteIdentifier;
        }

        /// <summary>
        /// Determines site identifiers which are present in the eduHub directory
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub CSV Data Sets</param>
        /// <returns>Enumerable of Site Identifiers</returns>
        /// <exception cref="ArgumentNullException"><see cref="EduHubDirectory"/> parameter is null</exception>
        /// <exception cref="ArgumentException">EduHub Directory does not exist</exception>
        public static IEnumerable<string> GetSiteIdentifiers(string EduHubDirectory)
        {
            if (string.IsNullOrWhiteSpace(EduHubDirectory))
                throw new ArgumentNullException(nameof(EduHubDirectory));
            if (!Directory.Exists(EduHubDirectory))
                throw new ArgumentException($"EduHub Directory [{EduHubDirectory}] does not exist");

            var testSiteIdentifier = new Regex(@".*_(.+).csv$", RegexOptions.IgnoreCase);
            var siteIdentifiers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var file in Directory.EnumerateFiles(EduHubDirectory, "*.csv"))
            {
                var match = testSiteIdentifier.Match(file);
                var siteIdentifier = match.Groups[1].Value;
                if (match.Success && siteIdentifiers.Add(siteIdentifier))
                {
                    yield return siteIdentifier;
                }
            }
        }

        /// <summary>
        /// Determines site identifiers which are present in the default eduHub directory
        /// </summary>
        /// <returns>Enumerable of Site Identifiers</returns>
        /// <exception cref="ArgumentException"><see cref="DefaultEduHubDirectory"/> does not exist</exception>
        /// <exception cref="ArgumentNullException"><see cref="DefaultEduHubDirectory"/> property is null</exception>
        public static IEnumerable<string> GetSiteIdentifiers()
        {
            if (string.IsNullOrWhiteSpace(DefaultEduHubDirectory))
                throw new ArgumentNullException(nameof(DefaultEduHubDirectory));

            return GetSiteIdentifiers(DefaultEduHubDirectory);
        }

        /// <summary>
        /// Determines a site identifier for the eduHub directory
        /// </summary>
        /// <param name="EduHubDirectory"></param>
        /// <returns>A site identifier</returns>
        /// <exception cref="ArgumentException">EduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        /// <exception cref="ArgumentNullException"><see cref="EduHubDirectory"/> parameter is null</exception>
        public static string GetSiteIdentifier(string EduHubDirectory)
        {
            if (string.IsNullOrWhiteSpace(EduHubDirectory))
                throw new ArgumentNullException(nameof(EduHubDirectory));

            var identifiers = GetSiteIdentifiers(EduHubDirectory).ToList();

            if (identifiers.Count == 0)
            {
                throw new ArgumentException("EduHub Directory [{EduHubDirectory}] contains no valid data sets.", nameof(EduHubDirectory));
            }
            else if (identifiers.Count > 1)
            {
                throw new ArgumentException("EduHub Directory [{EduHubDirectory}] contains data sets for multiple sites. Explicitly pass a site identifier.", nameof(EduHubDirectory));
            }

            return identifiers[0];
        }

        /// <summary>
        /// Determines a site identifier for the default eduHub directory
        /// </summary>
        /// <returns>A site identifier</returns>
        /// <exception cref="ArgumentException"><see cref="DefaultEduHubDirectory"/> does not exist, has no valid data sets or contains multiple data sets</exception>
        /// <exception cref="ArgumentNullException"><see cref="DefaultEduHubDirectory"/> property is null</exception>
        public static string GetSiteIdentifier()
        {
            if (string.IsNullOrWhiteSpace(DefaultEduHubDirectory))
                throw new ArgumentNullException(nameof(DefaultEduHubDirectory));

            return GetSiteIdentifier(DefaultEduHubDirectory);
        }
    }
}