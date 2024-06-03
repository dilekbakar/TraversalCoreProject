using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
           return _featureDal.GetList();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
