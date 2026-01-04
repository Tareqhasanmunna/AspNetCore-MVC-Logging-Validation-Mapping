using AutoMapper;
using SerilogPractice.Models.ViewModels;
using SerilogPractice.Models.Entities;
using SerilogPractice.Models.DTOs;
namespace SerilogPractice.Mappings
{
    public class UserProfile: Profile
    {
        public UserProfile()
        { 
           CreateMap<UserRegisterViewModel, User>()

                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
            CreateMap<User, UserResponseDto>()
                .ForMember(dest => dest.Message, opt => opt.MapFrom(_ => "Registration Successful"));
                
        }
    }
}
