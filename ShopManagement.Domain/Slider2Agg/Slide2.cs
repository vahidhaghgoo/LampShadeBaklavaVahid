using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Slider2Agg
{
    public class Slide2 :EntityBase
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }

        public string PictureTitle { get; private set; }

        public string Title { get; private set; }

        public string Text { get; private set; }

        public string BtnText { get; private set; }
        public string Link { get; private set; }
        public bool IsRemoved { get; private set; }

        public Slide2(string picture, string pictureAlt,
            string pictureTitle, string title,
            string text, string link, string btnText)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
            IsRemoved = false;
        }
        public void Edit(string picture, string pictureAlt,
           string pictureTitle, string title,
           string text, string link, string btnText)
        {
            if (!string.IsNullOrWhiteSpace(picture))

                Picture = picture;


            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
        }
        public void Remove()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}

