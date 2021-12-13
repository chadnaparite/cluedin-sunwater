using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Sunwater.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.Sunwater.Factories
{
    public class SunwaterClueFactory : ClueFactory
    {
        public SunwaterClueFactory()
            : base(SunwaterConstants.CodeOrigin, SunwaterConstants.ProviderRootCodeValue)
        {
        }

        protected override Clue ConfigureProviderRoot([NotNull] Clue clue)
        {
            if (clue == null)
            {
                throw new ArgumentNullException(nameof(clue));
            }

            var data = clue.Data.EntityData;
            data.Name = SunwaterConstants.CrawlerName;
            data.Uri = new Uri(SunwaterConstants.Uri);
            data.Description = SunwaterConstants.CrawlerDescription;

            clue.ValidationRuleSuppressions.AddRange(new[] {RuleConstants.PROPERTIES_001_MustExist,});

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
                RuleConstants.METADATA_002_Uri_MustBeSet, RuleConstants.PROPERTIES_002_Unknown_VocabularyKey_Used
            });

            return clue;
        }
    }
}
