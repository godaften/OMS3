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

namespace OMS.Business.Repositories;

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
        obj.CreatedDate= DateTime.Now;

        var addedObj = _db.Bygninger.Add(obj);
        _db.SaveChanges();

        return _mapper.Map<Bygning, BygningDTO>(addedObj.Entity);

    }


    public int Delete(int id)
    {
        var obj = _db.Bygninger.FirstOrDefault(x => x.Id == id);
        
        if(obj != null)
        {
            _db.Bygninger.Remove(obj);
            return _db.SaveChanges();
        }
        return 0;
    }

    public BygningDTO Get(int id)
    {
        var obj = _db.Bygninger.FirstOrDefault(x => x.Id==id);
        if(obj != null)
        {
           return _mapper.Map<Bygning, BygningDTO>(obj);
        }
        return new BygningDTO();
    }

    public IEnumerable<BygningDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<Bygning>, IEnumerable<BygningDTO>>(_db.Bygninger);
    }

    public BygningDTO Update(BygningDTO objDTO)
    {
        var objFromDb = _db.Bygninger.FirstOrDefault(x => x.Id == objDTO.Id);
        if (objFromDb != null)
        {
            objFromDb.Navn = objDTO.Navn;
            _db.Bygninger.Update(objFromDb);
            _db.SaveChanges();
            return _mapper.Map<Bygning, BygningDTO>(objFromDb);
        }
        return objDTO;
    }
}
