﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
           //iş kodları
           return _categoryDal.GetAll();
        }

        //select * from Categories where CategoryId = 3
        public Category GetById(int categoryıd)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryıd);
        }

        List<Category> ICategoryService.GetById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
