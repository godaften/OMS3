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

        public BygningRepository(AppDbContext db)
        {
            _db = db;
        }
        public BygningDTO Create(BygningDTO objDTO)
        {
            Bygning bygning = new Bygning()
            {
                Navn= objDTO.Navn,
                Id=objDTO.Id,
                CreatedDate=DateTime.Now
            };
            _db.Bygninger.Add(bygning);
            _db.SaveChanges();

            return new Bygning()
            {
                Navn = bygning.Navn,
                Id = bygning.Id
            };
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
