using Application.Contract.ArticleAgg.Commands___DTOs;
using AutoMapper;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ArticleAgg
{
    public class ArticleMappingProfile : Profile
    {
        public ArticleMappingProfile() 
        {
            CreateMap<Article, ArticleDTO>()
                .ForMember(dest => dest.Category,
                opt => opt.MapFrom(src => src.ArticleCategory.Title))
                .ForMember(dest => dest.JournalistFullName,
                opt => opt.MapFrom(src => src.Journalist.FirstName + src.Journalist.LastName));


        }
    }
}
