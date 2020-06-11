using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HT.API.DAL.EF;
using HT.API.DAL.MemoryRepository;

namespace HT.API.DAL
{
    public class MemoryBLL
    {
        IMemoryRepository _repo;
        private IMemoryRepository repo;

        public MemoryBLL(IMemoryRepository repo)
        {
            _repo = repo;
        }

        public Task Insert(Memory memory)
        {
            return _repo.Insert(memory);
        }

        public Memory GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Memory> GetAll()
        {
            return _repo.GetAll();
        }

        public Task<Memory> Update(int id, Memory newMemory)
        {
            return _repo.Update(id, newMemory);
        }

        public Task Delete(int id)
        {
            return _repo.Delete(id);
        }
        public Task Archive(int id){
            return _repo.Archive(id);
        }

    }
}