﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{
    public class EFAbout2Dal: GenericRepository<About2>,IAbout2Dal
    {
    }
}
