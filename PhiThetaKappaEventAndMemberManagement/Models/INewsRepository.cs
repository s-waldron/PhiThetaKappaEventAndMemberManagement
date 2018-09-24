using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface INewsRepository
    {
        IEnumerable<News> News { get; }

        void SaveNews(News news);
    }
}
