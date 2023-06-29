using AutoMapper;
using Debtors.Application.Common.Mapping;
using Debtors.Application.Debtors.Commands.CreateDebtors;

namespace Debtors.WebApi.Models
{
    public class CreateDebtorDto : IMapWith<CreateDebtorCommand>
    {
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string? Description { get; set; }
        public DateTime? RepaymentDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateDebtorDto, CreateDebtorCommand>()
                .ForMember(debtorCommand => debtorCommand.DebtorName,
                opt => opt.MapFrom(debtorDto => debtorDto.DebtorName))
                 .ForMember(debtorCommand => debtorCommand.DebtorObject,
                opt => opt.MapFrom(debtorDto => debtorDto.DebtorObject))
                  .ForMember(debtorCommand => debtorCommand.Description,
                opt => opt.MapFrom(debtorDto => debtorDto.Description))
                   .ForMember(debtorCommand => debtorCommand.RepaymentDate,
                opt => opt.MapFrom(debtorDto => debtorDto.RepaymentDate));
        }
    }
}
