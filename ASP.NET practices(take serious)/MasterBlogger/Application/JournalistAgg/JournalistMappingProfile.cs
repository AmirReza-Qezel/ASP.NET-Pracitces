using Application.Contract.CommentAgg.Commands___DTOs;
using AutoMapper;
using Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JournalistAgg
{
    public class JournalistMappingProfile : Profile
    {
        public JournalistMappingProfile() {
            CreateMap<Comment, CommentDTO>();
        }
    }
}
