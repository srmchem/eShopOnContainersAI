﻿using Microsoft.eShopOnContainers.WebMVC.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.WebMVC.Services
{
    public interface ICatalogAIService
    {
        Task<List<CatalogItem>> GetRecommendationsAsync(string productId, string customerId);
        Task<string[]> AnalyzeImage(byte[] imageFile);
        Task<Catalog> GetCatalogItems(int page, int take, int? brand, int? type, IEnumerable<string> tags);
    }
}