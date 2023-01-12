using OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Business.Repositories.Interfaces;

public interface IBygningRepository
{
    public BygningDTO Create(BygningDTO objDTO);
    public BygningDTO Update(BygningDTO objDTO);
    public int Delete(int id);
    public BygningDTO Get(int id);
    public List<BygningDTO> GetAll();




}
