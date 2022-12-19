using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeManTours.Model;
using YoutubeManTours.View;
using YoutubeManTours.View.Hotels;

namespace YoutubeManTours.Coordinator
{
    public class ViewCoordinator
    {

        static public ViewCoordinator shared = new ViewCoordinator();

        public ToursView goToToursView(User user)
        {
            var view = new ToursView();
            view.configure(user);
            return view;
        }

        public HotelView goToHotelView()
        {
            return new HotelView();
        }

        public HotelEditInfoView goToHotelEditInfoView(HotelView fromView, Hotel hotel)
        {
            var view = new HotelEditInfoView();
            view.configure(fromView, hotel);
            return view;
        }

        public HotelAddView goToHotelAddView(HotelView fromView)
        {
            var view = new HotelAddView();
            view.configure(fromView);
            return view;
        }
    }
}
