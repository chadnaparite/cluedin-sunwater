using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.SuggestedSearch.Sunwater.RelatedEntities
{
    public class OrganizationRelatedEntities : BaseRelatedEntitiesProvider
    {
        public OrganizationRelatedEntities() : base(EntityType.Organization)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                relatedEntitiesHelper.GetRelationshipForEntity("Suggested Search", EntityEdgeType.OwnedBy),
                relatedEntitiesHelper.GetRelationshipForEntityOfMultipleTypes("Suggested for Basic Deails, Organization Unit Costing and Position", EntityEdgeType.OwnedBy, SunwaterEntities.BasicDetails, SunwaterEntities.OrganizationUnitCosting, SunwaterEntities.Position),
                relatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Basic Details", EntityEdgeType.OwnedBy, SunwaterEntities.BasicDetails),
                relatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Organization Unit Costing", EntityEdgeType.OwnedBy, SunwaterEntities.OrganizationUnitCosting),
                relatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position),
                //relatedEntitiesHelper.GetRelationshipForEntityOfTypeFromEntityOfType("Suggested From Entity Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
                //relatedEntitiesHelper.GetRelationshipForEntityOfTypeToEntityOfType("Suggested To Entity Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position, EntityType.Organization),
            };
        }
    }
}
