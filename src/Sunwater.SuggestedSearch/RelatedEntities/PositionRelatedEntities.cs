using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Sunwater.Core.Constants;
using CluedIn.RelatedEntities2;

namespace CluedIn.SuggestedSearch.Sunwater.RelatedEntities
{
    public class PositionRelatedEntities : BaseRelatedEntitiesProvider
    {
        public PositionRelatedEntities() : base(SunwaterEntities.Position)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntity("Suggested Search", EntityEdgeType.OwnedBy),
                RelatedEntitiesHelper.GetRelationshipForEntityOfMultipleTypes("Suggested for Position and Organization", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Organization", EntityEdgeType.OwnedBy, EntityType.Organization),
                //relatedEntitiesHelper.GetRelationshipForEntityOfTypeFromEntityOfType("Suggested From Entity Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
                //relatedEntitiesHelper.GetRelationshipForEntityOfTypeToEntityOfType("Suggested To Entity Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
            };
        }
    }
}
