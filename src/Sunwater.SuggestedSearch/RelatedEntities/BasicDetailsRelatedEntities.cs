using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Sunwater.Core.Constants;
using CluedIn.RelatedEntities2;

namespace CluedIn.SuggestedSearch.Sunwater.RelatedEntities
{
    public class BasicDetailsRelatedEntities : BaseRelatedEntitiesProvider
    {
        public BasicDetailsRelatedEntities() : base(SunwaterEntities.BasicDetails)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                relatedEntitiesHelper.GetRelationshipForEntity("Suggested Search", EntityEdgeType.OwnedBy),
                relatedEntitiesHelper.GetRelationshipForEntityOfMultipleTypes("Suggested for Position and Organization", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
                relatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position),
                relatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Organization", EntityEdgeType.OwnedBy, EntityType.Organization),
                relatedEntitiesHelper.GetRelationshipForEntityOfTypeFromEntityOfType("Suggested From Entity Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
                relatedEntitiesHelper.GetRelationshipForEntityOfTypeToEntityOfType("Suggested To Entity Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
            };
        }
    }
}
