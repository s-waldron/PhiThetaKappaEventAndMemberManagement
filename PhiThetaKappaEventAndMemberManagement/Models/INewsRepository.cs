using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface INewsRepository
    {
        IEnumerable<News> News { get; }

        void SaveNews(News news);
    }
}
