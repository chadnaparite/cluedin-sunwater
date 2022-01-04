using System;
using System.Collections.Generic;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.RelatedEntities;
using Microsoft.Extensions.Logging;

namespace CluedIn.SuggestedSearch.Sunwater.RelatedEntities
{
    public abstract class BaseRelatedEntitiesProvider : IRelatedEntitiesProvider
    {
        public readonly EntityType EntityType;
        public readonly string OriginName = null;

        public BaseRelatedEntitiesProvider(EntityType entityType)
        {
            EntityType = entityType;
        }
        public BaseRelatedEntitiesProvider(EntityType entityType, string originName) : this(entityType)
        {
            OriginName = originName;
        }

        public abstract IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id);
        public List<DataStore.Document.Models.SuggestedSearch> searches = new List<DataStore.Document.Models.SuggestedSearch>();
        public RelatedEntitiesHelper relatedEntitiesHelper { get; set; }

        public IEnumerable<DataStore.Document.Models.SuggestedSearch> GetRelatedEntitiesSearches(ExecutionContext context, Entity entity)
        {
            if (entity.Type == EntityType && (entity.OriginEntityCode.Origin == OriginName || OriginName == null))
            {
                var Log = context.Log;
                Log.LogInformation($"[Related Entities] {EntityType}{", " + OriginName}");

                relatedEntitiesHelper = new RelatedEntitiesHelper(context, entity);

                foreach (var suggestedSearch in SuggestedSearches(entity.Id))
                {
                    try
                    {
                        if (RelatedEntitiesUtility.CypherFluentQueriesCount(suggestedSearch.SearchQuery, suggestedSearch.Tokens, context) > 0)
                            searches.Add(suggestedSearch);
                        else
                            Log.LogInformation($"[Related Entities] No result. Query: '{suggestedSearch.SearchQuery}' Token: '{suggestedSearch.Tokens}'");
                    }
                    catch (Exception ex)
                    {
                        Log.LogCritical(ex, $"[Related Entities] Error in executing Suggested Search. Query: '{suggestedSearch.SearchQuery}' Token: '{suggestedSearch.Tokens}'");
                    }
                }

                return searches;
            }

            return new DataStore.Document.Models.SuggestedSearch[0];
        }
    }
}
