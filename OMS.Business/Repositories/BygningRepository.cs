using AutoMapper;
using OMS.Business.Repositories.Interfaces;
using OMS.DataAccess;
using OMS.DataAccess.Data;
using OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Business.Repositories
{
    public class BygningRepository : IBygningRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public BygningRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public BygningDTO Create(BygningDTO objDTO)
        {
            var obj = _mapper.Map<BygningDTO, Bygning>(objDTO);

            var addedObj = _db.Bygninger.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<Bygning, BygningDTO>(addedObj.Entity);

        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BygningDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BygningDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BygningDTO Update(BygningDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
