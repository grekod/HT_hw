using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace HT.API.DAL.EF
{
    public class seedMemory
    {
        public static void SeedMemories(HtContext context)
        {
            if(!context.Memories.Any())
            {
                var memoryData = System.IO.File.ReadAllText("DAL/EF/MemoryDataSeed.json");
                var memories = JsonConvert.DeserializeObject<List<Memory>>(memoryData);

                foreach (var memo in memories)
                {
                    context.Memories.Add(memo);
                }

                context.SaveChanges();
            }
        }
    }
}