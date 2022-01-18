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
                RelatedEntitiesHelper.GetRelationshipForEntity("Suggested Search", EntityEdgeType.OwnedBy),
                RelatedEntitiesHelper.GetRelationshipForEntityOfMultipleTypes("Suggested for Basic Deails, Organization Unit Costing and Position", EntityEdgeType.OwnedBy, SunwaterEntities.BasicDetails, SunwaterEntities.OrganizationUnitCosting, SunwaterEntities.Position),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Basic Details", EntityEdgeType.OwnedBy, SunwaterEntities.BasicDetails),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Organization Unit Costing", EntityEdgeType.OwnedBy, SunwaterEntities.OrganizationUnitCosting),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Suggested for Position", EntityEdgeType.OwnedBy, SunwaterEntities.Position),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Superior Organization", "/SuperiorOrgOf", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 1", "/HierarchyLvl01", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 2", "/HierarchyLvl02", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 3", "/HierarchyLvl03", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 4", "/HierarchyLvl04", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 5", "/HierarchyLvl05", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 6", "/HierarchyLvl06", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 7", "/HierarchyLvl07", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 8", "/HierarchyLvl08", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 9", "/HierarchyLvl09", EntityType.Organization),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Hierarchy Level 10", "/HierarchyLvl10", EntityType.Organization),
            };
        }
    }
}
