﻿namespace Umbraco.Cms.Core.DeliveryApi;

/// <summary>
///     Concrete implementation of content querying (e.g. based on Examine)
/// </summary>
public interface IApiContentQueryProvider
{
    /// <summary>
    ///     Returns a page of item ids that passed the search criteria.
    /// </summary>
    /// <param name="selectorOption">The selector option of the search criteria.</param>
    /// <param name="filterOptions">The filter options of the search criteria.</param>
    /// <param name="sortOptions">The sorting options of the search criteria.</param>
    /// <param name="culture">The requested culture.</param>
    /// <param name="skip">Number of search results to skip (for pagination).</param>
    /// <param name="take">Number of search results to retrieve (for pagination).</param>
    /// <param name="totalResultCount">The total number of results matching the search criteria (for pagination).</param>
    /// <returns>The result page of ids matching the search criteria.</returns>
    Guid[] ExecuteQuery(SelectorOption selectorOption, IList<FilterOption> filterOptions, IList<SortOption> sortOptions, string culture, int skip, int take, out long totalResultCount);

    /// <summary>
    ///     Returns a selector option that can be applied to fetch "all content" (i.e. if a selector option is not present when performing a search).
    /// </summary>
    SelectorOption AllContentSelectorOption();
}
