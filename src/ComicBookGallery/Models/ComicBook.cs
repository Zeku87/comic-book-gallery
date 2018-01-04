using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public Series Series { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
        public string DisplayText
        {
            get
            {
                if (Series != null)
                    return Series.Title + " #" + IssueNumber;
                else
                    return null;
            }
        }
        //series-title-issunumber.jpg
        public string CoverImageFileName
        {
            get
            {
                if (Series != null)
                    return Series.Title.Replace(" ", "-").ToLower()
                        + "-" + IssueNumber + ".jpg";
                else
                    return null;
            }
        }
    }
}