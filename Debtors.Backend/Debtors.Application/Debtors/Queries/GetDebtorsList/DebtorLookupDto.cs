using AutoMapper;
using Debtors.Application.Common.Mapping;
using Debtors.Domain.Entities;

namespace Debtors.Application.Debtors.Queries.GetDebtorsList
{
    public class DebtorLookupDto : IMapWith<Debtor>
    {
        public Guid Id { get; set; }
        public string DebtorName { get; set; }
        public string DebtorObject { get; set; }
        public DateTime? RepaymentDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Debtor, DebtorLookupDto>()
                .ForMember(debtorVm => debtorVm.Id, opt => opt.MapFrom(debtor => debtor.Id))
                .ForMember(debtorVm => debtorVm.DebtorName, opt => opt.MapFrom(debtor => debtor.DebtorName))
                .ForMember(debtorVm => debtorVm.DebtorObject, opt => opt.MapFrom(debtor => debtor.DebtorObject))
                .ForMember(debtorVm => debtorVm.RepaymentDate, opt => opt.MapFrom(debtor => debtor.RepaymentDate));
        }
    }
}
