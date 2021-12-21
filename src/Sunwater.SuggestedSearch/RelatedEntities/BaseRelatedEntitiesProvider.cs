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
        public BaseRelatedEntitiesProvider(EntityType entityType)
        {
            EntityType = entityType;
        }

        public abstract IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id);
        public List<DataStore.Document.Models.SuggestedSearch> searches = new List<DataStore.Document.Models.SuggestedSearch>();
        public RelatedEntitiesHelper relatedEntitiesHelper { get; set; }

        public IEnumerable<DataStore.Document.Models.SuggestedSearch> GetRelatedEntitiesSearches(ExecutionContext context, Entity entity)
        {
            if (entity.Type == EntityType)
            {
                var Log = context.Log;
                Log.LogInformation($"[Related Entities] GetRelatedEntitiesSearches({context}, {entity})");

                relatedEntitiesHelper = new RelatedEntitiesHelper(context, entity);

                foreach (var suggestedSearch in SuggestedSearches(entity.Id))
                {
                    try
                    {
                        if (RelatedEntitiesUtility.CypherFluentQueriesCount(suggestedSearch.SearchQuery, suggestedSearch.Tokens, context) > 0)
                            searches.Add(suggestedSearch);
                    }
                    catch (Exception ex)
                    {
                        Log.LogCritical(ex, "Error in executing Suggested Search: " + suggestedSearch.DisplayName);
                    }
                }

                return searches;
            }

            return new DataStore.Document.Models.SuggestedSearch[0];
        }
    }
}
