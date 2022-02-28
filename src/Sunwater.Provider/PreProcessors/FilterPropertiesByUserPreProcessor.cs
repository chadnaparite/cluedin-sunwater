using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Processing.Processors.PreProcessing;
using Microsoft.Extensions.Logging;

namespace CluedIn.Provider.Sunwater.PreProcessors
{
    public class FilterPropertiesByUserPreProcessor : IPreProcessor
    {
        private readonly IVocabularyRepository vocabularyRepository;
        
        public FilterPropertiesByUserPreProcessor(IVocabularyRepository vocabularyRepository)
        {
            this.vocabularyRepository = vocabularyRepository;
        }
        
        public bool Accepts([NotNull] Core.ExecutionContext context, IEnumerable<IEntityCode> codes)
        {
            return true;
        }

        public void Process([NotNull] Core.ExecutionContext context, [NotNull] IEntityMetadataPart metadata, [CanBeNull] IDataPart data)
        {
            context.Log.LogDebug("[PreProcessor] FilterPropertiesByUserPreProcessor.Process Executed");

            var keys = metadata.Properties.Keys;
            
            var vocabularyKeys = vocabularyRepository.GetVocabularyKeys(keys.ToList());
            
            var uniqueVocabularies = vocabularyKeys.Select(s => s.VocabularyId).Distinct();
            
            var allowedVocabularies = new List<Guid>();
            
            foreach (var vocab in uniqueVocabularies)
            {
                var isOwner = vocabularyRepository.GetVocabularyOwners(vocab, null, context).Result;
                if (isOwner.Contains(context.Identity.UserId.ToString()))
                    allowedVocabularies.Add(vocab);
            }
            
            var allowedKeys = new List<string>();
            foreach (var key in allowedVocabularies)
            {
                allowedKeys.AddRange(vocabularyRepository.GetVocabulary(key).Keys.Select(s => s.ToString()));
            }
            
            var newProperties = metadata.Properties.Where(f => allowedKeys.Contains(f.Key));
            metadata.Properties.Clear();
            metadata.Properties.AddRange(newProperties);
        }
    }
}
