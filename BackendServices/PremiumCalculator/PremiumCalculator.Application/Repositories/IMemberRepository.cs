using PremiumCalculator.Domain.Entities;
using System.ComponentModel;

namespace PremiumCalculator.Application.Repositories
{
    public interface IMemberRepository
    {
        int AddMember(Member member);
        Member GetMemberById(int id);

    }
}
