using AutoMapper;
using Debtors.Application.Common.Mapping;
using Debtors.Application.Debtors.Commands.EditDebtor;

namespace Debtors.WebApi.Models
{
    public class EditDebtorDto : IMapWith<EditDebtorCommand>
    {
        public Guid Id { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string? Description { get; set; }
        public DateTime? RepaymentDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EditDebtorDto, EditDebtorCommand>()
                .ForMember(debtor => debtor.Id,
                    opt => opt.MapFrom(debtorDto => debtorDto.Id))
                .ForMember(debtor => debtor.DebtorName,
                    opt => opt.MapFrom(debtorDto => debtorDto.DebtorName))
                .ForMember(debtor => debtor.DebtorObject,
                    opt => opt.MapFrom(debtorDto => debtorDto.DebtorObject))
                .ForMember(debtor => debtor.Description,
                    opt => opt.MapFrom(debtorDto => debtorDto.Description))
                .ForMember(debtor => debtor.RepaymentDate,
                    opt => opt.MapFrom(debtorDto => debtorDto.RepaymentDate));
        }
    }
}
