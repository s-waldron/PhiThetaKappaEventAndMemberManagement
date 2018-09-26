using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public interface INewsRepository
    {
        IEnumerable<News> News { get; }

        void SaveNews(News news);
    }
}
