using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HT.API.DAL.EF;

namespace HT.API.DAL.MemoryRepository
{
    public interface IMemoryRepository
    {

        Memory GetById(int id);
        List<Memory> GetAll();
        Task<Memory> Update(int id, Memory newMemory);
        Task Delete(int id);
        Task Insert(Memory memory);
        Task Archive(int id);

    }
}