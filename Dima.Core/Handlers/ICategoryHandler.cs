﻿using Dima.Core.Models;
using Dima.Core.Requests.Categories;
using Dima.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsyc(GetCategoryByIdRequest request);
        Task<Response<List<Category?>>> GetAllAsyc(GetAllCategoriesRequest request);
    }
}
