using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{

    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public SubAbout GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
           return _subAboutDal.GetList();   
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
