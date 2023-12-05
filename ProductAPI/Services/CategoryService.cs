﻿using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Entities;
using ProductAPI.Responses;

namespace ProductAPI.Services
{
    public class CategoryService : IService
    {
        public readonly ProductContext _context;

        public CategoryService(ProductContext context)
        {
            _context = context;
        }
        
        public async Task<IResponseApi> GetById(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(cat => cat.Id == id);
            if (category != null)
                return new ResponseSuccess<Category>()
                {
                    Message = "Category found",
                    Response = category
                };
            
            string[] errors = { "There are no records with the id provided." };
            return new ResponseError()
            {
                Errors = errors,
                Message = "unexpected error"
            };

        }

        public Task<IResponseApi> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IResponseApi> Create()
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, object obj)
        {
            throw new NotImplementedException();
        }
    }
}