using AutoMapper;
using Debtors.Application.Common.Mapping;
using Debtors.Domain.Entities;

namespace Debtors.Application.Debtors.Queries.GetDebtorDetails
{
    public class DebtorDetailsVm : IMapWith<Debtor>
    {
        public Guid Id { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public string? Description { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Debtor, DebtorDetailsVm>()
                .ForMember(debtorVm => debtorVm.Id, opt => opt.MapFrom(debtor => debtor.Id))
                .ForMember(debtorVm => debtorVm.DebtorName, opt => opt.MapFrom(debtor => debtor.DebtorName))
                .ForMember(debtorVm => debtorVm.DebtorObject, opt => opt.MapFrom(debtor => debtor.DebtorObject))
                .ForMember(debtorVm => debtorVm.Description, opt => opt.MapFrom(debtor => debtor.Description))
                .ForMember(debtorVm => debtorVm.RepaymentDate, opt => opt.MapFrom(debtor => debtor.RepaymentDate))
                .ForMember(debtorVm => debtorVm.CreationDate, opt => opt.MapFrom(debtor => debtor.CreationDate))
                .ForMember(debtorVm => debtorVm.EditDate, opt => opt.MapFrom(debtor => debtor.EditDate));
        }
    }
}
