using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HT.API.DAL.EF;

namespace HT.API.DAL.MemoryRepository
{
    public class MemoryRepository : IMemoryRepository
    {
        HtContext _context;
        public MemoryRepository(HtContext context){
            _context = context;
        }

        public async Task Insert(Memory data)
        {
            try{
                _context.Memories.Add(data);
                await _context.SaveChangesAsync();
            }catch{
                throw new System.NotImplementedException();
            }
            
        }

        public Memory GetById(int id)
        {
            try{
                return _context.Memories.FirstOrDefault(m => m.Id == id);
            }catch{
                throw new System.NotImplementedException();
            }
        }
        public List<Memory> GetAll()
        {
            try
            {
                List<Memory> memo = _context.Memories.ToList();
                return memo;
            }catch
            {
                throw new System.NotImplementedException();
            }
        }
        public async Task<Memory> Update(int id,Memory newMemory)
        {

            try{
                var change = _context.Memories.FirstOrDefault(m => m.Id == id);
                change.Manufacturer = newMemory.Manufacturer;
                change.Type = newMemory.Type;
                change.ImgURL = newMemory.ImgURL;
                change.PurchasePrice = newMemory.PurchasePrice;
                change.SellingPrice = newMemory.SellingPrice;
                change.Socket = newMemory.Socket;
                change.MemorySize = newMemory.MemorySize;
                change.Size = newMemory.Size;
                change.Latency = newMemory.Latency;
                await _context.SaveChangesAsync();
                return _context.Memories.FirstOrDefault(m => m.Id == id);

            }catch{
                throw new System.NotImplementedException();
            }
        }

        public async Task Archive(int id)
        {
            try
            {
                var product = GetById(id);
                product.Archived = !product.Archived;
                await _context.SaveChangesAsync();
            }
            catch
            {
                
                throw new System.NotImplementedException();
            }
        }


        public async Task Delete(int id)
        {
            try{
                _context.Memories.Remove(_context.Memories.FirstOrDefault(m=>m.Id == id));
                await _context.SaveChangesAsync();
            }catch{
                throw new System.NotImplementedException();
            }
            
        }



    }
}