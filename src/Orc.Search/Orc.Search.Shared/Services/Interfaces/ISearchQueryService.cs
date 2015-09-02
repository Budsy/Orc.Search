﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISearchQueryService.cs" company="Wild Gums">
//   Copyright (c) 2008 - 2015 Wild Gums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Search
{
    using System.Collections.Generic;

    public interface ISearchQueryService
    {
        #region Methods
        string GetSearchQuery(string filter, IEnumerable<ISearchableMetadata> searchableMetadatas);
        string GetSearchQuery(params ISearchableMetadataValue[] searchableMetadataValues);
        #endregion
    }
}