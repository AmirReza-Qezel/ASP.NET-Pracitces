using Application.Contract.ArticleAgg.Commands___DTOs;
using Application.Contract.ArticleCategoryAgg.Commands___DTOs;
using AutoMapper;
using Domain.ArticleAgg;
using Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ArticleCategoryAgg
{
    public class ArticleCategoryMappingProfile : Profile
    {
        public ArticleCategoryMappingProfile()
        {
            CreateMap<ArticleCategory, ArticleCategoryDTO>();
        }
    }
}
