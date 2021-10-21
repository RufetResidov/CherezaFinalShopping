using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Helpers
{
    public class Pager
    {
        public Pager(int totalItems, int? page = 1, int recordSize = 10, int maxPages = 10)
        {
            // calculate total, start and end pages
            var totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)recordSize);
            if (!page.HasValue || page < 1)
            {
                page = 1;
            }
            else if (page > totalPages)
            {
                page = totalPages;
            }
            int startPage, endPage;
            if (totalPages <= maxPages)
            {
                startPage = 1;
                endPage = totalPages;

            }
            else
            {
                var maxPagesBeforeCurrentPage = (int)Math.Floor((decimal)maxPages / (decimal)2);
                var maxPagesAfterCurrentPage = (int)Math.Ceiling((decimal)maxPages / (decimal)2) - 1;
                if (page <= maxPagesBeforeCurrentPage)
                {
                    startPage = 1;
                    endPage = maxPages;
                }
                else if (page + maxPagesAfterCurrentPage >= totalPages)
                {
                    startPage = totalPages - maxPages + 1;
                    endPage = totalPages;
                }
                else
                {
                    startPage = page.Value - maxPagesBeforeCurrentPage;
                    endPage = page.Value - maxPagesAfterCurrentPage;
                }
            }
            //Calculate start end item indexs   
            var startIndex = (page.Value - 1) * recordSize;
            var endIndex = Math.Min(startIndex + recordSize - 1, totalItems - 1);

            var pages = Enumerable.Range(startPage, (endPage + 1) - startPage);
            TotalItems = totalItems;
            CurrentPage = page.Value;
            PageSize = recordSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
            StartIndex = startIndex;
            EndIndex = endIndex;
            Pages = pages;
        }

        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

        public IEnumerable<int> Pages { get; private set; }

    }
}
