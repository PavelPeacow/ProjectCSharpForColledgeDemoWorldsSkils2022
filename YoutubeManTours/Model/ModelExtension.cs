using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace YoutubeManTours.Model
{
    //Computed properties
    public partial class Tour
    {

        public string ImgPath
        {
            get
            {
                return "/Resources/" + this.Name + ".jpg";
            }
        }

        public string FullPrice
        {
            get
            {
                return Convert.ToString(this.Price) + "РУБ.";
            }
        }

        public string State
        {
            get
            {
                if (this.IsActual) return "Актуален";
                else return "Не актуален";
            }
        }

        public SolidColorBrush colorBrush
        {
            get
            {
                if (this.IsActual) return Brushes.Green;
                else return Brushes.Red;
            }
        }

        public string FullTicketCount
        {
            get
            {
                return "Билетов: " + this.TicketCount;
            }
        }

    }
}
