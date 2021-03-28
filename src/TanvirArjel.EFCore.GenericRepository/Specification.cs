﻿// <copyright file="Specification.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

namespace TanvirArjel.EFCore.GenericRepository
{
    /// <summary>
    /// This object hold the query specifications.
    /// </summary>
    /// <typeparam name="T">The database entity.</typeparam>
    public class Specification<T> : SpecificationBase<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets the value of number of entity you want to skip in your query.
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// Gets or sets the value of number of entity you want to take in your query.
        /// </summary>
        public int? Take { get; set; }
    }
}
