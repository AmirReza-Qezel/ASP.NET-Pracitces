using Application.Contract.ArticleCategoryAgg.Commands___DTOs;
using Application.Contract.CommentAgg.Commands___DTOs;
using AutoMapper;
using Domain.ArticleCategoryAgg;
using Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CommentAgg
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Comment, CommentDTO>();
        }
    }
}
