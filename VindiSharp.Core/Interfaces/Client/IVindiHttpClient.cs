﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Interfaces
{
    public interface IVindiHttpClient
    {
        String ApiVersion { get; set; }

        Uri BaseUri { get; set; }

        String ApiKey { get; set; }


        TResponse Do<TResponse>(String Resource, String NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, Dictionary<string, object> Parameters = null) where TResponse : class, new();
        TResponse Do<TEntity, TResponse>(String Resource, String NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, TEntity Parameters = null) where TResponse : class, new() where TEntity : class, IVindiEntity, new();

        void Do<TEntity>(String Resource, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, TEntity Parameters = null) where TEntity : class, IVindiEntity, new();
        Task DoAsync<TEntity>(String Resource, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, TEntity Parameter = null) where TEntity : class, IVindiEntity, new();

        Task<TResponse> DoAsync<TResponse>(String Resource, String NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, Dictionary<string, object> Parameters = null) where TResponse : class, new();

        Task<TResponse> DoAsync<TEntity, TResponse>(String Resource, String NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, TEntity Parameter = null) where TResponse : class, new() where TEntity : class, IVindiEntity, new();

    }
}