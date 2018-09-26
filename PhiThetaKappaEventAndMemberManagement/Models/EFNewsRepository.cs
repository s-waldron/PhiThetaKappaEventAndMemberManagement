using System.Collections.Generic;
using System.Linq;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class EFNewsRepository : INewsRepository
    {
        private ApplicationDbContext context;

        public EFNewsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }// end EFNewsRepository constructor

        public IEnumerable<News> News => context.News;

        public void SaveNews(News news)
        {
            if(news.NEWSID == 0)
            {
                context.News.Add(news);
            }// end if(news.NEWSID == 0) check
            else
            {
                News dbEntry = context.News
                    .FirstOrDefault(ne => ne.NEWSID == news.NEWSID);
                if(dbEntry != null)
                {
                    dbEntry.NewsArticleTitle = news.NewsArticleTitle;
                    dbEntry.NewsCreatedDate = news.NewsCreatedDate;
                    dbEntry.NewsArticle = news.NewsArticle;
                }// end if(dbEntry != null) check
            }// end else statement
        }// end SaveNews method
    }// end EFNewsRepository class
}// end PhiThetaKKappaEventAndMemberManagement.Models namespace